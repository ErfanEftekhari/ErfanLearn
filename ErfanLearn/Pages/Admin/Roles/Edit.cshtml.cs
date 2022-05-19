using ErfanLearn.Core.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErfanLearn.Core.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ErfanLearn.DataLayer.Entities.User;

namespace ErfanLearn.Web.Pages.Admin.Roles
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
        public Role Role { get; set; }

        [BindProperty]
        public bool IsActive { get; set; }

        public void OnGet(int id)
        {
            Role = _permissionService.GetRoleById(id);
            IsActive = Role.Status == Enum.Status.Enabled ? true : false;
            //ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                Role = _permissionService.GetRoleById(Role.RoleId);
                //ViewData["Roles"] = _permissionService.GetRoles();
                return Page();
            }

            //Edit Role
            Role.Status = IsActive == true ? Enum.Status.Enabled : Enum.Status.Disabled;
            var result = _permissionService.EditRole(Role);
            if (!result)
            {
                //ViewData["Roles"] = _permissionService.GetRoles();
                return Page();
            }

            //Edit Role
            //To Do Role Is Empty 
            //if (!_permissionService.EditRolesUser(SelectedRoles, Model.UserId))
            //{
            //    ViewData["Roles"] = _permissionService.GetRoles();
            //    return Page();
            //}

            return Redirect("/admin/roles");
        }
    }
}
