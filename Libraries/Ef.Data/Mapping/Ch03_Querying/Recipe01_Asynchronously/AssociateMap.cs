using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Data.Mapping
{
    public class AssociateMap : EfEntityTypeConfiguration<Associate>
    {
        public AssociateMap()
        {
            this.ToTable(nameof(Associate), "Chapter03");
            this.HasKey(a => a.AssociateId);

            this.Property(a => a.Name).HasMaxLength(64).IsRequired();
        }
    }
}
