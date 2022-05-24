using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Mandant
    {
        public Mandant()
        {
            Betriebsstaettes = new HashSet<Betriebsstaette>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
    }
}
