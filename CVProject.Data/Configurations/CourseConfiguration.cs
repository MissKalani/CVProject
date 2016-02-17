using CVProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Data.Configurations
{
    public class CourseConfiguration : EntityBaseConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(u => u.Name).IsRequired();
            Property(u => u.EducationId).IsRequired();             
        }
    }
}
