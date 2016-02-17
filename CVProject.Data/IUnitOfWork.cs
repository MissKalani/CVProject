using CVProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Data
{
    public interface IUnitOfWork
    {
        ICourseRepository CourseRepository { get; }
        IEducationRepository EducationRepository { get; }
        IMaterialRepository MaterialRepository { get; }
        ISkillRepository SkillRepository { get; }
        ITechnologyRepository TechnologyRepository { get; }
        IWorkExperienceRepository WorkExperienceRepository { get; }

        void Save();
    }
}
