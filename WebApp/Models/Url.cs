using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Url
    {
        public int Id { get; set; }
        public int KontaktinformationId { get; set; }
        public int UrlartId { get; set; }
        public string Url1 { get; set; }

        public virtual Kontaktinformation Kontaktinformation { get; set; }
        public virtual Urlart Urlart { get; set; }
    }
}
