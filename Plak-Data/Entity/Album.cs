using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_Data.Entity
{
     public class Album
    {
        public int AlbumID { get; set; }    

        public string AlbumAdi {  get; set; }   
        public string Sanatci {  get; set; } 
        public DateTime CikisTarihi { get; set; }   
        public decimal Fiyat {  get; set; }
        public bool SatisDurumu { get; set; }
        public double? IndirimOrani { get; set; }   
         //Navigation
         public Admin Admin { get; set; }   
        public int AdminID {  get; set; }   

    }
}
