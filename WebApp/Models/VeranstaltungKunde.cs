using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class VeranstaltungKunde
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int VeranstaltungId { get; set; }
        public int VeranstaltungteilnehmerartId { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual Veranstaltung Veranstaltung { get; set; }
        public virtual Veranstaltungsteilnehmerart Veranstaltungteilnehmerart { get; set; }
    }
}
