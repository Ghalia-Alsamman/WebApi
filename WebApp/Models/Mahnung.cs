using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mahnung
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int BelegId { get; set; }
        public int BenutzerId { get; set; }
        public string Bezeichnung { get; set; }
        public double Betrag { get; set; }
        public int Mahnstufe { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Erstellungsdatum { get; set; }

        public virtual Beleg Beleg { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Kunde Kunde { get; set; }
    }
}
