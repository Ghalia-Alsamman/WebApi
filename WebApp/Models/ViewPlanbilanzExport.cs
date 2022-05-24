using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewPlanbilanzExport
    {
        public long? Id { get; set; }
        public string RefNr { get; set; }
        public int LfdNr { get; set; }
        public string Satzart { get; set; }
        public string Satz { get; set; }
        public int Status { get; set; }
        public int? PlanbilanzId { get; set; }
    }
}
