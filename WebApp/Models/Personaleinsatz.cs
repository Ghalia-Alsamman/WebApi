using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personaleinsatz
    {
        public Personaleinsatz()
        {
            KalkulationVerprobungs = new HashSet<KalkulationVerprobung>();
        }

        public int Id { get; set; }
        public int? BerufsgruppeId { get; set; }
        public int? KostenstelleId { get; set; }
        public int? PersonalId { get; set; }
        public string Name { get; set; }
        public double? Kopfanteil { get; set; }
        public DateTime? BeschaeftigtVon { get; set; }
        public DateTime? BeschaeftigtBis { get; set; }
        public double GehaltProMonat { get; set; }
        public double Personalfolgekosten { get; set; }
        public double Personalkosten { get; set; }
        public double VkSpeicherwert { get; set; }

        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Kostenstelle Kostenstelle { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual ICollection<KalkulationVerprobung> KalkulationVerprobungs { get; set; }
    }
}
