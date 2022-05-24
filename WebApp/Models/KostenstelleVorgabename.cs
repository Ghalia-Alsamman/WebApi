using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KostenstelleVorgabename
    {
        public int Id { get; set; }
        public int Kostenstellennummer { get; set; }
        public string Vorgabename { get; set; }
        public int? KostenbereichId { get; set; }

        public virtual Kostenbereich Kostenbereich { get; set; }
    }
}
