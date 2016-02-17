using CVProject.Data.Repositories;

namespace CVProject.Data.Repositories
{
    internal class WorkExperienceRepository : IWorkExperienceRepository
    {
        private CVProjectContext context;

        public WorkExperienceRepository(CVProjectContext context)
        {
            this.context = context;
        }
    }
}