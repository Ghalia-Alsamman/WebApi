using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class VerteilerKunde
    {
        public int Id { get; set; }
        public int VerteilerId { get; set; }
        public int KundeId { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual Verteiler Verteiler { get; set; }
    }
}
