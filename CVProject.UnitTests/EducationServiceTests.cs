using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CVProject.Data.Repositories;
using FluentAssertions;
using NSubstitute;
using CVProject.Data;
using CVProject.Services;


namespace CVProject.UnitTests
{
    [TestClass]
    public class EducationServiceTests
    {
        [TestMethod]
        public void WillReturnAllEducation()
        {
            //Arrange
            var educationList = new List<Entities.Education>();
            educationList.Add(new Entities.Education
            {
                Title = "Bachelor of Science in Civil Engineering",
                School = "Southwestern University, Philippines",
                StartDate = new DateTime(1998, 6, 1),
                EndDate = new DateTime(2003, 5, 1)
            });
            educationList.Add(new Entities.Education
            {
                Title = "Systems Science",
                School = "Dalarna University, Sweden",
                StartDate = new DateTime(2012, 8, 1),
                EndDate = new DateTime(2015, 6, 1)
            });

            IEducationRepository edRepository = Substitute.For<IEducationRepository>();
            edRepository.GetAllEducation().Returns(educationList);

            IUnitOfWork uow = Substitute.For<IUnitOfWork>();
            uow.EducationRepository.Returns(edRepository);

            EducationService edService = new EducationService(uow);
            //Act
            var educationServiceList = edService.GetAllEducation();
            //Assert
            educationServiceList.Should().NotBeNull();
        }
    }
}
