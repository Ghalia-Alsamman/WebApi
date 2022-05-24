using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kontoinformation
    {
        public Kontoinformation()
        {
            InternesKontos = new HashSet<InternesKonto>();
            Kontos = new HashSet<Konto>();
        }

        public int Id { get; set; }
        public int KontaktinformationId { get; set; }
        public double Kreditrahmen { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Kontaktinformation Kontaktinformation { get; set; }
        public virtual ICollection<InternesKonto> InternesKontos { get; set; }
        public virtual ICollection<Konto> Kontos { get; set; }
    }
}
