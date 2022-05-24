using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SonderveranstaltungPersonal
    {
        public int Id { get; set; }
        public int? PersonalId { get; set; }
        public int? SonderveranstaltungId { get; set; }
        public DateTime? Von { get; set; }
        public DateTime? Bis { get; set; }
        public double? Aufschlag { get; set; }

        public virtual Personal Personal { get; set; }
        public virtual Sonderveranstaltung Sonderveranstaltung { get; set; }
    }
}
