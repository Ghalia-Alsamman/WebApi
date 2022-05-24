using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mailadressart
    {
        public Mailadressart()
        {
            Mailadresses = new HashSet<Mailadresse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Mailadresse> Mailadresses { get; set; }
    }
}
