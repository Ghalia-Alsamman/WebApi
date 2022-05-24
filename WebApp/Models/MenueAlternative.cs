using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MenueAlternative
    {
        public MenueAlternative()
        {
            MenueplanTags = new HashSet<MenueplanTag>();
        }

        public int Id { get; set; }
        public int MenueplanId { get; set; }
        public int Nummer { get; set; }
        public string Name { get; set; }
        public double Verkaufspreis { get; set; }

        public virtual Menueplan Menueplan { get; set; }
        public virtual ICollection<MenueplanTag> MenueplanTags { get; set; }
    }
}
