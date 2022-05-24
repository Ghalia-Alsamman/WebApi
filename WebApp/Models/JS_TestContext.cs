using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApp.Models
{
    public partial class JS_TestContext : DbContext
    {
        public JS_TestContext()
        {
        }

        public JS_TestContext(DbContextOptions<JS_TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abrechnung> Abrechnungs { get; set; }
        public virtual DbSet<Abwesenheitsregel> Abwesenheitsregels { get; set; }
        public virtual DbSet<Adressart> Adressarts { get; set; }
        public virtual DbSet<Adresse> Adresses { get; set; }
        public virtual DbSet<Aenderungslog> Aenderungslogs { get; set; }
        public virtual DbSet<AfAzeile> AfAzeiles { get; set; }
        public virtual DbSet<Altersvorsorge> Altersvorsorges { get; set; }
        public virtual DbSet<AltersvorsorgeDetail> AltersvorsorgeDetails { get; set; }
        public virtual DbSet<Angebot> Angebots { get; set; }
        public virtual DbSet<Anlageart> Anlagearts { get; set; }
        public virtual DbSet<Anlagengruppe> Anlagengruppes { get; set; }
        public virtual DbSet<Anrede> Anredes { get; set; }
        public virtual DbSet<Ansprechpartner> Ansprechpartners { get; set; }
        public virtual DbSet<AnsprechpartnerKunde> AnsprechpartnerKundes { get; set; }
        public virtual DbSet<AnsprechpartnerLieferant> AnsprechpartnerLieferants { get; set; }
        public virtual DbSet<Ansprechpartnerart> Ansprechpartnerarts { get; set; }
        public virtual DbSet<Arbeitskrei> Arbeitskreis { get; set; }
        public virtual DbSet<Arbeitstage> Arbeitstages { get; set; }
        public virtual DbSet<Artikel> Artikels { get; set; }
        public virtual DbSet<ArtikelArtikelattribut> ArtikelArtikelattributs { get; set; }
        public virtual DbSet<ArtikelEinkauf> ArtikelEinkaufs { get; set; }
        public virtual DbSet<ArtikelPrei> ArtikelPreis { get; set; }
        public virtual DbSet<ArtikelVerkauf> ArtikelVerkaufs { get; set; }
        public virtual DbSet<ArtikelVerkaufArtikelattribut> ArtikelVerkaufArtikelattributs { get; set; }
        public virtual DbSet<Artikelattribut> Artikelattributs { get; set; }
        public virtual DbSet<Artikelliste> Artikellistes { get; set; }
        public virtual DbSet<ArtikelmerklisteEintrag> ArtikelmerklisteEintrags { get; set; }
        public virtual DbSet<Auftrag> Auftrags { get; set; }
        public virtual DbSet<AuftragArtikelVerkauf> AuftragArtikelVerkaufs { get; set; }
        public virtual DbSet<AuftragAuftragstatus> AuftragAuftragstatuses { get; set; }
        public virtual DbSet<AuftragMenueplanZeitpunkt> AuftragMenueplanZeitpunkts { get; set; }
        public virtual DbSet<AuftragVerleihartikel> AuftragVerleihartikels { get; set; }
        public virtual DbSet<AuftragZuschlag> AuftragZuschlags { get; set; }
        public virtual DbSet<Auftragstatus> Auftragstatuses { get; set; }
        public virtual DbSet<AuftragsverwaltungStatischerBereichBerechtigung> AuftragsverwaltungStatischerBereichBerechtigungs { get; set; }
        public virtual DbSet<Aufwand> Aufwands { get; set; }
        public virtual DbSet<AuslastungMonat> AuslastungMonats { get; set; }
        public virtual DbSet<Auslastungsart> Auslastungsarts { get; set; }
        public virtual DbSet<Auslastungszeile> Auslastungszeiles { get; set; }
        public virtual DbSet<Bekoestigungstage> Bekoestigungstages { get; set; }
        public virtual DbSet<BekoestigungstageCateringMahlzeit> BekoestigungstageCateringMahlzeits { get; set; }
        public virtual DbSet<Beleg> Belegs { get; set; }
        public virtual DbSet<BelegJournal> BelegJournals { get; set; }
        public virtual DbSet<Belegart> Belegarts { get; set; }
        public virtual DbSet<Benutzer> Benutzers { get; set; }
        public virtual DbSet<BenutzerAktion> BenutzerAktions { get; set; }
        public virtual DbSet<BenutzerAktionsart> BenutzerAktionsarts { get; set; }
        public virtual DbSet<BenutzerGruppe> BenutzerGruppes { get; set; }
        public virtual DbSet<BenutzerLizenz> BenutzerLizenzs { get; set; }
        public virtual DbSet<BenutzerSeitenElement> BenutzerSeitenElements { get; set; }
        public virtual DbSet<BenutzerSignatur> BenutzerSignaturs { get; set; }
        public virtual DbSet<BenutzerUebersicht> BenutzerUebersichts { get; set; }
        public virtual DbSet<BenutzerUebersichtBasis> BenutzerUebersichtBases { get; set; }
        public virtual DbSet<BenutzerUebersichtBasisTyp> BenutzerUebersichtBasisTyps { get; set; }
        public virtual DbSet<BenutzerUebersichtBasisTypBenutzerUebersichtOperator> BenutzerUebersichtBasisTypBenutzerUebersichtOperators { get; set; }
        public virtual DbSet<BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperator> BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperators { get; set; }
        public virtual DbSet<BenutzerUebersichtOperator> BenutzerUebersichtOperators { get; set; }
        public virtual DbSet<Benutzereinstellungen> Benutzereinstellungens { get; set; }
        public virtual DbSet<Berechtigung> Berechtigungs { get; set; }
        public virtual DbSet<BerechtigungBenutzerBerechtigung> BerechtigungBenutzerBerechtigungs { get; set; }
        public virtual DbSet<BerechtigungBerechtigung> BerechtigungBerechtigungs { get; set; }
        public virtual DbSet<BerechtigungGruppeBerechtigung> BerechtigungGruppeBerechtigungs { get; set; }
        public virtual DbSet<BerechtigungKategorie> BerechtigungKategories { get; set; }
        public virtual DbSet<BerechtigungKlasseTyp> BerechtigungKlasseTyps { get; set; }
        public virtual DbSet<BerechtigungKlasseTypEinschraenkung> BerechtigungKlasseTypEinschraenkungs { get; set; }
        public virtual DbSet<BerechtigungKomponente> BerechtigungKomponentes { get; set; }
        public virtual DbSet<BerechtigungKomponenteBerechtigung> BerechtigungKomponenteBerechtigungs { get; set; }
        public virtual DbSet<BerechtigungOberklasseAequivalentZu> BerechtigungOberklasseAequivalentZus { get; set; }
        public virtual DbSet<BerechtigungObjektTyp> BerechtigungObjektTyps { get; set; }
        public virtual DbSet<Berufsgruppe> Berufsgruppes { get; set; }
        public virtual DbSet<BerufsgruppeSachkonto> BerufsgruppeSachkontos { get; set; }
        public virtual DbSet<Bestand> Bestands { get; set; }
        public virtual DbSet<BestandLagerArtikel> BestandLagerArtikels { get; set; }
        public virtual DbSet<Bestandsbewegung> Bestandsbewegungs { get; set; }
        public virtual DbSet<BestellObjekt> BestellObjekts { get; set; }
        public virtual DbSet<BestellObjektArtikel> BestellObjektArtikels { get; set; }
        public virtual DbSet<BestellObjektStatus> BestellObjektStatuses { get; set; }
        public virtual DbSet<Bestellung> Bestellungs { get; set; }
        public virtual DbSet<BestellungLagerArtikel> BestellungLagerArtikels { get; set; }
        public virtual DbSet<Betriebsstaette> Betriebsstaettes { get; set; }
        public virtual DbSet<BetriebsstaetteSachkontoKostenstelleDienstart> BetriebsstaetteSachkontoKostenstelleDienstarts { get; set; }
        public virtual DbSet<BetriebsstaetteVerprobungsfaktor> BetriebsstaetteVerprobungsfaktors { get; set; }
        public virtual DbSet<BetriebsstaetteVorgabewerte> BetriebsstaetteVorgabewertes { get; set; }
        public virtual DbSet<BetriebsstaetteWareneinsatz> BetriebsstaetteWareneinsatzs { get; set; }
        public virtual DbSet<Betriebsstaettedarlehen> Betriebsstaettedarlehens { get; set; }
        public virtual DbSet<BetriebsstaettedarlehenTilgungsplan> BetriebsstaettedarlehenTilgungsplans { get; set; }
        public virtual DbSet<Bild> Bilds { get; set; }
        public virtual DbSet<Boardkategorie> Boardkategories { get; set; }
        public virtual DbSet<Boardmeldungen> Boardmeldungens { get; set; }
        public virtual DbSet<BsRechte> BsRechtes { get; set; }
        public virtual DbSet<Buchungstag> Buchungstags { get; set; }
        public virtual DbSet<BuchungstagDefinition> BuchungstagDefinitions { get; set; }
        public virtual DbSet<Bundesland> Bundeslands { get; set; }
        public virtual DbSet<CateringAllgemein> CateringAllgemeins { get; set; }
        public virtual DbSet<CateringArbeitsschritte> CateringArbeitsschrittes { get; set; }
        public virtual DbSet<CateringArbeitsschritteMahlzeit> CateringArbeitsschritteMahlzeits { get; set; }
        public virtual DbSet<CateringEinheiten> CateringEinheitens { get; set; }
        public virtual DbSet<CateringMahlzeit> CateringMahlzeits { get; set; }
        public virtual DbSet<CateringProduktivzeiten> CateringProduktivzeitens { get; set; }
        public virtual DbSet<Checklisteintrag> Checklisteintrags { get; set; }
        public virtual DbSet<ChecklisteintragArt> ChecklisteintragArts { get; set; }
        public virtual DbSet<ChecklisteneintragVeranstaltung> ChecklisteneintragVeranstaltungs { get; set; }
        public virtual DbSet<Darlehen> Darlehens { get; set; }
        public virtual DbSet<DarlehenTypen> DarlehenTypens { get; set; }
        public virtual DbSet<DarlehenZusatztilgung> DarlehenZusatztilgungs { get; set; }
        public virtual DbSet<Datei> Dateis { get; set; }
        public virtual DbSet<Dateiart> Dateiarts { get; set; }
        public virtual DbSet<Dateiverknuepfung> Dateiverknuepfungs { get; set; }
        public virtual DbSet<Dateivorlage> Dateivorlages { get; set; }
        public virtual DbSet<Datenbankverbindungen> Datenbankverbindungens { get; set; }
        public virtual DbSet<DefaultCateringTageImJahr> DefaultCateringTageImJahrs { get; set; }
        public virtual DbSet<DefaultCateringTageImJahrFeiertage> DefaultCateringTageImJahrFeiertages { get; set; }
        public virtual DbSet<DefaultNettokosten> DefaultNettokostens { get; set; }
        public virtual DbSet<DefaultVertretungspersonal> DefaultVertretungspersonals { get; set; }
        public virtual DbSet<DiamantExport> DiamantExports { get; set; }
        public virtual DbSet<DiamantExportDatensatz> DiamantExportDatensatzs { get; set; }
        public virtual DbSet<Dienst> Diensts { get; set; }
        public virtual DbSet<DienstKonfiguration> DienstKonfigurations { get; set; }
        public virtual DbSet<Dinnorm> Dinnorms { get; set; }
        public virtual DbSet<Einheit> Einheits { get; set; }
        public virtual DbSet<Einrichtungskapazitaet> Einrichtungskapazitaets { get; set; }
        public virtual DbSet<Einstellungen> Einstellungens { get; set; }
        public virtual DbSet<Ergebnisbewertung> Ergebnisbewertungs { get; set; }
        public virtual DbSet<Erloesplanungszeile> Erloesplanungszeiles { get; set; }
        public virtual DbSet<FaktorenPvist> FaktorenPvists { get; set; }
        public virtual DbSet<FaktorenPvsoll> FaktorenPvsolls { get; set; }
        public virtual DbSet<Finanzinstitut> Finanzinstituts { get; set; }
        public virtual DbSet<Finanzplanung> Finanzplanungs { get; set; }
        public virtual DbSet<FortschrittsanzeigeKategorie> FortschrittsanzeigeKategories { get; set; }
        public virtual DbSet<FortschrittsanzeigeKategorieSachkonto> FortschrittsanzeigeKategorieSachkontos { get; set; }
        public virtual DbSet<FtpZugangsdaten> FtpZugangsdatens { get; set; }
        public virtual DbSet<GrenzwerteFuerPersonalplanung> GrenzwerteFuerPersonalplanungs { get; set; }
        public virtual DbSet<Gruppe> Gruppes { get; set; }
        public virtual DbSet<GuvSummenzeile> GuvSummenzeiles { get; set; }
        public virtual DbSet<GwgVorgabewerte> GwgVorgabewertes { get; set; }
        public virtual DbSet<ImportHochrechnung> ImportHochrechnungs { get; set; }
        public virtual DbSet<ImportLog> ImportLogs { get; set; }
        public virtual DbSet<ImportSachkosten> ImportSachkostens { get; set; }
        public virtual DbSet<InternesKonto> InternesKontos { get; set; }
        public virtual DbSet<Inventur> Inventurs { get; set; }
        public virtual DbSet<InventurLagerArtikel> InventurLagerArtikels { get; set; }
        public virtual DbSet<InventurLagerArtikelAbweichungsgrund> InventurLagerArtikelAbweichungsgrunds { get; set; }
        public virtual DbSet<Kalkulation> Kalkulations { get; set; }
        public virtual DbSet<KalkulationAngebot> KalkulationAngebots { get; set; }
        public virtual DbSet<KalkulationArtikel> KalkulationArtikels { get; set; }
        public virtual DbSet<KalkulationAufschlaege> KalkulationAufschlaeges { get; set; }
        public virtual DbSet<KalkulationAuslastungsart> KalkulationAuslastungsarts { get; set; }
        public virtual DbSet<KalkulationBrotkruemeldefinition> KalkulationBrotkruemeldefinitions { get; set; }
        public virtual DbSet<KalkulationKommentar> KalkulationKommentars { get; set; }
        public virtual DbSet<KalkulationKonsolidierung> KalkulationKonsolidierungs { get; set; }
        public virtual DbSet<KalkulationVerprobung> KalkulationVerprobungs { get; set; }
        public virtual DbSet<KalkulationWohnung> KalkulationWohnungs { get; set; }
        public virtual DbSet<Kalkulationsart> Kalkulationsarts { get; set; }
        public virtual DbSet<KalkulationsartBerechtigungLesen> KalkulationsartBerechtigungLesens { get; set; }
        public virtual DbSet<Kalkulationskennzahl> Kalkulationskennzahls { get; set; }
        public virtual DbSet<Kampagne> Kampagnes { get; set; }
        public virtual DbSet<KampagneGruppen> KampagneGruppens { get; set; }
        public virtual DbSet<Kennzahl> Kennzahls { get; set; }
        public virtual DbSet<KennzahlElement> KennzahlElements { get; set; }
        public virtual DbSet<KennzahlElementTyp> KennzahlElementTyps { get; set; }
        public virtual DbSet<KennzahlKennzahlenbericht> KennzahlKennzahlenberichts { get; set; }
        public virtual DbSet<KennzahlOperator> KennzahlOperators { get; set; }
        public virtual DbSet<Kennzahlenbericht> Kennzahlenberichts { get; set; }
        public virtual DbSet<Kommentar> Kommentars { get; set; }
        public virtual DbSet<Konsolidierung> Konsolidierungs { get; set; }
        public virtual DbSet<KonsolidierungAfAzeile> KonsolidierungAfAzeiles { get; set; }
        public virtual DbSet<KonsolidierungAuslastungsblock> KonsolidierungAuslastungsblocks { get; set; }
        public virtual DbSet<KonsolidierungAuslastungsblocktyp> KonsolidierungAuslastungsblocktyps { get; set; }
        public virtual DbSet<KonsolidierungAuslastungszeile> KonsolidierungAuslastungszeiles { get; set; }
        public virtual DbSet<KonsolidierungAuslastungszeilentyp> KonsolidierungAuslastungszeilentyps { get; set; }
        public virtual DbSet<KonsolidierungDarlehen> KonsolidierungDarlehens { get; set; }
        public virtual DbSet<KonsolidierungDataset> KonsolidierungDatasets { get; set; }
        public virtual DbSet<KonsolidierungDatenExport> KonsolidierungDatenExports { get; set; }
        public virtual DbSet<KonsolidierungImportHochrechnung> KonsolidierungImportHochrechnungs { get; set; }
        public virtual DbSet<KonsolidierungImportVorjahr> KonsolidierungImportVorjahrs { get; set; }
        public virtual DbSet<KonsolidierungPersonal> KonsolidierungPersonals { get; set; }
        public virtual DbSet<KonsolidierungPersonaleinsatz> KonsolidierungPersonaleinsatzs { get; set; }
        public virtual DbSet<KonsolidierungPersonalzusatzkosten> KonsolidierungPersonalzusatzkostens { get; set; }
        public virtual DbSet<KonsolidierungPraemie> KonsolidierungPraemies { get; set; }
        public virtual DbSet<KonsolidierungSachkostenVerteilungKst> KonsolidierungSachkostenVerteilungKsts { get; set; }
        public virtual DbSet<KonsolidierungSachkostenzeile> KonsolidierungSachkostenzeiles { get; set; }
        public virtual DbSet<KonsolidierungSonderposten> KonsolidierungSonderpostens { get; set; }
        public virtual DbSet<KonsolidierungVerprobung> KonsolidierungVerprobungs { get; set; }
        public virtual DbSet<KonsolidierungWohnung> KonsolidierungWohnungs { get; set; }
        public virtual DbSet<Kontaktinformation> Kontaktinformations { get; set; }
        public virtual DbSet<Konto> Kontos { get; set; }
        public virtual DbSet<Kontobewegung> Kontobewegungs { get; set; }
        public virtual DbSet<Kontoinformation> Kontoinformations { get; set; }
        public virtual DbSet<Kostenbereich> Kostenbereiches { get; set; }
        public virtual DbSet<Kostenstelle> Kostenstelles { get; set; }
        public virtual DbSet<KostenstellePflegestufe> KostenstellePflegestuves { get; set; }
        public virtual DbSet<KostenstelleSachkontoBetriebsstaette> KostenstelleSachkontoBetriebsstaettes { get; set; }
        public virtual DbSet<KostenstelleVorgabename> KostenstelleVorgabenames { get; set; }
        public virtual DbSet<Kostenstellenbereich> Kostenstellenbereiches { get; set; }
        public virtual DbSet<Kunde> Kundes { get; set; }
        public virtual DbSet<KundeArtikel> KundeArtikels { get; set; }
        public virtual DbSet<KundeLoesung> KundeLoesungs { get; set; }
        public virtual DbSet<KundeSegment> KundeSegments { get; set; }
        public virtual DbSet<KundeVerleihartikel> KundeVerleihartikels { get; set; }
        public virtual DbSet<Kundenart> Kundenarts { get; set; }
        public virtual DbSet<Kundenkategorie> Kundenkategories { get; set; }
        public virtual DbSet<Lager> Lagers { get; set; }
        public virtual DbSet<LagerArtikel> LagerArtikels { get; set; }
        public virtual DbSet<LagerWarenwirtschaftskomponente> LagerWarenwirtschaftskomponentes { get; set; }
        public virtual DbSet<Land> Lands { get; set; }
        public virtual DbSet<Lieferant> Lieferants { get; set; }
        public virtual DbSet<LieferantMailZugangsdaten> LieferantMailZugangsdatens { get; set; }
        public virtual DbSet<Lieferdaten> Lieferdatens { get; set; }
        public virtual DbSet<LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelle> LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelles { get; set; }
        public virtual DbSet<LiquiditaetsplanungKostenstelle> LiquiditaetsplanungKostenstelles { get; set; }
        public virtual DbSet<LiquiditaetsplanungVorgabenaman> LiquiditaetsplanungVorgabenamen { get; set; }
        public virtual DbSet<LiquiditaetsplanungZeile> LiquiditaetsplanungZeiles { get; set; }
        public virtual DbSet<Liquiditaetsplanungkonto> Liquiditaetsplanungkontos { get; set; }
        public virtual DbSet<Lizenz> Lizenzs { get; set; }
        public virtual DbSet<Loesung> Loesungs { get; set; }
        public virtual DbSet<Lohn> Lohns { get; set; }
        public virtual DbSet<Mahnung> Mahnungs { get; set; }
        public virtual DbSet<MailEmpfaenger> MailEmpfaengers { get; set; }
        public virtual DbSet<MailEmpfaengerart> MailEmpfaengerarts { get; set; }
        public virtual DbSet<MailMeldung> MailMeldungs { get; set; }
        public virtual DbSet<MailNachricht> MailNachrichts { get; set; }
        public virtual DbSet<MailZugangsdaten> MailZugangsdatens { get; set; }
        public virtual DbSet<Mailadressart> Mailadressarts { get; set; }
        public virtual DbSet<Mailadresse> Mailadresses { get; set; }
        public virtual DbSet<Mandant> Mandants { get; set; }
        public virtual DbSet<Massgroesse> Massgroesses { get; set; }
        public virtual DbSet<Mengeneinheit> Mengeneinheits { get; set; }
        public virtual DbSet<MenueAlternative> MenueAlternatives { get; set; }
        public virtual DbSet<Menueplan> Menueplans { get; set; }
        public virtual DbSet<MenueplanKunde> MenueplanKundes { get; set; }
        public virtual DbSet<MenueplanTag> MenueplanTags { get; set; }
        public virtual DbSet<MenueplanZeitpunkt> MenueplanZeitpunkts { get; set; }
        public virtual DbSet<MenueplanZeitpunktArtikelverkaufRezept> MenueplanZeitpunktArtikelverkaufRezepts { get; set; }
        public virtual DbSet<Menueplankategorie> Menueplankategories { get; set; }
        public virtual DbSet<MenuplanEigenschaft> MenuplanEigenschafts { get; set; }
        public virtual DbSet<Mitarbeiter> Mitarbeiters { get; set; }
        public virtual DbSet<Mitgliedsbeitrag> Mitgliedsbeitrags { get; set; }
        public virtual DbSet<Mitgliedschaft> Mitgliedschafts { get; set; }
        public virtual DbSet<MitgliedschaftArt> MitgliedschaftArts { get; set; }
        public virtual DbSet<Navigationsbereich> Navigationsbereiches { get; set; }
        public virtual DbSet<Newsletter> Newsletters { get; set; }
        public virtual DbSet<NewsletterKunde> NewsletterKundes { get; set; }
        public virtual DbSet<NewsletterMailEmpfaenger> NewsletterMailEmpfaengers { get; set; }
        public virtual DbSet<NewsletterVerteiler> NewsletterVerteilers { get; set; }
        public virtual DbSet<Overhead> Overheads { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<PersonalAuslastungszeile> PersonalAuslastungszeiles { get; set; }
        public virtual DbSet<PersonalZusatzkosten> PersonalZusatzkostens { get; set; }
        public virtual DbSet<Personaleinsatz> Personaleinsatzs { get; set; }
        public virtual DbSet<Personalerloese> Personalerloeses { get; set; }
        public virtual DbSet<Personalfaktor> Personalfaktors { get; set; }
        public virtual DbSet<Personalkategorie> Personalkategories { get; set; }
        public virtual DbSet<Personalplan> Personalplans { get; set; }
        public virtual DbSet<PersonalplanGeplanteZeiteinheit> PersonalplanGeplanteZeiteinheits { get; set; }
        public virtual DbSet<PersonalplanGeplanteZeiteinheitMitarbeiter> PersonalplanGeplanteZeiteinheitMitarbeiters { get; set; }
        public virtual DbSet<PersonalplanGeplanterTag> PersonalplanGeplanterTags { get; set; }
        public virtual DbSet<PersonalplanPersonalplanregel> PersonalplanPersonalplanregels { get; set; }
        public virtual DbSet<Personalplankategorie> Personalplankategories { get; set; }
        public virtual DbSet<Personalplanregel> Personalplanregels { get; set; }
        public virtual DbSet<Pflegesaetze> Pflegesaetzes { get; set; }
        public virtual DbSet<Pflegestufe> Pflegestuves { get; set; }
        public virtual DbSet<PivotExportSpeziellesSpaltenformat> PivotExportSpeziellesSpaltenformats { get; set; }
        public virtual DbSet<Planbilanz> Planbilanzs { get; set; }
        public virtual DbSet<PlanbilanzKonsolidierung> PlanbilanzKonsolidierungs { get; set; }
        public virtual DbSet<PlanbilanzMittelfristplanung> PlanbilanzMittelfristplanungs { get; set; }
        public virtual DbSet<PlanbilanzMittelfristplanungPosition> PlanbilanzMittelfristplanungPositions { get; set; }
        public virtual DbSet<PlanbilanzPosition> PlanbilanzPositions { get; set; }
        public virtual DbSet<Planbilanzkonto> Planbilanzkontos { get; set; }
        public virtual DbSet<Postleitzahlenvorgabewerte> Postleitzahlenvorgabewertes { get; set; }
        public virtual DbSet<Praemie> Praemies { get; set; }
        public virtual DbSet<Prei> Preis { get; set; }
        public virtual DbSet<Rabattinformationen> Rabattinformationens { get; set; }
        public virtual DbSet<Rechnungseingangsliste> Rechnungseingangslistes { get; set; }
        public virtual DbSet<RechnungseingangslisteSachkonto> RechnungseingangslisteSachkontos { get; set; }
        public virtual DbSet<Rechte> Rechtes { get; set; }
        public virtual DbSet<RegionaleZuordnung> RegionaleZuordnungs { get; set; }
        public virtual DbSet<Reklamationsgrund> Reklamationsgrunds { get; set; }
        public virtual DbSet<Rezept> Rezepts { get; set; }
        public virtual DbSet<RezeptArtikel> RezeptArtikels { get; set; }
        public virtual DbSet<RezeptPortionsgroesse> RezeptPortionsgroesses { get; set; }
        public virtual DbSet<RezeptRezept> RezeptRezepts { get; set; }
        public virtual DbSet<Rezepteinheit> Rezepteinheits { get; set; }
        public virtual DbSet<Rezeptkategorie> Rezeptkategories { get; set; }
        public virtual DbSet<Rhythmu> Rhythmus { get; set; }
        public virtual DbSet<SachkontenGliederungsgruppe> SachkontenGliederungsgruppes { get; set; }
        public virtual DbSet<SachkontenGliederungsgruppeSachkontoGliederungsSummenzeile> SachkontenGliederungsgruppeSachkontoGliederungsSummenzeiles { get; set; }
        public virtual DbSet<Sachkontengruppe> Sachkontengruppes { get; set; }
        public virtual DbSet<SachkontengruppeGuvSummenzeile> SachkontengruppeGuvSummenzeiles { get; set; }
        public virtual DbSet<Sachkontenkategorie> Sachkontenkategories { get; set; }
        public virtual DbSet<Sachkontenueberleitung> Sachkontenueberleitungs { get; set; }
        public virtual DbSet<Sachkontenueberleitungseintrag> Sachkontenueberleitungseintrags { get; set; }
        public virtual DbSet<Sachkonto> Sachkontos { get; set; }
        public virtual DbSet<SachkontoGliederungsgruppeSummenzeile> SachkontoGliederungsgruppeSummenzeiles { get; set; }
        public virtual DbSet<SachkontoProzentBetriebsstaette> SachkontoProzentBetriebsstaettes { get; set; }
        public virtual DbSet<SachkontoSachkontoGliederungsgruppe> SachkontoSachkontoGliederungsgruppes { get; set; }
        public virtual DbSet<SachkostenVerteilungKst> SachkostenVerteilungKsts { get; set; }
        public virtual DbSet<Sachkostenzeile> Sachkostenzeiles { get; set; }
        public virtual DbSet<Schnittstellenart> Schnittstellenarts { get; set; }
        public virtual DbSet<Schnittstelleneinstellung> Schnittstelleneinstellungs { get; set; }
        public virtual DbSet<Schnittstellenkonfiguration> Schnittstellenkonfigurations { get; set; }
        public virtual DbSet<Schwund> Schwunds { get; set; }
        public virtual DbSet<SchwundLagerArtikel> SchwundLagerArtikels { get; set; }
        public virtual DbSet<Segment> Segments { get; set; }
        public virtual DbSet<SeitenElement> SeitenElements { get; set; }
        public virtual DbSet<Sonderposten> Sonderpostens { get; set; }
        public virtual DbSet<Sonderveranstaltung> Sonderveranstaltungs { get; set; }
        public virtual DbSet<SonderveranstaltungArtikel> SonderveranstaltungArtikels { get; set; }
        public virtual DbSet<SonderveranstaltungPersonal> SonderveranstaltungPersonals { get; set; }
        public virtual DbSet<Sonderzahlungen> Sonderzahlungens { get; set; }
        public virtual DbSet<Sperrobjekt> Sperrobjekts { get; set; }
        public virtual DbSet<Staffelprei> Staffelpreis { get; set; }
        public virtual DbSet<Standardkommunikationskanal> Standardkommunikationskanals { get; set; }
        public virtual DbSet<Stellenbeschreibung> Stellenbeschreibungs { get; set; }
        public virtual DbSet<Steuern> Steuerns { get; set; }
        public virtual DbSet<StrategischeKalkulation> StrategischeKalkulations { get; set; }
        public virtual DbSet<StrategischeKalkulationBrotkruemeldefinition> StrategischeKalkulationBrotkruemeldefinitions { get; set; }
        public virtual DbSet<StrategischeKalkulationKalkulation> StrategischeKalkulationKalkulations { get; set; }
        public virtual DbSet<StrategischeKalkulationKonsolidierung> StrategischeKalkulationKonsolidierungs { get; set; }
        public virtual DbSet<Tarif> Tarifs { get; set; }
        public virtual DbSet<TarifBerufsgruppe> TarifBerufsgruppes { get; set; }
        public virtual DbSet<TarifPersonalabgaben> TarifPersonalabgabens { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Telefonart> Telefonarts { get; set; }
        public virtual DbSet<Telefonnummer> Telefonnummers { get; set; }
        public virtual DbSet<Traeger> Traegers { get; set; }
        public virtual DbSet<Transaktion> Transaktions { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<TransferArtikel> TransferArtikels { get; set; }
        public virtual DbSet<TransferGrund> TransferGrunds { get; set; }
        public virtual DbSet<TransferWarenwirtschaftskomponente> TransferWarenwirtschaftskomponentes { get; set; }
        public virtual DbSet<Typ> Typs { get; set; }
        public virtual DbSet<Umlagekostenstelle> Umlagekostenstelles { get; set; }
        public virtual DbSet<Urflaechenart> Urflaechenarts { get; set; }
        public virtual DbSet<Url> Urls { get; set; }
        public virtual DbSet<Urlart> Urlarts { get; set; }
        public virtual DbSet<Urlaub> Urlaubs { get; set; }
        public virtual DbSet<Urlaubsart> Urlaubsarts { get; set; }
        public virtual DbSet<Urlaubsinformation> Urlaubsinformations { get; set; }
        public virtual DbSet<Urleistungswerte> Urleistungswertes { get; set; }
        public virtual DbSet<Urraum> Urraums { get; set; }
        public virtual DbSet<UrraumUrreinigungsart> UrraumUrreinigungsarts { get; set; }
        public virtual DbSet<Urraumnutzgruppe> Urraumnutzgruppes { get; set; }
        public virtual DbSet<UrraumnutzgruppeKalkulation> UrraumnutzgruppeKalkulations { get; set; }
        public virtual DbSet<UrraumnutzgruppeKalkulationUrreinigungsart> UrraumnutzgruppeKalkulationUrreinigungsarts { get; set; }
        public virtual DbSet<Urraumnutzkategorie> Urraumnutzkategories { get; set; }
        public virtual DbSet<UrraumnutzkategorieKalkulation> UrraumnutzkategorieKalkulations { get; set; }
        public virtual DbSet<Urreinigungsart> Urreinigungsarts { get; set; }
        public virtual DbSet<Veranstaltung> Veranstaltungs { get; set; }
        public virtual DbSet<VeranstaltungKunde> VeranstaltungKundes { get; set; }
        public virtual DbSet<Veranstaltungsteilnehmerart> Veranstaltungsteilnehmerarts { get; set; }
        public virtual DbSet<Verguetungsart> Verguetungsarts { get; set; }
        public virtual DbSet<Verguetungsinformation> Verguetungsinformations { get; set; }
        public virtual DbSet<Verleihartikel> Verleihartikels { get; set; }
        public virtual DbSet<Verleihartikelkategorie> Verleihartikelkategories { get; set; }
        public virtual DbSet<Verprobungsfaktor> Verprobungsfaktors { get; set; }
        public virtual DbSet<Verteiler> Verteilers { get; set; }
        public virtual DbSet<VerteilerKunde> VerteilerKundes { get; set; }
        public virtual DbSet<VerteilungBekoestigungstage> VerteilungBekoestigungstages { get; set; }
        public virtual DbSet<Vertretungspersonal> Vertretungspersonals { get; set; }
        public virtual DbSet<Verwaltungsumlage> Verwaltungsumlages { get; set; }
        public virtual DbSet<ViewAlleBestellObjekt> ViewAlleBestellObjekts { get; set; }
        public virtual DbSet<ViewAlleBestellObjekteArtikel> ViewAlleBestellObjekteArtikels { get; set; }
        public virtual DbSet<ViewAlleBestellungen> ViewAlleBestellungens { get; set; }
        public virtual DbSet<ViewAlleNichtAbgeschlossenenBestellObjekt> ViewAlleNichtAbgeschlossenenBestellObjekts { get; set; }
        public virtual DbSet<ViewAnsprechpartnerKundeUebersicht> ViewAnsprechpartnerKundeUebersichts { get; set; }
        public virtual DbSet<ViewArbeitskrei> ViewArbeitskreis { get; set; }
        public virtual DbSet<ViewArbeitskreisGesamt> ViewArbeitskreisGesamts { get; set; }
        public virtual DbSet<ViewArtikelEinkauf> ViewArtikelEinkaufs { get; set; }
        public virtual DbSet<ViewArtikelOffeneBestellungen> ViewArtikelOffeneBestellungens { get; set; }
        public virtual DbSet<ViewArtikelVerkauf> ViewArtikelVerkaufs { get; set; }
        public virtual DbSet<ViewArtikelVerkaufGuenstigesterPrei> ViewArtikelVerkaufGuenstigesterPreis { get; set; }
        public virtual DbSet<ViewArtikelVerkaufOffeneAuftragspositionen> ViewArtikelVerkaufOffeneAuftragspositionens { get; set; }
        public virtual DbSet<ViewArtikelname> ViewArtikelnames { get; set; }
        public virtual DbSet<ViewArtikelnameArtikelnummer> ViewArtikelnameArtikelnummers { get; set; }
        public virtual DbSet<ViewAuftrag> ViewAuftrags { get; set; }
        public virtual DbSet<ViewAuftragAuftragstatus> ViewAuftragAuftragstatuses { get; set; }
        public virtual DbSet<ViewAuftragsposition> ViewAuftragspositions { get; set; }
        public virtual DbSet<ViewAuslastungMonat> ViewAuslastungMonats { get; set; }
        public virtual DbSet<ViewAuslastungMonatKonsolidierung> ViewAuslastungMonatKonsolidierungs { get; set; }
        public virtual DbSet<ViewBelegJournal> ViewBelegJournals { get; set; }
        public virtual DbSet<ViewBenutzeruebersicht> ViewBenutzeruebersichts { get; set; }
        public virtual DbSet<ViewBetriebsstaette> ViewBetriebsstaettes { get; set; }
        public virtual DbSet<ViewBetriebstaetteFinanzplanung> ViewBetriebstaetteFinanzplanungs { get; set; }
        public virtual DbSet<ViewBuArbeitskrei> ViewBuArbeitskreis { get; set; }
        public virtual DbSet<ViewBuKunde> ViewBuKundes { get; set; }
        public virtual DbSet<ViewBuKundeAdresseKommunikation> ViewBuKundeAdresseKommunikations { get; set; }
        public virtual DbSet<ViewBuKundeInMahnverfahren> ViewBuKundeInMahnverfahrens { get; set; }
        public virtual DbSet<ViewBuKundeLoesungen> ViewBuKundeLoesungens { get; set; }
        public virtual DbSet<ViewBuKundeMitAnsprechpartner> ViewBuKundeMitAnsprechpartners { get; set; }
        public virtual DbSet<ViewBuKundeRechnungsadresseMitgliedsbeitrag> ViewBuKundeRechnungsadresseMitgliedsbeitrags { get; set; }
        public virtual DbSet<ViewBuKundeSegmente> ViewBuKundeSegmentes { get; set; }
        public virtual DbSet<ViewBuOffeneAenderungenKalkulation> ViewBuOffeneAenderungenKalkulations { get; set; }
        public virtual DbSet<ViewBuPivotAuswertungIstDaten> ViewBuPivotAuswertungIstDatens { get; set; }
        public virtual DbSet<ViewBuPivotAuswertungStandard> ViewBuPivotAuswertungStandards { get; set; }
        public virtual DbSet<ViewBuTarifUebersicht> ViewBuTarifUebersichts { get; set; }
        public virtual DbSet<ViewBuVeranstaltungBasisdaten> ViewBuVeranstaltungBasisdatens { get; set; }
        public virtual DbSet<ViewBuVeranstaltungsteilnehmer> ViewBuVeranstaltungsteilnehmers { get; set; }
        public virtual DbSet<ViewBuchungstagDefinition> ViewBuchungstagDefinitions { get; set; }
        public virtual DbSet<ViewDateiverknuepfung> ViewDateiverknuepfungs { get; set; }
        public virtual DbSet<ViewErteilteAuftraegeNochNichtVersandt> ViewErteilteAuftraegeNochNichtVersandts { get; set; }
        public virtual DbSet<ViewFehlerhafteBudget> ViewFehlerhafteBudgets { get; set; }
        public virtual DbSet<ViewFinanzplanung> ViewFinanzplanungs { get; set; }
        public virtual DbSet<ViewGueltigeVerkaufsArtikel> ViewGueltigeVerkaufsArtikels { get; set; }
        public virtual DbSet<ViewInternesKontoUebersicht> ViewInternesKontoUebersichts { get; set; }
        public virtual DbSet<ViewInventurUebersicht> ViewInventurUebersichts { get; set; }
        public virtual DbSet<ViewKalkulation> ViewKalkulations { get; set; }
        public virtual DbSet<ViewKalkulationKennzahlen> ViewKalkulationKennzahlens { get; set; }
        public virtual DbSet<ViewKalkulationenFuerFinanzplanung> ViewKalkulationenFuerFinanzplanungs { get; set; }
        public virtual DbSet<ViewKontobewegung> ViewKontobewegungs { get; set; }
        public virtual DbSet<ViewKontobewegungKunde> ViewKontobewegungKundes { get; set; }
        public virtual DbSet<ViewKontostand> ViewKontostands { get; set; }
        public virtual DbSet<ViewKundeBestandteilAdresse> ViewKundeBestandteilAdresses { get; set; }
        public virtual DbSet<ViewKundeBestandteilAdresseGeschaeftlich> ViewKundeBestandteilAdresseGeschaeftliches { get; set; }
        public virtual DbSet<ViewKundeBestandteilAdresseRechnung> ViewKundeBestandteilAdresseRechnungs { get; set; }
        public virtual DbSet<ViewKundeBestandteilAnrede> ViewKundeBestandteilAnredes { get; set; }
        public virtual DbSet<ViewKundeBestandteilGesamt> ViewKundeBestandteilGesamts { get; set; }
        public virtual DbSet<ViewKundeBestandteilKommunikation> ViewKundeBestandteilKommunikations { get; set; }
        public virtual DbSet<ViewKundeBestandteilMitgliedschaft> ViewKundeBestandteilMitgliedschafts { get; set; }
        public virtual DbSet<ViewKundeUebersicht> ViewKundeUebersichts { get; set; }
        public virtual DbSet<ViewKundeVeranstaltung> ViewKundeVeranstaltungs { get; set; }
        public virtual DbSet<ViewLager> ViewLagers { get; set; }
        public virtual DbSet<ViewLagerArtikelDurchschnittsprei> ViewLagerArtikelDurchschnittspreis { get; set; }
        public virtual DbSet<ViewLagerArtikelNiedrigsterEinkaufsprei> ViewLagerArtikelNiedrigsterEinkaufspreis { get; set; }
        public virtual DbSet<ViewLagerBestandHeute> ViewLagerBestandHeutes { get; set; }
        public virtual DbSet<ViewLagerUebersicht> ViewLagerUebersichts { get; set; }
        public virtual DbSet<ViewLagerbestandProArtikelHeute> ViewLagerbestandProArtikelHeutes { get; set; }
        public virtual DbSet<ViewLetzterLogin> ViewLetzterLogins { get; set; }
        public virtual DbSet<ViewLieferantenArtikelEinkaufspreisHeute> ViewLieferantenArtikelEinkaufspreisHeutes { get; set; }
        public virtual DbSet<ViewMailNachricht> ViewMailNachrichts { get; set; }
        public virtual DbSet<ViewMenueauswahl> ViewMenueauswahls { get; set; }
        public virtual DbSet<ViewMenueplanBestandteile> ViewMenueplanBestandteiles { get; set; }
        public virtual DbSet<ViewMenueplanUebersicht> ViewMenueplanUebersichts { get; set; }
        public virtual DbSet<ViewNewsletter> ViewNewsletters { get; set; }
        public virtual DbSet<ViewOffeneBestellmengenArtikel> ViewOffeneBestellmengenArtikels { get; set; }
        public virtual DbSet<ViewOffeneBestellmengenArtikelEinkauf> ViewOffeneBestellmengenArtikelEinkaufs { get; set; }
        public virtual DbSet<ViewOffenerBeleg> ViewOffenerBelegs { get; set; }
        public virtual DbSet<ViewOffenesBestellObjekt> ViewOffenesBestellObjekts { get; set; }
        public virtual DbSet<ViewPlanbilanzExport> ViewPlanbilanzExports { get; set; }
        public virtual DbSet<ViewPlanbilanzPosition> ViewPlanbilanzPositions { get; set; }
        public virtual DbSet<ViewPraemiePersonal> ViewPraemiePersonals { get; set; }
        public virtual DbSet<ViewPreiseEinkaufsartikel> ViewPreiseEinkaufsartikels { get; set; }
        public virtual DbSet<ViewPreiseVerkaufsartikel> ViewPreiseVerkaufsartikels { get; set; }
        public virtual DbSet<ViewRechnungsPositionBeleg> ViewRechnungsPositionBelegs { get; set; }
        public virtual DbSet<ViewRezeptBestandteile> ViewRezeptBestandteiles { get; set; }
        public virtual DbSet<ViewRezeptUebersicht> ViewRezeptUebersichts { get; set; }
        public virtual DbSet<ViewSummeBestandsbewegung> ViewSummeBestandsbewegungs { get; set; }
        public virtual DbSet<ViewTarifUebersicht> ViewTarifUebersichts { get; set; }
        public virtual DbSet<ViewTeilgelieferteAuftragspositionen> ViewTeilgelieferteAuftragspositionens { get; set; }
        public virtual DbSet<ViewUmsatzProKunde> ViewUmsatzProKundes { get; set; }
        public virtual DbSet<ViewVeranstaltung> ViewVeranstaltungs { get; set; }
        public virtual DbSet<ViewVeranstaltungBasisdaten> ViewVeranstaltungBasisdatens { get; set; }
        public virtual DbSet<ViewVeranstaltungTeilnehmer> ViewVeranstaltungTeilnehmers { get; set; }
        public virtual DbSet<ViewVerlieheneArtikel> ViewVerlieheneArtikels { get; set; }
        public virtual DbSet<ViewVerteiler> ViewVerteilers { get; set; }
        public virtual DbSet<ViewWarenbewegungenUebersicht> ViewWarenbewegungenUebersichts { get; set; }
        public virtual DbSet<VorgabewerteKennzahlenabweichung> VorgabewerteKennzahlenabweichungs { get; set; }
        public virtual DbSet<Vorlagenart> Vorlagenarts { get; set; }
        public virtual DbSet<Warenwirtschaftskomponente> Warenwirtschaftskomponentes { get; set; }
        public virtual DbSet<WawiRechte> WawiRechtes { get; set; }
        public virtual DbSet<WawiTyp> WawiTyps { get; set; }
        public virtual DbSet<Wawistatistik> Wawistatistiks { get; set; }
        public virtual DbSet<WawistatistikSpalte> WawistatistikSpaltes { get; set; }
        public virtual DbSet<WawistatistikZeile> WawistatistikZeiles { get; set; }
        public virtual DbSet<Wohnung> Wohnungs { get; set; }
        public virtual DbSet<Wohnungsinformation> Wohnungsinformations { get; set; }
        public virtual DbSet<Zahlungsart> Zahlungsarts { get; set; }
        public virtual DbSet<ZiviTarif> ZiviTarifs { get; set; }
        public virtual DbSet<ZuordnungGehaltSozialversicherung> ZuordnungGehaltSozialversicherungs { get; set; }
        public virtual DbSet<Zuschlag> Zuschlags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=JS_Test;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abrechnung>(entity =>
            {
                entity.ToTable("Abrechnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.EntnahmenAusRegistrierkassen).HasColumnName("entnahmenAusRegistrierkassen");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.KasseIst).HasColumnName("kasseIst");

                entity.Property(e => e.KasseSollXabschlag).HasColumnName("kasseSollXAbschlag");

                entity.Property(e => e.KasseSollZabschlag).HasColumnName("kasseSollZAbschlag");

                entity.Property(e => e.Kassenbezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kassenbezeichnung");

                entity.Property(e => e.KorrekturFehlbons).HasColumnName("korrekturFehlbons");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponenteId");

                entity.Property(e => e.Wechselbestand).HasColumnName("wechselbestand");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.Abrechnungs)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .HasConstraintName("FK_Abrechnung_Warenwirtschaftskomponente");
            });

            modelBuilder.Entity<Abwesenheitsregel>(entity =>
            {
                entity.ToTable("Abwesenheitsregel");

                entity.HasIndex(e => new { e.BundeslandId, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BundeslandId).HasColumnName("bundeslandId");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_von");

                entity.Property(e => e.Prozentsatz).HasColumnName("prozentsatz");

                entity.HasOne(d => d.Bundesland)
                    .WithMany(p => p.Abwesenheitsregels)
                    .HasForeignKey(d => d.BundeslandId)
                    .HasConstraintName("FK_Abwesenheitsregel_Bundesland");
            });

            modelBuilder.Entity<Adressart>(entity =>
            {
                entity.ToTable("Adressart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.ToTable("Adresse");

                entity.HasIndex(e => new { e.AdressartId, e.KontaktinformationId, e.LandId }, "AdressartUndKontaktinformation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abteilung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abteilung");

                entity.Property(e => e.AdressartId).HasColumnName("adressart_id");

                entity.Property(e => e.Adresszusatz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresszusatz");

                entity.Property(e => e.BestellNummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellNummer");

                entity.Property(e => e.Email)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firmenname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("firmenname");

                entity.Property(e => e.Hausnumer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnumer");

                entity.Property(e => e.IstPostfach).HasColumnName("istPostfach");

                entity.Property(e => e.IstStandard).HasColumnName("istStandard");

                entity.Property(e => e.KontaktinformationId).HasColumnName("kontaktinformation_id");

                entity.Property(e => e.LandId).HasColumnName("land_id");

                entity.Property(e => e.LandText)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("landText");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Ort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ort");

                entity.Property(e => e.PersonenName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("personenName");

                entity.Property(e => e.Plz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plz");

                entity.Property(e => e.Postfach)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfach");

                entity.Property(e => e.PostfachOrt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachOrt");

                entity.Property(e => e.PostfachPlz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachPlz");

                entity.Property(e => e.Strasse)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasse");

                entity.Property(e => e.Telefax)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefax");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefon");

                entity.HasOne(d => d.Adressart)
                    .WithMany(p => p.Adresses)
                    .HasForeignKey(d => d.AdressartId)
                    .HasConstraintName("FK_Adresse_Adressart");

                entity.HasOne(d => d.Kontaktinformation)
                    .WithMany(p => p.Adresses)
                    .HasForeignKey(d => d.KontaktinformationId)
                    .HasConstraintName("FK_Adresse_Kontaktinformation");

                entity.HasOne(d => d.Land)
                    .WithMany(p => p.Adresses)
                    .HasForeignKey(d => d.LandId)
                    .HasConstraintName("FK_Adresse_Land");
            });

            modelBuilder.Entity<Aenderungslog>(entity =>
            {
                entity.ToTable("Aenderungslog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Klasse)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("klasse");

                entity.Property(e => e.ObjektId).HasColumnName("objektId");
            });

            modelBuilder.Entity<AfAzeile>(entity =>
            {
                entity.ToTable("AfAzeile");

                entity.HasIndex(e => e.KalkulationId, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AfAlaufzeit).HasColumnName("afALaufzeit");

                entity.Property(e => e.AnlageartId).HasColumnName("anlageartId");

                entity.Property(e => e.Anschaffungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("anschaffungsdatum");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.Aufloesung).HasColumnName("aufloesung");

                entity.Property(e => e.Bemerkung)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bilanzgruppe).HasColumnName("bilanzgruppe");

                entity.Property(e => e.Gruppenschluessel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gruppenschluessel");

                entity.Property(e => e.Gwg).HasColumnName("gwg");

                entity.Property(e => e.Investitionshoehe).HasColumnName("investitionshoehe");

                entity.Property(e => e.IstAfA).HasColumnName("istAfA");

                entity.Property(e => e.IstErweiterungsinvestition).HasColumnName("istErweiterungsinvestition");

                entity.Property(e => e.IstPlanung).HasColumnName("istPlanung");

                entity.Property(e => e.IstSoPo).HasColumnName("istSoPo");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.ProzentKostenstelle).HasColumnName("prozentKostenstelle");

                entity.Property(e => e.SachkontoAnschaffungId).HasColumnName("sachkontoAnschaffungId");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.Property(e => e.StandAnfangJahr).HasColumnName("standAnfangJahr");

                entity.Property(e => e.UrsprungsBetrag).HasColumnName("ursprungsBetrag");

                entity.Property(e => e.Zufuehrung).HasColumnName("zufuehrung");

                entity.Property(e => e.Zuschussgeber)
                    .HasMaxLength(50)
                    .HasColumnName("zuschussgeber");

                entity.HasOne(d => d.Anlageart)
                    .WithMany(p => p.AfAzeiles)
                    .HasForeignKey(d => d.AnlageartId)
                    .HasConstraintName("FK_AfAzeile_Anlageart");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.AfAzeiles)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_AfAzeile_Kalkulation");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.AfAzeiles)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_AfAzeile_Kostenstelle");

                entity.HasOne(d => d.SachkontoAnschaffung)
                    .WithMany(p => p.AfAzeileSachkontoAnschaffungs)
                    .HasForeignKey(d => d.SachkontoAnschaffungId)
                    .HasConstraintName("FK_AfAzeile_Sachkonto_Anschaffung");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.AfAzeileSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_AfAzeile_Sachkonto");
            });

            modelBuilder.Entity<Altersvorsorge>(entity =>
            {
                entity.ToTable("Altersvorsorge");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.ImportKuerzel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("import_kuerzel");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Altersvorsorges)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Altersvorsorge_Benutzer");
            });

            modelBuilder.Entity<AltersvorsorgeDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AltersvorsorgeId).HasColumnName("altersvorsorge_id");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Prozentsatz).HasColumnName("prozentsatz");

                entity.HasOne(d => d.Altersvorsorge)
                    .WithMany(p => p.AltersvorsorgeDetails)
                    .HasForeignKey(d => d.AltersvorsorgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AltersvorsorgeDetails_Altersvorsorge");
            });

            modelBuilder.Entity<Angebot>(entity =>
            {
                entity.ToTable("Angebot");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.DateivorlageId).HasColumnName("dateivorlage_id");

                entity.Property(e => e.FristBis)
                    .HasColumnType("datetime")
                    .HasColumnName("fristBis");

                entity.Property(e => e.IstEmpfaenger).HasColumnName("istEmpfaenger");

                entity.Property(e => e.IstVersendet).HasColumnName("istVersendet");

                entity.Property(e => e.IstVertrag).HasColumnName("istVertrag");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.LaufzeitBis)
                    .HasColumnType("datetime")
                    .HasColumnName("laufzeitBis");

                entity.Property(e => e.LaufzeitVon)
                    .HasColumnType("datetime")
                    .HasColumnName("laufzeitVon");

                entity.Property(e => e.Nachricht)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("nachricht");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Angebots)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Angebot_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Angebots)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Angebot_Betriebsstaette");

                entity.HasOne(d => d.Dateivorlage)
                    .WithMany(p => p.Angebots)
                    .HasForeignKey(d => d.DateivorlageId)
                    .HasConstraintName("FK_Angebot_Dateivorlage");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Angebots)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_Angebot_Kalkulation");
            });

            modelBuilder.Entity<Anlageart>(entity =>
            {
                entity.ToTable("Anlageart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AfaLaufzeit).HasColumnName("afaLaufzeit");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AktuellPlanbilanzgegenkontoId).HasColumnName("aktuell_planbilanzgegenkontoId");

                entity.Property(e => e.AktuellPlanbilanzkontoId).HasColumnName("aktuell_planbilanzkontoId");

                entity.Property(e => e.AnlagegruppeId).HasColumnName("anlagegruppeId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nettopreis).HasColumnName("nettopreis");

                entity.Property(e => e.PlanbilanzgegenkontoId).HasColumnName("planbilanzgegenkontoId");

                entity.Property(e => e.PlanbilanzkontoId).HasColumnName("planbilanzkontoId");

                entity.HasOne(d => d.AktuellPlanbilanzgegenkonto)
                    .WithMany(p => p.AnlageartAktuellPlanbilanzgegenkontos)
                    .HasForeignKey(d => d.AktuellPlanbilanzgegenkontoId)
                    .HasConstraintName("FK_Anlageart_AktuellPlanbilanzgegenkonto");

                entity.HasOne(d => d.AktuellPlanbilanzkonto)
                    .WithMany(p => p.AnlageartAktuellPlanbilanzkontos)
                    .HasForeignKey(d => d.AktuellPlanbilanzkontoId)
                    .HasConstraintName("FK_Anlageart_AktuellPlanbilanzkonto");

                entity.HasOne(d => d.Anlagegruppe)
                    .WithMany(p => p.Anlagearts)
                    .HasForeignKey(d => d.AnlagegruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Anlageart_Anlagengruppe");

                entity.HasOne(d => d.Planbilanzgegenkonto)
                    .WithMany(p => p.AnlageartPlanbilanzgegenkontos)
                    .HasForeignKey(d => d.PlanbilanzgegenkontoId)
                    .HasConstraintName("FK_Anlageart_Planbilanzgegenkonto");

                entity.HasOne(d => d.Planbilanzkonto)
                    .WithMany(p => p.AnlageartPlanbilanzkontos)
                    .HasForeignKey(d => d.PlanbilanzkontoId)
                    .HasConstraintName("FK_Anlageart_Planbilanzkonto");
            });

            modelBuilder.Entity<Anlagengruppe>(entity =>
            {
                entity.ToTable("Anlagengruppe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Anrede>(entity =>
            {
                entity.ToTable("Anrede");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anredetext)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anredetext");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");
            });

            modelBuilder.Entity<Ansprechpartner>(entity =>
            {
                entity.ToTable("Ansprechpartner");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdresseId).HasColumnName("adresseId");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anrede");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppeId");

                entity.Property(e => e.BetriebsstaettenId).HasColumnName("betriebsstaettenId");

                entity.Property(e => e.BundeslandId).HasColumnName("bundeslandId");

                entity.Property(e => e.LieferantId).HasColumnName("lieferant_id");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.StellenbeschreibungId).HasColumnName("stellenbeschreibungId");

                entity.Property(e => e.TraegerId).HasColumnName("traegerId");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.Ansprechpartners)
                    .HasForeignKey(d => d.AdresseId)
                    .HasConstraintName("FK_Ansprechpartner_Adresse");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.Ansprechpartners)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .HasConstraintName("FK_Ansprechpartner_Berufsgruppe");

                entity.HasOne(d => d.Betriebsstaetten)
                    .WithMany(p => p.Ansprechpartners)
                    .HasForeignKey(d => d.BetriebsstaettenId)
                    .HasConstraintName("FK_Ansprechpartner_Betriebsstaette");

                entity.HasOne(d => d.Bundesland)
                    .WithMany(p => p.Ansprechpartners)
                    .HasForeignKey(d => d.BundeslandId)
                    .HasConstraintName("FK_Ansprechpartner_Bundesland1");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.Ansprechpartners)
                    .HasForeignKey(d => d.LieferantId)
                    .HasConstraintName("FK_Ansprechpartner_Lieferant");

                entity.HasOne(d => d.Stellenbeschreibung)
                    .WithMany(p => p.Ansprechpartners)
                    .HasForeignKey(d => d.StellenbeschreibungId)
                    .HasConstraintName("FK_Ansprechpartner_Stellenbeschreibung");

                entity.HasOne(d => d.Traeger)
                    .WithMany(p => p.Ansprechpartners)
                    .HasForeignKey(d => d.TraegerId)
                    .HasConstraintName("FK_Ansprechpartner_Traeger");
            });

            modelBuilder.Entity<AnsprechpartnerKunde>(entity =>
            {
                entity.ToTable("Ansprechpartner_Kunde");

                entity.HasIndex(e => new { e.AnsprechpartnerId, e.KundeId, e.KundeVaterId, e.AnsprechpartnerartId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnsprechpartnerId).HasColumnName("ansprechpartner_id");

                entity.Property(e => e.AnsprechpartnerartId).HasColumnName("ansprechpartnerart_id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.KundeVaterId).HasColumnName("KundeVater_id");

                entity.HasOne(d => d.Ansprechpartner)
                    .WithMany(p => p.AnsprechpartnerKundes)
                    .HasForeignKey(d => d.AnsprechpartnerId)
                    .HasConstraintName("FK_Ansprechpartner_Kunde_Ansprechpartner");

                entity.HasOne(d => d.Ansprechpartnerart)
                    .WithMany(p => p.AnsprechpartnerKundes)
                    .HasForeignKey(d => d.AnsprechpartnerartId)
                    .HasConstraintName("FK_Ansprechpartner_Kunde_Ansprechpartnerart");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.AnsprechpartnerKundeKundes)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ansprechpartner_Kunde_Kunde");

                entity.HasOne(d => d.KundeVater)
                    .WithMany(p => p.AnsprechpartnerKundeKundeVaters)
                    .HasForeignKey(d => d.KundeVaterId)
                    .HasConstraintName("FK_Ansprechpartner_Kunde_Kunde1");
            });

            modelBuilder.Entity<AnsprechpartnerLieferant>(entity =>
            {
                entity.ToTable("Ansprechpartner_Lieferant");

                entity.HasIndex(e => new { e.AnsprechpartnerId, e.LieferantId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnsprechpartnerId).HasColumnName("ansprechpartner_id");

                entity.Property(e => e.LieferantId).HasColumnName("lieferant_id");

                entity.HasOne(d => d.Ansprechpartner)
                    .WithMany(p => p.AnsprechpartnerLieferants)
                    .HasForeignKey(d => d.AnsprechpartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ansprechpartner_Lieferant_Ansprechpartner");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.AnsprechpartnerLieferants)
                    .HasForeignKey(d => d.LieferantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ansprechpartner_Lieferant_Lieferant");
            });

            modelBuilder.Entity<Ansprechpartnerart>(entity =>
            {
                entity.ToTable("Ansprechpartnerart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Arbeitskrei>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnzahlTeilnehmer).HasColumnName("anzahlTeilnehmer");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Dauer).HasColumnName("dauer");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.KannVeroeffentlichtWerden).HasColumnName("kannVeroeffentlichtWerden");

                entity.Property(e => e.KundeArbeitskreisleiterId).HasColumnName("kundeArbeitskreisleiter_id");

                entity.Property(e => e.KundeBetreuerId).HasColumnName("kundeBetreuer_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Arbeitskreis)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arbeitskreis_Benutzer");

                entity.HasOne(d => d.KundeArbeitskreisleiter)
                    .WithMany(p => p.ArbeitskreiKundeArbeitskreisleiters)
                    .HasForeignKey(d => d.KundeArbeitskreisleiterId)
                    .HasConstraintName("FK_Arbeitskreis_Kunde");

                entity.HasOne(d => d.KundeBetreuer)
                    .WithMany(p => p.ArbeitskreiKundeBetreuers)
                    .HasForeignKey(d => d.KundeBetreuerId)
                    .HasConstraintName("FK_Arbeitskreis_Kunde1");
            });

            modelBuilder.Entity<Arbeitstage>(entity =>
            {
                entity.ToTable("Arbeitstage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arbeitstage1).HasColumnName("arbeitstage");

                entity.Property(e => e.BundeslandId).HasColumnName("bundesland_id");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.HasOne(d => d.Bundesland)
                    .WithMany(p => p.Arbeitstages)
                    .HasForeignKey(d => d.BundeslandId)
                    .HasConstraintName("FK_Arbeitstage_Bundesland");
            });

            modelBuilder.Entity<Artikel>(entity =>
            {
                entity.ToTable("Artikel");

                entity.HasIndex(e => new { e.Artikelnummer, e.ArtikellisteId, e.LieferantId, e.MengeneinheitId, e.Standardartikel, e.Aktiv }, "IX_Artikelnummer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AnzahlAbschreibungsmonate).HasColumnName("anzahlAbschreibungsmonate");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikellisteId");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Gebindegroesse).HasColumnName("gebindegroesse");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kuerzel");

                entity.Property(e => e.LieferantId).HasColumnName("lieferantId");

                entity.Property(e => e.Meldemenge).HasColumnName("meldemenge");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheitId");

                entity.Property(e => e.Mindestmenge).HasColumnName("mindestmenge");

                entity.Property(e => e.Preis).HasColumnName("preis");

                entity.Property(e => e.Standardartikel).HasColumnName("standardartikel");

                entity.Property(e => e.SteuernId).HasColumnName("steuernId");

                entity.Property(e => e.Zusatzname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("zusatzname");

                entity.HasOne(d => d.Artikelliste)
                    .WithMany(p => p.Artikels)
                    .HasForeignKey(d => d.ArtikellisteId)
                    .HasConstraintName("FK_Artikel_Artikelliste");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.Artikels)
                    .HasForeignKey(d => d.LieferantId)
                    .HasConstraintName("FK_Artikel_Lieferant");

                entity.HasOne(d => d.Mengeneinheit)
                    .WithMany(p => p.Artikels)
                    .HasForeignKey(d => d.MengeneinheitId)
                    .HasConstraintName("FK_Artikel_Mengeneinheit");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.Artikels)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Artikel_Steuern");
            });

            modelBuilder.Entity<ArtikelArtikelattribut>(entity =>
            {
                entity.ToTable("Artikel_Artikelattribut");

                entity.HasIndex(e => new { e.ArtikelId, e.ArtikelattributId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.ArtikelattributId).HasColumnName("artikelattribut_id");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.ArtikelArtikelattributs)
                    .HasForeignKey(d => d.ArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Artikel_Artikelattribut_Artikel");

                entity.HasOne(d => d.Artikelattribut)
                    .WithMany(p => p.ArtikelArtikelattributs)
                    .HasForeignKey(d => d.ArtikelattributId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Artikel_Artikelattribut_Artikelattribut");
            });

            modelBuilder.Entity<ArtikelEinkauf>(entity =>
            {
                entity.ToTable("ArtikelEinkauf");

                entity.HasIndex(e => new { e.LieferantId, e.ArtikelId, e.ArtikellisteId, e.SteuernId, e.MengeneinheitId, e.ArtikelattributId, e.Aktiv }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.ArtikelattributId).HasColumnName("artikelattribut_id");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikelliste_id");

                entity.Property(e => e.Artikelnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Beschreibung)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.EAn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eAN");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Gebindegroesse).HasColumnName("gebindegroesse");

                entity.Property(e => e.IstGebindeartikel).HasColumnName("istGebindeartikel");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kuerzel");

                entity.Property(e => e.LieferantId).HasColumnName("lieferant_id");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheit_id");

                entity.Property(e => e.Mindestbestellmenge).HasColumnName("mindestbestellmenge");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Prioritaet).HasColumnName("prioritaet");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.Property(e => e.Umrechnungsfaktor).HasColumnName("umrechnungsfaktor");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.ArtikelEinkaufs)
                    .HasForeignKey(d => d.ArtikelId)
                    .HasConstraintName("FK_ArtikelEinkauf_Artikel");

                entity.HasOne(d => d.Artikelattribut)
                    .WithMany(p => p.ArtikelEinkaufs)
                    .HasForeignKey(d => d.ArtikelattributId)
                    .HasConstraintName("FK_ArtikelEinkauf_Artikelattribut");

                entity.HasOne(d => d.Artikelliste)
                    .WithMany(p => p.ArtikelEinkaufs)
                    .HasForeignKey(d => d.ArtikellisteId)
                    .HasConstraintName("FK_ArtikelEinkauf_Artikelliste");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.ArtikelEinkaufs)
                    .HasForeignKey(d => d.LieferantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtikelEinkauf_Lieferant");

                entity.HasOne(d => d.Mengeneinheit)
                    .WithMany(p => p.ArtikelEinkaufs)
                    .HasForeignKey(d => d.MengeneinheitId)
                    .HasConstraintName("FK_ArtikelEinkauf_Mengeneinheit");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.ArtikelEinkaufs)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_ArtikelEinkauf_Steuern");
            });

            modelBuilder.Entity<ArtikelPrei>(entity =>
            {
                entity.ToTable("Artikel_Preis");

                entity.HasIndex(e => new { e.ArtikelId, e.GueltigVon, e.GueltigBis, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_von");

                entity.Property(e => e.Preis).HasColumnName("preis");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.ArtikelPreis)
                    .HasForeignKey(d => d.ArtikelId)
                    .HasConstraintName("FK_Artikel_Preis_Artikel");
            });

            modelBuilder.Entity<ArtikelVerkauf>(entity =>
            {
                entity.ToTable("ArtikelVerkauf");

                entity.HasIndex(e => new { e.ArtikelId, e.RezeptId, e.ArtikellisteId, e.SteuernId, e.MengeneinheitId, e.ArtikelattributId, e.Artikelnummer, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.ArtikelattributId).HasColumnName("artikelattribut_id");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikelliste_id");

                entity.Property(e => e.Artikelnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Gebindegroesse).HasColumnName("gebindegroesse");

                entity.Property(e => e.IstGebindeartikel).HasColumnName("istGebindeartikel");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheit_id");

                entity.Property(e => e.Mindestverkaufsmenge).HasColumnName("mindestverkaufsmenge");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RezeptId).HasColumnName("rezept_id");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.ArtikelVerkaufs)
                    .HasForeignKey(d => d.ArtikelId)
                    .HasConstraintName("FK_ArtikelVerkauf_Artikel");

                entity.HasOne(d => d.Artikelattribut)
                    .WithMany(p => p.ArtikelVerkaufs)
                    .HasForeignKey(d => d.ArtikelattributId)
                    .HasConstraintName("FK_ArtikelVerkauf_Artikelattribut");

                entity.HasOne(d => d.Artikelliste)
                    .WithMany(p => p.ArtikelVerkaufs)
                    .HasForeignKey(d => d.ArtikellisteId)
                    .HasConstraintName("FK_ArtikelVerkauf_Artikelliste");

                entity.HasOne(d => d.Mengeneinheit)
                    .WithMany(p => p.ArtikelVerkaufs)
                    .HasForeignKey(d => d.MengeneinheitId)
                    .HasConstraintName("FK_ArtikelVerkauf_Mengeneinheit");

                entity.HasOne(d => d.Rezept)
                    .WithMany(p => p.ArtikelVerkaufs)
                    .HasForeignKey(d => d.RezeptId)
                    .HasConstraintName("FK_ArtikelVerkauf_Rezept");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.ArtikelVerkaufs)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_ArtikelVerkauf_Steuern");
            });

            modelBuilder.Entity<ArtikelVerkaufArtikelattribut>(entity =>
            {
                entity.ToTable("ArtikelVerkauf_Artikelattribut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtikelVerkaufId).HasColumnName("ArtikelVerkauf_id");

                entity.Property(e => e.ArtikelattributId).HasColumnName("Artikelattribut_id");

                entity.HasOne(d => d.ArtikelVerkauf)
                    .WithMany(p => p.ArtikelVerkaufArtikelattributs)
                    .HasForeignKey(d => d.ArtikelVerkaufId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtikelVerkauf_Artikelattribut_ArtikelVerkauf");

                entity.HasOne(d => d.Artikelattribut)
                    .WithMany(p => p.ArtikelVerkaufArtikelattributs)
                    .HasForeignKey(d => d.ArtikelattributId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtikelVerkauf_Artikelattribut_Artikelattribut");
            });

            modelBuilder.Entity<Artikelattribut>(entity =>
            {
                entity.ToTable("Artikelattribut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Kennziffer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kennziffer");
            });

            modelBuilder.Entity<Artikelliste>(entity =>
            {
                entity.ToTable("Artikelliste");

                entity.HasIndex(e => new { e.IstZentralliste, e.AfaListe, e.Aktiv, e.Schluessel }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AfaListe).HasColumnName("afaListe");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.IstZentralliste).HasColumnName("istZentralliste");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Rabattfaehig)
                    .HasColumnName("rabattfaehig")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Schluessel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("schluessel");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Artikellistes)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Artikelliste_Kostenstelle");
            });

            modelBuilder.Entity<ArtikelmerklisteEintrag>(entity =>
            {
                entity.ToTable("ArtikelmerklisteEintrag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.ArtikelmerklisteEintrags)
                    .HasForeignKey(d => d.ArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtikelmerklisteEintrag_Artikel");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.ArtikelmerklisteEintrags)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtikelmerklisteEintrag_Benutzer");
            });

            modelBuilder.Entity<Auftrag>(entity =>
            {
                entity.ToTable("Auftrag");

                entity.HasIndex(e => new { e.KundeId, e.AnsprechpartnerId, e.BenutzerId, e.GeplantFuer, e.Bestelldatum, e.Aenderungsdatum, e.Erstellungsdatum, e.Auftragsvolumen, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AngebotGueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("angebotGueltigBis");

                entity.Property(e => e.AnsprechpartnerId).HasColumnName("ansprechpartner_id");

                entity.Property(e => e.AuftragsnummerExtern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerExtern");

                entity.Property(e => e.AuftragsnummerIntern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerIntern");

                entity.Property(e => e.Auftragsvolumen).HasColumnName("auftragsvolumen");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Bestelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("bestelldatum");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.GeplantFuer)
                    .HasColumnType("datetime")
                    .HasColumnName("geplantFuer");

                entity.Property(e => e.KommentarId).HasColumnName("kommentar_id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Ansprechpartner)
                    .WithMany(p => p.Auftrags)
                    .HasForeignKey(d => d.AnsprechpartnerId)
                    .HasConstraintName("FK_Auftrag_Ansprechpartner");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Auftrags)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_Benutzer");

                entity.HasOne(d => d.Kommentar)
                    .WithMany(p => p.Auftrags)
                    .HasForeignKey(d => d.KommentarId)
                    .HasConstraintName("FK_Auftrag_Kommentar");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.Auftrags)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_Kunde");
            });

            modelBuilder.Entity<AuftragArtikelVerkauf>(entity =>
            {
                entity.ToTable("Auftrag_ArtikelVerkauf");

                entity.HasIndex(e => new { e.AuftragId, e.BelegId, e.ArtikelVerkaufId, e.SteuernId, e.ReklamationsgrundId, e.Belegposition }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.ArtikelVerkaufId).HasColumnName("artikelVerkauf_id");

                entity.Property(e => e.AufLieferscheinDrucken)
                    .HasColumnName("aufLieferscheinDrucken")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuftragId).HasColumnName("auftrag_id");

                entity.Property(e => e.BelegId).HasColumnName("beleg_id");

                entity.Property(e => e.Belegposition).HasColumnName("belegposition");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.IstWarenrueckname).HasColumnName("istWarenrueckname");

                entity.Property(e => e.Kommentar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kommentar");

                entity.Property(e => e.ReklamationsgrundId).HasColumnName("reklamationsgrund_id");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.Property(e => e.Verkaufspreis).HasColumnName("verkaufspreis");

                entity.Property(e => e.WirdRueckerstattet).HasColumnName("wirdRueckerstattet");

                entity.HasOne(d => d.ArtikelVerkauf)
                    .WithMany(p => p.AuftragArtikelVerkaufs)
                    .HasForeignKey(d => d.ArtikelVerkaufId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_ArtikelVerkauf_ArtikelVerkauf");

                entity.HasOne(d => d.Auftrag)
                    .WithMany(p => p.AuftragArtikelVerkaufs)
                    .HasForeignKey(d => d.AuftragId)
                    .HasConstraintName("FK_Auftrag_ArtikelVerkauf_Auftrag");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.AuftragArtikelVerkaufs)
                    .HasForeignKey(d => d.BelegId)
                    .HasConstraintName("FK_Auftrag_ArtikelVerkauf_Beleg");

                entity.HasOne(d => d.Reklamationsgrund)
                    .WithMany(p => p.AuftragArtikelVerkaufs)
                    .HasForeignKey(d => d.ReklamationsgrundId)
                    .HasConstraintName("FK_Auftrag_ArtikelVerkauf_Reklamationsgrund");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.AuftragArtikelVerkaufs)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Auftrag_ArtikelVerkauf_Steuern");
            });

            modelBuilder.Entity<AuftragAuftragstatus>(entity =>
            {
                entity.ToTable("Auftrag_Auftragstatus");

                entity.HasIndex(e => new { e.AuftragId, e.AuftragstatusId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AuftragId).HasColumnName("auftrag_id");

                entity.Property(e => e.AuftragstatusId).HasColumnName("auftragstatus_id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.HasOne(d => d.Auftrag)
                    .WithMany(p => p.AuftragAuftragstatuses)
                    .HasForeignKey(d => d.AuftragId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_Auftragstatus_Auftrag");

                entity.HasOne(d => d.Auftragstatus)
                    .WithMany(p => p.AuftragAuftragstatuses)
                    .HasForeignKey(d => d.AuftragstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_Auftragstatus_Auftragstatus");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.AuftragAuftragstatuses)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_Auftragstatus_Benutzer");
            });

            modelBuilder.Entity<AuftragMenueplanZeitpunkt>(entity =>
            {
                entity.ToTable("Auftrag_MenueplanZeitpunkt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.AuftragId).HasColumnName("auftrag_id");

                entity.Property(e => e.BelegId).HasColumnName("beleg_id");

                entity.Property(e => e.Belegposition).HasColumnName("belegposition");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.IstWarenrueckname).HasColumnName("istWarenrueckname");

                entity.Property(e => e.Kommentar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kommentar");

                entity.Property(e => e.MenueplanZeitpunktId).HasColumnName("menueplanZeitpunkt_id");

                entity.Property(e => e.ReklamationsgrundId).HasColumnName("reklamationsgrund_id");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.Property(e => e.Verkaufspreis).HasColumnName("verkaufspreis");

                entity.Property(e => e.WirdRueckerstattet).HasColumnName("wirdRueckerstattet");

                entity.HasOne(d => d.Auftrag)
                    .WithMany(p => p.AuftragMenueplanZeitpunkts)
                    .HasForeignKey(d => d.AuftragId)
                    .HasConstraintName("FK_Auftrag_MenueplanZeitpunkt_Auftrag");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.AuftragMenueplanZeitpunkts)
                    .HasForeignKey(d => d.BelegId)
                    .HasConstraintName("FK_Auftrag_MenueplanZeitpunkt_Beleg");

                entity.HasOne(d => d.MenueplanZeitpunkt)
                    .WithMany(p => p.AuftragMenueplanZeitpunkts)
                    .HasForeignKey(d => d.MenueplanZeitpunktId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_MenueplanZeitpunkt_MenueplanZeitpunkt");

                entity.HasOne(d => d.Reklamationsgrund)
                    .WithMany(p => p.AuftragMenueplanZeitpunkts)
                    .HasForeignKey(d => d.ReklamationsgrundId)
                    .HasConstraintName("FK_Auftrag_MenueplanZeitpunkt_Reklamationsgrund");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.AuftragMenueplanZeitpunkts)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Auftrag_MenueplanZeitpunkt_Steuern");
            });

            modelBuilder.Entity<AuftragVerleihartikel>(entity =>
            {
                entity.ToTable("Auftrag_Verleihartikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuftragId).HasColumnName("auftrag_id");

                entity.Property(e => e.BelegId).HasColumnName("beleg_id");

                entity.Property(e => e.Belegposition).HasColumnName("belegposition");

                entity.Property(e => e.IstWarenrueckname).HasColumnName("istWarenrueckname");

                entity.Property(e => e.Kommentar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kommentar");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.Preis).HasColumnName("preis");

                entity.Property(e => e.ReklamationsgrundId).HasColumnName("reklamationsgrund_id");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.Property(e => e.VerleihartikelId).HasColumnName("verleihartikel_id");

                entity.Property(e => e.WirdRueckerstattet).HasColumnName("wirdRueckerstattet");

                entity.HasOne(d => d.Auftrag)
                    .WithMany(p => p.AuftragVerleihartikels)
                    .HasForeignKey(d => d.AuftragId)
                    .HasConstraintName("FK_Auftrag_Verleihartikel_Auftrag");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.AuftragVerleihartikels)
                    .HasForeignKey(d => d.BelegId)
                    .HasConstraintName("FK_Auftrag_Verleihartikel_Beleg");

                entity.HasOne(d => d.Reklamationsgrund)
                    .WithMany(p => p.AuftragVerleihartikels)
                    .HasForeignKey(d => d.ReklamationsgrundId)
                    .HasConstraintName("FK_Auftrag_Verleihartikel_Reklamationsgrund");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.AuftragVerleihartikels)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Auftrag_Verleihartikel_Steuern");

                entity.HasOne(d => d.Verleihartikel)
                    .WithMany(p => p.AuftragVerleihartikels)
                    .HasForeignKey(d => d.VerleihartikelId)
                    .HasConstraintName("FK_Auftrag_Verleihartikel_Auftrag_Verleihartikel");
            });

            modelBuilder.Entity<AuftragZuschlag>(entity =>
            {
                entity.ToTable("Auftrag_Zuschlag");

                entity.HasIndex(e => new { e.AuftragId, e.ZuschlagId, e.BelegId, e.SteuernId, e.ReklamationsgrundId, e.WirdRueckerstattet, e.IstWarenrueckname }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.AufLieferscheinDrucken)
                    .HasColumnName("aufLieferscheinDrucken")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuftragId).HasColumnName("auftrag_id");

                entity.Property(e => e.BelegId).HasColumnName("beleg_id");

                entity.Property(e => e.Belegposition).HasColumnName("belegposition");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.BetragRelativ).HasColumnName("betragRelativ");

                entity.Property(e => e.IstWarenrueckname).HasColumnName("istWarenrueckname");

                entity.Property(e => e.Kommentar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kommentar");

                entity.Property(e => e.ReklamationsgrundId).HasColumnName("reklamationsgrund_id");

                entity.Property(e => e.Relativ).HasColumnName("relativ");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.Property(e => e.WirdRueckerstattet).HasColumnName("wirdRueckerstattet");

                entity.Property(e => e.ZuschlagId).HasColumnName("zuschlag_id");

                entity.HasOne(d => d.Auftrag)
                    .WithMany(p => p.AuftragZuschlags)
                    .HasForeignKey(d => d.AuftragId)
                    .HasConstraintName("FK_Auftrag_Zuschlag_Auftrag");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.AuftragZuschlags)
                    .HasForeignKey(d => d.BelegId)
                    .HasConstraintName("FK_Auftrag_Zuschlag_Beleg");

                entity.HasOne(d => d.Reklamationsgrund)
                    .WithMany(p => p.AuftragZuschlags)
                    .HasForeignKey(d => d.ReklamationsgrundId)
                    .HasConstraintName("FK_Auftrag_Zuschlag_Reklamationsgrund");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.AuftragZuschlags)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Auftrag_Zuschlag_Steuern");

                entity.HasOne(d => d.Zuschlag)
                    .WithMany(p => p.AuftragZuschlags)
                    .HasForeignKey(d => d.ZuschlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auftrag_Zuschlag_Auftrag_Zuschlag");
            });

            modelBuilder.Entity<Auftragstatus>(entity =>
            {
                entity.ToTable("Auftragstatus");

                entity.HasIndex(e => new { e.ReihenfolgeNr, e.Aktiv }, "Standard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnzeigeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anzeigeName");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ReihenfolgeNr).HasColumnName("reihenfolgeNr");
            });

            modelBuilder.Entity<AuftragsverwaltungStatischerBereichBerechtigung>(entity =>
            {
                entity.ToTable("AuftragsverwaltungStatischerBereichBerechtigung");

                entity.HasIndex(e => e.AuftragstatusId, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuftragstatusId).HasColumnName("auftragstatus_id");

                entity.Property(e => e.MyComboBoxAnsprechpartner)
                    .IsRequired()
                    .HasColumnName("myComboBoxAnsprechpartner")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyComboBoxKunde)
                    .IsRequired()
                    .HasColumnName("myComboBoxKunde")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyDateTimePickerBestelldatum)
                    .IsRequired()
                    .HasColumnName("myDateTimePickerBestelldatum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyDateTimePickerGueltigskeitsdatum)
                    .IsRequired()
                    .HasColumnName("myDateTimePickerGueltigskeitsdatum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyDateTimePickerLieferdatum)
                    .IsRequired()
                    .HasColumnName("myDateTimePickerLieferdatum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyTextBoxExtAuftragsnr)
                    .IsRequired()
                    .HasColumnName("myTextBoxExtAuftragsnr")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyTextBoxIntAuftragsnr)
                    .IsRequired()
                    .HasColumnName("myTextBoxIntAuftragsnr")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyTextBoxLetzteAenderung)
                    .IsRequired()
                    .HasColumnName("myTextBoxLetzteAenderung")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyTextBoxLetzterBearbeiter)
                    .IsRequired()
                    .HasColumnName("myTextBoxLetzterBearbeiter")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyTextBoxName)
                    .IsRequired()
                    .HasColumnName("myTextBoxName")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ToolStripButtonKundeBearbeiten)
                    .IsRequired()
                    .HasColumnName("toolStripButton_KundeBearbeiten")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ToolStripButtonNeuerKunde)
                    .IsRequired()
                    .HasColumnName("toolStripButton_NeuerKunde")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ToolStripButtonStatushistorie)
                    .IsRequired()
                    .HasColumnName("toolStripButtonStatushistorie")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Auftragstatus)
                    .WithMany(p => p.AuftragsverwaltungStatischerBereichBerechtigungs)
                    .HasForeignKey(d => d.AuftragstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuftragsverwaltungStatischerBereichBerechtigung_Auftragstatus");
            });

            modelBuilder.Entity<Aufwand>(entity =>
            {
                entity.ToTable("Aufwand");

                entity.HasIndex(e => new { e.KalkulationId, e.SachkontoId, e.KostenstelleId, e.Datum, e.IstDaten }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Einsatz).HasColumnName("einsatz");

                entity.Property(e => e.HochgerechneterWertLaufendesJahr).HasColumnName("hochgerechneterWertLaufendesJahr");

                entity.Property(e => e.IstDaten).HasColumnName("istDaten");

                entity.Property(e => e.IstPersonal).HasColumnName("istPersonal");

                entity.Property(e => e.IstWertVorjahr).HasColumnName("istWertVorjahr");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Aufwands)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aufwand_Kalkulation");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Aufwands)
                    .HasForeignKey(d => d.KostenstelleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aufwand_Kostenstelle");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.Aufwands)
                    .HasForeignKey(d => d.SachkontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aufwand_Sachkonto");
            });

            modelBuilder.Entity<AuslastungMonat>(entity =>
            {
                entity.ToTable("AuslastungMonat");

                entity.HasIndex(e => new { e.KalkulationAuslastungsartId, e.Monat }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbwesenheitPst0).HasColumnName("abwesenheitPst0");

                entity.Property(e => e.AbwesenheitPst1).HasColumnName("abwesenheitPst1");

                entity.Property(e => e.AbwesenheitPst2).HasColumnName("abwesenheitPst2");

                entity.Property(e => e.AbwesenheitPst3).HasColumnName("abwesenheitPst3");

                entity.Property(e => e.AbwesenheitPst3plus).HasColumnName("abwesenheitPst3plus");

                entity.Property(e => e.AbwesenheitenProTag).HasColumnName("abwesenheitenProTag");

                entity.Property(e => e.AnteilInv3).HasColumnName("anteilInv3");

                entity.Property(e => e.AnteilInv4).HasColumnName("anteilInv4");

                entity.Property(e => e.AnteilInv5).HasColumnName("anteilInv5");

                entity.Property(e => e.AnteilSelbstzahler).HasColumnName("anteilSelbstzahler");

                entity.Property(e => e.AnteilShe).HasColumnName("anteilSHE");

                entity.Property(e => e.AnwesenheitPst0).HasColumnName("anwesenheitPst0");

                entity.Property(e => e.AnwesenheitPst1).HasColumnName("anwesenheitPst1");

                entity.Property(e => e.AnwesenheitPst2).HasColumnName("anwesenheitPst2");

                entity.Property(e => e.AnwesenheitPst3).HasColumnName("anwesenheitPst3");

                entity.Property(e => e.AnwesenheitPst3plus).HasColumnName("anwesenheitPst3plus");

                entity.Property(e => e.BelegtePlaetzeProTag).HasColumnName("belegtePlaetzeProTag");

                entity.Property(e => e.KalkulationAuslastungsartId).HasColumnName("kalkulation_Auslastungsart_id");

                entity.Property(e => e.Monat).HasColumnName("monat");

                entity.Property(e => e.TageBelegteEz).HasColumnName("tageBelegteEZ");

                entity.Property(e => e.TageSondennahrung).HasColumnName("tageSondennahrung");

                entity.HasOne(d => d.KalkulationAuslastungsart)
                    .WithMany(p => p.AuslastungMonats)
                    .HasForeignKey(d => d.KalkulationAuslastungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuslastungMonat_Kalkulation_Auslastungsart");
            });

            modelBuilder.Entity<Auslastungsart>(entity =>
            {
                entity.ToTable("Auslastungsart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.InKalkulationAuslastungRelevant).HasColumnName("inKalkulationAuslastungRelevant");

                entity.Property(e => e.Kostenstellennummernbis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kostenstellennummernbis");

                entity.Property(e => e.Kostenstellennummervon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kostenstellennummervon");
            });

            modelBuilder.Entity<Auslastungszeile>(entity =>
            {
                entity.ToTable("Auslastungszeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.April).HasColumnName("april");

                entity.Property(e => e.August).HasColumnName("august");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsartId");

                entity.Property(e => e.Dezember).HasColumnName("dezember");

                entity.Property(e => e.Februar).HasColumnName("februar");

                entity.Property(e => e.Januar).HasColumnName("januar");

                entity.Property(e => e.Juli).HasColumnName("juli");

                entity.Property(e => e.Juni).HasColumnName("juni");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.Maerz).HasColumnName("maerz");

                entity.Property(e => e.Mai).HasColumnName("mai");

                entity.Property(e => e.November).HasColumnName("november");

                entity.Property(e => e.Oktober).HasColumnName("oktober");

                entity.Property(e => e.September).HasColumnName("september");

                entity.Property(e => e.Verteilung).HasColumnName("verteilung");

                entity.Property(e => e.Zeilennummer).HasColumnName("zeilennummer");

                entity.HasOne(d => d.Auslastungsart)
                    .WithMany(p => p.Auslastungszeiles)
                    .HasForeignKey(d => d.AuslastungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auslastungszeile_Auslastungsart");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Auslastungszeiles)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auslastungszeile_Kalkulation");
            });

            modelBuilder.Entity<Bekoestigungstage>(entity =>
            {
                entity.ToTable("Bekoestigungstage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponenteId");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.Bekoestigungstages)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .HasConstraintName("FK_Bekoestigungstage_Warenwirtschaftskomponente");
            });

            modelBuilder.Entity<BekoestigungstageCateringMahlzeit>(entity =>
            {
                entity.ToTable("Bekoestigungstage_Catering_Mahlzeit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.Bekoestigungstageid).HasColumnName("bekoestigungstageid");

                entity.Property(e => e.CateringMahlzeitId).HasColumnName("catering_mahlzeit_id");

                entity.HasOne(d => d.Bekoestigungstage)
                    .WithMany(p => p.BekoestigungstageCateringMahlzeits)
                    .HasForeignKey(d => d.Bekoestigungstageid)
                    .HasConstraintName("FK_Bekoestigungstage_Catering_Mahlzeit_Bekoestigungstage");

                entity.HasOne(d => d.CateringMahlzeit)
                    .WithMany(p => p.BekoestigungstageCateringMahlzeits)
                    .HasForeignKey(d => d.CateringMahlzeitId)
                    .HasConstraintName("FK_Bekoestigungstage_Catering_Mahlzeit_CateringMahlzeit");
            });

            modelBuilder.Entity<Beleg>(entity =>
            {
                entity.ToTable("Beleg");

                entity.HasIndex(e => new { e.BelegartId, e.AuftragId, e.KundeId, e.BelegJournalId, e.AuftragstatusId, e.OberBelegId, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuftragId).HasColumnName("auftrag_id");

                entity.Property(e => e.AuftragstatusId).HasColumnName("auftragstatus_id");

                entity.Property(e => e.BelegJournalId).HasColumnName("belegJournal_id");

                entity.Property(e => e.BelegartId).HasColumnName("belegart_id");

                entity.Property(e => e.Belegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("belegdatum");

                entity.Property(e => e.Belegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegnummer");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstSammelrechnungVerband).HasColumnName("istSammelrechnungVerband");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.OberBelegId).HasColumnName("oberBeleg_id");

                entity.Property(e => e.Rechnungsbetrag).HasColumnName("rechnungsbetrag");

                entity.HasOne(d => d.Auftrag)
                    .WithMany(p => p.Belegs)
                    .HasForeignKey(d => d.AuftragId)
                    .HasConstraintName("FK_Lieferschein_Auftrag");

                entity.HasOne(d => d.Auftragstatus)
                    .WithMany(p => p.Belegs)
                    .HasForeignKey(d => d.AuftragstatusId)
                    .HasConstraintName("FK_Beleg_Auftragstatus");

                entity.HasOne(d => d.BelegJournal)
                    .WithMany(p => p.Belegs)
                    .HasForeignKey(d => d.BelegJournalId)
                    .HasConstraintName("FK_Beleg_BelegJournal");

                entity.HasOne(d => d.Belegart)
                    .WithMany(p => p.Belegs)
                    .HasForeignKey(d => d.BelegartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beleg_Belegart");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Belegs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lieferschein_Benutzer");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.Belegs)
                    .HasForeignKey(d => d.KundeId)
                    .HasConstraintName("FK_Beleg_Kunde");

                entity.HasOne(d => d.OberBeleg)
                    .WithMany(p => p.InverseOberBeleg)
                    .HasForeignKey(d => d.OberBelegId)
                    .HasConstraintName("FK_Beleg_Beleg");
            });

            modelBuilder.Entity<BelegJournal>(entity =>
            {
                entity.ToTable("BelegJournal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BelegJournals)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BelegJournal_Benutzer");
            });

            modelBuilder.Entity<Belegart>(entity =>
            {
                entity.ToTable("Belegart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BelegnummerVorsilbe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("belegnummerVorsilbe");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.VorblattFuerVerband).HasColumnName("vorblattFuerVerband");
            });

            modelBuilder.Entity<Benutzer>(entity =>
            {
                entity.ToTable("Benutzer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdresseId).HasColumnName("adresse_id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_von");

                entity.Property(e => e.LetzterBearbeiterId).HasColumnName("letzterBearbeiter_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Passwort)
                    .HasMaxLength(500)
                    .HasColumnName("passwort");

                entity.Property(e => e.RechteId).HasColumnName("rechte_id");

                entity.Property(e => e.RegionaleZuordnungId).HasColumnName("regionaleZuordnung_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.Benutzers)
                    .HasForeignKey(d => d.AdresseId)
                    .HasConstraintName("FK_Benutzer_Adresse");

                entity.HasOne(d => d.LetzterBearbeiter)
                    .WithMany(p => p.InverseLetzterBearbeiter)
                    .HasForeignKey(d => d.LetzterBearbeiterId)
                    .HasConstraintName("FK_Benutzer_Benutzer");

                entity.HasOne(d => d.Rechte)
                    .WithMany(p => p.Benutzers)
                    .HasForeignKey(d => d.RechteId)
                    .HasConstraintName("FK_Benutzer_Rechte");

                entity.HasOne(d => d.RegionaleZuordnung)
                    .WithMany(p => p.Benutzers)
                    .HasForeignKey(d => d.RegionaleZuordnungId)
                    .HasConstraintName("FK_Benutzer_RegionaleZuordnung");
            });

            modelBuilder.Entity<BenutzerAktion>(entity =>
            {
                entity.ToTable("BenutzerAktion");

                entity.HasIndex(e => new { e.BenutzerId, e.BenutzerAktionsartId, e.Datum }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("aktion");

                entity.Property(e => e.BenutzerAktionsartId).HasColumnName("benutzerAktionsart_id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Betriebssystem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("betriebssystem");

                entity.Property(e => e.BetriebssystemBenutzer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("betriebssystemBenutzer");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("computerName");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.HasOne(d => d.BenutzerAktionsart)
                    .WithMany(p => p.BenutzerAktions)
                    .HasForeignKey(d => d.BenutzerAktionsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerAktion_BenutzerAktionsart");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BenutzerAktions)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerAktion_Benutzer");
            });

            modelBuilder.Entity<BenutzerAktionsart>(entity =>
            {
                entity.ToTable("BenutzerAktionsart");

                entity.HasIndex(e => e.Art, "Standard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Art)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("art");
            });

            modelBuilder.Entity<BenutzerGruppe>(entity =>
            {
                entity.ToTable("Benutzer_Gruppe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.GruppenId).HasColumnName("gruppen_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BenutzerGruppes)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Benutzer_Gruppe_Benutzer");

                entity.HasOne(d => d.Gruppen)
                    .WithMany(p => p.BenutzerGruppes)
                    .HasForeignKey(d => d.GruppenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Benutzer_Gruppe_Gruppe");
            });

            modelBuilder.Entity<BenutzerLizenz>(entity =>
            {
                entity.ToTable("Benutzer_Lizenz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.LizenzId).HasColumnName("lizenz_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BenutzerLizenzs)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Benutzer_Lizenz_Benutzer");

                entity.HasOne(d => d.Lizenz)
                    .WithMany(p => p.BenutzerLizenzs)
                    .HasForeignKey(d => d.LizenzId)
                    .HasConstraintName("FK_Benutzer_Lizenz_Lizenz");
            });

            modelBuilder.Entity<BenutzerSeitenElement>(entity =>
            {
                entity.ToTable("Benutzer_SeitenElement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.SeitenElementId).HasColumnName("seitenElement_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BenutzerSeitenElements)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Benutzer_SeitenElement_Benutzer");

                entity.HasOne(d => d.SeitenElement)
                    .WithMany(p => p.BenutzerSeitenElements)
                    .HasForeignKey(d => d.SeitenElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Benutzer_SeitenElement_SeitenElement");
            });

            modelBuilder.Entity<BenutzerSignatur>(entity =>
            {
                entity.ToTable("BenutzerSignatur");

                entity.HasIndex(e => e.BenutzerId, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Signatur)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("signatur");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BenutzerSignaturs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerSignatur_Benutzer1");
            });

            modelBuilder.Entity<BenutzerUebersicht>(entity =>
            {
                entity.ToTable("BenutzerUebersicht");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BenutzeruebersichtbasisId).HasColumnName("benutzeruebersichtbasis_id");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.IstUndVerknuepfung)
                    .IsRequired()
                    .HasColumnName("istUndVerknuepfung")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NavigationsbereichId).HasColumnName("navigationsbereich_id");

                entity.Property(e => e.Sqlstring)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("sqlstring");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BenutzerUebersichts)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerUebersicht_Benutzer");

                entity.HasOne(d => d.Benutzeruebersichtbasis)
                    .WithMany(p => p.BenutzerUebersichts)
                    .HasForeignKey(d => d.BenutzeruebersichtbasisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerUebersicht_BenutzerUebersichtBasis");

                entity.HasOne(d => d.Navigationsbereich)
                    .WithMany(p => p.BenutzerUebersichts)
                    .HasForeignKey(d => d.NavigationsbereichId)
                    .HasConstraintName("FK_BenutzerUebersicht_Navigationsbereich");
            });

            modelBuilder.Entity<BenutzerUebersichtBasis>(entity =>
            {
                entity.ToTable("BenutzerUebersichtBasis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OeffneModul)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oeffneModul");

                entity.Property(e => e.Typ)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("typ");

                entity.Property(e => e.Viewname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("viewname");
            });

            modelBuilder.Entity<BenutzerUebersichtBasisTyp>(entity =>
            {
                entity.ToTable("BenutzerUebersichtBasisTyp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstFiltertextAktiv)
                    .IsRequired()
                    .HasColumnName("istFiltertextAktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Typ)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("typ");
            });

            modelBuilder.Entity<BenutzerUebersichtBasisTypBenutzerUebersichtOperator>(entity =>
            {
                entity.ToTable("BenutzerUebersichtBasisTyp_BenutzerUebersichtOperator");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerUebersichtBasisTypId).HasColumnName("benutzerUebersichtBasisTyp_id");

                entity.Property(e => e.BenutzerUebersichtOperatorId).HasColumnName("benutzerUebersichtOperator_id");

                entity.HasOne(d => d.BenutzerUebersichtBasisTyp)
                    .WithMany(p => p.BenutzerUebersichtBasisTypBenutzerUebersichtOperators)
                    .HasForeignKey(d => d.BenutzerUebersichtBasisTypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerUebersichtBasisTyp_BenutzerUebersichtOperator_BenutzerUebersichtBasisTyp");

                entity.HasOne(d => d.BenutzerUebersichtOperator)
                    .WithMany(p => p.BenutzerUebersichtBasisTypBenutzerUebersichtOperators)
                    .HasForeignKey(d => d.BenutzerUebersichtOperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerUebersichtBasisTyp_BenutzerUebersichtOperator_BenutzerUebersichtOperator");
            });

            modelBuilder.Entity<BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperator>(entity =>
            {
                entity.ToTable("BenutzerUebersicht_BenutzerUebersichtBasisTypBenutzerUebersichtOperator");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerUebersichtBasisTypBenutzerUebersichtOperatorId).HasColumnName("benutzerUebersichtBasisTypBenutzerUebersichtOperator_id");

                entity.Property(e => e.BenutzerUebersichtId).HasColumnName("benutzerUebersicht_id");

                entity.Property(e => e.Filtertext)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("filtertext");

                entity.Property(e => e.Spalte)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte");

                entity.HasOne(d => d.BenutzerUebersichtBasisTypBenutzerUebersichtOperator)
                    .WithMany(p => p.BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperators)
                    .HasForeignKey(d => d.BenutzerUebersichtBasisTypBenutzerUebersichtOperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerUebersicht_BenutzerUebersichtBasisTypBenutzerUebersichtOperator_BenutzerUebersichtBasisTyp_BenutzerUebersichtOperator");

                entity.HasOne(d => d.BenutzerUebersicht)
                    .WithMany(p => p.BenutzerUebersichtBenutzerUebersichtBasisTypBenutzerUebersichtOperators)
                    .HasForeignKey(d => d.BenutzerUebersichtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenutzerUebersicht_BenutzerUebersichtBasisTypBenutzerUebersichtOperator_BenutzerUebersicht");
            });

            modelBuilder.Entity<BenutzerUebersichtOperator>(entity =>
            {
                entity.ToTable("BenutzerUebersichtOperator");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstFiltertextAktiv)
                    .IsRequired()
                    .HasColumnName("istFiltertextAktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SqlBefehl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sqlBefehl");
            });

            modelBuilder.Entity<Benutzereinstellungen>(entity =>
            {
                entity.ToTable("Benutzereinstellungen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.DeaktiviereWaitCursor).HasColumnName("deaktiviereWaitCursor");

                entity.Property(e => e.EinrichtungStarteMaximiert).HasColumnName("einrichtung_StarteMaximiert");

                entity.Property(e => e.ExpandSachkonten).HasColumnName("expandSachkonten");

                entity.Property(e => e.KalkulationStarteMaximiert).HasColumnName("kalkulation_StarteMaximiert");

                entity.Property(e => e.KalkulationZeigeErtragslage).HasColumnName("kalkulation_ZeigeErtragslage");

                entity.Property(e => e.KalkulationZeigeFortschritt).HasColumnName("kalkulation_ZeigeFortschritt");

                entity.Property(e => e.MfpStarteMaximiert).HasColumnName("mfp_StarteMaximiert");

                entity.Property(e => e.ViewFixiereMenu).HasColumnName("view_fixiereMenu");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Benutzereinstellungens)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Benutzereinstellungen_Benutzer");
            });

            modelBuilder.Entity<Berechtigung>(entity =>
            {
                entity.ToTable("Berechtigung");

                entity.HasIndex(e => new { e.KategorieId, e.KlasseId, e.Aktiv }, "Standard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.IstAequivalentZuBerechtigungId).HasColumnName("istAequivalentZuBerechtigung_id");

                entity.Property(e => e.IstRoot).HasColumnName("istRoot");

                entity.Property(e => e.KategorieId).HasColumnName("kategorie_id");

                entity.Property(e => e.KlasseId).HasColumnName("klasse_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IstAequivalentZuBerechtigung)
                    .WithMany(p => p.InverseIstAequivalentZuBerechtigung)
                    .HasForeignKey(d => d.IstAequivalentZuBerechtigungId)
                    .HasConstraintName("FK_Berechtigung_Berechtigung1");

                entity.HasOne(d => d.Kategorie)
                    .WithMany(p => p.Berechtigungs)
                    .HasForeignKey(d => d.KategorieId)
                    .HasConstraintName("FK_Berechtigung_BerechtigungKategorie");

                entity.HasOne(d => d.Klasse)
                    .WithMany(p => p.Berechtigungs)
                    .HasForeignKey(d => d.KlasseId)
                    .HasConstraintName("FK_Berechtigung_BerechtigungKlasseTyp");
            });

            modelBuilder.Entity<BerechtigungBenutzerBerechtigung>(entity =>
            {
                entity.ToTable("BerechtigungBenutzer_Berechtigung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BerechtigungId).HasColumnName("berechtigung_id");

                entity.Property(e => e.BerechtigungObjektTypId).HasColumnName("berechtigungObjektTyp_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BerechtigungBenutzerBerechtigungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungBenutzer_Berechtigung_Benutzer");

                entity.HasOne(d => d.Berechtigung)
                    .WithMany(p => p.BerechtigungBenutzerBerechtigungs)
                    .HasForeignKey(d => d.BerechtigungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungBenutzer_Berechtigung_Berechtigung");

                entity.HasOne(d => d.BerechtigungObjektTyp)
                    .WithMany(p => p.BerechtigungBenutzerBerechtigungs)
                    .HasForeignKey(d => d.BerechtigungObjektTypId)
                    .HasConstraintName("FK_BerechtigungBenutzer_Berechtigung_BerechtigungObjektTyp");
            });

            modelBuilder.Entity<BerechtigungBerechtigung>(entity =>
            {
                entity.ToTable("Berechtigung_Berechtigung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PrimaerId).HasColumnName("primaer_id");

                entity.Property(e => e.SekundaerId).HasColumnName("sekundaer_id");

                entity.HasOne(d => d.Primaer)
                    .WithMany(p => p.BerechtigungBerechtigungPrimaers)
                    .HasForeignKey(d => d.PrimaerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Berechtigung_Berechtigung_Berechtigung");

                entity.HasOne(d => d.Sekundaer)
                    .WithMany(p => p.BerechtigungBerechtigungSekundaers)
                    .HasForeignKey(d => d.SekundaerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Berechtigung_Berechtigung_Berechtigung1");
            });

            modelBuilder.Entity<BerechtigungGruppeBerechtigung>(entity =>
            {
                entity.ToTable("BerechtigungGruppe_Berechtigung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BerechtigungId).HasColumnName("berechtigung_id");

                entity.Property(e => e.BerechtigungObjektTypId).HasColumnName("berechtigungObjektTyp_id");

                entity.Property(e => e.GruppeId).HasColumnName("gruppe_id");

                entity.HasOne(d => d.Berechtigung)
                    .WithMany(p => p.BerechtigungGruppeBerechtigungs)
                    .HasForeignKey(d => d.BerechtigungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungGruppe_Berechtigung_Berechtigung1");

                entity.HasOne(d => d.BerechtigungObjektTyp)
                    .WithMany(p => p.BerechtigungGruppeBerechtigungs)
                    .HasForeignKey(d => d.BerechtigungObjektTypId)
                    .HasConstraintName("FK_BerechtigungGruppe_Berechtigung_BerechtigungObjektTyp1");

                entity.HasOne(d => d.Gruppe)
                    .WithMany(p => p.BerechtigungGruppeBerechtigungs)
                    .HasForeignKey(d => d.GruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungGruppe_Berechtigung_Gruppe");
            });

            modelBuilder.Entity<BerechtigungKategorie>(entity =>
            {
                entity.ToTable("BerechtigungKategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BerechtigungKlasseTyp>(entity =>
            {
                entity.ToTable("BerechtigungKlasseTyp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Anzeigename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anzeigename");

                entity.Property(e => e.BerechtigungOberklasseAequivalentZuId).HasColumnName("berechtigungOberklasseAequivalentZu_id");

                entity.Property(e => e.Klassenname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("klassenname");

                entity.Property(e => e.OberBerechtigungKlasseTypId).HasColumnName("oberBerechtigungKlasseTyp_id");

                entity.HasOne(d => d.BerechtigungOberklasseAequivalentZu)
                    .WithMany(p => p.BerechtigungKlasseTyps)
                    .HasForeignKey(d => d.BerechtigungOberklasseAequivalentZuId)
                    .HasConstraintName("FK_BerechtigungKlasseTyp_BerechtigungOberklasseAequivalentZu");

                entity.HasOne(d => d.OberBerechtigungKlasseTyp)
                    .WithMany(p => p.InverseOberBerechtigungKlasseTyp)
                    .HasForeignKey(d => d.OberBerechtigungKlasseTypId)
                    .HasConstraintName("FK_BerechtigungKlasseTyp_BerechtigungKlasseTyp");
            });

            modelBuilder.Entity<BerechtigungKlasseTypEinschraenkung>(entity =>
            {
                entity.ToTable("BerechtigungKlasseTypEinschraenkung");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BerechtigungId).HasColumnName("berechtigung_id");

                entity.Property(e => e.BerechtigungKlasseTypId).HasColumnName("berechtigungKlasseTyp_id");

                entity.Property(e => e.IstPropertyIdFeld).HasColumnName("istPropertyIdFeld");

                entity.Property(e => e.Verbindungspropertie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("verbindungspropertie");

                entity.HasOne(d => d.Berechtigung)
                    .WithMany(p => p.BerechtigungKlasseTypEinschraenkungs)
                    .HasForeignKey(d => d.BerechtigungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungKlasseTypEinschraenkung_Berechtigung");

                entity.HasOne(d => d.BerechtigungKlasseTyp)
                    .WithMany(p => p.BerechtigungKlasseTypEinschraenkungs)
                    .HasForeignKey(d => d.BerechtigungKlasseTypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungKlasseTypEinschraenkung_BerechtigungKlasseTyp");
            });

            modelBuilder.Entity<BerechtigungKomponente>(entity =>
            {
                entity.ToTable("BerechtigungKomponente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BerechtigungKomponenteBerechtigung>(entity =>
            {
                entity.ToTable("BerechtigungKomponente_Berechtigung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BerechtigungKomponenteId).HasColumnName("berechtigungKomponente_id");

                entity.Property(e => e.RechteId).HasColumnName("rechte_id");

                entity.HasOne(d => d.BerechtigungKomponente)
                    .WithMany(p => p.BerechtigungKomponenteBerechtigungs)
                    .HasForeignKey(d => d.BerechtigungKomponenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungKomponente_Berechtigung_BerechtigungKomponente_Berechtigung1");

                entity.HasOne(d => d.Rechte)
                    .WithMany(p => p.BerechtigungKomponenteBerechtigungs)
                    .HasForeignKey(d => d.RechteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungKomponente_Berechtigung_BerechtigungKomponente_Berechtigung");
            });

            modelBuilder.Entity<BerechtigungOberklasseAequivalentZu>(entity =>
            {
                entity.ToTable("BerechtigungOberklasseAequivalentZu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FremdschluesselIstId).HasColumnName("fremdschluesselIstId");

                entity.Property(e => e.IstOberrechtId).HasColumnName("istOberrecht_id");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("propertyName");

                entity.HasOne(d => d.IstOberrecht)
                    .WithMany(p => p.BerechtigungOberklasseAequivalentZus)
                    .HasForeignKey(d => d.IstOberrechtId)
                    .HasConstraintName("FK_BerechtigungOberklasseAequivalentZu_BerechtigungKlasseTyp");
            });

            modelBuilder.Entity<BerechtigungObjektTyp>(entity =>
            {
                entity.ToTable("BerechtigungObjektTyp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KlassenTypId).HasColumnName("klassenTyp_id");

                entity.Property(e => e.Objektid).HasColumnName("objektid");

                entity.HasOne(d => d.KlassenTyp)
                    .WithMany(p => p.BerechtigungObjektTyps)
                    .HasForeignKey(d => d.KlassenTypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BerechtigungObjektTyp_BerechtigungKlasseTyp");
            });

            modelBuilder.Entity<Berufsgruppe>(entity =>
            {
                entity.ToTable("Berufsgruppe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Fq).HasColumnName("fq");

                entity.Property(e => e.IstGfb).HasColumnName("istGfb");

                entity.Property(e => e.IstUmsatzRelevant).HasColumnName("istUmsatzRelevant");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer).HasColumnName("nummer");

                entity.Property(e => e.PersonalfaktorId).HasColumnName("personalfaktorId");

                entity.Property(e => e.Tagessatz).HasColumnName("tagessatz");

                entity.Property(e => e.VerprobungsfaktorId).HasColumnName("verprobungsfaktor_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Berufsgruppes)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Berufsgruppe_Benutzer");

                entity.HasOne(d => d.Personalfaktor)
                    .WithMany(p => p.Berufsgruppes)
                    .HasForeignKey(d => d.PersonalfaktorId)
                    .HasConstraintName("FK_Berufsgruppe_Personalfaktor");

                entity.HasOne(d => d.Verprobungsfaktor)
                    .WithMany(p => p.Berufsgruppes)
                    .HasForeignKey(d => d.VerprobungsfaktorId)
                    .HasConstraintName("FK_Berufsgruppe_Verprobungsfaktor");
            });

            modelBuilder.Entity<BerufsgruppeSachkonto>(entity =>
            {
                entity.ToTable("Berufsgruppe_Sachkonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppeId");

                entity.Property(e => e.SkAltersvorsorgeId).HasColumnName("skAltersvorsorgeId");

                entity.Property(e => e.SkAltersvorsorgeZusatzId).HasColumnName("skAltersvorsorgeZusatzId");

                entity.Property(e => e.SkArbeitslosenVersId).HasColumnName("skArbeitslosenVersId");

                entity.Property(e => e.SkAufwendungsausglId).HasColumnName("skAufwendungsausglId");

                entity.Property(e => e.SkBeihilfeId).HasColumnName("skBeihilfeId");

                entity.Property(e => e.SkBerufsgenossenschId).HasColumnName("skBerufsgenossenschId");

                entity.Property(e => e.SkErstattungId).HasColumnName("skErstattungId");

                entity.Property(e => e.SkGehaltId).HasColumnName("skGehaltId");

                entity.Property(e => e.SkHaftpflichtId).HasColumnName("skHaftpflichtId");

                entity.Property(e => e.SkKrankenVersId).HasColumnName("skKrankenVersId");

                entity.Property(e => e.SkLohnsteuerId).HasColumnName("skLohnsteuerId");

                entity.Property(e => e.SkPflegeVersId).HasColumnName("skPflegeVersId");

                entity.Property(e => e.SkPraemieSonderzahlungId).HasColumnName("skPraemieSonderzahlungId");

                entity.Property(e => e.SkSchwerbehinPauschId).HasColumnName("skSchwerbehinPauschId");

                entity.Property(e => e.SkSozialVersId).HasColumnName("skSozialVersId");

                entity.Property(e => e.SkZuschlagId).HasColumnName("skZuschlagId");

                entity.Property(e => e.SkZuschlagSvpflichtigId).HasColumnName("skZuschlagSVpflichtigId");

                entity.Property(e => e.TypId).HasColumnName("typId");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.BerufsgruppeSachkontos)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_Berufsgruppe");

                entity.HasOne(d => d.SkAltersvorsorge)
                    .WithMany(p => p.BerufsgruppeSachkontoSkAltersvorsorges)
                    .HasForeignKey(d => d.SkAltersvorsorgeId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoAltersvorsorge");

                entity.HasOne(d => d.SkAltersvorsorgeZusatz)
                    .WithMany(p => p.BerufsgruppeSachkontoSkAltersvorsorgeZusatzs)
                    .HasForeignKey(d => d.SkAltersvorsorgeZusatzId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_Sachkonto");

                entity.HasOne(d => d.SkArbeitslosenVers)
                    .WithMany(p => p.BerufsgruppeSachkontoSkArbeitslosenVers)
                    .HasForeignKey(d => d.SkArbeitslosenVersId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoArbeitslosenversicherung");

                entity.HasOne(d => d.SkAufwendungsausgl)
                    .WithMany(p => p.BerufsgruppeSachkontoSkAufwendungsausgls)
                    .HasForeignKey(d => d.SkAufwendungsausglId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoAufwendungsausgleich");

                entity.HasOne(d => d.SkBeihilfe)
                    .WithMany(p => p.BerufsgruppeSachkontoSkBeihilves)
                    .HasForeignKey(d => d.SkBeihilfeId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoBeihilfe");

                entity.HasOne(d => d.SkBerufsgenossensch)
                    .WithMany(p => p.BerufsgruppeSachkontoSkBerufsgenossensches)
                    .HasForeignKey(d => d.SkBerufsgenossenschId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoBerufsgenosschenschaft");

                entity.HasOne(d => d.SkErstattung)
                    .WithMany(p => p.BerufsgruppeSachkontoSkErstattungs)
                    .HasForeignKey(d => d.SkErstattungId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoErstattung");

                entity.HasOne(d => d.SkGehalt)
                    .WithMany(p => p.BerufsgruppeSachkontoSkGehalts)
                    .HasForeignKey(d => d.SkGehaltId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoGehalt");

                entity.HasOne(d => d.SkHaftpflicht)
                    .WithMany(p => p.BerufsgruppeSachkontoSkHaftpflichts)
                    .HasForeignKey(d => d.SkHaftpflichtId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoHaftpflicht");

                entity.HasOne(d => d.SkKrankenVers)
                    .WithMany(p => p.BerufsgruppeSachkontoSkKrankenVers)
                    .HasForeignKey(d => d.SkKrankenVersId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoKrankenvers");

                entity.HasOne(d => d.SkLohnsteuer)
                    .WithMany(p => p.BerufsgruppeSachkontoSkLohnsteuers)
                    .HasForeignKey(d => d.SkLohnsteuerId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoLohnsteuer");

                entity.HasOne(d => d.SkPflegeVers)
                    .WithMany(p => p.BerufsgruppeSachkontoSkPflegeVers)
                    .HasForeignKey(d => d.SkPflegeVersId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoPflegeVers");

                entity.HasOne(d => d.SkPraemieSonderzahlung)
                    .WithMany(p => p.BerufsgruppeSachkontoSkPraemieSonderzahlungs)
                    .HasForeignKey(d => d.SkPraemieSonderzahlungId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_Sachkonto1");

                entity.HasOne(d => d.SkSchwerbehinPausch)
                    .WithMany(p => p.BerufsgruppeSachkontoSkSchwerbehinPausches)
                    .HasForeignKey(d => d.SkSchwerbehinPauschId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoSchwerbehinPausch");

                entity.HasOne(d => d.SkSozialVers)
                    .WithMany(p => p.BerufsgruppeSachkontoSkSozialVers)
                    .HasForeignKey(d => d.SkSozialVersId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoSozialvers");

                entity.HasOne(d => d.SkZuschlag)
                    .WithMany(p => p.BerufsgruppeSachkontoSkZuschlags)
                    .HasForeignKey(d => d.SkZuschlagId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoZuschlagSVfrei");

                entity.HasOne(d => d.SkZuschlagSvpflichtig)
                    .WithMany(p => p.BerufsgruppeSachkontoSkZuschlagSvpflichtigs)
                    .HasForeignKey(d => d.SkZuschlagSvpflichtigId)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_SachkontoSVpflichtig");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.BerufsgruppeSachkontos)
                    .HasForeignKey(d => d.TypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Berufsgruppe_Sachkonto_Typ");
            });

            modelBuilder.Entity<Bestand>(entity =>
            {
                entity.ToTable("Bestand");

                entity.HasIndex(e => new { e.LagerId, e.SchwundId, e.BenutzerId, e.Aktiv }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abschlussdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("abschlussdatum");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.IstInventur).HasColumnName("istInventur");

                entity.Property(e => e.LagerId).HasColumnName("lagerId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SchwundId).HasColumnName("schwundId");

                entity.Property(e => e.Sollinventurdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("sollinventurdatum");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Bestands)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Bestand_Benutzer");

                entity.HasOne(d => d.Lager)
                    .WithMany(p => p.Bestands)
                    .HasForeignKey(d => d.LagerId)
                    .HasConstraintName("FK_Bestand_Lager");

                entity.HasOne(d => d.Schwund)
                    .WithMany(p => p.Bestands)
                    .HasForeignKey(d => d.SchwundId)
                    .HasConstraintName("FK_Bestand_Schwund");
            });

            modelBuilder.Entity<BestandLagerArtikel>(entity =>
            {
                entity.ToTable("Bestand_Lager_Artikel");

                entity.HasIndex(e => new { e.BestandId, e.LagerArtikelId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BestandId).HasColumnName("bestand_id");

                entity.Property(e => e.ErklaerungAbweichung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("erklaerungAbweichung");

                entity.Property(e => e.Istmenge).HasColumnName("istmenge");

                entity.Property(e => e.LagerArtikelId).HasColumnName("lager_artikel_id");

                entity.Property(e => e.Preis).HasColumnName("preis");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");

                entity.HasOne(d => d.Bestand)
                    .WithMany(p => p.BestandLagerArtikels)
                    .HasForeignKey(d => d.BestandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestand_Lager_Artikel_Bestand");

                entity.HasOne(d => d.LagerArtikel)
                    .WithMany(p => p.BestandLagerArtikels)
                    .HasForeignKey(d => d.LagerArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestand_Lager_Artikel_Lager_Artikel");
            });

            modelBuilder.Entity<Bestandsbewegung>(entity =>
            {
                entity.ToTable("Bestandsbewegung");

                entity.HasIndex(e => e.Aenderungsdatum, "IX_Bestandsbewegung");

                entity.HasIndex(e => e.LagerId, "IX_Bestandsbewegung_1");

                entity.HasIndex(e => e.LagerArtikelId, "IX_Bestandsbewegung_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.GrundObjektId).HasColumnName("grundObjektId");

                entity.Property(e => e.GrundObjektTyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("grundObjektTyp");

                entity.Property(e => e.LagerArtikelId).HasColumnName("lager_artikel_id");

                entity.Property(e => e.LagerId).HasColumnName("lager_id");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.StckPreis).HasColumnName("stckPreis");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Bestandsbewegungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestandsbewegung_Benutzer");

                entity.HasOne(d => d.LagerArtikel)
                    .WithMany(p => p.Bestandsbewegungs)
                    .HasForeignKey(d => d.LagerArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestandsbewegung_Lager_Artikel");

                entity.HasOne(d => d.Lager)
                    .WithMany(p => p.Bestandsbewegungs)
                    .HasForeignKey(d => d.LagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestandsbewegung_Lager");
            });

            modelBuilder.Entity<BestellObjekt>(entity =>
            {
                entity.ToTable("BestellObjekt");

                entity.HasIndex(e => new { e.BestellStatusId, e.Aktiv }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BestellStatusId).HasColumnName("bestellStatus_id");

                entity.Property(e => e.Bestelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("bestelldatum");

                entity.Property(e => e.Bestellnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellnummer");

                entity.Property(e => e.Lieferdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("lieferdatum");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BestellObjekts)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BestellObjekt_Benutzer");

                entity.HasOne(d => d.BestellStatus)
                    .WithMany(p => p.BestellObjekts)
                    .HasForeignKey(d => d.BestellStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BestellObjekt_BestellStatus");
            });

            modelBuilder.Entity<BestellObjektArtikel>(entity =>
            {
                entity.ToTable("BestellObjekt_Artikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.ArtikelEinkaufId).HasColumnName("artikelEinkauf_id");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.BestellObjektId).HasColumnName("bestellObjekt_id");

                entity.Property(e => e.BestellteMenge).HasColumnName("bestellteMenge");

                entity.Property(e => e.BestellteMengeInterneMe).HasColumnName("bestellteMengeInterneME");

                entity.Property(e => e.GebuchteMenge).HasColumnName("gebuchteMenge");

                entity.Property(e => e.GelieferteMenge).HasColumnName("gelieferteMenge");

                entity.Property(e => e.StckPreis).HasColumnName("stckPreis");

                entity.HasOne(d => d.ArtikelEinkauf)
                    .WithMany(p => p.BestellObjektArtikels)
                    .HasForeignKey(d => d.ArtikelEinkaufId)
                    .HasConstraintName("FK_BestellObjekt_Artikel_ArtikelEinkauf");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.BestellObjektArtikels)
                    .HasForeignKey(d => d.ArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BestellObjekt_Artikel_Artikel");

                entity.HasOne(d => d.BestellObjekt)
                    .WithMany(p => p.BestellObjektArtikels)
                    .HasForeignKey(d => d.BestellObjektId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BestellObjekt_Artikel_BestellObjekt");
            });

            modelBuilder.Entity<BestellObjektStatus>(entity =>
            {
                entity.ToTable("BestellObjektStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Kennziffer).HasColumnName("kennziffer");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Bestellung>(entity =>
            {
                entity.ToTable("Bestellung");

                entity.HasIndex(e => new { e.BetriebsstaetteId, e.Aktiv }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_Id");

                entity.Property(e => e.Bestelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("bestelldatum");

                entity.Property(e => e.Bestellnummer)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bestellnummer");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.IstBarkauf).HasColumnName("istBarkauf");

                entity.Property(e => e.Lieferdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("lieferdatum");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Rechnungsnummer)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rechnungsnummer");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponenteId");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Bestellungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Bestellung_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Bestellungs)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Bestellung_Betriebsstaette");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.Bestellungs)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .HasConstraintName("FK_Bestellung_Warenwirtschaftskomponente");
            });

            modelBuilder.Entity<BestellungLagerArtikel>(entity =>
            {
                entity.ToTable("Bestellung_Lager_Artikel");

                entity.HasIndex(e => new { e.BestellungId, e.LagerArtikelId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bestellmenge).HasColumnName("bestellmenge");

                entity.Property(e => e.BestellungId).HasColumnName("bestellungId");

                entity.Property(e => e.Gebindegroesse).HasColumnName("gebindegroesse");

                entity.Property(e => e.LagerArtikelId).HasColumnName("lager_ArtikelId");

                entity.Property(e => e.Lieferdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("lieferdatum");

                entity.Property(e => e.Liefermenge).HasColumnName("liefermenge");

                entity.Property(e => e.MengeGebucht).HasColumnName("mengeGebucht");

                entity.HasOne(d => d.Bestellung)
                    .WithMany(p => p.BestellungLagerArtikels)
                    .HasForeignKey(d => d.BestellungId)
                    .HasConstraintName("FK_Bestellung_Lager_Artikel_Bestellung");

                entity.HasOne(d => d.LagerArtikel)
                    .WithMany(p => p.BestellungLagerArtikels)
                    .HasForeignKey(d => d.LagerArtikelId)
                    .HasConstraintName("FK_Bestellung_Lager_Artikel_Lager_Artikel");
            });

            modelBuilder.Entity<Betriebsstaette>(entity =>
            {
                entity.ToTable("Betriebsstaette");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdresseId).HasColumnName("adresse_id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.BenutzerGebietsleiterId).HasColumnName("benutzerGebietsleiter_id");

                entity.Property(e => e.BenutzerGeoffnetId).HasColumnName("benutzerGeoffnetId");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.BundeslandId).HasColumnName("bundesland_id");

                entity.Property(e => e.DatumGesperrt)
                    .HasColumnType("datetime")
                    .HasColumnName("datumGesperrt");

                entity.Property(e => e.Deaktiviert).HasColumnName("deaktiviert");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.FestesPersonal).HasColumnName("festesPersonal");

                entity.Property(e => e.ImportNurAngelegteKst).HasColumnName("importNurAngelegteKst");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.Kundennr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundennr");

                entity.Property(e => e.MandantId).HasColumnName("mandantId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RegionaleZuordnungId).HasColumnName("regionaleZuordnung_id");

                entity.Property(e => e.SchnittstelleneinstellungId).HasColumnName("schnittstelleneinstellung_id");

                entity.Property(e => e.Stundenwoche).HasColumnName("stundenwoche");

                entity.Property(e => e.TraegerId).HasColumnName("traeger_id");

                entity.Property(e => e.TypId).HasColumnName("typ_id");

                entity.Property(e => e.ZGasachkontoId).HasColumnName("zGASachkontoId");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.AdresseId)
                    .HasConstraintName("FK_Betriebsstaette_Adresse");

                entity.HasOne(d => d.BenutzerGebietsleiter)
                    .WithMany(p => p.BetriebsstaetteBenutzerGebietsleiters)
                    .HasForeignKey(d => d.BenutzerGebietsleiterId)
                    .HasConstraintName("FK_Betriebsstaette_Benutzer1");

                entity.HasOne(d => d.BenutzerGeoffnet)
                    .WithMany(p => p.BetriebsstaetteBenutzerGeoffnets)
                    .HasForeignKey(d => d.BenutzerGeoffnetId)
                    .HasConstraintName("FK_Betriebsstaette_BenutzerGeoffnet");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BetriebsstaetteBenutzers)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Betriebsstaette_Benutzer");

                entity.HasOne(d => d.Bundesland)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.BundeslandId)
                    .HasConstraintName("FK_Betriebsstaette_Bundesland");

                entity.HasOne(d => d.Mandant)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.MandantId)
                    .HasConstraintName("FK_Betriebsstaette_Mandant");

                entity.HasOne(d => d.RegionaleZuordnung)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.RegionaleZuordnungId)
                    .HasConstraintName("FK_Betriebsstaette_RegionaleZuordnung");

                entity.HasOne(d => d.Schnittstelleneinstellung)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.SchnittstelleneinstellungId)
                    .HasConstraintName("FK_Betriebsstaette_Schnittstelleneinstellung");

                entity.HasOne(d => d.Traeger)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.TraegerId)
                    .HasConstraintName("FK_Betriebsstaette_Traeger");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK_Betriebsstaette_Typ");

                entity.HasOne(d => d.ZGasachkonto)
                    .WithMany(p => p.Betriebsstaettes)
                    .HasForeignKey(d => d.ZGasachkontoId)
                    .HasConstraintName("FK_Betriebsstaette_Sachkonto");
            });

            modelBuilder.Entity<BetriebsstaetteSachkontoKostenstelleDienstart>(entity =>
            {
                entity.ToTable("Betriebsstaette_Sachkonto_Kostenstelle_Dienstart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.DienstartId).HasColumnName("dienstart_id");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.Prozent).HasColumnName("prozent");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.BetriebsstaetteSachkontoKostenstelleDienstarts)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Betriebsstaette_Sachkonto_Kostenstelle_Dienstart_Betriebsstaette");

                entity.HasOne(d => d.Dienstart)
                    .WithMany(p => p.BetriebsstaetteSachkontoKostenstelleDienstarts)
                    .HasForeignKey(d => d.DienstartId)
                    .HasConstraintName("FK_Betriebsstaette_Sachkonto_Kostenstelle_Dienstart_Berufsgruppe");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.BetriebsstaetteSachkontoKostenstelleDienstarts)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Betriebsstaette_Sachkonto_Kostenstelle_Dienstart_Kostenstelle");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.BetriebsstaetteSachkontoKostenstelleDienstarts)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_Betriebsstaette_Sachkonto_Kostenstelle_Dienstart_Sachkonto");
            });

            modelBuilder.Entity<BetriebsstaetteVerprobungsfaktor>(entity =>
            {
                entity.ToTable("Betriebsstaette_Verprobungsfaktor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsart_id");

                entity.Property(e => e.Bedarf).HasColumnName("bedarf");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppe_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.Faktor)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("faktor");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.Schluessel).HasColumnName("schluessel");

                entity.Property(e => e.VerprobungsfaktorId).HasColumnName("verprobungsfaktor_id");

                entity.HasOne(d => d.Auslastungsart)
                    .WithMany(p => p.BetriebsstaetteVerprobungsfaktors)
                    .HasForeignKey(d => d.AuslastungsartId)
                    .HasConstraintName("FK_Betriebsstaette_Verprobungsfaktor_Auslastungsart");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.BetriebsstaetteVerprobungsfaktors)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .HasConstraintName("FK_Betriebsstaette_Verprobungsfaktor_Berufsgruppe");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.BetriebsstaetteVerprobungsfaktors)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Betriebsstaette_Verprobungsfaktor_Betriebsstaette");

                entity.HasOne(d => d.Verprobungsfaktor)
                    .WithMany(p => p.BetriebsstaetteVerprobungsfaktors)
                    .HasForeignKey(d => d.VerprobungsfaktorId)
                    .HasConstraintName("FK_Betriebsstaette_Verprobungsfaktor_Verprobungsfaktor");
            });

            modelBuilder.Entity<BetriebsstaetteVorgabewerte>(entity =>
            {
                entity.ToTable("BetriebsstaetteVorgabewerte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.Neg1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Neg2).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pos1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pos2).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("propertyName");

                entity.Property(e => e.PropertyTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("propertyTyp");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.BetriebsstaetteVorgabewertes)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_BetriebsstaetteVorgabewerte_Betriebsstaette");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.BetriebsstaetteVorgabewertes)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_BetriebsstaetteVorgabewerte_Kostenstelle");
            });

            modelBuilder.Entity<BetriebsstaetteWareneinsatz>(entity =>
            {
                entity.ToTable("BetriebsstaetteWareneinsatz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abend).HasColumnName("abend");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.BudgetProBkt).HasColumnName("budgetProBkt");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Fruehstueck).HasColumnName("fruehstueck");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Mittag).HasColumnName("mittag");

                entity.Property(e => e.Nachmittag).HasColumnName("nachmittag");

                entity.Property(e => e.Sonstiges).HasColumnName("sonstiges");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BetriebsstaetteWareneinsatzs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BetriebsstaetteWareneinsatz_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.BetriebsstaetteWareneinsatzs)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BetriebsstaetteWareneinsatz_Betriebsstaette");
            });

            modelBuilder.Entity<Betriebsstaettedarlehen>(entity =>
            {
                entity.ToTable("Betriebsstaettedarlehen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbgrenzungTilgung).HasColumnName("abgrenzungTilgung");

                entity.Property(e => e.AbgrenzungZinsen).HasColumnName("abgrenzungZinsen");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.IstRatendarlehen).HasColumnName("istRatendarlehen");

                entity.Property(e => e.IstTilgungsplanImportiert).HasColumnName("istTilgungsplanImportiert");

                entity.Property(e => e.IstVergeben).HasColumnName("istVergeben");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.Kreditbetrag)
                    .HasColumnType("money")
                    .HasColumnName("kreditbetrag");

                entity.Property(e => e.Laufzeit).HasColumnName("laufzeit");

                entity.Property(e => e.Rate)
                    .HasColumnType("money")
                    .HasColumnName("rate");

                entity.Property(e => e.SachkontoAbgrenzungTilung).HasColumnName("sachkonto_abgrenzungTilung");

                entity.Property(e => e.SachkontoAbgrenzungZinsen).HasColumnName("sachkonto_abgrenzungZinsen");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.Property(e => e.Startdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("startdatum");

                entity.Property(e => e.Tilgungen).HasColumnName("tilgungen");

                entity.Property(e => e.TypId).HasColumnName("typ_id");

                entity.Property(e => e.Zinssatz)
                    .HasColumnType("money")
                    .HasColumnName("zinssatz");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Betriebsstaettedarlehens)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Betriebsstaettedarlehen_Betriebsstaette");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Betriebsstaettedarlehens)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Betriebsstaettedarlehen_Kostenstelle");

                entity.HasOne(d => d.SachkontoAbgrenzungTilungNavigation)
                    .WithMany(p => p.BetriebsstaettedarlehenSachkontoAbgrenzungTilungNavigations)
                    .HasForeignKey(d => d.SachkontoAbgrenzungTilung)
                    .HasConstraintName("FK_Betriebsstaettedarlehen_SachkontoAbTilgung");

                entity.HasOne(d => d.SachkontoAbgrenzungZinsenNavigation)
                    .WithMany(p => p.BetriebsstaettedarlehenSachkontoAbgrenzungZinsenNavigations)
                    .HasForeignKey(d => d.SachkontoAbgrenzungZinsen)
                    .HasConstraintName("FK_Betriebsstaettedarlehen_SachkontoAbZinsen");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.BetriebsstaettedarlehenSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_Betriebsstaettedarlehen_Sachkonto");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.Betriebsstaettedarlehens)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK_Betriebsstaettedarlehen_DarlehenTypen");
            });

            modelBuilder.Entity<BetriebsstaettedarlehenTilgungsplan>(entity =>
            {
                entity.ToTable("Betriebsstaettedarlehen_Tilgungsplan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Annuitaet)
                    .HasColumnType("money")
                    .HasColumnName("annuitaet");

                entity.Property(e => e.BetriebsstaettedarlehenId).HasColumnName("betriebsstaettedarlehen_id");

                entity.Property(e => e.IstSondertilgung).HasColumnName("istSondertilgung");

                entity.Property(e => e.Startsaldo)
                    .HasColumnType("money")
                    .HasColumnName("startsaldo");

                entity.Property(e => e.Tilgung)
                    .HasColumnType("money")
                    .HasColumnName("tilgung");

                entity.Property(e => e.Zahlungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("zahlungsdatum");

                entity.Property(e => e.Zinsen)
                    .HasColumnType("money")
                    .HasColumnName("zinsen");

                entity.HasOne(d => d.Betriebsstaettedarlehen)
                    .WithMany(p => p.BetriebsstaettedarlehenTilgungsplans)
                    .HasForeignKey(d => d.BetriebsstaettedarlehenId)
                    .HasConstraintName("FK_Betriebsstaettedarlehen_Tilgungsplan_Betriebsstaettedarlehen");
            });

            modelBuilder.Entity<Bild>(entity =>
            {
                entity.ToTable("Bild");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Bild1)
                    .HasColumnType("image")
                    .HasColumnName("bild");
            });

            modelBuilder.Entity<Boardkategorie>(entity =>
            {
                entity.ToTable("Boardkategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Boardmeldungen>(entity =>
            {
                entity.ToTable("Boardmeldungen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BoardkategorieId).HasColumnName("boardkategorie_id");

                entity.Property(e => e.DatumBis)
                    .HasColumnType("datetime")
                    .HasColumnName("datum_bis");

                entity.Property(e => e.DatumVon)
                    .HasColumnType("datetime")
                    .HasColumnName("datum_von");

                entity.Property(e => e.Gelesen)
                    .HasColumnType("datetime")
                    .HasColumnName("gelesen");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.Property(e => e.Ueberschrift)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ueberschrift");

                entity.HasOne(d => d.Boardkategorie)
                    .WithMany(p => p.Boardmeldungens)
                    .HasForeignKey(d => d.BoardkategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Boardmeldungen_Boardmeldungen");
            });

            modelBuilder.Entity<BsRechte>(entity =>
            {
                entity.ToTable("BS_rechte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.ArtikelLesen).HasColumnName("artikel_lesen");

                entity.Property(e => e.ArtikelSchreiben).HasColumnName("artikel_schreiben");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.BudgetierungLesen).HasColumnName("budgetierung_lesen");

                entity.Property(e => e.BudgetierungSchreiben).HasColumnName("budgetierung_schreiben");

                entity.Property(e => e.BudgetierungSchreibrechteAfa).HasColumnName("budgetierung_schreibrechte_afa");

                entity.Property(e => e.BudgetierungSchreibrechteAuslastungsplanung).HasColumnName("budgetierung_schreibrechte_auslastungsplanung");

                entity.Property(e => e.BudgetierungSchreibrechtePersonalkosten).HasColumnName("budgetierung_schreibrechte_personalkosten");

                entity.Property(e => e.BudgetierungSchreibrechtePersonalplanung).HasColumnName("budgetierung_schreibrechte_personalplanung");

                entity.Property(e => e.BudgetierungSchreibrechtePersonalplanungzdl).HasColumnName("budgetierung_schreibrechte_personalplanungzdl");

                entity.Property(e => e.BudgetierungSchreibrechteSachkostenplanung).HasColumnName("budgetierung_schreibrechte_sachkostenplanung");

                entity.Property(e => e.BudgetierungSchreibrechteWohnung).HasColumnName("budgetierung_schreibrechte_wohnung");

                entity.Property(e => e.CafeLesen).HasColumnName("cafe_lesen");

                entity.Property(e => e.CafeSchreiben).HasColumnName("cafe_schreiben");

                entity.Property(e => e.CateringLesen).HasColumnName("catering_lesen");

                entity.Property(e => e.CateringSchreiben).HasColumnName("catering_schreiben");

                entity.Property(e => e.EinrichtungsverwaltungLesen).HasColumnName("einrichtungsverwaltung_lesen");

                entity.Property(e => e.EinrichtungsverwaltungSchreiben).HasColumnName("einrichtungsverwaltung_schreiben");

                entity.Property(e => e.ErloesstatistikLesen).HasColumnName("erloesstatistik_lesen");

                entity.Property(e => e.ErloesstatistikSchreiben).HasColumnName("erloesstatistik_schreiben");

                entity.Property(e => e.EssensstatistikLesen).HasColumnName("essensstatistik_lesen");

                entity.Property(e => e.EssensstatistikSchreiben).HasColumnName("essensstatistik_schreiben");

                entity.Property(e => e.FinanzplanungLesen).HasColumnName("finanzplanung_lesen");

                entity.Property(e => e.FinanzplanungSchreiben).HasColumnName("finanzplanung_schreiben");

                entity.Property(e => e.InventurFuerAlleWawiKomponenten).HasColumnName("inventur_fuer_alle_wawi_komponenten");

                entity.Property(e => e.KioskLesen).HasColumnName("kiosk_lesen");

                entity.Property(e => e.KioskSchreiben).HasColumnName("kiosk_schreiben");

                entity.Property(e => e.KonsolidierungLesen).HasColumnName("konsolidierung_lesen");

                entity.Property(e => e.KonsolidierungSchreiben).HasColumnName("konsolidierung_schreiben");

                entity.Property(e => e.KuechenLesen).HasColumnName("kuechen_lesen");

                entity.Property(e => e.KuechenSchreiben).HasColumnName("kuechen_schreiben");

                entity.Property(e => e.LieferantenLesen).HasColumnName("lieferanten_lesen");

                entity.Property(e => e.LieferantenSchreiben).HasColumnName("lieferanten_schreiben");

                entity.Property(e => e.RechteId).HasColumnName("rechte_id");

                entity.Property(e => e.RelLesen).HasColumnName("REL_lesen");

                entity.Property(e => e.RelSchreiben).HasColumnName("REL_schreiben");

                entity.Property(e => e.UnterhaltsreinigungLesen).HasColumnName("unterhaltsreinigung_lesen");

                entity.Property(e => e.UnterhaltsreinigungSchreiben).HasColumnName("unterhaltsreinigung_schreiben");

                entity.Property(e => e.WareneinsatzLesen).HasColumnName("wareneinsatz_lesen");

                entity.Property(e => e.WareneinsatzSchreiben).HasColumnName("wareneinsatz_schreiben");

                entity.Property(e => e.WarentransferFuerAlleWawiKomponenten).HasColumnName("warentransfer_fuer_alle_wawi_komponenten");

                entity.Property(e => e.WarentransferFuerEventkostenstelle).HasColumnName("warentransfer_fuer_eventkostenstelle");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.BsRechtes)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BS_rechte_Betriebsstaette");

                entity.HasOne(d => d.Rechte)
                    .WithMany(p => p.BsRechtes)
                    .HasForeignKey(d => d.RechteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BS_rechte_Rechte");
            });

            modelBuilder.Entity<Buchungstag>(entity =>
            {
                entity.ToTable("Buchungstag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuchungstagDefinitionId).HasColumnName("buchungstagDefinition_id");

                entity.Property(e => e.DarfUeberschriebenWerden).HasColumnName("darfUeberschriebenWerden");

                entity.Property(e => e.SachkontengruppeId).HasColumnName("sachkontengruppe_id");

                entity.Property(e => e.SachkontenkategorieId).HasColumnName("sachkontenkategorie_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.Property(e => e.Tag).HasColumnName("tag");

                entity.HasOne(d => d.BuchungstagDefinition)
                    .WithMany(p => p.Buchungstags)
                    .HasForeignKey(d => d.BuchungstagDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuchungstagDefinition_Buchungstag");

                entity.HasOne(d => d.Sachkontengruppe)
                    .WithMany(p => p.Buchungstags)
                    .HasForeignKey(d => d.SachkontengruppeId)
                    .HasConstraintName("FK_BuchungstagDefinition_Sachkontengruppe");

                entity.HasOne(d => d.Sachkontenkategorie)
                    .WithMany(p => p.Buchungstags)
                    .HasForeignKey(d => d.SachkontenkategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuchungstagDefinition_Sachkontenkategorie");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.Buchungstags)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_BuchungstagDefinition_Sachkonto");
            });

            modelBuilder.Entity<BuchungstagDefinition>(entity =>
            {
                entity.ToTable("BuchungstagDefinition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstGlobal).HasColumnName("istGlobal");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.BuchungstagDefinitions)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Buchungstag_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.BuchungstagDefinitions)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Buchungstag_Betriebsstaette");
            });

            modelBuilder.Entity<Bundesland>(entity =>
            {
                entity.ToTable("Bundesland");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AltesBundesland)
                    .IsRequired()
                    .HasColumnName("altesBundesland")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CateringAllgemein>(entity =>
            {
                entity.ToTable("CateringAllgemein");

                entity.HasIndex(e => e.KalkulationId, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnzahlAbendessen).HasColumnName("anzahlAbendessen");

                entity.Property(e => e.AnzahlBkt).HasColumnName("anzahlBkt");

                entity.Property(e => e.AnzahlBktAbendessen).HasColumnName("anzahlBktAbendessen");

                entity.Property(e => e.AnzahlBktAbendessenPrivat).HasColumnName("anzahlBktAbendessenPrivat");

                entity.Property(e => e.AnzahlBktFruehstueck).HasColumnName("anzahlBktFruehstueck");

                entity.Property(e => e.AnzahlBktFruehstueckPrivat).HasColumnName("anzahlBktFruehstueckPrivat");

                entity.Property(e => e.AnzahlBktHeissgetraenke).HasColumnName("anzahlBktHeissgetraenke");

                entity.Property(e => e.AnzahlBktHeissgetraenkePrivat).HasColumnName("anzahlBktHeissgetraenkePrivat");

                entity.Property(e => e.AnzahlBktKaltgetraenke).HasColumnName("anzahlBktKaltgetraenke");

                entity.Property(e => e.AnzahlBktKaltgetraenkePrivat).HasColumnName("anzahlBktKaltgetraenkePrivat");

                entity.Property(e => e.AnzahlBktMittag).HasColumnName("anzahlBktMittag");

                entity.Property(e => e.AnzahlBktMittagPrivat).HasColumnName("anzahlBktMittagPrivat");

                entity.Property(e => e.AnzahlBktPrivat).HasColumnName("anzahlBktPrivat");

                entity.Property(e => e.AnzahlBktZwischenmahlzeit).HasColumnName("anzahlBktZwischenmahlzeit");

                entity.Property(e => e.AnzahlBktZwischenmahlzeitPrivat).HasColumnName("anzahlBktZwischenmahlzeitPrivat");

                entity.Property(e => e.AnzahlFruehstueck).HasColumnName("anzahlFruehstueck");

                entity.Property(e => e.AnzahlHeissgetraenke).HasColumnName("anzahlHeissgetraenke");

                entity.Property(e => e.AnzahlKaltgetraenke).HasColumnName("anzahlKaltgetraenke");

                entity.Property(e => e.AnzahlMittag).HasColumnName("anzahlMittag");

                entity.Property(e => e.AnzahlZwischenmahlzeit).HasColumnName("anzahlZwischenmahlzeit");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.PreisAbendessenPrivat).HasColumnName("preisAbendessenPrivat");

                entity.Property(e => e.PreisFruehstueckPrivat).HasColumnName("preisFruehstueckPrivat");

                entity.Property(e => e.PreisHeissgetraenkePrivat).HasColumnName("preisHeissgetraenkePrivat");

                entity.Property(e => e.PreisKaltgetraenkePrivat).HasColumnName("preisKaltgetraenkePrivat");

                entity.Property(e => e.PreisMittagPrivat).HasColumnName("preisMittagPrivat");

                entity.Property(e => e.PreisZwischenmahlzeitPrivat).HasColumnName("preisZwischenmahlzeitPrivat");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.CateringAllgemeins)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CateringAllgemein_Kalkulation1");
            });

            modelBuilder.Entity<CateringArbeitsschritte>(entity =>
            {
                entity.ToTable("CateringArbeitsschritte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Verteilungprobkt).HasColumnName("verteilungprobkt");

                entity.Property(e => e.ZeitProStueck).HasColumnName("zeitProStueck");
            });

            modelBuilder.Entity<CateringArbeitsschritteMahlzeit>(entity =>
            {
                entity.ToTable("CateringArbeitsschritte_Mahlzeit");

                entity.HasIndex(e => new { e.CateringArbeitsschritteId, e.CateringMahlzeiteId, e.CateringEinheitenId, e.KalkulationId, e.Standard, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CateringArbeitsschritteId).HasColumnName("cateringArbeitsschritteId");

                entity.Property(e => e.CateringEinheitenId).HasColumnName("cateringEinheitenId");

                entity.Property(e => e.CateringMahlzeiteId).HasColumnName("cateringMahlzeiteId");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.Standard).HasColumnName("standard");

                entity.HasOne(d => d.CateringArbeitsschritte)
                    .WithMany(p => p.CateringArbeitsschritteMahlzeits)
                    .HasForeignKey(d => d.CateringArbeitsschritteId)
                    .HasConstraintName("FK_CateringArbeitsschritte_Mahlzeit_CateringArbeitsschritte");

                entity.HasOne(d => d.CateringEinheiten)
                    .WithMany(p => p.CateringArbeitsschritteMahlzeits)
                    .HasForeignKey(d => d.CateringEinheitenId)
                    .HasConstraintName("FK_CateringArbeitsschritte_Mahlzeit_CateringEinheiten");

                entity.HasOne(d => d.CateringMahlzeite)
                    .WithMany(p => p.CateringArbeitsschritteMahlzeits)
                    .HasForeignKey(d => d.CateringMahlzeiteId)
                    .HasConstraintName("FK_CateringArbeitsschritte_Mahlzeit_CateringMahlzeit");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.CateringArbeitsschritteMahlzeits)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_CateringArbeitsschritte_Mahlzeit_Kalkulation");
            });

            modelBuilder.Entity<CateringEinheiten>(entity =>
            {
                entity.ToTable("CateringEinheiten");

                entity.HasIndex(e => e.KalkulationId, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dienstag).HasColumnName("dienstag");

                entity.Property(e => e.Donnerstag).HasColumnName("donnerstag");

                entity.Property(e => e.Feiertags).HasColumnName("feiertags");

                entity.Property(e => e.Freitag).HasColumnName("freitag");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.Mittwoch).HasColumnName("mittwoch");

                entity.Property(e => e.Montag).HasColumnName("montag");

                entity.Property(e => e.Samstag).HasColumnName("samstag");

                entity.Property(e => e.Sonntag).HasColumnName("sonntag");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.CateringEinheitens)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_CateringEinheiten_Kalkulation");
            });

            modelBuilder.Entity<CateringMahlzeit>(entity =>
            {
                entity.ToTable("CateringMahlzeit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Gewichtung).HasColumnName("gewichtung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Standard).HasColumnName("standard");
            });

            modelBuilder.Entity<CateringProduktivzeiten>(entity =>
            {
                entity.ToTable("CateringProduktivzeiten");

                entity.HasIndex(e => new { e.CateringArbeitsschritteMahlzeitId, e.KalkulationId, e.CateringEinheitenId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CateringArbeitsschritteMahlzeitId).HasColumnName("cateringArbeitsschritte_Mahlzeit_Id");

                entity.Property(e => e.CateringEinheitenId).HasColumnName("cateringEinheitenId");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.ZeitProStueck).HasColumnName("zeitProStueck");

                entity.HasOne(d => d.CateringArbeitsschritteMahlzeit)
                    .WithMany(p => p.CateringProduktivzeitens)
                    .HasForeignKey(d => d.CateringArbeitsschritteMahlzeitId)
                    .HasConstraintName("FK_CateringProduktivzeiten_CateringArbeitsschritte_Mahlzeit");

                entity.HasOne(d => d.CateringEinheiten)
                    .WithMany(p => p.CateringProduktivzeitens)
                    .HasForeignKey(d => d.CateringEinheitenId)
                    .HasConstraintName("FK_CateringProduktivzeiten_CateringEinheiten");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.CateringProduktivzeitens)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_CateringProduktivzeiten_Kalkulation");
            });

            modelBuilder.Entity<Checklisteintrag>(entity =>
            {
                entity.ToTable("Checklisteintrag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.ChecklisteintragArtId).HasColumnName("checklisteintragArt_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.ChecklisteintragArt)
                    .WithMany(p => p.Checklisteintrags)
                    .HasForeignKey(d => d.ChecklisteintragArtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checklisteintrag_ChecklisteintragArt");
            });

            modelBuilder.Entity<ChecklisteintragArt>(entity =>
            {
                entity.ToTable("ChecklisteintragArt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ChecklisteneintragVeranstaltung>(entity =>
            {
                entity.ToTable("Checklisteneintrag_Veranstaltung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChecklisteneintragId).HasColumnName("checklisteneintrag_id");

                entity.Property(e => e.IstChecked).HasColumnName("istChecked");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.VeranstaltungId).HasColumnName("veranstaltung_id");

                entity.HasOne(d => d.Checklisteneintrag)
                    .WithMany(p => p.ChecklisteneintragVeranstaltungs)
                    .HasForeignKey(d => d.ChecklisteneintragId)
                    .HasConstraintName("FK_Checklisteneintrag_Veranstaltung_Checklisteintrag");

                entity.HasOne(d => d.Veranstaltung)
                    .WithMany(p => p.ChecklisteneintragVeranstaltungs)
                    .HasForeignKey(d => d.VeranstaltungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checklisteneintrag_Veranstaltung_Veranstaltung");
            });

            modelBuilder.Entity<Darlehen>(entity =>
            {
                entity.ToTable("Darlehen");

                entity.HasIndex(e => new { e.FinanzplanungId, e.KostenstelleId, e.SachkontoId, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbgrenzungTilgung).HasColumnName("abgrenzungTilgung");

                entity.Property(e => e.AbgrenzungZinsen).HasColumnName("abgrenzungZinsen");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DarlehenWurdeVergeben).HasColumnName("darlehenWurdeVergeben");

                entity.Property(e => e.DarlehenshoeheAnfangJahr).HasColumnName("darlehenshoeheAnfangJahr");

                entity.Property(e => e.DarlehentypId).HasColumnName("darlehentyp_id");

                entity.Property(e => e.FinanzplanungId).HasColumnName("finanzplanungId");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.Kredithoehe).HasColumnName("kredithoehe");

                entity.Property(e => e.Laufzeit).HasColumnName("laufzeit");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.SachkontoAbgrenzungTilung).HasColumnName("sachkonto_abgrenzungTilung");

                entity.Property(e => e.SachkontoAbgrenzungZinsen).HasColumnName("sachkonto_abgrenzungZinsen");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.Property(e => e.Startdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("startdatum");

                entity.Property(e => e.Tilgung).HasColumnName("tilgung");

                entity.Property(e => e.Tilgung01).HasColumnName("tilgung01");

                entity.Property(e => e.Tilgung02).HasColumnName("tilgung02");

                entity.Property(e => e.Tilgung03).HasColumnName("tilgung03");

                entity.Property(e => e.Tilgung04).HasColumnName("tilgung04");

                entity.Property(e => e.Tilgung05).HasColumnName("tilgung05");

                entity.Property(e => e.Tilgung06).HasColumnName("tilgung06");

                entity.Property(e => e.Tilgung07).HasColumnName("tilgung07");

                entity.Property(e => e.Tilgung08).HasColumnName("tilgung08");

                entity.Property(e => e.Tilgung09).HasColumnName("tilgung09");

                entity.Property(e => e.Tilgung10).HasColumnName("tilgung10");

                entity.Property(e => e.Tilgung11).HasColumnName("tilgung11");

                entity.Property(e => e.Tilgung12).HasColumnName("tilgung12");

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Zinsen01).HasColumnName("zinsen01");

                entity.Property(e => e.Zinsen02).HasColumnName("zinsen02");

                entity.Property(e => e.Zinsen03).HasColumnName("zinsen03");

                entity.Property(e => e.Zinsen04).HasColumnName("zinsen04");

                entity.Property(e => e.Zinsen05).HasColumnName("zinsen05");

                entity.Property(e => e.Zinsen06).HasColumnName("zinsen06");

                entity.Property(e => e.Zinsen07).HasColumnName("zinsen07");

                entity.Property(e => e.Zinsen08).HasColumnName("zinsen08");

                entity.Property(e => e.Zinsen09).HasColumnName("zinsen09");

                entity.Property(e => e.Zinsen10).HasColumnName("zinsen10");

                entity.Property(e => e.Zinsen11).HasColumnName("zinsen11");

                entity.Property(e => e.Zinsen12).HasColumnName("zinsen12");

                entity.Property(e => e.Zinssatz).HasColumnName("zinssatz");

                entity.HasOne(d => d.Darlehentyp)
                    .WithMany(p => p.Darlehens)
                    .HasForeignKey(d => d.DarlehentypId)
                    .HasConstraintName("FK_Darlehen_DarlehenTypen");

                entity.HasOne(d => d.Finanzplanung)
                    .WithMany(p => p.Darlehens)
                    .HasForeignKey(d => d.FinanzplanungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Darlehen_Finanzplanung");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Darlehens)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Darlehen_Kostenstelle");

                entity.HasOne(d => d.SachkontoAbgrenzungTilungNavigation)
                    .WithMany(p => p.DarlehenSachkontoAbgrenzungTilungNavigations)
                    .HasForeignKey(d => d.SachkontoAbgrenzungTilung)
                    .HasConstraintName("FK_Darlehen_SachkontoAbTilgung");

                entity.HasOne(d => d.SachkontoAbgrenzungZinsenNavigation)
                    .WithMany(p => p.DarlehenSachkontoAbgrenzungZinsenNavigations)
                    .HasForeignKey(d => d.SachkontoAbgrenzungZinsen)
                    .HasConstraintName("FK_Darlehen_SachkontoAbZinsen");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.DarlehenSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_Darlehen_Sachkonto");
            });

            modelBuilder.Entity<DarlehenTypen>(entity =>
            {
                entity.ToTable("DarlehenTypen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbgrenzungtilgungId).HasColumnName("abgrenzungtilgung_id");

                entity.Property(e => e.AbgrenzungzinsenId).HasColumnName("abgrenzungzinsen_id");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.PlanbilanzgegenkontoId).HasColumnName("planbilanzgegenkonto_id");

                entity.Property(e => e.PlanbilanzkontoId).HasColumnName("planbilanzkonto_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.HasOne(d => d.Abgrenzungtilgung)
                    .WithMany(p => p.DarlehenTypenAbgrenzungtilgungs)
                    .HasForeignKey(d => d.AbgrenzungtilgungId)
                    .HasConstraintName("FK_DarlehenTypen_Sachkonto");

                entity.HasOne(d => d.Abgrenzungzinsen)
                    .WithMany(p => p.DarlehenTypenAbgrenzungzinsens)
                    .HasForeignKey(d => d.AbgrenzungzinsenId)
                    .HasConstraintName("FK_DarlehenTypen_Sachkonto1");

                entity.HasOne(d => d.Planbilanzgegenkonto)
                    .WithMany(p => p.DarlehenTypenPlanbilanzgegenkontos)
                    .HasForeignKey(d => d.PlanbilanzgegenkontoId)
                    .HasConstraintName("FK_DarlehenTypen_Planbilanzgegenkonto");

                entity.HasOne(d => d.Planbilanzkonto)
                    .WithMany(p => p.DarlehenTypenPlanbilanzkontos)
                    .HasForeignKey(d => d.PlanbilanzkontoId)
                    .HasConstraintName("FK_DarlehenTypen_Planbilanzkonten");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.DarlehenTypenSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_DarlehenTypen_Sachkonto2");
            });

            modelBuilder.Entity<DarlehenZusatztilgung>(entity =>
            {
                entity.ToTable("DarlehenZusatztilgung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.DarlehenId).HasColumnName("darlehenId");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Enddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("enddatum");

                entity.HasOne(d => d.Darlehen)
                    .WithMany(p => p.DarlehenZusatztilgungs)
                    .HasForeignKey(d => d.DarlehenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DarlehenZusatztilgung_Darlehen");
            });

            modelBuilder.Entity<Datei>(entity =>
            {
                entity.ToTable("Datei");

                entity.HasIndex(e => new { e.BenutzerId, e.DateiartId, e.IstVeroeffentlicht, e.KannVeroeffentlichtWerden, e.OeffentlichBis, e.NameHash }, "WeitereInd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.DateiAuthor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateiAuthor");

                entity.Property(e => e.DateiartId).HasColumnName("dateiart_id");

                entity.Property(e => e.Dateierweiterung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateierweiterung");

                entity.Property(e => e.Dateigroesse).HasColumnName("dateigroesse");

                entity.Property(e => e.Dateiinhalt)
                    .HasColumnType("image")
                    .HasColumnName("dateiinhalt");

                entity.Property(e => e.Dateiname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateiname");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.KannVeroeffentlichtWerden).HasColumnName("kannVeroeffentlichtWerden");

                entity.Property(e => e.NameHash)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nameHash");

                entity.Property(e => e.OeffentlichBis)
                    .HasColumnType("datetime")
                    .HasColumnName("oeffentlichBis");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Dateis)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Datei_Benutzer");

                entity.HasOne(d => d.Dateiart)
                    .WithMany(p => p.Dateis)
                    .HasForeignKey(d => d.DateiartId)
                    .HasConstraintName("FK_Datei_Dateiart");
            });

            modelBuilder.Entity<Dateiart>(entity =>
            {
                entity.ToTable("Dateiart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Dateiverknuepfung>(entity =>
            {
                entity.ToTable("Dateiverknuepfung");

                entity.HasIndex(e => new { e.DateiId, e.Verknuepfungsklasse, e.VerknuepfungsklassenId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateiId).HasColumnName("datei_id");

                entity.Property(e => e.Verknuepfungsklasse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("verknuepfungsklasse");

                entity.Property(e => e.VerknuepfungsklassenId).HasColumnName("verknuepfungsklassenId");

                entity.HasOne(d => d.Datei)
                    .WithMany(p => p.Dateiverknuepfungs)
                    .HasForeignKey(d => d.DateiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dateiverknuepfung_Datei");
            });

            modelBuilder.Entity<Dateivorlage>(entity =>
            {
                entity.ToTable("Dateivorlage");

                entity.HasIndex(e => e.Vorlagenartid, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Benutzerid).HasColumnName("benutzerid");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Datei)
                    .HasColumnType("image")
                    .HasColumnName("datei");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Typ)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("typ");

                entity.Property(e => e.Vorlagenartid).HasColumnName("vorlagenartid");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Dateivorlages)
                    .HasForeignKey(d => d.Benutzerid)
                    .HasConstraintName("FK_Dateivorlage_Benutzer");

                entity.HasOne(d => d.Vorlagenart)
                    .WithMany(p => p.Dateivorlages)
                    .HasForeignKey(d => d.Vorlagenartid)
                    .HasConstraintName("FK_Dateivorlage_Vorlagenart");
            });

            modelBuilder.Entity<Datenbankverbindungen>(entity =>
            {
                entity.ToTable("Datenbankverbindungen");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Assemblyname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assemblyname");

                entity.Property(e => e.Datenbankname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("datenbankname");

                entity.Property(e => e.Datenbankserver)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("datenbankserver");

                entity.Property(e => e.Datenbankzugangsdaten)
                    .IsUnicode(false)
                    .HasColumnName("datenbankzugangsdaten");
            });

            modelBuilder.Entity<DefaultCateringTageImJahr>(entity =>
            {
                entity.ToTable("DefaultCateringTageImJahr");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<DefaultCateringTageImJahrFeiertage>(entity =>
            {
                entity.ToTable("DefaultCateringTageImJahrFeiertage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.DefaultCateringTageImJahrId).HasColumnName("defaultCateringTageImJahr_id");

                entity.Property(e => e.Jahr)
                    .HasColumnType("datetime")
                    .HasColumnName("jahr");

                entity.HasOne(d => d.DefaultCateringTageImJahr)
                    .WithMany(p => p.DefaultCateringTageImJahrFeiertages)
                    .HasForeignKey(d => d.DefaultCateringTageImJahrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DefaultCateringTageImJahrFeiertage_DefaultCateringTageImJahr");
            });

            modelBuilder.Entity<DefaultNettokosten>(entity =>
            {
                entity.ToTable("DefaultNettokosten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OperMgmtAufschlagProzent).HasColumnName("operMgmtAufschlagProzent");

                entity.Property(e => e.RisikoGewinnProzent).HasColumnName("risikoGewinnProzent");

                entity.Property(e => e.VerwaltungsProzent).HasColumnName("verwaltungsProzent");
            });

            modelBuilder.Entity<DefaultVertretungspersonal>(entity =>
            {
                entity.ToTable("DefaultVertretungspersonal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Krankheit).HasColumnName("krankheit");

                entity.Property(e => e.Urlaub).HasColumnName("urlaub");
            });

            modelBuilder.Entity<DiamantExport>(entity =>
            {
                entity.ToTable("DiamantExport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.ExportDatum)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDatum");

                entity.Property(e => e.GeloeschtDatum)
                    .HasColumnType("datetime")
                    .HasColumnName("geloeschtDatum");

                entity.Property(e => e.IstVerarbeitet).HasColumnName("istVerarbeitet");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.Planalternative)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("planalternative")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SchnittstellenartId).HasColumnName("schnittstellenart_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.DiamantExports)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiamantExport_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.DiamantExports)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_DiamantExport_Betriebsstaette");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.DiamantExports)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_DiamantExport_Kalkulation");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.DiamantExports)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .HasConstraintName("FK_DiamantExport_Konsolidierung");

                entity.HasOne(d => d.Schnittstellenart)
                    .WithMany(p => p.DiamantExports)
                    .HasForeignKey(d => d.SchnittstellenartId)
                    .HasConstraintName("FK_DiamantExport_Schnittstellenart");
            });

            modelBuilder.Entity<DiamantExportDatensatz>(entity =>
            {
                entity.ToTable("DiamantExportDatensatz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Betriebskalender)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("betriebskalender");

                entity.Property(e => e.Buchungsperiode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("buchungsperiode");

                entity.Property(e => e.DiamantexportId).HasColumnName("diamantexportId");

                entity.Property(e => e.Istgeloescht).HasColumnName("istgeloescht");

                entity.Property(e => e.Istverarbeitet).HasColumnName("istverarbeitet");

                entity.Property(e => e.Kostenart).HasColumnName("kostenart");

                entity.Property(e => e.Kostenfix).HasColumnName("kostenfix");

                entity.Property(e => e.Kostenstelle).HasColumnName("kostenstelle");

                entity.Property(e => e.Kostenvariable).HasColumnName("kostenvariable");

                entity.Property(e => e.Lfdnr).HasColumnName("lfdnr");

                entity.Property(e => e.Planalternative)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("planalternative");

                entity.Property(e => e.Refnr)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("refnr");

                entity.Property(e => e.Sachkonto).HasColumnName("sachkonto");

                entity.Property(e => e.Satzart)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("satzart");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Vkz)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("vkz");

                entity.Property(e => e.Wertschreibeart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("wertschreibeart");

                entity.Property(e => e.Zielsatzart)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("zielsatzart");

                entity.HasOne(d => d.Diamantexport)
                    .WithMany(p => p.DiamantExportDatensatzs)
                    .HasForeignKey(d => d.DiamantexportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_diamantExportDatensatz_DiamantExport");
            });

            modelBuilder.Entity<Dienst>(entity =>
            {
                entity.ToTable("Dienst");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Klasse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("klasse");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DienstKonfiguration>(entity =>
            {
                entity.ToTable("DienstKonfiguration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DienstId).HasColumnName("dienst_id");

                entity.Property(e => e.Eintrag)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eintrag");

                entity.Property(e => e.Eintragswert)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eintragswert");

                entity.HasOne(d => d.Dienst)
                    .WithMany(p => p.DienstKonfigurations)
                    .HasForeignKey(d => d.DienstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DienstKonfiguration_Dienst");
            });

            modelBuilder.Entity<Dinnorm>(entity =>
            {
                entity.ToTable("DINNorm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Einheit>(entity =>
            {
                entity.ToTable("Einheit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("symbol");

                entity.Property(e => e.UmrechnungsfaktorZuVater).HasColumnName("umrechnungsfaktorZuVater");

                entity.Property(e => e.VaterEinheitId).HasColumnName("vaterEinheit_id");

                entity.HasOne(d => d.VaterEinheit)
                    .WithMany(p => p.InverseVaterEinheit)
                    .HasForeignKey(d => d.VaterEinheitId)
                    .HasConstraintName("FK_Einheit_Einheit");
            });

            modelBuilder.Entity<Einrichtungskapazitaet>(entity =>
            {
                entity.ToTable("Einrichtungskapazitaet");

                entity.HasIndex(e => new { e.BetriebsstaetteId, e.GueltigVon, e.GueltigBis }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnzKurzzeitpflegeEinz).HasColumnName("anzKurzzeitpflegeEinz");

                entity.Property(e => e.AnzVollstationaerEinz).HasColumnName("anzVollstationaerEinz");

                entity.Property(e => e.AnzahlKurzzeitpflege).HasColumnName("anzahlKurzzeitpflege");

                entity.Property(e => e.AnzahlTeilstationaer).HasColumnName("anzahlTeilstationaer");

                entity.Property(e => e.AnzahlVollstationaer).HasColumnName("anzahlVollstationaer");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Einrichtungskapazitaets)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Einrichtungskapazitaet_Betriebsstaette");
            });

            modelBuilder.Entity<Einstellungen>(entity =>
            {
                entity.ToTable("Einstellungen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzeDynamischeFortschrittsanzeige).HasColumnName("benutzeDynamischeFortschrittsanzeige");

                entity.Property(e => e.ClientMindestVersion).HasColumnName("clientMindestVersion");

                entity.Property(e => e.DarlehenImBudgetPlanen).HasColumnName("darlehenImBudgetPlanen");

                entity.Property(e => e.FehlerberichtEmpfaenger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fehlerberichtEmpfaenger");

                entity.Property(e => e.FehlerberichtMitScreenshot)
                    .IsRequired()
                    .HasColumnName("fehlerberichtMitScreenshot")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FehlerberichtPort)
                    .HasColumnName("fehlerberichtPort")
                    .HasDefaultValueSql("((587))");

                entity.Property(e => e.FehlerberichtSendenMoeglich)
                    .IsRequired()
                    .HasColumnName("fehlerberichtSendenMoeglich")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IstPasswortdialogEingeschaltet)
                    .IsRequired()
                    .HasColumnName("istPasswortdialogEingeschaltet")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LogKalkulationsaenderungenAktiv).HasColumnName("logKalkulationsaenderungenAktiv");

                entity.Property(e => e.NameEinrichtungsverwaltung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nameEinrichtungsverwaltung")
                    .HasDefaultValueSql("('Einrichtungsverwaltung')");

                entity.Property(e => e.Planungsjahr)
                    .HasColumnName("planungsjahr")
                    .HasDefaultValueSql("((2020))");

                entity.Property(e => e.Wartungszustand).HasColumnName("wartungszustand");
            });

            modelBuilder.Entity<Ergebnisbewertung>(entity =>
            {
                entity.ToTable("Ergebnisbewertung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.EnumKennzahlFarbe).HasColumnName("enumKennzahlFarbe");

                entity.Property(e => e.KennzahlId).HasColumnName("kennzahl_id");

                entity.Property(e => e.WertBis).HasColumnName("wertBis");

                entity.Property(e => e.WertVon).HasColumnName("wertVon");

                entity.HasOne(d => d.Kennzahl)
                    .WithMany(p => p.Ergebnisbewertungs)
                    .HasForeignKey(d => d.KennzahlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ergebnisbewertung_Kennzahl");
            });

            modelBuilder.Entity<Erloesplanungszeile>(entity =>
            {
                entity.ToTable("Erloesplanungszeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.April).HasColumnName("april");

                entity.Property(e => e.August).HasColumnName("august");

                entity.Property(e => e.Bemerkung)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dezember).HasColumnName("dezember");

                entity.Property(e => e.Februar).HasColumnName("februar");

                entity.Property(e => e.Identifizierungsschluessel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identifizierungsschluessel");

                entity.Property(e => e.Januar).HasColumnName("januar");

                entity.Property(e => e.Juli).HasColumnName("juli");

                entity.Property(e => e.Juni).HasColumnName("juni");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.KampagneId).HasColumnName("kampagne_id");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.Maerz).HasColumnName("maerz");

                entity.Property(e => e.Mai).HasColumnName("mai");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.November).HasColumnName("november");

                entity.Property(e => e.Oktober).HasColumnName("oktober");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.Property(e => e.September).HasColumnName("september");

                entity.Property(e => e.Ursprungsklasse)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ursprungsklasse");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Erloesplanungszeiles)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Erloesplanungszeile_Kalkulation");

                entity.HasOne(d => d.Kampagne)
                    .WithMany(p => p.Erloesplanungszeiles)
                    .HasForeignKey(d => d.KampagneId)
                    .HasConstraintName("FK_Erloesplanungszeile_kampagne");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Erloesplanungszeiles)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Erloesplanungszeile_Kostenstelle");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.Erloesplanungszeiles)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_Erloesplanungszeile_Sachkonto");
            });

            modelBuilder.Entity<FaktorenPvist>(entity =>
            {
                entity.ToTable("FaktorenPVIst");

                entity.HasIndex(e => new { e.BetriebsstaetteId, e.PersonalfaktorId, e.GueltigBis, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Faktor).HasColumnName("faktor");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.InKalkulationEnthalten).HasColumnName("inKalkulationEnthalten");

                entity.Property(e => e.PersonalfaktorId).HasColumnName("personalfaktorId");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.FaktorenPvists)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaktorenPVIst_Betriebsstaette");

                entity.HasOne(d => d.Personalfaktor)
                    .WithMany(p => p.FaktorenPvists)
                    .HasForeignKey(d => d.PersonalfaktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaktorenPVIst_Personalfaktor");
            });

            modelBuilder.Entity<FaktorenPvsoll>(entity =>
            {
                entity.ToTable("FaktorenPVSoll");

                entity.HasIndex(e => new { e.BetriebsstaetteId, e.AuslastungsartId, e.GueltigBis, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsart_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.Nachtwachepauschal).HasColumnName("nachtwachepauschal");

                entity.Property(e => e.Nachtwacheverprobung).HasColumnName("nachtwacheverprobung");

                entity.Property(e => e.Pflegestufe0).HasColumnName("pflegestufe0");

                entity.Property(e => e.Pflegestufe1).HasColumnName("pflegestufe1");

                entity.Property(e => e.Pflegestufe2).HasColumnName("pflegestufe2");

                entity.Property(e => e.Pflegestufe3).HasColumnName("pflegestufe3");

                entity.Property(e => e.Pflegestufe3p).HasColumnName("pflegestufe3p");

                entity.Property(e => e.Psg2Zuschlag).HasColumnName("psg2Zuschlag");

                entity.HasOne(d => d.Auslastungsart)
                    .WithMany(p => p.FaktorenPvsolls)
                    .HasForeignKey(d => d.AuslastungsartId)
                    .HasConstraintName("FK_FaktorenPVSoll_Auslastungsart");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.FaktorenPvsolls)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaktorenPVSoll_Betriebsstaette");
            });

            modelBuilder.Entity<Finanzinstitut>(entity =>
            {
                entity.ToTable("Finanzinstitut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Blz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("blz");

                entity.Property(e => e.Iban)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("iban");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Finanzplanung>(entity =>
            {
                entity.ToTable("Finanzplanung");

                entity.HasIndex(e => new { e.KalkulationId, e.Aktiv }, "IDX_Finanzplanung_Kalkulation");

                entity.HasIndex(e => new { e.BetriebsstaetteId, e.KalkulationId, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnfangsKontostandLiqPl).HasColumnName("anfangsKontostandLiqPl");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Finanzplanungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Finanzplanung_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Finanzplanungs)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Finanzplanung_Betriebsstaette");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Finanzplanungs)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_Finanzplanung_Kalkulation");
            });

            modelBuilder.Entity<FortschrittsanzeigeKategorie>(entity =>
            {
                entity.ToTable("Fortschrittsanzeige_Kategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Autosumme)
                    .IsRequired()
                    .HasColumnName("autosumme")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BasisFuerProzent).HasColumnName("basisFuerProzent");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.FuerCat).HasColumnName("fuerCAT");

                entity.Property(e => e.Sort).HasColumnName("sort");
            });

            modelBuilder.Entity<FortschrittsanzeigeKategorieSachkonto>(entity =>
            {
                entity.ToTable("Fortschrittsanzeige_Kategorie_Sachkonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FortschrittsanzeigeKategorieId).HasColumnName("fortschrittsanzeige_kategorie_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.HasOne(d => d.FortschrittsanzeigeKategorie)
                    .WithMany(p => p.FortschrittsanzeigeKategorieSachkontos)
                    .HasForeignKey(d => d.FortschrittsanzeigeKategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fortschrittsanzeige_Kategorie_Sachkonto_Fortschrittsanzeige_Kategorie");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.FortschrittsanzeigeKategorieSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fortschrittsanzeige_Kategorie_Sachkonto_Sachkonto");
            });

            modelBuilder.Entity<FtpZugangsdaten>(entity =>
            {
                entity.ToTable("FtpZugangsdaten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateiname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dateiname");

                entity.Property(e => e.FtpBenutzer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ftpBenutzer");

                entity.Property(e => e.FtpOrdner)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ftpOrdner");

                entity.Property(e => e.FtpPasswort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ftpPasswort");

                entity.Property(e => e.FtpServer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ftpServer");
            });

            modelBuilder.Entity<GrenzwerteFuerPersonalplanung>(entity =>
            {
                entity.ToTable("GrenzwerteFuerPersonalplanung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Maximum).HasColumnName("maximum");

                entity.Property(e => e.MaximumProzent).HasColumnName("maximum_prozent");

                entity.Property(e => e.Minimum).HasColumnName("minimum");

                entity.Property(e => e.MinimumProzent).HasColumnName("minimumProzent");
            });

            modelBuilder.Entity<Gruppe>(entity =>
            {
                entity.ToTable("Gruppe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RechteId).HasColumnName("rechte_id");

                entity.Property(e => e.RegionalleitungId).HasColumnName("regionalleitung_id");

                entity.HasOne(d => d.Rechte)
                    .WithMany(p => p.Gruppes)
                    .HasForeignKey(d => d.RechteId)
                    .HasConstraintName("FK_Gruppe_Rechte");

                entity.HasOne(d => d.Regionalleitung)
                    .WithMany(p => p.Gruppes)
                    .HasForeignKey(d => d.RegionalleitungId)
                    .HasConstraintName("FK_Gruppe_Regionalleitung");
            });

            modelBuilder.Entity<GuvSummenzeile>(entity =>
            {
                entity.ToTable("GuvSummenzeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HinterSachkontengruppeId).HasColumnName("hinterSachkontengruppeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");

                entity.HasOne(d => d.HinterSachkontengruppe)
                    .WithMany(p => p.GuvSummenzeiles)
                    .HasForeignKey(d => d.HinterSachkontengruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuvSummenzeile_Sachkontengruppe");
            });

            modelBuilder.Entity<GwgVorgabewerte>(entity =>
            {
                entity.ToTable("GwgVorgabewerte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.GwgBetrag).HasColumnName("gwgBetrag");

                entity.Property(e => e.GwgWert).HasColumnName("gwgWert");
            });

            modelBuilder.Entity<ImportHochrechnung>(entity =>
            {
                entity.ToTable("ImportHochrechnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hochrechnung).HasColumnName("hochrechnung");

                entity.Property(e => e.ImportDatum)
                    .HasColumnType("datetime")
                    .HasColumnName("import_datum");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.ImportHochrechnungs)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_ImportHochrechnung_Kalkulation");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.ImportHochrechnungs)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_ImportHochrechnung_Sachkonto");
            });

            modelBuilder.Entity<ImportLog>(entity =>
            {
                entity.ToTable("ImportLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnzahlDatensaetze).HasColumnName("anzahlDatensaetze");

                entity.Property(e => e.AnzahlFehler).HasColumnName("anzahlFehler");

                entity.Property(e => e.AnzahlGeaenderteDatensaetze).HasColumnName("anzahlGeaenderteDatensaetze");

                entity.Property(e => e.AnzahlGeloeschteDatensaetze).HasColumnName("anzahlGeloeschteDatensaetze");

                entity.Property(e => e.AnzahlNeueDatensaetze).HasColumnName("anzahlNeueDatensaetze");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.MailZugangsdatenId).HasColumnName("mailZugangsdaten_id");

                entity.Property(e => e.Quellautor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("quellautor");

                entity.Property(e => e.Quelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("quelldatum");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.ImportLogs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportLog_Benutzer");

                entity.HasOne(d => d.MailZugangsdaten)
                    .WithMany(p => p.ImportLogs)
                    .HasForeignKey(d => d.MailZugangsdatenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportLog_Lieferant_MailZugangsdaten");
            });

            modelBuilder.Entity<ImportSachkosten>(entity =>
            {
                entity.ToTable("ImportSachkosten");

                entity.HasIndex(e => e.KalkulationId, "IDX_ImportSachkosten_Kalkulation");

                entity.HasIndex(e => new { e.SachkontoId, e.KalkulationId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.LfdJahrBis)
                    .HasColumnType("datetime")
                    .HasColumnName("lfdJahrBis");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.Property(e => e.SummeLfdJahr).HasColumnName("summeLfdJahr");

                entity.Property(e => e.VorjahrGesamtsumme).HasColumnName("vorjahrGesamtsumme");

                entity.Property(e => e.WertApril).HasColumnName("wertApril");

                entity.Property(e => e.WertAugust).HasColumnName("wertAugust");

                entity.Property(e => e.WertDezember).HasColumnName("wertDezember");

                entity.Property(e => e.WertFebruar).HasColumnName("wertFebruar");

                entity.Property(e => e.WertJanuar).HasColumnName("wertJanuar");

                entity.Property(e => e.WertJuli).HasColumnName("wertJuli");

                entity.Property(e => e.WertJuni).HasColumnName("wertJuni");

                entity.Property(e => e.WertMaerz).HasColumnName("wertMaerz");

                entity.Property(e => e.WertMai).HasColumnName("wertMai");

                entity.Property(e => e.WertNovember).HasColumnName("wertNovember");

                entity.Property(e => e.WertOktober).HasColumnName("wertOktober");

                entity.Property(e => e.WertSeptember).HasColumnName("wertSeptember");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.ImportSachkostens)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportSachkosten_Kalkulation");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.ImportSachkostens)
                    .HasForeignKey(d => d.SachkontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportSachkosten_Sachkonto");
            });

            modelBuilder.Entity<InternesKonto>(entity =>
            {
                entity.ToTable("InternesKonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.KontoinformationId).HasColumnName("kontoinformation_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.InternesKontos)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternesKonto_Benutzer");

                entity.HasOne(d => d.Kontoinformation)
                    .WithMany(p => p.InternesKontos)
                    .HasForeignKey(d => d.KontoinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternesKonto_Kontoinformation");
            });

            modelBuilder.Entity<Inventur>(entity =>
            {
                entity.ToTable("Inventur");

                entity.HasIndex(e => e.LagerId, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.LagerId).HasColumnName("lager_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Sollinventurdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("sollinventurdatum");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Inventurs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventur_Benutzer");

                entity.HasOne(d => d.Lager)
                    .WithMany(p => p.Inventurs)
                    .HasForeignKey(d => d.LagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventur_Lager");
            });

            modelBuilder.Entity<InventurLagerArtikel>(entity =>
            {
                entity.ToTable("Inventur_Lager_Artikel");

                entity.HasIndex(e => new { e.LagerArtikelId, e.InventurId, e.InventurLagerArtikelAbweichungsgrundId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Durchschnittspreis).HasColumnName("durchschnittspreis");

                entity.Property(e => e.ErklaerungAbweichungInventur)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("erklaerungAbweichungInventur");

                entity.Property(e => e.InventurId).HasColumnName("inventurId");

                entity.Property(e => e.InventurLagerArtikelAbweichungsgrundId).HasColumnName("inventur_Lager_Artikel_Abweichungsgrund_id");

                entity.Property(e => e.Istmenge).HasColumnName("istmenge");

                entity.Property(e => e.LagerArtikelId).HasColumnName("lagerArtikel_id");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");

                entity.HasOne(d => d.Inventur)
                    .WithMany(p => p.InventurLagerArtikels)
                    .HasForeignKey(d => d.InventurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventur_Lager_Artikel_Inventur_Lager_Artikel");

                entity.HasOne(d => d.InventurLagerArtikelAbweichungsgrund)
                    .WithMany(p => p.InventurLagerArtikels)
                    .HasForeignKey(d => d.InventurLagerArtikelAbweichungsgrundId)
                    .HasConstraintName("FK_Inventur_Lager_Artikel_Inventur_Lager_Artikel_Abweichungsgrund");

                entity.HasOne(d => d.LagerArtikel)
                    .WithMany(p => p.InventurLagerArtikels)
                    .HasForeignKey(d => d.LagerArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventur_Lager_Artikel_Lager_Artikel");
            });

            modelBuilder.Entity<InventurLagerArtikelAbweichungsgrund>(entity =>
            {
                entity.ToTable("Inventur_Lager_Artikel_Abweichungsgrund");

                entity.HasIndex(e => e.Aktiv, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Kalkulation>(entity =>
            {
                entity.ToTable("Kalkulation");

                entity.HasIndex(e => new { e.Deaktiviert, e.Aktiv }, "KalkulationAktivDeaktiv");

                entity.HasIndex(e => new { e.KostenstellenId, e.BetriebsstaetteId, e.KalkulationsartId, e.Deaktiviert, e.Aktiv, e.IstAbgeschlossen }, "Wichtiges");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AnzahlBetten).HasColumnName("anzahlBetten");

                entity.Property(e => e.Beitragsfuss).HasColumnName("beitragsfuss");

                entity.Property(e => e.BeitragsfussFreibetrag).HasColumnName("beitragsfussFreibetrag");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.BgSachkontoId).HasColumnName("bgSachkonto_id");

                entity.Property(e => e.Deaktiviert).HasColumnName("deaktiviert");

                entity.Property(e => e.ErloeseAutomBerechnet).HasColumnName("erloeseAutomBerechnet");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Freibetrag).HasColumnName("freibetrag");

                entity.Property(e => e.Gefahrenklasse).HasColumnName("gefahrenklasse");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.IstAngebot).HasColumnName("istAngebot");

                entity.Property(e => e.IstDatenImportPruefsumme).HasColumnName("istDatenImportPruefsumme");

                entity.Property(e => e.IstKalkulationZurKonsolidierungFreigegeben).HasColumnName("istKalkulationZurKonsolidierungFreigegeben");

                entity.Property(e => e.IstMfp).HasColumnName("istMFP");

                entity.Property(e => e.KalkGewerbesteuer).HasColumnName("kalkGewerbesteuer");

                entity.Property(e => e.KalkKoerperschaftssteuer).HasColumnName("kalkKoerperschaftssteuer");

                entity.Property(e => e.KalkOperativesMgmt).HasColumnName("kalkOperativesMgmt");

                entity.Property(e => e.KalkVerwaltungspauschale).HasColumnName("kalkVerwaltungspauschale");

                entity.Property(e => e.KalkulationsartId).HasColumnName("kalkulationsartId");

                entity.Property(e => e.KalkulatorischeEndsummeMitAufschlaegen).HasColumnName("kalkulatorischeEndsummeMitAufschlaegen");

                entity.Property(e => e.KostenstellenId).HasColumnName("kostenstellenId");

                entity.Property(e => e.MietertraegeRenovierung).HasColumnName("mietertraegeRenovierung");

                entity.Property(e => e.MietertraegeUnternehmen).HasColumnName("mietertraegeUnternehmen");

                entity.Property(e => e.Nachricht)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("nachricht");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OperativesMgmtProzent).HasColumnName("operativesMgmtProzent");

                entity.Property(e => e.PlanungBis)
                    .HasColumnType("datetime")
                    .HasColumnName("planungBis");

                entity.Property(e => e.PlanungVon)
                    .HasColumnType("datetime")
                    .HasColumnName("planungVon");

                entity.Property(e => e.RisikoGewinnProzent).HasColumnName("risikoGewinnProzent");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StundenVerrechnungssatz).HasColumnName("stundenVerrechnungssatz");

                entity.Property(e => e.UrsprungsbudgetId).HasColumnName("ursprungsbudgetId");

                entity.Property(e => e.VerwaltungsProzent).HasColumnName("verwaltungsProzent");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Kalkulations)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Kalkulations)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Kalkulation_Betriebsstaette");

                entity.HasOne(d => d.BgSachkonto)
                    .WithMany(p => p.Kalkulations)
                    .HasForeignKey(d => d.BgSachkontoId)
                    .HasConstraintName("FK_Kalkulation_Sachkonto");

                entity.HasOne(d => d.Kalkulationsart)
                    .WithMany(p => p.Kalkulations)
                    .HasForeignKey(d => d.KalkulationsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Kalkulationsart");

                entity.HasOne(d => d.Kostenstellen)
                    .WithMany(p => p.Kalkulations)
                    .HasForeignKey(d => d.KostenstellenId)
                    .HasConstraintName("FK_Kalkulation_Kostenstelle");

                entity.HasOne(d => d.Ursprungsbudget)
                    .WithMany(p => p.InverseUrsprungsbudget)
                    .HasForeignKey(d => d.UrsprungsbudgetId)
                    .HasConstraintName("FK_Kalkulation_Kalkulation");
            });

            modelBuilder.Entity<KalkulationAngebot>(entity =>
            {
                entity.ToTable("Kalkulation_Angebot");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.HasOne(d => d.Angebot)
                    .WithMany(p => p.KalkulationAngebots)
                    .HasForeignKey(d => d.AngebotId)
                    .HasConstraintName("FK_Kalkulation_Angebot_Angebot");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.KalkulationAngebots)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_Kalkulation_Angebot_Kalkulation");
            });

            modelBuilder.Entity<KalkulationArtikel>(entity =>
            {
                entity.ToTable("Kalkulation_Artikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.AnzahlMonate).HasColumnName("anzahlMonate");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.AufwandId).HasColumnName("aufwand_id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.Kaufdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("kaufdatum");

                entity.Property(e => e.Preis).HasColumnName("preis");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.KalkulationArtikels)
                    .HasForeignKey(d => d.ArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Artikel_Artikel");

                entity.HasOne(d => d.Aufwand)
                    .WithMany(p => p.KalkulationArtikels)
                    .HasForeignKey(d => d.AufwandId)
                    .HasConstraintName("FK_Kalkulation_Artikel_Aufwand");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.KalkulationArtikels)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Artikel_Kalkulation");
            });

            modelBuilder.Entity<KalkulationAufschlaege>(entity =>
            {
                entity.ToTable("KalkulationAufschlaege");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Endsumme).HasColumnName("endsumme");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.OperativesMgmtAufschlag).HasColumnName("operativesMgmtAufschlag");

                entity.Property(e => e.RisikoGewinnaufschlag).HasColumnName("risikoGewinnaufschlag");

                entity.Property(e => e.SummeGewerbesteuer).HasColumnName("summeGewerbesteuer");

                entity.Property(e => e.SummeKoerperschaftssteuer).HasColumnName("summeKoerperschaftssteuer");

                entity.Property(e => e.SummeVorsteuerErmaessigt).HasColumnName("summeVorsteuerErmaessigt");

                entity.Property(e => e.SummeVorsteuerVoll).HasColumnName("summeVorsteuerVoll");

                entity.Property(e => e.Verwaltungsaufschlag).HasColumnName("verwaltungsaufschlag");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.KalkulationAufschlaeges)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KalkulationAufschlaege_Kalkulation");
            });

            modelBuilder.Entity<KalkulationAuslastungsart>(entity =>
            {
                entity.ToTable("Kalkulation_Auslastungsart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbwesenheitPst0Prozent).HasColumnName("abwesenheitPst0Prozent");

                entity.Property(e => e.AbwesenheitPst1Prozent).HasColumnName("abwesenheitPst1Prozent");

                entity.Property(e => e.AbwesenheitPst2Prozent).HasColumnName("abwesenheitPst2Prozent");

                entity.Property(e => e.AbwesenheitPst3Prozent).HasColumnName("abwesenheitPst3Prozent");

                entity.Property(e => e.AbwesenheitPst3plusProzent).HasColumnName("abwesenheitPst3plusProzent");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnwesenheitPst0Prozent).HasColumnName("anwesenheitPst0Prozent");

                entity.Property(e => e.AnwesenheitPst1Prozent).HasColumnName("anwesenheitPst1Prozent");

                entity.Property(e => e.AnwesenheitPst2Prozent).HasColumnName("anwesenheitPst2Prozent");

                entity.Property(e => e.AnwesenheitPst3Prozent).HasColumnName("anwesenheitPst3Prozent");

                entity.Property(e => e.AnwesenheitPst3plusProzent).HasColumnName("anwesenheitPst3plusProzent");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsart_id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.PflegesatzId).HasColumnName("pflegesatz_id");

                entity.HasOne(d => d.Auslastungsart)
                    .WithMany(p => p.KalkulationAuslastungsarts)
                    .HasForeignKey(d => d.AuslastungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Auslastungsart_Auslastungsart");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.KalkulationAuslastungsarts)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Auslastungsart_Benutzer");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.KalkulationAuslastungsarts)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Auslastungsart_Kalkulation");

                entity.HasOne(d => d.Pflegesatz)
                    .WithMany(p => p.KalkulationAuslastungsarts)
                    .HasForeignKey(d => d.PflegesatzId)
                    .HasConstraintName("FK_Kalkulation_Auslastungsart_Pflegesaetze");
            });

            modelBuilder.Entity<KalkulationBrotkruemeldefinition>(entity =>
            {
                entity.ToTable("KalkulationBrotkruemeldefinition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EnumBerechtigungsString)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungsString");

                entity.Property(e => e.EnumBerechtigungsStringAlleLesen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungsStringAlleLesen");

                entity.Property(e => e.EnumBerechtigungsStringAlternativ)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungsStringAlternativ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EnumBerechtigungsStringRoot)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungsStringRoot");

                entity.Property(e => e.KalkulationsartId).HasColumnName("kalkulationsart_id");

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");

                entity.Property(e => e.UcType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uc_Type");

                entity.HasOne(d => d.Kalkulationsart)
                    .WithMany(p => p.KalkulationBrotkruemeldefinitions)
                    .HasForeignKey(d => d.KalkulationsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KalkulationBrotkruemeldefinition_Kalkulationsart");
            });

            modelBuilder.Entity<KalkulationKommentar>(entity =>
            {
                entity.ToTable("KalkulationKommentar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.Kommentar)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("kommentar");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.KalkulationKommentars)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_KalkulationKommentar_Benutzer");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.KalkulationKommentars)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_KalkulationKommentar_Kalkulation");
            });

            modelBuilder.Entity<KalkulationKonsolidierung>(entity =>
            {
                entity.ToTable("Kalkulation_Konsolidierung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.KalkulationKonsolidierungs)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_Kalkulation_Konsolidierung_Kalkulation");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KalkulationKonsolidierungs)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .HasConstraintName("FK_Kalkulation_Konsolidierung_Konsolidierung");
            });

            modelBuilder.Entity<KalkulationVerprobung>(entity =>
            {
                entity.ToTable("Kalkulation_Verprobung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BetriebsstaetteVerprobungsfaktorId).HasColumnName("betriebsstaette_verprobungsfaktor_id");

                entity.Property(e => e.PersonaleinsatzId).HasColumnName("personaleinsatz_id");

                entity.Property(e => e.VkwertVerprobt).HasColumnName("vkwert_verprobt");

                entity.HasOne(d => d.BetriebsstaetteVerprobungsfaktor)
                    .WithMany(p => p.KalkulationVerprobungs)
                    .HasForeignKey(d => d.BetriebsstaetteVerprobungsfaktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Verprobung_Betriebsstaette_Verprobungsfaktor");

                entity.HasOne(d => d.Personaleinsatz)
                    .WithMany(p => p.KalkulationVerprobungs)
                    .HasForeignKey(d => d.PersonaleinsatzId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulation_Verprobung_Personaleinsatz");
            });

            modelBuilder.Entity<KalkulationWohnung>(entity =>
            {
                entity.ToTable("Kalkulation_Wohnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.ErtragRenovierung).HasColumnName("ertragRenovierung");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.Kaltmiete).HasColumnName("kaltmiete");

                entity.Property(e => e.Nebenkosten).HasColumnName("nebenkosten");

                entity.Property(e => e.Pauschale1).HasColumnName("pauschale1");

                entity.Property(e => e.Pauschale2).HasColumnName("pauschale2");

                entity.Property(e => e.WohnungId).HasColumnName("wohnungId");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.KalkulationWohnungs)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_Kalkulation_Wohnung_Kalkulation");

                entity.HasOne(d => d.Wohnung)
                    .WithMany(p => p.KalkulationWohnungs)
                    .HasForeignKey(d => d.WohnungId)
                    .HasConstraintName("FK_Kalkulation_Wohnung_Wohnung");
            });

            modelBuilder.Entity<Kalkulationsart>(entity =>
            {
                entity.ToTable("Kalkulationsart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EnumBerechtigungAlleSchreiben)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungAlleSchreiben");

                entity.Property(e => e.EnumBerechtigungEntsperren)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungEntsperren");

                entity.Property(e => e.EnumBerechtigungExportieren)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungExportieren");

                entity.Property(e => e.EnumBerechtigungLesen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungLesen");

                entity.Property(e => e.EnumBerechtigungSchreiben)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungSchreiben")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.VertretungspersonalAktiv).HasColumnName("vertretungspersonalAktiv");
            });

            modelBuilder.Entity<KalkulationsartBerechtigungLesen>(entity =>
            {
                entity.ToTable("KalkulationsartBerechtigungLesen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EnumBerechtigungLesen)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("enumBerechtigungLesen");

                entity.Property(e => e.KalkulationsartId).HasColumnName("kalkulationsart_id");

                entity.HasOne(d => d.Kalkulationsart)
                    .WithMany(p => p.KalkulationsartBerechtigungLesens)
                    .HasForeignKey(d => d.KalkulationsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KalkulationsartBerechtigungLesen_Kalkulationsart");
            });

            modelBuilder.Entity<Kalkulationskennzahl>(entity =>
            {
                entity.ToTable("Kalkulationskennzahl");

                entity.HasIndex(e => e.Typ, "Kennzahl_KalkId");

                entity.HasIndex(e => new { e.KalkulationId, e.Typ }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.Typ).HasColumnName("typ");

                entity.Property(e => e.Wert).HasColumnName("wert");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Kalkulationskennzahls)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kalkulationskennzahl_Kalkulation");
            });

            modelBuilder.Entity<Kampagne>(entity =>
            {
                entity.ToTable("Kampagne");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Kampagnes)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_kampagne_Kalkulation");
            });

            modelBuilder.Entity<KampagneGruppen>(entity =>
            {
                entity.ToTable("Kampagne_Gruppen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GruppeId).HasColumnName("gruppe_id");

                entity.Property(e => e.KampagneId).HasColumnName("kampagne_id");

                entity.HasOne(d => d.Gruppe)
                    .WithMany(p => p.KampagneGruppens)
                    .HasForeignKey(d => d.GruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kampagne_Gruppen_Gruppe");

                entity.HasOne(d => d.Kampagne)
                    .WithMany(p => p.KampagneGruppens)
                    .HasForeignKey(d => d.KampagneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kampagne_Gruppen_Kampagne");
            });

            modelBuilder.Entity<Kennzahl>(entity =>
            {
                entity.ToTable("Kennzahl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Anzeigen).HasColumnName("anzeigen");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.EinheitId).HasColumnName("einheit_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstdatenMitAusgeben).HasColumnName("istdatenMitAusgeben");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Kennzahls)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Kennzahl_Benutzer");

                entity.HasOne(d => d.Einheit)
                    .WithMany(p => p.Kennzahls)
                    .HasForeignKey(d => d.EinheitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kennzahl_Einheit");
            });

            modelBuilder.Entity<KennzahlElement>(entity =>
            {
                entity.ToTable("KennzahlElement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KennzahlElementObjektId).HasColumnName("kennzahlElementObjektId");

                entity.Property(e => e.KennzahlElementTypId).HasColumnName("kennzahlElementTyp_id");

                entity.Property(e => e.KennzahlId).HasColumnName("kennzahl_id");

                entity.Property(e => e.KennzahlOperatorId).HasColumnName("kennzahlOperator_id");

                entity.Property(e => e.OberKennzahlId).HasColumnName("oberKennzahl_id");

                entity.Property(e => e.ReihenfolgeNr).HasColumnName("reihenfolgeNr");

                entity.Property(e => e.Wert).HasColumnName("wert");

                entity.HasOne(d => d.KennzahlElementTyp)
                    .WithMany(p => p.KennzahlElements)
                    .HasForeignKey(d => d.KennzahlElementTypId)
                    .HasConstraintName("FK_KennzahlElement_KennzahlElementTyp");

                entity.HasOne(d => d.Kennzahl)
                    .WithMany(p => p.KennzahlElementKennzahls)
                    .HasForeignKey(d => d.KennzahlId)
                    .HasConstraintName("FK_KennzahlElement_Kennzahl1");

                entity.HasOne(d => d.KennzahlOperator)
                    .WithMany(p => p.KennzahlElements)
                    .HasForeignKey(d => d.KennzahlOperatorId)
                    .HasConstraintName("FK_KennzahlElement_KennzahlOperator");

                entity.HasOne(d => d.OberKennzahl)
                    .WithMany(p => p.KennzahlElementOberKennzahls)
                    .HasForeignKey(d => d.OberKennzahlId)
                    .HasConstraintName("FK_KennzahlElement_Kennzahl");
            });

            modelBuilder.Entity<KennzahlElementTyp>(entity =>
            {
                entity.ToTable("KennzahlElementTyp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnzeigeEigenschaft)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anzeigeEigenschaft");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OberKennzahlElementTypId).HasColumnName("oberKennzahlElementTyp_id");

                entity.Property(e => e.SingulaerLaden).HasColumnName("singulaerLaden");

                entity.Property(e => e.WertEigenschaft)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("wertEigenschaft");

                entity.Property(e => e.WertEigenschaft2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("wertEigenschaft2");

                entity.Property(e => e.WertEigenschaft3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("wertEigenschaft3");

                entity.Property(e => e.WertMethode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("wertMethode");

                entity.HasOne(d => d.OberKennzahlElementTyp)
                    .WithMany(p => p.InverseOberKennzahlElementTyp)
                    .HasForeignKey(d => d.OberKennzahlElementTypId)
                    .HasConstraintName("FK_KennzahlElementTyp_KennzahlElementTyp1");
            });

            modelBuilder.Entity<KennzahlKennzahlenbericht>(entity =>
            {
                entity.ToTable("Kennzahl_Kennzahlenbericht");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KennzahlId).HasColumnName("kennzahl_id");

                entity.Property(e => e.KennzahlenberichtId).HasColumnName("kennzahlenbericht_id");

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");

                entity.HasOne(d => d.Kennzahl)
                    .WithMany(p => p.KennzahlKennzahlenberichts)
                    .HasForeignKey(d => d.KennzahlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kennzahl_Kennzahlenbericht_Kennzahl");

                entity.HasOne(d => d.Kennzahlenbericht)
                    .WithMany(p => p.KennzahlKennzahlenberichts)
                    .HasForeignKey(d => d.KennzahlenberichtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kennzahl_Kennzahlenbericht_Kennzahlenbericht");
            });

            modelBuilder.Entity<KennzahlOperator>(entity =>
            {
                entity.ToTable("KennzahlOperator");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ErwarteteAnzahlParameter).HasColumnName("erwarteteAnzahlParameter");

                entity.Property(e => e.Funktionsname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("funktionsname");

                entity.Property(e => e.IstKlammerAuf).HasColumnName("istKlammerAuf");

                entity.Property(e => e.IstKlammerZu).HasColumnName("istKlammerZu");

                entity.Property(e => e.OperatorText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("operatorText");

                entity.Property(e => e.ReihenfolgeNr).HasColumnName("reihenfolgeNr");

                entity.Property(e => e.StringFuerAnzeige)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stringFuerAnzeige");

                entity.Property(e => e.StringFuerRechnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stringFuerRechnung");
            });

            modelBuilder.Entity<Kennzahlenbericht>(entity =>
            {
                entity.ToTable("Kennzahlenbericht");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Kennzahlenberichts)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kennzahlenbericht_Benutzer");
            });

            modelBuilder.Entity<Kommentar>(entity =>
            {
                entity.ToTable("Kommentar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nachricht)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("nachricht");
            });

            modelBuilder.Entity<Konsolidierung>(entity =>
            {
                entity.ToTable("Konsolidierung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.IstDatenImportPruefsumme).HasColumnName("istDatenImportPruefsumme");

                entity.Property(e => e.RegionaleZuordnungId).HasColumnName("regionaleZuordnung_id");

                entity.Property(e => e.SchnittstelleneinstellungId).HasColumnName("schnittstelleneinstellung_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Konsolidierungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Konsolidierung_Benutzer");

                entity.HasOne(d => d.RegionaleZuordnung)
                    .WithMany(p => p.Konsolidierungs)
                    .HasForeignKey(d => d.RegionaleZuordnungId)
                    .HasConstraintName("FK_Konsolidierung_RegionaleZuordnung");

                entity.HasOne(d => d.Schnittstelleneinstellung)
                    .WithMany(p => p.Konsolidierungs)
                    .HasForeignKey(d => d.SchnittstelleneinstellungId)
                    .HasConstraintName("FK_Konsolidierung_Schnittstelleneinstellung");
            });

            modelBuilder.Entity<KonsolidierungAfAzeile>(entity =>
            {
                entity.ToTable("KonsolidierungAfAzeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AfAlaufzeit).HasColumnName("afALaufzeit");

                entity.Property(e => e.AnlageartId).HasColumnName("anlageart_id");

                entity.Property(e => e.Anschaffungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("anschaffungsdatum");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.Aufloesung).HasColumnName("aufloesung");

                entity.Property(e => e.Bemerkung)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Bilanzgruppe).HasColumnName("bilanzgruppe");

                entity.Property(e => e.Gruppenschluessel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gruppenschluessel");

                entity.Property(e => e.Gwg).HasColumnName("gwg");

                entity.Property(e => e.Investitionshoehe).HasColumnName("investitionshoehe");

                entity.Property(e => e.IstAfA).HasColumnName("istAfA");

                entity.Property(e => e.IstErweiterungsinvestition).HasColumnName("istErweiterungsinvestition");

                entity.Property(e => e.IstPlanung).HasColumnName("istPlanung");

                entity.Property(e => e.IstSoPo).HasColumnName("istSoPo");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.ProzentKostenstelle).HasColumnName("prozentKostenstelle");

                entity.Property(e => e.SachkontoAnschaffungId).HasColumnName("sachkontoAnschaffung_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.Property(e => e.StandAnfangJahr).HasColumnName("standAnfangJahr");

                entity.Property(e => e.UrsprungsBetrag).HasColumnName("ursprungsBetrag");

                entity.Property(e => e.Zufuehrung).HasColumnName("zufuehrung");

                entity.Property(e => e.Zuschussgeber)
                    .HasMaxLength(50)
                    .HasColumnName("zuschussgeber");

                entity.HasOne(d => d.Anlageart)
                    .WithMany(p => p.KonsolidierungAfAzeiles)
                    .HasForeignKey(d => d.AnlageartId)
                    .HasConstraintName("FK_KonsolidierungAfAzeile_Anlageart");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungAfAzeiles)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .HasConstraintName("FK_KonsolidierungAfAzeile_Konsolidierung");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.KonsolidierungAfAzeiles)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_KonsolidierungAfAzeile_Kostenstelle");

                entity.HasOne(d => d.SachkontoAnschaffung)
                    .WithMany(p => p.KonsolidierungAfAzeileSachkontoAnschaffungs)
                    .HasForeignKey(d => d.SachkontoAnschaffungId)
                    .HasConstraintName("FK_KonsolidierungAfAzeile_Sachkonto_Anschaffung");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.KonsolidierungAfAzeileSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_KonsolidierungAfAzeile_Sachkonto");
            });

            modelBuilder.Entity<KonsolidierungAuslastungsblock>(entity =>
            {
                entity.ToTable("KonsolidierungAuslastungsblock");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsart_id");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.TypId).HasColumnName("typ_id");

                entity.Property(e => e.WertApril).HasColumnName("wertApril");

                entity.Property(e => e.WertAugust).HasColumnName("wertAugust");

                entity.Property(e => e.WertDezember).HasColumnName("wertDezember");

                entity.Property(e => e.WertFebruar).HasColumnName("wertFebruar");

                entity.Property(e => e.WertJanuar).HasColumnName("wertJanuar");

                entity.Property(e => e.WertJuli).HasColumnName("wertJuli");

                entity.Property(e => e.WertJuni).HasColumnName("wertJuni");

                entity.Property(e => e.WertMaerz).HasColumnName("wertMaerz");

                entity.Property(e => e.WertMai).HasColumnName("wertMai");

                entity.Property(e => e.WertNovember).HasColumnName("wertNovember");

                entity.Property(e => e.WertOktober).HasColumnName("wertOktober");

                entity.Property(e => e.WertSeptember).HasColumnName("wertSeptember");

                entity.HasOne(d => d.Auslastungsart)
                    .WithMany(p => p.KonsolidierungAuslastungsblocks)
                    .HasForeignKey(d => d.AuslastungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungAuslastungsblock_Auslastungsart");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungAuslastungsblocks)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungAuslastungsblock_Konsolidierung");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.KonsolidierungAuslastungsblocks)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK_KonsolidierungAuslastungsblock_KonsolidierungAuslastungsblocktyp");
            });

            modelBuilder.Entity<KonsolidierungAuslastungsblocktyp>(entity =>
            {
                entity.ToTable("KonsolidierungAuslastungsblocktyp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");
            });

            modelBuilder.Entity<KonsolidierungAuslastungszeile>(entity =>
            {
                entity.ToTable("KonsolidierungAuslastungszeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KonsolidierungAuslastungsblockId).HasColumnName("konsolidierungAuslastungsblock_id");

                entity.Property(e => e.TypId).HasColumnName("typ_id");

                entity.Property(e => e.WertApril).HasColumnName("wertApril");

                entity.Property(e => e.WertAugust).HasColumnName("wertAugust");

                entity.Property(e => e.WertDezember).HasColumnName("wertDezember");

                entity.Property(e => e.WertFebruar).HasColumnName("wertFebruar");

                entity.Property(e => e.WertJanuar).HasColumnName("wertJanuar");

                entity.Property(e => e.WertJuli).HasColumnName("wertJuli");

                entity.Property(e => e.WertJuni).HasColumnName("wertJuni");

                entity.Property(e => e.WertMaerz).HasColumnName("wertMaerz");

                entity.Property(e => e.WertMai).HasColumnName("wertMai");

                entity.Property(e => e.WertNovember).HasColumnName("wertNovember");

                entity.Property(e => e.WertOktober).HasColumnName("wertOktober");

                entity.Property(e => e.WertSeptember).HasColumnName("wertSeptember");

                entity.HasOne(d => d.KonsolidierungAuslastungsblock)
                    .WithMany(p => p.KonsolidierungAuslastungszeiles)
                    .HasForeignKey(d => d.KonsolidierungAuslastungsblockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungAuslastungszeile_KonsolidierungAuslastungsblock");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.KonsolidierungAuslastungszeiles)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK_KonsolidierungAuslastungszeile_KonsolidierungAuslastungszeilentyp");
            });

            modelBuilder.Entity<KonsolidierungAuslastungszeilentyp>(entity =>
            {
                entity.ToTable("KonsolidierungAuslastungszeilentyp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.KonsolidierungAuslastungsblocktypId).HasColumnName("konsolidierungAuslastungsblocktyp_Id");

                entity.HasOne(d => d.KonsolidierungAuslastungsblocktyp)
                    .WithMany(p => p.KonsolidierungAuslastungszeilentyps)
                    .HasForeignKey(d => d.KonsolidierungAuslastungsblocktypId)
                    .HasConstraintName("FK_KonsolidierungAuslastungszeilentyp_KonsolidierungAuslastungsblocktyp");
            });

            modelBuilder.Entity<KonsolidierungDarlehen>(entity =>
            {
                entity.ToTable("KonsolidierungDarlehen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.DarlehenWurdeVergeben).HasColumnName("darlehenWurdeVergeben");

                entity.Property(e => e.DarlehenshoeheAnfangJahr).HasColumnName("darlehenshoeheAnfangJahr");

                entity.Property(e => e.DarlehentypId).HasColumnName("darlehentyp_id");

                entity.Property(e => e.FinanzplanungId).HasColumnName("finanzplanung_id");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.Kredithoehe).HasColumnName("kredithoehe");

                entity.Property(e => e.Laufzeit).HasColumnName("laufzeit");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.Property(e => e.Startdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("startdatum");

                entity.Property(e => e.Tilgung).HasColumnName("tilgung");

                entity.Property(e => e.Tilgung01).HasColumnName("tilgung01");

                entity.Property(e => e.Tilgung02).HasColumnName("tilgung02");

                entity.Property(e => e.Tilgung03).HasColumnName("tilgung03");

                entity.Property(e => e.Tilgung04).HasColumnName("tilgung04");

                entity.Property(e => e.Tilgung05).HasColumnName("tilgung05");

                entity.Property(e => e.Tilgung06).HasColumnName("tilgung06");

                entity.Property(e => e.Tilgung07).HasColumnName("tilgung07");

                entity.Property(e => e.Tilgung08).HasColumnName("tilgung08");

                entity.Property(e => e.Tilgung09).HasColumnName("tilgung09");

                entity.Property(e => e.Tilgung10).HasColumnName("tilgung10");

                entity.Property(e => e.Tilgung11).HasColumnName("tilgung11");

                entity.Property(e => e.Tilgung12).HasColumnName("tilgung12");

                entity.Property(e => e.Typ).HasColumnName("typ");

                entity.Property(e => e.Zinsen01).HasColumnName("zinsen01");

                entity.Property(e => e.Zinsen02).HasColumnName("zinsen02");

                entity.Property(e => e.Zinsen03).HasColumnName("zinsen03");

                entity.Property(e => e.Zinsen04).HasColumnName("zinsen04");

                entity.Property(e => e.Zinsen05).HasColumnName("zinsen05");

                entity.Property(e => e.Zinsen06).HasColumnName("zinsen06");

                entity.Property(e => e.Zinsen07).HasColumnName("zinsen07");

                entity.Property(e => e.Zinsen08).HasColumnName("zinsen08");

                entity.Property(e => e.Zinsen09).HasColumnName("zinsen09");

                entity.Property(e => e.Zinsen10).HasColumnName("zinsen10");

                entity.Property(e => e.Zinsen11).HasColumnName("zinsen11");

                entity.Property(e => e.Zinsen12).HasColumnName("zinsen12");

                entity.Property(e => e.Zinssatz).HasColumnName("zinssatz");

                entity.HasOne(d => d.Darlehentyp)
                    .WithMany(p => p.KonsolidierungDarlehens)
                    .HasForeignKey(d => d.DarlehentypId)
                    .HasConstraintName("FK_KonsolidierungDarlehen_DarlehenTypen");

                entity.HasOne(d => d.Finanzplanung)
                    .WithMany(p => p.KonsolidierungDarlehens)
                    .HasForeignKey(d => d.FinanzplanungId)
                    .HasConstraintName("FK_KonsolidierungDarlehen_Finanzplanung");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungDarlehens)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .HasConstraintName("FK_KonsolidierungDarlehen_Konsolidierung");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.KonsolidierungDarlehens)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_KonsolidierungDarlehen_Kostenstelle");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.KonsolidierungDarlehens)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_KonsolidierungDarlehen_Sachkonto");
            });

            modelBuilder.Entity<KonsolidierungDataset>(entity =>
            {
                entity.ToTable("KonsolidierungDataset");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExportArt).HasColumnName("exportArt");

                entity.Property(e => e.KonsolidierungDatenExportId).HasColumnName("konsolidierungDatenExportId");

                entity.Property(e => e.Spalte1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte1");

                entity.Property(e => e.Spalte10)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte10");

                entity.Property(e => e.Spalte11)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte11");

                entity.Property(e => e.Spalte12)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte12");

                entity.Property(e => e.Spalte13)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte13");

                entity.Property(e => e.Spalte14)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte14");

                entity.Property(e => e.Spalte15)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte15");

                entity.Property(e => e.Spalte2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte2");

                entity.Property(e => e.Spalte3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte3");

                entity.Property(e => e.Spalte4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte4");

                entity.Property(e => e.Spalte5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte5");

                entity.Property(e => e.Spalte6)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte6");

                entity.Property(e => e.Spalte7)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte7");

                entity.Property(e => e.Spalte8)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte8");

                entity.Property(e => e.Spalte9)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spalte9");

                entity.HasOne(d => d.KonsolidierungDatenExport)
                    .WithMany(p => p.KonsolidierungDatasets)
                    .HasForeignKey(d => d.KonsolidierungDatenExportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungDataset_KonsolidierungDatenExport");
            });

            modelBuilder.Entity<KonsolidierungDatenExport>(entity =>
            {
                entity.ToTable("KonsolidierungDatenExport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Benutzer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzer");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Sachkontenrahmen)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sachkontenrahmen");
            });

            modelBuilder.Entity<KonsolidierungImportHochrechnung>(entity =>
            {
                entity.ToTable("KonsolidierungImportHochrechnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hochrechnung).HasColumnName("hochrechnung");

                entity.Property(e => e.ImportDatum)
                    .HasColumnType("datetime")
                    .HasColumnName("import_datum");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungImportHochrechnungs)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .HasConstraintName("FK_KonsolidierungImportHochrechnung_Konsolidierung");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.KonsolidierungImportHochrechnungs)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_KonsolidierungImportHochrechnung_Sachkonto");
            });

            modelBuilder.Entity<KonsolidierungImportVorjahr>(entity =>
            {
                entity.ToTable("KonsolidierungImportVorjahr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.Property(e => e.VorjahrGesamtsumme).HasColumnName("vorjahrGesamtsumme");

                entity.Property(e => e.WertApril).HasColumnName("wertApril");

                entity.Property(e => e.WertAugust).HasColumnName("wertAugust");

                entity.Property(e => e.WertDezember).HasColumnName("wertDezember");

                entity.Property(e => e.WertFebruar).HasColumnName("wertFebruar");

                entity.Property(e => e.WertJanuar).HasColumnName("wertJanuar");

                entity.Property(e => e.WertJuli).HasColumnName("wertJuli");

                entity.Property(e => e.WertJuni).HasColumnName("wertJuni");

                entity.Property(e => e.WertMaerz).HasColumnName("wertMaerz");

                entity.Property(e => e.WertMai).HasColumnName("wertMai");

                entity.Property(e => e.WertNovember).HasColumnName("wertNovember");

                entity.Property(e => e.WertOktober).HasColumnName("wertOktober");

                entity.Property(e => e.WertSeptember).HasColumnName("wertSeptember");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungImportVorjahrs)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungImportVorjahr_Konsolidierung");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.KonsolidierungImportVorjahrs)
                    .HasForeignKey(d => d.SachkontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungImportVorjahr_Sachkonto");
            });

            modelBuilder.Entity<KonsolidierungPersonal>(entity =>
            {
                entity.ToTable("KonsolidierungPersonal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AltersvorsorgeId).HasColumnName("altersvorsorge_id");

                entity.Property(e => e.ArbeitszeitProWoche).HasColumnName("arbeitszeitProWoche");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppe_id");

                entity.Property(e => e.Entgeltgruppe)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entgeltgruppe");

                entity.Property(e => e.Entgeltstufe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entgeltstufe");

                entity.Property(e => e.Gehalt).HasColumnName("gehalt");

                entity.Property(e => e.IstFachkraft).HasColumnName("istFachkraft");

                entity.Property(e => e.IstGfb).HasColumnName("istGfb");

                entity.Property(e => e.IstVertretungspersonal).HasColumnName("istVertretungspersonal");

                entity.Property(e => e.IstZdl).HasColumnName("istZDL");

                entity.Property(e => e.KeineAltersvorsorge).HasColumnName("keineAltersvorsorge");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Personalnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("personalnummer");

                entity.Property(e => e.TarifId).HasColumnName("tarif_id");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");

                entity.Property(e => e.ZuschlagProMonat).HasColumnName("zuschlagProMonat");

                entity.Property(e => e.Zuschuss).HasColumnName("zuschuss");

                entity.Property(e => e.ZuschussKontoId).HasColumnName("zuschussKonto_id");

                entity.HasOne(d => d.Altersvorsorge)
                    .WithMany(p => p.KonsolidierungPersonals)
                    .HasForeignKey(d => d.AltersvorsorgeId)
                    .HasConstraintName("FK_KonsolidierungPersonal_Altersvorsorge");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.KonsolidierungPersonals)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .HasConstraintName("FK_KonsolidierungPersonal_Berufsgruppe");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungPersonals)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungPersonal_Konsolidierung");

                entity.HasOne(d => d.Tarif)
                    .WithMany(p => p.KonsolidierungPersonals)
                    .HasForeignKey(d => d.TarifId)
                    .HasConstraintName("FK_KonsolidierungPersonal_Tarif");

                entity.HasOne(d => d.ZuschussKonto)
                    .WithMany(p => p.KonsolidierungPersonals)
                    .HasForeignKey(d => d.ZuschussKontoId)
                    .HasConstraintName("FK_KonsolidierungPersonal_Sachkonto");
            });

            modelBuilder.Entity<KonsolidierungPersonaleinsatz>(entity =>
            {
                entity.ToTable("KonsolidierungPersonaleinsatz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppe_id");

                entity.Property(e => e.BeschaeftigtBis)
                    .HasColumnType("datetime")
                    .HasColumnName("beschaeftigtBis");

                entity.Property(e => e.BeschaeftigtVon)
                    .HasColumnType("datetime")
                    .HasColumnName("beschaeftigtVon");

                entity.Property(e => e.GehaltProMonat).HasColumnName("gehaltProMonat");

                entity.Property(e => e.Kopfanteil).HasColumnName("kopfanteil");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PersonalId).HasColumnName("personal_id");

                entity.Property(e => e.Personalfolgekosten).HasColumnName("personalfolgekosten");

                entity.Property(e => e.Personalkosten).HasColumnName("personalkosten");

                entity.Property(e => e.Vkspeicherwert).HasColumnName("VKSpeicherwert");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.KonsolidierungPersonaleinsatzs)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .HasConstraintName("FK_KonsolidierungPersonaleinsatz_Berufsgruppe");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.KonsolidierungPersonaleinsatzs)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_KonsolidierungPersonaleinsatz_Kostenstelle");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.KonsolidierungPersonaleinsatzs)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_KonsolidierungPersonaleinsatz_KonsolidierungPersonal");
            });

            modelBuilder.Entity<KonsolidierungPersonalzusatzkosten>(entity =>
            {
                entity.ToTable("KonsolidierungPersonalzusatzkosten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Fahrtkosten).HasColumnName("fahrtkosten");

                entity.Property(e => e.Mietkosten).HasColumnName("mietkosten");

                entity.Property(e => e.Mobilitaetszuschlag).HasColumnName("mobilitaetszuschlag");

                entity.Property(e => e.PersonalId).HasColumnName("personal_id");

                entity.Property(e => e.Sonstiges).HasColumnName("sonstiges");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.KonsolidierungPersonalzusatzkostens)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_KonsolidierungPersonalzusatzkosten_KonsolidierungPersonal1");
            });

            modelBuilder.Entity<KonsolidierungPraemie>(entity =>
            {
                entity.ToTable("KonsolidierungPraemie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.DatumBis)
                    .HasColumnType("datetime")
                    .HasColumnName("datumBis");

                entity.Property(e => e.Einsatz).HasColumnName("einsatz");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PersonalId).HasColumnName("personal_id");

                entity.Property(e => e.SonderzahlungId).HasColumnName("sonderzahlung_id");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.KonsolidierungPraemies)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_KonsolidierungPraemie_KonsolidierungPersonal");

                entity.HasOne(d => d.Sonderzahlung)
                    .WithMany(p => p.KonsolidierungPraemies)
                    .HasForeignKey(d => d.SonderzahlungId)
                    .HasConstraintName("FK_KonsolidierungPraemie_Sonderzahlungen");
            });

            modelBuilder.Entity<KonsolidierungSachkostenVerteilungKst>(entity =>
            {
                entity.ToTable("KonsolidierungSachkostenVerteilungKST");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KonsolidierungImportVorjahrId).HasColumnName("konsolidierungImportVorjahr_id");

                entity.Property(e => e.KonsolidierungSachkostenzeileId).HasColumnName("konsolidierungSachkostenzeile_id");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.ProzentKostenstelle).HasColumnName("prozentKostenstelle");

                entity.HasOne(d => d.KonsolidierungImportVorjahr)
                    .WithMany(p => p.KonsolidierungSachkostenVerteilungKsts)
                    .HasForeignKey(d => d.KonsolidierungImportVorjahrId)
                    .HasConstraintName("FK_KonsolidierungSachkostenVerteilungKST_KonsolidierungImportVorjahr");

                entity.HasOne(d => d.KonsolidierungSachkostenzeile)
                    .WithMany(p => p.KonsolidierungSachkostenVerteilungKsts)
                    .HasForeignKey(d => d.KonsolidierungSachkostenzeileId)
                    .HasConstraintName("FK_KonsolidierungSachkostenVerteilungKST_KonsolidierungSachkostenzeile");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.KonsolidierungSachkostenVerteilungKsts)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_KonsolidierungSachkostenVerteilungKST_Kostenstelle");
            });

            modelBuilder.Entity<KonsolidierungSachkostenzeile>(entity =>
            {
                entity.ToTable("KonsolidierungSachkostenzeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErrechneterWert).HasColumnName("errechneterWert");

                entity.Property(e => e.HochgerechneterLfdJahr).HasColumnName("hochgerechneterLfdJahr");

                entity.Property(e => e.IstVorjahrWert).HasColumnName("istVorjahrWert");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.Planwert).HasColumnName("planwert");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungSachkostenzeiles)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungSachkostenzeile_Konsolidierung");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.KonsolidierungSachkostenzeiles)
                    .HasForeignKey(d => d.SachkontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KonsolidierungSachkostenzeile_Sachkonto");
            });

            modelBuilder.Entity<KonsolidierungSonderposten>(entity =>
            {
                entity.ToTable("KonsolidierungSonderposten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aufloesung).HasColumnName("aufloesung");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.KonsolidierungAfAzeileId).HasColumnName("konsolidierungAfAzeile_id");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.SachkontoAufwZufuehrungId).HasColumnName("sachkontoAufwZufuehrung_id");

                entity.Property(e => e.SachkontoErtrFoerderungId).HasColumnName("sachkontoErtrFoerderung_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.Property(e => e.StandAnfangJahr).HasColumnName("standAnfangJahr");

                entity.Property(e => e.Ursprungsbetrag).HasColumnName("ursprungsbetrag");

                entity.Property(e => e.Zufuehrung).HasColumnName("zufuehrung");

                entity.Property(e => e.Zuschussgeber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("zuschussgeber");

                entity.HasOne(d => d.KonsolidierungAfAzeile)
                    .WithMany(p => p.KonsolidierungSonderpostens)
                    .HasForeignKey(d => d.KonsolidierungAfAzeileId)
                    .HasConstraintName("FK_KonsolidierungSonderposten_KonsolidierungAfAzeile");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.KonsolidierungSonderpostens)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_KonsolidierungSonderposten_Kostenstelle");

                entity.HasOne(d => d.SachkontoAufwZufuehrung)
                    .WithMany(p => p.KonsolidierungSonderpostenSachkontoAufwZufuehrungs)
                    .HasForeignKey(d => d.SachkontoAufwZufuehrungId)
                    .HasConstraintName("FK_KonsolidierungSonderposten_SachkontoAufwZufuehrung");

                entity.HasOne(d => d.SachkontoErtrFoerderung)
                    .WithMany(p => p.KonsolidierungSonderpostenSachkontoErtrFoerderungs)
                    .HasForeignKey(d => d.SachkontoErtrFoerderungId)
                    .HasConstraintName("FK_KonsolidierungSonderposten_SachkontoErtrFoerderung");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.KonsolidierungSonderpostenSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_KonsolidierungSonderposten_Sachkonto");
            });

            modelBuilder.Entity<KonsolidierungVerprobung>(entity =>
            {
                entity.ToTable("KonsolidierungVerprobung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BetriebsstaetteVerprobungsfaktorId).HasColumnName("betriebsstaette_verprobungsfaktor_id");

                entity.Property(e => e.KonsolidierungPersonaleinsatzId).HasColumnName("konsolidierungPersonaleinsatz_id");

                entity.Property(e => e.VkwertVerprobt).HasColumnName("vkwert_verprobt");

                entity.HasOne(d => d.BetriebsstaetteVerprobungsfaktor)
                    .WithMany(p => p.KonsolidierungVerprobungs)
                    .HasForeignKey(d => d.BetriebsstaetteVerprobungsfaktorId)
                    .HasConstraintName("FK_KonsolidierungVerprobung_Verprobungsfaktor");

                entity.HasOne(d => d.KonsolidierungPersonaleinsatz)
                    .WithMany(p => p.KonsolidierungVerprobungs)
                    .HasForeignKey(d => d.KonsolidierungPersonaleinsatzId)
                    .HasConstraintName("FK_KonsolidierungVerprobung_KonsolidierungPersonaleinsatz");
            });

            modelBuilder.Entity<KonsolidierungWohnung>(entity =>
            {
                entity.ToTable("KonsolidierungWohnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.ErtragRenovierung).HasColumnName("ertragRenovierung");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Kaltmiete).HasColumnName("kaltmiete");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.Nebenkosten).HasColumnName("nebenkosten");

                entity.Property(e => e.Pauschale1).HasColumnName("pauschale1");

                entity.Property(e => e.Pauschale2).HasColumnName("pauschale2");

                entity.Property(e => e.WohnungId).HasColumnName("wohnung_id");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.KonsolidierungWohnungs)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .HasConstraintName("FK_KonsolidierungWohnung_Konsolidierung");

                entity.HasOne(d => d.Wohnung)
                    .WithMany(p => p.KonsolidierungWohnungs)
                    .HasForeignKey(d => d.WohnungId)
                    .HasConstraintName("FK_KonsolidierungWohnung_Wohnung");
            });

            modelBuilder.Entity<Kontaktinformation>(entity =>
            {
                entity.ToTable("Kontaktinformation");

                entity.HasIndex(e => new { e.KundeId, e.WieVerband, e.LieferantId }, "kundeUndWieVerband");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnredeId).HasColumnName("anrede_id");

                entity.Property(e => e.Anredetext)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anredetext");

                entity.Property(e => e.AnsprechpartnerId).HasColumnName("ansprechpartner_id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.LieferantId).HasColumnName("lieferant_id");

                entity.Property(e => e.MitartbeiterId).HasColumnName("mitartbeiter_id");

                entity.Property(e => e.StandardkommunikationskanalId).HasColumnName("standardkommunikationskanal_id");

                entity.Property(e => e.WieVerband).HasColumnName("wieVerband");

                entity.HasOne(d => d.Anrede)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.AnredeId)
                    .HasConstraintName("FK_Kontaktinformation_Anrede");

                entity.HasOne(d => d.Ansprechpartner)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.AnsprechpartnerId)
                    .HasConstraintName("FK_Kontaktinformation_Ansprechpartner");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Kontaktinformation_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Kontaktinformation_Betriebsstaette");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.KundeId)
                    .HasConstraintName("FK_Kontaktinformation_Kunde");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.LieferantId)
                    .HasConstraintName("FK_Kontaktinformation_Lieferant");

                entity.HasOne(d => d.Mitartbeiter)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.MitartbeiterId)
                    .HasConstraintName("FK_Kontaktinformation_Mitarbeiter");

                entity.HasOne(d => d.Standardkommunikationskanal)
                    .WithMany(p => p.Kontaktinformations)
                    .HasForeignKey(d => d.StandardkommunikationskanalId)
                    .HasConstraintName("FK_Kontaktinformation_Standardkommunikationskanal");
            });

            modelBuilder.Entity<Konto>(entity =>
            {
                entity.ToTable("Konto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FinanzinstitutId).HasColumnName("finanzinstitut_id");

                entity.Property(e => e.KontoinformationId).HasColumnName("kontoinformation_id");

                entity.Property(e => e.Kontonummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kontonummer");

                entity.HasOne(d => d.Finanzinstitut)
                    .WithMany(p => p.Kontos)
                    .HasForeignKey(d => d.FinanzinstitutId)
                    .HasConstraintName("FK_Konto_Finanzinstitut");

                entity.HasOne(d => d.Kontoinformation)
                    .WithMany(p => p.Kontos)
                    .HasForeignKey(d => d.KontoinformationId)
                    .HasConstraintName("FK_Konto_Kontoinformation");
            });

            modelBuilder.Entity<Kontobewegung>(entity =>
            {
                entity.ToTable("Kontobewegung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Belegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("belegdatum");

                entity.Property(e => e.Belegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegnummer");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.Betreff)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("betreff");

                entity.Property(e => e.Buchungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("buchungsdatum");

                entity.Property(e => e.Buchungsnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("buchungsnummer");

                entity.Property(e => e.GrundObjektId).HasColumnName("grundObjektId");

                entity.Property(e => e.GrundObjektTyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("grundObjektTyp");

                entity.Property(e => e.InternesKontoId).HasColumnName("internesKonto_id");

                entity.Property(e => e.KontoId).HasColumnName("konto_id");

                entity.Property(e => e.KontobewegungsartId).HasColumnName("kontobewegungsartId");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Kontobewegungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kontobewegung_Benutzer");

                entity.HasOne(d => d.InternesKonto)
                    .WithMany(p => p.Kontobewegungs)
                    .HasForeignKey(d => d.InternesKontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kontobewegung_InternesKonto");

                entity.HasOne(d => d.Konto)
                    .WithMany(p => p.Kontobewegungs)
                    .HasForeignKey(d => d.KontoId)
                    .HasConstraintName("FK_Kontobewegung_Konto");
            });

            modelBuilder.Entity<Kontoinformation>(entity =>
            {
                entity.ToTable("Kontoinformation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KontaktinformationId).HasColumnName("kontaktinformation_id");

                entity.Property(e => e.Kreditrahmen).HasColumnName("kreditrahmen");

                entity.HasOne(d => d.Kontaktinformation)
                    .WithMany(p => p.Kontoinformations)
                    .HasForeignKey(d => d.KontaktinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kontoinformation_Kontaktinformation");
            });

            modelBuilder.Entity<Kostenbereich>(entity =>
            {
                entity.ToTable("Kostenbereich");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kostenstelle>(entity =>
            {
                entity.ToTable("Kostenstelle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AnsprechpartnerId).HasColumnName("ansprechpartner_id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Eventkostenstelle).HasColumnName("eventkostenstelle");

                entity.Property(e => e.KalkulationsartId).HasColumnName("kalkulationsart_id");

                entity.Property(e => e.Kostenstellennummer).HasColumnName("kostenstellennummer");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OverheadId).HasColumnName("overhead_id");

                entity.Property(e => e.VorgabenameGewaehlt).HasColumnName("vorgabenameGewaehlt");

                entity.HasOne(d => d.Ansprechpartner)
                    .WithMany(p => p.Kostenstelles)
                    .HasForeignKey(d => d.AnsprechpartnerId)
                    .HasConstraintName("FK_Kostenstelle_Ansprechpartner");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Kostenstelles)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Kostenstelle_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Kostenstelles)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Kostenstelle_Betriebsstaette");

                entity.HasOne(d => d.Kalkulationsart)
                    .WithMany(p => p.Kostenstelles)
                    .HasForeignKey(d => d.KalkulationsartId)
                    .HasConstraintName("FK_Kostenstelle_Kalkulationsart");

                entity.HasOne(d => d.Overhead)
                    .WithMany(p => p.Kostenstelles)
                    .HasForeignKey(d => d.OverheadId)
                    .HasConstraintName("FK_Kostenstelle_Overhead");
            });

            modelBuilder.Entity<KostenstellePflegestufe>(entity =>
            {
                entity.ToTable("Kostenstelle_Pflegestufe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Auslastungsart).HasColumnName("auslastungsart");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.PflegestufeId).HasColumnName("pflegestufeId");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.KostenstellePflegestuves)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Kostenstelle_Pflegestufe_Kostenstelle");

                entity.HasOne(d => d.Pflegestufe)
                    .WithMany(p => p.KostenstellePflegestuves)
                    .HasForeignKey(d => d.PflegestufeId)
                    .HasConstraintName("FK_Kostenstelle_Pflegestufe_Pflegestufe");
            });

            modelBuilder.Entity<KostenstelleSachkontoBetriebsstaette>(entity =>
            {
                entity.ToTable("Kostenstelle_Sachkonto_Betriebsstaette");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.KostenstelleSachkontoBetriebsstaettes)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Kostenstelle_Sachkonto_Betriebsstaette_Betriebsstaette");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.KostenstelleSachkontoBetriebsstaettes)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Kostenstelle_Sachkonto_Betriebsstaette_Kostenstelle");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.KostenstelleSachkontoBetriebsstaettes)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_Kostenstelle_Sachkonto_Betriebsstaette_Sachkonto");
            });

            modelBuilder.Entity<KostenstelleVorgabename>(entity =>
            {
                entity.ToTable("KostenstelleVorgabename");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KostenbereichId).HasColumnName("kostenbereich_id");

                entity.Property(e => e.Kostenstellennummer).HasColumnName("kostenstellennummer");

                entity.Property(e => e.Vorgabename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorgabename");

                entity.HasOne(d => d.Kostenbereich)
                    .WithMany(p => p.KostenstelleVorgabenames)
                    .HasForeignKey(d => d.KostenbereichId)
                    .HasConstraintName("FK_KostenstelleVorgabename_Kostenbereich");
            });

            modelBuilder.Entity<Kostenstellenbereich>(entity =>
            {
                entity.ToTable("Kostenstellenbereich");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Schluessel).HasColumnName("schluessel");
            });

            modelBuilder.Entity<Kunde>(entity =>
            {
                entity.ToTable("Kunde");

                entity.HasIndex(e => new { e.KundeVerbandId, e.Debitorennummer, e.KundenartId, e.KundenkategorieId, e.Aktiv }, "verbandUndDebitorennr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Filialnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KommentarId).HasColumnName("kommentar_id");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kuerzel");

                entity.Property(e => e.KundeVerbandId).HasColumnName("kundeVerband_id");

                entity.Property(e => e.KundenartId).HasColumnName("kundenart_id");

                entity.Property(e => e.KundenkategorieId).HasColumnName("kundenkategorie_id");

                entity.Property(e => e.LieferantId).HasColumnName("lieferant_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NummerBeiKunde)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummerBeiKunde");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Titel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("titel");

                entity.Property(e => e.VorblattFuerVerband).HasColumnName("vorblattFuerVerband");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");

                entity.Property(e => e.ZahlungsartId).HasColumnName("zahlungsart_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Kundes)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kunde_Benutzer");

                entity.HasOne(d => d.Kommentar)
                    .WithMany(p => p.Kundes)
                    .HasForeignKey(d => d.KommentarId)
                    .HasConstraintName("FK_Kunde_Kommentar");

                entity.HasOne(d => d.KundeVerband)
                    .WithMany(p => p.InverseKundeVerband)
                    .HasForeignKey(d => d.KundeVerbandId)
                    .HasConstraintName("FK_Kunde_Kunde");

                entity.HasOne(d => d.Kundenart)
                    .WithMany(p => p.Kundes)
                    .HasForeignKey(d => d.KundenartId)
                    .HasConstraintName("FK_Kunde_Kundenart");

                entity.HasOne(d => d.Kundenkategorie)
                    .WithMany(p => p.Kundes)
                    .HasForeignKey(d => d.KundenkategorieId)
                    .HasConstraintName("FK_Kunde_Kundenkategorie");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.Kundes)
                    .HasForeignKey(d => d.LieferantId)
                    .HasConstraintName("FK_Kunde_Lieferant");

                entity.HasOne(d => d.Zahlungsart)
                    .WithMany(p => p.Kundes)
                    .HasForeignKey(d => d.ZahlungsartId)
                    .HasConstraintName("FK_Kunde_Zahlungsart");
            });

            modelBuilder.Entity<KundeArtikel>(entity =>
            {
                entity.ToTable("KundeArtikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.Kundenartikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundenartikelname");

                entity.Property(e => e.Kundenartikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundenartikelnummer");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.KundeArtikels)
                    .HasForeignKey(d => d.ArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KundeArtikel_Artikel");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.KundeArtikels)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KundeArtikel_Kunde");
            });

            modelBuilder.Entity<KundeLoesung>(entity =>
            {
                entity.ToTable("Kunde_Loesung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.LoesungId).HasColumnName("loesung_id");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.KundeLoesungs)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kunde_Loesung_Kunde");

                entity.HasOne(d => d.Loesung)
                    .WithMany(p => p.KundeLoesungs)
                    .HasForeignKey(d => d.LoesungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kunde_Loesung_Loesung");
            });

            modelBuilder.Entity<KundeSegment>(entity =>
            {
                entity.ToTable("Kunde_Segment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.SegmentId).HasColumnName("segment_id");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.KundeSegments)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kunde_Segment_Kunde");

                entity.HasOne(d => d.Segment)
                    .WithMany(p => p.KundeSegments)
                    .HasForeignKey(d => d.SegmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kunde_Segment_Segment");
            });

            modelBuilder.Entity<KundeVerleihartikel>(entity =>
            {
                entity.ToTable("Kunde_Verleihartikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AuftragId).HasColumnName("auftrag_id");

                entity.Property(e => e.BelegId).HasColumnName("beleg_id");

                entity.Property(e => e.Belegposition).HasColumnName("belegposition");

                entity.Property(e => e.Buchungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("buchungsdatum");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Kommentar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kommentar");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.ManuellerVerleihpreis).HasColumnName("manuellerVerleihpreis");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.Property(e => e.VerleihartikelId).HasColumnName("verleihartikel_id");

                entity.Property(e => e.Vernichtet).HasColumnName("vernichtet");

                entity.HasOne(d => d.Auftrag)
                    .WithMany(p => p.KundeVerleihartikels)
                    .HasForeignKey(d => d.AuftragId)
                    .HasConstraintName("FK_Kunde_Verleihartikel_Auftrag");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.KundeVerleihartikels)
                    .HasForeignKey(d => d.BelegId)
                    .HasConstraintName("FK_Kunde_Verleihartikel_Beleg");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.KundeVerleihartikels)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kunde_Verleihartikel_Kunde");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.KundeVerleihartikels)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Kunde_Verleihartikel_Steuern");

                entity.HasOne(d => d.Verleihartikel)
                    .WithMany(p => p.KundeVerleihartikels)
                    .HasForeignKey(d => d.VerleihartikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kunde_Verleihartikel_Verleihartikel");
            });

            modelBuilder.Entity<Kundenart>(entity =>
            {
                entity.ToTable("Kundenart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Kundenkategorie>(entity =>
            {
                entity.ToTable("Kundenkategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Lager>(entity =>
            {
                entity.ToTable("Lager");

                entity.HasIndex(e => e.Aktiv, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Ort).HasColumnName("ort");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Lagers)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Lager_Benutzer");

                entity.HasOne(d => d.OrtNavigation)
                    .WithMany(p => p.Lagers)
                    .HasForeignKey(d => d.Ort)
                    .HasConstraintName("FK_Lager_Betriebsstaette");
            });

            modelBuilder.Entity<LagerArtikel>(entity =>
            {
                entity.ToTable("Lager_Artikel");

                entity.HasIndex(e => new { e.LagerId, e.ArtikelId, e.BestandId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.BestandId).HasColumnName("bestandId");

                entity.Property(e => e.Durchschnittspreis).HasColumnName("durchschnittspreis");

                entity.Property(e => e.ErklaerungAbweichungInventur)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("erklaerungAbweichungInventur");

                entity.Property(e => e.InterneBelegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("interneBelegnummer");

                entity.Property(e => e.IstBarkauf).HasColumnName("istBarkauf");

                entity.Property(e => e.IstInventur).HasColumnName("istInventur");

                entity.Property(e => e.LagerId).HasColumnName("lagerId");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.LagerArtikels)
                    .HasForeignKey(d => d.ArtikelId)
                    .HasConstraintName("FK_Lager_Artikel_Artikel");

                entity.HasOne(d => d.Bestand)
                    .WithMany(p => p.LagerArtikels)
                    .HasForeignKey(d => d.BestandId)
                    .HasConstraintName("FK_Lager_Artikel_Bestand");

                entity.HasOne(d => d.Lager)
                    .WithMany(p => p.LagerArtikels)
                    .HasForeignKey(d => d.LagerId)
                    .HasConstraintName("FK_Lager_Artikel_Lager");
            });

            modelBuilder.Entity<LagerWarenwirtschaftskomponente>(entity =>
            {
                entity.ToTable("Lager_Warenwirtschaftskomponente");

                entity.HasIndex(e => new { e.LagerId, e.WarenwirtschaftskomponenteId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerId).HasColumnName("lagerId");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponenteId");

                entity.HasOne(d => d.Lager)
                    .WithMany(p => p.LagerWarenwirtschaftskomponentes)
                    .HasForeignKey(d => d.LagerId)
                    .HasConstraintName("FK_Lager_Warenwirtschaftskomponente_Lager");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.LagerWarenwirtschaftskomponentes)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .HasConstraintName("FK_Lager_Warenwirtschaftskomponente_Warenwirtschaftskomponente");
            });

            modelBuilder.Entity<Land>(entity =>
            {
                entity.ToTable("Land");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Lieferant>(entity =>
            {
                entity.ToTable("Lieferant");

                entity.HasIndex(e => new { e.LieferantVerbandId, e.KundeId, e.BetriebsstaetteId }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdresseId).HasColumnName("adresseId");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Iln)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("iln");

                entity.Property(e => e.IstZentralerLieferant).HasColumnName("istZentralerLieferant");

                entity.Property(e => e.KommentarId).HasColumnName("kommentar_id");

                entity.Property(e => e.Kreditorennummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kreditorennummer");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kuerzel");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.LieferantVerbandId).HasColumnName("lieferantVerband_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NummerBeiLieferant)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummerBeiLieferant");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.Lieferants)
                    .HasForeignKey(d => d.AdresseId)
                    .HasConstraintName("FK_Lieferant_Adresse");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Lieferants)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Lieferant_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Lieferants)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Lieferant_Betriebsstaette");

                entity.HasOne(d => d.Kommentar)
                    .WithMany(p => p.Lieferants)
                    .HasForeignKey(d => d.KommentarId)
                    .HasConstraintName("FK_Lieferant_Kommentar");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.Lieferants)
                    .HasForeignKey(d => d.KundeId)
                    .HasConstraintName("FK_Lieferant_Kunde");

                entity.HasOne(d => d.LieferantVerband)
                    .WithMany(p => p.InverseLieferantVerband)
                    .HasForeignKey(d => d.LieferantVerbandId)
                    .HasConstraintName("FK_Lieferant_Lieferant");
            });

            modelBuilder.Entity<LieferantMailZugangsdaten>(entity =>
            {
                entity.ToTable("Lieferant_MailZugangsdaten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LieferantId).HasColumnName("lieferant_Id");

                entity.Property(e => e.MailZugangsdatenId).HasColumnName("mailZugangsdaten_Id");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.LieferantMailZugangsdatens)
                    .HasForeignKey(d => d.LieferantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lieferant_MailZugangsdaten_Lieferant");

                entity.HasOne(d => d.MailZugangsdaten)
                    .WithMany(p => p.LieferantMailZugangsdatens)
                    .HasForeignKey(d => d.MailZugangsdatenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lieferant_MailZugangsdaten_MailZugangsdaten");
            });

            modelBuilder.Entity<Lieferdaten>(entity =>
            {
                entity.ToTable("Lieferdaten");

                entity.HasIndex(e => e.KontaktinformationId, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bestellkanal).HasColumnName("bestellkanal");

                entity.Property(e => e.Dauer)
                    .HasColumnName("dauer")
                    .HasComment("Gueltigkeit  des Skontos");

                entity.Property(e => e.KontaktinformationId).HasColumnName("kontaktinformation_id");

                entity.Property(e => e.Mindestbestellwert).HasColumnName("mindestbestellwert");

                entity.Property(e => e.Porto).HasColumnName("porto");

                entity.Property(e => e.Rabatt).HasColumnName("rabatt");

                entity.Property(e => e.Skonto).HasColumnName("skonto");

                entity.Property(e => e.WareMussAbgeholtWerden).HasColumnName("wareMussAbgeholtWerden");

                entity.HasOne(d => d.Kontaktinformation)
                    .WithMany(p => p.Lieferdatens)
                    .HasForeignKey(d => d.KontaktinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lieferdaten_Kontaktinformation");
            });

            modelBuilder.Entity<LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelle>(entity =>
            {
                entity.ToTable("LiquiditaetsplanungKonto_LiquiditaetsplanungKostenstelle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Betreff)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("betreff");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Istwert).HasColumnName("istwert");

                entity.Property(e => e.KontostandIst).HasColumnName("kontostandIst");

                entity.Property(e => e.KontostandPlan).HasColumnName("kontostandPlan");

                entity.Property(e => e.LiquiditaetsplanungKontoId).HasColumnName("liquiditaetsplanungKonto_id");

                entity.Property(e => e.LiquiditaetsplanungKostenstelle).HasColumnName("liquiditaetsplanungKostenstelle");

                entity.Property(e => e.Planwert).HasColumnName("planwert");

                entity.Property(e => e.Typ).HasColumnName("typ");

                entity.HasOne(d => d.LiquiditaetsplanungKonto)
                    .WithMany(p => p.LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelles)
                    .HasForeignKey(d => d.LiquiditaetsplanungKontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquiditaetsplanungKonto_LiquiditaetsplanungKostenstelle_Liquiditaetsplanungkonto");

                entity.HasOne(d => d.LiquiditaetsplanungKostenstelleNavigation)
                    .WithMany(p => p.LiquiditaetsplanungKontoLiquiditaetsplanungKostenstelles)
                    .HasForeignKey(d => d.LiquiditaetsplanungKostenstelle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquiditaetsplanungKonto_LiquiditaetsplanungKostenstelle_LiquiditaetsplanungKostenstelle");
            });

            modelBuilder.Entity<LiquiditaetsplanungKostenstelle>(entity =>
            {
                entity.ToTable("LiquiditaetsplanungKostenstelle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer).HasColumnName("nummer");
            });

            modelBuilder.Entity<LiquiditaetsplanungVorgabenaman>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LiquiditaetsplanungZeile>(entity =>
            {
                entity.ToTable("LiquiditaetsplanungZeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FinanzplanungId).HasColumnName("finanzplanungId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Wert1).HasColumnName("wert1");

                entity.Property(e => e.Wert10).HasColumnName("wert10");

                entity.Property(e => e.Wert11).HasColumnName("wert11");

                entity.Property(e => e.Wert12).HasColumnName("wert12");

                entity.Property(e => e.Wert2).HasColumnName("wert2");

                entity.Property(e => e.Wert3).HasColumnName("wert3");

                entity.Property(e => e.Wert4).HasColumnName("wert4");

                entity.Property(e => e.Wert5).HasColumnName("wert5");

                entity.Property(e => e.Wert6).HasColumnName("wert6");

                entity.Property(e => e.Wert7).HasColumnName("wert7");

                entity.Property(e => e.Wert8).HasColumnName("wert8");

                entity.Property(e => e.Wert9).HasColumnName("wert9");

                entity.HasOne(d => d.Finanzplanung)
                    .WithMany(p => p.LiquiditaetsplanungZeiles)
                    .HasForeignKey(d => d.FinanzplanungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquiditaetsplanungZeile_LiquiditaetsplanungZeile");
            });

            modelBuilder.Entity<Liquiditaetsplanungkonto>(entity =>
            {
                entity.ToTable("Liquiditaetsplanungkonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Anfangsbestand).HasColumnName("anfangsbestand");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer).HasColumnName("nummer");
            });

            modelBuilder.Entity<Lizenz>(entity =>
            {
                entity.ToTable("Lizenz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IstCoreLizenz).HasColumnName("istCoreLizenz");

                entity.Property(e => e.KannZugeordnetWerden).HasColumnName("kannZugeordnetWerden");

                entity.Property(e => e.Lizenz1)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("lizenz");

                entity.Property(e => e.Modul)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("modul");
            });

            modelBuilder.Entity<Loesung>(entity =>
            {
                entity.ToTable("Loesung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Lohn>(entity =>
            {
                entity.ToTable("Lohn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Hoehe).HasColumnName("hoehe");

                entity.Property(e => e.VerguetungsartId).HasColumnName("verguetungsart_id");

                entity.Property(e => e.VerguetungsinformationId).HasColumnName("verguetungsinformation_id");

                entity.HasOne(d => d.Verguetungsart)
                    .WithMany(p => p.Lohns)
                    .HasForeignKey(d => d.VerguetungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lohn_Verguetungsart");

                entity.HasOne(d => d.Verguetungsinformation)
                    .WithMany(p => p.Lohns)
                    .HasForeignKey(d => d.VerguetungsinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lohn_Verguetungsinformation");
            });

            modelBuilder.Entity<Mahnung>(entity =>
            {
                entity.ToTable("Mahnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BelegId).HasColumnName("beleg_id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.Mahnstufe).HasColumnName("mahnstufe");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.Mahnungs)
                    .HasForeignKey(d => d.BelegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mahnung_Beleg1");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Mahnungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mahnung_Benutzer");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.Mahnungs)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mahnung_Kunde");
            });

            modelBuilder.Entity<MailEmpfaenger>(entity =>
            {
                entity.ToTable("MailEmpfaenger");

                entity.HasIndex(e => new { e.MailId, e.MailempfaengerartId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresse");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.MailId).HasColumnName("mail_id");

                entity.Property(e => e.MailempfaengerartId).HasColumnName("mailempfaengerart_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Verarbeitet).HasColumnName("verarbeitet");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.MailEmpfaengers)
                    .HasForeignKey(d => d.KundeId)
                    .HasConstraintName("FK_MailEmpfaenger_Kunde");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.MailEmpfaengers)
                    .HasForeignKey(d => d.MailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailEmpfaenger_Mail");

                entity.HasOne(d => d.Mailempfaengerart)
                    .WithMany(p => p.MailEmpfaengers)
                    .HasForeignKey(d => d.MailempfaengerartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailEmpfaenger_MailEmpfaengerart");
            });

            modelBuilder.Entity<MailEmpfaengerart>(entity =>
            {
                entity.ToTable("MailEmpfaengerart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Art)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("art");
            });

            modelBuilder.Entity<MailMeldung>(entity =>
            {
                entity.ToTable("MailMeldung");

                entity.HasIndex(e => e.MailnachrichtId, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MailnachrichtId).HasColumnName("mailnachricht_id");

                entity.Property(e => e.Meldung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("meldung");

                entity.HasOne(d => d.Mailnachricht)
                    .WithMany(p => p.MailMeldungs)
                    .HasForeignKey(d => d.MailnachrichtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailMeldung_MailNachricht");
            });

            modelBuilder.Entity<MailNachricht>(entity =>
            {
                entity.ToTable("MailNachricht");

                entity.HasIndex(e => new { e.BenutzerId, e.IstEntwurf, e.Versanddatum }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Absender)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("absender");

                entity.Property(e => e.Absenderadresse)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("absenderadresse");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Betreff)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("betreff");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstEntwurf).HasColumnName("istEntwurf");

                entity.Property(e => e.Nachricht)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("nachricht");

                entity.Property(e => e.NachrichtRtf)
                    .IsUnicode(false)
                    .HasColumnName("nachrichtRtf");

                entity.Property(e => e.VersandNichtVor)
                    .HasColumnType("datetime")
                    .HasColumnName("versandNichtVor");

                entity.Property(e => e.VersandNichtVorAktiv).HasColumnName("versandNichtVorAktiv");

                entity.Property(e => e.Versanddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("versanddatum");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.MailNachrichts)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mail_Benutzer");
            });

            modelBuilder.Entity<MailZugangsdaten>(entity =>
            {
                entity.ToTable("MailZugangsdaten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzernameAusgangsserver)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzernameAusgangsserver");

                entity.Property(e => e.BenutzernameEingangsserver)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzernameEingangsserver");

                entity.Property(e => e.EmpfangsPort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("empfangsPort");

                entity.Property(e => e.EmpfangsServer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("empfangsServer");

                entity.Property(e => e.IstImap).HasColumnName("istImap");

                entity.Property(e => e.MailadresseAbsender)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mailadresseAbsender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PasswortAusgangsServer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("passwortAusgangsServer");

                entity.Property(e => e.PasswortEingangsServer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("passwortEingangsServer");

                entity.Property(e => e.SmtpAuthentifizierung).HasColumnName("smtpAuthentifizierung");

                entity.Property(e => e.SmtpPort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("smtpPort");

                entity.Property(e => e.SmtpServer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("smtpServer");

                entity.Property(e => e.VollstaendigerDatenabgleich).HasColumnName("vollstaendigerDatenabgleich");
            });

            modelBuilder.Entity<Mailadressart>(entity =>
            {
                entity.ToTable("Mailadressart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Mailadresse>(entity =>
            {
                entity.ToTable("Mailadresse");

                entity.HasIndex(e => new { e.MailadressartId, e.KontaktinformationId }, "ArtKontaktinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresse");

                entity.Property(e => e.KontaktinformationId).HasColumnName("kontaktinformation_id");

                entity.Property(e => e.MailadressartId).HasColumnName("mailadressart_id");

                entity.HasOne(d => d.Kontaktinformation)
                    .WithMany(p => p.Mailadresses)
                    .HasForeignKey(d => d.KontaktinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mailadresse_Kontaktinformation");

                entity.HasOne(d => d.Mailadressart)
                    .WithMany(p => p.Mailadresses)
                    .HasForeignKey(d => d.MailadressartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mailadresse_Mailadressart");
            });

            modelBuilder.Entity<Mandant>(entity =>
            {
                entity.ToTable("Mandant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Massgroesse>(entity =>
            {
                entity.ToTable("Massgroesse");

                entity.HasIndex(e => e.Id, "IX_Massgroesse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diamantschluessel)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("diamantschluessel");

                entity.Property(e => e.Kostenstelle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kostenstelle")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Property)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("property");
            });

            modelBuilder.Entity<Mengeneinheit>(entity =>
            {
                entity.ToTable("Mengeneinheit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kuerzel");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<MenueAlternative>(entity =>
            {
                entity.ToTable("MenueAlternative");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MenueplanId).HasColumnName("menueplan_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer).HasColumnName("nummer");

                entity.Property(e => e.Verkaufspreis)
                    .HasColumnName("verkaufspreis")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.Menueplan)
                    .WithMany(p => p.MenueAlternatives)
                    .HasForeignKey(d => d.MenueplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenueAlternative_Menueplan");
            });

            modelBuilder.Entity<Menueplan>(entity =>
            {
                entity.ToTable("Menueplan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Anzeigename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anzeigename");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.GeplantBis)
                    .HasColumnType("datetime")
                    .HasColumnName("geplantBis");

                entity.Property(e => e.KategorieId).HasColumnName("kategorie_Id");

                entity.Property(e => e.KommentarId).HasColumnName("kommentar_id");

                entity.Property(e => e.LetzteVeroeffentlichung)
                    .HasColumnType("datetime")
                    .HasColumnName("letzteVeroeffentlichung");

                entity.Property(e => e.MenueplanEigenschaftId).HasColumnName("menueplanEigenschaft_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Veroeffentlichen).HasColumnName("veroeffentlichen");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Menueplans)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menueplan_Benutzer");

                entity.HasOne(d => d.Kategorie)
                    .WithMany(p => p.Menueplans)
                    .HasForeignKey(d => d.KategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menueplan_Menueplankategorie");

                entity.HasOne(d => d.Kommentar)
                    .WithMany(p => p.Menueplans)
                    .HasForeignKey(d => d.KommentarId)
                    .HasConstraintName("FK_Menueplan_Kommentar");

                entity.HasOne(d => d.MenueplanEigenschaft)
                    .WithMany(p => p.Menueplans)
                    .HasForeignKey(d => d.MenueplanEigenschaftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menueplan_MenuplanEigenschaft");
            });

            modelBuilder.Entity<MenueplanKunde>(entity =>
            {
                entity.ToTable("Menueplan_Kunde");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.MenueplanId).HasColumnName("menueplan_id");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.MenueplanKundes)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menueplan_Kunde_Kunde");

                entity.HasOne(d => d.Menueplan)
                    .WithMany(p => p.MenueplanKundes)
                    .HasForeignKey(d => d.MenueplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menueplan_Kunde_Menueplan");
            });

            modelBuilder.Entity<MenueplanTag>(entity =>
            {
                entity.ToTable("MenueplanTag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MenuplanAlternativeId).HasColumnName("menuplanAlternative_Id");

                entity.Property(e => e.Tag).HasColumnType("datetime");

                entity.HasOne(d => d.MenuplanAlternative)
                    .WithMany(p => p.MenueplanTags)
                    .HasForeignKey(d => d.MenuplanAlternativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenueplanTag_MenueAlternative");
            });

            modelBuilder.Entity<MenueplanZeitpunkt>(entity =>
            {
                entity.ToTable("MenueplanZeitpunkt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GeschaetzteMenge).HasColumnName("geschaetzteMenge");

                entity.Property(e => e.MenueplanTagId).HasColumnName("menueplanTag_Id");

                entity.Property(e => e.Text)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Textmanuell).HasColumnName("textmanuell");

                entity.Property(e => e.Verkaufspreis)
                    .HasColumnName("verkaufspreis")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Zeitpunkt)
                    .HasColumnType("datetime")
                    .HasColumnName("zeitpunkt");

                entity.HasOne(d => d.MenueplanTag)
                    .WithMany(p => p.MenueplanZeitpunkts)
                    .HasForeignKey(d => d.MenueplanTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenueplanZeitpunkt_MenueplanTag");
            });

            modelBuilder.Entity<MenueplanZeitpunktArtikelverkaufRezept>(entity =>
            {
                entity.ToTable("MenueplanZeitpunkt_ArtikelverkaufRezept");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtikelverkaufId).HasColumnName("artikelverkauf_id");

                entity.Property(e => e.MenueplanZeitpunktId).HasColumnName("menueplanZeitpunkt_id");

                entity.Property(e => e.Nummer).HasColumnName("nummer");

                entity.Property(e => e.RezeptId).HasColumnName("rezept_id");

                entity.HasOne(d => d.Artikelverkauf)
                    .WithMany(p => p.MenueplanZeitpunktArtikelverkaufRezepts)
                    .HasForeignKey(d => d.ArtikelverkaufId)
                    .HasConstraintName("FK_MenueplanZeitpunkt_ArtikelverkaufRezept_ArtikelVerkauf");

                entity.HasOne(d => d.MenueplanZeitpunkt)
                    .WithMany(p => p.MenueplanZeitpunktArtikelverkaufRezepts)
                    .HasForeignKey(d => d.MenueplanZeitpunktId)
                    .HasConstraintName("FK_MenueplanZeitpunkt_ArtikelverkaufRezept_MenueplanZeitpunkt");

                entity.HasOne(d => d.Rezept)
                    .WithMany(p => p.MenueplanZeitpunktArtikelverkaufRezepts)
                    .HasForeignKey(d => d.RezeptId)
                    .HasConstraintName("FK_MenueplanZeitpunkt_ArtikelverkaufRezept_Rezept");
            });

            modelBuilder.Entity<Menueplankategorie>(entity =>
            {
                entity.ToTable("Menueplankategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<MenuplanEigenschaft>(entity =>
            {
                entity.ToTable("MenuplanEigenschaft");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dienstag).HasColumnName("dienstag");

                entity.Property(e => e.Donnerstag).HasColumnName("donnerstag");

                entity.Property(e => e.Freitag).HasColumnName("freitag");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Mittwoch).HasColumnName("mittwoch");

                entity.Property(e => e.Montag).HasColumnName("montag");

                entity.Property(e => e.Samstag).HasColumnName("samstag");

                entity.Property(e => e.Sonntag).HasColumnName("sonntag");
            });

            modelBuilder.Entity<Mitarbeiter>(entity =>
            {
                entity.ToTable("Mitarbeiter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Deaktiviert).HasColumnName("deaktiviert");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nachname");

                entity.Property(e => e.PersonalkategorieId).HasColumnName("personalkategorie_id");

                entity.Property(e => e.Personalnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("personalnummer");

                entity.Property(e => e.Vorname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Mitarbeiters)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Mitarbeiter_Benutzer");

                entity.HasOne(d => d.Personalkategorie)
                    .WithMany(p => p.Mitarbeiters)
                    .HasForeignKey(d => d.PersonalkategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mitarbeiter_Personalkategorie");
            });

            modelBuilder.Entity<Mitgliedsbeitrag>(entity =>
            {
                entity.ToTable("Mitgliedsbeitrag");

                entity.HasIndex(e => new { e.LandId, e.KundeId, e.Von, e.Bis }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beitrag).HasColumnName("beitrag");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Bis)
                    .HasColumnType("datetime")
                    .HasColumnName("bis");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.LandId).HasColumnName("land_id");

                entity.Property(e => e.Steuer).HasColumnName("steuer");

                entity.Property(e => e.Von)
                    .HasColumnType("datetime")
                    .HasColumnName("von");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.Mitgliedsbeitrags)
                    .HasForeignKey(d => d.KundeId)
                    .HasConstraintName("FK_Mitgliedsbeitrag_Kunde");

                entity.HasOne(d => d.Land)
                    .WithMany(p => p.Mitgliedsbeitrags)
                    .HasForeignKey(d => d.LandId)
                    .HasConstraintName("FK_Mitgliedsbeitrag_Land");
            });

            modelBuilder.Entity<Mitgliedschaft>(entity =>
            {
                entity.ToTable("Mitgliedschaft");

                entity.HasIndex(e => new { e.KundeId, e.MitgliedschaftArtId, e.Von, e.Bis }, "Rest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bemerkung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Bis)
                    .HasColumnType("datetime")
                    .HasColumnName("bis");

                entity.Property(e => e.Kuendigungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("kuendigungsdatum");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.MitgliedschaftArtId).HasColumnName("mitgliedschaftArt_id");

                entity.Property(e => e.Von)
                    .HasColumnType("datetime")
                    .HasColumnName("von");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.Mitgliedschafts)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mitgliedschaft_Kunde");

                entity.HasOne(d => d.MitgliedschaftArt)
                    .WithMany(p => p.Mitgliedschafts)
                    .HasForeignKey(d => d.MitgliedschaftArtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mitgliedschaft_MitgliedschaftArt");
            });

            modelBuilder.Entity<MitgliedschaftArt>(entity =>
            {
                entity.ToTable("MitgliedschaftArt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Navigationsbereich>(entity =>
            {
                entity.ToTable("Navigationsbereich");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Typ)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("typ");
            });

            modelBuilder.Entity<Newsletter>(entity =>
            {
                entity.ToTable("Newsletter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.MailNachrichtId).HasColumnName("mailNachricht_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Newsletters)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Benutzer");

                entity.HasOne(d => d.MailNachricht)
                    .WithMany(p => p.Newsletters)
                    .HasForeignKey(d => d.MailNachrichtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_MailNachricht");
            });

            modelBuilder.Entity<NewsletterKunde>(entity =>
            {
                entity.ToTable("Newsletter_Kunde");

                entity.HasIndex(e => new { e.NewsletterId, e.KundeId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.NewsletterId).HasColumnName("newsletter_id");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.NewsletterKundes)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Kunde_Kunde");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewsletterKundes)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Kunde_Newsletter");
            });

            modelBuilder.Entity<NewsletterMailEmpfaenger>(entity =>
            {
                entity.ToTable("NewsletterMailEmpfaenger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresse");

                entity.Property(e => e.NewsletterId).HasColumnName("newsletter_id");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewsletterMailEmpfaengers)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsletterMailEmpfaenger_Newsletter");
            });

            modelBuilder.Entity<NewsletterVerteiler>(entity =>
            {
                entity.ToTable("Newsletter_Verteiler");

                entity.HasIndex(e => new { e.NewsletterId, e.VerteilerId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NewsletterId).HasColumnName("newsletter_id");

                entity.Property(e => e.VerteilerId).HasColumnName("verteiler_id");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewsletterVerteilers)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Verteiler_Newsletter");

                entity.HasOne(d => d.Verteiler)
                    .WithMany(p => p.NewsletterVerteilers)
                    .HasForeignKey(d => d.VerteilerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Verteiler_Verteiler");
            });

            modelBuilder.Entity<Overhead>(entity =>
            {
                entity.ToTable("Overhead");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.TypId).HasColumnName("typ_id");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.Overheads)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK_Overhead_Typ");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("Personal");

                entity.HasIndex(e => new { e.KalkulationId, e.Aktiv, e.BerufsgruppeId, e.ZuschussKontoId, e.TarifId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbendbrotGestellt).HasColumnName("abendbrotGestellt");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AltersvorsorgeId).HasColumnName("altersvorsorge_id");

                entity.Property(e => e.ArbeitszeitProWoche).HasColumnName("arbeitszeitProWoche");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppeId");

                entity.Property(e => e.Entgeltgruppe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entgeltgruppe");

                entity.Property(e => e.FruehstueckGestellt).HasColumnName("fruehstueckGestellt");

                entity.Property(e => e.Gehalt).HasColumnName("gehalt");

                entity.Property(e => e.IstFachkraft).HasColumnName("istFachkraft");

                entity.Property(e => e.IstGfb).HasColumnName("istGfb");

                entity.Property(e => e.IstVertretungspersonal).HasColumnName("istVertretungspersonal");

                entity.Property(e => e.IstZdl).HasColumnName("istZDL");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.KeineAltersvorsorge)
                    .HasColumnName("keineAltersvorsorge")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MittagGestellt).HasColumnName("mittagGestellt");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Personalnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("personalnummer");

                entity.Property(e => e.TarifId).HasColumnName("tarif_id");

                entity.Property(e => e.Tarifgruppenname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tarifgruppenname");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");

                entity.Property(e => e.ZuschlagProMonat).HasColumnName("zuschlagProMonat");

                entity.Property(e => e.ZuschlagProMonatSvpflichtig).HasColumnName("zuschlagProMonatSVpflichtig");

                entity.Property(e => e.Zuschuss).HasColumnName("zuschuss");

                entity.Property(e => e.ZuschussKontoId).HasColumnName("zuschussKontoId");

                entity.HasOne(d => d.Altersvorsorge)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.AltersvorsorgeId)
                    .HasConstraintName("FK_Personal_Altersvorsorge");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .HasConstraintName("FK_Personal_Berufsgruppe");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_Personal_Kalkulation");

                entity.HasOne(d => d.Tarif)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.TarifId)
                    .HasConstraintName("FK_Personal_Tarif");

                entity.HasOne(d => d.ZuschussKonto)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.ZuschussKontoId)
                    .HasConstraintName("FK_Personal_Sachkonto");
            });

            modelBuilder.Entity<PersonalAuslastungszeile>(entity =>
            {
                entity.ToTable("Personal_Auslastungszeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonalAuslastungsart)
                    .HasColumnName("Personal_Auslastungsart")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PersonalId).HasColumnName("Personal_id");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.PersonalAuslastungszeiles)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_Personal_Auslastungszeile_Personal");
            });

            modelBuilder.Entity<PersonalZusatzkosten>(entity =>
            {
                entity.ToTable("PersonalZusatzkosten");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Fahrtkosten).HasColumnName("fahrtkosten");

                entity.Property(e => e.Mietkosten).HasColumnName("mietkosten");

                entity.Property(e => e.Mobilitaetszuschlag).HasColumnName("mobilitaetszuschlag");

                entity.Property(e => e.PersonalId).HasColumnName("personalId");

                entity.Property(e => e.Sonstiges).HasColumnName("sonstiges");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.PersonalZusatzkostens)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_PersonalZusatzkosten_Personal");
            });

            modelBuilder.Entity<Personaleinsatz>(entity =>
            {
                entity.ToTable("Personaleinsatz");

                entity.HasIndex(e => e.PersonalId, "IDX_Personaleinsaz_PersonalID");

                entity.HasIndex(e => new { e.BerufsgruppeId, e.KostenstelleId, e.PersonalId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppeId");

                entity.Property(e => e.BeschaeftigtBis)
                    .HasColumnType("datetime")
                    .HasColumnName("beschaeftigtBis");

                entity.Property(e => e.BeschaeftigtVon)
                    .HasColumnType("datetime")
                    .HasColumnName("beschaeftigtVon");

                entity.Property(e => e.GehaltProMonat).HasColumnName("gehaltProMonat");

                entity.Property(e => e.Kopfanteil).HasColumnName("kopfanteil");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PersonalId).HasColumnName("personalId");

                entity.Property(e => e.Personalfolgekosten).HasColumnName("personalfolgekosten");

                entity.Property(e => e.Personalkosten).HasColumnName("personalkosten");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.Personaleinsatzs)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .HasConstraintName("FK_Personaleinsatz_Berufsgruppe");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Personaleinsatzs)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Personaleinsatz_Kostenstelle");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.Personaleinsatzs)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_Personaleinsatz_Personal");
            });

            modelBuilder.Entity<Personalerloese>(entity =>
            {
                entity.ToTable("Personalerloese");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppe_id");

                entity.Property(e => e.Fakturaquote).HasColumnName("fakturaquote");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.PersonalId).HasColumnName("personal_id");

                entity.Property(e => e.Tagessatz).HasColumnName("tagessatz");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.Personalerloeses)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .HasConstraintName("FK_Personalerloese_Berufsgruppe");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.Personalerloeses)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_Personalerloese_Personal");
            });

            modelBuilder.Entity<Personalfaktor>(entity =>
            {
                entity.ToTable("Personalfaktor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Personalkategorie>(entity =>
            {
                entity.ToTable("Personalkategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Personalplan>(entity =>
            {
                entity.ToTable("Personalplan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.GroesseZeiteinheitInMinuten).HasColumnName("groesseZeiteinheitInMinuten");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PersonalplankategorieId).HasColumnName("personalplankategorie_id");

                entity.Property(e => e.PlanzeitBis)
                    .HasColumnType("datetime")
                    .HasColumnName("planzeitBis");

                entity.Property(e => e.PlanzeitVon)
                    .HasColumnType("datetime")
                    .HasColumnName("planzeitVon");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Personalplans)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personalplanung_Benutzer");

                entity.HasOne(d => d.Personalplankategorie)
                    .WithMany(p => p.Personalplans)
                    .HasForeignKey(d => d.PersonalplankategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personalplanung_Personalplankategorie");
            });

            modelBuilder.Entity<PersonalplanGeplanteZeiteinheit>(entity =>
            {
                entity.ToTable("PersonalplanGeplanteZeiteinheit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonalplanGeplanterTagId).HasColumnName("personalplanGeplanterTag_id");

                entity.Property(e => e.Zeitpunkt)
                    .HasColumnType("datetime")
                    .HasColumnName("zeitpunkt");

                entity.HasOne(d => d.PersonalplanGeplanterTag)
                    .WithMany(p => p.PersonalplanGeplanteZeiteinheits)
                    .HasForeignKey(d => d.PersonalplanGeplanterTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalplanungGeplanteZeiteinheit_PersonalplanungGeplanterTag");
            });

            modelBuilder.Entity<PersonalplanGeplanteZeiteinheitMitarbeiter>(entity =>
            {
                entity.ToTable("PersonalplanGeplanteZeiteinheit_Mitarbeiter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MitarbeiterId).HasColumnName("mitarbeiter_id");

                entity.Property(e => e.PersonalplanGeplanteZeiteinheitId).HasColumnName("personalplanGeplanteZeiteinheit_id");

                entity.HasOne(d => d.Mitarbeiter)
                    .WithMany(p => p.PersonalplanGeplanteZeiteinheitMitarbeiters)
                    .HasForeignKey(d => d.MitarbeiterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalplanungGeplanteZeiteinheit_Mitarbeiter_Mitarbeiter");

                entity.HasOne(d => d.PersonalplanGeplanteZeiteinheit)
                    .WithMany(p => p.PersonalplanGeplanteZeiteinheitMitarbeiters)
                    .HasForeignKey(d => d.PersonalplanGeplanteZeiteinheitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalplanungGeplanteZeiteinheit_Mitarbeiter_PersonalplanungGeplanteZeiteinheit");
            });

            modelBuilder.Entity<PersonalplanGeplanterTag>(entity =>
            {
                entity.ToTable("PersonalplanGeplanterTag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonalplanId).HasColumnName("personalplan_id");

                entity.Property(e => e.Tag)
                    .HasColumnType("datetime")
                    .HasColumnName("tag");

                entity.HasOne(d => d.Personalplan)
                    .WithMany(p => p.PersonalplanGeplanterTags)
                    .HasForeignKey(d => d.PersonalplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalplanungGeplanterTag_Personalplanung");
            });

            modelBuilder.Entity<PersonalplanPersonalplanregel>(entity =>
            {
                entity.ToTable("Personalplan_Personalplanregel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonalplanId).HasColumnName("personalplan_id");

                entity.Property(e => e.PersonalplanregelId).HasColumnName("personalplanregel_id");

                entity.HasOne(d => d.Personalplan)
                    .WithMany(p => p.PersonalplanPersonalplanregels)
                    .HasForeignKey(d => d.PersonalplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personalplaung_Personalplanregel_Personalplanung");

                entity.HasOne(d => d.Personalplanregel)
                    .WithMany(p => p.PersonalplanPersonalplanregels)
                    .HasForeignKey(d => d.PersonalplanregelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personalplaung_Personalplanregel_Personalplanregel");
            });

            modelBuilder.Entity<Personalplankategorie>(entity =>
            {
                entity.ToTable("Personalplankategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Personalplanregel>(entity =>
            {
                entity.ToTable("Personalplanregel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BedarfAnzahlMitarbeiter).HasColumnName("bedarfAnzahlMitarbeiter");

                entity.Property(e => e.KernzeitBis)
                    .HasColumnType("datetime")
                    .HasColumnName("kernzeitBis");

                entity.Property(e => e.KernzeitVon)
                    .HasColumnType("datetime")
                    .HasColumnName("kernzeitVon");
            });

            modelBuilder.Entity<Pflegesaetze>(entity =>
            {
                entity.ToTable("Pflegesaetze");

                entity.HasIndex(e => new { e.AuslastungsartId, e.BetriebsstaetteId, e.GueltigVon, e.GueltigBis, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Apu).HasColumnName("apu");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsart_id");

                entity.Property(e => e.BasisPflegesatzId).HasColumnName("basis_pflegesatz_id");

                entity.Property(e => e.Berechnungsbasis43b).HasColumnName("berechnungsbasis43b");

                entity.Property(e => e.BerechnungsbasisAnzahlTage43b).HasColumnName("berechnungsbasisAnzahlTage43b");

                entity.Property(e => e.BerechnungsbasisAnzahlTageErloes).HasColumnName("berechnungsbasisAnzahlTageErloes");

                entity.Property(e => e.BerechnungsbasisAnzahlTageInvest).HasColumnName("berechnungsbasisAnzahlTageInvest");

                entity.Property(e => e.BerechnungsbasisAnzahlTagePflege).HasColumnName("berechnungsbasisAnzahlTagePflege");

                entity.Property(e => e.BerechnungsbasisErloes).HasColumnName("berechnungsbasisErloes");

                entity.Property(e => e.BerechnungsbasisInvest).HasColumnName("berechnungsbasisInvest");

                entity.Property(e => e.BerechnungsbasisPflege).HasColumnName("berechnungsbasisPflege");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Eigenanteil).HasColumnName("eigenanteil");

                entity.Property(e => e.Entgelt43b).HasColumnName("entgelt43b");

                entity.Property(e => e.EzZuschlag).HasColumnName("ezZuschlag");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Investitionskosten3).HasColumnName("investitionskosten3");

                entity.Property(e => e.Investitionskosten4).HasColumnName("investitionskosten4");

                entity.Property(e => e.Investitionskosten5).HasColumnName("investitionskosten5");

                entity.Property(e => e.InvestitionskostenAllg).HasColumnName("investitionskostenAllg");

                entity.Property(e => e.InvestitionskostenSoz).HasColumnName("investitionskostenSoz");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PflegesatzMfp).HasColumnName("pflegesatz_mfp");

                entity.Property(e => e.Pflegestufe0).HasColumnName("pflegestufe0");

                entity.Property(e => e.Pflegestufe1).HasColumnName("pflegestufe1");

                entity.Property(e => e.Pflegestufe2).HasColumnName("pflegestufe2");

                entity.Property(e => e.Pflegestufe3).HasColumnName("pflegestufe3");

                entity.Property(e => e.Pflegestufe3p).HasColumnName("pflegestufe3p");

                entity.Property(e => e.ProzentwertSteigerungEntgelt43b).HasColumnName("prozentwert_steigerung_entgelt43b");

                entity.Property(e => e.ProzentwertSteigerungInvestkosten).HasColumnName("prozentwert_steigerung_investkosten");

                entity.Property(e => e.ProzentwertSteigerungPflegesatz).HasColumnName("prozentwert_steigerung_pflegesatz");

                entity.Property(e => e.ProzentwertSteigerungUv).HasColumnName("prozentwert_steigerung_uv");

                entity.Property(e => e.SatzFuerSimulation).HasColumnName("satzFuerSimulation");

                entity.Property(e => e.Sondennahrung).HasColumnName("sondennahrung");

                entity.Property(e => e.UnterkunftUndVerpflegung).HasColumnName("unterkunftUndVerpflegung");

                entity.HasOne(d => d.Auslastungsart)
                    .WithMany(p => p.Pflegesaetzes)
                    .HasForeignKey(d => d.AuslastungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pflegesaetze_Auslastungsart");

                entity.HasOne(d => d.BasisPflegesatz)
                    .WithMany(p => p.InverseBasisPflegesatz)
                    .HasForeignKey(d => d.BasisPflegesatzId)
                    .HasConstraintName("FK_Pflegesaetze_Pflegesaetze");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Pflegesaetzes)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Pflegesaetze_Betriebsstaette");
            });

            modelBuilder.Entity<Pflegestufe>(entity =>
            {
                entity.ToTable("Pflegestufe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Propertybezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("propertybezeichnung");
            });

            modelBuilder.Entity<PivotExportSpeziellesSpaltenformat>(entity =>
            {
                entity.ToTable("PivotExportSpeziellesSpaltenformat");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FormatString)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("formatString");

                entity.Property(e => e.Spaltenname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("spaltenname");
            });

            modelBuilder.Entity<Planbilanz>(entity =>
            {
                entity.ToTable("Planbilanz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DatumBis)
                    .HasColumnType("datetime")
                    .HasColumnName("datum_bis");

                entity.Property(e => e.DatumVon)
                    .HasColumnType("datetime")
                    .HasColumnName("datum_von");

                entity.Property(e => e.Istdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("istdatum");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.Planalternative)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("planalternative");

                entity.Property(e => e.Typ)
                    .HasColumnName("typ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VorjahresbilanzId).HasColumnName("vorjahresbilanz_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Planbilanzs)
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Planbilanz_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Planbilanzs)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Planbilanz_Betriebsstaette");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Planbilanzs)
                    .HasForeignKey(d => d.KalkulationId)
                    .HasConstraintName("FK_Planbilanz_Kalkulation");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.Planbilanzs)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .HasConstraintName("FK_Planbilanz_Konsolidierung");

                entity.HasOne(d => d.Vorjahresbilanz)
                    .WithMany(p => p.InverseVorjahresbilanz)
                    .HasForeignKey(d => d.VorjahresbilanzId)
                    .HasConstraintName("FK_Planbilanz_Planbilanz");
            });

            modelBuilder.Entity<PlanbilanzKonsolidierung>(entity =>
            {
                entity.ToTable("PlanbilanzKonsolidierung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlanbilanzId).HasColumnName("planbilanz_id");

                entity.Property(e => e.PlanbilanzkonsolidierungId).HasColumnName("planbilanzkonsolidierung_id");

                entity.HasOne(d => d.Planbilanz)
                    .WithMany(p => p.PlanbilanzKonsolidierungPlanbilanzs)
                    .HasForeignKey(d => d.PlanbilanzId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanbilanzKonsolidierung_Planbilanz");

                entity.HasOne(d => d.Planbilanzkonsolidierung)
                    .WithMany(p => p.PlanbilanzKonsolidierungPlanbilanzkonsolidierungs)
                    .HasForeignKey(d => d.PlanbilanzkonsolidierungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanbilanzKonsolidierung_Planbilanz1");
            });

            modelBuilder.Entity<PlanbilanzMittelfristplanung>(entity =>
            {
                entity.ToTable("Planbilanz_Mittelfristplanung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.PlanbilanzMittelfristplanungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planbilanz_Mittelfristplanung_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.PlanbilanzMittelfristplanungs)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planbilanz_Mittelfristplanung_Betriebsstaette");
            });

            modelBuilder.Entity<PlanbilanzMittelfristplanungPosition>(entity =>
            {
                entity.ToTable("Planbilanz_Mittelfristplanung_Position");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlanbilanzId).HasColumnName("planbilanz_id");

                entity.Property(e => e.PlanbilanzMittelfristId).HasColumnName("planbilanzMittelfristId");

                entity.HasOne(d => d.Planbilanz)
                    .WithMany(p => p.PlanbilanzMittelfristplanungPositions)
                    .HasForeignKey(d => d.PlanbilanzId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planbilanz_Mittelfristplanung_Position_Planbilanz");

                entity.HasOne(d => d.PlanbilanzMittelfrist)
                    .WithMany(p => p.PlanbilanzMittelfristplanungPositions)
                    .HasForeignKey(d => d.PlanbilanzMittelfristId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planbilanz_Mittelfristplanung_Position_Planbilanz_Mittelfristplanung");
            });

            modelBuilder.Entity<PlanbilanzPosition>(entity =>
            {
                entity.ToTable("PlanbilanzPosition");

                entity.HasIndex(e => e.PlanbilanzkontoId, "IDX_PlanbilanzPositionWerte");

                entity.HasIndex(e => e.PlanbilanzkontoId, "IDX_PlanbilanzPositionWerte1");

                entity.HasIndex(e => new { e.PlanbilanzId, e.PlanbilanzkontoId, e.PlanbilanzgegenkontoId }, "VIEW_PLANBILANZ_IDX_1");

                entity.HasIndex(e => new { e.PlanbilanzId, e.PlanbilanzkontoId, e.PlanbilanzgegenkontoId }, "VIEW_PLANBILANZ_IDX_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Manuell).HasColumnName("manuell");

                entity.Property(e => e.Nebenrechnung).HasColumnName("nebenrechnung");

                entity.Property(e => e.PlanbilanzId).HasColumnName("planbilanz_id");

                entity.Property(e => e.PlanbilanzgegenkontoId).HasColumnName("planbilanzgegenkonto_id");

                entity.Property(e => e.PlanbilanzkontoId).HasColumnName("planbilanzkonto_id");

                entity.Property(e => e.Wert01)
                    .HasColumnType("money")
                    .HasColumnName("wert01");

                entity.Property(e => e.Wert02)
                    .HasColumnType("money")
                    .HasColumnName("wert02");

                entity.Property(e => e.Wert03)
                    .HasColumnType("money")
                    .HasColumnName("wert03");

                entity.Property(e => e.Wert04)
                    .HasColumnType("money")
                    .HasColumnName("wert04");

                entity.Property(e => e.Wert05)
                    .HasColumnType("money")
                    .HasColumnName("wert05");

                entity.Property(e => e.Wert06)
                    .HasColumnType("money")
                    .HasColumnName("wert06");

                entity.Property(e => e.Wert07)
                    .HasColumnType("money")
                    .HasColumnName("wert07");

                entity.Property(e => e.Wert08)
                    .HasColumnType("money")
                    .HasColumnName("wert08");

                entity.Property(e => e.Wert09)
                    .HasColumnType("money")
                    .HasColumnName("wert09");

                entity.Property(e => e.Wert10)
                    .HasColumnType("money")
                    .HasColumnName("wert10");

                entity.Property(e => e.Wert11)
                    .HasColumnType("money")
                    .HasColumnName("wert11");

                entity.Property(e => e.Wert12)
                    .HasColumnType("money")
                    .HasColumnName("wert12");

                entity.Property(e => e.Werttyp).HasColumnName("werttyp");

                entity.HasOne(d => d.Planbilanz)
                    .WithMany(p => p.PlanbilanzPositions)
                    .HasForeignKey(d => d.PlanbilanzId)
                    .HasConstraintName("FK_PlanbilanzPosition_Planbilanz");

                entity.HasOne(d => d.Planbilanzgegenkonto)
                    .WithMany(p => p.PlanbilanzPositionPlanbilanzgegenkontos)
                    .HasForeignKey(d => d.PlanbilanzgegenkontoId)
                    .HasConstraintName("FK_PlanbilanzPosition_Planbilanzgegenkonto");

                entity.HasOne(d => d.Planbilanzkonto)
                    .WithMany(p => p.PlanbilanzPositionPlanbilanzkontos)
                    .HasForeignKey(d => d.PlanbilanzkontoId)
                    .HasConstraintName("FK_PlanbilanzPosition_Planbilanzkonto");
            });

            modelBuilder.Entity<Planbilanzkonto>(entity =>
            {
                entity.ToTable("Planbilanzkonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutoSumme).HasColumnName("autoSumme");

                entity.Property(e => e.Bearbeitbar).HasColumnName("bearbeitbar");

                entity.Property(e => e.Diamantkonto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("diamantkonto");

                entity.Property(e => e.Diamantplankonto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("diamantplankonto")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gewinn).HasColumnName("gewinn");

                entity.Property(e => e.Gliederung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gliederung");

                entity.Property(e => e.KontoArt)
                    .IsRequired()
                    .HasColumnName("kontoArt")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NegativparentId).HasColumnName("negativparent_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Sichtbar)
                    .IsRequired()
                    .HasColumnName("sichtbar")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sortierung).HasColumnName("sortierung");

                entity.Property(e => e.Umlauf).HasColumnName("umlauf");

                entity.HasOne(d => d.Negativparent)
                    .WithMany(p => p.InverseNegativparent)
                    .HasForeignKey(d => d.NegativparentId)
                    .HasConstraintName("FK_Planbilanzkonto_NegativPlanbilanzkonto");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Planbilanzkonto_Planbilanzkonto");
            });

            modelBuilder.Entity<Postleitzahlenvorgabewerte>(entity =>
            {
                entity.ToTable("Postleitzahlenvorgabewerte");

                entity.HasIndex(e => e.Code, "IX_Postleitzahlenvorgabewerte");

                entity.HasIndex(e => e.Suchname, "IX_Postleitzahlenvorgabewerte_1");

                entity.HasIndex(e => e.Ortsname, "IX_Postleitzahlenvorgabewerte_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktionsplz).HasColumnName("aktionsplz");

                entity.Property(e => e.Alort)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("alort");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Kgs)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kgs");

                entity.Property(e => e.LandId).HasColumnName("land_id");

                entity.Property(e => e.Ortsname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ortsname");

                entity.Property(e => e.Postfach).HasColumnName("postfach");

                entity.Property(e => e.Schalterausgabe).HasColumnName("schalterausgabe");

                entity.Property(e => e.Suchname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("suchname");

                entity.Property(e => e.Territorium)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("territorium");

                entity.Property(e => e.Zusatz)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("zusatz");

                entity.Property(e => e.ZusatzGehoertZuName).HasColumnName("zusatzGehoertZuName");

                entity.Property(e => e.Zustellung).HasColumnName("zustellung");

                entity.Property(e => e.ZustellungUndPostfach).HasColumnName("zustellungUndPostfach");

                entity.HasOne(d => d.Land)
                    .WithMany(p => p.Postleitzahlenvorgabewertes)
                    .HasForeignKey(d => d.LandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Postleitzahlenvorgabewerte_Land");
            });

            modelBuilder.Entity<Praemie>(entity =>
            {
                entity.ToTable("Praemie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AusTarifImportiert).HasColumnName("ausTarifImportiert");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.DatumBis)
                    .HasColumnType("datetime")
                    .HasColumnName("datumBis");

                entity.Property(e => e.Einsatz).HasColumnName("einsatz");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PersonalId).HasColumnName("personalId");

                entity.Property(e => e.SonderzahlungId).HasColumnName("sonderzahlungId");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.Praemies)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_Praemie_Personal");

                entity.HasOne(d => d.Sonderzahlung)
                    .WithMany(p => p.Praemies)
                    .HasForeignKey(d => d.SonderzahlungId)
                    .HasConstraintName("FK_Praemie_Sonderzahlungen");
            });

            modelBuilder.Entity<Prei>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArtikelEinkaufId).HasColumnName("artikelEinkauf_id");

                entity.Property(e => e.ArtikelVerkaufId).HasColumnName("artikelVerkauf_id");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.RezeptId).HasColumnName("rezept_id");

                entity.Property(e => e.VerleihartikelId).HasColumnName("verleihartikel_id");

                entity.HasOne(d => d.ArtikelEinkauf)
                    .WithMany(p => p.Preis)
                    .HasForeignKey(d => d.ArtikelEinkaufId)
                    .HasConstraintName("FK_Preis_ArtikelEinkauf");

                entity.HasOne(d => d.ArtikelVerkauf)
                    .WithMany(p => p.Preis)
                    .HasForeignKey(d => d.ArtikelVerkaufId)
                    .HasConstraintName("FK_Preis_ArtikelVerkauf");

                entity.HasOne(d => d.Rezept)
                    .WithMany(p => p.Preis)
                    .HasForeignKey(d => d.RezeptId)
                    .HasConstraintName("FK_Preis_Rezept");

                entity.HasOne(d => d.Verleihartikel)
                    .WithMany(p => p.Preis)
                    .HasForeignKey(d => d.VerleihartikelId)
                    .HasConstraintName("FK_Preis_Verleihartikel");
            });

            modelBuilder.Entity<Rabattinformationen>(entity =>
            {
                entity.ToTable("Rabattinformationen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bonus).HasColumnName("bonus");

                entity.Property(e => e.KontaktinformationId).HasColumnName("kontaktinformation_id");

                entity.Property(e => e.Skonto).HasColumnName("skonto");

                entity.HasOne(d => d.Kontaktinformation)
                    .WithMany(p => p.Rabattinformationens)
                    .HasForeignKey(d => d.KontaktinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rabattinformationen_Kontaktinformation");
            });

            modelBuilder.Entity<Rechnungseingangsliste>(entity =>
            {
                entity.ToTable("Rechnungseingangsliste");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Rechnungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("rechnungsdatum");

                entity.Property(e => e.Rechnungsnummer).HasColumnName("rechnungsnummer");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponenteId");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.Rechnungseingangslistes)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .HasConstraintName("FK_Rechnungseingangsliste_Warenwirtschaftskomponente");
            });

            modelBuilder.Entity<RechnungseingangslisteSachkonto>(entity =>
            {
                entity.ToTable("Rechnungseingangsliste_Sachkonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.LieferantId).HasColumnName("lieferantId");

                entity.Property(e => e.RechnungseingangslisteId).HasColumnName("rechnungseingangslisteId");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.HasOne(d => d.Lieferant)
                    .WithMany(p => p.RechnungseingangslisteSachkontos)
                    .HasForeignKey(d => d.LieferantId)
                    .HasConstraintName("FK_Rechnungseingangsliste_Sachkonto_Lieferant");

                entity.HasOne(d => d.Rechnungseingangsliste)
                    .WithMany(p => p.RechnungseingangslisteSachkontos)
                    .HasForeignKey(d => d.RechnungseingangslisteId)
                    .HasConstraintName("FK_Rechnungseingangsliste_Sachkonto_Rechnungseingangsliste");
            });

            modelBuilder.Entity<Rechte>(entity =>
            {
                entity.ToTable("Rechte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AfaArtikelSchreiben).HasColumnName("afa_Artikel_schreiben");

                entity.Property(e => e.AngebotsverwaltungLesen).HasColumnName("angebotsverwaltung_lesen");

                entity.Property(e => e.AngebotsverwaltungSchreiben).HasColumnName("angebotsverwaltung_schreiben");

                entity.Property(e => e.BenutzerverwaltungLesen).HasColumnName("benutzerverwaltung_lesen");

                entity.Property(e => e.BenutzerverwaltungSchreiben).HasColumnName("benutzerverwaltung_schreiben");

                entity.Property(e => e.EinrichrungGlobal).HasColumnName("einrichrungGlobal");

                entity.Property(e => e.KalkulationCafeLesen).HasColumnName("kalkulation_cafe_lesen");

                entity.Property(e => e.KalkulationCafeSchreiben).HasColumnName("kalkulation_cafe_schreiben");

                entity.Property(e => e.KalkulationCatLesen).HasColumnName("kalkulation_cat_lesen");

                entity.Property(e => e.KalkulationCatSchreiben).HasColumnName("kalkulation_cat_schreiben");

                entity.Property(e => e.KalkulationKioskLesen).HasColumnName("kalkulation_kiosk_lesen");

                entity.Property(e => e.KalkulationKioskSchreiben).HasColumnName("kalkulation_kiosk_schreiben");

                entity.Property(e => e.KalkulationOverheadLesen).HasColumnName("kalkulation_overhead_lesen");

                entity.Property(e => e.KalkulationUrLesen).HasColumnName("kalkulation_ur_lesen");

                entity.Property(e => e.KalkulationUrSchreiben).HasColumnName("kalkulation_ur_schreiben");

                entity.Property(e => e.KalkulatoonOverheadSchreiben).HasColumnName("kalkulatoon_overhead_schreiben");

                entity.Property(e => e.KonsolidierungAufGesellschafterebene).HasColumnName("konsolidierung_auf_gesellschafterebene");

                entity.Property(e => e.KundenverwaltungLesen).HasColumnName("kundenverwaltung_lesen");

                entity.Property(e => e.KundenverwaltungSchreiben).HasColumnName("kundenverwaltung_schreiben");

                entity.Property(e => e.OfflineArbeiten).HasColumnName("offline_arbeiten");

                entity.Property(e => e.Root).HasColumnName("root");

                entity.Property(e => e.StammdatenverwaltungLesen).HasColumnName("stammdatenverwaltung_lesen");

                entity.Property(e => e.StammdatenverwaltungSchreiben).HasColumnName("stammdatenverwaltung_schreiben");

                entity.Property(e => e.WawiGlobal).HasColumnName("wawi_global");
            });

            modelBuilder.Entity<RegionaleZuordnung>(entity =>
            {
                entity.ToTable("RegionaleZuordnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Reklamationsgrund>(entity =>
            {
                entity.ToTable("Reklamationsgrund");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Rezept>(entity =>
            {
                entity.ToTable("Rezept");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AnzahlPortionen).HasColumnName("anzahlPortionen");

                entity.Property(e => e.AnzeigeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anzeigeName");

                entity.Property(e => e.AusgabeeinheitId).HasColumnName("ausgabeeinheit_id");

                entity.Property(e => e.Ausgabemenge).HasColumnName("ausgabemenge");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BildId).HasColumnName("bild_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.GrammProStueck).HasColumnName("grammProStueck");

                entity.Property(e => e.IstMenuebestandteil).HasColumnName("istMenuebestandteil");

                entity.Property(e => e.KommentarId).HasColumnName("kommentar_id");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheit_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RezeptPortionsgroesseId).HasColumnName("rezeptPortionsgroesse_id");

                entity.Property(e => e.RezepteinheitId).HasColumnName("rezepteinheit_id");

                entity.Property(e => e.RezeptkategorieId).HasColumnName("rezeptkategorie_id");

                entity.HasOne(d => d.Ausgabeeinheit)
                    .WithMany(p => p.RezeptAusgabeeinheits)
                    .HasForeignKey(d => d.AusgabeeinheitId)
                    .HasConstraintName("FK_Rezept_Mengeneinheit1");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Rezepts)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezept_Benutzer");

                entity.HasOne(d => d.Bild)
                    .WithMany(p => p.Rezepts)
                    .HasForeignKey(d => d.BildId)
                    .HasConstraintName("FK_Rezept_Bild");

                entity.HasOne(d => d.Kommentar)
                    .WithMany(p => p.Rezepts)
                    .HasForeignKey(d => d.KommentarId)
                    .HasConstraintName("FK_Rezept_Kommentar");

                entity.HasOne(d => d.Mengeneinheit)
                    .WithMany(p => p.RezeptMengeneinheits)
                    .HasForeignKey(d => d.MengeneinheitId)
                    .HasConstraintName("FK_Rezept_Mengeneinheit");

                entity.HasOne(d => d.RezeptPortionsgroesse)
                    .WithMany(p => p.Rezepts)
                    .HasForeignKey(d => d.RezeptPortionsgroesseId)
                    .HasConstraintName("FK_Rezept_RezeptPortionsgroesse");

                entity.HasOne(d => d.Rezepteinheit)
                    .WithMany(p => p.Rezepts)
                    .HasForeignKey(d => d.RezepteinheitId)
                    .HasConstraintName("FK_Rezept_Rezepteinheit");

                entity.HasOne(d => d.Rezeptkategorie)
                    .WithMany(p => p.Rezepts)
                    .HasForeignKey(d => d.RezeptkategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezept_Rezeptkategorie");
            });

            modelBuilder.Entity<RezeptArtikel>(entity =>
            {
                entity.ToTable("Rezept_Artikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.RezeptId).HasColumnName("rezept_id");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.RezeptArtikels)
                    .HasForeignKey(d => d.ArtikelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezept_Artikel_Artikel");

                entity.HasOne(d => d.Rezept)
                    .WithMany(p => p.RezeptArtikels)
                    .HasForeignKey(d => d.RezeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezept_Artikel_Rezept");
            });

            modelBuilder.Entity<RezeptPortionsgroesse>(entity =>
            {
                entity.ToTable("RezeptPortionsgroesse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<RezeptRezept>(entity =>
            {
                entity.ToTable("Rezept_Rezept");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.RezeptEnthaltenId).HasColumnName("rezept_enthalten_id");

                entity.Property(e => e.RezeptUebergeordnetId).HasColumnName("rezept_uebergeordnet_id");

                entity.HasOne(d => d.RezeptEnthalten)
                    .WithMany(p => p.RezeptRezeptRezeptEnthaltens)
                    .HasForeignKey(d => d.RezeptEnthaltenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezept_RezeptEnhalten");

                entity.HasOne(d => d.RezeptUebergeordnet)
                    .WithMany(p => p.RezeptRezeptRezeptUebergeordnets)
                    .HasForeignKey(d => d.RezeptUebergeordnetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezept_RezeptUebergeordnet");
            });

            modelBuilder.Entity<Rezepteinheit>(entity =>
            {
                entity.ToTable("Rezepteinheit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Rezeptkategorie>(entity =>
            {
                entity.ToTable("Rezeptkategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Rhythmu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SachkontenGliederungsgruppe>(entity =>
            {
                entity.ToTable("SachkontenGliederungsgruppe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IstGuVposition)
                    .IsRequired()
                    .HasColumnName("istGuVPosition")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OberGliederungId).HasColumnName("oberGliederung_id");

                entity.Property(e => e.PositionString)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");

                entity.Property(e => e.Typ).HasColumnName("typ");

                entity.HasOne(d => d.OberGliederung)
                    .WithMany(p => p.InverseOberGliederung)
                    .HasForeignKey(d => d.OberGliederungId)
                    .HasConstraintName("FK_SachkontenGliederungsgruppe_SachkontenGliederungsgruppe");
            });

            modelBuilder.Entity<SachkontenGliederungsgruppeSachkontoGliederungsSummenzeile>(entity =>
            {
                entity.ToTable("SachkontenGliederungsgruppe_SachkontoGliederungsSummenzeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SachkontoGliederungsgruppeId).HasColumnName("sachkontoGliederungsgruppe_id");

                entity.Property(e => e.SachkontoGliederungsgruppeSummenzeileId).HasColumnName("sachkontoGliederungsgruppeSummenzeile_id");

                entity.HasOne(d => d.SachkontoGliederungsgruppe)
                    .WithMany(p => p.SachkontenGliederungsgruppeSachkontoGliederungsSummenzeiles)
                    .HasForeignKey(d => d.SachkontoGliederungsgruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SachkontenGliederungsgruppe_SachkontoGliederungsSummenzeile_SachkontenGliederungsgruppe");

                entity.HasOne(d => d.SachkontoGliederungsgruppeSummenzeile)
                    .WithMany(p => p.SachkontenGliederungsgruppeSachkontoGliederungsSummenzeiles)
                    .HasForeignKey(d => d.SachkontoGliederungsgruppeSummenzeileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SachkontenGliederungsgruppe_SachkontoGliederungsSummenzeile_SachkontoGliederungsgruppeSummenzeile");
            });

            modelBuilder.Entity<Sachkontengruppe>(entity =>
            {
                entity.ToTable("Sachkontengruppe");

                entity.HasIndex(e => new { e.OberSachkontengruppeId, e.Aktiv }, "Wichtiges");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.GuvPositionString)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("guvPositionString");

                entity.Property(e => e.IstGuVposition).HasColumnName("istGuVPosition");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OberSachkontengruppeId).HasColumnName("oberSachkontengruppeId");

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");

                entity.HasOne(d => d.OberSachkontengruppe)
                    .WithMany(p => p.InverseOberSachkontengruppe)
                    .HasForeignKey(d => d.OberSachkontengruppeId)
                    .HasConstraintName("FK_Sachkontengruppe_Sachkontengruppe");
            });

            modelBuilder.Entity<SachkontengruppeGuvSummenzeile>(entity =>
            {
                entity.ToTable("Sachkontengruppe_GuvSummenzeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GuvSummenzeileId).HasColumnName("guvSummenzeileId");

                entity.Property(e => e.SachkontengruppeId).HasColumnName("sachkontengruppeId");

                entity.HasOne(d => d.GuvSummenzeile)
                    .WithMany(p => p.SachkontengruppeGuvSummenzeiles)
                    .HasForeignKey(d => d.GuvSummenzeileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkontengruppe_GuvSummenzeile_GuvSummenzeile");

                entity.HasOne(d => d.Sachkontengruppe)
                    .WithMany(p => p.SachkontengruppeGuvSummenzeiles)
                    .HasForeignKey(d => d.SachkontengruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkontengruppe_GuvSummenzeile_Sachkontengruppe");
            });

            modelBuilder.Entity<Sachkontenkategorie>(entity =>
            {
                entity.ToTable("Sachkontenkategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SachkontoCateringErloeseId).HasColumnName("sachkontoCateringErloeseId");

                entity.Property(e => e.SachkontoErloeseGetraenke19Id).HasColumnName("sachkontoErloeseGetraenke19Id");

                entity.Property(e => e.SachkontoErloeseGetraenke7Id).HasColumnName("sachkontoErloeseGetraenke7Id");

                entity.Property(e => e.SachkontoErloeseLebensmittelId).HasColumnName("sachkontoErloeseLebensmittelId");

                entity.Property(e => e.SachkontoErloeseOperMgmtAufschlagId).HasColumnName("sachkontoErloeseOperMgmtAufschlagId");

                entity.Property(e => e.SachkontoErloeseVerwaltungId).HasColumnName("sachkontoErloeseVerwaltung_id");

                entity.Property(e => e.SachkontoKalkGewSteuerId).HasColumnName("sachkonto_KalkGewSteuerId");

                entity.Property(e => e.SachkontoKalkKoerpSteuerId).HasColumnName("sachkonto_KalkKoerpSteuerId");

                entity.Property(e => e.SachkontoLmsteuerId).HasColumnName("sachkonto_LMSteuerId");

                entity.Property(e => e.SachkontoOperMgmtAufschlagId).HasColumnName("sachkonto_OperMgmtAufschlag_id");

                entity.Property(e => e.SachkontoUhrerloeseId).HasColumnName("sachkontoUHRErloese_id");

                entity.Property(e => e.SachkontoVerwKostenId).HasColumnName("Sachkonto_VerwKostenId");

                entity.Property(e => e.SachkontoVolleSteuerId).HasColumnName("sachkonto_VolleSteuerId");

                entity.Property(e => e.SachkontoZgastId).HasColumnName("sachkontoZGASt_id");

                entity.Property(e => e.Stundenwoche).HasColumnName("stundenwoche");

                entity.Property(e => e.TypId).HasColumnName("typId");

                entity.HasOne(d => d.SachkontoCateringErloese)
                    .WithMany(p => p.SachkontenkategorieSachkontoCateringErloeses)
                    .HasForeignKey(d => d.SachkontoCateringErloeseId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto17");

                entity.HasOne(d => d.SachkontoErloeseGetraenke19)
                    .WithMany(p => p.SachkontenkategorieSachkontoErloeseGetraenke19s)
                    .HasForeignKey(d => d.SachkontoErloeseGetraenke19Id)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto14");

                entity.HasOne(d => d.SachkontoErloeseGetraenke7)
                    .WithMany(p => p.SachkontenkategorieSachkontoErloeseGetraenke7s)
                    .HasForeignKey(d => d.SachkontoErloeseGetraenke7Id)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto15");

                entity.HasOne(d => d.SachkontoErloeseLebensmittel)
                    .WithMany(p => p.SachkontenkategorieSachkontoErloeseLebensmittels)
                    .HasForeignKey(d => d.SachkontoErloeseLebensmittelId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto16");

                entity.HasOne(d => d.SachkontoErloeseOperMgmtAufschlag)
                    .WithMany(p => p.SachkontenkategorieSachkontoErloeseOperMgmtAufschlags)
                    .HasForeignKey(d => d.SachkontoErloeseOperMgmtAufschlagId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto21");

                entity.HasOne(d => d.SachkontoErloeseVerwaltung)
                    .WithMany(p => p.SachkontenkategorieSachkontoErloeseVerwaltungs)
                    .HasForeignKey(d => d.SachkontoErloeseVerwaltungId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto18");

                entity.HasOne(d => d.SachkontoKalkGewSteuer)
                    .WithMany(p => p.SachkontenkategorieSachkontoKalkGewSteuers)
                    .HasForeignKey(d => d.SachkontoKalkGewSteuerId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto6");

                entity.HasOne(d => d.SachkontoKalkKoerpSteuer)
                    .WithMany(p => p.SachkontenkategorieSachkontoKalkKoerpSteuers)
                    .HasForeignKey(d => d.SachkontoKalkKoerpSteuerId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto7");

                entity.HasOne(d => d.SachkontoLmsteuer)
                    .WithMany(p => p.SachkontenkategorieSachkontoLmsteuers)
                    .HasForeignKey(d => d.SachkontoLmsteuerId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto4");

                entity.HasOne(d => d.SachkontoOperMgmtAufschlag)
                    .WithMany(p => p.SachkontenkategorieSachkontoOperMgmtAufschlags)
                    .HasForeignKey(d => d.SachkontoOperMgmtAufschlagId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto20");

                entity.HasOne(d => d.SachkontoUhrerloese)
                    .WithMany(p => p.SachkontenkategorieSachkontoUhrerloeses)
                    .HasForeignKey(d => d.SachkontoUhrerloeseId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto19");

                entity.HasOne(d => d.SachkontoVerwKosten)
                    .WithMany(p => p.SachkontenkategorieSachkontoVerwKostens)
                    .HasForeignKey(d => d.SachkontoVerwKostenId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto12");

                entity.HasOne(d => d.SachkontoVolleSteuer)
                    .WithMany(p => p.SachkontenkategorieSachkontoVolleSteuers)
                    .HasForeignKey(d => d.SachkontoVolleSteuerId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto5");

                entity.HasOne(d => d.SachkontoZgast)
                    .WithMany(p => p.SachkontenkategorieSachkontoZgasts)
                    .HasForeignKey(d => d.SachkontoZgastId)
                    .HasConstraintName("FK_Sachkontenkategorie_Sachkonto13");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.Sachkontenkategories)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK_Sachkontenkategorie_Typ");
            });

            modelBuilder.Entity<Sachkontenueberleitung>(entity =>
            {
                entity.ToTable("Sachkontenueberleitung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.KstTransferieren).HasColumnName("kstTransferieren");

                entity.Property(e => e.TypId).HasColumnName("typ_id");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.Sachkontenueberleitungs)
                    .HasForeignKey(d => d.TypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkontenueberleitung_Sachkontenkategorie");
            });

            modelBuilder.Entity<Sachkontenueberleitungseintrag>(entity =>
            {
                entity.ToTable("Sachkontenueberleitungseintrag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AltesSachkonto).HasColumnName("altesSachkonto");

                entity.Property(e => e.NeuesSachkonto).HasColumnName("neuesSachkonto");

                entity.Property(e => e.SachkontenueberleitungId).HasColumnName("sachkontenueberleitung_id");

                entity.HasOne(d => d.Sachkontenueberleitung)
                    .WithMany(p => p.Sachkontenueberleitungseintrags)
                    .HasForeignKey(d => d.SachkontenueberleitungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkontenueberleitungseintrag_Sachkontenueberleitung");
            });

            modelBuilder.Entity<Sachkonto>(entity =>
            {
                entity.ToTable("Sachkonto");

                entity.HasIndex(e => new { e.SachkontengruppeId, e.SachkontenkategorieId, e.SachkontoId, e.Umsatzrelevant, e.Liquiditaetsrelevant, e.Hochrechnungsrelevant, e.GrundlageFuerGewerbesteuern, e.GrundlageFuerKoerperschaftssteuern, e.Aktiv }, "Wichtiges");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bearbeitungshinweis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bearbeitungshinweis")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FortschrittsanzeigeKategorieId).HasColumnName("fortschrittsanzeige_kategorieId");

                entity.Property(e => e.GrundlageFuerGewerbesteuern).HasColumnName("grundlageFuerGewerbesteuern");

                entity.Property(e => e.GrundlageFuerKoerperschaftssteuern).HasColumnName("grundlageFuerKoerperschaftssteuern");

                entity.Property(e => e.Hochrechnungsrelevant).HasColumnName("hochrechnungsrelevant");

                entity.Property(e => e.IstAfAkonto).HasColumnName("istAfAKonto");

                entity.Property(e => e.IstKampagnenKonto).HasColumnName("istKampagnenKonto");

                entity.Property(e => e.IstSopoKonto).HasColumnName("istSopoKonto");

                entity.Property(e => e.IstStandard).HasColumnName("istStandard");

                entity.Property(e => e.IstZuschussKonto).HasColumnName("istZuschussKonto");

                entity.Property(e => e.Liquiditaetsrelevant)
                    .IsRequired()
                    .HasColumnName("liquiditaetsrelevant")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Pflichtfeld).HasColumnName("pflichtfeld");

                entity.Property(e => e.PlanbilanzgegenkontoId).HasColumnName("planbilanzgegenkontoId");

                entity.Property(e => e.PlanbilanzkontoId).HasColumnName("planbilanzkontoId");

                entity.Property(e => e.SachkontengruppeId).HasColumnName("sachkontengruppeId");

                entity.Property(e => e.SachkontenkategorieId).HasColumnName("sachkontenkategorieId");

                entity.Property(e => e.Sachkontennummer).HasColumnName("sachkontennummer");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.Property(e => e.SteuernId).HasColumnName("steuernId");

                entity.Property(e => e.Umsatzrelevant).HasColumnName("umsatzrelevant");

                entity.Property(e => e.VorschlagswertSteigerung).HasColumnName("vorschlagswert_steigerung");

                entity.Property(e => e.ZeigeBearbeitungshinweis).HasColumnName("zeigeBearbeitungshinweis");

                entity.Property(e => e.ZumBuchenGesperrt).HasColumnName("zumBuchenGesperrt");

                entity.HasOne(d => d.FortschrittsanzeigeKategorie)
                    .WithMany(p => p.Sachkontos)
                    .HasForeignKey(d => d.FortschrittsanzeigeKategorieId)
                    .HasConstraintName("FK_Sachkonto_Fortschrittsanzeige_Kategorie");

                entity.HasOne(d => d.Planbilanzgegenkonto)
                    .WithMany(p => p.SachkontoPlanbilanzgegenkontos)
                    .HasForeignKey(d => d.PlanbilanzgegenkontoId)
                    .HasConstraintName("FK_Sachkonto_Planbilanzgegenkonto");

                entity.HasOne(d => d.Planbilanzkonto)
                    .WithMany(p => p.SachkontoPlanbilanzkontos)
                    .HasForeignKey(d => d.PlanbilanzkontoId)
                    .HasConstraintName("FK_Sachkonto_Planbilanzkonto");

                entity.HasOne(d => d.Sachkontengruppe)
                    .WithMany(p => p.Sachkontos)
                    .HasForeignKey(d => d.SachkontengruppeId)
                    .HasConstraintName("FK_Sachkonto_Sachkontengruppe");

                entity.HasOne(d => d.Sachkontenkategorie)
                    .WithMany(p => p.Sachkontos)
                    .HasForeignKey(d => d.SachkontenkategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkonto_Sachkontenkategorie");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.Sachkontos)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Sachkonto_Steuern");
            });

            modelBuilder.Entity<SachkontoGliederungsgruppeSummenzeile>(entity =>
            {
                entity.ToTable("SachkontoGliederungsgruppeSummenzeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HinterSachkontoGliederungsgruppeId).HasColumnName("hinterSachkontoGliederungsgruppe_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");

                entity.HasOne(d => d.HinterSachkontoGliederungsgruppe)
                    .WithMany(p => p.SachkontoGliederungsgruppeSummenzeiles)
                    .HasForeignKey(d => d.HinterSachkontoGliederungsgruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SachkontoGliederungsgruppeSummenzeile_SachkontenGliederungsgruppe");
            });

            modelBuilder.Entity<SachkontoProzentBetriebsstaette>(entity =>
            {
                entity.ToTable("Sachkonto_Prozent_Betriebsstaette");

                entity.HasIndex(e => new { e.SachkontoId, e.BetriebsstaetteId, e.AuslastungsartId, e.PflegestufeId, e.KostenstelleId, e.Prozentsatz, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsartId");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.PflegestufeId).HasColumnName("pflegestufeId");

                entity.Property(e => e.Prozentsatz).HasColumnName("prozentsatz");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.HasOne(d => d.Auslastungsart)
                    .WithMany(p => p.SachkontoProzentBetriebsstaettes)
                    .HasForeignKey(d => d.AuslastungsartId)
                    .HasConstraintName("FK_Sachkonto_Prozent_Betriebsstaette_Auslastungsart");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.SachkontoProzentBetriebsstaettes)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .HasConstraintName("FK_Sachkonto_Prozent_Betriebsstaette_Betriebsstaette");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.SachkontoProzentBetriebsstaettes)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Sachkonto_Prozent_Betriebsstaette_Kostenstelle");

                entity.HasOne(d => d.Pflegestufe)
                    .WithMany(p => p.SachkontoProzentBetriebsstaettes)
                    .HasForeignKey(d => d.PflegestufeId)
                    .HasConstraintName("FK_Sachkonto_Prozent_Betriebsstaette_Pflegestufe");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.SachkontoProzentBetriebsstaettes)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_Sachkonto_Prozent_Betriebsstaette_Sachkonto");
            });

            modelBuilder.Entity<SachkontoSachkontoGliederungsgruppe>(entity =>
            {
                entity.ToTable("Sachkonto_SachkontoGliederungsgruppe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SachkontenGliederungsgruppeId).HasColumnName("sachkontenGliederungsgruppe_id");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkonto_id");

                entity.HasOne(d => d.SachkontenGliederungsgruppe)
                    .WithMany(p => p.SachkontoSachkontoGliederungsgruppes)
                    .HasForeignKey(d => d.SachkontenGliederungsgruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkonto_SachkontoGliederungsgruppe_SachkontenGliederungsgruppe");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.SachkontoSachkontoGliederungsgruppes)
                    .HasForeignKey(d => d.SachkontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkonto_SachkontoGliederungsgruppe_Sachkonto");
            });

            modelBuilder.Entity<SachkostenVerteilungKst>(entity =>
            {
                entity.ToTable("SachkostenVerteilungKST");

                entity.HasIndex(e => new { e.SachkostenzeileId, e.ImportSachkostenId, e.KostenstelleId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ImportSachkostenId).HasColumnName("importSachkostenId");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.ProzentKostenstelle).HasColumnName("prozentKostenstelle");

                entity.Property(e => e.SachkostenzeileId).HasColumnName("sachkostenzeileId");

                entity.HasOne(d => d.ImportSachkosten)
                    .WithMany(p => p.SachkostenVerteilungKsts)
                    .HasForeignKey(d => d.ImportSachkostenId)
                    .HasConstraintName("FK_SachkostenVerteilungKST_ImportSachkosten");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.SachkostenVerteilungKsts)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_SachkostenVerteilungKST_Kostenstelle");

                entity.HasOne(d => d.Sachkostenzeile)
                    .WithMany(p => p.SachkostenVerteilungKsts)
                    .HasForeignKey(d => d.SachkostenzeileId)
                    .HasConstraintName("FK_SachkostenVerteilungKST_Sachkostenzeile");
            });

            modelBuilder.Entity<Sachkostenzeile>(entity =>
            {
                entity.ToTable("Sachkostenzeile");

                entity.HasIndex(e => new { e.KalkulationId, e.SachkontoId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.HochgerechneterLfdJahr).HasColumnName("hochgerechneterLfdJahr");

                entity.Property(e => e.IstSkalierenderWert).HasColumnName("istSkalierenderWert");

                entity.Property(e => e.IstVorjahrWert).HasColumnName("istVorjahrWert");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.Monatsgenau).HasColumnName("monatsgenau");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Nebenrechnung).HasColumnName("nebenrechnung");

                entity.Property(e => e.PlanApril).HasColumnName("planApril");

                entity.Property(e => e.PlanAugust).HasColumnName("planAugust");

                entity.Property(e => e.PlanDezember).HasColumnName("planDezember");

                entity.Property(e => e.PlanFebruar).HasColumnName("planFebruar");

                entity.Property(e => e.PlanJanuar).HasColumnName("planJanuar");

                entity.Property(e => e.PlanJuli).HasColumnName("planJuli");

                entity.Property(e => e.PlanJuni).HasColumnName("planJuni");

                entity.Property(e => e.PlanMaerz).HasColumnName("planMaerz");

                entity.Property(e => e.PlanMai).HasColumnName("planMai");

                entity.Property(e => e.PlanNovember).HasColumnName("planNovember");

                entity.Property(e => e.PlanOktober).HasColumnName("planOktober");

                entity.Property(e => e.PlanSeptember).HasColumnName("planSeptember");

                entity.Property(e => e.PlanWert).HasColumnName("planWert");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.Property(e => e.SkalierenderWert).HasColumnName("skalierenderWert");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Sachkostenzeiles)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkostenzeile_Kalkulation");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.Sachkostenzeiles)
                    .HasForeignKey(d => d.SachkontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sachkostenzeile_Sachkonto");
            });

            modelBuilder.Entity<Schnittstellenart>(entity =>
            {
                entity.ToTable("Schnittstellenart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Klassenname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("klassenname");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.WirdAutomUebertragen).HasColumnName("wirdAutomUebertragen");
            });

            modelBuilder.Entity<Schnittstelleneinstellung>(entity =>
            {
                entity.ToTable("Schnittstelleneinstellung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Schnittstellenkonfiguration>(entity =>
            {
                entity.ToTable("Schnittstellenkonfiguration");

                entity.HasIndex(e => new { e.SchnittstelleneinstellungId, e.SchnittstellenartId, e.Eintragsname }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Eintragsname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eintragsname");

                entity.Property(e => e.Eintragswert)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("eintragswert");

                entity.Property(e => e.SchnittstellenartId).HasColumnName("schnittstellenart_id");

                entity.Property(e => e.SchnittstelleneinstellungId).HasColumnName("schnittstelleneinstellung_id");

                entity.HasOne(d => d.Schnittstellenart)
                    .WithMany(p => p.Schnittstellenkonfigurations)
                    .HasForeignKey(d => d.SchnittstellenartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schnittstellenkonfiguration_Schnittstellenart");

                entity.HasOne(d => d.Schnittstelleneinstellung)
                    .WithMany(p => p.Schnittstellenkonfigurations)
                    .HasForeignKey(d => d.SchnittstelleneinstellungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schnittstellenkonfiguration_Schnittstelleneinstellung");
            });

            modelBuilder.Entity<Schwund>(entity =>
            {
                entity.ToTable("Schwund");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");
            });

            modelBuilder.Entity<SchwundLagerArtikel>(entity =>
            {
                entity.ToTable("Schwund_Lager_Artikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerArtikelId).HasColumnName("lager_ArtikelId");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.SchwundId).HasColumnName("schwundId");

                entity.HasOne(d => d.LagerArtikel)
                    .WithMany(p => p.SchwundLagerArtikels)
                    .HasForeignKey(d => d.LagerArtikelId)
                    .HasConstraintName("FK_Schwund_Lager_Artikel_Schwund_Lager_Artikel");

                entity.HasOne(d => d.Schwund)
                    .WithMany(p => p.SchwundLagerArtikels)
                    .HasForeignKey(d => d.SchwundId)
                    .HasConstraintName("FK_Schwund_Lager_Artikel_Schwund");
            });

            modelBuilder.Entity<Segment>(entity =>
            {
                entity.ToTable("Segment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SeitenElement>(entity =>
            {
                entity.ToTable("SeitenElement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UcName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ucName");
            });

            modelBuilder.Entity<Sonderposten>(entity =>
            {
                entity.ToTable("Sonderposten");

                entity.HasIndex(e => e.AfaZeileId, "IDX_Sonderposten_AfaZeile_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AfaZeileId).HasColumnName("afaZeileId");

                entity.Property(e => e.Aufloesung).HasColumnName("aufloesung");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.SachkontoAufwZufuehrungId).HasColumnName("sachkontoAufwZufuehrungId");

                entity.Property(e => e.SachkontoErtrFoerderungId).HasColumnName("sachkontoErtrFoerderungId");

                entity.Property(e => e.SachkontoId).HasColumnName("sachkontoId");

                entity.Property(e => e.StandAnfangJahr).HasColumnName("standAnfangJahr");

                entity.Property(e => e.Ursprungsbetrag).HasColumnName("ursprungsbetrag");

                entity.Property(e => e.Zufuehrung).HasColumnName("zufuehrung");

                entity.Property(e => e.Zuschussgeber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("zuschussgeber");

                entity.HasOne(d => d.AfaZeile)
                    .WithMany(p => p.Sonderpostens)
                    .HasForeignKey(d => d.AfaZeileId)
                    .HasConstraintName("FK_Sonderposten_AfAzeile");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Sonderpostens)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Sonderposten_Sonderposten");

                entity.HasOne(d => d.SachkontoAufwZufuehrung)
                    .WithMany(p => p.SonderpostenSachkontoAufwZufuehrungs)
                    .HasForeignKey(d => d.SachkontoAufwZufuehrungId)
                    .HasConstraintName("FK_Sonderposten_SachkontoAufwZufuehrung");

                entity.HasOne(d => d.SachkontoErtrFoerderung)
                    .WithMany(p => p.SonderpostenSachkontoErtrFoerderungs)
                    .HasForeignKey(d => d.SachkontoErtrFoerderungId)
                    .HasConstraintName("FK_Sonderposten_SachkontoErtrFoerderung");

                entity.HasOne(d => d.Sachkonto)
                    .WithMany(p => p.SonderpostenSachkontos)
                    .HasForeignKey(d => d.SachkontoId)
                    .HasConstraintName("FK_Sonderposten_Sachkonto");
            });

            modelBuilder.Entity<Sonderveranstaltung>(entity =>
            {
                entity.ToTable("Sonderveranstaltung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdresseId).HasColumnName("adresseId");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AnzahlPersonen).HasColumnName("anzahlPersonen");

                entity.Property(e => e.Ausrichtungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("ausrichtungsdatum");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Deko)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("deko");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Thema)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("thema");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponenteId");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.Sonderveranstaltungs)
                    .HasForeignKey(d => d.AdresseId)
                    .HasConstraintName("FK_Sonderveranstaltung_Adresse");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.Sonderveranstaltungs)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .HasConstraintName("FK_Sonderveranstaltung_Warenwirtschaftskomponente");
            });

            modelBuilder.Entity<SonderveranstaltungArtikel>(entity =>
            {
                entity.ToTable("Sonderveranstaltung_Artikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.Aufschlag).HasColumnName("aufschlag");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.SonderveranstaltungId).HasColumnName("sonderveranstaltungId");

                entity.HasOne(d => d.Artikel)
                    .WithMany(p => p.SonderveranstaltungArtikels)
                    .HasForeignKey(d => d.ArtikelId)
                    .HasConstraintName("FK_Sonderveranstaltung_Artikel_Artikel");

                entity.HasOne(d => d.Sonderveranstaltung)
                    .WithMany(p => p.SonderveranstaltungArtikels)
                    .HasForeignKey(d => d.SonderveranstaltungId)
                    .HasConstraintName("FK_Sonderveranstaltung_Artikel_Sonderveranstaltung");
            });

            modelBuilder.Entity<SonderveranstaltungPersonal>(entity =>
            {
                entity.ToTable("Sonderveranstaltung_Personal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aufschlag).HasColumnName("aufschlag");

                entity.Property(e => e.Bis)
                    .HasColumnType("datetime")
                    .HasColumnName("bis");

                entity.Property(e => e.PersonalId).HasColumnName("personalId");

                entity.Property(e => e.SonderveranstaltungId).HasColumnName("sonderveranstaltungId");

                entity.Property(e => e.Von)
                    .HasColumnType("datetime")
                    .HasColumnName("von");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.SonderveranstaltungPersonals)
                    .HasForeignKey(d => d.PersonalId)
                    .HasConstraintName("FK_Sonderveranstaltung_Personal_Personal");

                entity.HasOne(d => d.Sonderveranstaltung)
                    .WithMany(p => p.SonderveranstaltungPersonals)
                    .HasForeignKey(d => d.SonderveranstaltungId)
                    .HasConstraintName("FK_Sonderveranstaltung_Personal_Sonderveranstaltung");
            });

            modelBuilder.Entity<Sonderzahlungen>(entity =>
            {
                entity.ToTable("Sonderzahlungen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbgrenzungskontoId).HasColumnName("abgrenzungskonto_id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Auswerten).HasColumnName("auswerten");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Sortierung).HasColumnName("sortierung");

                entity.Property(e => e.SvBefreit).HasColumnName("svBefreit");

                entity.HasOne(d => d.Abgrenzungskonto)
                    .WithMany(p => p.Sonderzahlungens)
                    .HasForeignKey(d => d.AbgrenzungskontoId)
                    .HasConstraintName("FK_Sonderzahlungen_Sachkonto");
            });

            modelBuilder.Entity<Sperrobjekt>(entity =>
            {
                entity.ToTable("Sperrobjekt");

                entity.HasIndex(e => new { e.BenutzerId, e.ObjektHash, e.GesperrtSeit }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.GesperrtSeit)
                    .HasColumnType("datetime")
                    .HasColumnName("gesperrtSeit");

                entity.Property(e => e.ObjektHash)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("objektHash");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Sperrobjekts)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObjektSperre_Benutzer");
            });

            modelBuilder.Entity<Staffelprei>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nettopreis).HasColumnName("nettopreis");

                entity.Property(e => e.PreisId).HasColumnName("preisId");

                entity.Property(e => e.VonMenge).HasColumnName("vonMenge");

                entity.HasOne(d => d.Preis)
                    .WithMany(p => p.Staffelpreis)
                    .HasForeignKey(d => d.PreisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staffelpreis_Preis");
            });

            modelBuilder.Entity<Standardkommunikationskanal>(entity =>
            {
                entity.ToTable("Standardkommunikationskanal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KlassenTyp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("klassenTyp");

                entity.Property(e => e.ObjektId).HasColumnName("objektId");
            });

            modelBuilder.Entity<Stellenbeschreibung>(entity =>
            {
                entity.ToTable("Stellenbeschreibung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Steuern>(entity =>
            {
                entity.ToTable("Steuern");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kennzeichen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kennzeichen");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Prozent).HasColumnName("prozent");

                entity.Property(e => e.Standardsatz).HasColumnName("standardsatz");
            });

            modelBuilder.Entity<StrategischeKalkulation>(entity =>
            {
                entity.ToTable("StrategischeKalkulation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BasisKonsolidierung).HasColumnName("basis_konsolidierung");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaette_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.KalkulationsartId).HasColumnName("kalkulationsart_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Notiz)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("notiz");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.StrategischeKalkulations)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StrategischeKalkulation_Benutzer");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.StrategischeKalkulations)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StrategischeKalkulation_Betriebsstaette");

                entity.HasOne(d => d.Kalkulationsart)
                    .WithMany(p => p.StrategischeKalkulations)
                    .HasForeignKey(d => d.KalkulationsartId)
                    .HasConstraintName("FK_StrategischeKalkulation_Kalkulationsart");
            });

            modelBuilder.Entity<StrategischeKalkulationBrotkruemeldefinition>(entity =>
            {
                entity.ToTable("StrategischeKalkulationBrotkruemeldefinition");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.KalkulationBrotkruemeldefinitionId).HasColumnName("kalkulationBrotkruemeldefinition_id");

                entity.Property(e => e.Reihenfolge).HasColumnName("reihenfolge");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.KalkulationBrotkruemeldefinition)
                    .WithMany(p => p.StrategischeKalkulationBrotkruemeldefinitions)
                    .HasForeignKey(d => d.KalkulationBrotkruemeldefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StrategischeKalkulationBrotkruemeldefinition_KalkulationBrotkruemeldefinition");
            });

            modelBuilder.Entity<StrategischeKalkulationKalkulation>(entity =>
            {
                entity.ToTable("StrategischeKalkulation_Kalkulation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.StrategischeKalkulationId).HasColumnName("strategischeKalkulation_id");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.StrategischeKalkulationKalkulations)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StrategischeKalkulation_Kalkulation_Kalkulation");

                entity.HasOne(d => d.StrategischeKalkulation)
                    .WithMany(p => p.StrategischeKalkulationKalkulations)
                    .HasForeignKey(d => d.StrategischeKalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StrategischeKalkulation_Kalkulation_StrategischeKalkulation");
            });

            modelBuilder.Entity<StrategischeKalkulationKonsolidierung>(entity =>
            {
                entity.ToTable("StrategischeKalkulation_Konsolidierung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.StrategischeKalkulationId).HasColumnName("strategischeKalkulation_id");

                entity.HasOne(d => d.Konsolidierung)
                    .WithMany(p => p.StrategischeKalkulationKonsolidierungs)
                    .HasForeignKey(d => d.KonsolidierungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StrategischeKalkulation_Konsolidierung_Konsolidierung");

                entity.HasOne(d => d.StrategischeKalkulation)
                    .WithMany(p => p.StrategischeKalkulationKonsolidierungs)
                    .HasForeignKey(d => d.StrategischeKalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StrategischeKalkulation_Konsolidierung_StrategischeKalkulation_Konsolidierung");
            });

            modelBuilder.Entity<Tarif>(entity =>
            {
                entity.ToTable("Tarif");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummer");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Tarifs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tarif_Benutzer");
            });

            modelBuilder.Entity<TarifBerufsgruppe>(entity =>
            {
                entity.ToTable("Tarif_Berufsgruppe");

                entity.HasIndex(e => new { e.TarifId, e.BerufsgruppeId, e.GueltigAb }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppeId");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigAb");

                entity.Property(e => e.PraemieFix).HasColumnName("praemieFix");

                entity.Property(e => e.PraemieStattWeihnachtsgeld).HasColumnName("praemieStattWeihnachtsgeld");

                entity.Property(e => e.SonderzahlungId).HasColumnName("sonderzahlungId");

                entity.Property(e => e.TarifId).HasColumnName("tarif_id");

                entity.Property(e => e.Weihnachtsgeldsatz).HasColumnName("weihnachtsgeldsatz");

                entity.HasOne(d => d.Berufsgruppe)
                    .WithMany(p => p.TarifBerufsgruppes)
                    .HasForeignKey(d => d.BerufsgruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Betriebsstaette_Berufsgruppe_Berufsgruppe");

                entity.HasOne(d => d.Sonderzahlung)
                    .WithMany(p => p.TarifBerufsgruppes)
                    .HasForeignKey(d => d.SonderzahlungId)
                    .HasConstraintName("FK_Tarif_Berufsgruppe_Sonderzahlungen");

                entity.HasOne(d => d.Tarif)
                    .WithMany(p => p.TarifBerufsgruppes)
                    .HasForeignKey(d => d.TarifId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tarif_Berufsgruppe_Tarif");
            });

            modelBuilder.Entity<TarifPersonalabgaben>(entity =>
            {
                entity.ToTable("Tarif_Personalabgaben");

                entity.HasIndex(e => new { e.TarifId, e.GueltigVon, e.GueltigBis, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Altersversorgung).HasColumnName("altersversorgung");

                entity.Property(e => e.AnteilAv).HasColumnName("anteilAV");

                entity.Property(e => e.AnteilBg).HasColumnName("anteilBG");

                entity.Property(e => e.AnteilFp).HasColumnName("anteilFP");

                entity.Property(e => e.AnteilHpv).HasColumnName("anteilHPV");

                entity.Property(e => e.AnteilKv).HasColumnName("anteilKV");

                entity.Property(e => e.AnteilPv).HasColumnName("anteilPV");

                entity.Property(e => e.AnteilRv).HasColumnName("anteilRV");

                entity.Property(e => e.AnteilSbp).HasColumnName("anteilSBP");

                entity.Property(e => e.Beihilfe).HasColumnName("beihilfe");

                entity.Property(e => e.Fallpreisatz).HasColumnName("fallpreisatz");

                entity.Property(e => e.GfbKvpauschal).HasColumnName("gfbKVpauschal");

                entity.Property(e => e.GfbLspauschal).HasColumnName("gfbLSpauschal");

                entity.Property(e => e.GfbRvpauschal).HasColumnName("gfbRVpauschal");

                entity.Property(e => e.GfbUmlageAufwendungsAusglG).HasColumnName("gfbUmlageAufwendungsAusglG");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.LohnsteigerungGfb).HasColumnName("lohnsteigerung_gfb");

                entity.Property(e => e.LohnsteigerungSonstige).HasColumnName("lohnsteigerung_sonstige");

                entity.Property(e => e.SvGfb).HasColumnName("sv_gfb");

                entity.Property(e => e.SvSonstige).HasColumnName("sv_sonstige");

                entity.Property(e => e.TarifId).HasColumnName("tarif_id");

                entity.Property(e => e.WoechentlicheArbeitszeit).HasColumnName("woechentlicheArbeitszeit");

                entity.HasOne(d => d.Tarif)
                    .WithMany(p => p.TarifPersonalabgabens)
                    .HasForeignKey(d => d.TarifId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tarif_Personalabgaben_Tarif");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("duedate");

                entity.Property(e => e.Dueuser).HasColumnName("dueuser");

                entity.Property(e => e.Senddate)
                    .HasColumnType("datetime")
                    .HasColumnName("senddate");

                entity.Property(e => e.Senduser).HasColumnName("senduser");

                entity.Property(e => e.Task1)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("task");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.TypeString)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("type_string");

                entity.HasOne(d => d.DueuserNavigation)
                    .WithMany(p => p.TaskDueuserNavigations)
                    .HasForeignKey(d => d.Dueuser)
                    .HasConstraintName("FK_Tasks_Benutzer");

                entity.HasOne(d => d.SenduserNavigation)
                    .WithMany(p => p.TaskSenduserNavigations)
                    .HasForeignKey(d => d.Senduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tasks_Benutzer1");
            });

            modelBuilder.Entity<Telefonart>(entity =>
            {
                entity.ToTable("Telefonart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Telefonnummer>(entity =>
            {
                entity.ToTable("Telefonnummer");

                entity.HasIndex(e => new { e.KontaktinformationId, e.TelefonartId }, "ArtKontaktinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KontaktinformationId).HasColumnName("kontaktinformation_id");

                entity.Property(e => e.Nummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummer");

                entity.Property(e => e.TelefonartId).HasColumnName("telefonart_id");

                entity.HasOne(d => d.Kontaktinformation)
                    .WithMany(p => p.Telefonnummers)
                    .HasForeignKey(d => d.KontaktinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Telefonnummer_Kontaktinformation");

                entity.HasOne(d => d.Telefonart)
                    .WithMany(p => p.Telefonnummers)
                    .HasForeignKey(d => d.TelefonartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Telefonnummer_Telefonart");
            });

            modelBuilder.Entity<Traeger>(entity =>
            {
                entity.ToTable("Traeger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Transaktion>(entity =>
            {
                entity.ToTable("Transaktion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Kontennummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kontennummer");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("Transfer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Art).HasColumnName("art");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.TransferGrundId).HasColumnName("transferGrundId");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transfer_Benutzer");

                entity.HasOne(d => d.TransferGrund)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.TransferGrundId)
                    .HasConstraintName("FK_Transfer_TransferGrund");
            });

            modelBuilder.Entity<TransferArtikel>(entity =>
            {
                entity.ToTable("Transfer_Artikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerArtikelId).HasColumnName("lagerArtikelId");

                entity.Property(e => e.LagerZielId).HasColumnName("lagerZielId");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.Preis).HasColumnName("preis");

                entity.Property(e => e.SteuernId).HasColumnName("steuernId");

                entity.Property(e => e.TransferId).HasColumnName("transferId");

                entity.HasOne(d => d.LagerArtikel)
                    .WithMany(p => p.TransferArtikels)
                    .HasForeignKey(d => d.LagerArtikelId)
                    .HasConstraintName("FK_Transfer_Artikel_Lager_Artikel");

                entity.HasOne(d => d.LagerZiel)
                    .WithMany(p => p.TransferArtikels)
                    .HasForeignKey(d => d.LagerZielId)
                    .HasConstraintName("FK_Transfer_Artikel_Lager");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.TransferArtikels)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Transfer_Artikel_Steuern");

                entity.HasOne(d => d.Transfer)
                    .WithMany(p => p.TransferArtikels)
                    .HasForeignKey(d => d.TransferId)
                    .HasConstraintName("FK_Transfer_Artikel_Transfer");
            });

            modelBuilder.Entity<TransferGrund>(entity =>
            {
                entity.ToTable("TransferGrund");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TransferWarenwirtschaftskomponente>(entity =>
            {
                entity.ToTable("Transfer_Warenwirtschaftskomponente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TransferId).HasColumnName("transferId");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponenteId");

                entity.HasOne(d => d.Transfer)
                    .WithMany(p => p.TransferWarenwirtschaftskomponentes)
                    .HasForeignKey(d => d.TransferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transfer_Warenwirtschaftskomponente_Transfer");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.TransferWarenwirtschaftskomponentes)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transfer_Warenwirtschaftskomponente_Warenwirtschaftskomponente");
            });

            modelBuilder.Entity<Typ>(entity =>
            {
                entity.ToTable("Typ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abkuerzung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("abkuerzung");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Umlagekostenstelle>(entity =>
            {
                entity.ToTable("Umlagekostenstelle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.Prozent).HasColumnName("prozent");

                entity.Property(e => e.UKostenstelleId).HasColumnName("uKostenstelleId");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.UmlagekostenstelleKostenstelles)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Umlagekostenstelle_Kostenstelle");

                entity.HasOne(d => d.UKostenstelle)
                    .WithMany(p => p.UmlagekostenstelleUKostenstelles)
                    .HasForeignKey(d => d.UKostenstelleId)
                    .HasConstraintName("FK_Umlagekostenstelle_UKostenstelle");
            });

            modelBuilder.Entity<Urflaechenart>(entity =>
            {
                entity.ToTable("URFlaechenart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Url>(entity =>
            {
                entity.ToTable("URL");

                entity.HasIndex(e => new { e.KontaktinformationId, e.UrlartId }, "ArtUndKontaktInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KontaktinformationId).HasColumnName("kontaktinformation_id");

                entity.Property(e => e.Url1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.UrlartId).HasColumnName("urlart_id");

                entity.HasOne(d => d.Kontaktinformation)
                    .WithMany(p => p.Urls)
                    .HasForeignKey(d => d.KontaktinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Url_Kontaktinformation");

                entity.HasOne(d => d.Urlart)
                    .WithMany(p => p.Urls)
                    .HasForeignKey(d => d.UrlartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Url_UrlArt");
            });

            modelBuilder.Entity<Urlart>(entity =>
            {
                entity.ToTable("URLArt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Urlaub>(entity =>
            {
                entity.ToTable("Urlaub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.UrlaubsartId).HasColumnName("urlaubsart_id");

                entity.Property(e => e.UrlaubsinformationId).HasColumnName("urlaubsinformation_id");

                entity.Property(e => e.VerbrauchteUrlaubstage).HasColumnName("verbrauchteUrlaubstage");

                entity.HasOne(d => d.Urlaubsart)
                    .WithMany(p => p.Urlaubs)
                    .HasForeignKey(d => d.UrlaubsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Urlaub_Urlaubsart");

                entity.HasOne(d => d.Urlaubsinformation)
                    .WithMany(p => p.Urlaubs)
                    .HasForeignKey(d => d.UrlaubsinformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Urlaub_Urlaubsinformation");
            });

            modelBuilder.Entity<Urlaubsart>(entity =>
            {
                entity.ToTable("Urlaubsart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Urlaubsinformation>(entity =>
            {
                entity.ToTable("Urlaubsinformation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnzahlUrlaubstage).HasColumnName("anzahlUrlaubstage");

                entity.Property(e => e.VertragsinformationId).HasColumnName("vertragsinformation_id");
            });

            modelBuilder.Entity<Urleistungswerte>(entity =>
            {
                entity.ToTable("URLeistungswerte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dienstag).HasColumnName("dienstag");

                entity.Property(e => e.Donnerstag).HasColumnName("donnerstag");

                entity.Property(e => e.Freitag).HasColumnName("freitag");

                entity.Property(e => e.Mittwoch).HasColumnName("mittwoch");

                entity.Property(e => e.Montag).HasColumnName("montag");

                entity.Property(e => e.Samstag).HasColumnName("samstag");

                entity.Property(e => e.Sonntag).HasColumnName("sonntag");
            });

            modelBuilder.Entity<Urraum>(entity =>
            {
                entity.ToTable("URRaum");

                entity.HasIndex(e => new { e.Id, e.KalkulationId, e.URraumnutzgruppeKalkulationId, e.RhythmusId }, "Wichtiges");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Allgemeinflaeche)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("allgemeinflaeche");

                entity.Property(e => e.Bemerkungen)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("bemerkungen");

                entity.Property(e => e.Bereich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bereich");

                entity.Property(e => e.DinnormId).HasColumnName("dinnorm_id");

                entity.Property(e => e.Etage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("etage");

                entity.Property(e => e.Flaeche).HasColumnName("flaeche");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Raumnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("raumnummer");

                entity.Property(e => e.Reinigungskraft)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("reinigungskraft");

                entity.Property(e => e.RhythmusId).HasColumnName("rhythmusId");

                entity.Property(e => e.Schluessel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("schluessel");

                entity.Property(e => e.URraumnutzgruppeKalkulationId).HasColumnName("uRRaumnutzgruppe_Kalkulation_id");

                entity.Property(e => e.UrflaechenartId).HasColumnName("urflaechenart_id");

                entity.HasOne(d => d.Dinnorm)
                    .WithMany(p => p.Urraums)
                    .HasForeignKey(d => d.DinnormId)
                    .HasConstraintName("FK_URRaum_DINNorm");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Urraums)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaum_Kalkulation");

                entity.HasOne(d => d.Rhythmus)
                    .WithMany(p => p.Urraums)
                    .HasForeignKey(d => d.RhythmusId)
                    .HasConstraintName("FK_URRaum_Rhythmus");

                entity.HasOne(d => d.URraumnutzgruppeKalkulation)
                    .WithMany(p => p.Urraums)
                    .HasForeignKey(d => d.URraumnutzgruppeKalkulationId)
                    .HasConstraintName("FK_URRaum_URRaumnutzgruppe_Kalkulation");

                entity.HasOne(d => d.Urflaechenart)
                    .WithMany(p => p.Urraums)
                    .HasForeignKey(d => d.UrflaechenartId)
                    .HasConstraintName("FK_URRaum_URFlaechenart");
            });

            modelBuilder.Entity<UrraumUrreinigungsart>(entity =>
            {
                entity.ToTable("URRaum_URReinigungsart");

                entity.HasIndex(e => new { e.UrRaumId, e.URreinigungsartId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.Tag).HasColumnName("tag");

                entity.Property(e => e.URreinigungsartId).HasColumnName("uRReinigungsart_id");

                entity.Property(e => e.UrRaumId).HasColumnName("urRaum_Id");

                entity.HasOne(d => d.URreinigungsart)
                    .WithMany(p => p.UrraumUrreinigungsarts)
                    .HasForeignKey(d => d.URreinigungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRraum_URReinigungsart_URRaumnutzgruppe_Kalkulation_URReinigungsart");

                entity.HasOne(d => d.UrRaum)
                    .WithMany(p => p.UrraumUrreinigungsarts)
                    .HasForeignKey(d => d.UrRaumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRraum_URReinigungsart_URRaum");
            });

            modelBuilder.Entity<Urraumnutzgruppe>(entity =>
            {
                entity.ToTable("URRaumnutzgruppe");

                entity.HasIndex(e => new { e.UrRaumnutzkategorieId, e.URleistungswerteId, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.URleistungswerteId).HasColumnName("uRLeistungswerte_id");

                entity.Property(e => e.UrRaumnutzkategorieId).HasColumnName("urRaumnutzkategorieId");

                entity.HasOne(d => d.URleistungswerte)
                    .WithMany(p => p.Urraumnutzgruppes)
                    .HasForeignKey(d => d.URleistungswerteId)
                    .HasConstraintName("FK_URRaumnutzgruppe_UREinheiten");

                entity.HasOne(d => d.UrRaumnutzkategorie)
                    .WithMany(p => p.Urraumnutzgruppes)
                    .HasForeignKey(d => d.UrRaumnutzkategorieId)
                    .HasConstraintName("FK_URRaumnutzgruppe_URRaumnutzkategorie");
            });

            modelBuilder.Entity<UrraumnutzgruppeKalkulation>(entity =>
            {
                entity.ToTable("URRaumnutzgruppe_Kalkulation");

                entity.HasIndex(e => new { e.URraumnutzgruppeId, e.URraumnutzkategorieKalkulationId, e.URleistungswerteId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.URleistungswerteId).HasColumnName("uRLeistungswerte_id");

                entity.Property(e => e.URraumnutzgruppeId).HasColumnName("uRRaumnutzgruppe_id");

                entity.Property(e => e.URraumnutzkategorieKalkulationId).HasColumnName("uRRaumnutzkategorie_Kalkulation_id");

                entity.HasOne(d => d.URleistungswerte)
                    .WithMany(p => p.UrraumnutzgruppeKalkulations)
                    .HasForeignKey(d => d.URleistungswerteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaumnutzgruppe_Kalkulation_URLeistungswerte");

                entity.HasOne(d => d.URraumnutzgruppe)
                    .WithMany(p => p.UrraumnutzgruppeKalkulations)
                    .HasForeignKey(d => d.URraumnutzgruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaumnutzgruppe_Kalkulation_URRaumnutzgruppe");

                entity.HasOne(d => d.URraumnutzkategorieKalkulation)
                    .WithMany(p => p.UrraumnutzgruppeKalkulations)
                    .HasForeignKey(d => d.URraumnutzkategorieKalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaumnutzgruppe_Kalkulation_URRaumnutzkategorie_Kalkulation");
            });

            modelBuilder.Entity<UrraumnutzgruppeKalkulationUrreinigungsart>(entity =>
            {
                entity.ToTable("URRaumnutzgruppe_Kalkulation_URReinigungsart");

                entity.HasIndex(e => new { e.URreinigungsartId, e.URraumnutzgruppeKalkulationId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Faktor).HasColumnName("faktor");

                entity.Property(e => e.URraumnutzgruppeKalkulationId).HasColumnName("uRRaumnutzgruppe_Kalkulation_id");

                entity.Property(e => e.URreinigungsartId).HasColumnName("uRReinigungsart_id");

                entity.HasOne(d => d.URraumnutzgruppeKalkulation)
                    .WithMany(p => p.UrraumnutzgruppeKalkulationUrreinigungsarts)
                    .HasForeignKey(d => d.URraumnutzgruppeKalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaumnutzgruppe_Kalkulation_URReinigungsart_URRaumnutzgruppe_Kalkulation");

                entity.HasOne(d => d.URreinigungsart)
                    .WithMany(p => p.UrraumnutzgruppeKalkulationUrreinigungsarts)
                    .HasForeignKey(d => d.URreinigungsartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaumnutzgruppe_Kalkulation_URReinigungsart_URReinigungsart");
            });

            modelBuilder.Entity<Urraumnutzkategorie>(entity =>
            {
                entity.ToTable("URRaumnutzkategorie");

                entity.HasIndex(e => e.Aktiv, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Standard).HasColumnName("standard");
            });

            modelBuilder.Entity<UrraumnutzkategorieKalkulation>(entity =>
            {
                entity.ToTable("URRaumnutzkategorie_Kalkulation");

                entity.HasIndex(e => new { e.KalkulationId, e.URraumnutzkategorieId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.Faktor).HasColumnName("faktor");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulation_id");

                entity.Property(e => e.URraumnutzkategorieId).HasColumnName("uRRaumnutzkategorie_id");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.UrraumnutzkategorieKalkulations)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaumnutzkategorie_Kalkulation_Kalkulation");

                entity.HasOne(d => d.URraumnutzkategorie)
                    .WithMany(p => p.UrraumnutzkategorieKalkulations)
                    .HasForeignKey(d => d.URraumnutzkategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_URRaumnutzkategorie_Kalkulation_URRaumnutzkategorie");
            });

            modelBuilder.Entity<Urreinigungsart>(entity =>
            {
                entity.ToTable("URReinigungsart");

                entity.HasIndex(e => e.Aktiv, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Faktor).HasColumnName("faktor");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kuerzel");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Veranstaltung>(entity =>
            {
                entity.ToTable("Veranstaltung");

                entity.HasIndex(e => new { e.ArbeitskreisId, e.KundeLeiterId, e.KundeHotelId, e.KundeTagungsortId }, "WeitereFremdschluessel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnzahlTeilnehmer).HasColumnName("anzahlTeilnehmer");

                entity.Property(e => e.ArbeitskreisId).HasColumnName("arbeitskreis_id");

                entity.Property(e => e.BeginDatum)
                    .HasColumnType("datetime")
                    .HasColumnName("beginDatum");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Enddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("enddatum");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.KannVeroeffentlichtWerden).HasColumnName("kannVeroeffentlichtWerden");

                entity.Property(e => e.KundeHotelId).HasColumnName("kundeHotel_id");

                entity.Property(e => e.KundeLeiterId).HasColumnName("kundeLeiter_id");

                entity.Property(e => e.KundeTagungsortId).HasColumnName("kundeTagungsort_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RaumBeschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("raumBeschreibung");

                entity.Property(e => e.Raumnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("raumnummer");

                entity.HasOne(d => d.Arbeitskreis)
                    .WithMany(p => p.Veranstaltungs)
                    .HasForeignKey(d => d.ArbeitskreisId)
                    .HasConstraintName("FK_Veranstaltung_Arbeitskreis");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Veranstaltungs)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veranstaltung_Benutzer");

                entity.HasOne(d => d.KundeHotel)
                    .WithMany(p => p.VeranstaltungKundeHotels)
                    .HasForeignKey(d => d.KundeHotelId)
                    .HasConstraintName("FK_Veranstaltung_Kunde");

                entity.HasOne(d => d.KundeLeiter)
                    .WithMany(p => p.VeranstaltungKundeLeiters)
                    .HasForeignKey(d => d.KundeLeiterId)
                    .HasConstraintName("FK_Veranstaltung_Kunde1");

                entity.HasOne(d => d.KundeTagungsort)
                    .WithMany(p => p.VeranstaltungKundeTagungsorts)
                    .HasForeignKey(d => d.KundeTagungsortId)
                    .HasConstraintName("FK_Veranstaltung_Kunde2");
            });

            modelBuilder.Entity<VeranstaltungKunde>(entity =>
            {
                entity.ToTable("Veranstaltung_Kunde");

                entity.HasIndex(e => new { e.KundeId, e.VeranstaltungId, e.VeranstaltungteilnehmerartId }, "Restlichen Fremdschluessel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.VeranstaltungId).HasColumnName("veranstaltung_id");

                entity.Property(e => e.VeranstaltungteilnehmerartId).HasColumnName("veranstaltungteilnehmerart_id");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.VeranstaltungKundes)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veranstaltung_Kunde_Kunde");

                entity.HasOne(d => d.Veranstaltung)
                    .WithMany(p => p.VeranstaltungKundes)
                    .HasForeignKey(d => d.VeranstaltungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veranstaltung_Kunde_Veranstaltung");

                entity.HasOne(d => d.Veranstaltungteilnehmerart)
                    .WithMany(p => p.VeranstaltungKundes)
                    .HasForeignKey(d => d.VeranstaltungteilnehmerartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veranstaltung_Kunde_Veranstaltungsteilnehmerart");
            });

            modelBuilder.Entity<Veranstaltungsteilnehmerart>(entity =>
            {
                entity.ToTable("Veranstaltungsteilnehmerart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Verguetungsart>(entity =>
            {
                entity.ToTable("Verguetungsart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Verguetungsinformation>(entity =>
            {
                entity.ToTable("Verguetungsinformation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gehaltsgrenze).HasColumnName("gehaltsgrenze");

                entity.Property(e => e.Mindestgehalt).HasColumnName("mindestgehalt");

                entity.Property(e => e.Plangehalt).HasColumnName("plangehalt");

                entity.Property(e => e.VertragsinformationId).HasColumnName("vertragsinformation_id");

                entity.Property(e => e.Wertguthabenvereinbarung).HasColumnName("wertguthabenvereinbarung");
            });

            modelBuilder.Entity<Verleihartikel>(entity =>
            {
                entity.ToTable("Verleihartikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.VerleihartikelkategorieId).HasColumnName("verleihartikelkategorie_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Verleihartikels)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Verleihartikel_Benutzer");

                entity.HasOne(d => d.Verleihartikelkategorie)
                    .WithMany(p => p.Verleihartikels)
                    .HasForeignKey(d => d.VerleihartikelkategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Verleihartikel_Verleihartikelkategorie");
            });

            modelBuilder.Entity<Verleihartikelkategorie>(entity =>
            {
                entity.ToTable("Verleihartikelkategorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Verprobungsfaktor>(entity =>
            {
                entity.ToTable("Verprobungsfaktor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutomatischeBerechnung).HasColumnName("automatischeBerechnung");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KapaFaktor)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("kapaFaktor");
            });

            modelBuilder.Entity<Verteiler>(entity =>
            {
                entity.ToTable("Verteiler");

                entity.HasIndex(e => new { e.BenutzerId, e.BenutzerUebersichtId, e.Aktiv }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BenutzerUebersichtId).HasColumnName("benutzerUebersicht_id");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Verteilers)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_Benutzer");

                entity.HasOne(d => d.BenutzerUebersicht)
                    .WithMany(p => p.Verteilers)
                    .HasForeignKey(d => d.BenutzerUebersichtId)
                    .HasConstraintName("FK_Table_1_BenutzerUebersicht");
            });

            modelBuilder.Entity<VerteilerKunde>(entity =>
            {
                entity.ToTable("Verteiler_Kunde");

                entity.HasIndex(e => new { e.VerteilerId, e.KundeId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.VerteilerId).HasColumnName("verteiler_id");

                entity.HasOne(d => d.Kunde)
                    .WithMany(p => p.VerteilerKundes)
                    .HasForeignKey(d => d.KundeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Verteiler_Kunde_Kunde");

                entity.HasOne(d => d.Verteiler)
                    .WithMany(p => p.VerteilerKundes)
                    .HasForeignKey(d => d.VerteilerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Verteiler_Kunde_Verteiler");
            });

            modelBuilder.Entity<VerteilungBekoestigungstage>(entity =>
            {
                entity.ToTable("VerteilungBekoestigungstage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abendessen).HasColumnName("abendessen");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.AnzahlBkt).HasColumnName("anzahlBKT");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Budget).HasColumnName("budget");

                entity.Property(e => e.Fruehstueck).HasColumnName("fruehstueck");

                entity.Property(e => e.Mittagessen).HasColumnName("mittagessen");

                entity.Property(e => e.Nachmittagskaffee).HasColumnName("nachmittagskaffee");

                entity.Property(e => e.Sonstiges).HasColumnName("sonstiges");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.VerteilungBekoestigungstages)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VerteilungBekoestigungstage_Betriebsstaette");
            });

            modelBuilder.Entity<Vertretungspersonal>(entity =>
            {
                entity.ToTable("Vertretungspersonal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FachkraftKrankheit).HasColumnName("fachkraftKrankheit");

                entity.Property(e => e.FachkraftUrlaub).HasColumnName("fachkraftUrlaub");

                entity.Property(e => e.HilfskraftKrankheit).HasColumnName("hilfskraftKrankheit");

                entity.Property(e => e.HilfskraftUrlaub).HasColumnName("hilfskraftUrlaub");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.HasOne(d => d.Kalkulation)
                    .WithMany(p => p.Vertretungspersonals)
                    .HasForeignKey(d => d.KalkulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vertretungspersonal_Kalkulation");
            });

            modelBuilder.Entity<Verwaltungsumlage>(entity =>
            {
                entity.ToTable("Verwaltungsumlage");

                entity.HasIndex(e => new { e.KalkulationBesitzerId, e.KalkulationGehoertZuId }, "Standard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.BudgetName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budgetName");

                entity.Property(e => e.KalkulationBesitzerId).HasColumnName("kalkulationBesitzer_id");

                entity.Property(e => e.KalkulationGehoertZuId).HasColumnName("kalkulationGehoertZu_id");

                entity.Property(e => e.LetzteAktualisierung)
                    .HasColumnType("datetime")
                    .HasColumnName("letzteAktualisierung");

                entity.Property(e => e.OperativesMgmtAufschlag).HasColumnName("operativesMgmtAufschlag");

                entity.Property(e => e.SummeBg).HasColumnName("summeBG");

                entity.Property(e => e.SummeGewStRelevant).HasColumnName("summeGewStRelevant");

                entity.Property(e => e.SummeKoeStRelevant).HasColumnName("summeKoeStRelevant");

                entity.Property(e => e.Verwaltungsumlage1).HasColumnName("verwaltungsumlage");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Verwaltungsumlages)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Verwaltungsumlage_Benutzer");

                entity.HasOne(d => d.KalkulationBesitzer)
                    .WithMany(p => p.VerwaltungsumlageKalkulationBesitzers)
                    .HasForeignKey(d => d.KalkulationBesitzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Verwaltungsumlage_Kalkulation");

                entity.HasOne(d => d.KalkulationGehoertZu)
                    .WithMany(p => p.VerwaltungsumlageKalkulationGehoertZus)
                    .HasForeignKey(d => d.KalkulationGehoertZuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Verwaltungsumlage_Kalkulation1");
            });

            modelBuilder.Entity<ViewAlleBestellObjekt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AlleBestellObjekt");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.BearbeiterName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("bearbeiterName");

                entity.Property(e => e.BeschreibungStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibungStatus");

                entity.Property(e => e.Bestelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("bestelldatum");

                entity.Property(e => e.Bestellnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellnummer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lieferant)
                    .HasMaxLength(513)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("lieferdatum");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewAlleBestellObjekteArtikel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AlleBestellObjekteArtikel");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikellisteId");

                entity.Property(e => e.BestellObjektId).HasColumnName("bestellObjektId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerBestand).HasColumnName("lagerBestand");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheitId");

                entity.Property(e => e.MengeneinheitName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mengeneinheitName");

                entity.Property(e => e.Mindestmenge).HasColumnName("mindestmenge");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummer");

                entity.Property(e => e.OffeneMenge).HasColumnName("offeneMenge");
            });

            modelBuilder.Entity<ViewAlleBestellungen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AlleBestellungen");

                entity.Property(e => e.BestellObjektId).HasColumnName("bestellObjektId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OffeneMenge).HasColumnName("offeneMenge");
            });

            modelBuilder.Entity<ViewAlleNichtAbgeschlossenenBestellObjekt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AlleNichtAbgeschlossenenBestellObjekt");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.BearbeiterName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("bearbeiterName");

                entity.Property(e => e.BeschreibungStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibungStatus");

                entity.Property(e => e.Bestelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("bestelldatum");

                entity.Property(e => e.Bestellnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellnummer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lieferant)
                    .HasMaxLength(513)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("lieferdatum");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewAnsprechpartnerKundeUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AnsprechpartnerKundeUebersicht");

                entity.Property(e => e.Faxnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("faxnummer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.Mailadresse)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mailadresse");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Stellenbeschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stellenbeschreibung");

                entity.Property(e => e.Telefonnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummer");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");
            });

            modelBuilder.Entity<ViewArbeitskrei>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Arbeitskreis");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AnzahlTeilnehmer).HasColumnName("anzahlTeilnehmer");

                entity.Property(e => e.BenutzerVorNachname)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzerVorNachname");

                entity.Property(e => e.Benutzernachname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzernachname");

                entity.Property(e => e.Benutzername)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzername");

                entity.Property(e => e.Benutzervorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzervorname");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Betreuer)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("betreuer");

                entity.Property(e => e.Dauer).HasColumnName("dauer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.Leiter)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("leiter");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewArbeitskreisGesamt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArbeitskreisGesamt");

                entity.Property(e => e.AnzahlTeilnehmer).HasColumnName("anzahlTeilnehmer");

                entity.Property(e => e.AnzahlTeilnehmerVorgabewert).HasColumnName("anzahlTeilnehmerVorgabewert");

                entity.Property(e => e.AnzahlVeranstaltungen).HasColumnName("anzahlVeranstaltungen");

                entity.Property(e => e.AuslastungVeranstaltungenDurchschnitt).HasColumnName("auslastungVeranstaltungenDurchschnitt");

                entity.Property(e => e.Benutzer)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzer");

                entity.Property(e => e.Betreuer)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("betreuer");

                entity.Property(e => e.Dauervorgabewert).HasColumnName("dauervorgabewert");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.KannVeroeffentlichtWerden).HasColumnName("kannVeroeffentlichtWerden");

                entity.Property(e => e.Leiter)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("leiter");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewArtikelEinkauf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArtikelEinkauf");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Artikelkategorie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelkategorie");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lieferantenname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lieferantenname");
            });

            modelBuilder.Entity<ViewArtikelOffeneBestellungen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArtikelOffeneBestellungen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OffeneMenge).HasColumnName("offeneMenge");
            });

            modelBuilder.Entity<ViewArtikelVerkauf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArtikelVerkauf");

                entity.Property(e => e.Artikelkategorie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelkategorie");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ViewArtikelVerkaufGuenstigesterPrei>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArtikelVerkaufGuenstigesterPreis");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.Artikelkategorie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelkategorie");

                entity.Property(e => e.Einkaufspreis).HasColumnName("einkaufspreis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.VerkaufArtikelName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("verkaufArtikelName");
            });

            modelBuilder.Entity<ViewArtikelVerkaufOffeneAuftragspositionen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View__ArtikelVerkaufOffeneAuftragspositionen");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.BeauftragteMenge).HasColumnName("beauftragteMenge");

                entity.Property(e => e.GelieferteMenge).HasColumnName("gelieferteMenge");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ViewArtikelname>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Artikelname");

                entity.Property(e => e.AfaListe).HasColumnName("afaListe");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewArtikelnameArtikelnummer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArtikelnameArtikelnummer");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikellisteId");

                entity.Property(e => e.ArtikellisteName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikellisteName");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ViewAuftrag>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Auftrag");

                entity.Property(e => e.AuftragsnummerExtern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerExtern");

                entity.Property(e => e.AuftragsnummerIntern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerIntern");

                entity.Property(e => e.Auftragstatus)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("auftragstatus");

                entity.Property(e => e.Auftragsvolumen).HasColumnName("auftragsvolumen");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.GeplantFuer)
                    .HasColumnType("datetime")
                    .HasColumnName("geplantFuer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kundenname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundenname");

                entity.Property(e => e.Kundennummer)
                    .HasMaxLength(255)
                    .HasColumnName("kundennummer");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewAuftragAuftragstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Auftrag_Auftragstatus");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AuftragsnummerExtern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerExtern");

                entity.Property(e => e.AuftragsnummerIntern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerIntern");

                entity.Property(e => e.AuftragstatusId).HasColumnName("auftragstatusId");

                entity.Property(e => e.AuftragstatusName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragstatusName");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ReihenfolgeNr).HasColumnName("reihenfolgeNr");
            });

            modelBuilder.Entity<ViewAuftragsposition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Auftragsposition");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.ArtikelVerkaufId).HasColumnName("artikelVerkaufId");

                entity.Property(e => e.Artikelliste)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelliste");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikellisteId");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Debitorenname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("debitorenname");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.Gesamtpreis).HasColumnName("gesamtpreis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheitId");

                entity.Property(e => e.RezeptName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rezeptName");

                entity.Property(e => e.RezepteinheitId).HasColumnName("rezepteinheitId");

                entity.Property(e => e.RezeptkategorieId).HasColumnName("rezeptkategorieId");

                entity.Property(e => e.Verkaufspreis).HasColumnName("verkaufspreis");
            });

            modelBuilder.Entity<ViewAuslastungMonat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AuslastungMonat");

                entity.Property(e => e.AbwesenheitPst0).HasColumnName("abwesenheitPst0");

                entity.Property(e => e.AbwesenheitPst0proTag).HasColumnName("abwesenheitPst0proTag");

                entity.Property(e => e.AbwesenheitPst1).HasColumnName("abwesenheitPst1");

                entity.Property(e => e.AbwesenheitPst1proTag).HasColumnName("abwesenheitPst1proTag");

                entity.Property(e => e.AbwesenheitPst2).HasColumnName("abwesenheitPst2");

                entity.Property(e => e.AbwesenheitPst2proTag).HasColumnName("abwesenheitPst2proTag");

                entity.Property(e => e.AbwesenheitPst3).HasColumnName("abwesenheitPst3");

                entity.Property(e => e.AbwesenheitPst3plus).HasColumnName("abwesenheitPst3plus");

                entity.Property(e => e.AbwesenheitPst3plusproTag).HasColumnName("abwesenheitPst3plusproTag");

                entity.Property(e => e.AbwesenheitPst3proTag).HasColumnName("abwesenheitPst3proTag");

                entity.Property(e => e.AnteilSelbstzahler).HasColumnName("anteilSelbstzahler");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsartId");

                entity.Property(e => e.BelegungPst0).HasColumnName("belegungPst0");

                entity.Property(e => e.BelegungPst0proTag).HasColumnName("belegungPst0proTag");

                entity.Property(e => e.BelegungPst1).HasColumnName("belegungPst1");

                entity.Property(e => e.BelegungPst1proTag).HasColumnName("belegungPst1proTag");

                entity.Property(e => e.BelegungPst2).HasColumnName("belegungPst2");

                entity.Property(e => e.BelegungPst2proTag).HasColumnName("belegungPst2proTag");

                entity.Property(e => e.BelegungPst3).HasColumnName("belegungPst3");

                entity.Property(e => e.BelegungPst3plus).HasColumnName("belegungPst3plus");

                entity.Property(e => e.BelegungPst3plusproTag).HasColumnName("belegungPst3plusproTag");

                entity.Property(e => e.BelegungPst3proTag).HasColumnName("belegungPst3proTag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.Monat).HasColumnName("monat");

                entity.Property(e => e.TageBelegteEz).HasColumnName("tageBelegteEZ");

                entity.Property(e => e.TageSondennahrung).HasColumnName("tageSondennahrung");
            });

            modelBuilder.Entity<ViewAuslastungMonatKonsolidierung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AuslastungMonatKonsolidierung");

                entity.Property(e => e.AbwesenheitPst0).HasColumnName("abwesenheitPst0");

                entity.Property(e => e.AbwesenheitPst0proTag).HasColumnName("abwesenheitPst0proTag");

                entity.Property(e => e.AbwesenheitPst1).HasColumnName("abwesenheitPst1");

                entity.Property(e => e.AbwesenheitPst1proTag).HasColumnName("abwesenheitPst1proTag");

                entity.Property(e => e.AbwesenheitPst2).HasColumnName("abwesenheitPst2");

                entity.Property(e => e.AbwesenheitPst2proTag).HasColumnName("abwesenheitPst2proTag");

                entity.Property(e => e.AbwesenheitPst3).HasColumnName("abwesenheitPst3");

                entity.Property(e => e.AbwesenheitPst3plus).HasColumnName("abwesenheitPst3plus");

                entity.Property(e => e.AbwesenheitPst3plusproTag).HasColumnName("abwesenheitPst3plusproTag");

                entity.Property(e => e.AbwesenheitPst3proTag).HasColumnName("abwesenheitPst3proTag");

                entity.Property(e => e.AuslastungsartId).HasColumnName("auslastungsartId");

                entity.Property(e => e.BelegungPst0).HasColumnName("belegungPst0");

                entity.Property(e => e.BelegungPst0proTag).HasColumnName("belegungPst0proTag");

                entity.Property(e => e.BelegungPst1).HasColumnName("belegungPst1");

                entity.Property(e => e.BelegungPst1proTag).HasColumnName("belegungPst1proTag");

                entity.Property(e => e.BelegungPst2).HasColumnName("belegungPst2");

                entity.Property(e => e.BelegungPst2proTag).HasColumnName("belegungPst2proTag");

                entity.Property(e => e.BelegungPst3).HasColumnName("belegungPst3");

                entity.Property(e => e.BelegungPst3plus).HasColumnName("belegungPst3plus");

                entity.Property(e => e.BelegungPst3plusproTag).HasColumnName("belegungPst3plusproTag");

                entity.Property(e => e.BelegungPst3proTag).HasColumnName("belegungPst3proTag");

                entity.Property(e => e.KonsolidierungId).HasColumnName("konsolidierung_id");

                entity.Property(e => e.Monat).HasColumnName("monat");

                entity.Property(e => e.TageBelegteEz).HasColumnName("tageBelegteEZ");

                entity.Property(e => e.TageSondennahrung).HasColumnName("tageSondennahrung");
            });

            modelBuilder.Entity<ViewBelegJournal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_BelegJournal");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AuftragstatusId).HasColumnName("auftragstatus_id");

                entity.Property(e => e.BelegJournalId).HasColumnName("belegJournalId");

                entity.Property(e => e.Belegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("belegdatum");

                entity.Property(e => e.Belegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegnummer");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Expr3).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kunde_id");

                entity.Property(e => e.OberBelegId).HasColumnName("oberBeleg_id");
            });

            modelBuilder.Entity<ViewBenutzeruebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Benutzeruebersicht");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltig_von");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LetzterLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("letzterLogin");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RegionaleZuordnungId).HasColumnName("regionaleZuordnungId");

                entity.Property(e => e.RegionaleZuordnungName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("regionaleZuordnungName");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");
            });

            modelBuilder.Entity<ViewBetriebsstaette>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Betriebsstaette");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerGebietsleiter)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzerGebietsleiter");

                entity.Property(e => e.BenutzerGebietsleiterId).HasColumnName("benutzerGebietsleiterId");

                entity.Property(e => e.BundeslandId).HasColumnName("bundeslandId");

                entity.Property(e => e.BundeslandName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Bundesland_Name");

                entity.Property(e => e.Deaktiviert).HasColumnName("deaktiviert");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kundennr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundennr");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NummerUndName)
                    .HasMaxLength(511)
                    .IsUnicode(false)
                    .HasColumnName("nummerUndName");

                entity.Property(e => e.RegionaleZuordnungId).HasColumnName("regionaleZuordnungId");

                entity.Property(e => e.RegionaleZuordnungName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RegionaleZuordnung_Name");

                entity.Property(e => e.TraegerId).HasColumnName("traegerId");

                entity.Property(e => e.TraegerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Traeger_Name");

                entity.Property(e => e.TypId).HasColumnName("typId");
            });

            modelBuilder.Entity<ViewBetriebstaetteFinanzplanung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Betriebstaette_Finanzplanung");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BundeslandId).HasColumnName("bundeslandId");

                entity.Property(e => e.Deaktiviert).HasColumnName("deaktiviert");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NummerUndName)
                    .HasMaxLength(511)
                    .IsUnicode(false)
                    .HasColumnName("nummerUndName");

                entity.Property(e => e.RegionaleZuordnungId).HasColumnName("regionaleZuordnungId");

                entity.Property(e => e.TraegerId).HasColumnName("traegerId");

                entity.Property(e => e.TypId).HasColumnName("typId");
            });

            modelBuilder.Entity<ViewBuArbeitskrei>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_Arbeitskreis");

                entity.Property(e => e.AnzTeilnehmer).HasColumnName("Anz. Teilnehmer");

                entity.Property(e => e.AnzVeranstaltungen).HasColumnName("Anz. Veranstaltungen");

                entity.Property(e => e.Arbeitskreisbetreuer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Arbeitskreisleiter)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AufWebseiteVeröffentlicht).HasColumnName("Auf Webseite veröffentlicht");

                entity.Property(e => e.Benutzer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.DarfAufWebseiteVeröffentlichtWerden).HasColumnName("Darf Auf Webseite veröffentlicht werden");

                entity.Property(e => e.DurchAuslastungVeranstaltung).HasColumnName("Durch. Auslastung Veranstaltung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaxAnzahlTeilnehmer).HasColumnName("Max. Anzahl Teilnehmer");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StandarddauerInTagen).HasColumnName("Standarddauer in Tagen");
            });

            modelBuilder.Entity<ViewBuKunde>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_Kunde");

                entity.Property(e => e.AbteilungGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AbteilungRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdresszusatzRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ansprechpartnerart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BestellnummerRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kontaktart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LandGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LandKrzlGesch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LandKrzlRechn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LandRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mail2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftEnddatum).HasColumnType("date");

                entity.Property(e => e.MitgliedschaftKuendigungsdatum).HasColumnType("date");

                entity.Property(e => e.MitgliedschaftStartdatum).HasColumnType("date");

                entity.Property(e => e.Mitgliedschaftsart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftsartUnternehmen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mitgliedsnummer).HasMaxLength(255);

                entity.Property(e => e.Mobiltel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notizen)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OrtGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrtRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZGesch");

                entity.Property(e => e.Plzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZRechn");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfOrtGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfOrtRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfPlzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZGesch");

                entity.Property(e => e.PostfPlzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZRechn");

                entity.Property(e => e.PostfRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TelFax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unternehmen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuKundeAdresseKommunikation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_KundeAdresseKommunikation");

                entity.Property(e => e.AbteilungGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ansprechpartnerart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kontaktart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kundennr).HasMaxLength(255);

                entity.Property(e => e.LandGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mail2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftArt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftArtUnternehmen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobiltel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrtGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZGesch");

                entity.Property(e => e.PostfGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfOrtGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfPlzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZGesch");

                entity.Property(e => e.StrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("StrGesch.");

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TelFax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuKundeInMahnverfahren>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_KundeInMahnverfahren");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kunde)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kundennummer).HasMaxLength(255);

                entity.Property(e => e.Mahnbetrag).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ort)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZ");
            });

            modelBuilder.Entity<ViewBuKundeLoesungen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_KundeLoesungen");

                entity.Property(e => e.AbteilungGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AbteilungRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kundennr).HasMaxLength(255);

                entity.Property(e => e.LandGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LandRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftArt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftArtUnternehmen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrtGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrtRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZGesch");

                entity.Property(e => e.Plzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZRechn");

                entity.Property(e => e.PostfGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfPlzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZGesch");

                entity.Property(e => e.PostfPlzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZRechn");

                entity.Property(e => e.PostfRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuKundeMitAnsprechpartner>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_KundeMitAnsprechpartner");

                entity.Property(e => e.Adresszusatz)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Anredetext)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnsprechpartnerId).HasColumnName("ansprechpartnerId");

                entity.Property(e => e.DebitorenNr).HasMaxLength(255);

                entity.Property(e => e.EmailAnsprechhpartner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailUnternehmen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FaxnummerAnsprechpartner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hausnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kürzel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nachname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ort)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZ");

                entity.Property(e => e.Stellenbeschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Strasse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonnummerAnsprechpartner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unternehmen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuKundeRechnungsadresseMitgliedsbeitrag>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_KundeRechnungsadresseMitgliedsbeitrag");

                entity.Property(e => e.AbteilungRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdresszusatzRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ansprechpartnerart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BestellnummerRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kontaktart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kundennr).HasMaxLength(255);

                entity.Property(e => e.LandRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftArtUnternehmen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mitgliedschaftsart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notizen)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OrtRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZRechn");

                entity.Property(e => e.PostfOrtRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfPlzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZRechn");

                entity.Property(e => e.PostfRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnternehmensnameRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuKundeSegmente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_KundeSegmente");

                entity.Property(e => e.AbteilungGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AbteilungRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kundennr).HasMaxLength(255);

                entity.Property(e => e.LandGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LandRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftArt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitgliedschaftArtUnternehmen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mnkn).HasColumnName("mnkn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrtGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrtRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZGesch");

                entity.Property(e => e.Plzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLZRechn");

                entity.Property(e => e.PostfGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostfPlzgesch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZGesch");

                entity.Property(e => e.PostfPlzrechn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PostfPLZRechn");

                entity.Property(e => e.PostfRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrGesch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrRechn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unternehmen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuOffeneAenderungenKalkulation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_OffeneAenderungenKalkulation");

                entity.Property(e => e.Bearbeiter)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Debitor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gesellschaft)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kalkulation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LetzteÄnderung)
                    .HasColumnType("datetime")
                    .HasColumnName("Letzte Änderung");
            });

            modelBuilder.Entity<ViewBuPivotAuswertungIstDaten>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_PivotAuswertungIstDaten");

                entity.Property(e => e.Budgetname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Bundesland)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Debitor)
                    .HasMaxLength(281)
                    .IsUnicode(false);

                entity.Property(e => e.Dienstart)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gebietsleiter)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Gesellschaft)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstEinsatz).HasColumnType("money");

                entity.Property(e => e.Kostenstelle)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Kostenstellenbereich)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Objektnummer)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PreisProBkt).HasColumnName("PreisProBKT");

                entity.Property(e => e.Sachkontengruppe)
                    .HasMaxLength(511)
                    .IsUnicode(false);

                entity.Property(e => e.Sachkonto)
                    .HasMaxLength(266)
                    .IsUnicode(false);

                entity.Property(e => e.Träger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vkwert).HasColumnName("VKWert");
            });

            modelBuilder.Entity<ViewBuPivotAuswertungStandard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_PivotAuswertungStandard");

                entity.Property(e => e.Budgetname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Bundesland)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Debitor)
                    .HasMaxLength(286)
                    .IsUnicode(false);

                entity.Property(e => e.Dienstart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gebietsleiter)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Gesellschaft)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kostenstellenbereich)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Objektnummer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PreisProBkt).HasColumnName("PreisProBKT");

                entity.Property(e => e.Sachkontengruppe)
                    .HasMaxLength(511)
                    .IsUnicode(false);

                entity.Property(e => e.Sachkonto)
                    .HasMaxLength(288)
                    .IsUnicode(false);

                entity.Property(e => e.Träger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vkwert).HasColumnName("VKWert");
            });

            modelBuilder.Entity<ViewBuTarifUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_TarifUebersicht");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KrankenversicherungGfB).HasColumnName("Krankenversicherung GfB");

                entity.Property(e => e.LohnsteigerungGfb).HasColumnName("Lohnsteigerung Gfb");

                entity.Property(e => e.LohnsteigerungSonstige).HasColumnName("Lohnsteigerung Sonstige");

                entity.Property(e => e.LohnsteuerGfB).HasColumnName("Lohnsteuer GfB");

                entity.Property(e => e.RentenversicherungGfB).HasColumnName("Rentenversicherung GfB");

                entity.Property(e => e.Tarifname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tarifnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UmlageNachDemAufwendungsausgleichsgesetz).HasColumnName("Umlage nach dem Aufwendungsausgleichsgesetz");

                entity.Property(e => e.WöchentlicheArbeitszeit).HasColumnName("Wöchentliche Arbeitszeit");
            });

            modelBuilder.Entity<ViewBuVeranstaltungBasisdaten>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_VeranstaltungBasisdaten");

                entity.Property(e => e.Arbeitskreis)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Benutzer)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Enddatum).HasColumnType("datetime");

                entity.Property(e => e.Hotel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Leiter)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Raumbeschreibung)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Raumnr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Startdatum).HasColumnType("datetime");

                entity.Property(e => e.Tagungsort)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuVeranstaltungsteilnehmer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewBU_Veranstaltungsteilnehmer");

                entity.Property(e => e.Arbeitskreis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MitgliedstatusBeiVeranstaltung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(513)
                    .IsUnicode(false);

                entity.Property(e => e.Veranstaltung)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBuchungstagDefinition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_BuchungstagDefinition");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdBuchungstagDefinition).HasColumnName("idBuchungstagDefinition");

                entity.Property(e => e.IstGlobal).HasColumnName("istGlobal");

                entity.Property(e => e.NameBenutzer)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nameBenutzer");

                entity.Property(e => e.NameBetriebsstaette)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nameBetriebsstaette");

                entity.Property(e => e.NameRegionaleZuordnung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nameRegionaleZuordnung");

                entity.Property(e => e.NummerUndNameBetriebsstaette)
                    .HasMaxLength(511)
                    .IsUnicode(false)
                    .HasColumnName("nummerUndNameBetriebsstaette");
            });

            modelBuilder.Entity<ViewDateiverknuepfung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Dateiverknuepfung");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Benutzername)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzername");

                entity.Property(e => e.DateiAuthor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateiAuthor");

                entity.Property(e => e.DateiId).HasColumnName("datei_id");

                entity.Property(e => e.Dateiart)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateiart");

                entity.Property(e => e.DateiartId).HasColumnName("dateiart_id");

                entity.Property(e => e.Dateierweiterung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateierweiterung");

                entity.Property(e => e.Dateigroesse).HasColumnName("dateigroesse");

                entity.Property(e => e.Dateiinhalt)
                    .HasColumnType("image")
                    .HasColumnName("dateiinhalt");

                entity.Property(e => e.Dateiname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dateiname");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.KannVeroeffentlichtWerden).HasColumnName("kannVeroeffentlichtWerden");

                entity.Property(e => e.Nachname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nachname");

                entity.Property(e => e.Verknuepfungsklasse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("verknuepfungsklasse");

                entity.Property(e => e.VerknuepfungsklassenId).HasColumnName("verknuepfungsklassenId");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");
            });

            modelBuilder.Entity<ViewErteilteAuftraegeNochNichtVersandt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ErteilteAuftraegeNochNichtVersandt");

                entity.Property(e => e.ArtikelId).HasColumnName("artikel_id");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.AuftragsnummerExtern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerExtern");

                entity.Property(e => e.AuftragsnummerIntern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerIntern");

                entity.Property(e => e.Auftragstatus)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("auftragstatus");

                entity.Property(e => e.Auftragsvolumen).HasColumnName("auftragsvolumen");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kundenname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundenname");

                entity.Property(e => e.Kundennummer)
                    .HasMaxLength(255)
                    .HasColumnName("kundennummer");

                entity.Property(e => e.LagerBestand).HasColumnName("lagerBestand");

                entity.Property(e => e.Sollmenge).HasColumnName("sollmenge");
            });

            modelBuilder.Entity<ViewFehlerhafteBudget>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FehlerhafteBudgets");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstMfp).HasColumnName("istMFP");

                entity.Property(e => e.Kalkulationsname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewFinanzplanung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Finanzplanung");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzerName");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.BudgetIstGesperrt).HasColumnName("budgetIstGesperrt");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.FinanzplanungIstAbgeschlossen).HasColumnName("finanzplanungIstAbgeschlossen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");

                entity.Property(e => e.KalkulationsName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kalkulationsName");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TraegerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("traegerName");
            });

            modelBuilder.Entity<ViewGueltigeVerkaufsArtikel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GueltigeVerkaufsArtikel");

                entity.Property(e => e.Artikelnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewInternesKontoUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InternesKontoUebersicht");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kontostand)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("kontostand");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");

                entity.Property(e => e.KundeVerbandId).HasColumnName("kundeVerbandId");

                entity.Property(e => e.KundenName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundenName");

                entity.Property(e => e.LetzteAenderung)
                    .HasColumnType("datetime")
                    .HasColumnName("letzteAenderung");
            });

            modelBuilder.Entity<ViewInventurUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InventurUebersicht");

                entity.Property(e => e.Benutzername)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzername");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Inventurname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("inventurname");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.LagerId).HasColumnName("lager_id");

                entity.Property(e => e.Lagerwert).HasColumnName("lagerwert");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Sollinventurdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("sollinventurdatum");
            });

            modelBuilder.Entity<ViewKalkulation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Kalkulation");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BenutzerGebietsleiter)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzerGebietsleiter");

                entity.Property(e => e.BenutzerGebietsleiterId).HasColumnName("benutzerGebietsleiterId");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzerName");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.BetriebsstaetteNameBkz)
                    .HasMaxLength(511)
                    .IsUnicode(false)
                    .HasColumnName("BetriebsstaetteNameBKZ");

                entity.Property(e => e.Deaktiviert).HasColumnName("deaktiviert");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstAbgeschlossen).HasColumnName("istAbgeschlossen");

                entity.Property(e => e.IstKalkulationZurKonsolidierungFreigegeben).HasColumnName("istKalkulationZurKonsolidierungFreigegeben");

                entity.Property(e => e.IstMfp).HasColumnName("istMFP");

                entity.Property(e => e.KalkulationsartId).HasColumnName("kalkulationsartId");

                entity.Property(e => e.KostenstellenId).HasColumnName("kostenstellenId");

                entity.Property(e => e.Kostenstellennummer).HasColumnName("kostenstellennummer");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PlanungBis)
                    .HasColumnType("datetime")
                    .HasColumnName("planungBis");

                entity.Property(e => e.PlanungVon)
                    .HasColumnType("datetime")
                    .HasColumnName("planungVon");

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Traeger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewKalkulationKennzahlen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KalkulationKennzahlen");

                entity.Property(e => e.BKtsatz).HasColumnName("bKTSatz");

                entity.Property(e => e.Betriebsstaette)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("betriebsstaette");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Ergebnis).HasColumnName("ergebnis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Investitionssumme).HasColumnName("investitionssumme");

                entity.Property(e => e.IstFehlerfrei).HasColumnName("istFehlerfrei");

                entity.Property(e => e.IstGesperrt).HasColumnName("istGesperrt");

                entity.Property(e => e.MonatlichProduktivPlanstunden).HasColumnName("monatlichProduktivPlanstunden");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PlanungBis)
                    .HasColumnType("datetime")
                    .HasColumnName("planungBis");

                entity.Property(e => e.PlanungVon)
                    .HasColumnType("datetime")
                    .HasColumnName("planungVon");

                entity.Property(e => e.PreisProQm).HasColumnName("preisProQM");

                entity.Property(e => e.QMgesamt).HasColumnName("qMGesamt");

                entity.Property(e => e.RegionaleZuordnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("regionaleZuordnung");

                entity.Property(e => e.RegionaleZuordnungId).HasColumnName("regionaleZuordnungId");

                entity.Property(e => e.SollIstPlanstunden).HasColumnName("sollIstPlanstunden");

                entity.Property(e => e.Standardleistungswert).HasColumnName("standardleistungswert");

                entity.Property(e => e.Umsatz).HasColumnName("umsatz");

                entity.Property(e => e.Wareneinsatz).HasColumnName("wareneinsatz");

                entity.Property(e => e.WareneinsatzProBkt).HasColumnName("WareneinsatzProBKT");
            });

            modelBuilder.Entity<ViewKalkulationenFuerFinanzplanung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KalkulationenFuerFinanzplanung");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Deaktiviert).HasColumnName("deaktiviert");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewKontobewegung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Kontobewegung");

                entity.Property(e => e.Belegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("belegdatum");

                entity.Property(e => e.Belegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegnummer");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.Benutzername)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzername");

                entity.Property(e => e.Betrag)
                    .HasColumnType("decimal(36, 2)")
                    .HasColumnName("betrag");

                entity.Property(e => e.Betreff)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("betreff");

                entity.Property(e => e.Buchungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("buchungsdatum");

                entity.Property(e => e.Buchungsnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("buchungsnummer");

                entity.Property(e => e.GrundObjektId).HasColumnName("grundObjektId");

                entity.Property(e => e.GrundObjektTyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("grundObjektTyp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InternesKontoId).HasColumnName("internesKontoId");

                entity.Property(e => e.KontobewegungsartId).HasColumnName("kontobewegungsartId");
            });

            modelBuilder.Entity<ViewKontobewegungKunde>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KontobewegungKunde");

                entity.Property(e => e.Belegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("belegdatum");

                entity.Property(e => e.Belegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegnummer");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.Betreff)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("betreff");

                entity.Property(e => e.Buchungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("buchungsdatum");

                entity.Property(e => e.Buchungsnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("buchungsnummer");

                entity.Property(e => e.GrundObjektId).HasColumnName("grundObjektId");

                entity.Property(e => e.GrundObjektTyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("grundObjektTyp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InternesKontoId).HasColumnName("internesKontoId");

                entity.Property(e => e.KontobewegungsartId).HasColumnName("kontobewegungsartId");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");
            });

            modelBuilder.Entity<ViewKontostand>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Kontostand");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kontostand)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("kontostand");
            });

            modelBuilder.Entity<ViewKundeBestandteilAdresse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeBestandteilAdresse");

                entity.Property(e => e.AbteilungGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abteilungGeschaeftlich");

                entity.Property(e => e.AbteilungRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abteilungRechnung");

                entity.Property(e => e.AdresszusatzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresszusatzRechnung");

                entity.Property(e => e.BestellnummerRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellnummerRechnung");

                entity.Property(e => e.HausnummerGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnummerGeschaeftlich");

                entity.Property(e => e.HausnummerRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnummerRechnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstpostfachGeschaeftlich).HasColumnName("istpostfachGeschaeftlich");

                entity.Property(e => e.IstpostfachRechnung).HasColumnName("istpostfachRechnung");

                entity.Property(e => e.LandcodeGeschaeftlich)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("landcodeGeschaeftlich");

                entity.Property(e => e.LandcodeRechnung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("landcodeRechnung");

                entity.Property(e => e.LandnameGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("landnameGeschaeftlich");

                entity.Property(e => e.LandnameRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("landnameRechnung");

                entity.Property(e => e.OrtGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ortGeschaeftlich");

                entity.Property(e => e.OrtRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ortRechnung");

                entity.Property(e => e.PlzGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plzGeschaeftlich");

                entity.Property(e => e.PlzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plzRechnung");

                entity.Property(e => e.PostfachGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachGeschaeftlich");

                entity.Property(e => e.PostfachOrtGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachOrtGeschaeftlich");

                entity.Property(e => e.PostfachOrtRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachOrtRechnung");

                entity.Property(e => e.PostfachRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachRechnung");

                entity.Property(e => e.PostfachplzGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachplzGeschaeftlich");

                entity.Property(e => e.PostfachplzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachplzRechnung");

                entity.Property(e => e.StrasseGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasseGeschaeftlich");

                entity.Property(e => e.StrasseRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasseRechnung");

                entity.Property(e => e.UnternehmensnameRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("unternehmensnameRechnung");
            });

            modelBuilder.Entity<ViewKundeBestandteilAdresseGeschaeftlich>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeBestandteilAdresseGeschaeftlich");

                entity.Property(e => e.Abteilung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abteilung");

                entity.Property(e => e.AdresseId).HasColumnName("adresseID");

                entity.Property(e => e.HausnummerGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnummerGeschaeftlich");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstpostfachGeschaeftlich).HasColumnName("istpostfachGeschaeftlich");

                entity.Property(e => e.LandcodeGeschaeftlich)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("landcodeGeschaeftlich");

                entity.Property(e => e.LandnameGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("landnameGeschaeftlich");

                entity.Property(e => e.OrtGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ortGeschaeftlich");

                entity.Property(e => e.PlzGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plzGeschaeftlich");

                entity.Property(e => e.PostfachGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachGeschaeftlich");

                entity.Property(e => e.PostfachOrt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachOrt");

                entity.Property(e => e.PostfachplzGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachplzGeschaeftlich");

                entity.Property(e => e.StrasseGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasseGeschaeftlich");
            });

            modelBuilder.Entity<ViewKundeBestandteilAdresseRechnung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeBestandteilAdresseRechnung");

                entity.Property(e => e.Abteilung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abteilung");

                entity.Property(e => e.Adresszusatz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresszusatz");

                entity.Property(e => e.BestellNummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellNummer");

                entity.Property(e => e.HausnummerRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnummerRechnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstpostfachRechnung).HasColumnName("istpostfachRechnung");

                entity.Property(e => e.LandcodeRechnung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("landcodeRechnung");

                entity.Property(e => e.LandnameRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("landnameRechnung");

                entity.Property(e => e.OrtRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ortRechnung");

                entity.Property(e => e.PlzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plzRechnung");

                entity.Property(e => e.PostfachOrt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachOrt");

                entity.Property(e => e.PostfachRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachRechnung");

                entity.Property(e => e.PostfachplzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachplzRechnung");

                entity.Property(e => e.StrasseRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasseRechnung");

                entity.Property(e => e.UnternehmensnameRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("unternehmensnameRechnung");
            });

            modelBuilder.Entity<ViewKundeBestandteilAnrede>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeBestandteilAnrede");

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anrede");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ViewKundeBestandteilGesamt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeBestandteilGesamt");

                entity.Property(e => e.AbteilungGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abteilungGeschaeftlich");

                entity.Property(e => e.AbteilungRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abteilungRechnung");

                entity.Property(e => e.AdresszusatzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresszusatzRechnung");

                entity.Property(e => e.Anrede)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anrede");

                entity.Property(e => e.Ansprechpartnerart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ansprechpartnerart");

                entity.Property(e => e.AnzahlMitgliedschaft).HasColumnName("anzahlMitgliedschaft");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.BestellnummerRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellnummerRechnung");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.DebitorennummerVater)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummerVater");

                entity.Property(e => e.Enddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("enddatum");

                entity.Property(e => e.HausnummerGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnummerGeschaeftlich");

                entity.Property(e => e.HausnummerRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnummerRechnung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstpostfachGeschaeftlich).HasColumnName("istpostfachGeschaeftlich");

                entity.Property(e => e.IstpostfachRechnung).HasColumnName("istpostfachRechnung");

                entity.Property(e => e.Kuendigungdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("kuendigungdatum");

                entity.Property(e => e.Kundenart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kundenart");

                entity.Property(e => e.Kundenkategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kundenkategorie");

                entity.Property(e => e.LandcodeGeschaeftlich)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("landcodeGeschaeftlich");

                entity.Property(e => e.LandcodeRechnung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("landcodeRechnung");

                entity.Property(e => e.LandnameGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("landnameGeschaeftlich");

                entity.Property(e => e.LandnameRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("landnameRechnung");

                entity.Property(e => e.MailadresseGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mailadresseGeschaeftlich");

                entity.Property(e => e.MailadressePrivat)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mailadressePrivat");

                entity.Property(e => e.Mitgliedsbeitrag).HasColumnName("mitgliedsbeitrag");

                entity.Property(e => e.MitgliedschaftArt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mitgliedschaftArt");

                entity.Property(e => e.MitgliedschaftArtId).HasColumnName("mitgliedschaftArt_id");

                entity.Property(e => e.MitgliedschaftArtUnternehmen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mitgliedschaftArtUnternehmen");

                entity.Property(e => e.MitgliedschaftArtUnternehmenId).HasColumnName("mitgliedschaftArtUnternehmen_id");

                entity.Property(e => e.Mitgliedssteuer).HasColumnName("mitgliedssteuer");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OrtGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ortGeschaeftlich");

                entity.Property(e => e.OrtRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ortRechnung");

                entity.Property(e => e.PlzGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plzGeschaeftlich");

                entity.Property(e => e.PlzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plzRechnung");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.PostfachGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachGeschaeftlich");

                entity.Property(e => e.PostfachOrtGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachOrtGeschaeftlich");

                entity.Property(e => e.PostfachOrtRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachOrtRechnung");

                entity.Property(e => e.PostfachRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachRechnung");

                entity.Property(e => e.PostfachplzGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachplzGeschaeftlich");

                entity.Property(e => e.PostfachplzRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("postfachplzRechnung");

                entity.Property(e => e.Startdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("startdatum");

                entity.Property(e => e.StrasseGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasseGeschaeftlich");

                entity.Property(e => e.StrasseRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasseRechnung");

                entity.Property(e => e.Telefonfax)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonfax");

                entity.Property(e => e.Telefonnummergeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummergeschaeftlich");

                entity.Property(e => e.Telefonnummermobil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummermobil");

                entity.Property(e => e.Telefonnummerprivat)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummerprivat");

                entity.Property(e => e.Titel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("titel");

                entity.Property(e => e.Unternehmen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("unternehmen");

                entity.Property(e => e.UnternehmensnameRechnung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("unternehmensnameRechnung");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");
            });

            modelBuilder.Entity<ViewKundeBestandteilKommunikation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeBestandteilKommunikation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MailadresseGeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mailadresseGeschaeftlich");

                entity.Property(e => e.MailadressePrivat)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mailadressePrivat");

                entity.Property(e => e.Telefonfax)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonfax");

                entity.Property(e => e.Telefonnummergeschaeftlich)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummergeschaeftlich");

                entity.Property(e => e.Telefonnummermobil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummermobil");

                entity.Property(e => e.Telefonnummerprivat)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummerprivat");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<ViewKundeBestandteilMitgliedschaft>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeBestandteilMitgliedschaft");

                entity.Property(e => e.AnzahlMitgliedschaft).HasColumnName("anzahlMitgliedschaft");

                entity.Property(e => e.Enddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("enddatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kuendigungdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("kuendigungdatum");

                entity.Property(e => e.Mitgliedsbeitrag).HasColumnName("mitgliedsbeitrag");

                entity.Property(e => e.MitgliedschaftArt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mitgliedschaftArt");

                entity.Property(e => e.MitgliedschaftArtId).HasColumnName("mitgliedschaftArt_id");

                entity.Property(e => e.MitgliedschaftArtUnternehmen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mitgliedschaftArtUnternehmen");

                entity.Property(e => e.MitgliedschaftArtUnternehmenId).HasColumnName("mitgliedschaftArtUnternehmen_id");

                entity.Property(e => e.Mitgliedssteuer).HasColumnName("mitgliedssteuer");

                entity.Property(e => e.Startdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("startdatum");
            });

            modelBuilder.Entity<ViewKundeUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeUebersicht");

                entity.Property(e => e.Adresszusatz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adresszusatz");

                entity.Property(e => e.AnzahlMitgliedschaft).HasColumnName("anzahlMitgliedschaft");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.Faxnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("faxnummer");

                entity.Property(e => e.Hausnumer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hausnumer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstGesperrt).HasColumnName("istGesperrt");

                entity.Property(e => e.Kategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kategorie");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kuerzel");

                entity.Property(e => e.KundeAnsprechpartnerVaterId).HasColumnName("kundeAnsprechpartnerVaterId");

                entity.Property(e => e.KundeVerbandId).HasColumnName("kundeVerband_id");

                entity.Property(e => e.Kundenart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kundenart");

                entity.Property(e => e.KundenartId).HasColumnName("kundenart_id");

                entity.Property(e => e.KundenkategorieId).HasColumnName("kundenkategorie_id");

                entity.Property(e => e.MitgliedschaftArt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mitgliedschaftArt");

                entity.Property(e => e.MitgliedschaftArtId).HasColumnName("mitgliedschaftArt_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Ort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ort");

                entity.Property(e => e.Plz)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("plz");

                entity.Property(e => e.Strasse)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strasse");

                entity.Property(e => e.Telefonnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefonnummer");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");
            });

            modelBuilder.Entity<ViewKundeVeranstaltung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KundeVeranstaltung");

                entity.Property(e => e.Arbeitskreis)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("arbeitskreis");

                entity.Property(e => e.ArbeitskreisId).HasColumnName("arbeitskreisId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");

                entity.Property(e => e.KundeVaterId).HasColumnName("kundeVaterId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Tagungsort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tagungsort");

                entity.Property(e => e.Teilnehmerart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teilnehmerart");

                entity.Property(e => e.Veranstaltung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("veranstaltung");

                entity.Property(e => e.VeranstaltungId).HasColumnName("veranstaltungId");

                entity.Property(e => e.Veranstaltungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("veranstaltungsdatum");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");
            });

            modelBuilder.Entity<ViewLager>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Lager");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzerId");

                entity.Property(e => e.Benutzername)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzername");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewLagerArtikelDurchschnittsprei>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LagerArtikelDurchschnittspreis");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.Durchschnittspreis).HasColumnName("durchschnittspreis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerId).HasColumnName("lagerId");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.Umsatz).HasColumnName("umsatz");
            });

            modelBuilder.Entity<ViewLagerArtikelNiedrigsterEinkaufsprei>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LagerArtikelNiedrigsterEinkaufspreis");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerId).HasColumnName("lagerId");

                entity.Property(e => e.NiedrigsterPreis).HasColumnName("niedrigsterPreis");
            });

            modelBuilder.Entity<ViewLagerBestandHeute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LagerBestandHeute");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.Artikellistenname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikellistenname");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Bestandsmenge).HasColumnName("bestandsmenge");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerId).HasColumnName("lagerId");

                entity.Property(e => e.Lagername)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lagername");
            });

            modelBuilder.Entity<ViewLagerUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LagerUebersicht");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzerName");

                entity.Property(e => e.BenutzerVorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzerVorname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerArtikelDurchschnittspreis).HasColumnName("lagerArtikelDurchschnittspreis");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewLagerbestandProArtikelHeute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LagerbestandProArtikelHeute");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerBestand).HasColumnName("lagerBestand");
            });

            modelBuilder.Entity<ViewLetzterLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LetzterLogin");

                entity.Property(e => e.Anzahl).HasColumnName("anzahl");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.ErsterLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("ersterLogin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LetzterLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("letzterLogin");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewLieferantenArtikelEinkaufspreisHeute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LieferantenArtikelEinkaufspreisHeute");

                entity.Property(e => e.Artikelid).HasColumnName("artikelid");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikellisteId");

                entity.Property(e => e.Artikelnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.EinkaufspreisproExtEinheit).HasColumnName("einkaufspreisproExtEinheit");

                entity.Property(e => e.EinkaufspreisproIntEinheit)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("einkaufspreisproIntEinheit");

                entity.Property(e => e.Gebindegroesse).HasColumnName("gebindegroesse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstGebindeartikel).HasColumnName("istGebindeartikel");

                entity.Property(e => e.Lieferantid).HasColumnName("lieferantid");

                entity.Property(e => e.Lieferantname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lieferantname");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheitId");

                entity.Property(e => e.MengeneinheitName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mengeneinheitName");

                entity.Property(e => e.Mindestbestellmenge).HasColumnName("mindestbestellmenge");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Prioritaet).HasColumnName("prioritaet");

                entity.Property(e => e.Umrechnungsfaktor).HasColumnName("umrechnungsfaktor");
            });

            modelBuilder.Entity<ViewMailNachricht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MailNachricht");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AnzahlMeldungen).HasColumnName("anzahlMeldungen");

                entity.Property(e => e.Betreff)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("betreff");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstEntwurf).HasColumnName("istEntwurf");

                entity.Property(e => e.Versanddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("versanddatum");
            });

            modelBuilder.Entity<ViewMenueauswahl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Menueauswahl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MenueAnzeigename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("menueAnzeigename");

                entity.Property(e => e.MenueName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("menueName");

                entity.Property(e => e.MenueplanId).HasColumnName("menueplanId");

                entity.Property(e => e.MenueplanTag)
                    .HasColumnType("datetime")
                    .HasColumnName("menueplanTag");

                entity.Property(e => e.MenueplankategorieId).HasColumnName("menueplankategorieId");

                entity.Property(e => e.MenueplankategorieName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("menueplankategorieName");
            });

            modelBuilder.Entity<ViewMenueplanBestandteile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MenueplanBestandteile");

                entity.Property(e => e.Alternative)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alternative");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MenueAlternativeId).HasColumnName("menueAlternativeId");

                entity.Property(e => e.MenueAlternativeNr).HasColumnName("menueAlternativeNr");

                entity.Property(e => e.Menueplan)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("menueplan");

                entity.Property(e => e.MenueplanId).HasColumnName("menueplanId");

                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("text");
            });

            modelBuilder.Entity<ViewMenueplanUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MenueplanUebersicht");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AnzahlMenue).HasColumnName("anzahlMenue");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LetzteVeroeffentlichung)
                    .HasColumnType("datetime")
                    .HasColumnName("letzteVeroeffentlichung");

                entity.Property(e => e.MenueplanKategorieName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("menueplanKategorieName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewNewsletter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Newsletter");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AnzahlMeldungen).HasColumnName("anzahlMeldungen");

                entity.Property(e => e.AnzahlNichtVerarbeitet).HasColumnName("anzahlNichtVerarbeitet");

                entity.Property(e => e.AnzahlVerarbeitet).HasColumnName("anzahlVerarbeitet");

                entity.Property(e => e.Betreff)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("betreff");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstEntwurf).HasColumnName("istEntwurf");

                entity.Property(e => e.MailNachrichtId).HasColumnName("mailNachricht_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProzentVerarbeitet).HasColumnName("prozentVerarbeitet");

                entity.Property(e => e.Versanddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("versanddatum");
            });

            modelBuilder.Entity<ViewOffeneBestellmengenArtikel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OffeneBestellmengenArtikel");

                entity.Property(e => e.ArtikellisteId).HasColumnName("artikellisteId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lagerbestand).HasColumnName("lagerbestand");

                entity.Property(e => e.MengeneinheitId).HasColumnName("mengeneinheitId");

                entity.Property(e => e.MengeneinheitName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mengeneinheitName");

                entity.Property(e => e.Mindestmenge).HasColumnName("mindestmenge");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummer");

                entity.Property(e => e.OffeneMenge).HasColumnName("offeneMenge");
            });

            modelBuilder.Entity<ViewOffeneBestellmengenArtikelEinkauf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OffeneBestellmengenArtikelEinkauf");

                entity.Property(e => e.ArtikelId).HasColumnName("artikelId");

                entity.Property(e => e.BestellteMenge).HasColumnName("bestellteMenge");

                entity.Property(e => e.ExtMengeneinheitName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gebindegroesse).HasColumnName("gebindegroesse");

                entity.Property(e => e.GebuchteMenge).HasColumnName("gebuchteMenge");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LieferantId).HasColumnName("lieferantId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummer");
            });

            modelBuilder.Entity<ViewOffenerBeleg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OffenerBeleg");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AuftragId).HasColumnName("auftragId");

                entity.Property(e => e.Auftragsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("auftragsdatum");

                entity.Property(e => e.AuftragsnummerIntern)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("auftragsnummerIntern");

                entity.Property(e => e.Auftragsvolumen).HasColumnName("auftragsvolumen");

                entity.Property(e => e.BelegartId).HasColumnName("belegartId");

                entity.Property(e => e.BelegartName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegartName");

                entity.Property(e => e.Belegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("belegdatum");

                entity.Property(e => e.Belegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegnummer");

                entity.Property(e => e.Debitorenname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("debitorenname");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewOffenesBestellObjekt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OffenesBestellObjekt");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.BearbeiterName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("bearbeiterName");

                entity.Property(e => e.BeschreibungStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("beschreibungStatus");

                entity.Property(e => e.Bestelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("bestelldatum");

                entity.Property(e => e.Bestellnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestellnummer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lieferant)
                    .HasMaxLength(513)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("lieferdatum");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewPlanbilanzExport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PlanbilanzExport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlanbilanzId).HasColumnName("planbilanz_id");

                entity.Property(e => e.RefNr)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Satz)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Satzart)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPlanbilanzPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PlanbilanzPosition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Manuell).HasColumnName("manuell");

                entity.Property(e => e.Nebenrechnung).HasColumnName("nebenrechnung");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PlanbilanzId).HasColumnName("planbilanz_id");

                entity.Property(e => e.PlanbilanzPositionId).HasColumnName("planbilanzPosition_id");

                entity.Property(e => e.PlanbilanzkontoId).HasColumnName("planbilanzkonto_id");

                entity.Property(e => e.Vorjahreswert).HasColumnType("money");

                entity.Property(e => e.Wert).HasColumnType("money");
            });

            modelBuilder.Entity<ViewPraemiePersonal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PraemiePersonal");

                entity.Property(e => e.BerufsgruppeId).HasColumnName("berufsgruppeId");

                entity.Property(e => e.DatumBis)
                    .HasColumnType("datetime")
                    .HasColumnName("datumBis");

                entity.Property(e => e.DatumVon)
                    .HasColumnType("datetime")
                    .HasColumnName("datumVon");

                entity.Property(e => e.Einsatz).HasColumnName("einsatz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KalkulationId).HasColumnName("kalkulationId");
            });

            modelBuilder.Entity<ViewPreiseEinkaufsartikel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PreiseEinkaufsartikel");

                entity.Property(e => e.ArtNrIntArtikel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artNrIntArtikel");

                entity.Property(e => e.Artikelkategorie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelkategorie");

                entity.Property(e => e.Artikelnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lieferantenname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lieferantenname");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nettopreis).HasColumnName("nettopreis");
            });

            modelBuilder.Entity<ViewPreiseVerkaufsartikel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PreiseVerkaufsartikel");

                entity.Property(e => e.AnzahlArtikelVerkauf).HasColumnName("anzahlArtikelVerkauf");

                entity.Property(e => e.ArtikelVerkaufId).HasColumnName("artikelVerkaufId");

                entity.Property(e => e.Artikelkategorie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelkategorie");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nettopreis).HasColumnName("nettopreis");

                entity.Property(e => e.VonMenge).HasColumnName("vonMenge");
            });

            modelBuilder.Entity<ViewRechnungsPositionBeleg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RechnungsPositionBeleg");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AuftragId).HasColumnName("auftragId");

                entity.Property(e => e.BelegartName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegartName");

                entity.Property(e => e.Belegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("belegdatum");

                entity.Property(e => e.Belegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("belegnummer");

                entity.Property(e => e.Debitorenname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("debitorenname");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");

                entity.Property(e => e.OberBelegId).HasColumnName("oberBelegId");

                entity.Property(e => e.OberBelegdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("oberBelegdatum");

                entity.Property(e => e.OberBelegnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oberBelegnummer");

                entity.Property(e => e.Rechnungsbetrag).HasColumnName("rechnungsbetrag");
            });

            modelBuilder.Entity<ViewRezeptBestandteile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RezeptBestandteile");

                entity.Property(e => e.AnzeigeName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("anzeigeName");

                entity.Property(e => e.Art)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("art");

                entity.Property(e => e.Ausgabemenge).HasColumnName("ausgabemenge");

                entity.Property(e => e.Ausgabemengeneinheit)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ausgabemengeneinheit");

                entity.Property(e => e.Bestandteil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bestandteil");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstMenuebestandteil).HasColumnName("istMenuebestandteil");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.Mengeneinheit)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mengeneinheit");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RezeptId).HasColumnName("rezeptId");

                entity.Property(e => e.Rezeptkategorie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rezeptkategorie");
            });

            modelBuilder.Entity<ViewRezeptUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RezeptUebersicht");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Ausgabemenge).HasColumnName("ausgabemenge");

                entity.Property(e => e.Ausgabemengeneinheit)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ausgabemengeneinheit");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzerName");

                entity.Property(e => e.GrammProStueck).HasColumnName("grammProStueck");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstMenuebestandteil).HasColumnName("istMenuebestandteil");

                entity.Property(e => e.Nettopreis).HasColumnName("nettopreis");

                entity.Property(e => e.Positionsgroesse)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("positionsgroesse");

                entity.Property(e => e.RezeptAnzeigename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rezeptAnzeigename");

                entity.Property(e => e.RezeptName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rezeptName");

                entity.Property(e => e.RezeptkategorieId).HasColumnName("rezeptkategorieID");

                entity.Property(e => e.RezeptkategorieName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rezeptkategorieName");

                entity.Property(e => e.RezeptportionsgroesseId).HasColumnName("rezeptportionsgroesseId");
            });

            modelBuilder.Entity<ViewSummeBestandsbewegung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SummeBestandsbewegung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerArtikelId).HasColumnName("lager_artikel_id");

                entity.Property(e => e.LagerId).HasColumnName("lager_id");
            });

            modelBuilder.Entity<ViewTarifUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TarifUebersicht");

                entity.Property(e => e.AnteilAv).HasColumnName("anteilAV");

                entity.Property(e => e.AnteilBg).HasColumnName("anteilBG");

                entity.Property(e => e.AnteilHpv).HasColumnName("anteilHPV");

                entity.Property(e => e.AnteilKv).HasColumnName("anteilKV");

                entity.Property(e => e.AnteilPv).HasColumnName("anteilPV");

                entity.Property(e => e.AnteilRv).HasColumnName("anteilRV");

                entity.Property(e => e.AnteilSbp).HasColumnName("anteilSBP");

                entity.Property(e => e.Fallpreisatz).HasColumnName("fallpreisatz");

                entity.Property(e => e.GfbKvpauschal).HasColumnName("gfbKVpauschal");

                entity.Property(e => e.GfbLspauschal).HasColumnName("gfbLSpauschal");

                entity.Property(e => e.GfbRvpauschal).HasColumnName("gfbRVpauschal");

                entity.Property(e => e.GfbUmlageAufwendungsAusglG).HasColumnName("gfbUmlageAufwendungsAusglG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LohnsteigerungGfb).HasColumnName("lohnsteigerung_gfb");

                entity.Property(e => e.LohnsteigerungSonstige).HasColumnName("lohnsteigerung_sonstige");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummer");

                entity.Property(e => e.WoechentlicheArbeitszeit).HasColumnName("woechentlicheArbeitszeit");
            });

            modelBuilder.Entity<ViewTeilgelieferteAuftragspositionen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TeilgelieferteAuftragspositionen");

                entity.Property(e => e.GelieferteMenge).HasColumnName("gelieferteMenge");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ViewUmsatzProKunde>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_UmsatzProKunde");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Debitor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("debitor");

                entity.Property(e => e.Debitorennummer)
                    .HasMaxLength(255)
                    .HasColumnName("debitorennummer");

                entity.Property(e => e.Gesamtumsatz).HasColumnName("gesamtumsatz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");
            });

            modelBuilder.Entity<ViewVeranstaltung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Veranstaltung");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AnzahlTeilnehmer).HasColumnName("anzahlTeilnehmer");

                entity.Property(e => e.AnzahlTeilnehmerMax).HasColumnName("anzahlTeilnehmerMax");

                entity.Property(e => e.Arbeitskreis)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("arbeitskreis");

                entity.Property(e => e.ArbeitskreisId).HasColumnName("arbeitskreisId");

                entity.Property(e => e.AuslastungVeranstaltung).HasColumnName("auslastungVeranstaltung");

                entity.Property(e => e.BeginDatum)
                    .HasColumnType("datetime")
                    .HasColumnName("beginDatum");

                entity.Property(e => e.BenutzerGesamtname)
                    .HasMaxLength(513)
                    .IsUnicode(false)
                    .HasColumnName("benutzerGesamtname");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzerName");

                entity.Property(e => e.BenutzerVorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzerVorname");

                entity.Property(e => e.Dauer).HasColumnName("dauer");

                entity.Property(e => e.Enddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("enddatum");

                entity.Property(e => e.HotelName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hotelName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.KannVeroeffentlichtWerden).HasColumnName("kannVeroeffentlichtWerden");

                entity.Property(e => e.LeiterName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("leiterName");

                entity.Property(e => e.LeiterVorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("leiterVorname");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RaumBeschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("raumBeschreibung");

                entity.Property(e => e.Raumnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("raumnummer");

                entity.Property(e => e.TagungsortName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tagungsortName");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ViewVeranstaltungBasisdaten>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VeranstaltungBasisdaten");

                entity.Property(e => e.AnzahlReferenten).HasColumnName("anzahlReferenten");

                entity.Property(e => e.AnzahlSchnuppermitglieder).HasColumnName("anzahlSchnuppermitglieder");

                entity.Property(e => e.AnzahlTeilnehmer).HasColumnName("anzahlTeilnehmer");

                entity.Property(e => e.AnzahlTeilnehmerGesamt).HasColumnName("anzahlTeilnehmerGesamt");

                entity.Property(e => e.AnzahlTeilnehmerVorgabewert).HasColumnName("anzahlTeilnehmerVorgabewert");

                entity.Property(e => e.Arbeitskreis)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("arbeitskreis");

                entity.Property(e => e.AuslastungVeranstaltung).HasColumnName("auslastungVeranstaltung");

                entity.Property(e => e.BeginDatum)
                    .HasColumnType("datetime")
                    .HasColumnName("beginDatum");

                entity.Property(e => e.Benutzer)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("benutzer");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.Dauer).HasColumnName("dauer");

                entity.Property(e => e.Enddatum)
                    .HasColumnType("datetime")
                    .HasColumnName("enddatum");

                entity.Property(e => e.Hotel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hotel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IstVeroeffentlicht).HasColumnName("istVeroeffentlicht");

                entity.Property(e => e.KannVeroeffentlichtWerden).HasColumnName("kannVeroeffentlichtWerden");

                entity.Property(e => e.Leiter)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("leiter");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProzentsatzChecklisteBearbeitet).HasColumnName("prozentsatzChecklisteBearbeitet");

                entity.Property(e => e.RaumBeschreibung)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("raumBeschreibung");

                entity.Property(e => e.Raumnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("raumnummer");

                entity.Property(e => e.Tagungsort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tagungsort");
            });

            modelBuilder.Entity<ViewVeranstaltungTeilnehmer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VeranstaltungTeilnehmer");

                entity.Property(e => e.Arbeitskreis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("arbeitskreis");

                entity.Property(e => e.Benutzer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("benutzer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MitgliedstatusBeiVeranstaltung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mitgliedstatusBeiVeranstaltung");

                entity.Property(e => e.MitgliedstatusIdBeiVeranstaltung).HasColumnName("mitgliedstatusIdBeiVeranstaltung");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NameKomplett)
                    .HasMaxLength(513)
                    .IsUnicode(false)
                    .HasColumnName("nameKomplett");

                entity.Property(e => e.Teilnehmerart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("teilnehmerart");

                entity.Property(e => e.VeranstaltungId).HasColumnName("veranstaltungId");

                entity.Property(e => e.Veranstaltungsname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("veranstaltungsname");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vorname");
            });

            modelBuilder.Entity<ViewVerlieheneArtikel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VerlieheneArtikel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KundeId).HasColumnName("kundeId");

                entity.Property(e => e.KundeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kundeName");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.VerleihartikelId).HasColumnName("verleihartikelId");
            });

            modelBuilder.Entity<ViewVerteiler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Verteiler");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.AnzahlKunde).HasColumnName("anzahlKunde");

                entity.Property(e => e.Benutzer)
                    .HasMaxLength(511)
                    .IsUnicode(false)
                    .HasColumnName("benutzer");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewWarenbewegungenUebersicht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WarenbewegungenUebersicht");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Artikelname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelname");

                entity.Property(e => e.Artikelnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("artikelnummer");

                entity.Property(e => e.Ersteller)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("ersteller");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LagerId).HasColumnName("lager_id");

                entity.Property(e => e.Menge).HasColumnName("menge");

                entity.Property(e => e.Mengeneinheitname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mengeneinheitname");

                entity.Property(e => e.StckPreis).HasColumnName("stckPreis");
            });

            modelBuilder.Entity<VorgabewerteKennzahlenabweichung>(entity =>
            {
                entity.ToTable("Vorgabewerte_Kennzahlenabweichung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbweichungOben1).HasColumnName("abweichung_oben_1");

                entity.Property(e => e.AbweichungOben1Farbe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abweichung_oben_1_farbe");

                entity.Property(e => e.AbweichungOben2).HasColumnName("abweichung_oben_2");

                entity.Property(e => e.AbweichungOben2Farbe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abweichung_oben_2_farbe");

                entity.Property(e => e.AbweichungUnten1).HasColumnName("abweichung_unten_1");

                entity.Property(e => e.AbweichungUnten1Farbe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abweichung_unten_1_farbe");

                entity.Property(e => e.AbweichungUnten2).HasColumnName("abweichung_unten_2");

                entity.Property(e => e.AbweichungUnten2Farbe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abweichung_unten_2_farbe");

                entity.Property(e => e.Kennzahl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kennzahl");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.VorgabewerteKennzahlenabweichungs)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Kostenstelle");
            });

            modelBuilder.Entity<Vorlagenart>(entity =>
            {
                entity.ToTable("Vorlagenart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Warenwirtschaftskomponente>(entity =>
            {
                entity.ToTable("Warenwirtschaftskomponente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdresseId).HasColumnName("adresseId");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TypId).HasColumnName("typId");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.Warenwirtschaftskomponentes)
                    .HasForeignKey(d => d.AdresseId)
                    .HasConstraintName("FK_Warenwirtschaftskomponente_Adresse");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Warenwirtschaftskomponentes)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Warenwirtschaftskomponente_Kostenstelle");

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.Warenwirtschaftskomponentes)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK_Warenwirtschaftskomponente_Typ");
            });

            modelBuilder.Entity<WawiRechte>(entity =>
            {
                entity.ToTable("Wawi_rechte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.InventurLesen).HasColumnName("inventur_lesen");

                entity.Property(e => e.InventurSchreiben).HasColumnName("inventur_schreiben");

                entity.Property(e => e.LagerLesen).HasColumnName("lager_lesen");

                entity.Property(e => e.LagerSchreiben).HasColumnName("lager_schreiben");

                entity.Property(e => e.RechteId).HasColumnName("rechte_id");

                entity.Property(e => e.WarenentnahmeLesen).HasColumnName("warenentnahme_lesen");

                entity.Property(e => e.WarenentnahmeSchreiben).HasColumnName("warenentnahme_schreiben");

                entity.Property(e => e.WarentransfersLesen).HasColumnName("warentransfers_lesen");

                entity.Property(e => e.WarentransfersSchreiben).HasColumnName("warentransfers_schreiben");

                entity.Property(e => e.WarenwirtschaftskomponenteId).HasColumnName("warenwirtschaftskomponente_id");

                entity.HasOne(d => d.Rechte)
                    .WithMany(p => p.WawiRechtes)
                    .HasForeignKey(d => d.RechteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wawi_rechte_Rechte1");

                entity.HasOne(d => d.Warenwirtschaftskomponente)
                    .WithMany(p => p.WawiRechtes)
                    .HasForeignKey(d => d.WarenwirtschaftskomponenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wawi_rechte_WawiKomponente");
            });

            modelBuilder.Entity<WawiTyp>(entity =>
            {
                entity.ToTable("Wawi_Typ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Wawistatistik>(entity =>
            {
                entity.ToTable("Wawistatistik");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Typ).HasColumnName("typ");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Wawistatistiks)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wawistatistik_Betriebsstaette");
            });

            modelBuilder.Entity<WawistatistikSpalte>(entity =>
            {
                entity.ToTable("WawistatistikSpalte");

                entity.Property(e => e.SpaltenName).HasMaxLength(50);

                entity.HasOne(d => d.WawistatistikZeile)
                    .WithMany(p => p.WawistatistikSpaltes)
                    .HasForeignKey(d => d.WawistatistikZeileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WawistatistikSpalte_WawistatistikZeile");
            });

            modelBuilder.Entity<WawistatistikZeile>(entity =>
            {
                entity.ToTable("WawistatistikZeile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Spalte01).HasColumnName("spalte01");

                entity.Property(e => e.Spalte02).HasColumnName("spalte02");

                entity.Property(e => e.Spalte03).HasColumnName("spalte03");

                entity.Property(e => e.Spalte04).HasColumnName("spalte04");

                entity.Property(e => e.Spalte05).HasColumnName("spalte05");

                entity.Property(e => e.Spalte06).HasColumnName("spalte06");

                entity.Property(e => e.Spalte07).HasColumnName("spalte07");

                entity.Property(e => e.Spalte08).HasColumnName("spalte08");

                entity.Property(e => e.Spalte09).HasColumnName("spalte09");

                entity.Property(e => e.Spalte10).HasColumnName("spalte10");

                entity.Property(e => e.WawistatistikId).HasColumnName("wawistatistikId");

                entity.HasOne(d => d.Wawistatistik)
                    .WithMany(p => p.WawistatistikZeiles)
                    .HasForeignKey(d => d.WawistatistikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WawistatistikZeile_Wawistatistik");
            });

            modelBuilder.Entity<Wohnung>(entity =>
            {
                entity.ToTable("Wohnung");

                entity.HasIndex(e => new { e.BetriebsstaetteId, e.Aktiv }, "IDX_Wohnung_Betriebsstaette_Aktiv");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.BetriebsstaetteId).HasColumnName("betriebsstaetteId");

                entity.Property(e => e.Kaltmiete).HasColumnName("kaltmiete");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelleId");

                entity.Property(e => e.Nebenkosten).HasColumnName("nebenkosten");

                entity.Property(e => e.Nr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nr");

                entity.Property(e => e.Pauschale1).HasColumnName("pauschale1");

                entity.Property(e => e.Pauschale2).HasColumnName("pauschale2");

                entity.Property(e => e.Qm).HasColumnName("qm");

                entity.HasOne(d => d.Betriebsstaette)
                    .WithMany(p => p.Wohnungs)
                    .HasForeignKey(d => d.BetriebsstaetteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wohnung_Betriebsstaette");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Wohnungs)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Wohnung_Kostenstelle");
            });

            modelBuilder.Entity<Wohnungsinformation>(entity =>
            {
                entity.ToTable("Wohnungsinformation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Groesse).HasColumnName("groesse");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Kaltmiete).HasColumnName("kaltmiete");

                entity.Property(e => e.KostenstelleId).HasColumnName("kostenstelle_id");

                entity.Property(e => e.Nebenkosten).HasColumnName("nebenkosten");

                entity.Property(e => e.Pauschale1).HasColumnName("pauschale1");

                entity.Property(e => e.Pauschale2).HasColumnName("pauschale2");

                entity.Property(e => e.WohnungId).HasColumnName("wohnung_id");

                entity.HasOne(d => d.Kostenstelle)
                    .WithMany(p => p.Wohnungsinformations)
                    .HasForeignKey(d => d.KostenstelleId)
                    .HasConstraintName("FK_Wohnungsinformation_Kostenstelle");

                entity.HasOne(d => d.Wohnung)
                    .WithMany(p => p.Wohnungsinformations)
                    .HasForeignKey(d => d.WohnungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wohnungsinformation_Wohnung");
            });

            modelBuilder.Entity<Zahlungsart>(entity =>
            {
                entity.ToTable("Zahlungsart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ZiviTarif>(entity =>
            {
                entity.ToTable("ZiviTarif");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aktiv).HasColumnName("aktiv");

                entity.Property(e => e.Arbeitskleidung).HasColumnName("arbeitskleidung");

                entity.Property(e => e.EntlassungsGeld).HasColumnName("entlassungsGeld");

                entity.Property(e => e.Erstattungentlassungsgeld).HasColumnName("erstattungentlassungsgeld");

                entity.Property(e => e.FahrtkostenHoechstbetrag).HasColumnName("fahrtkostenHoechstbetrag");

                entity.Property(e => e.FahrtkostenProKilometer).HasColumnName("fahrtkostenProKilometer");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigBis");

                entity.Property(e => e.GueltigVon)
                    .HasColumnType("datetime")
                    .HasColumnName("gueltigVon");

                entity.Property(e => e.Pauschalerstattung).HasColumnName("pauschalerstattung");

                entity.Property(e => e.Reinigung).HasColumnName("reinigung");

                entity.Property(e => e.Sold1).HasColumnName("sold1");

                entity.Property(e => e.Sold2).HasColumnName("sold2");

                entity.Property(e => e.Sold3).HasColumnName("sold3");

                entity.Property(e => e.VerpflegungAbendessen).HasColumnName("verpflegungAbendessen");

                entity.Property(e => e.VerpflegungFruehstueck).HasColumnName("verpflegungFruehstueck");

                entity.Property(e => e.VerpflegungMittagessen).HasColumnName("verpflegungMittagessen");

                entity.Property(e => e.WeihnachtsGeld).HasColumnName("weihnachtsGeld");
            });

            modelBuilder.Entity<ZuordnungGehaltSozialversicherung>(entity =>
            {
                entity.ToTable("Zuordnung_GehaltSozialversicherung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SachkontenkategorieId).HasColumnName("sachkontenkategorieId");

                entity.Property(e => e.SachkontoGehaltId).HasColumnName("sachkonto_GehaltId");

                entity.Property(e => e.SachkontoSvid).HasColumnName("sachkonto_SVId");

                entity.HasOne(d => d.Sachkontenkategorie)
                    .WithMany(p => p.ZuordnungGehaltSozialversicherungs)
                    .HasForeignKey(d => d.SachkontenkategorieId)
                    .HasConstraintName("FK_Zuordnung_GehaltSozialversicherung_Sachkontenkategorie");

                entity.HasOne(d => d.SachkontoGehalt)
                    .WithMany(p => p.ZuordnungGehaltSozialversicherungSachkontoGehalts)
                    .HasForeignKey(d => d.SachkontoGehaltId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zuordnung_GehaltSozialversicherung_Sachkonto");

                entity.HasOne(d => d.SachkontoSv)
                    .WithMany(p => p.ZuordnungGehaltSozialversicherungSachkontoSvs)
                    .HasForeignKey(d => d.SachkontoSvid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zuordnung_GehaltSozialversicherung_Sachkonto1");
            });

            modelBuilder.Entity<Zuschlag>(entity =>
            {
                entity.ToTable("Zuschlag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aenderungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("aenderungsdatum");

                entity.Property(e => e.Aktiv)
                    .IsRequired()
                    .HasColumnName("aktiv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bemerkung");

                entity.Property(e => e.BenutzerId).HasColumnName("benutzer_id");

                entity.Property(e => e.Betrag).HasColumnName("betrag");

                entity.Property(e => e.Erstellungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("erstellungsdatum");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nummer");

                entity.Property(e => e.Relativ).HasColumnName("relativ");

                entity.Property(e => e.StandardaufschlagFuerAuftrag).HasColumnName("standardaufschlagFuerAuftrag");

                entity.Property(e => e.SteuernId).HasColumnName("steuern_id");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.Zuschlags)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zuschlag_Benutzer");

                entity.HasOne(d => d.Steuern)
                    .WithMany(p => p.Zuschlags)
                    .HasForeignKey(d => d.SteuernId)
                    .HasConstraintName("FK_Zuschlag_Steuern");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
