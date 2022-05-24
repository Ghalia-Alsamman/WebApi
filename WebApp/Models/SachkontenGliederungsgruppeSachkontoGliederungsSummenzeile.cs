using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SachkontenGliederungsgruppeSachkontoGliederungsSummenzeile
    {
        public int Id { get; set; }
        public int SachkontoGliederungsgruppeId { get; set; }
        public int SachkontoGliederungsgruppeSummenzeileId { get; set; }

        public virtual SachkontenGliederungsgruppe SachkontoGliederungsgruppe { get; set; }
        public virtual SachkontoGliederungsgruppeSummenzeile SachkontoGliederungsgruppeSummenzeile { get; set; }
    }
}
