using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Aenderungslog
    {
        public int Id { get; set; }
        public int ObjektId { get; set; }
        public string Klasse { get; set; }
        public DateTime Datum { get; set; }
    }
}
