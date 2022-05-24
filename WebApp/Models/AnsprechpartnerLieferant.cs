using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class AnsprechpartnerLieferant
    {
        public int Id { get; set; }
        public int AnsprechpartnerId { get; set; }
        public int LieferantId { get; set; }

        public virtual Ansprechpartner Ansprechpartner { get; set; }
        public virtual Lieferant Lieferant { get; set; }
    }
}
