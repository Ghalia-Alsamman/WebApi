using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BenutzerSeitenElement
    {
        public int Id { get; set; }
        public int BenutzerId { get; set; }
        public int SeitenElementId { get; set; }

        public virtual Benutzer Benutzer { get; set; }
        public virtual SeitenElement SeitenElement { get; set; }
    }
}
