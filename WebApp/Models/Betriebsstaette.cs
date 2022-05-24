using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Betriebsstaette
    {
        public Betriebsstaette()
        {
            Angebots = new HashSet<Angebot>();
            Ansprechpartners = new HashSet<Ansprechpartner>();
            Bestellungs = new HashSet<Bestellung>();
            BetriebsstaetteSachkontoKostenstelleDienstarts = new HashSet<BetriebsstaetteSachkontoKostenstelleDienstart>();
            BetriebsstaetteVerprobungsfaktors = new HashSet<BetriebsstaetteVerprobungsfaktor>();
            BetriebsstaetteVorgabewertes = new HashSet<BetriebsstaetteVorgabewerte>();
            BetriebsstaetteWareneinsatzs = new HashSet<BetriebsstaetteWareneinsatz>();
            Betriebsstaettedarlehens = new HashSet<Betriebsstaettedarlehen>();
            BsRechtes = new HashSet<BsRechte>();
            BuchungstagDefinitions = new HashSet<BuchungstagDefinition>();
            DiamantExports = new HashSet<DiamantExport>();
            Einrichtungskapazitaets = new HashSet<Einrichtungskapazitaet>();
            FaktorenPvists = new HashSet<FaktorenPvist>();
            FaktorenPvsolls = new HashSet<FaktorenPvsoll>();
            Finanzplanungs = new HashSet<Finanzplanung>();
            Kalkulations = new HashSet<Kalkulation>();
            Kontaktinformations = new HashSet<Kontaktinformation>();
            KostenstelleSachkontoBetriebsstaettes = new HashSet<KostenstelleSachkontoBetriebsstaette>();
            Kostenstelles = new HashSet<Kostenstelle>();
            Lagers = new HashSet<Lager>();
            Lieferants = new HashSet<Lieferant>();
            Pflegesaetzes = new HashSet<Pflegesaetze>();
            PlanbilanzMittelfristplanungs = new HashSet<PlanbilanzMittelfristplanung>();
            Planbilanzs = new HashSet<Planbilanz>();
            SachkontoProzentBetriebsstaettes = new HashSet<SachkontoProzentBetriebsstaette>();
            StrategischeKalkulations = new HashSet<StrategischeKalkulation>();
            VerteilungBekoestigungstages = new HashSet<VerteilungBekoestigungstage>();
            Wawistatistiks = new HashSet<Wawistatistik>();
            Wohnungs = new HashSet<Wohnung>();
        }

        public int Id { get; set; }
        public int? TraegerId { get; set; }
        public int? BundeslandId { get; set; }
        public int? RegionaleZuordnungId { get; set; }
        public int? AdresseId { get; set; }
        public int? TypId { get; set; }
        public int? MandantId { get; set; }
        public int? ZGasachkontoId { get; set; }
        public int? BenutzerGeoffnetId { get; set; }
        public int? BenutzerId { get; set; }
        public int? SchnittstelleneinstellungId { get; set; }
        public int? BenutzerGebietsleiterId { get; set; }
        public string Name { get; set; }
        public string Kundennr { get; set; }
        public string Bemerkung { get; set; }
        public double? Stundenwoche { get; set; }
        public bool Deaktiviert { get; set; }
        public DateTime? DatumGesperrt { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool? IstAbgeschlossen { get; set; }
        public bool Aktiv { get; set; }
        public double FestesPersonal { get; set; }
        public bool ImportNurAngelegteKst { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Benutzer BenutzerGebietsleiter { get; set; }
        public virtual Benutzer BenutzerGeoffnet { get; set; }
        public virtual Bundesland Bundesland { get; set; }
        public virtual Mandant Mandant { get; set; }
        public virtual RegionaleZuordnung RegionaleZuordnung { get; set; }
        public virtual Schnittstelleneinstellung Schnittstelleneinstellung { get; set; }
        public virtual Traeger Traeger { get; set; }
        public virtual Typ Typ { get; set; }
        public virtual Sachkonto ZGasachkonto { get; set; }
        public virtual ICollection<Angebot> Angebots { get; set; }
        public virtual ICollection<Ansprechpartner> Ansprechpartners { get; set; }
        public virtual ICollection<Bestellung> Bestellungs { get; set; }
        public virtual ICollection<BetriebsstaetteSachkontoKostenstelleDienstart> BetriebsstaetteSachkontoKostenstelleDienstarts { get; set; }
        public virtual ICollection<BetriebsstaetteVerprobungsfaktor> BetriebsstaetteVerprobungsfaktors { get; set; }
        public virtual ICollection<BetriebsstaetteVorgabewerte> BetriebsstaetteVorgabewertes { get; set; }
        public virtual ICollection<BetriebsstaetteWareneinsatz> BetriebsstaetteWareneinsatzs { get; set; }
        public virtual ICollection<Betriebsstaettedarlehen> Betriebsstaettedarlehens { get; set; }
        public virtual ICollection<BsRechte> BsRechtes { get; set; }
        public virtual ICollection<BuchungstagDefinition> BuchungstagDefinitions { get; set; }
        public virtual ICollection<DiamantExport> DiamantExports { get; set; }
        public virtual ICollection<Einrichtungskapazitaet> Einrichtungskapazitaets { get; set; }
        public virtual ICollection<FaktorenPvist> FaktorenPvists { get; set; }
        public virtual ICollection<FaktorenPvsoll> FaktorenPvsolls { get; set; }
        public virtual ICollection<Finanzplanung> Finanzplanungs { get; set; }
        public virtual ICollection<Kalkulation> Kalkulations { get; set; }
        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
        public virtual ICollection<KostenstelleSachkontoBetriebsstaette> KostenstelleSachkontoBetriebsstaettes { get; set; }
        public virtual ICollection<Kostenstelle> Kostenstelles { get; set; }
        public virtual ICollection<Lager> Lagers { get; set; }
        public virtual ICollection<Lieferant> Lieferants { get; set; }
        public virtual ICollection<Pflegesaetze> Pflegesaetzes { get; set; }
        public virtual ICollection<PlanbilanzMittelfristplanung> PlanbilanzMittelfristplanungs { get; set; }
        public virtual ICollection<Planbilanz> Planbilanzs { get; set; }
        public virtual ICollection<SachkontoProzentBetriebsstaette> SachkontoProzentBetriebsstaettes { get; set; }
        public virtual ICollection<StrategischeKalkulation> StrategischeKalkulations { get; set; }
        public virtual ICollection<VerteilungBekoestigungstage> VerteilungBekoestigungstages { get; set; }
        public virtual ICollection<Wawistatistik> Wawistatistiks { get; set; }
        public virtual ICollection<Wohnung> Wohnungs { get; set; }
    }
}
