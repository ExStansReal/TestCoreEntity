using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace yjrthergwef.Entity
{
    public partial class User
    {
        public User()
        {
            ChatUserIdFirstNavigation = new HashSet<Chat>();
            ChatUserIdSecondNavigation = new HashSet<Chat>();
            FriendsUserIdUserInFriendshipNavigation = new HashSet<Friends>();
            FriendsUserIdWhoHaveItNavigation = new HashSet<Friends>();
            Messedges = new HashSet<Messedges>();
            ZayavkiUserIdFromNavigation = new HashSet<Zayavki>();
            ZayavkiUserIdToNavigation = new HashSet<Zayavki>();
        }

        public int IdUser { get; set; }
        public string Familiya { get; set; }
        public string Ima { get; set; }
        public string Otchestvo { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Chat> ChatUserIdFirstNavigation { get; set; }
        public virtual ICollection<Chat> ChatUserIdSecondNavigation { get; set; }
        public virtual ICollection<Friends> FriendsUserIdUserInFriendshipNavigation { get; set; }
        public virtual ICollection<Friends> FriendsUserIdWhoHaveItNavigation { get; set; }
        public virtual ICollection<Messedges> Messedges { get; set; }
        public virtual ICollection<Zayavki> ZayavkiUserIdFromNavigation { get; set; }
        public virtual ICollection<Zayavki> ZayavkiUserIdToNavigation { get; set; }
    }
}
