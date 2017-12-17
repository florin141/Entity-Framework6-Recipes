using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Domain;
using Ef.Core.Data;

namespace Ef.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IRepository<Artist> _artistRepository;

        public ArtistService(IRepository<Artist> artistRepository)
        {
            this._artistRepository = artistRepository;
        }

        public void Delete(Artist entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _artistRepository.Delete(entity);
        }

        public IEnumerable<Artist> GetAll()
        {
            return _artistRepository.Table.ToList();
        }

        public Artist GetById(int id)
        {
            if (id == 0)
                return null;

            return _artistRepository.GetById(id);
        }

        public void Insert(Artist entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _artistRepository.Insert(entity);
        }

        public void Update(Artist entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _artistRepository.Update(entity);
        }
    }
}
