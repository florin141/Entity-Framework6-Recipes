using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Services
{
    public interface IAssociateService
    {
        Associate GetById(int id);

        IEnumerable<Associate> GetAll();

        void Insert(Associate entity);

        void Update(Associate entity);

        void Delete(Associate entity);
    }
}
