using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Data.Mapping
{
    public class ArtistMap : EfEntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            this.ToTable(nameof(Artist), Schema.Chapter02);
            this.HasKey(a => a.ArtistId);

            this.Property(a => a.FirstName).HasMaxLength(64);
            this.Property(a => a.MiddleName).HasMaxLength(64);
            this.Property(a => a.LastName).HasMaxLength(64);

            this.HasMany<Album>(ar => ar.Albums)
                .WithMany(al => al.Artists)
                .Map(aa =>
                {
                    aa.MapLeftKey("ArtistId");
                    aa.MapRightKey("AlbumId");
                    aa.ToTable("LinkTable", Schema.Chapter02);
                });
        }
    }
}
