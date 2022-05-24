using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MenueplanZeitpunkt
    {
        public MenueplanZeitpunkt()
        {
            AuftragMenueplanZeitpunkts = new HashSet<AuftragMenueplanZeitpunkt>();
            MenueplanZeitpunktArtikelverkaufRezepts = new HashSet<MenueplanZeitpunktArtikelverkaufRezept>();
        }

        public int Id { get; set; }
        public int MenueplanTagId { get; set; }
        public DateTime Zeitpunkt { get; set; }
        public string Text { get; set; }
        public bool Textmanuell { get; set; }
        public double Verkaufspreis { get; set; }
        public double GeschaetzteMenge { get; set; }

        public virtual MenueplanTag MenueplanTag { get; set; }
        public virtual ICollection<AuftragMenueplanZeitpunkt> AuftragMenueplanZeitpunkts { get; set; }
        public virtual ICollection<MenueplanZeitpunktArtikelverkaufRezept> MenueplanZeitpunktArtikelverkaufRezepts { get; set; }
    }
}
