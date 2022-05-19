using ErfanLearn.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErfanLearn.Core.Services.Interface;
using System.Collections.Generic;
using ErfanLearn.DataLayer.Entities.User;

namespace ErfanLearn.Web.Pages.Admin.Roles
{
    public class CreateModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IPermissionService _permissionService;
        public CreateModel(IPermissionService permissionService, IUserService userService)
        {
            _permissionService = permissionService;
            _userService = userService;
        }
        [BindProperty]
        public Role role { get; set; }

        public void OnGet()
        {
            //Getpermision
            //ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Add Role

            var result = _permissionService.CreateRole(role);
            if (result == 0)
            {
                return Page();

            }

            return Redirect("/admin/roles");
        }
    }
}
