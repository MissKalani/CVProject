using CVProject.Data.Repositories;
using CVProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CVProject.Data.Repositories
{
    internal class EducationRepository : IEducationRepository
    {
        private CVProjectContext context;

        public EducationRepository(CVProjectContext context)
        {
            this.context = context;
        }
        public List<Education> GetAllEducation()
        {
            return context.EducationSet.ToList();
        }
    }
}