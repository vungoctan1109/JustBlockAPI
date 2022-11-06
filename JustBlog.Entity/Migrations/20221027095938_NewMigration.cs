using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JustBlog.Entities.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    RateCount = table.Column<int>(type: "int", nullable: false),
                    TotalRate = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec"), null, "User", "USER" },
                    { new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b"), null, "Contributor", "CONTRIBUTOR" },
                    { new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f"), null, "Blog Owner", "BLOG OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed"), null, 0, null, "aee72114-6de6-47d1-82b8-417b285ccb6b", "owner@example.com", true, false, null, "OWNER@EXAMPLE.COM", "OWNER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPTb4V/OkIXifI29nrbFcb/NH3j89+oqZBe4tmkTXRI5Ycl0X5npBbbPM2HE5k3rNA==", null, false, "", false, "owner@example.com" },
                    { new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa"), null, 0, null, "75470c26-5712-4145-b160-01663cc43095", "owner2@example.com", true, false, null, "OWNER2@EXAMPLE.COM", "OWNER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAELFcg1/EGvMEjWy/+gPkaDphm/Nh1E9hQ5aXeRixozeq67jmw9VZxtwYorc+BZtV0Q==", null, false, "", false, "owner2@example.com" },
                    { new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9"), null, 0, null, "2daaed9a-9b49-4946-b4b5-2e4589a57ec6", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE/lMy/etm3nmU5sy9T4tCjxKqy+yIL8rpwyjEjU95mSVHFqbxbaEVU6Z54MUhl5RQ==", null, false, "", false, "user@example.com" },
                    { new Guid("70369848-8782-4928-b8e3-106db74c5f3f"), null, 0, null, "8b18d31e-18e6-4ede-938e-c0636839fce7", "contributor2@example.com", true, false, null, "CONTRIBUTOR2@EXAMPLE.COM", "CONTRIBUTOR2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI7Y0Of5DvsYcOjbt2V6bSj7oX/xFv98lV3/oPQpUT1vL6BdRUlqI7ws69uR5Ujgbg==", null, false, "", false, "contributor2@example.com" },
                    { new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891"), null, 0, null, "37998e89-b61e-4568-b638-a9d2bace9526", "contributor@example.com", true, false, null, "CONTRIBUTOR@EXAMPLE.COM", "CONTRIBUTOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF8L48/odsERYmDlpjQTGc86TH4q+WZDl6CFSUCKOnCci+MLfRsKCpRyNw1ZTD2b/w==", null, false, "", false, "contributor@example.com" },
                    { new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b"), null, 0, null, "db25b527-bdc9-462e-8f55-79a02d26d268", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKU8wMwNYPLrS5NZeo0J6kLQXbEwnEeL+nyPXxr//SSvCtG6JcZca1dVY/5oySHIKw==", null, false, "", false, "user1@example.com" },
                    { new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9"), null, 0, null, "9276040e-7bc0-462c-9782-5d7237abaabd", "contributor1@example.com", true, false, null, "CONTRIBUTOR1@EXAMPLE.COM", "CONTRIBUTOR1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKypp5LMptInqFTFl4XO9Bf0iGTJvdL1oUPYNTLB4D1Gn/5Dfhr93/B++UbtjBe40g==", null, false, "", false, "contributor1@example.com" },
                    { new Guid("c92627c0-9156-494d-bc90-ad381f136852"), null, 0, null, "7c283d66-32fc-449a-9121-2d0838d67e16", "owner1@example.com", true, false, null, "OWNER1@EXAMPLE.COM", "OWNER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFCDtjYAL3ym1ydRSsDwLJjD+aFzP8kF2nSfvu9fDV32v0Pv5rqGzxO2GqRFDzMCbQ==", null, false, "", false, "owner1@example.com" },
                    { new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e"), null, 0, null, "288015b0-aa8d-4a24-aee1-c258496ae486", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK9ePgz5S78u9lDn77M+l35T5DQcUlpEaIqYhUuFJowQPp+UAxOqVSTYwwI4/CfPVg==", null, false, "", false, "user2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { new Guid("4245cf7a-4aa2-4467-b411-518830a4a43a"), "Description 3", "Category 3", "category-3" },
                    { new Guid("bf2a84ab-68f7-482d-8dcd-f2c0f9028049"), "Description 1", "Category 1", "category-1" },
                    { new Guid("e1a767ca-708a-4392-bf9a-c16dcf9ab04f"), "Description 2", "Category 2", "category-2" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { new Guid("48c1c139-b86e-4811-899b-05d81814a394"), "Description 3", "Tag 3", "tag-3" },
                    { new Guid("90ee6cd8-7e27-43ea-95a2-1cb21edff54e"), "Description 2", "Tag 2", "tag-2" },
                    { new Guid("bc341849-ae9c-4dc6-8735-ac10d1d76ac1"), "Description 1", "Tag 1", "tag-1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f"), new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed") },
                    { new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f"), new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa") },
                    { new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec"), new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9") },
                    { new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b"), new Guid("70369848-8782-4928-b8e3-106db74c5f3f") },
                    { new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b"), new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891") },
                    { new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec"), new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b") },
                    { new Guid("dc71a2ee-5450-4827-a74a-4ee47043450b"), new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9") },
                    { new Guid("e9d69a07-8601-4d43-8e80-190e97bb068f"), new Guid("c92627c0-9156-494d-bc90-ad381f136852") },
                    { new Guid("9b47fbf8-e0b6-48af-8fa9-3636c7f815ec"), new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Modified", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("274ccdc9-922d-42d3-9931-5448b6a21f21"), new Guid("4245cf7a-4aa2-4467-b411-518830a4a43a"), "Content 3", "Description 3", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10, "Short Description 3", "Post 3", 10, "post-3", 10 },
                    { new Guid("37026059-494f-499e-ac1a-17fb1f8736b0"), new Guid("bf2a84ab-68f7-482d-8dcd-f2c0f9028049"), "Content 1", "Description 1", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Short Description 1", "Post 1", 10, "post-1", 2 },
                    { new Guid("8d248b4b-2a7d-4a85-a2d9-9688ce5aa9a2"), new Guid("e1a767ca-708a-4392-bf9a-c16dcf9ab04f"), "Content 2", "Description 2", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, "Short Description 2", "Post 2", 15, "post-2", 5 }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { new Guid("274ccdc9-922d-42d3-9931-5448b6a21f21"), new Guid("48c1c139-b86e-4811-899b-05d81814a394") },
                    { new Guid("274ccdc9-922d-42d3-9931-5448b6a21f21"), new Guid("bc341849-ae9c-4dc6-8735-ac10d1d76ac1") },
                    { new Guid("37026059-494f-499e-ac1a-17fb1f8736b0"), new Guid("90ee6cd8-7e27-43ea-95a2-1cb21edff54e") },
                    { new Guid("37026059-494f-499e-ac1a-17fb1f8736b0"), new Guid("bc341849-ae9c-4dc6-8735-ac10d1d76ac1") },
                    { new Guid("8d248b4b-2a7d-4a85-a2d9-9688ce5aa9a2"), new Guid("48c1c139-b86e-4811-899b-05d81814a394") },
                    { new Guid("8d248b4b-2a7d-4a85-a2d9-9688ce5aa9a2"), new Guid("90ee6cd8-7e27-43ea-95a2-1cb21edff54e") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UrlSlug",
                table: "Categories",
                column: "UrlSlug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UrlSlug",
                table: "Posts",
                column: "UrlSlug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_UrlSlug",
                table: "Tags",
                column: "UrlSlug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
