using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerAktion
    {
        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int BenutzerAktionsartId { get; set; }
        public string Aktion { get; set; }
        public string ComputerName { get; set; }
        public string Ip { get; set; }
        public string Betriebssystem { get; set; }
        public string BetriebssystemBenutzer { get; set; }
        public DateTime Datum { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual BenutzerAktionsart BenutzerAktionsart { get; set; }
    }
}
