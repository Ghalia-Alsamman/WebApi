using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class AuftragsverwaltungStatischerBereichBerechtigung
    {
        public int Id { get; set; }
        public int AuftragstatusId { get; set; }
        public bool? ToolStripButtonNeuerKunde { get; set; }
        public bool? ToolStripButtonKundeBearbeiten { get; set; }
        public bool? ToolStripButtonStatushistorie { get; set; }
        public bool? MyComboBoxKunde { get; set; }
        public bool? MyComboBoxAnsprechpartner { get; set; }
        public bool? MyTextBoxExtAuftragsnr { get; set; }
        public bool? MyDateTimePickerBestelldatum { get; set; }
        public bool? MyTextBoxName { get; set; }
        public bool? MyTextBoxIntAuftragsnr { get; set; }
        public bool? MyTextBoxLetzterBearbeiter { get; set; }
        public bool? MyTextBoxLetzteAenderung { get; set; }
        public bool? MyDateTimePickerGueltigskeitsdatum { get; set; }
        public bool? MyDateTimePickerLieferdatum { get; set; }

        public virtual Auftragstatus Auftragstatus { get; set; }
    }
}
