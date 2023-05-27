using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace yjrthergwef.Entity
{
    public partial class Zayavki
    {
        public int IdZayavki { get; set; }
        public int UserIdFrom { get; set; }
        public int UserIdTo { get; set; }
        public DateTime Date { get; set; }

        public virtual User UserIdFromNavigation { get; set; }
        public virtual User UserIdToNavigation { get; set; }
    }
}
