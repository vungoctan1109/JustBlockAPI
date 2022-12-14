// <auto-generated />
using System;
using JustBlog.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JustBlog.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221027095938_NewMigration")]
    partial class NewMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JustBlog.Entities.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2daaed9a-9b49-4946-b4b5-2e4589a57ec6",
                            Email = "user@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@EXAMPLE.COM",
                            NormalizedUserName = "USER@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEE/lMy/etm3nmU5sy9T4tCjxKqy+yIL8rpwyjEjU95mSVHFqbxbaEVU6Z54MUhl5RQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user@example.com"
                        },
                        new
                        {
                            Id = new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "db25b527-bdc9-462e-8f55-79a02d26d268",
                            Email = "user1@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@EXAMPLE.COM",
                            NormalizedUserName = "USER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKU8wMwNYPLrS5NZeo0J6kLQXbEwnEeL+nyPXxr//SSvCtG6JcZca1dVY/5oySHIKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user1@example.com"
                        },
                        new
                        {
                            Id = new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "288015b0-aa8d-4a24-aee1-c258496ae486",
                            Email = "user2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@EXAMPLE.COM",
                            NormalizedUserName = "USER2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEK9ePgz5S78u9lDn77M+l35T5DQcUlpEaIqYhUuFJowQPp+UAxOqVSTYwwI4/CfPVg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user2@example.com"
                        },
                        new
                        {
                            Id = new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aee72114-6de6-47d1-82b8-417b285ccb6b",
                            Email = "owner@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OWNER@EXAMPLE.COM",
                            NormalizedUserName = "OWNER@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPTb4V/OkIXifI29nrbFcb/NH3j89+oqZBe4tmkTXRI5Ycl0X5npBbbPM2HE5k3rNA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "owner@example.com"
                        },
                        new
                        {
                            Id = new Guid("c92627c0-9156-494d-bc90-ad381f136852"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7c283d66-32fc-449a-9121-2d0838d67e16",
                            Email = "owner1@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OWNER1@EXAMPLE.COM",
                            NormalizedUserName = "OWNER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFCDtjYAL3ym1ydRSsDwLJjD+aFzP8kF2nSfvu9fDV32v0Pv5rqGzxO2GqRFDzMCbQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "owner1@example.com"
                        },
                        new
                        {
                            Id = new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "75470c26-5712-4145-b160-01663cc43095",
                            Email = "owner2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OWNER2@EXAMPLE.COM",
                            NormalizedUserName = "OWNER2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELFcg1/EGvMEjWy/+gPkaDphm/Nh1E9hQ5aXeRixozeq67jmw9VZxtwYorc+BZtV0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "owner2@example.com"
                        },
                        new
                        {
                            Id = new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "37998e89-b61e-4568-b638-a9d2bace9526",
                            Email = "contributor@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CONTRIBUTOR@EXAMPLE.COM",
                            NormalizedUserName = "CONTRIBUTOR@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEF8L48/odsERYmDlpjQTGc86TH4q+WZDl6CFSUCKOnCci+MLfRsKCpRyNw1ZTD2b/w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "contributor@example.com"
                        },
                        new
                        {
                            Id = new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9276040e-7bc0-462c-9782-5d7237abaabd",
                            Email = "contributor1@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CONTRIBUTOR1@EXAMPLE.COM",
                            NormalizedUserName = "CONTRIBUTOR1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKypp5LMptInqFTFl4XO9Bf0iGTJvdL1oUPYNTLB4D1Gn/5Dfhr93/B++UbtjBe40g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "contributor1@example.com"
                        },
                        new
                        {
                            Id = new Guid("70369848-8782-4928-b8e3-106db74c5f3f"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b18d31e-18e6-4ede-938e-c0636839fce7",
                            Email = "contributor2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CONTRIBUTOR2@EXAMPLE.COM",
                            NormalizedUserName = "CONTRIBUTOR2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI7Y0Of5DvsYcOjbt2V6bSj7oX/xFv98lV3/oPQpUT1vL6BdRUlqI7ws69uR5Ujgbg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "contributor2@example.com"
                        });
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UrlSlug")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf2a84ab-68f7-482d-8dcd-f2c0f9028049"),
                            Description = "Description 1",
                            Name = "Category 1",
                            UrlSlug = "category-1"
                        },
                        new
                        {
                            Id = new Guid("e1a767ca-708a-4392-bf9a-c16dcf9ab04f"),
                            Description = "Description 2",
                            Name = "Category 2",
                            UrlSlug = "category-2"
                        },
                        new
                        {
                            Id = new Guid("4245cf7a-4aa2-4467-b411-518830a4a43a"),
                            Description = "Description 3",
                            Name = "Category 3",
                            UrlSlug = "category-3"
                        });
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<int>("RateCount")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TotalRate")
                        .HasColumnType("int");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UrlSlug")
                        .IsUnique();

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("37026059-494f-499e-ac1a-17fb1f8736b0"),
                            CategoryId = new Guid("bf2a84ab-68f7-482d-8dcd-f2c0f9028049"),
                            Content = "Content 1",
                            Description = "Description 1",
                            Modified = new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            RateCount = 2,
                            ShortDescription = "Short Description 1",
                            Title = "Post 1",
                            TotalRate = 10,
                            UrlSlug = "post-1",
                            ViewCount = 2
                        },
                        new
                        {
                            Id = new Guid("8d248b4b-2a7d-4a85-a2d9-9688ce5aa9a2"),
                            CategoryId = new Guid("e1a767ca-708a-4392-bf9a-c16dcf9ab04f"),
                            Content = "Content 2",
                            Description = "Description 2",
                            Modified = new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            RateCount = 5,
                            ShortDescription = "Short Description 2",
                            Title = "Post 2",
                            TotalRate = 15,
                            UrlSlug = "post-2",
                            ViewCount = 5
                        },
                        new
                        {
                            Id = new Guid("274ccdc9-922d-42d3-9931-5448b6a21f21"),
                            CategoryId = new Guid("4245cf7a-4aa2-4467-b411-518830a4a43a"),
                            Content = "Content 3",
                            Description = "Description 3",
                            Modified = new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostedOn = new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = true,
                            RateCount = 10,
                            ShortDescription = "Short Description 3",
                            Title = "Post 3",
                            TotalRate = 10,
                            UrlSlug = "post-3",
                            ViewCount = 10
                        });
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.PostTagMap", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");

                    b.HasData(
                        new
                        {
                            PostId = new Guid("37026059-494f-499e-ac1a-17fb1f8736b0"),
                            TagId = new Guid("bc341849-ae9c-4dc6-8735-ac10d1d76ac1")
                        },
                        new
                        {
                            PostId = new Guid("37026059-494f-499e-ac1a-17fb1f8736b0"),
                            TagId = new Guid("90ee6cd8-7e27-43ea-95a2-1cb21edff54e")
                        },
                        new
                        {
                            PostId = new Guid("8d248b4b-2a7d-4a85-a2d9-9688ce5aa9a2"),
                            TagId = new Guid("90ee6cd8-7e27-43ea-95a2-1cb21edff54e")
                        },
                        new
                        {
                            PostId = new Guid("8d248b4b-2a7d-4a85-a2d9-9688ce5aa9a2"),
                            TagId = new Guid("48c1c139-b86e-4811-899b-05d81814a394")
                        },
                        new
                        {
                            PostId = new Guid("274ccdc9-922d-42d3-9931-5448b6a21f21"),
                            TagId = new Guid("48c1c139-b86e-4811-899b-05d81814a394")
                        },
                        new
                        {
                            PostId = new Guid("274ccdc9-922d-42d3-9931-5448b6a21f21"),
                            TagId = new Guid("bc341849-ae9c-4dc6-8735-ac10d1d76ac1")
                        });
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UrlSlug")
                        .IsUnique();

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc341849-ae9c-4dc6-8735-ac10d1d76ac1"),
                            Description = "Description 1",
                            Name = "Tag 1",
                            UrlSlug = "tag-1"
                        },
                        new
                        {
                            Id = new Guid("90ee6cd8-7e27-43ea-95a2-1cb21edff54e"),
                            Description = "Description 2",
                            Name = "Tag 2",
                            UrlSlug = "tag-2"
                        },
                        new
                        {
                            Id = new Guid("48c1c139-b86e-4811-899b-05d81814a394"),
                            Description = "Description 3",
                            Name = "Tag 3",
                            UrlSlug = "tag-3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f"),
                            Name = "Blog Owner",
                            NormalizedName = "BLOG OWNER"
                        },
                        new
                        {
                            Id = new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec"),
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b"),
                            Name = "Contributor",
                            NormalizedName = "CONTRIBUTOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa"),
                            RoleId = new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f")
                        },
                        new
                        {
                            UserId = new Guid("c92627c0-9156-494d-bc90-ad381f136852"),
                            RoleId = new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f")
                        },
                        new
                        {
                            UserId = new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed"),
                            RoleId = new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f")
                        },
                        new
                        {
                            UserId = new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9"),
                            RoleId = new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec")
                        },
                        new
                        {
                            UserId = new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b"),
                            RoleId = new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec")
                        },
                        new
                        {
                            UserId = new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e"),
                            RoleId = new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec")
                        },
                        new
                        {
                            UserId = new Guid("70369848-8782-4928-b8e3-106db74c5f3f"),
                            RoleId = new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b")
                        },
                        new
                        {
                            UserId = new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9"),
                            RoleId = new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b")
                        },
                        new
                        {
                            UserId = new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891"),
                            RoleId = new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Comment", b =>
                {
                    b.HasOne("JustBlog.Entities.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Post", b =>
                {
                    b.HasOne("JustBlog.Entities.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.PostTagMap", b =>
                {
                    b.HasOne("JustBlog.Entities.Entities.Post", "Post")
                        .WithMany("PostTagMaps")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JustBlog.Entities.Entities.Tag", "Tag")
                        .WithMany("PostTag")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("JustBlog.Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("JustBlog.Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JustBlog.Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("JustBlog.Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PostTagMaps");
                });

            modelBuilder.Entity("JustBlog.Entities.Entities.Tag", b =>
                {
                    b.Navigation("PostTag");
                });
#pragma warning restore 612, 618
        }
    }
}
