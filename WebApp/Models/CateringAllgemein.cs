using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class CateringAllgemein
    {
        public int Id { get; set; }
        public int KalkulationId { get; set; }
        public double AnzahlBkt { get; set; }
        public double AnzahlBktFruehstueck { get; set; }
        public double AnzahlBktMittag { get; set; }
        public double AnzahlBktZwischenmahlzeit { get; set; }
        public double AnzahlBktAbendessen { get; set; }
        public double AnzahlBktHeissgetraenke { get; set; }
        public double AnzahlBktKaltgetraenke { get; set; }
        public double AnzahlFruehstueck { get; set; }
        public double AnzahlMittag { get; set; }
        public double AnzahlZwischenmahlzeit { get; set; }
        public double AnzahlAbendessen { get; set; }
        public double AnzahlHeissgetraenke { get; set; }
        public double AnzahlKaltgetraenke { get; set; }
        public double AnzahlBktPrivat { get; set; }
        public double AnzahlBktFruehstueckPrivat { get; set; }
        public double AnzahlBktMittagPrivat { get; set; }
        public double AnzahlBktZwischenmahlzeitPrivat { get; set; }
        public double AnzahlBktAbendessenPrivat { get; set; }
        public double AnzahlBktHeissgetraenkePrivat { get; set; }
        public double AnzahlBktKaltgetraenkePrivat { get; set; }
        public double PreisFruehstueckPrivat { get; set; }
        public double PreisMittagPrivat { get; set; }
        public double PreisZwischenmahlzeitPrivat { get; set; }
        public double PreisAbendessenPrivat { get; set; }
        public double PreisHeissgetraenkePrivat { get; set; }
        public double PreisKaltgetraenkePrivat { get; set; }

        public virtual Kalkulation Kalkulation { get; set; }
    }
}
