using ErfanLearn.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErfanLearn.Core.Services.Interface;
using System.Collections.Generic;

namespace ErfanLearn.Web.Pages.Admin.Users
{
    public class CreateModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IPermissionService _permissionService;
        public CreateModel(IPermissionService permissionService , IUserService userService)
        {
            _permissionService = permissionService;
            _userService = userService;
        }
        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }
        
        public void OnGet()
        {
            //GetRoles
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            //Add user

            var result = _userService.AddUserByAdmin(CreateUserViewModel);
            if(result == 0)
            {
                return Page();

            }

            //Add Role

            if(!_permissionService.AddRolesToUser(SelectedRoles,result))
            {
                return Page();
            }

            return Redirect("/admin/users");
        }
    }
}
