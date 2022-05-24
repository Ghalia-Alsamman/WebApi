using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class MailZugangsdaten
    {
        public MailZugangsdaten()
        {
            ImportLogs = new HashSet<ImportLog>();
            LieferantMailZugangsdatens = new HashSet<LieferantMailZugangsdaten>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpServer { get; set; }
        public bool SmtpAuthentifizierung { get; set; }
        public string EmpfangsPort { get; set; }
        public string EmpfangsServer { get; set; }
        public bool IstImap { get; set; }
        public string MailadresseAbsender { get; set; }
        public string BenutzernameEingangsserver { get; set; }
        public string PasswortEingangsServer { get; set; }
        public string BenutzernameAusgangsserver { get; set; }
        public string PasswortAusgangsServer { get; set; }
        public bool VollstaendigerDatenabgleich { get; set; }
        public bool? Aktiv { get; set; }

        public virtual ICollection<ImportLog> ImportLogs { get; set; }
        public virtual ICollection<LieferantMailZugangsdaten> LieferantMailZugangsdatens { get; set; }
    }
}
