using ErfanLearn.Core.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ErfanLearn.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/request")]
    [ApiController]
    public class RequestController : Controller
    {
        private readonly ICourseService _courseService;
        public RequestController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("[action]/{groupId}")]
        public IActionResult GetChildGroup(int groupId)
        {
            var result = _courseService.GetChildGroup(groupId);
            return Json(new SelectList(result , "Value" , "Text"));
        }
    }
}
