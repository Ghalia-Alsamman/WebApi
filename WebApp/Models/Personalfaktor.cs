using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Personalfaktor
    {
        public Personalfaktor()
        {
            Berufsgruppes = new HashSet<Berufsgruppe>();
            FaktorenPvists = new HashSet<FaktorenPvist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Berufsgruppe> Berufsgruppes { get; set; }
        public virtual ICollection<FaktorenPvist> FaktorenPvists { get; set; }
    }
}
