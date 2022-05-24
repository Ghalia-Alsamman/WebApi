using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class AuftragAuftragstatus
    {
        public int Id { get; set; }
        public int AuftragId { get; set; }
        public int AuftragstatusId { get; set; }
        public int BenutzerId { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }

        public virtual Auftrag Auftrag { get; set; }
        public virtual Auftragstatus Auftragstatus { get; set; }
        public virtual Benutzer Benutzer { get; set; }
    }
}
