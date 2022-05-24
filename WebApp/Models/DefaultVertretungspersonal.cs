using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DefaultVertretungspersonal
    {
        public int Id { get; set; }
        public double? Urlaub { get; set; }
        public double? Krankheit { get; set; }
    }
}
