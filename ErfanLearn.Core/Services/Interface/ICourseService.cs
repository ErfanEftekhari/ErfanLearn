using ErfanLearn.DataLayer.Entities.Course;
using System.Collections.Generic;

namespace ErfanLearn.Core.Services.Interface
{
    public interface ICourseService
    {
        List<CourseGroup> GetAllGroup();
    }
}
