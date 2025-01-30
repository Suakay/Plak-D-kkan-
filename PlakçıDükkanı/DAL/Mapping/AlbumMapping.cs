using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plak_Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakçıDükkanı.DAL.Mapping
{
    public class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x=>x.AlbumID);
            builder.Property(x => x.AlbumAdi).IsRequired().HasMaxLength(50);    
            builder.Property(x=>x.CikisTarihi).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Sanatci).IsRequired().HasMaxLength(50);    
            builder.Property(x=>x.IndirimOrani).IsRequired().HasMaxLength(50);    

        }
    }
}
