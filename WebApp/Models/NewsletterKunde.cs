using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class NewsletterKunde
    {
        public int Id { get; set; }
        public int NewsletterId { get; set; }
        public int KundeId { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual Newsletter Newsletter { get; set; }
    }
}
