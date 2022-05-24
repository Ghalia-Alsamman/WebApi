using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeBestandteilKommunikation
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string MailadresseGeschaeftlich { get; set; }
        public string MailadressePrivat { get; set; }
        public string Telefonnummergeschaeftlich { get; set; }
        public string Telefonnummerprivat { get; set; }
        public string Telefonnummermobil { get; set; }
        public string Telefonfax { get; set; }
    }
}
