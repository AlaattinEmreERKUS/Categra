using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategraReal.Models
{
    public class Not : IAranabilir
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime OlusturulmaTarihi { get; private set; }
        public DateTime SonDuzenlenmeTarihi { get; set; }
        public Kategori Kategori { get; set; }

        public Not()
        {
            OlusturulmaTarihi = DateTime.Now;
            SonDuzenlenmeTarihi = DateTime.Now;
        }
        public Not(string baslik, string icerik, Kategori kategori)
        {
            Baslik = baslik;
            Icerik = icerik;
            Kategori = kategori;
            OlusturulmaTarihi = DateTime.Now;
            SonDuzenlenmeTarihi = DateTime.Now;
        }

        public string AranabilirText()
        {
            return $"{Baslik} {Icerik} {Kategori?.Name}";
        }

        public string BaslikGetir() => Baslik;

        public SearchableType AramaTuru() => SearchableType.Not;

    }
}
