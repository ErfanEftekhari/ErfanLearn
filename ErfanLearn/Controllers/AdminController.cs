using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.Services.Interface;

namespace ErfanLearn.Web.API
{
    [Produces("application/json")]
    [Route("api/admin")]
    [ApiController]
    public class AdminController : Controller
    {

        private IUserService _userService;
        public IPermissionService _permissionService;
        public AdminController(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        [HttpPost("/users/[action]/{id}")]
        public IActionResult Delete(int id)
        {
            //Todo Dont Delete Own
            var result = _userService.SoftDeleteUser(id); 
            return new JsonResult(new
            {
                data = result
            });
        }

        [HttpPost("roles/[action]/{id}")]
        public IActionResult DeleteRole(int id)
        {
            //Todo Dont Delete Own
            var result = _permissionService.SoftDeleteRole(id);
            return new JsonResult(new
            {
                data = result
            });
        }
    }
}
