using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Entities.Course;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ErfanLearn.Web.Pages.Admin.Courses
{
    public class CreateModel : PageModel
    {

        private readonly ICourseService _courseService;
        public CreateModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Course Course { get; set; }

        [BindProperty]
        public List<SelectListItem> OriginalGroup { get; set; }

        [BindProperty]
        public List<SelectListItem> Teachers { get; set; }

        [BindProperty]
        public List<SelectListItem> Levels { get; set; }

        [BindProperty]
        public List<SelectListItem> Status { get; set; }

        public void OnGet()
        {
            OriginalGroup = _courseService.GetAllOriginalGroup();
            Teachers = _courseService.GetTeachers();
            Levels = _courseService.GetLevels();
            var statues = _courseService.GetStatus();
            ViewData["Statues"] = new SelectList(statues, "Value", "Text");
        }

        public IActionResult OnPost(IFormFile demoUp , IFormFile imgCourseUp)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var result = _courseService.CreateCource(Course, demoUp, imgCourseUp);

            return Page();
        }
    }
}
