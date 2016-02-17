using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVProject.Data.Repositories;

namespace CVProject.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public ICourseRepository CourseRepository { get; }

        public IEducationRepository EducationRepository { get; }
        public IMaterialRepository MaterialRepository { get; }
        public ISkillRepository SkillRepository { get; }
        public ITechnologyRepository TechnologyRepository { get; }
        public IWorkExperienceRepository WorkExperienceRepository { get; }

        private CVProjectContext CVProjectContext { get; }
      
        public UnitOfWork()
            :this(new CVProjectContext())
        { }
        public UnitOfWork(CVProjectContext context)
        {
            this.CVProjectContext = context;
            SkillRepository = new SkillRepository(context);
            TechnologyRepository = new TechnologyRepository(context);
            MaterialRepository = new MaterialRepository(context);
            CourseRepository = new CourseRepository(context);
            WorkExperienceRepository = new WorkExperienceRepository(context);
            EducationRepository = new EducationRepository(context);
        }
        public void Save()
        {
            CVProjectContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {

            if (CVProjectContext != null)
                CVProjectContext.Dispose();
        }
    }
}
