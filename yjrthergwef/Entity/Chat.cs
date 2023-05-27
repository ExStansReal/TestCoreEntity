using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace yjrthergwef.Entity
{
    public partial class Chat
    {
        public Chat()
        {
            Messedges = new HashSet<Messedges>();
        }

        public int IdChat { get; set; }
        public int UserIdFirst { get; set; }
        public int UserIdSecond { get; set; }

        public virtual User UserIdFirstNavigation { get; set; }
        public virtual User UserIdSecondNavigation { get; set; }
        public virtual ICollection<Messedges> Messedges { get; set; }
    }
}
