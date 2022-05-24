using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SachkontengruppeGuvSummenzeile
    {
        public int Id { get; set; }
        public int SachkontengruppeId { get; set; }
        public int GuvSummenzeileId { get; set; }

        public virtual GuvSummenzeile GuvSummenzeile { get; set; }
        public virtual Sachkontengruppe Sachkontengruppe { get; set; }
    }
}
