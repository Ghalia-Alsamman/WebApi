using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationVerprobung
    {
        public int Id { get; set; }
        public int PersonaleinsatzId { get; set; }
        public int BetriebsstaetteVerprobungsfaktorId { get; set; }
        public double VkwertVerprobt { get; set; }

        public virtual BetriebsstaetteVerprobungsfaktor BetriebsstaetteVerprobungsfaktor { get; set; }
        public virtual Personaleinsatz Personaleinsatz { get; set; }
    }
}
