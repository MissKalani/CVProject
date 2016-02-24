using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVProject.Entities;
using CVProject.Data;

namespace CVProject.Services
{
    public class EducationService : IEducationService
    {
        private IUnitOfWork uow;
        public EducationService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public List<Education> GetAllEducation()
        {
            return uow.EducationRepository.GetAllEducation();
        }
    }
}
