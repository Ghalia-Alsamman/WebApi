using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Typ
    {
        public Typ()
        {
            BerufsgruppeSachkontos = new HashSet<BerufsgruppeSachkonto>();
            Betriebsstaettes = new HashSet<Betriebsstaette>();
            Overheads = new HashSet<Overhead>();
            Sachkontenkategories = new HashSet<Sachkontenkategorie>();
            Sachkontenueberleitungs = new HashSet<Sachkontenueberleitung>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abkuerzung { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<BerufsgruppeSachkonto> BerufsgruppeSachkontos { get; set; }
        public virtual ICollection<Betriebsstaette> Betriebsstaettes { get; set; }
        public virtual ICollection<Overhead> Overheads { get; set; }
        public virtual ICollection<Sachkontenkategorie> Sachkontenkategories { get; set; }
        public virtual ICollection<Sachkontenueberleitung> Sachkontenueberleitungs { get; set; }
    }
}
