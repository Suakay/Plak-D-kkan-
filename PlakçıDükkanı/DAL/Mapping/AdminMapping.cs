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
    public class AdminMapping : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x=>x.AdminId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.Sifre).IsRequired().HasMaxLength(8); 
        }
    }
}
