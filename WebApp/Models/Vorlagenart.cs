using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Vorlagenart
    {
        public Vorlagenart()
        {
            Dateivorlages = new HashSet<Dateivorlage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Dateivorlage> Dateivorlages { get; set; }
    }
}
