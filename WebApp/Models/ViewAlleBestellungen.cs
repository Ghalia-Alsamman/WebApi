using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewAlleBestellungen
    {
        public int Id { get; set; }
        public double? OffeneMenge { get; set; }
        public int BestellObjektId { get; set; }
    }
}
