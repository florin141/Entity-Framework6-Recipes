using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Data.Mapping
{
    public class AlbumMap : EfEntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            this.ToTable(nameof(Album), Schema.Chapter02);
            this.HasKey(a => a.AlbumId);

            this.Property(a => a.AlbumName).HasMaxLength(128).IsRequired();
        }
    }
}
