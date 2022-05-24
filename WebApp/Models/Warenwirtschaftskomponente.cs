using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Warenwirtschaftskomponente
    {
        public Warenwirtschaftskomponente()
        {
            Abrechnungs = new HashSet<Abrechnung>();
            Bekoestigungstages = new HashSet<Bekoestigungstage>();
            Bestellungs = new HashSet<Bestellung>();
            LagerWarenwirtschaftskomponentes = new HashSet<LagerWarenwirtschaftskomponente>();
            Rechnungseingangslistes = new HashSet<Rechnungseingangsliste>();
            Sonderveranstaltungs = new HashSet<Sonderveranstaltung>();
            TransferWarenwirtschaftskomponentes = new HashSet<TransferWarenwirtschaftskomponente>();
            WawiRechtes = new HashSet<WawiRechte>();
        }

        public int Id { get; set; }
        public int? KostenstelleId { get; set; }
        public int? AdresseId { get; set; }
        public int? TypId { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual WawiTyp Typ { get; set; }
        public virtual ICollection<Abrechnung> Abrechnungs { get; set; }
        public virtual ICollection<Bekoestigungstage> Bekoestigungstages { get; set; }
        public virtual ICollection<Bestellung> Bestellungs { get; set; }
        public virtual ICollection<LagerWarenwirtschaftskomponente> LagerWarenwirtschaftskomponentes { get; set; }
        public virtual ICollection<Rechnungseingangsliste> Rechnungseingangslistes { get; set; }
        public virtual ICollection<Sonderveranstaltung> Sonderveranstaltungs { get; set; }
        public virtual ICollection<TransferWarenwirtschaftskomponente> TransferWarenwirtschaftskomponentes { get; set; }
        public virtual ICollection<WawiRechte> WawiRechtes { get; set; }
    }
}
