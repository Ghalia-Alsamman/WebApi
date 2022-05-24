using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ChecklisteneintragVeranstaltung
    {
        public int Id { get; set; }
        public int VeranstaltungId { get; set; }
        public int? ChecklisteneintragId { get; set; }
        public bool IstChecked { get; set; }
        public string Name { get; set; }

        public virtual Checklisteintrag Checklisteneintrag { get; set; }
        public virtual Veranstaltung Veranstaltung { get; set; }
    }
}
