using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewKundeBestandteilMitgliedschaft
    {
        public int Id { get; set; }
        public int? MitgliedschaftArtId { get; set; }
        public string MitgliedschaftArt { get; set; }
        public int? AnzahlMitgliedschaft { get; set; }
        public double? Mitgliedsbeitrag { get; set; }
        public double? Mitgliedssteuer { get; set; }
        public int? MitgliedschaftArtUnternehmenId { get; set; }
        public string MitgliedschaftArtUnternehmen { get; set; }
        public DateTime? Startdatum { get; set; }
        public DateTime? Enddatum { get; set; }
        public DateTime? Kuendigungdatum { get; set; }
    }
}
