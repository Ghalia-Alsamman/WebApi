using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Auftragstatus
    {
        public Auftragstatus()
        {
            AuftragAuftragstatuses = new HashSet<AuftragAuftragstatus>();
            AuftragsverwaltungStatischerBereichBerechtigungs = new HashSet<AuftragsverwaltungStatischerBereichBerechtigung>();
            Belegs = new HashSet<Beleg>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AnzeigeName { get; set; }
        public string Beschreibung { get; set; }
        public int ReihenfolgeNr { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<AuftragAuftragstatus> AuftragAuftragstatuses { get; set; }
        public virtual ICollection<AuftragsverwaltungStatischerBereichBerechtigung> AuftragsverwaltungStatischerBereichBerechtigungs { get; set; }
        public virtual ICollection<Beleg> Belegs { get; set; }
    }
}
