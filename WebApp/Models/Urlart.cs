using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Urlart
    {
        public Urlart()
        {
            Urls = new HashSet<Url>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Url> Urls { get; set; }
    }
}
