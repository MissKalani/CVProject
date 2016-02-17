using CVProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Data
{
    public class CVProjectContext : DbContext
    {
        IDbSet<Material> MaterialsSet { get; set; }
        IDbSet<Education> EducationSet { get; set; }
        IDbSet<Technology> TechnologySet { get; set; }
        IDbSet<Skill> SkillSet { get; set; }
        IDbSet<WorkExperience> WorkExperienceSet { get; set; }
        IDbSet<Course> CourseSet { get; set; }

        public CVProjectContext()
            : base("CVProjectContext")
        {
            Database.SetInitializer<CVProjectContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
