using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Adressart
    {
        public Adressart()
        {
            Adresses = new HashSet<Adresse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Adresse> Adresses { get; set; }
    }
}
