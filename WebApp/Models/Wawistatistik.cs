using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Wawistatistik
    {
        public Wawistatistik()
        {
            WawistatistikZeiles = new HashSet<WawistatistikZeile>();
        }

        public int Id { get; set; }
        public int BetriebsstaetteId { get; set; }
        public string Name { get; set; }
        public int Typ { get; set; }

        public virtual Betriebsstaette Betriebsstaette { get; set; }
        public virtual ICollection<WawistatistikZeile> WawistatistikZeiles { get; set; }
    }
}
