using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Domain;
using Ef.Core.Data;

namespace Ef.Services
{
    public class SimpleModelService : ISimpleModelService
    {
        private readonly IRepository<Person> _personRepository;

        public SimpleModelService(IRepository<Person> personRepository)
        {
            this._personRepository = personRepository;
        }

        public Person GetById(int id)
        {
            if (id == 0)
                return null;

            return _personRepository.GetById(id);
        }

        public IEnumerable<Person> GetAll()
        {
            var query = _personRepository.Table;

            query = query.OrderBy(p => p.Id);

            return query.ToList();
        }

        public void Insert(Person entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _personRepository.Insert(entity);

            //event notification
            //_eventPublisher.EntityInserted(entity);
        }

        public void Insert(IEnumerable<Person> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            _personRepository.Insert(entities);

            //event notification
            //_eventPublisher.EntityInserted(entity);
        }

        public void Update(Person entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _personRepository.Update(entity);

            //event notification
            //_eventPublisher.EntityUpdated(entity);
        }

        public void Delete(Person entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _personRepository.Delete(entity);

            //event notification
            //_eventPublisher.EntityDeleted(entity);
        }
    }
}
