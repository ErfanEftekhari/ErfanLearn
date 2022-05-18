using Microsoft.AspNetCore.Mvc;
using ErfanLearn.Core.Services.Interface;

namespace ErfanLearn.Web.API
{
    [Produces("application/json")]
    [Route("api/admin/users")]
    [ApiController]
    public class AdminController : Controller
    {

        private IUserService _userService;
        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _userService.SoftDeleteUser(id); 
            return new JsonResult(new
            {
                data = result
            });
        }
    }
}
