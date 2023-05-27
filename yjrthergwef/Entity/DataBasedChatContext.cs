using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace yjrthergwef.Entity
{
    public partial class DataBasedChatContext : DbContext
    {
        public DataBasedChatContext()
        {
        }

        public DataBasedChatContext(DbContextOptions<DataBasedChatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Messedges> Messedges { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Zayavki> Zayavki { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PSEJFIA\\SQLEXPRESS;Database=DataBasedChat;User ID=application;Password=zekindaplaneta");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>(entity =>
            {
                entity.HasKey(e => e.IdChat);

                entity.Property(e => e.IdChat).HasColumnName("ID_Chat");

                entity.Property(e => e.UserIdFirst).HasColumnName("User_ID_First");

                entity.Property(e => e.UserIdSecond).HasColumnName("User_ID_Second");

                entity.HasOne(d => d.UserIdFirstNavigation)
                    .WithMany(p => p.ChatUserIdFirstNavigation)
                    .HasForeignKey(d => d.UserIdFirst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_User");

                entity.HasOne(d => d.UserIdSecondNavigation)
                    .WithMany(p => p.ChatUserIdSecondNavigation)
                    .HasForeignKey(d => d.UserIdSecond)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_User1");
            });

            modelBuilder.Entity<Friends>(entity =>
            {
                entity.HasKey(e => e.IdFriends);

                entity.Property(e => e.IdFriends).HasColumnName("ID_Friends");

                entity.Property(e => e.UserIdUserInFriendship).HasColumnName("User_ID_user_in_friendship");

                entity.Property(e => e.UserIdWhoHaveIt).HasColumnName("User_ID_who_have_it");

                entity.HasOne(d => d.UserIdUserInFriendshipNavigation)
                    .WithMany(p => p.FriendsUserIdUserInFriendshipNavigation)
                    .HasForeignKey(d => d.UserIdUserInFriendship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Friends_User");

                entity.HasOne(d => d.UserIdWhoHaveItNavigation)
                    .WithMany(p => p.FriendsUserIdWhoHaveItNavigation)
                    .HasForeignKey(d => d.UserIdWhoHaveIt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Friends_User1");
            });

            modelBuilder.Entity<Messedges>(entity =>
            {
                entity.HasKey(e => e.IdMessedge);

                entity.Property(e => e.IdMessedge).HasColumnName("ID_Messedge");

                entity.Property(e => e.ChatId).HasColumnName("Chat_ID");

                entity.Property(e => e.Messedge)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.Messedges)
                    .HasForeignKey(d => d.ChatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messedges_Chat");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messedges)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messedges_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.Familiya)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ima)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Otchestvo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zayavki>(entity =>
            {
                entity.HasKey(e => e.IdZayavki);

                entity.Property(e => e.IdZayavki).HasColumnName("ID_Zayavki");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.UserIdFrom).HasColumnName("User_ID_From");

                entity.Property(e => e.UserIdTo).HasColumnName("User_ID_To");

                entity.HasOne(d => d.UserIdFromNavigation)
                    .WithMany(p => p.ZayavkiUserIdFromNavigation)
                    .HasForeignKey(d => d.UserIdFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zayavki_User");

                entity.HasOne(d => d.UserIdToNavigation)
                    .WithMany(p => p.ZayavkiUserIdToNavigation)
                    .HasForeignKey(d => d.UserIdTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zayavki_User1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
