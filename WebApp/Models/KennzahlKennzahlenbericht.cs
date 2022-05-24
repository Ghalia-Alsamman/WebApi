using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KennzahlKennzahlenbericht
    {
        public int Id { get; set; }
        public int KennzahlId { get; set; }
        public int KennzahlenberichtId { get; set; }
        public int Reihenfolge { get; set; }

        public virtual Kennzahl Kennzahl { get; set; }
        public virtual Kennzahlenbericht Kennzahlenbericht { get; set; }
    }
}
