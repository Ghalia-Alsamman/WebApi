using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KundeLoesung
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int LoesungId { get; set; }
        public bool? Checked { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual Loesung Loesung { get; set; }
    }
}
