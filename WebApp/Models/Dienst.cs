using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Dienst
    {
        public Dienst()
        {
            DienstKonfigurations = new HashSet<DienstKonfiguration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Klasse { get; set; }

        public virtual ICollection<DienstKonfiguration> DienstKonfigurations { get; set; }
    }
}
