using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Services
{
    public interface ISimpleModelService
    {
        Person GetById(int id);

        IEnumerable<Person> GetAll();

        void Insert(Person entity);

        void Update(Person entity);

        void Delete(Person entity);
    }
}
