using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Data.Mapping
{
    public class AssociateSalaryMap : EfEntityTypeConfiguration<AssociateSalary>
    {
        public AssociateSalaryMap()
        {
            this.ToTable(nameof(AssociateSalary), "Chapter03");
            this.HasKey(s => s.SalaryId);

            this.HasRequired<Associate>(a => a.Associate)
                .WithMany(s => s.AssociateSalaries)
                .HasForeignKey<int>(a => a.AssociateId);

        }
    }
}
