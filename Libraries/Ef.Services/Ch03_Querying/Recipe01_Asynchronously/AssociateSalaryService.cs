using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Domain;
using Ef.Core.Data;

namespace Ef.Services
{
    public class AssociateSalaryService : IAssociateSalaryService
    {
        private readonly IRepository<AssociateSalary> _associateSalaryRepository;

        public AssociateSalaryService(IRepository<AssociateSalary> associateSalaryRepository)
        {
            this._associateSalaryRepository = associateSalaryRepository;
        }

        public void Delete(AssociateSalary entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _associateSalaryRepository.Delete(entity);
        }

        public IEnumerable<AssociateSalary> GetAll()
        {
            return _associateSalaryRepository.Table.ToList();
        }

        public AssociateSalary GetById(int id)
        {
            if (id == 0)
                return null;

            return _associateSalaryRepository.GetById(id);
        }

        public void Insert(AssociateSalary entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _associateSalaryRepository.Insert(entity);
        }

        public void Update(AssociateSalary entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _associateSalaryRepository.Update(entity);
        }
    }
}
