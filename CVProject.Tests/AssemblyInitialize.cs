using CVProject.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Tests
{
    [TestClass]
    public class AssemblyInitialize
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext testContext)
        {
            var context = new CVProjectContext();
            context.Database.Delete();

            var config = new TestMigrationConfiguration();
            var migrator = new DbMigrator(config);
            migrator.Update();

        }
        [AssemblyCleanup]
        public static void CleanUp()
        {
            var context = new CVProjectContext();
            context.Database.Delete();
        }
    }
}
