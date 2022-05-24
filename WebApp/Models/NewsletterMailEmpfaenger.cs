using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class NewsletterMailEmpfaenger
    {
        public int Id { get; set; }
        public int NewsletterId { get; set; }
        public string Adresse { get; set; }

        public virtual Newsletter Newsletter { get; set; }
    }
}
