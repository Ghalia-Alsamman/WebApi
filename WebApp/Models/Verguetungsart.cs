using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Verguetungsart
    {
        public Verguetungsart()
        {
            Lohns = new HashSet<Lohn>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Lohn> Lohns { get; set; }
    }
}
