using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class SachkontoSachkontoGliederungsgruppe
    {
        public int Id { get; set; }
        public int SachkontoId { get; set; }
        public int SachkontenGliederungsgruppeId { get; set; }

        public virtual SachkontenGliederungsgruppe SachkontenGliederungsgruppe { get; set; }
        public virtual Sachkonto Sachkonto { get; set; }
    }
}
