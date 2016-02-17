using CVProject.Data.Repositories;

namespace CVProject.Data.Repositories
{
    internal class SkillRepository : ISkillRepository
    {
        private CVProjectContext context;

        public SkillRepository(CVProjectContext context)
        {
            this.context = context;
        }
    }
}