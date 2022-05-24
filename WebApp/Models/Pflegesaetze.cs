using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Pflegesaetze
    {
        public Pflegesaetze()
        {
            InverseBasisPflegesatz = new HashSet<Pflegesaetze>();
            KalkulationAuslastungsarts = new HashSet<KalkulationAuslastungsart>();
        }

        public int Id { get; set; }
        public int AuslastungsartId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public double Pflegestufe0 { get; set; }
        public double Pflegestufe1 { get; set; }
        public double Pflegestufe2 { get; set; }
        public double Pflegestufe3 { get; set; }
        public double Pflegestufe3p { get; set; }
        public double Apu { get; set; }
        public double UnterkunftUndVerpflegung { get; set; }
        public double Sondennahrung { get; set; }
        public double InvestitionskostenAllg { get; set; }
        public double InvestitionskostenSoz { get; set; }
        public double EzZuschlag { get; set; }
        public double? Entgelt43b { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public string Name { get; set; }
        public int? BerechnungsbasisPflege { get; set; }
        public double? BerechnungsbasisAnzahlTagePflege { get; set; }
        public int? BerechnungsbasisErloes { get; set; }
        public double? BerechnungsbasisAnzahlTageErloes { get; set; }
        public int? BerechnungsbasisInvest { get; set; }
        public double? BerechnungsbasisAnzahlTageInvest { get; set; }
        public bool? Aktiv { get; set; }
        public double Eigenanteil { get; set; }
        public double? Investitionskosten3 { get; set; }
        public double? Investitionskosten4 { get; set; }
        public double? Investitionskosten5 { get; set; }
        public bool? SatzFuerSimulation { get; set; }
        public int? Berechnungsbasis43b { get; set; }
        public double? BerechnungsbasisAnzahlTage43b { get; set; }
        public int? BasisPflegesatzId { get; set; }
        public double? ProzentwertSteigerungPflegesatz { get; set; }
        public bool? PflegesatzMfp { get; set; }
        public double? ProzentwertSteigerungUv { get; set; }
        public double? ProzentwertSteigerungInvestkosten { get; set; }
        public double? ProzentwertSteigerungEntgelt43b { get; set; }

        public virtual Auslastungsart Auslastungsart { get; set; }
        public virtual Pflegesaetze BasisPflegesatz { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual ICollection<Pflegesaetze> InverseBasisPflegesatz { get; set; }
        public virtual ICollection<KalkulationAuslastungsart> KalkulationAuslastungsarts { get; set; }
    }
}
