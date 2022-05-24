using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sachkonto
    {
        public Sachkonto()
        {
            AfAzeileSachkontoAnschaffungs = new HashSet<AfAzeile>();
            AfAzeileSachkontos = new HashSet<AfAzeile>();
            Aufwands = new HashSet<Aufwand>();
            BerufsgruppeSachkontoSkAltersvorsorgeZusatzs = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkAltersvorsorges = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkArbeitslosenVers = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkAufwendungsausgls = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkBeihilves = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkBerufsgenossensches = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkErstattungs = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkGehalts = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkHaftpflichts = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkKrankenVers = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkLohnsteuers = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkPflegeVers = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkPraemieSonderzahlungs = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkSchwerbehinPausches = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkSozialVers = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkZuschlagSvpflichtigs = new HashSet<BerufsgruppeSachkonto>();
            BerufsgruppeSachkontoSkZuschlags = new HashSet<BerufsgruppeSachkonto>();
            BetriebsstaetteSachkontoKostenstelleDienstarts = new HashSet<BetriebsstaetteSachkontoKostenstelleDienstart>();
            BetriebsstaettedarlehenSachkontoAbgrenzungTilungNavigations = new HashSet<Betriebsstaettedarlehen>();
            BetriebsstaettedarlehenSachkontoAbgrenzungZinsenNavigations = new HashSet<Betriebsstaettedarlehen>();
            BetriebsstaettedarlehenSachkontos = new HashSet<Betriebsstaettedarlehen>();
            Betriebsstaettes = new HashSet<Betriebsstaette>();
            Buchungstags = new HashSet<Buchungstag>();
            DarlehenSachkontoAbgrenzungTilungNavigations = new HashSet<Darlehen>();
            DarlehenSachkontoAbgrenzungZinsenNavigations = new HashSet<Darlehen>();
            DarlehenSachkontos = new HashSet<Darlehen>();
            DarlehenTypenAbgrenzungtilgungs = new HashSet<DarlehenTypen>();
            DarlehenTypenAbgrenzungzinsens = new HashSet<DarlehenTypen>();
            DarlehenTypenSachkontos = new HashSet<DarlehenTypen>();
            Erloesplanungszeiles = new HashSet<Erloesplanungszeile>();
            FortschrittsanzeigeKategorieSachkontos = new HashSet<FortschrittsanzeigeKategorieSachkonto>();
            ImportHochrechnungs = new HashSet<ImportHochrechnung>();
            ImportSachkostens = new HashSet<ImportSachkosten>();
            Kalkulations = new HashSet<Kalkulation>();
            KonsolidierungAfAzeileSachkontoAnschaffungs = new HashSet<KonsolidierungAfAzeile>();
            KonsolidierungAfAzeileSachkontos = new HashSet<KonsolidierungAfAzeile>();
            KonsolidierungDarlehens = new HashSet<KonsolidierungDarlehen>();
            KonsolidierungImportHochrechnungs = new HashSet<KonsolidierungImportHochrechnung>();
            KonsolidierungImportVorjahrs = new HashSet<KonsolidierungImportVorjahr>();
            KonsolidierungPersonals = new HashSet<KonsolidierungPersonal>();
            KonsolidierungSachkostenzeiles = new HashSet<KonsolidierungSachkostenzeile>();
            KonsolidierungSonderpostenSachkontoAufwZufuehrungs = new HashSet<KonsolidierungSonderposten>();
            KonsolidierungSonderpostenSachkontoErtrFoerderungs = new HashSet<KonsolidierungSonderposten>();
            KonsolidierungSonderpostenSachkontos = new HashSet<KonsolidierungSonderposten>();
            KostenstelleSachkontoBetriebsstaettes = new HashSet<KostenstelleSachkontoBetriebsstaette>();
            Personals = new HashSet<Personal>();
            SachkontenkategorieSachkontoCateringErloeses = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoErloeseGetraenke19s = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoErloeseGetraenke7s = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoErloeseLebensmittels = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoErloeseOperMgmtAufschlags = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoErloeseVerwaltungs = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoKalkGewSteuers = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoKalkKoerpSteuers = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoLmsteuers = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoOperMgmtAufschlags = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoUhrerloeses = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoVerwKostens = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoVolleSteuers = new HashSet<Sachkontenkategorie>();
            SachkontenkategorieSachkontoZgasts = new HashSet<Sachkontenkategorie>();
            SachkontoProzentBetriebsstaettes = new HashSet<SachkontoProzentBetriebsstaette>();
            SachkontoSachkontoGliederungsgruppes = new HashSet<SachkontoSachkontoGliederungsgruppe>();
            Sachkostenzeiles = new HashSet<Sachkostenzeile>();
            SonderpostenSachkontoAufwZufuehrungs = new HashSet<Sonderposten>();
            SonderpostenSachkontoErtrFoerderungs = new HashSet<Sonderposten>();
            SonderpostenSachkontos = new HashSet<Sonderposten>();
            Sonderzahlungens = new HashSet<Sonderzahlungen>();
            ZuordnungGehaltSozialversicherungSachkontoGehalts = new HashSet<ZuordnungGehaltSozialversicherung>();
            ZuordnungGehaltSozialversicherungSachkontoSvs = new HashSet<ZuordnungGehaltSozialversicherung>();
        }

        public int Id { get; set; }
        public int? SachkontengruppeId { get; set; }
        public int SachkontenkategorieId { get; set; }
        public int? SachkontoId { get; set; }
        public int? SteuernId { get; set; }
        public int? Sachkontennummer { get; set; }
        public string Name { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool Umsatzrelevant { get; set; }
        public bool? Liquiditaetsrelevant { get; set; }
        public bool Hochrechnungsrelevant { get; set; }
        public bool GrundlageFuerGewerbesteuern { get; set; }
        public bool GrundlageFuerKoerperschaftssteuern { get; set; }
        public bool IstStandard { get; set; }
        public bool? Aktiv { get; set; }
        public bool IstAfAkonto { get; set; }
        public int? PlanbilanzkontoId { get; set; }
        public int? PlanbilanzgegenkontoId { get; set; }
        public int? FortschrittsanzeigeKategorieId { get; set; }
        public bool? ZumBuchenGesperrt { get; set; }
        public double? VorschlagswertSteigerung { get; set; }
        public bool? Pflichtfeld { get; set; }
        public bool IstKampagnenKonto { get; set; }
        public bool ZeigeBearbeitungshinweis { get; set; }
        public string Bearbeitungshinweis { get; set; }
        public bool IstZuschussKonto { get; set; }
        public bool IstSopoKonto { get; set; }

        public virtual FortschrittsanzeigeKategorie FortschrittsanzeigeKategorie { get; set; }
        public virtual Planbilanzkonto Planbilanzgegenkonto { get; set; }
        public virtual Planbilanzkonto Planbilanzkonto { get; set; }
        public virtual Sachkontengruppe Sachkontengruppe { get; set; }
        public virtual Sachkontenkategorie Sachkontenkategorie { get; set; }
        public virtual Steuern Steuern { get; set; }
        public virtual ICollection<AfAzeile> AfAzeileSachkontoAnschaffungs { get; set; }
        public virtual ICollection<AfAzeile> AfAzeileSachkontos { get; set; }
        public virtual ICollection<Aufwand> Aufwands { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkAltersvorsorgeZusatzs { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkAltersvorsorges { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkArbeitslosenVers { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkAufwendungsausgls { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkBeihilves { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkBerufsgenossensches { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkErstattungs { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkGehalts { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkHaftpflichts { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkKrankenVers { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkLohnsteuers { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkPflegeVers { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkPraemieSonderzahlungs { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkSchwerbehinPausches { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkSozialVers { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkZuschlagSvpflichtigs { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontoSkZuschlags { get; set; }
        public virtual ICollection<BetriebsstaetteSachkontoKostenstelleDienstart> BetriebsstaetteSachkontoKostenstelleDienstarts { get; set; }
        public virtual ICollection<Betriebsstaettedarlehen> BetriebsstaettedarlehenSachkontoAbgrenzungTilungNavigations { get; set; }
        public virtual ICollection<Betriebsstaettedarlehen> BetriebsstaettedarlehenSachkontoAbgrenzungZinsenNavigations { get; set; }
        public virtual ICollection<Betriebsstaettedarlehen> BetriebsstaettedarlehenSachkontos { get; set; }
        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
        public virtual ICollection<Buchungstag> Buchungstags { get; set; }
        public virtual ICollection<Darlehen> DarlehenSachkontoAbgrenzungTilungNavigations { get; set; }
        public virtual ICollection<Darlehen> DarlehenSachkontoAbgrenzungZinsenNavigations { get; set; }
        public virtual ICollection<Darlehen> DarlehenSachkontos { get; set; }
        public virtual ICollection<DarlehenTypen> DarlehenTypenAbgrenzungtilgungs { get; set; }
        public virtual ICollection<DarlehenTypen> DarlehenTypenAbgrenzungzinsens { get; set; }
        public virtual ICollection<DarlehenTypen> DarlehenTypenSachkontos { get; set; }
        public virtual ICollection<Erloesplanungszeile> Erloesplanungszeiles { get; set; }
        public virtual ICollection<FortschrittsanzeigeKategorieSachkonto> FortschrittsanzeigeKategorieSachkontos { get; set; }
        public virtual ICollection<ImportHochrechnung> ImportHochrechnungs { get; set; }
        public virtual ICollection<ImportSachkosten> ImportSachkostens { get; set; }
        public virtual ICollection<Kalkulation> Kalkulations { get; set; }
        public virtual ICollection<KonsolidierungAfAzeile> KonsolidierungAfAzeileSachkontoAnschaffungs { get; set; }
        public virtual ICollection<KonsolidierungAfAzeile> KonsolidierungAfAzeileSachkontos { get; set; }
        public virtual ICollection<KonsolidierungDarlehen> KonsolidierungDarlehens { get; set; }
        public virtual ICollection<KonsolidierungImportHochrechnung> KonsolidierungImportHochrechnungs { get; set; }
        public virtual ICollection<KonsolidierungImportVorjahr> KonsolidierungImportVorjahrs { get; set; }
        public virtual ICollection<KonsolidierungPersonal> KonsolidierungPersonals { get; set; }
        public virtual ICollection<KonsolidierungSachkostenzeile> KonsolidierungSachkostenzeiles { get; set; }
        public virtual ICollection<KonsolidierungSonderposten> KonsolidierungSonderpostenSachkontoAufwZufuehrungs { get; set; }
        public virtual ICollection<KonsolidierungSonderposten> KonsolidierungSonderpostenSachkontoErtrFoerderungs { get; set; }
        public virtual ICollection<KonsolidierungSonderposten> KonsolidierungSonderpostenSachkontos { get; set; }
        public virtual ICollection<KostenstelleSachkontoBetriebsstaette> KostenstelleSachkontoBetriebsstaettes { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoCateringErloeses { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoErloeseGetraenke19s { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoErloeseGetraenke7s { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoErloeseLebensmittels { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoErloeseOperMgmtAufschlags { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoErloeseVerwaltungs { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoKalkGewSteuers { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoKalkKoerpSteuers { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoLmsteuers { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoOperMgmtAufschlags { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoUhrerloeses { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoVerwKostens { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoVolleSteuers { get; set; }
        public virtual ICollection<Sachkontenkategorie> SachkontenkategorieSachkontoZgasts { get; set; }
        public virtual ICollection<SachkontoProzentBetriebsstaette> SachkontoProzentBetriebsstaettes { get; set; }
        public virtual ICollection<SachkontoSachkontoGliederungsgruppe> SachkontoSachkontoGliederungsgruppes { get; set; }
        public virtual ICollection<Sachkostenzeile> Sachkostenzeiles { get; set; }
        public virtual ICollection<Sonderposten> SonderpostenSachkontoAufwZufuehrungs { get; set; }
        public virtual ICollection<Sonderposten> SonderpostenSachkontoErtrFoerderungs { get; set; }
        public virtual ICollection<Sonderposten> SonderpostenSachkontos { get; set; }
        public virtual ICollection<Sonderzahlungen> Sonderzahlungens { get; set; }
        public virtual ICollection<ZuordnungGehaltSozialversicherung> ZuordnungGehaltSozialversicherungSachkontoGehalts { get; set; }
        public virtual ICollection<ZuordnungGehaltSozialversicherung> ZuordnungGehaltSozialversicherungSachkontoSvs { get; set; }
    }
}
