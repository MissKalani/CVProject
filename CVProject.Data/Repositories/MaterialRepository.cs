using CVProject.Data.Repositories;

namespace CVProject.Data.Repositories
{
    internal class MaterialRepository : IMaterialRepository
    {
        private CVProjectContext context;

        public MaterialRepository(CVProjectContext context)
        {
            this.context = context;
        }
    }
}