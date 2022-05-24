using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class TransferArtikel
    {
        public int Id { get; set; }
        public int? TransferId { get; set; }
        public int? SteuernId { get; set; }
        public int? LagerArtikelId { get; set; }
        public int? LagerZielId { get; set; }
        public double? Menge { get; set; }
        public double? Preis { get; set; }

        public virtual LagerArtikel LagerArtikel { get; set; }
        public virtual Lager LagerZiel { get; set; }
        public virtual Steuern Steuern { get; set; }
        public virtual Transfer Transfer { get; set; }
    }
}
