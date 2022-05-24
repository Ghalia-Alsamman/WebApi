using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungAfAzeile
    {
        public KonsolidierungAfAzeile()
        {
            KonsolidierungSonderpostens = new HashSet<KonsolidierungSonderposten>();
        }

        public int Id { get; set; }
        public int? SachkontoId { get; set; }
        public int? KostenstelleId { get; set; }
        public int? KonsolidierungId { get; set; }
        public int? AnlageartId { get; set; }
        public int? SachkontoAnschaffungId { get; set; }
        public string Bezeichnung { get; set; }
        public double? AfAlaufzeit { get; set; }
        public int? Bilanzgruppe { get; set; }
        public string Gruppenschluessel { get; set; }
        public double? UrsprungsBetrag { get; set; }
        public double? Zufuehrung { get; set; }
        public double? Aufloesung { get; set; }
        public double? StandAnfangJahr { get; set; }
        public double? Investitionshoehe { get; set; }
        public string Bemerkung { get; set; }
        public bool IstAfA { get; set; }
        public bool IstSoPo { get; set; }
        public bool IstPlanung { get; set; }
        public int? Anzahl { get; set; }
        public DateTime? Anschaffungsdatum { get; set; }
        public double? ProzentKostenstelle { get; set; }
        public string Zuschussgeber { get; set; }
        public bool? IstErweiterungsinvestition { get; set; }
        public bool? Gwg { get; set; }

        public virtual Anlageart Anlageart { get; set; }
        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual Sachkonto SachkontoAnschaffung { get; set; }
        public virtual ICollection<KonsolidierungSonderposten> KonsolidierungSonderpostens { get; set; }
    }
}
