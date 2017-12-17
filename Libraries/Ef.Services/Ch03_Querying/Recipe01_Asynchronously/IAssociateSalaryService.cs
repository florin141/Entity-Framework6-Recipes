using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Services
{
    public interface IAssociateSalaryService
    {
        AssociateSalary GetById(int id);

        IEnumerable<AssociateSalary> GetAll();

        void Insert(AssociateSalary entity);

        void Update(AssociateSalary entity);

        void Delete(AssociateSalary entity);
    }
}
