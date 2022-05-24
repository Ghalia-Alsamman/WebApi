using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kalkulation
    {
        public Kalkulation()
        {
            AfAzeiles = new HashSet<AfAzeile>();
            Angebots = new HashSet<Angebot>();
            Aufwands = new HashSet<Aufwand>();
            Auslastungszeiles = new HashSet<Auslastungszeile>();
            CateringAllgemeins = new HashSet<CateringAllgemein>();
            CateringArbeitsschritteMahlzeits = new HashSet<CateringArbeitsschritteMahlzeit>();
            CateringEinheitens = new HashSet<CateringEinheiten>();
            CateringProduktivzeitens = new HashSet<CateringProduktivzeiten>();
            DiamantExports = new HashSet<DiamantExport>();
            Erloesplanungszeiles = new HashSet<Erloesplanungszeile>();
            Finanzplanungs = new HashSet<Finanzplanung>();
            ImportHochrechnungs = new HashSet<ImportHochrechnung>();
            ImportSachkostens = new HashSet<ImportSachkosten>();
            InverseUrsprungsbudget = new HashSet<Kalkulation>();
            KalkulationAngebots = new HashSet<KalkulationAngebot>();
            KalkulationArtikels = new HashSet<KalkulationArtikel>();
            KalkulationAufschlaeges = new HashSet<KalkulationAufschlaege>();
            KalkulationAuslastungsarts = new HashSet<KalkulationAuslastungsart>();
            KalkulationKommentars = new HashSet<KalkulationKommentar>();
            KalkulationKonsolidierungs = new HashSet<KalkulationKonsolidierung>();
            KalkulationWohnungs = new HashSet<KalkulationWohnung>();
            Kalkulationskennzahls = new HashSet<Kalkulationskennzahl>();
            Kampagnes = new HashSet<Kampagne>();
            Personals = new HashSet<Personal>();
            Planbilanzs = new HashSet<Planbilanz>();
            Sachkostenzeiles = new HashSet<Sachkostenzeile>();
            StrategischeKalkulationKalkulations = new HashSet<StrategischeKalkulationKalkulation>();
            UrraumnutzkategorieKalkulations = new HashSet<UrraumnutzkategorieKalkulation>();
            Urraums = new HashSet<Urraum>();
            Vertretungspersonals = new HashSet<Vertretungspersonal>();
            VerwaltungsumlageKalkulationBesitzers = new HashSet<Verwaltungsumlage>();
            VerwaltungsumlageKalkulationGehoertZus = new HashSet<Verwaltungsumlage>();
        }

        public int Id { get; set; }
        public int? KostenstellenId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int KalkulationsartId { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public double? VerwaltungsProzent { get; set; }
        public double? RisikoGewinnProzent { get; set; }
        public bool IstAbgeschlossen { get; set; }
        public DateTime? PlanungVon { get; set; }
        public DateTime? PlanungBis { get; set; }
        public double? StundenVerrechnungssatz { get; set; }
        public double? MietertraegeRenovierung { get; set; }
        public double? MietertraegeUnternehmen { get; set; }
        public string Nachricht { get; set; }
        public bool? IstKalkulationZurKonsolidierungFreigegeben { get; set; }
        public double? IstDatenImportPruefsumme { get; set; }
        public double? KalkulatorischeEndsummeMitAufschlaegen { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool ErloeseAutomBerechnet { get; set; }
        public bool Deaktiviert { get; set; }
        public bool Aktiv { get; set; }
        public double OperativesMgmtProzent { get; set; }
        public bool KalkOperativesMgmt { get; set; }
        public bool KalkVerwaltungspauschale { get; set; }
        public bool KalkGewerbesteuer { get; set; }
        public bool KalkKoerperschaftssteuer { get; set; }
        public int AnzahlBetten { get; set; }
        public int Status { get; set; }
        public int? UrsprungsbudgetId { get; set; }
        public bool IstMfp { get; set; }
        public bool IstAngebot { get; set; }
        public double Gefahrenklasse { get; set; }
        public double Beitragsfuss { get; set; }
        public double Freibetrag { get; set; }
        public double BeitragsfussFreibetrag { get; set; }
        public int? BgSachkontoId { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Sachkonto BgSachkonto { get; set; }
        public virtual Kalkulationsart Kalkulationsart { get; set; }
        public virtual Kostenstelle Kostenstellen { get; set; }
        public virtual Kalkulation Ursprungsbudget { get; set; }
        public virtual ICollection<AfAzeile> AfAzeiles { get; set; }
        public virtual ICollection<Angebot> Angebots { get; set; }
        public virtual ICollection<Aufwand> Aufwands { get; set; }
        public virtual ICollection<Auslastungszeile> Auslastungszeiles { get; set; }
        public virtual ICollection<CateringAllgemein> CateringAllgemeins { get; set; }
        public virtual ICollection<CateringArbeitsschritteMahlzeit> CateringArbeitsschritteMahlzeits { get; set; }
        public virtual ICollection<CateringEinheiten> CateringEinheitens { get; set; }
        public virtual ICollection<CateringProduktivzeiten> CateringProduktivzeitens { get; set; }
        public virtual ICollection<DiamantExport> DiamantExports { get; set; }
        public virtual ICollection<Erloesplanungszeile> Erloesplanungszeiles { get; set; }
        public virtual ICollection<Finanzplanung> Finanzplanungs { get; set; }
        public virtual ICollection<ImportHochrechnung> ImportHochrechnungs { get; set; }
        public virtual ICollection<ImportSachkosten> ImportSachkostens { get; set; }
        public virtual ICollection<Kalkulation> InverseUrsprungsbudget { get; set; }
        public virtual ICollection<KalkulationAngebot> KalkulationAngebots { get; set; }
        public virtual ICollection<KalkulationArtikel> KalkulationArtikels { get; set; }
        public virtual ICollection<KalkulationAufschlaege> KalkulationAufschlaeges { get; set; }
        public virtual ICollection<KalkulationAuslastungsart> KalkulationAuslastungsarts { get; set; }
        public virtual ICollection<KalkulationKommentar> KalkulationKommentars { get; set; }
        public virtual ICollection<KalkulationKonsolidierung> KalkulationKonsolidierungs { get; set; }
        public virtual ICollection<KalkulationWohnung> KalkulationWohnungs { get; set; }
        public virtual ICollection<Kalkulationskennzahl> Kalkulationskennzahls { get; set; }
        public virtual ICollection<Kampagne> Kampagnes { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<Planbilanz> Planbilanzs { get; set; }
        public virtual ICollection<Sachkostenzeile> Sachkostenzeiles { get; set; }
        public virtual ICollection<StrategischeKalkulationKalkulation> StrategischeKalkulationKalkulations { get; set; }
        public virtual ICollection<UrraumnutzkategorieKalkulation> UrraumnutzkategorieKalkulations { get; set; }
        public virtual ICollection<Urraum> Urraums { get; set; }
        public virtual ICollection<Vertretungspersonal> Vertretungspersonals { get; set; }
        public virtual ICollection<Verwaltungsumlage> VerwaltungsumlageKalkulationBesitzers { get; set; }
        public virtual ICollection<Verwaltungsumlage> VerwaltungsumlageKalkulationGehoertZus { get; set; }
    }
}
