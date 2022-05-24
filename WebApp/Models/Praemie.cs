﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Praemie
    {
        public int Id { get; set; }
        public int? PersonalId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public double? Einsatz { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime? DatumBis { get; set; }
        public int? SonderzahlungId { get; set; }
        public bool AusTarifImportiert { get; set; }

        public virtual Personal Personal { get; set; }
        public virtual Sonderzahlungen Sonderzahlung { get; set; }
    }
}
