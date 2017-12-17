using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Domain
{
    public class Album
    {
        public Album()
        {
            Artists = new HashSet<Artist>();
        }

        public int AlbumId { get; set; }
        public string AlbumName { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
