using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewLagerArtikelNiedrigsterEinkaufsprei
    {
        public int Id { get; set; }
        public int? ArtikelId { get; set; }
        public int? LagerId { get; set; }
        public double? NiedrigsterPreis { get; set; }
    }
}
