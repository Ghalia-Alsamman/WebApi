using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewAuftragAuftragstatus
    {
        public int Id { get; set; }
        public string AuftragsnummerIntern { get; set; }
        public string AuftragsnummerExtern { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public string AuftragstatusName { get; set; }
        public int AuftragstatusId { get; set; }
        public int ReihenfolgeNr { get; set; }
        public DateTime Aenderungsdatum { get; set; }
    }
}
