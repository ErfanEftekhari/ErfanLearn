using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Entities.Course;
using System;
using System.Collections.Generic;
using ErfanLearn.DataLayer.Context;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using ErfanLearn.Core.Generator;
using ErfanLearn.Core.DTOs;

namespace ErfanLearn.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly ErfanLearnContext _context;
        public CourseService(ErfanLearnContext context)
        {
            _context = context;
        }



        public List<CourseGroup> GetAllGroup()
        {
            return _context.courseGroups.ToList();
        }

        //ToDo Dont Select Deleted
        public List<SelectListItem> GetAllOriginalGroup()
            => _context.courseGroups.Where(x => x.ParentId == null)
                    .Select(x => new SelectListItem
                    {
                        Text = x.GroupTitle,
                        Value = x.GroupId.ToString()
                    }).ToList();

        public List<SelectListItem> GetChildGroup(int groupId)
            => _context.courseGroups.Where(x => x.ParentId == groupId)
                    .Select(x => new SelectListItem
                    {
                        Text = x.GroupTitle,
                        Value = x.GroupId.ToString()
                    }).ToList();

        public List<SelectListItem> GetLevels()
        {
            return _context.CourseLevel
                    .Select(x => new SelectListItem
                    {
                        Text = x.LevelTitle,
                        Value = x.LevelId.ToString()
                    }).ToList();
        }

        public List<SelectListItem> GetStatus()
        {
            return _context.CourseStatus.Select(_ => new SelectListItem()
            {
                Text = _.StatusTitle,
                Value = _.StatusId.ToString()
            }).ToList();
        }

        public List<SelectListItem> GetTeachers(int id = 2)
            => _context.UserRoles.Where(x => x.RoleId == 2)
                                .Include(x => x.User)
                                .Select(x => new SelectListItem
                                {
                                    Text = x.User.UserName,
                                    Value = x.User.UserId.ToString()

                                }).ToList();

        public int CreateCource(Course course, IFormFile demo, IFormFile imgCourse)
        {
            course.CreateDate = DateTime.Now;
            course.CourseImageName = "no-photo.jpg";
            //TODO Check Image
            if (imgCourse != null)
            {
                course.CourseImageName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/image", course.CourseImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }
            }

            //ToDO Upload Demo 

            _context.Add(course);
            _context.SaveChanges();

            return course.CourseId;
        }

        public List<ShowCourseForAdminViewModel> ShowCourcesForAdmin()
            => _context.Courses.Select(_ => new ShowCourseForAdminViewModel()
            {
                CourseId = _.CourseId,
                EpisodeCount = _.CourseEpisodes.Count(),
                ImageName = _.CourseImageName,
                Title = _.CourseTitle

            }).ToList();
    }
}
