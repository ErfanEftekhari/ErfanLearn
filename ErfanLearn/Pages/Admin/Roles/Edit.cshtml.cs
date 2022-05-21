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
            loadRelatedData(id);
        }

        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
            {
                loadRelatedData(Role.RoleId);
                return Page();
            }

            //Edit Role
            Role.Status = IsActive == true ? Enum.Status.Enabled : Enum.Status.Disabled;
            var result = _permissionService.EditRole(Role);
            if (!result)
            {
                loadRelatedData(Role.RoleId);
                return Page();
            }

            //Edit permission
            //To Do Role Is Empty 
            if (!_permissionService.EditPermissionsToRole(SelectedPermission, Role.RoleId))
            {
                loadRelatedData(Role.RoleId);
                return Page();
            }

            return Redirect("/admin/roles");
        }

        private void loadRelatedData(int roleId)
        {
            Role = _permissionService.GetRoleById(roleId);
            IsActive = Role.Status == Enum.Status.Enabled ? true : false;
            ViewData["Permissions"] = _permissionService.GetPermissions();
            ViewData["SelectedPermissions"] = _permissionService.GetPermissionsByRoleId(roleId);
        }
    }
}
