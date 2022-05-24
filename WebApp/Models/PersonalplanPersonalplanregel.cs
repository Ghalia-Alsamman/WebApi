using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class PersonalplanPersonalplanregel
    {
        public int Id { get; set; }
        public int PersonalplanregelId { get; set; }
        public int PersonalplanId { get; set; }

        public virtual Personalplan Personalplan { get; set; }
        public virtual Personalplanregel Personalplanregel { get; set; }
    }
}
