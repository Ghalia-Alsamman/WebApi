using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBuOffeneAenderungenKalkulation
    {
        public int Id { get; set; }
        public string Gesellschaft { get; set; }
        public string Debitor { get; set; }
        public string Kalkulation { get; set; }
        public string Bearbeiter { get; set; }
        public DateTime LetzteÄnderung { get; set; }
    }
}
