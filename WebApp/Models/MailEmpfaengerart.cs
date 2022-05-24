using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MailEmpfaengerart
    {
        public MailEmpfaengerart()
        {
            MailEmpfaengers = new HashSet<MailEmpfaenger>();
        }

        public int Id { get; set; }
        public string Art { get; set; }

        public virtual ICollection<MailEmpfaenger> MailEmpfaengers { get; set; }
    }
}
