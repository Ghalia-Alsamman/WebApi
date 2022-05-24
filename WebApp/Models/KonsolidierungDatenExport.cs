using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungDatenExport
    {
        public KonsolidierungDatenExport()
        {
            KonsolidierungDatasets = new HashSet<KonsolidierungDataset>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Sachkontenrahmen { get; set; }
        public DateTime Datum { get; set; }
        public string Benutzer { get; set; }

        public virtual ICollection<KonsolidierungDataset> KonsolidierungDatasets { get; set; }
    }
}
