using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace yjrthergwef.Entity
{
    public partial class Messedges
    {
        public int IdMessedge { get; set; }
        public TimeSpan Time { get; set; }
        public int UserId { get; set; }
        public string Messedge { get; set; }
        public int ChatId { get; set; }

        public virtual Chat Chat { get; set; }
        public virtual User User { get; set; }
    }
}
