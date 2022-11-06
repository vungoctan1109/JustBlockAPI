using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustBlog.Entities.Migrations
{
    /// <inheritdoc />
    public partial class NewUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tags_UrlSlug",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UrlSlug",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UrlSlug",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Tags",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tags",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CommentHeader",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "978054ec-bf48-438c-aaa4-c75c15b9330e", "AQAAAAIAAYagAAAAEKJnil0VLpR3KBg3FlOnNqToTlmvh/Fh58LyqlrhZKEOB6U02CA8HpdwLuaT8eSBRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "3da3541a-fb57-4651-a384-a283565c9ef6", "AQAAAAIAAYagAAAAEJjksWNgPaYRXWTJyzIyTYapgsWZ56Nh4QG4JorbG64ejhp8OXDSL49hSJ1pGXDo6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "4e9faacd-8bdd-42f4-a9b0-00f0d55faf70", "AQAAAAIAAYagAAAAEIztDBwh1oc4c/G0dHRRX+BZ6xi7zeUGIcdSCmDcJyQL2RJXmrY1wi7tcx3BGjtUtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70369848-8782-4928-b8e3-106db74c5f3f"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "122e66da-e5af-4365-8938-47e66804d7b2", "AQAAAAIAAYagAAAAEJH+nBcga2xXX7BfFFoGi2TJFpCaoOVD6ULTwsL/PmUpn0pCHL+WIEdurgHJiEQw1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "0b53a326-acfd-49f3-9076-86114fb5a59b", "AQAAAAIAAYagAAAAEPq5RpRCBmLoP5ye0CLjc1pr2k/Ls+aYZfUoWnq5HTdX7yM4xCaOVWua/h30ADHHXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "c1840aa8-ff24-4dca-ae14-fc3989c4f14e", "AQAAAAIAAYagAAAAELy+Fo1+yOiurKeJ2hTsz565SpEpL5NhqGxf9M7y9Q/7kce7laZh1HXnyezLOZqg/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "193db009-4221-4fbb-bace-0120aec14d6a", "AQAAAAIAAYagAAAAEPaza3tIkkfuUJtlPa/5rtRmgQNFXCLp/vVa6NOW8g6cZIVBGB7j/J66o+qIwThKHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c92627c0-9156-494d-bc90-ad381f136852"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "78c77179-2c1b-4762-aaef-a203c329ce85", "AQAAAAIAAYagAAAAEFGBDm0FWOlowibyZMo3NGYbCVtz15YqnWpa1Z8uOscGtn6KZETQsNHgngYNnxDRnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { 0, "53aaec1c-6ded-432c-93b3-c504fe327ba5", "AQAAAAIAAYagAAAAENl+2IXmTB9OXlhIGnh3ZhC47FFWQO3Jm41dPc3bdQ/yWxqvOzTaq9tVQwACy4Gapg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_UrlSlug",
                table: "Tags",
                column: "UrlSlug",
                unique: true,
                filter: "[UrlSlug] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UrlSlug",
                table: "Posts",
                column: "UrlSlug",
                unique: true,
                filter: "[UrlSlug] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UrlSlug",
                table: "Categories",
                column: "UrlSlug",
                unique: true,
                filter: "[UrlSlug] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tags_UrlSlug",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UrlSlug",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UrlSlug",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Tags",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tags",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CommentHeader",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "aee72114-6de6-47d1-82b8-417b285ccb6b", "AQAAAAIAAYagAAAAEPTb4V/OkIXifI29nrbFcb/NH3j89+oqZBe4tmkTXRI5Ycl0X5npBbbPM2HE5k3rNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "75470c26-5712-4145-b160-01663cc43095", "AQAAAAIAAYagAAAAELFcg1/EGvMEjWy/+gPkaDphm/Nh1E9hQ5aXeRixozeq67jmw9VZxtwYorc+BZtV0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "2daaed9a-9b49-4946-b4b5-2e4589a57ec6", "AQAAAAIAAYagAAAAEE/lMy/etm3nmU5sy9T4tCjxKqy+yIL8rpwyjEjU95mSVHFqbxbaEVU6Z54MUhl5RQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70369848-8782-4928-b8e3-106db74c5f3f"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "8b18d31e-18e6-4ede-938e-c0636839fce7", "AQAAAAIAAYagAAAAEI7Y0Of5DvsYcOjbt2V6bSj7oX/xFv98lV3/oPQpUT1vL6BdRUlqI7ws69uR5Ujgbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "37998e89-b61e-4568-b638-a9d2bace9526", "AQAAAAIAAYagAAAAEF8L48/odsERYmDlpjQTGc86TH4q+WZDl6CFSUCKOnCci+MLfRsKCpRyNw1ZTD2b/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "db25b527-bdc9-462e-8f55-79a02d26d268", "AQAAAAIAAYagAAAAEKU8wMwNYPLrS5NZeo0J6kLQXbEwnEeL+nyPXxr//SSvCtG6JcZca1dVY/5oySHIKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "9276040e-7bc0-462c-9782-5d7237abaabd", "AQAAAAIAAYagAAAAEKypp5LMptInqFTFl4XO9Bf0iGTJvdL1oUPYNTLB4D1Gn/5Dfhr93/B++UbtjBe40g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c92627c0-9156-494d-bc90-ad381f136852"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "7c283d66-32fc-449a-9121-2d0838d67e16", "AQAAAAIAAYagAAAAEFCDtjYAL3ym1ydRSsDwLJjD+aFzP8kF2nSfvu9fDV32v0Pv5rqGzxO2GqRFDzMCbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e"),
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "288015b0-aa8d-4a24-aee1-c258496ae486", "AQAAAAIAAYagAAAAEK9ePgz5S78u9lDn77M+l35T5DQcUlpEaIqYhUuFJowQPp+UAxOqVSTYwwI4/CfPVg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_UrlSlug",
                table: "Tags",
                column: "UrlSlug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UrlSlug",
                table: "Posts",
                column: "UrlSlug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UrlSlug",
                table: "Categories",
                column: "UrlSlug",
                unique: true);
        }
    }
}
