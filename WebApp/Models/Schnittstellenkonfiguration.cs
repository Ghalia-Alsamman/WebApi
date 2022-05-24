using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Schnittstellenkonfiguration
    {
        public int Id { get; set; }
        public int SchnittstelleneinstellungId { get; set; }
        public int SchnittstellenartId { get; set; }
        public string Eintragsname { get; set; }
        public string Eintragswert { get; set; }

        public virtual Schnittstellenart Schnittstellenart { get; set; }
        public virtual Schnittstelleneinstellung Schnittstelleneinstellung { get; set; }
    }
}
