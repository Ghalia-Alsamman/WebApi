using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DienstKonfiguration
    {
        public int Id { get; set; }
        public int DienstId { get; set; }
        public string Eintrag { get; set; }
        public string Eintragswert { get; set; }

        public virtual Dienst Dienst { get; set; }
    }
}
