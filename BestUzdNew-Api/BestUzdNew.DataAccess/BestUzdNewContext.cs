using System;
using BestUzdNew.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.DataAccess
{
    public partial class BestUzdNewContext : DbContext
    {
        public BestUzdNewContext()
        {
        }

        public BestUzdNewContext(DbContextOptions<BestUzdNewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DiscountType> DiscountType { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceDiscount> ServiceDiscount { get; set; }
        public virtual DbSet<ServiceGroup> ServiceGroup { get; set; }
        public virtual DbSet<ServiceGroupDiscount> ServiceGroupDiscount { get; set; }
        public virtual DbSet<ServiceGroupToService> ServiceGroupToService { get; set; }
        public virtual DbSet<ServiceSetDiscount> ServiceSetDiscount { get; set; }
        public virtual DbSet<ServiceSetDiscountToService> ServiceSetDiscountToService { get; set; }
        public virtual DbSet<Translation> Translation { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserInformation> UserInformation { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=BestUzdNew;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscountType>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.ServiceId);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FamilyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Order_ServiceFK");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EndTime).HasColumnType("date");

                entity.Property(e => e.StartTime).HasColumnType("date");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ServiceDiscount>(entity =>
            {
                entity.HasIndex(e => e.DiscountTypeId);

                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.ServiceDiscount)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceDiscount_DiscountTypeFK");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceDiscount)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("ServiceDiscount_ServiceFK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceDiscount)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ServiceDiscount_UserFK");
            });

            modelBuilder.Entity<ServiceGroup>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ServiceGroupDiscount>(entity =>
            {
                entity.HasIndex(e => e.DiscountTypeId);

                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.ServiceGroupId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.ServiceGroupDiscount)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceGroupDiscount_DiscountTypeFK");

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(p => p.ServiceGroupDiscount)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .HasConstraintName("ServiceGroupDiscount_ServiceGroupFK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceGroupDiscount)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ServiceGroupDiscount_UserFK");
            });

            modelBuilder.Entity<ServiceGroupToService>(entity =>
            {
                entity.HasKey(sg => new { sg.ServiceId, sg.ServiceGroupId});

                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.ServiceGroupId);

                entity.HasIndex(e => e.ServiceId);

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(s => s.ServiceGroupsToServices)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceGroupToService_ServiceGroupFK");

                entity.HasOne(d => d.Service)
                    .WithMany(s => s.ServiceGroupsToServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceGroupToService_ServiceFK");
            });

            modelBuilder.Entity<ServiceSetDiscount>(entity =>
            {
                entity.HasIndex(e => e.DiscountTypeId);

                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.ServiceSetDiscount)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceSetDiscount_DiscountTypeFK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceSetDiscount)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ServiceSetDiscount_UserFK");
            });

            modelBuilder.Entity<ServiceSetDiscountToService>(entity =>
            {
                entity.HasKey(sd => new { sd.ServiceSetDiscountId, sd.ServiceId });

                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.ServiceSetDiscountId);

                entity.HasOne(d => d.Service)
                    .WithMany(d => d.ServiceSetDiscountsToServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceSetDiscountToService_ServiceFK");

                entity.HasOne(d => d.ServiceSetDiscount)
                    .WithMany(d => d.ServiceSetDiscountsToServices)
                    .HasForeignKey(d => d.ServiceSetDiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceSetDiscountToService_ServiceSetDiscountFK");
            });

            modelBuilder.Entity<Translation>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.LanguageId);

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Translation1)
                    .IsRequired()
                    .HasColumnName("Translation");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Translation)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Translation_LanguageFK");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.HasIndex(e => e.UserInformationId);

                entity.HasIndex(e => e.UserRoleId);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserInformation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_UserInformationFK");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserRole");
            });

            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FamilyName).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
