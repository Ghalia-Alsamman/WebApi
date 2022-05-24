using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Ansprechpartnerart
    {
        public Ansprechpartnerart()
        {
            AnsprechpartnerKundes = new HashSet<AnsprechpartnerKunde>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<AnsprechpartnerKunde> AnsprechpartnerKundes { get; set; }
    }
}
