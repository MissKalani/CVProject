using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Entities
{
    public class Course :IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Education Education { get; set; }
        public int EducationId { get; set; }
    }
}
