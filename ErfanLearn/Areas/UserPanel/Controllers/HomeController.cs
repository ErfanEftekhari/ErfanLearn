using ErfanLearn.Core.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.DTOs;

namespace ErfanLearn.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile ()
        {
            var model = _userService.GetDataForEditProfileUser(User.Identity.Name);
            return View(model);
        }

        [Route("UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel model)
        {
            model.LastUserName = User.Identity.Name;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if(! _userService.EditProfile(model))
            {
                ModelState.AddModelError("Email", "خطایی به وجود آمده است.");
                return View(model);
            }
            //TODO Email Is Activ
            return Redirect("/Login?EditProfile=true");
        }
    }
}