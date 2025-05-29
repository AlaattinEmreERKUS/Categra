using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategraReal.Models
{
    internal class Kategori : IAranabilir<Not>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Not> Notlar { get; set; }
        public Kategori()
        {
            Notlar = new List<Not>();
        }
        public Kategori(string name, string description)
        {
            Name = name;
            Description = description;
            Notlar = new List<Not>();
        }

        public bool Arama(Not not)
        {
            if (Notlar.Count == 0)
            {
                return false;
            }
            foreach (var item in Notlar)
            {
                if (item.Baslik == not.Baslik && item.Icerik == not.Icerik)
                {
                    return true;
                }
            }
            return false;
        }

        public void Update(string name,string description)
        {
            this.Name = name;
            this.Description = description;
        }

    }
}
