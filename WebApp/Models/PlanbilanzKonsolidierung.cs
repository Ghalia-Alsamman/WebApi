using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PlanbilanzKonsolidierung
    {
        public int Id { get; set; }
        public int PlanbilanzId { get; set; }
        public int PlanbilanzkonsolidierungId { get; set; }

        public virtual Planbilanz Planbilanz { get; set; }
        public virtual Planbilanz Planbilanzkonsolidierung { get; set; }
    }
}
