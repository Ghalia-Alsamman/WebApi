using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewMenueplanBestandteile
    {
        public int Id { get; set; }
        public int? MenueplanId { get; set; }
        public string Menueplan { get; set; }
        public DateTime? Datum { get; set; }
        public string Alternative { get; set; }
        public int? MenueAlternativeNr { get; set; }
        public int? MenueAlternativeId { get; set; }
        public string Text { get; set; }
    }
}
