using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Services
{
    public interface IAlbumService
    {
        Album GetById(int id);

        IEnumerable<Album> GetAll();

        void Insert(Album entity);

        void Update(Album entity);

        void Delete(Album entity);
    }
}
