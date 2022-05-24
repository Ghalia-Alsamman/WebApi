using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Darlehen
    {
        public Darlehen()
        {
            DarlehenZusatztilgungs = new HashSet<DarlehenZusatztilgung>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FinanzplanungId { get; set; }
        public int? KostenstelleId { get; set; }
        public int? SachkontoId { get; set; }
        public double Kredithoehe { get; set; }
        public int Laufzeit { get; set; }
        public double Zinssatz { get; set; }
        public double Tilgung { get; set; }
        public double? Tilgung01 { get; set; }
        public double? Tilgung02 { get; set; }
        public double? Tilgung03 { get; set; }
        public double? Tilgung04 { get; set; }
        public double? Tilgung05 { get; set; }
        public double? Tilgung06 { get; set; }
        public double? Tilgung07 { get; set; }
        public double? Tilgung08 { get; set; }
        public double? Tilgung09 { get; set; }
        public double? Tilgung10 { get; set; }
        public double? Tilgung11 { get; set; }
        public double? Tilgung12 { get; set; }
        public double? Zinsen01 { get; set; }
        public double? Zinsen02 { get; set; }
        public double? Zinsen03 { get; set; }
        public double? Zinsen04 { get; set; }
        public double? Zinsen05 { get; set; }
        public double? Zinsen06 { get; set; }
        public double? Zinsen07 { get; set; }
        public double? Zinsen08 { get; set; }
        public double? Zinsen09 { get; set; }
        public double? Zinsen10 { get; set; }
        public double? Zinsen11 { get; set; }
        public double? Zinsen12 { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public DateTime? Startdatum { get; set; }
        public double? DarlehenshoeheAnfangJahr { get; set; }
        public bool DarlehenWurdeVergeben { get; set; }
        public bool? Aktiv { get; set; }
        public int Typ { get; set; }
        public int? DarlehentypId { get; set; }
        public bool AbgrenzungZinsen { get; set; }
        public bool AbgrenzungTilgung { get; set; }
        public int? SachkontoAbgrenzungZinsen { get; set; }
        public int? SachkontoAbgrenzungTilung { get; set; }

        public virtual DarlehenTypen Darlehentyp { get; set; }
        public virtual Finanzplanung Finanzplanung { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
        public virtual Sachkonto SachkontoAbgrenzungTilungNavigation { get; set; }
        public virtual Sachkonto SachkontoAbgrenzungZinsenNavigation { get; set; }
        public virtual ICollection<DarlehenZusatztilgung> DarlehenZusatztilgungs { get; set; }
    }
}
