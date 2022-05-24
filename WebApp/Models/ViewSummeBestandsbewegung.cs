using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewSummeBestandsbewegung
    {
        public int? Id { get; set; }
        public int? LagerId { get; set; }
        public int LagerArtikelId { get; set; }
        public double? Menge { get; set; }
    }
}
