using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class RezeptRezept
    {
        public int Id { get; set; }
        public int RezeptUebergeordnetId { get; set; }
        public int RezeptEnthaltenId { get; set; }
        public double Menge { get; set; }

        public virtual Rezept RezeptEnthalten { get; set; }
        public virtual Rezept RezeptUebergeordnet { get; set; }
    }
}
