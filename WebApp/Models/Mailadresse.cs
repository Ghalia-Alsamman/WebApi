using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mailadresse
    {
        public int Id { get; set; }
        public int MailadressartId { get; set; }
        public int KontaktinformationId { get; set; }
        public string Adresse { get; set; }

        public virtual Kontaktinformation Kontaktinformation { get; set; }
        public virtual Mailadressart Mailadressart { get; set; }
    }
}
