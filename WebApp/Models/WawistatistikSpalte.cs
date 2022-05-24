using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class WawistatistikSpalte
    {
        public int Id { get; set; }
        public int WawistatistikZeileId { get; set; }
        public string SpaltenName { get; set; }
        public double? SpaltenValue { get; set; }

        public virtual WawistatistikZeile WawistatistikZeile { get; set; }
    }
}
