using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class DefaultCateringTageImJahr
    {
        public DefaultCateringTageImJahr()
        {
            DefaultCateringTageImJahrFeiertages = new HashSet<DefaultCateringTageImJahrFeiertage>();
        }

        public int Id { get; set; }
        public double Montag { get; set; }
        public double Dienstag { get; set; }
        public double Mittwoch { get; set; }
        public double Donnerstag { get; set; }
        public double Freitag { get; set; }
        public double Samstag { get; set; }
        public double Sonntag { get; set; }
        public double Feiertags { get; set; }

        public virtual ICollection<DefaultCateringTageImJahrFeiertage> DefaultCateringTageImJahrFeiertages { get; set; }
    }
}
