using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Schnittstelleneinstellung
    {
        public Schnittstelleneinstellung()
        {
            Betriebsstaettes = new HashSet<Betriebsstaette>();
            Konsolidierungs = new HashSet<Konsolidierung>();
            Schnittstellenkonfigurations = new HashSet<Schnittstellenkonfiguration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }

        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
        public virtual ICollection<Konsolidierung> Konsolidierungs { get; set; }
        public virtual ICollection<Schnittstellenkonfiguration> Schnittstellenkonfigurations { get; set; }
    }
}
