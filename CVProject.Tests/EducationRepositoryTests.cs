using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVProject.Data;
using FluentAssertions;

namespace CVProject.Tests
{
    [TestClass]
    public class EducationRepositoryTests
    {
        [TestMethod]
        public void GetAllEducationReturnsNotNull()
        {
            using (var context = new CVProjectContext())
            {
                var uow = new UnitOfWork(context);
                var educationList = uow.EducationRepository.GetAllEducation();
                educationList.Should().NotBeNull();
            }

        }
    }
}
