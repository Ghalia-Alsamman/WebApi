using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PlanbilanzMittelfristplanungPosition
    {
        public int Id { get; set; }
        public int PlanbilanzMittelfristId { get; set; }
        public int PlanbilanzId { get; set; }

        public virtual Planbilanz Planbilanz { get; set; }
        public virtual PlanbilanzMittelfristplanung PlanbilanzMittelfrist { get; set; }
    }
}
