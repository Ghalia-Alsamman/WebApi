using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ZuordnungGehaltSozialversicherung
    {
        public int Id { get; set; }
        public int SachkontoGehaltId { get; set; }
        public int SachkontoSvid { get; set; }
        public int? SachkontenkategorieId { get; set; }

        public virtual Sachkontenkategorie Sachkontenkategorie { get; set; }
        public virtual Sachkonto SachkontoGehalt { get; set; }
        public virtual Sachkonto SachkontoSv { get; set; }
    }
}
