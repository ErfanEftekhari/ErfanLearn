﻿using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.Services.Interface;
using ErfanLearn.Core.DTOs;
using ErfanLearn.DataLayer.Entities.User;
using ErfanLearn.Core.Generator;
using System;
using ErfanLearn.Core.Security;

namespace ErfanLearn.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
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

            return View("SuccessRegister",user);
        }
    }
}
