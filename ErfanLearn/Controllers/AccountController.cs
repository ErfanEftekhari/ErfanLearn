using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.Services.Interface;
using ErfanLearn.Core.DTOs;
using ErfanLearn.DataLayer.Entities.User;
using ErfanLearn.Core.Generator;
using System;
using ErfanLearn.Core.Security;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using ErfanLearn.Core.Convertors;
using ErfanLearn.Core.Senders;

namespace ErfanLearn.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IViewRenderService _viewRender;
        public AccountController(IUserService userService,IViewRenderService viewRender)
        {
            _userService = userService;
            _viewRender = viewRender;
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(AccountViewModel model)
        {
            if(! ModelState.IsValid)
            {
                return View(model);
            }

            if(_userService.IsExistUserName(model.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری وارد شده معتبر نمی باشد.");
                return View(model);
            }

            if(_userService.IsExistEmail(model.Email))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده معتبر نمی باشد.");
                return View(model);
            }

            User user = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                ActiveCode = NameGenerator.GeneratorUniqCode(),
                UserAvatar = "Defult.jpg",
                IsActive = false,
                Password = PasswordHelper.EncodePasswordMd5(model.Password),
                RegisterDate = DateTime.Now,
            };
            _userService.CreateUser(user);

            #region Send Activation Email

            string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.Send(user.Email, "فعالسازی", body);

            #endregion

            return View("SuccessRegister",user);
        }


        [Route("Login")]
        public IActionResult Login(bool EditProfile = false)
        {
            if(EditProfile)
                ViewBag.EditProfile = true;

            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var user = _userService.LoginUser(model);
            if (user != null)
            {
                if (user.IsActive)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.Email, user.Email)
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);

                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد.");
                }
            }
            ModelState.AddModelError("Email","کاربری با مشخصات وارد شده یافت نشد.");
            return View(model);
        }

        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userService.ActiveAccount(id);
            return View();
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
        
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if(! ModelState.IsValid)
            {
                return View(model);
            }

            var user = _userService.GetUserByEmail(model.Email);
            
            if(user != null)
            {
                string body = _viewRender.RenderToStringAsync("_SendPassToEmail", user);
                SendEmail.Send(user.Email, "فرموشی رمز", body);
            }

            ViewBag.IsSend = true;
            return View();
        }

        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel 
            { 
                ActiveCode = id
            });
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            if(! _userService.ResetPassword(model))
                return NotFound();

            return Redirect("/Login");
        }
    }
}
