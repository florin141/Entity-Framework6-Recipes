using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Domain;
using Ef.Core.Data;

namespace Ef.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IRepository<Album> _albumRepository;

        public AlbumService(IRepository<Album> albumRepository)
        {
            this._albumRepository = albumRepository;
        }

        public void Delete(Album entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _albumRepository.Delete(entity);
        }

        public IEnumerable<Album> GetAll()
        {
            return _albumRepository.Table.ToList();
        }

        public Album GetById(int id)
        {
            if (id == 0)
                return null;

            return _albumRepository.GetById(id);
        }

        public void Insert(Album entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _albumRepository.Insert(entity);
        }

        public void Update(Album entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _albumRepository.Update(entity);
        }
    }
}
