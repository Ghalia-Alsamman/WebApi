using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerechtigungBerechtigung
    {
        public int Id { get; set; }
        public int SekundaerId { get; set; }
        public int PrimaerId { get; set; }

        public virtual Berechtigung Primaer { get; set; }
        public virtual Berechtigung Sekundaer { get; set; }
    }
}
