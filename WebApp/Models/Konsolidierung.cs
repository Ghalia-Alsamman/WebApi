using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Konsolidierung
    {
        public Konsolidierung()
        {
            DiamantExports = new HashSet<DiamantExport>();
            KalkulationKonsolidierungs = new HashSet<KalkulationKonsolidierung>();
            KonsolidierungAfAzeiles = new HashSet<KonsolidierungAfAzeile>();
            KonsolidierungAuslastungsblocks = new HashSet<KonsolidierungAuslastungsblock>();
            KonsolidierungDarlehens = new HashSet<KonsolidierungDarlehen>();
            KonsolidierungImportHochrechnungs = new HashSet<KonsolidierungImportHochrechnung>();
            KonsolidierungImportVorjahrs = new HashSet<KonsolidierungImportVorjahr>();
            KonsolidierungPersonals = new HashSet<KonsolidierungPersonal>();
            KonsolidierungSachkostenzeiles = new HashSet<KonsolidierungSachkostenzeile>();
            KonsolidierungWohnungs = new HashSet<KonsolidierungWohnung>();
            Planbilanzs = new HashSet<Planbilanz>();
            StrategischeKalkulationKonsolidierungs = new HashSet<StrategischeKalkulationKonsolidierung>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public DateTime? GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public int? RegionaleZuordnungId { get; set; }
        public int? SchnittstelleneinstellungId { get; set; }
        public bool Aktiv { get; set; }
        public int? BenutzerId { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public double? IstDatenImportPruefsumme { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual RegionaleZuordnung RegionaleZuordnung { get; set; }
        public virtual Schnittstelleneinstellung Schnittstelleneinstellung { get; set; }
        public virtual ICollection<DiamantExport> DiamantExports { get; set; }
        public virtual ICollection<KalkulationKonsolidierung> KalkulationKonsolidierungs { get; set; }
        public virtual ICollection<KonsolidierungAfAzeile> KonsolidierungAfAzeiles { get; set; }
        public virtual ICollection<KonsolidierungAuslastungsblock> KonsolidierungAuslastungsblocks { get; set; }
        public virtual ICollection<KonsolidierungDarlehen> KonsolidierungDarlehens { get; set; }
        public virtual ICollection<KonsolidierungImportHochrechnung> KonsolidierungImportHochrechnungs { get; set; }
        public virtual ICollection<KonsolidierungImportVorjahr> KonsolidierungImportVorjahrs { get; set; }
        public virtual ICollection<KonsolidierungPersonal> KonsolidierungPersonals { get; set; }
        public virtual ICollection<KonsolidierungSachkostenzeile> KonsolidierungSachkostenzeiles { get; set; }
        public virtual ICollection<KonsolidierungWohnung> KonsolidierungWohnungs { get; set; }
        public virtual ICollection<Planbilanz> Planbilanzs { get; set; }
        public virtual ICollection<StrategischeKalkulationKonsolidierung> StrategischeKalkulationKonsolidierungs { get; set; }
    }
}
