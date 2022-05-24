using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewBenutzeruebersicht
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public DateTime? LetzterLogin { get; set; }
        public int? RegionaleZuordnungId { get; set; }
        public string RegionaleZuordnungName { get; set; }
    }
}
