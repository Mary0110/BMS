﻿// <auto-generated />
using System;
using Lab1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Lab1.Entities.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BankId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FactoryId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Money")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("ClientId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Lab1.Entities.Credit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BankId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BillId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Money")
                        .HasColumnType("REAL");

                    b.Property<int>("Percent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("Lab1.Entities.CreditInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BankId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Procent")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CreditInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BankId = 1,
                            Duration = "3",
                            Procent = 10
                        },
                        new
                        {
                            Id = 2,
                            BankId = 1,
                            Duration = "6",
                            Procent = 200
                        },
                        new
                        {
                            Id = 3,
                            BankId = 1,
                            Duration = "12",
                            Procent = 50
                        },
                        new
                        {
                            Id = 4,
                            BankId = 1,
                            Duration = "24",
                            Procent = 11
                        },
                        new
                        {
                            Id = 5,
                            BankId = 1,
                            Duration = ">24",
                            Procent = 12
                        },
                        new
                        {
                            Id = 6,
                            BankId = 2,
                            Duration = "3",
                            Procent = 13
                        },
                        new
                        {
                            Id = 7,
                            BankId = 2,
                            Duration = "6",
                            Procent = 100
                        },
                        new
                        {
                            Id = 8,
                            BankId = 2,
                            Duration = "12",
                            Procent = 1
                        },
                        new
                        {
                            Id = 9,
                            BankId = 2,
                            Duration = "24",
                            Procent = 2000
                        },
                        new
                        {
                            Id = 10,
                            BankId = 2,
                            Duration = ">24",
                            Procent = 2
                        },
                        new
                        {
                            Id = 11,
                            BankId = 3,
                            Duration = "3",
                            Procent = 3
                        },
                        new
                        {
                            Id = 12,
                            BankId = 3,
                            Duration = "6",
                            Procent = 2
                        },
                        new
                        {
                            Id = 13,
                            BankId = 3,
                            Duration = "12",
                            Procent = 10
                        },
                        new
                        {
                            Id = 14,
                            BankId = 3,
                            Duration = "24",
                            Procent = 10
                        },
                        new
                        {
                            Id = 15,
                            BankId = 3,
                            Duration = ">24",
                            Procent = 10
                        });
                });

            modelBuilder.Entity("Lab1.Entities.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Money")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Deposit");
                });

            modelBuilder.Entity("Lab1.Entities.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BankId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FactoryType")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UNP")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlAdress")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Factories");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Factory");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            BankId = 1,
                            FactoryType = "Rabotygi",
                            IsBank = false,
                            Name = "Super Compony",
                            UNP = "supercode",
                            UrlAdress = "rabotygi.com"
                        },
                        new
                        {
                            Id = 5,
                            BankId = 2,
                            FactoryType = "NotRabotygi",
                            IsBank = false,
                            Name = "Mega Compony",
                            UNP = "megacode",
                            UrlAdress = "notrabotygi.com"
                        },
                        new
                        {
                            Id = 6,
                            BankId = 3,
                            FactoryType = "students",
                            IsBank = false,
                            Name = "BSUIR Compony",
                            UNP = "student.com",
                            UrlAdress = "students.com"
                        },
                        new
                        {
                            Id = 7,
                            BankId = 1,
                            FactoryType = "nones",
                            IsBank = false,
                            Name = "Noone Compony",
                            UNP = "nonecode",
                            UrlAdress = "nones.com"
                        },
                        new
                        {
                            Id = 8,
                            BankId = 2,
                            FactoryType = "fucks",
                            IsBank = false,
                            Name = "Fuck Compony",
                            UNP = "fuckcode",
                            UrlAdress = "fucks.com"
                        });
                });

            modelBuilder.Entity("Lab1.Entities.Other.RequestMoney", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BillId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAproved")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ClientId");

                    b.ToTable("RequestMonies");
                });

            modelBuilder.Entity("Lab1.Entities.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BankId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Money")
                        .HasColumnType("REAL");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Lab1.Entities.PlanInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BankId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Procent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PlanInfos");
                });

            modelBuilder.Entity("Lab1.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user"
                        },
                        new
                        {
                            Id = 3,
                            Name = "client"
                        },
                        new
                        {
                            Id = 4,
                            Name = "specialist"
                        },
                        new
                        {
                            Id = 5,
                            Name = "manager"
                        },
                        new
                        {
                            Id = 6,
                            Name = "operator"
                        });
                });

            modelBuilder.Entity("Lab1.Entities.Transfer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Display")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FromId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Money")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ToId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("Lab1.Entities.Undo.BillCreation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BillCreations");
                });

            modelBuilder.Entity("Lab1.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecondName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeriesAndPassportNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = 123,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Lab1.Entities.Bank", b =>
                {
                    b.HasBaseType("Lab1.Entities.Factory");

                    b.HasDiscriminator().HasValue("Bank");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BankId = 1,
                            IsBank = true,
                            Name = "PriorBank"
                        },
                        new
                        {
                            Id = 2,
                            BankId = 2,
                            IsBank = true,
                            Name = "MTBank"
                        },
                        new
                        {
                            Id = 3,
                            BankId = 3,
                            IsBank = true,
                            Name = "BelWeb"
                        });
                });

            modelBuilder.Entity("Lab1.Entities.UserCategories.Admin", b =>
                {
                    b.HasBaseType("Lab1.Entities.User");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Lab1.Entities.UserCategories.Client", b =>
                {
                    b.HasBaseType("Lab1.Entities.User");

                    b.Property<int>("BankId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FactoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAproved")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Lab1.Entities.UserCategories.Manager", b =>
                {
                    b.HasBaseType("Lab1.Entities.User");

                    b.HasDiscriminator().HasValue("Manager");
                });

            modelBuilder.Entity("Lab1.Entities.UserCategories.Operator", b =>
                {
                    b.HasBaseType("Lab1.Entities.User");

                    b.Property<bool>("OneOperation")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Operator");
                });

            modelBuilder.Entity("Lab1.Entities.Bill", b =>
                {
                    b.HasOne("Lab1.Entities.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("Lab1.Entities.UserCategories.Client", "Client")
                        .WithMany("Bills")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Lab1.Entities.Credit", b =>
                {
                    b.HasOne("Lab1.Entities.UserCategories.Client", null)
                        .WithMany("Credits")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab1.Entities.Deposit", b =>
                {
                    b.HasOne("Lab1.Entities.UserCategories.Client", null)
                        .WithMany("Deposits")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("Lab1.Entities.Other.RequestMoney", b =>
                {
                    b.HasOne("Lab1.Entities.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab1.Entities.UserCategories.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Lab1.Entities.Plan", b =>
                {
                    b.HasOne("Lab1.Entities.UserCategories.Client", null)
                        .WithMany("Plans")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab1.Entities.User", b =>
                {
                    b.HasOne("Lab1.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Lab1.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Lab1.Entities.UserCategories.Client", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Credits");

                    b.Navigation("Deposits");

                    b.Navigation("Plans");
                });
#pragma warning restore 612, 618
        }
    }
}