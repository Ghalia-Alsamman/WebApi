using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class TransferGrund
    {
        public TransferGrund()
        {
            Transfers = new HashSet<Transfer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
