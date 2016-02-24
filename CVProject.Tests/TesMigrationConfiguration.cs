using CVProject.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Tests
{
    internal class TestMigrationConfiguration : DbMigrationsConfiguration<CVProjectContext>
    {
        public TestMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsAssembly = Assembly.GetAssembly(typeof(CVProjectContext));
            MigrationsNamespace = "CVProject.DataModels.Migrations";
        }

        protected override void Seed(CVProjectContext context)
        {
            var education = new List<Entities.Education>();
            education.Add(context.EducationSet.Add(new Entities.Education
            {
                Title = "Bachelor of Science in Civil Engineering",
                School = "Southwestern University, Philippines",
                StartDate = new DateTime(1998, 6, 1),
                EndDate = new DateTime(2003, 5, 1)
            }));
            education.Add(context.EducationSet.Add(new Entities.Education
            {
                Title = "Systems Science",
                School = "Dalarna University, Sweden",
                StartDate = new DateTime(2012, 8, 1),
                EndDate = new DateTime(2015, 6, 1)
            }));
        }
    }
}
