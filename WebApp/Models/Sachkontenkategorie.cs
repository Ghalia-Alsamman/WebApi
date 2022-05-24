using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Sachkontenkategorie
    {
        public Sachkontenkategorie()
        {
            Buchungstags = new HashSet<Buchungstag>();
            Sachkontos = new HashSet<Sachkonto>();
            ZuordnungGehaltSozialversicherungs = new HashSet<ZuordnungGehaltSozialversicherung>();
        }

        public int Id { get; set; }
        public int? TypId { get; set; }
        public string Name { get; set; }
        public int? SachkontoLmsteuerId { get; set; }
        public int? SachkontoVolleSteuerId { get; set; }
        public int? SachkontoKalkGewSteuerId { get; set; }
        public int? SachkontoKalkKoerpSteuerId { get; set; }
        public int? SachkontoVerwKostenId { get; set; }
        public int? SachkontoZgastId { get; set; }
        public double? Stundenwoche { get; set; }
        public int? SachkontoErloeseLebensmittelId { get; set; }
        public int? SachkontoErloeseGetraenke7Id { get; set; }
        public int? SachkontoErloeseGetraenke19Id { get; set; }
        public int? SachkontoCateringErloeseId { get; set; }
        public int? SachkontoErloeseVerwaltungId { get; set; }
        public int? SachkontoUhrerloeseId { get; set; }
        public bool Aktiv { get; set; }
        public int? SachkontoOperMgmtAufschlagId { get; set; }
        public int? SachkontoErloeseOperMgmtAufschlagId { get; set; }

        public virtual Sachkonto SachkontoCateringErloese { get; set; }
        public virtual Sachkonto SachkontoErloeseGetraenke19 { get; set; }
        public virtual Sachkonto SachkontoErloeseGetraenke7 { get; set; }
        public virtual Sachkonto SachkontoErloeseLebensmittel { get; set; }
        public virtual Sachkonto SachkontoErloeseOperMgmtAufschlag { get; set; }
        public virtual Sachkonto SachkontoErloeseVerwaltung { get; set; }
        public virtual Sachkonto SachkontoKalkGewSteuer { get; set; }
        public virtual Sachkonto SachkontoKalkKoerpSteuer { get; set; }
        public virtual Sachkonto SachkontoLmsteuer { get; set; }
        public virtual Sachkonto SachkontoOperMgmtAufschlag { get; set; }
        public virtual Sachkonto SachkontoUhrerloese { get; set; }
        public virtual Sachkonto SachkontoVerwKosten { get; set; }
        public virtual Sachkonto SachkontoVolleSteuer { get; set; }
        public virtual Sachkonto SachkontoZgast { get; set; }
        public virtual Typ Typ { get; set; }
        public virtual ICollection<Buchungstag> Buchungstags { get; set; }
        public virtual ICollection<Sachkonto> Sachkontos { get; set; }
        public virtual ICollection<ZuordnungGehaltSozialversicherung> ZuordnungGehaltSozialversicherungs { get; set; }
    }
}
