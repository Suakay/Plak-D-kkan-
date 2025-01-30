using Plak_Data.Entity;
using PlakçıDükkanı.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakçıDükkanı.DAL.Repository
{
    public class AdminRepository : GenericRepository<Admin>
    {
        public readonly AppDbContext _context;

        public AdminRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public void InsertAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }
        public Admin GetKullaniciAdi(string kullaniciAdi)
        {
            return _context.Admins.FirstOrDefault(ad => ad.Name == kullaniciAdi);

        }
    }
}
