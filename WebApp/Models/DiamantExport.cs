using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DiamantExport
    {
        public DiamantExport()
        {
            DiamantExportDatensatzs = new HashSet<DiamantExportDatensatz>();
        }

        public int Id { get; set; }
        public int? KalkulationId { get; set; }
        public int BenutzerId { get; set; }
        public int? BetriebsstaetteId { get; set; }
        public int? SchnittstellenartId { get; set; }
        public string Planalternative { get; set; }
        public DateTime ExportDatum { get; set; }
        public DateTime? GeloeschtDatum { get; set; }
        public bool? Aktiv { get; set; }
        public bool IstVerarbeitet { get; set; }
        public int? KonsolidierungId { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Schnittstellenart Schnittstellenart { get; set; }
        public virtual ICollection<DiamantExportDatensatz> DiamantExportDatensatzs { get; set; }
    }
}
