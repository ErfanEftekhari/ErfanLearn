using Microsoft.AspNetCore.Mvc.RazorPages;
using ErfanLearn.Core.DTOs;
using ErfanLearn.Core.Services.Interface;
using System.Collections.Generic;
using ErfanLearn.DataLayer.Entities.User;

namespace ErfanLearn.Web.Pages.Admin.Roles
{
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;

        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Role> Roles { get; set; }

        public void OnGet()
        {
            Roles = _permissionService.GetRoles();
        }


    }
}