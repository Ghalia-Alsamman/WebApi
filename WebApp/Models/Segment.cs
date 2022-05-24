using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Segment
    {
        public Segment()
        {
            KundeSegments = new HashSet<KundeSegment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<KundeSegment> KundeSegments { get; set; }
    }
}
