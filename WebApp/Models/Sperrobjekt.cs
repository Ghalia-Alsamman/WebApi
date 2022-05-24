using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sperrobjekt
    {
        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public string ObjektHash { get; set; }
        public DateTime GesperrtSeit { get; set; }

        public virtual Benutzer Benutzer { get; set; }
    }
}
