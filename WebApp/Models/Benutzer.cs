using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Benutzer
    {
        public Benutzer()
        {
            Altersvorsorges = new HashSet<Altersvorsorge>();
            Angebots = new HashSet<Angebot>();
            Arbeitskreis = new HashSet<Arbeitskrei>();
            ArtikelmerklisteEintrags = new HashSet<ArtikelmerklisteEintrag>();
            AuftragAuftragstatuses = new HashSet<AuftragAuftragstatus>();
            Auftrags = new HashSet<Auftrag>();
            BelegJournals = new HashSet<BelegJournal>();
            Belegs = new HashSet<Beleg>();
            BenutzerAktions = new HashSet<BenutzerAktion>();
            BenutzerGruppes = new HashSet<BenutzerGruppe>();
            BenutzerLizenzs = new HashSet<BenutzerLizenz>();
            BenutzerSeitenElements = new HashSet<BenutzerSeitenElement>();
            BenutzerSignaturs = new HashSet<BenutzerSignatur>();
            BenutzerUebersichts = new HashSet<BenutzerUebersicht>();
            Benutzereinstellungens = new HashSet<Benutzereinstellungen>();
            BerechtigungBenutzerBerechtigungs = new HashSet<BerechtigungBenutzerBerechtigung>();
            Berufsgruppes = new HashSet<Berufsgruppe>();
            Bestands = new HashSet<Bestand>();
            Bestandsbewegungs = new HashSet<Bestandsbewegung>();
            BestellObjekts = new HashSet<BestellObjekt>();
            Bestellungs = new HashSet<Bestellung>();
            BetriebsstaetteBenutzerGebietsleiters = new HashSet<Betriebsstaette>();
            BetriebsstaetteBenutzerGeoffnets = new HashSet<Betriebsstaette>();
            BetriebsstaetteBenutzers = new HashSet<Betriebsstaette>();
            BetriebsstaetteWareneinsatzs = new HashSet<BetriebsstaetteWareneinsatz>();
            BuchungstagDefinitions = new HashSet<BuchungstagDefinition>();
            Dateis = new HashSet<Datei>();
            Dateivorlages = new HashSet<Dateivorlage>();
            DiamantExports = new HashSet<DiamantExport>();
            Finanzplanungs = new HashSet<Finanzplanung>();
            Gruppes = new HashSet<Gruppe>();
            ImportLogs = new HashSet<ImportLog>();
            InternesKontos = new HashSet<InternesKonto>();
            Inventurs = new HashSet<Inventur>();
            InverseLetzterBearbeiter = new HashSet<Benutzer>();
            KalkulationAuslastungsarts = new HashSet<KalkulationAuslastungsart>();
            KalkulationKommentars = new HashSet<KalkulationKommentar>();
            Kalkulations = new HashSet<Kalkulation>();
            Kennzahlenberichts = new HashSet<Kennzahlenbericht>();
            Kennzahls = new HashSet<Kennzahl>();
            Konsolidierungs = new HashSet<Konsolidierung>();
            Kontaktinformations = new HashSet<Kontaktinformation>();
            Kontobewegungs = new HashSet<Kontobewegung>();
            Kostenstelles = new HashSet<Kostenstelle>();
            Kundes = new HashSet<Kunde>();
            Lagers = new HashSet<Lager>();
            Lieferants = new HashSet<Lieferant>();
            Mahnungs = new HashSet<Mahnung>();
            MailNachrichts = new HashSet<MailNachricht>();
            Menueplans = new HashSet<Menueplan>();
            Mitarbeiters = new HashSet<Mitarbeiter>();
            Newsletters = new HashSet<Newsletter>();
            Personalplans = new HashSet<Personalplan>();
            PlanbilanzMittelfristplanungs = new HashSet<PlanbilanzMittelfristplanung>();
            Planbilanzs = new HashSet<Planbilanz>();
            Rezepts = new HashSet<Rezept>();
            Sperrobjekts = new HashSet<Sperrobjekt>();
            StrategischeKalkulations = new HashSet<StrategischeKalkulation>();
            Tarifs = new HashSet<Tarif>();
            TaskDueuserNavigations = new HashSet<Task>();
            TaskSenduserNavigations = new HashSet<Task>();
            Transfers = new HashSet<Transfer>();
            Veranstaltungs = new HashSet<Veranstaltung>();
            Verleihartikels = new HashSet<Verleihartikel>();
            Verteilers = new HashSet<Verteiler>();
            Verwaltungsumlages = new HashSet<Verwaltungsumlage>();
            Zuschlags = new HashSet<Zuschlag>();
        }

        public int Id { get; set; }
        public int? RechteId { get; set; }
        public int? AdresseId { get; set; }
        public int? LetzterBearbeiterId { get; set; }
        public int? RegionaleZuordnungId { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Username { get; set; }
        public string Passwort { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Benutzer LetzterBearbeiter { get; set; }
        public virtual Rechte Rechte { get; set; }
        public virtual RegionaleZuordnung RegionaleZuordnung { get; set; }
        public virtual ICollection<Altersvorsorge> Altersvorsorges { get; set; }
        public virtual ICollection<Angebot> Angebots { get; set; }
        public virtual ICollection<Arbeitskrei> Arbeitskreis { get; set; }
        public virtual ICollection<ArtikelmerklisteEintrag> ArtikelmerklisteEintrags { get; set; }
        public virtual ICollection<AuftragAuftragstatus> AuftragAuftragstatuses { get; set; }
        public virtual ICollection<Auftrag> Auftrags { get; set; }
        public virtual ICollection<BelegJournal> BelegJournals { get; set; }
        public virtual ICollection<Beleg> Belegs { get; set; }
        public virtual ICollection<BenutzerAktion> BenutzerAktions { get; set; }
        public virtual ICollection<BenutzerGruppe> BenutzerGruppes { get; set; }
        public virtual ICollection<BenutzerLizenz> BenutzerLizenzs { get; set; }
        public virtual ICollection<BenutzerSeitenElement> BenutzerSeitenElements { get; set; }
        public virtual ICollection<BenutzerSignatur> BenutzerSignaturs { get; set; }
        public virtual ICollection<BenutzerUebersicht> BenutzerUebersichts { get; set; }
        public virtual ICollection<Benutzereinstellungen> Benutzereinstellungens { get; set; }
        public virtual ICollection<BerechtigungBenutzerBerechtigung> BerechtigungBenutzerBerechtigungs { get; set; }
        public virtual ICollection<Berufsgruppe> Berufsgruppes { get; set; }
        public virtual ICollection<Bestand> Bestands { get; set; }
        public virtual ICollection<Bestandsbewegung> Bestandsbewegungs { get; set; }
        public virtual ICollection<BestellObjekt> BestellObjekts { get; set; }
        public virtual ICollection<Bestellung> Bestellungs { get; set; }
        public virtual ICollection<Betriebsstaette> BetriebsstaetteBenutzerGebietsleiters { get; set; }
        public virtual ICollection<Betriebsstaette> BetriebsstaetteBenutzerGeoffnets { get; set; }
        public virtual ICollection<Betriebsstaette> BetriebsstaetteBenutzers { get; set; }
        public virtual ICollection<BetriebsstaetteWareneinsatz> BetriebsstaetteWareneinsatzs { get; set; }
        public virtual ICollection<BuchungstagDefinition> BuchungstagDefinitions { get; set; }
        public virtual ICollection<Datei> Dateis { get; set; }
        public virtual ICollection<Dateivorlage> Dateivorlages { get; set; }
        public virtual ICollection<DiamantExport> DiamantExports { get; set; }
        public virtual ICollection<Finanzplanung> Finanzplanungs { get; set; }
        public virtual ICollection<Gruppe> Gruppes { get; set; }
        public virtual ICollection<ImportLog> ImportLogs { get; set; }
        public virtual ICollection<InternesKonto> InternesKontos { get; set; }
        public virtual ICollection<Inventur> Inventurs { get; set; }
        public virtual ICollection<Benutzer> InverseLetzterBearbeiter { get; set; }
        public virtual ICollection<KalkulationAuslastungsart> KalkulationAuslastungsarts { get; set; }
        public virtual ICollection<KalkulationKommentar> KalkulationKommentars { get; set; }
        public virtual ICollection<Kalkulation> Kalkulations { get; set; }
        public virtual ICollection<Kennzahlenbericht> Kennzahlenberichts { get; set; }
        public virtual ICollection<Kennzahl> Kennzahls { get; set; }
        public virtual ICollection<Konsolidierung> Konsolidierungs { get; set; }
        public virtual ICollection<Kontaktinformation> Kontaktinformations { get; set; }
        public virtual ICollection<Kontobewegung> Kontobewegungs { get; set; }
        public virtual ICollection<Kostenstelle> Kostenstelles { get; set; }
        public virtual ICollection<Kunde> Kundes { get; set; }
        public virtual ICollection<Lager> Lagers { get; set; }
        public virtual ICollection<Lieferant> Lieferants { get; set; }
        public virtual ICollection<Mahnung> Mahnungs { get; set; }
        public virtual ICollection<MailNachricht> MailNachrichts { get; set; }
        public virtual ICollection<Menueplan> Menueplans { get; set; }
        public virtual ICollection<Mitarbeiter> Mitarbeiters { get; set; }
        public virtual ICollection<Newsletter> Newsletters { get; set; }
        public virtual ICollection<Personalplan> Personalplans { get; set; }
        public virtual ICollection<PlanbilanzMittelfristplanung> PlanbilanzMittelfristplanungs { get; set; }
        public virtual ICollection<Planbilanz> Planbilanzs { get; set; }
        public virtual ICollection<Rezept> Rezepts { get; set; }
        public virtual ICollection<Sperrobjekt> Sperrobjekts { get; set; }
        public virtual ICollection<StrategischeKalkulation> StrategischeKalkulations { get; set; }
        public virtual ICollection<Tarif> Tarifs { get; set; }
        public virtual ICollection<Task> TaskDueuserNavigations { get; set; }
        public virtual ICollection<Task> TaskSenduserNavigations { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual ICollection<Veranstaltung> Veranstaltungs { get; set; }
        public virtual ICollection<Verleihartikel> Verleihartikels { get; set; }
        public virtual ICollection<Verteiler> Verteilers { get; set; }
        public virtual ICollection<Verwaltungsumlage> Verwaltungsumlages { get; set; }
        public virtual ICollection<Zuschlag> Zuschlags { get; set; }
    }
}
