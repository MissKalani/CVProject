using CVProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Data.Configurations
{
    public class WorkExperienceConfiguration:EntityBaseConfiguration<WorkExperience>
    {
        public WorkExperienceConfiguration()
        {
            Property(u => u.Title).IsRequired();
            Property(u => u.Description).IsOptional();
            Property(u => u.Organization).IsRequired();
            Property(u => u.StartDate).IsOptional();
            Property(u => u.EndDate).IsOptional();
        }
    }
}
