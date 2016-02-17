using CVProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Data.Configurations
{
    public class EducationConfiguration:EntityBaseConfiguration<Education>
    {
        public EducationConfiguration()
        {
            Property(u => u.Title).IsRequired();
            Property(u => u.School).IsRequired();
            Property(u => u.StartDate).IsOptional();
            Property(u => u.EndDate).IsOptional();
            HasMany(u => u.Courses).WithRequired(u=>u.Education).HasForeignKey(s => s.EducationId);
        }
    }
}
