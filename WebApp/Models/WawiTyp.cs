using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class WawiTyp
    {
        public WawiTyp()
        {
            Warenwirtschaftskomponentes = new HashSet<Warenwirtschaftskomponente>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Warenwirtschaftskomponente> Warenwirtschaftskomponentes { get; set; }
    }
}
