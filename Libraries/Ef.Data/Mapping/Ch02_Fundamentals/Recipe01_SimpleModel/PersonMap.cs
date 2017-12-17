using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Data.Mapping
{
    public class PersonMap : EfEntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            this.ToTable(nameof(Person), "Chapter02");
            this.HasKey(p => p.Id);

            this.Property(p => p.FirstName).HasMaxLength(64);
            this.Property(p => p.MiddleName).HasMaxLength(64);
            this.Property(p => p.LastName).HasMaxLength(64);
            this.Property(p => p.PhoneNumber).HasMaxLength(32);
        }
    }
}
