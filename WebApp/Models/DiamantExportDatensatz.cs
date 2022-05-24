using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DiamantExportDatensatz
    {
        public int Id { get; set; }
        public int DiamantexportId { get; set; }
        public string Planalternative { get; set; }
        public string Refnr { get; set; }
        public int Lfdnr { get; set; }
        public string Satzart { get; set; }
        public string Zielsatzart { get; set; }
        public string Vkz { get; set; }
        public int Kostenstelle { get; set; }
        public int Sachkonto { get; set; }
        public int Kostenart { get; set; }
        public string Buchungsperiode { get; set; }
        public double? Kostenfix { get; set; }
        public double? Kostenvariable { get; set; }
        public string Betriebskalender { get; set; }
        public string Wertschreibeart { get; set; }
        public string Status { get; set; }
        public bool Istverarbeitet { get; set; }
        public bool Istgeloescht { get; set; }

        public virtual DiamantExport Diamantexport { get; set; }
    }
}
