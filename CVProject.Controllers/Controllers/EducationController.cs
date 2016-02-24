using CVProject.Data;
using CVProject.Entities;
using CVProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CVProject.Controllers.Controllers
{
    public class EducationController : ApiController
    {
        IEducationService educationService = new EducationService(new UnitOfWork());

        // GET: api/education
        [ResponseType(typeof(List<Education>))]
        public IHttpActionResult GetAllEducation()
        {
            var educationList = educationService.GetAllEducation();
            return Ok(educationList);
        }
    }
}
