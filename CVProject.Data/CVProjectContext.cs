using CVProject.Data.Configurations;
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
        public IDbSet<Material> MaterialsSet { get; set; }
        public IDbSet<Education> EducationSet { get; set; }
        public IDbSet<Technology> TechnologySet { get; set; }
        public IDbSet<Skill> SkillSet { get; set; }
        public IDbSet<WorkExperience> WorkExperienceSet { get; set; }
        public IDbSet<Course> CourseSet { get; set; }

        public CVProjectContext()
            : base("CVProjectContext")
        {
            Database.SetInitializer<CVProjectContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new EducationConfiguration());
            modelBuilder.Configurations.Add(new SkillConfiguration());
            modelBuilder.Configurations.Add(new TechnologyConfiguration());
            modelBuilder.Configurations.Add(new MaterialConfiguration());
            modelBuilder.Configurations.Add(new WorkExperienceConfiguration());
        }

    }
}
