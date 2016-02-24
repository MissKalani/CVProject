using CVProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Services
{
    public interface IEducationService
    {
        List<Education> GetAllEducation();
    }
}
