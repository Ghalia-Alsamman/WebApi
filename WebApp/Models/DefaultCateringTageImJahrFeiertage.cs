using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DefaultCateringTageImJahrFeiertage
    {
        public int Id { get; set; }
        public int DefaultCateringTageImJahrId { get; set; }
        public double Anzahl { get; set; }
        public DateTime Jahr { get; set; }
        public bool Aktiv { get; set; }

        public virtual DefaultCateringTageImJahr DefaultCateringTageImJahr { get; set; }
    }
}
