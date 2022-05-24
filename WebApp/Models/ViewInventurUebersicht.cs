using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class ViewInventurUebersicht
    {
        public int Id { get; set; }
        public int LagerId { get; set; }
        public string Name { get; set; }
        public DateTime Sollinventurdatum { get; set; }
        public double? Lagerwert { get; set; }
        public string Benutzername { get; set; }
        public bool IstAbgeschlossen { get; set; }
        public string Inventurname { get; set; }
    }
}
