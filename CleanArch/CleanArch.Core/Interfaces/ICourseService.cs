using CleanArch.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Core.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
