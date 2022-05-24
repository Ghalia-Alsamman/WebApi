using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class FtpZugangsdaten
    {
        public int Id { get; set; }
        public string FtpServer { get; set; }
        public string FtpOrdner { get; set; }
        public string FtpBenutzer { get; set; }
        public string FtpPasswort { get; set; }
        public string Dateiname { get; set; }
    }
}
