using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MenueplanTag
    {
        public MenueplanTag()
        {
            MenueplanZeitpunkts = new HashSet<MenueplanZeitpunkt>();
        }

        public int Id { get; set; }
        public int MenuplanAlternativeId { get; set; }
        public DateTime Tag { get; set; }

        public virtual MenueAlternative MenuplanAlternative { get; set; }
        public virtual ICollection<MenueplanZeitpunkt> MenueplanZeitpunkts { get; set; }
    }
}
