﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kundenart
    {
        public Kundenart()
        {
            Kundes = new HashSet<Kunde>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Kunde> Kundes { get; set; }
    }
}
