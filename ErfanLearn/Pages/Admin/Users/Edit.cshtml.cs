using ErfanLearn.Core.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErfanLearn.Core.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ErfanLearn.Web.Pages.Admin.Users
{
    public class EditModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        public EditModel(IUserService userService,IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }
        [BindProperty]
        public EditUserViewModel Model { get; set; }
        public void OnGet(int id)
        {
            Model = _userService.GetUserForShow(id);
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                Model = _userService.GetUserForShow(Model.UserId);
                ViewData["Roles"] = _permissionService.GetRoles();
                return Page();
            }

            //Edit user

            var result = _userService.EditUSer(Model);
            if (!result)
            {
                ViewData["Roles"] = _permissionService.GetRoles();
                return Page();
            }

            //Edit Role

            if (!_permissionService.EditRolesUser(SelectedRoles, Model.UserId))
            {
                ViewData["Roles"] = _permissionService.GetRoles();
                return Page();
            }

            return Redirect("/admin/users");
        }
    }
}
