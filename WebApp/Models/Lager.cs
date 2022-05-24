using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Lager
    {
        public Lager()
        {
            Bestands = new HashSet<Bestand>();
            Bestandsbewegungs = new HashSet<Bestandsbewegung>();
            Inventurs = new HashSet<Inventur>();
            LagerArtikels = new HashSet<LagerArtikel>();
            LagerWarenwirtschaftskomponentes = new HashSet<LagerWarenwirtschaftskomponente>();
            TransferArtikels = new HashSet<TransferArtikel>();
        }

        public int Id { get; set; }
        public int? BenutzerId { get; set; }
        public string Name { get; set; }
        public int? Ort { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime? Erstellungsdatum { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Betriebsstaette OrtNavigation { get; set; }
        public virtual ICollection<Bestand> Bestands { get; set; }
        public virtual ICollection<Bestandsbewegung> Bestandsbewegungs { get; set; }
        public virtual ICollection<Inventur> Inventurs { get; set; }
        public virtual ICollection<LagerArtikel> LagerArtikels { get; set; }
        public virtual ICollection<LagerWarenwirtschaftskomponente> LagerWarenwirtschaftskomponentes { get; set; }
        public virtual ICollection<TransferArtikel> TransferArtikels { get; set; }
    }
}
