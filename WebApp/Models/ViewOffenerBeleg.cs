using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewOffenerBeleg
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int BelegartId { get; set; }
        public int? AuftragId { get; set; }
        public string Belegnummer { get; set; }
        public DateTime? Belegdatum { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public string BelegartName { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public string AuftragsnummerIntern { get; set; }
        public string Name { get; set; }
        public DateTime Auftragsdatum { get; set; }
        public double Auftragsvolumen { get; set; }
        public string Debitorenname { get; set; }
        public string Debitorennummer { get; set; }
    }
}
