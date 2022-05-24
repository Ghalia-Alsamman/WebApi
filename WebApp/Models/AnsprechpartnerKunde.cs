using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class AnsprechpartnerKunde
    {
        public int Id { get; set; }
        public int? AnsprechpartnerId { get; set; }
        public int KundeId { get; set; }
        public int? KundeVaterId { get; set; }
        public int? AnsprechpartnerartId { get; set; }

        public virtual Ansprechpartner Ansprechpartner { get; set; }
        public virtual Ansprechpartnerart Ansprechpartnerart { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual Kunde KundeVater { get; set; }
    }
}
