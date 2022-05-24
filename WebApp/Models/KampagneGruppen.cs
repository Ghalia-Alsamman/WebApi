using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KampagneGruppen
    {
        public int Id { get; set; }
        public int GruppeId { get; set; }
        public int KampagneId { get; set; }

        public virtual Gruppe Gruppe { get; set; }
        public virtual Kampagne Kampagne { get; set; }
    }
}
