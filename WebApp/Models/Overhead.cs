using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Overhead
    {
        public Overhead()
        {
            Kostenstelles = new HashSet<Kostenstelle>();
        }

        public int Id { get; set; }
        public int? TypId { get; set; }
        public bool Aktiv { get; set; }

        public virtual Typ Typ { get; set; }
        public virtual ICollection<Kostenstelle> Kostenstelles { get; set; }
    }
}
