using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BsRechte
    {
        public int Id { get; set; }
        public int RechteId { get; set; }
        public int BetriebsstaetteId { get; set; }
        public bool KuechenLesen { get; set; }
        public bool KuechenSchreiben { get; set; }
        public bool LieferantenLesen { get; set; }
        public bool LieferantenSchreiben { get; set; }
        public bool ArtikelLesen { get; set; }
        public bool ArtikelSchreiben { get; set; }
        public bool EssensstatistikLesen { get; set; }
        public bool EssensstatistikSchreiben { get; set; }
        public bool ErloesstatistikLesen { get; set; }
        public bool ErloesstatistikSchreiben { get; set; }
        public bool RelLesen { get; set; }
        public bool RelSchreiben { get; set; }
        public bool WareneinsatzLesen { get; set; }
        public bool WareneinsatzSchreiben { get; set; }
        public bool InventurFuerAlleWawiKomponenten { get; set; }
        public bool WarentransferFuerAlleWawiKomponenten { get; set; }
        public bool WarentransferFuerEventkostenstelle { get; set; }
        public bool EinrichtungsverwaltungLesen { get; set; }
        public bool EinrichtungsverwaltungSchreiben { get; set; }
        public bool BudgetierungLesen { get; set; }
        public bool BudgetierungSchreiben { get; set; }
        public bool KonsolidierungLesen { get; set; }
        public bool KonsolidierungSchreiben { get; set; }
        public bool FinanzplanungLesen { get; set; }
        public bool FinanzplanungSchreiben { get; set; }
        public bool BudgetierungSchreibrechteAuslastungsplanung { get; set; }
        public bool BudgetierungSchreibrechteWohnung { get; set; }
        public bool BudgetierungSchreibrechtePersonalplanung { get; set; }
        public bool BudgetierungSchreibrechtePersonalkosten { get; set; }
        public bool BudgetierungSchreibrechtePersonalplanungzdl { get; set; }
        public bool BudgetierungSchreibrechteAfa { get; set; }
        public bool BudgetierungSchreibrechteSachkostenplanung { get; set; }
        public bool CateringLesen { get; set; }
        public bool CateringSchreiben { get; set; }
        public bool UnterhaltsreinigungLesen { get; set; }
        public bool UnterhaltsreinigungSchreiben { get; set; }
        public bool KioskLesen { get; set; }
        public bool KioskSchreiben { get; set; }
        public bool CafeLesen { get; set; }
        public bool CafeSchreiben { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Rechte Rechte { get; set; }
    }
}
