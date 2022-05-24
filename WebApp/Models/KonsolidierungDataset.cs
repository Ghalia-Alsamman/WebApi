using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungDataset
    {
        public int Id { get; set; }
        public int KonsolidierungDatenExportId { get; set; }
        public int ExportArt { get; set; }
        public string Spalte1 { get; set; }
        public string Spalte2 { get; set; }
        public string Spalte3 { get; set; }
        public string Spalte4 { get; set; }
        public string Spalte5 { get; set; }
        public string Spalte6 { get; set; }
        public string Spalte7 { get; set; }
        public string Spalte8 { get; set; }
        public string Spalte9 { get; set; }
        public string Spalte10 { get; set; }
        public string Spalte11 { get; set; }
        public string Spalte12 { get; set; }
        public string Spalte13 { get; set; }
        public string Spalte14 { get; set; }
        public string Spalte15 { get; set; }

        public virtual KonsolidierungDatenExport KonsolidierungDatenExport { get; set; }
    }
}
