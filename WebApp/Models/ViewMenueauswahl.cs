using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewMenueauswahl
    {
        public int? Id { get; set; }
        public int MenueplanId { get; set; }
        public string MenueName { get; set; }
        public string MenueAnzeigename { get; set; }
        public string MenueplankategorieName { get; set; }
        public int MenueplankategorieId { get; set; }
        public DateTime MenueplanTag { get; set; }
    }
}
