using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Dateiverknuepfung
    {
        public int Id { get; set; }
        public int DateiId { get; set; }
        public string Verknuepfungsklasse { get; set; }
        public int VerknuepfungsklassenId { get; set; }

        public virtual Datei Datei { get; set; }
    }
}
