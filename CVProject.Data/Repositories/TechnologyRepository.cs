using CVProject.Data.Repositories;

namespace CVProject.Data.Repositories
{
    internal class TechnologyRepository : ITechnologyRepository
    {
        private CVProjectContext context;

        public TechnologyRepository(CVProjectContext context)
        {
            this.context = context;
        }
    }
}