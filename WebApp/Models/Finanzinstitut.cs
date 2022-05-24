using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Finanzinstitut
    {
        public Finanzinstitut()
        {
            Kontos = new HashSet<Konto>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Blz { get; set; }
        public string Iban { get; set; }

        public virtual ICollection<Konto> Kontos { get; set; }
    }
}
