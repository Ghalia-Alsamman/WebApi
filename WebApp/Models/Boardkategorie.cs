using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Boardkategorie
    {
        public Boardkategorie()
        {
            Boardmeldungens = new HashSet<Boardmeldungen>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Boardmeldungen> Boardmeldungens { get; set; }
    }
}
