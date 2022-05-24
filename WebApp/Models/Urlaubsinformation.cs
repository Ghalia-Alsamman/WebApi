using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urlaubsinformation
    {
        public Urlaubsinformation()
        {
            Urlaubs = new HashSet<Urlaub>();
        }

        public int Id { get; set; }
        public int? VertragsinformationId { get; set; }
        public double AnzahlUrlaubstage { get; set; }

        public virtual ICollection<Urlaub> Urlaubs { get; set; }
    }
}
