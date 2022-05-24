using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class TransferWarenwirtschaftskomponente
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int WarenwirtschaftskomponenteId { get; set; }

        public virtual Transfer Transfer { get; set; }
        public virtual Warenwirtschaftskomponente Warenwirtschaftskomponente { get; set; }
    }
}
