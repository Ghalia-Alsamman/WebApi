using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Berufsgruppe
    {
        public Berufsgruppe()
        {
            Ansprechpartners = new HashSet<Ansprechpartner>();
            BerufsgruppeSachkontos = new HashSet<BerufsgruppeSachkonto>();
            BetriebsstaetteSachkontoKostenstelleDienstarts = new HashSet<BetriebsstaetteSachkontoKostenstelleDienstart>();
            BetriebsstaetteVerprobungsfaktors = new HashSet<BetriebsstaetteVerprobungsfaktor>();
            KonsolidierungPersonaleinsatzs = new HashSet<KonsolidierungPersonaleinsatz>();
            KonsolidierungPersonals = new HashSet<KonsolidierungPersonal>();
            Personaleinsatzs = new HashSet<Personaleinsatz>();
            Personalerloeses = new HashSet<Personalerloese>();
            Personals = new HashSet<Personal>();
            TarifBerufsgruppes = new HashSet<TarifBerufsgruppe>();
        }

        public int Id { get; set; }
        public int? PersonalfaktorId { get; set; }
        public int? BenutzerId { get; set; }
        public string Name { get; set; }
        public int? Nummer { get; set; }
        public bool IstGfb { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public bool Aktiv { get; set; }
        public int? VerprobungsfaktorId { get; set; }
        public double Tagessatz { get; set; }
        public double Fq { get; set; }
        public bool IstUmsatzRelevant { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Personalfaktor Personalfaktor { get; set; }
        public virtual Verprobungsfaktor Verprobungsfaktor { get; set; }
        public virtual ICollection<Ansprechpartner> Ansprechpartners { get; set; }
        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontos { get; set; }
        public virtual ICollection<BetriebsstaetteSachkontoKostenstelleDienstart> BetriebsstaetteSachkontoKostenstelleDienstarts { get; set; }
        public virtual ICollection<BetriebsstaetteVerprobungsfaktor> BetriebsstaetteVerprobungsfaktors { get; set; }
        public virtual ICollection<KonsolidierungPersonaleinsatz> KonsolidierungPersonaleinsatzs { get; set; }
        public virtual ICollection<KonsolidierungPersonal> KonsolidierungPersonals { get; set; }
        public virtual ICollection<Personaleinsatz> Personaleinsatzs { get; set; }
        public virtual ICollection<Personalerloese> Personalerloeses { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<TarifBerufsgruppe> TarifBerufsgruppes { get; set; }
    }
}
