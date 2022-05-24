using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Verguetungsinformation
    {
        public Verguetungsinformation()
        {
            Lohns = new HashSet<Lohn>();
        }

        public int Id { get; set; }
        public int? VertragsinformationId { get; set; }
        public double? Gehaltsgrenze { get; set; }
        public double? Mindestgehalt { get; set; }
        public double? Plangehalt { get; set; }
        public bool Wertguthabenvereinbarung { get; set; }

        public virtual ICollection<Lohn> Lohns { get; set; }
    }
}
