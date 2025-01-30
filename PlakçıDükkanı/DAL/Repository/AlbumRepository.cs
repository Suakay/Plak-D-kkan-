using Plak_Data.Entity;
using PlakçıDükkanı.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakçıDükkanı.DAL.Repository
{
    public class AlbumRepository : GenericRepository<Album>
    {
        public readonly AppDbContext _context;

        public AlbumRepository(AppDbContext context):base(context)
        {
            _context = context;
        }

        public IQueryable<Album> GetSatisiOlmayanAlbumler()
        {
            return _context.Albums
                .Where(a => a.SatisDurumu == false)
                .Select(a => new Album
                {
                    AlbumID = a.AlbumID,
                    AlbumAdi = a.AlbumAdi,
                    Sanatci = a.Sanatci,
                    CikisTarihi = a.CikisTarihi,
                    Fiyat = a.Fiyat,
                    IndirimOrani = a.IndirimOrani,
                    SatisDurumu = a.SatisDurumu
                });


        }

        public IQueryable<Album> GetSonEklenenOnAlbum()
        {
            return _context.Albums
            .OrderBy(a => a.AlbumID)
            .Take(10)
            .Select(a => new Album
            {
                AlbumID = a.AlbumID,
                AlbumAdi = a.AlbumAdi,
                Sanatci = a.Sanatci,
                CikisTarihi = a.CikisTarihi,
                Fiyat = a.Fiyat,
                IndirimOrani = a.IndirimOrani,
                SatisDurumu = a.SatisDurumu

            });

        }
        public IQueryable<Album> getIndirimliAlbum()
        {
            return _context.Albums
            .Where(a => a.IndirimOrani.HasValue && a.IndirimOrani > 0)
            .Select(a => new Album
            {
                AlbumID = a.AlbumID,
                AlbumAdi = a.AlbumAdi,
                Sanatci = a.Sanatci,
                CikisTarihi = a.CikisTarihi,
                Fiyat = a.Fiyat,
                IndirimOrani = a.IndirimOrani,
                SatisDurumu = a.SatisDurumu
            });

        }

        //Satışı devam eden albumler:
        public IQueryable<Album> GetSatisiOlanAlbumler()
        {
            return _context.Albums
            .Where(a => a.SatisDurumu)
            .Select(a => new Album
            {
                AlbumID = a.AlbumID,
                AlbumAdi = a.AlbumAdi,
                Sanatci = a.Sanatci,
                CikisTarihi = a.CikisTarihi,
                Fiyat = a.Fiyat,
                IndirimOrani = a.IndirimOrani,
                SatisDurumu = a.SatisDurumu


            });

        }
    }
}
