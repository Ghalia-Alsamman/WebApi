using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Arbeitstage
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Arbeitstage1 { get; set; }
        public int? BundeslandId { get; set; }

        public virtual Bundesland Bundesland { get; set; }
    }
}
