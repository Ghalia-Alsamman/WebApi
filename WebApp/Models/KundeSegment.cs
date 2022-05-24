using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KundeSegment
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int SegmentId { get; set; }
        public bool? Checked { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual Segment Segment { get; set; }
    }
}
