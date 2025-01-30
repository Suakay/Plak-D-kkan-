
using PlakçıDükkanı.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plak_UI.Utilities
{
    public static class FormUtilities
    {

        public static void ListeyiGüncelle(ListView lstliste, AppDbContext appDbContext)
        {
            var albums = appDbContext.Albums.ToList();


            lstliste.Items.Clear();  

            
            foreach (var album in albums)
            {
                ListViewItem item = new ListViewItem(album.AlbumID.ToString());
                item.SubItems.Add(album.AlbumAdi);
                item.SubItems.Add(album.Sanatci);
                item.SubItems.Add(album.CikisTarihi.ToShortDateString());
                item.SubItems.Add(album.Fiyat.ToString("C"));
                item.SubItems.Add(album.IndirimOrani.HasValue ? (album.IndirimOrani.Value / 100).ToString("P2") : "%0");
                item.SubItems.Add(album.SatisDurumu ? "Stokta Var" : "Stokta Yok");

                lstliste.Items.Add(item);
            }
        }
        public static void GirilenVerileriTemizle(GroupBox groupBox, AppDbContext context)
        {
         
            foreach (Control control in groupBox.Controls)
            {
              
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                
            }



        }
    }

  
}
