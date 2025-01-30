using Microsoft.EntityFrameworkCore;
using Plak_Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PlakçıDükkanı.DAL.Context
{
    public class AppDbContext : DbContext
    {
      

       


        public DbSet<Album> Albums { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-785CG1C;Initial Catalog=PlakProjesiiii;Integrated Security=True;TrustServerCertificate=True");


        }

    }
}
