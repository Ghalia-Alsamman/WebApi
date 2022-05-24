using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Task1 { get; set; }
        public DateTime? Duedate { get; set; }
        public int? Dueuser { get; set; }
        public bool Done { get; set; }
        public DateTime Senddate { get; set; }
        public int Senduser { get; set; }
        public string TypeString { get; set; }
        public int? TypeId { get; set; }

        public virtual Benutzer DueuserNavigation { get; set; }
        public virtual Benutzer SenduserNavigation { get; set; }
    }
}
