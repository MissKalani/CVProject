using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Entities
{
    public class Material : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }
    }
}
