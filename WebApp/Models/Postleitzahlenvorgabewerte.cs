using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Postleitzahlenvorgabewerte
    {
        public int Id { get; set; }
        public int LandId { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Suchname { get; set; }
        public string Territorium { get; set; }
        public string Alort { get; set; }
        public string Zusatz { get; set; }
        public string Ortsname { get; set; }
        public bool Postfach { get; set; }
        public bool Schalterausgabe { get; set; }
        public bool Aktionsplz { get; set; }
        public bool Zustellung { get; set; }
        public bool ZustellungUndPostfach { get; set; }
        public bool ZusatzGehoertZuName { get; set; }
        public string Kgs { get; set; }

        public virtual Land Land { get; set; }
    }
}
