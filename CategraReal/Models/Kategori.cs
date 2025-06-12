using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategraReal.Models
{
    public class Kategori : IAranabilir
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Not> Notlar { get; set; } = new List<Not>();
        public Kategori()
        {
        }
        public Kategori(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Update(string name,string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public void Add(Not not)
        {
            Notlar.Add(not);
        }

        public string AranabilirText()
        {
            return $"{Name} {Description}";
        }

        public string BaslikGetir() => Name;

        public SearchableType AramaTuru() => SearchableType.Kategori;
    }
}
