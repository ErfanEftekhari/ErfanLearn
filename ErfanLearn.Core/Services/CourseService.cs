using ErfanLearn.Core.Services.Interface;
using ErfanLearn.DataLayer.Entities.Course;
using System;
using System.Collections.Generic;
using ErfanLearn.DataLayer.Context;
using System.Linq;

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
    }
}
