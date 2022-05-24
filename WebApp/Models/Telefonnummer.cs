using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Telefonnummer
    {
        public int Id { get; set; }
        public int KontaktinformationId { get; set; }
        public int TelefonartId { get; set; }
        public string Nummer { get; set; }

        public virtual Kontaktinformation Kontaktinformation { get; set; }
        public virtual Telefonart Telefonart { get; set; }
    }
}
