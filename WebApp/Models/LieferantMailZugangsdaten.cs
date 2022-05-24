using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class LieferantMailZugangsdaten
    {
        public int Id { get; set; }
        public int LieferantId { get; set; }
        public int MailZugangsdatenId { get; set; }

        public virtual Lieferant Lieferant { get; set; }
        public virtual MailZugangsdaten MailZugangsdaten { get; set; }
    }
}
