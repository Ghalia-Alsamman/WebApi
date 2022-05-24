using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewLetzterLogin
    {
        public int? Id { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public int? Anzahl { get; set; }
        public DateTime? ErsterLogin { get; set; }
        public DateTime? LetzterLogin { get; set; }
    }
}
