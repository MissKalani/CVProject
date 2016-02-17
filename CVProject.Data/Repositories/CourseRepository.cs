using System;
using System.Collections.Generic;
using CVProject.Data.Repositories;
using CVProject.Entities;

namespace CVProject.Data.Repositories
{
    internal class CourseRepository : ICourseRepository
    {
        private CVProjectContext context;

        public CourseRepository(CVProjectContext context)
        {
            this.context = context;
        }

        public List<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }
    }
}