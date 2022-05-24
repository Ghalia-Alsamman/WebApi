using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Datenbankverbindungen
    {
        public int Id { get; set; }
        public string Assemblyname { get; set; }
        public string Datenbankname { get; set; }
        public string Datenbankserver { get; set; }
        public string Datenbankzugangsdaten { get; set; }
    }
}
