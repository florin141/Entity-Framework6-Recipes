using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Services
{
    public interface IArtistService
    {
        Artist GetById(int id);

        IEnumerable<Artist> GetAll();

        void Insert(Artist entity);

        void Update(Artist entity);

        void Delete(Artist entity);
    }
}
