using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Dateiart
    {
        public Dateiart()
        {
            Dateis = new HashSet<Datei>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<Datei> Dateis { get; set; }
    }
}
