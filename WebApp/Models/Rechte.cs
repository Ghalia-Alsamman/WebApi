using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Rechte
    {
        public Rechte()
        {
            Benutzers = new HashSet<Benutzer>();
            BsRechtes = new HashSet<BsRechte>();
            Gruppes = new HashSet<Gruppe>();
            WawiRechtes = new HashSet<WawiRechte>();
        }

        public int Id { get; set; }
        public bool AngebotsverwaltungLesen { get; set; }
        public bool AngebotsverwaltungSchreiben { get; set; }
        public bool BenutzerverwaltungLesen { get; set; }
        public bool BenutzerverwaltungSchreiben { get; set; }
        public bool KundenverwaltungLesen { get; set; }
        public bool KundenverwaltungSchreiben { get; set; }
        public bool StammdatenverwaltungLesen { get; set; }
        public bool StammdatenverwaltungSchreiben { get; set; }
        public bool KalkulationCatLesen { get; set; }
        public bool KalkulationCatSchreiben { get; set; }
        public bool KalkulationUrLesen { get; set; }
        public bool KalkulationUrSchreiben { get; set; }
        public bool KalkulationOverheadLesen { get; set; }
        public bool KalkulatoonOverheadSchreiben { get; set; }
        public bool KalkulationCafeLesen { get; set; }
        public bool KalkulationCafeSchreiben { get; set; }
        public bool KalkulationKioskLesen { get; set; }
        public bool KalkulationKioskSchreiben { get; set; }
        public bool AfaArtikelSchreiben { get; set; }
        public bool OfflineArbeiten { get; set; }
        public bool KonsolidierungAufGesellschafterebene { get; set; }
        public bool WawiGlobal { get; set; }
        public bool EinrichrungGlobal { get; set; }
        public bool Root { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual ICollection<Benutzer> Benutzers { get; set; }
        public virtual ICollection<BsRechte> BsRechtes { get; set; }
        public virtual ICollection<Gruppe> Gruppes { get; set; }
        public virtual ICollection<WawiRechte> WawiRechtes { get; set; }
    }
}
