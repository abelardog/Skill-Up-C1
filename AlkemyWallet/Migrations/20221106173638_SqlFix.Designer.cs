﻿// <auto-generated />
using System;
using AlkemyWallet.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlkemyWallet.Migrations
{
    [DbContext(typeof(WalletDbContext))]
    [Migration("20221106173638_SqlFix")]
    partial class SqlFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AlkemyWallet.Entities.AccountsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Money")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsBlocked = true,
                            IsDeleted = false,
                            Money = 100m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsBlocked = true,
                            IsDeleted = false,
                            Money = 0m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsBlocked = false,
                            IsDeleted = false,
                            Money = 100m,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsBlocked = false,
                            IsDeleted = false,
                            Money = 0m,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("AlkemyWallet.Entities.CatalogueEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Catalogues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://api.com/imagen1",
                            IsDeleted = false,
                            Points = 5,
                            ProductDescription = "Descripcion Primera"
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://api.com/imagen2",
                            IsDeleted = false,
                            Points = 2,
                            ProductDescription = "Descripcion Segunda"
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://api.com/imagen3",
                            IsDeleted = false,
                            Points = 2,
                            ProductDescription = "Descripcion Tercera"
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://api.com/imagen4",
                            IsDeleted = false,
                            Points = 4,
                            ProductDescription = "Descripcion Cuarta"
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://api.com/imagen5",
                            IsDeleted = false,
                            Points = 3,
                            ProductDescription = "Descripcion Quita"
                        },
                        new
                        {
                            Id = 6,
                            Image = "https://api.com/imagen6",
                            IsDeleted = false,
                            Points = 3,
                            ProductDescription = "Descripcion Sexta"
                        },
                        new
                        {
                            Id = 7,
                            Image = "https://api.com/imagen7",
                            IsDeleted = false,
                            Points = 5,
                            ProductDescription = "Descripcion Séptima"
                        });
                });

            modelBuilder.Entity("AlkemyWallet.Entities.FixedTermDepositEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("AccountsEntityId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AccountsEntityId");

                    b.HasIndex("UserId");

                    b.ToTable("FixedTermDeposits");
                });

            modelBuilder.Entity("AlkemyWallet.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "System Admin",
                            IsDeleted = false,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Regular User",
                            IsDeleted = false,
                            Name = "Regular"
                        });
                });

            modelBuilder.Entity("AlkemyWallet.Entities.TransactionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Concept")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ToAccountId")
                        .HasColumnType("int");

                    b.Property<string>("Types")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            Concept = "Pago",
                            Date = new DateTime(2022, 9, 6, 17, 36, 38, 88, DateTimeKind.Utc).AddTicks(9649),
                            IsDeleted = false,
                            ToAccountId = 2,
                            Types = "payment",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 4,
                            Concept = "Compra del dia",
                            Date = new DateTime(2022, 8, 6, 17, 36, 38, 88, DateTimeKind.Utc).AddTicks(9653),
                            IsDeleted = false,
                            ToAccountId = 2,
                            Types = "payment",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("AlkemyWallet.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("rol_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "dcacerescartasso@gmail.com",
                            FirstName = "Duncan",
                            IsDeleted = false,
                            LastName = "Caceres",
                            Password = "test1234",
                            Points = 0,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "diegor89@gmail.com",
                            FirstName = "Diego",
                            IsDeleted = false,
                            LastName = "Rodrigues",
                            Password = "DiegoTest333",
                            Points = 425,
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "lgonzales53@gmail.com",
                            FirstName = "Lucas",
                            IsDeleted = false,
                            LastName = "Gonzales",
                            Password = "Boca4784",
                            Points = 5245,
                            RoleId = 2
                        },
                        new
                        {
                            Id = 4,
                            Email = "alkwallet@gmail.com",
                            FirstName = "admin",
                            IsDeleted = false,
                            LastName = "admin",
                            Password = "admin1234",
                            Points = 0,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("AlkemyWallet.Entities.AccountsEntity", b =>
                {
                    b.HasOne("AlkemyWallet.Entities.UserEntity", "User")
                        .WithOne("Account")
                        .HasForeignKey("AlkemyWallet.Entities.AccountsEntity", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AlkemyWallet.Entities.FixedTermDepositEntity", b =>
                {
                    b.HasOne("AlkemyWallet.Entities.AccountsEntity", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("AlkemyWallet.Entities.AccountsEntity", null)
                        .WithMany("FixedTerms")
                        .HasForeignKey("AccountsEntityId");

                    b.HasOne("AlkemyWallet.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Account");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AlkemyWallet.Entities.TransactionEntity", b =>
                {
                    b.HasOne("AlkemyWallet.Entities.AccountsEntity", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlkemyWallet.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AlkemyWallet.Entities.UserEntity", b =>
                {
                    b.HasOne("AlkemyWallet.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AlkemyWallet.Entities.AccountsEntity", b =>
                {
                    b.Navigation("FixedTerms");
                });

            modelBuilder.Entity("AlkemyWallet.Entities.UserEntity", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
