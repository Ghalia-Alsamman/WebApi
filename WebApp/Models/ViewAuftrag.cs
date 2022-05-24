using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewAuftrag
    {
        public int Id { get; set; }
        public string AuftragsnummerIntern { get; set; }
        public string AuftragsnummerExtern { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public string Auftragstatus { get; set; }
        public string Name { get; set; }
        public double Auftragsvolumen { get; set; }
        public string Kundenname { get; set; }
        public string Kundennummer { get; set; }
        public DateTime? GeplantFuer { get; set; }
    }
}
