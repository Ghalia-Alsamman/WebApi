using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Schnittstellenart
    {
        public Schnittstellenart()
        {
            DiamantExports = new HashSet<DiamantExport>();
            Schnittstellenkonfigurations = new HashSet<Schnittstellenkonfiguration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Klassenname { get; set; }
        public bool WirdAutomUebertragen { get; set; }
        public bool Aktiv { get; set; }

        public virtual ICollection<DiamantExport> DiamantExports { get; set; }
        public virtual ICollection<Schnittstellenkonfiguration> Schnittstellenkonfigurations { get; set; }
    }
}
