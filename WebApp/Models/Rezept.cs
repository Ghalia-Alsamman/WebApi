using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Rezept
    {
        public Rezept()
        {
            ArtikelVerkaufs = new HashSet<ArtikelVerkauf>();
            MenueplanZeitpunktArtikelverkaufRezepts = new HashSet<MenueplanZeitpunktArtikelverkaufRezept>();
            Preis = new HashSet<Prei>();
            RezeptArtikels = new HashSet<RezeptArtikel>();
            RezeptRezeptRezeptEnthaltens = new HashSet<RezeptRezept>();
            RezeptRezeptRezeptUebergeordnets = new HashSet<RezeptRezept>();
        }

        public int Id { get; set; }
        public int RezeptkategorieId { get; set; }
        public int? MengeneinheitId { get; set; }
        public int? RezepteinheitId { get; set; }
        public int BenutzerId { get; set; }
        public int? AusgabeeinheitId { get; set; }
        public int? BildId { get; set; }
        public int? KommentarId { get; set; }
        public int? RezeptPortionsgroesseId { get; set; }
        public string Name { get; set; }
        public string AnzeigeName { get; set; }
        public double AnzahlPortionen { get; set; }
        public bool IstMenuebestandteil { get; set; }
        public DateTime Erstellungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public int Ausgabemenge { get; set; }
        public double GrammProStueck { get; set; }
        public bool Aktiv { get; set; }

        public virtual Mengeneinheit Ausgabeeinheit { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual Bild Bild { get; set; }
        public virtual Kommentar Kommentar { get; set; }
        public virtual Mengeneinheit Mengeneinheit { get; set; }
        public virtual RezeptPortionsgroesse RezeptPortionsgroesse { get; set; }
        public virtual Rezepteinheit Rezepteinheit { get; set; }
        public virtual Rezeptkategorie Rezeptkategorie { get; set; }
        public virtual ICollection<ArtikelVerkauf> ArtikelVerkaufs { get; set; }
        public virtual ICollection<MenueplanZeitpunktArtikelverkaufRezept> MenueplanZeitpunktArtikelverkaufRezepts { get; set; }
        public virtual ICollection<Prei> Preis { get; set; }
        public virtual ICollection<RezeptArtikel> RezeptArtikels { get; set; }
        public virtual ICollection<RezeptRezept> RezeptRezeptRezeptEnthaltens { get; set; }
        public virtual ICollection<RezeptRezept> RezeptRezeptRezeptUebergeordnets { get; set; }
    }
}
