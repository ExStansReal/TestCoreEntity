using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace yjrthergwef.Entity
{
    public partial class Friends
    {
        public int IdFriends { get; set; }
        public int UserIdWhoHaveIt { get; set; }
        public int UserIdUserInFriendship { get; set; }

        public virtual User UserIdUserInFriendshipNavigation { get; set; }
        public virtual User UserIdWhoHaveItNavigation { get; set; }
    }
}
