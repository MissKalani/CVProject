using CVProject.Data.Repositories;

namespace CVProject.Data.Repositories
{
    internal class EducationRepository : IEducationRepository
    {
        private CVProjectContext context;

        public EducationRepository(CVProjectContext context)
        {
            this.context = context;
        }
    }
}