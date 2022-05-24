using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationsartBerechtigungLesen
    {
        public int Id { get; set; }
        public int KalkulationsartId { get; set; }
        public string EnumBerechtigungLesen { get; set; }

        public virtual Kalkulationsart Kalkulationsart { get; set; }
    }
}
