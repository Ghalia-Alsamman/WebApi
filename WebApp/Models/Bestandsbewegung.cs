using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Bestandsbewegung
    {
        public int Id { get; set; }
        public int LagerId { get; set; }
        public int LagerArtikelId { get; set; }
        public int BenutzerId { get; set; }
        public double Menge { get; set; }
        public double StckPreis { get; set; }
        public string Bemerkung { get; set; }
        public int? GrundObjektId { get; set; }
        public string GrundObjektTyp { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Lager Lager { get; set; }
        public virtual LagerArtikel LagerArtikel { get; set; }
    }
}
