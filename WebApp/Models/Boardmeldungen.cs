using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Boardmeldungen
    {
        public int Id { get; set; }
        public string Ueberschrift { get; set; }
        public string Text { get; set; }
        public DateTime? Gelesen { get; set; }
        public DateTime DatumVon { get; set; }
        public DateTime DatumBis { get; set; }
        public int BoardkategorieId { get; set; }

        public virtual Boardkategorie Boardkategorie { get; set; }
    }
}
