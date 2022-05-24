using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MenueplanKunde
    {
        public int Id { get; set; }
        public int KundeId { get; set; }
        public int MenueplanId { get; set; }

        public virtual Kunde Kunde { get; set; }
        public virtual Menueplan Menueplan { get; set; }
    }
}
