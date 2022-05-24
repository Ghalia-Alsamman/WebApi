using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KonsolidierungPersonal
    {
        public KonsolidierungPersonal()
        {
            KonsolidierungPersonaleinsatzs = new HashSet<KonsolidierungPersonaleinsatz>();
            KonsolidierungPersonalzusatzkostens = new HashSet<KonsolidierungPersonalzusatzkosten>();
            KonsolidierungPraemies = new HashSet<KonsolidierungPraemie>();
        }

        public int Id { get; set; }
        public int KonsolidierungId { get; set; }
        public int? BerufsgruppeId { get; set; }
        public int? ZuschussKontoId { get; set; }
        public int? TarifId { get; set; }
        public string Personalnummer { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Entgeltgruppe { get; set; }
        public string Entgeltstufe { get; set; }
        public double? Gehalt { get; set; }
        public double? ZuschlagProMonat { get; set; }
        public double? ArbeitszeitProWoche { get; set; }
        public double? Zuschuss { get; set; }
        public bool IstZdl { get; set; }
        public bool IstGfb { get; set; }
        public bool? KeineAltersvorsorge { get; set; }
        public bool? IstVertretungspersonal { get; set; }
        public int? AltersvorsorgeId { get; set; }
        public bool IstFachkraft { get; set; }

        public virtual Altersvorsorge Altersvorsorge { get; set; }
        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Konsolidierung Konsolidierung { get; set; }
        public virtual Tarif Tarif { get; set; }
        public virtual Sachkonto ZuschussKonto { get; set; }
        public virtual ICollection<KonsolidierungPersonaleinsatz> KonsolidierungPersonaleinsatzs { get; set; }
        public virtual ICollection<KonsolidierungPersonalzusatzkosten> KonsolidierungPersonalzusatzkostens { get; set; }
        public virtual ICollection<KonsolidierungPraemie> KonsolidierungPraemies { get; set; }
    }
}
