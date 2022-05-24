using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class KalkulationAngebot
    {
        public int Id { get; set; }
        public int? KalkulationId { get; set; }
        public int? AngebotId { get; set; }

        public virtual Angebot Angebot { get; set; }
        public virtual Kalkulation Kalkulation { get; set; }
    }
}
