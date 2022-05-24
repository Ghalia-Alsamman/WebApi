using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Konto
    {
        public Konto()
        {
            Kontobewegungs = new HashSet<Kontobewegung>();
        }

        public int Id { get; set; }
        public int? KontoinformationId { get; set; }
        public int? FinanzinstitutId { get; set; }
        public string Kontonummer { get; set; }

        public virtual Finanzinstitut Finanzinstitut { get; set; }
        public virtual Kontoinformation Kontoinformation { get; set; }
        public virtual ICollection<Kontobewegung> Kontobewegungs { get; set; }
    }
}
