﻿// <auto-generated />
using System;
using BookLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLibrary.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("BookLibrary.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SubCategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("YearPublisher")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3ee12438-087f-4021-b7ba-53658f58a03a"),
                            Author = "Jane Austen",
                            ISBN = "9780141439518",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81oDm6v%2B7HL.jpg",
                            Publisher = "Penguin Classics",
                            SubCategoryId = new Guid("5f3a82dc-0e72-405c-b921-04cbf01a3e43"),
                            Title = "Pride and Prejudice",
                            YearPublisher = new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e09760b4-329d-4435-beb4-ae51dcede312"),
                            Author = "Charlotte Bronte",
                            ISBN = "9780141441146",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51E6fm04DIL._SX322_BO1,204,203,200_.jpg",
                            Publisher = "Penguin Classics",
                            SubCategoryId = new Guid("5f3a82dc-0e72-405c-b921-04cbf01a3e43"),
                            Title = "Jane Eyre",
                            YearPublisher = new DateTime(1847, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("934f9aff-b26e-4ec4-addf-2a0412ad6fe2"),
                            Author = "Dan Brown",
                            ISBN = "9780307474278",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81c%2BdN5SbNL.jpg",
                            Publisher = "Anchor",
                            SubCategoryId = new Guid("b2f47482-983c-4da6-a1c2-d85a556d6906"),
                            Title = "The Da Vinci Code",
                            YearPublisher = new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("920305b6-bc36-45f6-94d2-7f674ce41164"),
                            Author = "Paula Hawkins",
                            ISBN = "9781594634024",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91mx%2BXxEm1L.jpg",
                            Publisher = "Riverhead Books",
                            SubCategoryId = new Guid("b2f47482-983c-4da6-a1c2-d85a556d6906"),
                            Title = "The Girl on the Train",
                            YearPublisher = new DateTime(2015, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("1628e6db-489b-49c0-9b8b-4dd6c36fcdfd"),
                            Author = "Howard Zinn",
                            ISBN = "9780062397348",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                            Publisher = "Harper Perennial Modern Classics",
                            SubCategoryId = new Guid("9898f53a-040e-4442-b15e-7d0d23f85116"),
                            Title = "A People's History of the United States",
                            YearPublisher = new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("437e84cb-c32a-48d3-b52a-e5a7ee97be8f"),
                            Author = "Howard Zinn",
                            ISBN = "9780062397348",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                            Publisher = "Harper Perennial Modern Classics",
                            SubCategoryId = new Guid("9898f53a-040e-4442-b15e-7d0d23f85116"),
                            Title = "A People's History of the United States",
                            YearPublisher = new DateTime(1980, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("1d5983ae-55a5-4a25-be43-a4c597ad165f"),
                            Author = "Frank Herbert",
                            ISBN = "9780441013593",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                            Publisher = "Chilton Books",
                            SubCategoryId = new Guid("4a8702ad-f738-4bd9-8813-4e052ddb39f2"),
                            Title = "Dune",
                            YearPublisher = new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("02a1ae48-e6f9-41fa-9364-e0ec189e4ad9"),
                            Author = "Douglas Adams",
                            ISBN = "9780330508117",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81u0XeLMK7L.jpg",
                            Publisher = "Pan Books",
                            SubCategoryId = new Guid("4a8702ad-f738-4bd9-8813-4e052ddb39f2"),
                            Title = "The Hitchhiker's Guide to the Galaxy",
                            YearPublisher = new DateTime(1979, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("236d168f-f2c5-47a2-b90d-cc5a04657e2d"),
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = new Guid("9f508a4e-a364-4c03-aa1b-95c709c19e41"),
                            Name = "Non-Fiction"
                        });
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId1");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId1");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5f3a82dc-0e72-405c-b921-04cbf01a3e43"),
                            CategoryId = new Guid("236d168f-f2c5-47a2-b90d-cc5a04657e2d"),
                            Name = "Romance"
                        },
                        new
                        {
                            Id = new Guid("b2f47482-983c-4da6-a1c2-d85a556d6906"),
                            CategoryId = new Guid("236d168f-f2c5-47a2-b90d-cc5a04657e2d"),
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = new Guid("9898f53a-040e-4442-b15e-7d0d23f85116"),
                            CategoryId = new Guid("9f508a4e-a364-4c03-aa1b-95c709c19e41"),
                            Name = "History"
                        },
                        new
                        {
                            Id = new Guid("4a8702ad-f738-4bd9-8813-4e052ddb39f2"),
                            CategoryId = new Guid("9f508a4e-a364-4c03-aa1b-95c709c19e41"),
                            Name = "Science"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Address", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Book", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Rating", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibrary.Domain.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.Review", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibrary.Domain.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookLibrary.Domain.Entities.SubCategory", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibrary.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookLibrary.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}