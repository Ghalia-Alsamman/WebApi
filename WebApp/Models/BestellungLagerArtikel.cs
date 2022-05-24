using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BestellungLagerArtikel
    {
        public int Id { get; set; }
        public int? BestellungId { get; set; }
        public int? LagerArtikelId { get; set; }
        public double? Bestellmenge { get; set; }
        public double? Liefermenge { get; set; }
        public double? MengeGebucht { get; set; }
        public double? Gebindegroesse { get; set; }
        public DateTime? Lieferdatum { get; set; }

        public virtual Bestellung Bestellung { get; set; }
        public virtual LagerArtikel LagerArtikel { get; set; }
    }
}
