using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_Data.Entity
{
     public class Admin
    {
        public int AdminId { get; set; } 
        public string Name { get; set; }
        public string Sifre {  get; set; }  

        public IList<Album> Albums { get; set; } = new List<Album>();

    }
}
