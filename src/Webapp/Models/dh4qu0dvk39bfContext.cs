using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Protocols;

namespace Webapp.Models
{
    public partial class dh4qu0dvk39bfContext : DbContext
    {
        public dh4qu0dvk39bfContext()
        {
        }

        public dh4qu0dvk39bfContext(DbContextOptions<dh4qu0dvk39bfContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pgcrypto");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Email)
                    .HasName("user_email_key")
                    .IsUnique();

                entity.HasIndex(e => e.Phone)
                    .HasName("user_phone_key")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("place");

                entity.Property(e => e.UserType).HasColumnName("user_type");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username");

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_user_type_fkey");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("user_type");

                entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasColumnName("user_type_name");
            });

            modelBuilder.HasSequence("remote_schemas_id_seq");

            modelBuilder.HasSequence("user_phone_seq");
        }
    }
}
