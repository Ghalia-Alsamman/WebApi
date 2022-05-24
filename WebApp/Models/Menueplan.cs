using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Menueplan
    {
        public Menueplan()
        {
            MenueAlternatives = new HashSet<MenueAlternative>();
            MenueplanKundes = new HashSet<MenueplanKunde>();
        }

        public int Id { get; set; }
        public int KategorieId { get; set; }
        public int MenueplanEigenschaftId { get; set; }
        public int BenutzerId { get; set; }
        public int? KommentarId { get; set; }
        public string Name { get; set; }
        public string Anzeigename { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime? Aenderungsdatum { get; set; }
        public DateTime? GeplantBis { get; set; }
        public bool Veroeffentlichen { get; set; }
        public DateTime? LetzteVeroeffentlichung { get; set; }
        public bool Aktiv { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual Menueplankategorie Kategorie { get; set; }
        public virtual Kommentar Kommentar { get; set; }
        public virtual MenuplanEigenschaft MenueplanEigenschaft { get; set; }
        public virtual ICollection<MenueAlternative> MenueAlternatives { get; set; }
        public virtual ICollection<MenueplanKunde> MenueplanKundes { get; set; }
    }
}
