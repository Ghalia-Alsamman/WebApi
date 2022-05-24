using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class GrenzwerteFuerPersonalplanung
    {
        public int Id { get; set; }
        public double? MinimumProzent { get; set; }
        public double? Minimum { get; set; }
        public double? MaximumProzent { get; set; }
        public double? Maximum { get; set; }
    }
}
