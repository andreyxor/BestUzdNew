﻿// <auto-generated />
using System;
using BestUzdNew.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BestUzdNew.DataAccess.Migrations
{
    [DbContext(typeof(BestUzdNewContext))]
    partial class BestUzdNewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BestUzdNew.Domain.Entities.DiscountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("DiscountType");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceDiscount");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("ServiceGroup");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ServiceGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceGroupDiscount");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupToService", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceGroupId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("ServiceId", "ServiceGroupId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceGroupId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceGroupToService");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceSetDiscount");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscountToService", b =>
                {
                    b.Property<int>("ServiceSetDiscountId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("ServiceSetDiscountId", "ServiceId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ServiceId");

                    b.HasIndex("ServiceSetDiscountId");

                    b.ToTable("ServiceSetDiscountToService");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Translation1")
                        .IsRequired()
                        .HasColumnName("Translation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("LanguageId");

                    b.ToTable("Translation");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<int>("UserInformationId")
                        .HasColumnType("int");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("UserInformationId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.UserInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("UserInformation");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Order", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany("Order")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("Order_ServiceFK")
                        .IsRequired();
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceDiscount", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.DiscountType", "DiscountType")
                        .WithMany("ServiceDiscount")
                        .HasForeignKey("DiscountTypeId")
                        .HasConstraintName("ServiceDiscount_DiscountTypeFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany("ServiceDiscount")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("ServiceDiscount_ServiceFK");

                    b.HasOne("BestUzdNew.Domain.Entities.User", "User")
                        .WithMany("ServiceDiscount")
                        .HasForeignKey("UserId")
                        .HasConstraintName("ServiceDiscount_UserFK");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupDiscount", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.DiscountType", "DiscountType")
                        .WithMany("ServiceGroupDiscount")
                        .HasForeignKey("DiscountTypeId")
                        .HasConstraintName("ServiceGroupDiscount_DiscountTypeFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.ServiceGroup", "ServiceGroup")
                        .WithMany("ServiceGroupDiscount")
                        .HasForeignKey("ServiceGroupId")
                        .HasConstraintName("ServiceGroupDiscount_ServiceGroupFK");

                    b.HasOne("BestUzdNew.Domain.Entities.User", "User")
                        .WithMany("ServiceGroupDiscount")
                        .HasForeignKey("UserId")
                        .HasConstraintName("ServiceGroupDiscount_UserFK");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceGroupToService", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.ServiceGroup", "ServiceGroup")
                        .WithMany("ServiceGroupsToServices")
                        .HasForeignKey("ServiceGroupId")
                        .HasConstraintName("ServiceGroupToService_ServiceGroupFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany("ServiceGroupsToServices")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("ServiceGroupToService_ServiceFK")
                        .IsRequired();
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscount", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.DiscountType", "DiscountType")
                        .WithMany("ServiceSetDiscount")
                        .HasForeignKey("DiscountTypeId")
                        .HasConstraintName("ServiceSetDiscount_DiscountTypeFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.User", "User")
                        .WithMany("ServiceSetDiscount")
                        .HasForeignKey("UserId")
                        .HasConstraintName("ServiceSetDiscount_UserFK");
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.ServiceSetDiscountToService", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.Service", "Service")
                        .WithMany("ServiceSetDiscountsToServices")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("ServiceSetDiscountToService_ServiceFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.ServiceSetDiscount", "ServiceSetDiscount")
                        .WithMany("ServiceSetDiscountsToServices")
                        .HasForeignKey("ServiceSetDiscountId")
                        .HasConstraintName("ServiceSetDiscountToService_ServiceSetDiscountFK")
                        .IsRequired();
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.Translation", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.Language", "Language")
                        .WithMany("Translation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("Translation_LanguageFK")
                        .IsRequired();
                });

            modelBuilder.Entity("BestUzdNew.Domain.Entities.User", b =>
                {
                    b.HasOne("BestUzdNew.Domain.Entities.UserInformation", "UserInformation")
                        .WithMany("User")
                        .HasForeignKey("UserInformationId")
                        .HasConstraintName("User_UserInformationFK")
                        .IsRequired();

                    b.HasOne("BestUzdNew.Domain.Entities.UserRole", "UserRole")
                        .WithMany("User")
                        .HasForeignKey("UserRoleId")
                        .HasConstraintName("FK_User_UserRole")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
