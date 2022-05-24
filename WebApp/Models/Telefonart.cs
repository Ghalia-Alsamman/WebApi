using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Telefonart
    {
        public Telefonart()
        {
            Telefonnummers = new HashSet<Telefonnummer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Telefonnummer> Telefonnummers { get; set; }
    }
}
