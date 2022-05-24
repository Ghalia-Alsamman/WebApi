using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Transfer
    {
        public Transfer()
        {
            TransferArtikels = new HashSet<TransferArtikel>();
            TransferWarenwirtschaftskomponentes = new HashSet<TransferWarenwirtschaftskomponente>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int? TransferGrundId { get; set; }
        public DateTime Datum { get; set; }
        public string Bezeichnung { get; set; }
        public int Art { get; set; }
        public bool? Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual TransferGrund TransferGrund { get; set; }
        public virtual ICollection<TransferArtikel> TransferArtikels { get; set; }
        public virtual ICollection<TransferWarenwirtschaftskomponente> TransferWarenwirtschaftskomponentes { get; set; }
    }
}
