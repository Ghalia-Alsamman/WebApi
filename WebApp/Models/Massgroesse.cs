using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Massgroesse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Property { get; set; }
        public string Diamantschluessel { get; set; }
        public string Kostenstelle { get; set; }
    }
}
