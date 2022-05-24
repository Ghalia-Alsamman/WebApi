using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Einstellungen
    {
        public int Id { get; set; }
        public bool Wartungszustand { get; set; }
        public bool? IstPasswortdialogEingeschaltet { get; set; }
        public double? ClientMindestVersion { get; set; }
        public bool? FehlerberichtSendenMoeglich { get; set; }
        public bool? FehlerberichtMitScreenshot { get; set; }
        public string FehlerberichtEmpfaenger { get; set; }
        public int FehlerberichtPort { get; set; }
        public bool LogKalkulationsaenderungenAktiv { get; set; }
        public byte[] ModulKonfiguration { get; set; }
        public byte[] Logo { get; set; }
        public int Planungsjahr { get; set; }
        public bool DarlehenImBudgetPlanen { get; set; }
        public bool KostenstellenZuBudgetart { get; set; }
        public bool BenutzeDynamischeFortschrittsanzeige { get; set; }
        public string NameEinrichtungsverwaltung { get; set; }
    }
}
