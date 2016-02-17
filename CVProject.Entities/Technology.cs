using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Entities
{
    public class Technology : IEntityBase
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public  List<Material>  Materials { get; set; }
    }
}
