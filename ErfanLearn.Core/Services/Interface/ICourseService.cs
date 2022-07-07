using ErfanLearn.Core.DTOs;
using ErfanLearn.DataLayer.Entities.Course;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ErfanLearn.Core.Services.Interface
{
    public interface ICourseService
    {
        List<CourseGroup> GetAllGroup();

        List<SelectListItem> GetAllOriginalGroup();

        List<SelectListItem> GetChildGroup(int groupId);

        List<SelectListItem> GetTeachers(int id = 2);

        List<SelectListItem> GetLevels();

        List<SelectListItem> GetStatus();

        int CreateCource(Course course, IFormFile demo, IFormFile imgCourse);

        List<ShowCourseForAdminViewModel> ShowCourcesForAdmin(); 
    }
}
