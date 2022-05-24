using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kostenstelle
    {
        public Kostenstelle()
        {
            AfAzeiles = new HashSet<AfAzeile>();
            Artikellistes = new HashSet<Artikelliste>();
            Aufwands = new HashSet<Aufwand>();
            BetriebsstaetteSachkontoKostenstelleDienstarts = new HashSet<BetriebsstaetteSachkontoKostenstelleDienstart>();
            BetriebsstaetteVorgabewertes = new HashSet<BetriebsstaetteVorgabewerte>();
            Betriebsstaettedarlehens = new HashSet<Betriebsstaettedarlehen>();
            Darlehens = new HashSet<Darlehen>();
            Erloesplanungszeiles = new HashSet<Erloesplanungszeile>();
            Kalkulations = new HashSet<Kalkulation>();
            KonsolidierungAfAzeiles = new HashSet<KonsolidierungAfAzeile>();
            KonsolidierungDarlehens = new HashSet<KonsolidierungDarlehen>();
            KonsolidierungPersonaleinsatzs = new HashSet<KonsolidierungPersonaleinsatz>();
            KonsolidierungSachkostenVerteilungKsts = new HashSet<KonsolidierungSachkostenVerteilungKst>();
            KonsolidierungSonderpostens = new HashSet<KonsolidierungSonderposten>();
            KostenstellePflegestuves = new HashSet<KostenstellePflegestufe>();
            KostenstelleSachkontoBetriebsstaettes = new HashSet<KostenstelleSachkontoBetriebsstaette>();
            Personaleinsatzs = new HashSet<Personaleinsatz>();
            SachkontoProzentBetriebsstaettes = new HashSet<SachkontoProzentBetriebsstaette>();
            SachkostenVerteilungKsts = new HashSet<SachkostenVerteilungKst>();
            Sonderpostens = new HashSet<Sonderposten>();
            UmlagekostenstelleKostenstelles = new HashSet<Umlagekostenstelle>();
            UmlagekostenstelleUKostenstelles = new HashSet<Umlagekostenstelle>();
            VorgabewerteKennzahlenabweichungs = new HashSet<VorgabewerteKennzahlenabweichung>();
            Warenwirtschaftskomponentes = new HashSet<Warenwirtschaftskomponente>();
            Wohnungs = new HashSet<Wohnung>();
            Wohnungsinformations = new HashSet<Wohnungsinformation>();
        }

        public int Id { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? AnsprechpartnerId { get; set; }
        public int? OverheadId { get; set; }
        public int? Kostenstellennummer { get; set; }
        public string Name { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public bool? Eventkostenstelle { get; set; }
        public bool VorgabenameGewaehlt { get; set; }
        public bool Aktiv { get; set; }
        public int? KalkulationsartId { get; set; }
        public int? BenutzerId { get; set; }

        public virtual Ansprechpartner Ansprechpartner { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kalkulationsart Kalkulationsart { get; set; }
        public virtual Overhead Overhead { get; set; }
        public virtual ICollection<AfAzeile> AfAzeiles { get; set; }
        public virtual ICollection<Artikelliste> Artikellistes { get; set; }
        public virtual ICollection<Aufwand> Aufwands { get; set; }
        public virtual ICollection<BetriebsstaetteSachkontoKostenstelleDienstart> BetriebsstaetteSachkontoKostenstelleDienstarts { get; set; }
        public virtual ICollection<BetriebsstaetteVorgabewerte> BetriebsstaetteVorgabewertes { get; set; }
        public virtual ICollection<Betriebsstaettedarlehen> Betriebsstaettedarlehens { get; set; }
        public virtual ICollection<Darlehen> Darlehens { get; set; }
        public virtual ICollection<Erloesplanungszeile> Erloesplanungszeiles { get; set; }
        public virtual ICollection<Kalkulation> Kalkulations { get; set; }
        public virtual ICollection<KonsolidierungAfAzeile> KonsolidierungAfAzeiles { get; set; }
        public virtual ICollection<KonsolidierungDarlehen> KonsolidierungDarlehens { get; set; }
        public virtual ICollection<KonsolidierungPersonaleinsatz> KonsolidierungPersonaleinsatzs { get; set; }
        public virtual ICollection<KonsolidierungSachkostenVerteilungKst> KonsolidierungSachkostenVerteilungKsts { get; set; }
        public virtual ICollection<KonsolidierungSonderposten> KonsolidierungSonderpostens { get; set; }
        public virtual ICollection<KostenstellePflegestufe> KostenstellePflegestuves { get; set; }
        public virtual ICollection<KostenstelleSachkontoBetriebsstaette> KostenstelleSachkontoBetriebsstaettes { get; set; }
        public virtual ICollection<Personaleinsatz> Personaleinsatzs { get; set; }
        public virtual ICollection<SachkontoProzentBetriebsstaette> SachkontoProzentBetriebsstaettes { get; set; }
        public virtual ICollection<SachkostenVerteilungKst> SachkostenVerteilungKsts { get; set; }
        public virtual ICollection<Sonderposten> Sonderpostens { get; set; }
        public virtual ICollection<Umlagekostenstelle> UmlagekostenstelleKostenstelles { get; set; }
        public virtual ICollection<Umlagekostenstelle> UmlagekostenstelleUKostenstelles { get; set; }
        public virtual ICollection<VorgabewerteKennzahlenabweichung> VorgabewerteKennzahlenabweichungs { get; set; }
        public virtual ICollection<Warenwirtschaftskomponente> Warenwirtschaftskomponentes { get; set; }
        public virtual ICollection<Wohnung> Wohnungs { get; set; }
        public virtual ICollection<Wohnungsinformation> Wohnungsinformations { get; set; }
    }
}
