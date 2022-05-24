using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Kennzahlenbericht
    {
        public Kennzahlenbericht()
        {
            KennzahlKennzahlenberichts = new HashSet<KennzahlKennzahlenbericht>();
        }

        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public string Name { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual ICollection<KennzahlKennzahlenbericht> KennzahlKennzahlenberichts { get; set; }
    }
}
