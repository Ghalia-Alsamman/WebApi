using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class WawiRechte
    {
        public int Id { get; set; }
        public int RechteId { get; set; }
        public int WarenwirtschaftskomponenteId { get; set; }
        public bool? InventurLesen { get; set; }
        public bool? InventurSchreiben { get; set; }
        public bool? WarenentnahmeLesen { get; set; }
        public bool? WarenentnahmeSchreiben { get; set; }
        public bool? LagerLesen { get; set; }
        public bool? LagerSchreiben { get; set; }
        public bool? WarentransfersLesen { get; set; }
        public bool? WarentransfersSchreiben { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Rechte Rechte { get; set; }
        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
    }
}
