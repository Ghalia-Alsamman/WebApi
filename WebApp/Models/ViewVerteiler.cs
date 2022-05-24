using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewVerteiler
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? AnzahlKunde { get; set; }
        public string Benutzer { get; set; }
        public int? BenutzerId { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
    }
}
