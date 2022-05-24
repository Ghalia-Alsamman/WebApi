using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Benutzereinstellungen
    {
        public int Id { get; set; }
        public int? BenutzerId { get; set; }
        public bool KalkulationZeigeErtragslage { get; set; }
        public bool KalkulationStarteMaximiert { get; set; }
        public bool KalkulationZeigeFortschritt { get; set; }
        public bool ViewFixiereMenu { get; set; }
        public bool DeaktiviereWaitCursor { get; set; }
        public bool EinrichtungStarteMaximiert { get; set; }
        public bool ExpandSachkonten { get; set; }
        public bool MfpStarteMaximiert { get; set; }

        public virtual Benutzer Benutzer { get; set; }
    }
}
