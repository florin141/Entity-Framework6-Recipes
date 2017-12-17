using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Domain;
using Ef.Core.Data;

namespace Ef.Services
{
    public class AssociateService : IAssociateService
    {
        private readonly IRepository<Associate> _associateRepository;

        public AssociateService(IRepository<Associate> associateRepository)
        {
            this._associateRepository = associateRepository;
        }

        public void Delete(Associate entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _associateRepository.Delete(entity);
        }

        public IEnumerable<Associate> GetAll()
        {
            return _associateRepository.Table.ToList();
        }

        public Associate GetById(int id)
        {
            if (id == 0)
                return null;

            return _associateRepository.GetById(id);
        }

        public void Insert(Associate entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _associateRepository.Insert(entity);
        }

        public void Update(Associate entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _associateRepository.Update(entity);
        }
    }
}
