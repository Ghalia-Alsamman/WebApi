using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BerufsgruppeSachkonto
    {
        public int Id { get; set; }
        public int BerufsgruppeId { get; set; }
        public int TypId { get; set; }
        public int? SkSozialVersId { get; set; }
        public int? SkAltersvorsorgeId { get; set; }
        public int? SkGehaltId { get; set; }
        public int? SkBeihilfeId { get; set; }
        public int? SkErstattungId { get; set; }
        public int? SkKrankenVersId { get; set; }
        public int? SkArbeitslosenVersId { get; set; }
        public int? SkPflegeVersId { get; set; }
        public int? SkBerufsgenossenschId { get; set; }
        public int? SkHaftpflichtId { get; set; }
        public int? SkSchwerbehinPauschId { get; set; }
        public int? SkAufwendungsausglId { get; set; }
        public int? SkLohnsteuerId { get; set; }
        public int? SkAltersvorsorgeZusatzId { get; set; }
        public int? SkZuschlagId { get; set; }
        public int? SkZuschlagSvpflichtigId { get; set; }
        public int? SkPraemieSonderzahlungId { get; set; }

        public virtual Berufsgruppe Berufsgruppe { get; set; }
        public virtual Sachkonto SkAltersvorsorge { get; set; }
        public virtual Sachkonto SkAltersvorsorgeZusatz { get; set; }
        public virtual Sachkonto SkArbeitslosenVers { get; set; }
        public virtual Sachkonto SkAufwendungsausgl { get; set; }
        public virtual Sachkonto SkBeihilfe { get; set; }
        public virtual Sachkonto SkBerufsgenossensch { get; set; }
        public virtual Sachkonto SkErstattung { get; set; }
        public virtual Sachkonto SkGehalt { get; set; }
        public virtual Sachkonto SkHaftpflicht { get; set; }
        public virtual Sachkonto SkKrankenVers { get; set; }
        public virtual Sachkonto SkLohnsteuer { get; set; }
        public virtual Sachkonto SkPflegeVers { get; set; }
        public virtual Sachkonto SkPraemieSonderzahlung { get; set; }
        public virtual Sachkonto SkSchwerbehinPausch { get; set; }
        public virtual Sachkonto SkSozialVers { get; set; }
        public virtual Sachkonto SkZuschlag { get; set; }
        public virtual Sachkonto SkZuschlagSvpflichtig { get; set; }
        public virtual Typ Typ { get; set; }
    }
}
