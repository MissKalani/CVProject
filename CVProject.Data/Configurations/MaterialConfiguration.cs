using CVProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Data.Configurations
{
    public class MaterialConfiguration: EntityBaseConfiguration<Material>
    {
        public MaterialConfiguration()
        {
            Property(u => u.Name).IsRequired();         
        }
    }
}
