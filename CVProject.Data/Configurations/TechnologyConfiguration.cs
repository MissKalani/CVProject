using CVProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Data.Configurations
{
    public class TechnologyConfiguration: EntityBaseConfiguration<Technology>
    {
        public TechnologyConfiguration()
        {
            Property(u => u.Name).IsRequired();
            HasMany(u => u.Materials).WithRequired(u=>u.Technology).HasForeignKey(s => s.TechnologyId);
        }
    }
}
