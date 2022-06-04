using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.Services.Interface;

namespace ErfanLearn.Core.Security
{
    public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private IPermissionService _permissionService;
        private string _permissionName;
        public PermissionCheckerAttribute(string PermissionName)
        {
            _permissionName = PermissionName;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService = 
                (IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));

            if(context.HttpContext.User.Identity.IsAuthenticated)
            {
                if(! _permissionService.CheckPermission(_permissionName,context.HttpContext.User.Identity.Name))
                {
                    context.Result = new RedirectResult("/Logout");
                }
            }
            else
            {
                context.Result = new RedirectResult("/Login");
            }
        }
    }
}
