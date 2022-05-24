using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewLager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Anzahl { get; set; }
        public int? BenutzerId { get; set; }
        public string Benutzername { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
    }
}
