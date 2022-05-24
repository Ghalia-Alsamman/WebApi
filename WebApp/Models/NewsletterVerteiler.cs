using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class NewsletterVerteiler
    {
        public int Id { get; set; }
        public int NewsletterId { get; set; }
        public int VerteilerId { get; set; }

        public virtual Newsletter Newsletter { get; set; }
        public virtual Verteiler Verteiler { get; set; }
    }
}
