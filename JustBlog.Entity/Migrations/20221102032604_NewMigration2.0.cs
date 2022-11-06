using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustBlog.Entities.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f8a2d0d-a8d5-42b7-acf9-c3f7d480734b", "AQAAAAIAAYagAAAAEIopP7+OCO0HXOtfK8T9cVe05SVwUcCLtrbUtpqQV/KmwWWdS3GtvsvE/SY16QInFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a55d38a-a30f-43ab-a296-63df9087a7aa", "AQAAAAIAAYagAAAAEJz2pNUAztA1FJtBEAHijMMho25QLTesAr3amPiTmUrITAdmeMQP2zenO/NZo+NKMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc586de8-dfa3-4064-97ef-09495799e805", "AQAAAAIAAYagAAAAEOzFmC2uIv07b5lo5n1ZfUXn17x4uIcA5os+tGHA6J9QJwYm8pVNh2GMrSFbeR1n4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70369848-8782-4928-b8e3-106db74c5f3f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c1bd9a1-7dfa-4ab4-ab34-b44e68b71d9b", "AQAAAAIAAYagAAAAECOkHh6YOZGA4lyaOc4VCZHoKjiApVAINAukK37ED4INMkHViGNxcfHtsZAIzuvttQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0de52d97-cf5f-46d5-91ef-fd4719d92514", "AQAAAAIAAYagAAAAEIF3UlkB6sasH5Z/sy+G6f7XKnPJce9bAptkvlNrnLDIMaCUkcxn29QFyWb2VmDH8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80cb8cda-8d32-41dc-80b6-54b44e55c5cb", "AQAAAAIAAYagAAAAEE/LQO8ken9vxIR/HeZdayFESKX9SwGscFhOfQSUZrK3RL6AlmQEVFeqAZAd1tB5Wg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69cf780f-bd6a-4a6d-a7a0-fd45db9cb760", "AQAAAAIAAYagAAAAEItM6Q/0/px725XSVGmAaDMYkAusewBwHd8gFXmpcQGZ+jzl2y1JG1sSZ3erVFhY3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c92627c0-9156-494d-bc90-ad381f136852"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd2c0ff9-e382-4759-a6d2-d14db6b9f260", "AQAAAAIAAYagAAAAEB4QUjTA/Bssa3HHN1A34/mn7LLt/X3wGMY9V1YuMAmgGYSv3wNZy+6ePy0njVozfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d45d780-586c-427d-8972-2f5a491dd4ef", "AQAAAAIAAYagAAAAEDPpyYL3JO1F4WBzQw9ltvOOF5DaniRlB6haMl1jmR7G1s08g25YgCC8XrVeD5qkng==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c917bbc-383b-4b7e-9fce-bfd76f2f4aed"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "978054ec-bf48-438c-aaa4-c75c15b9330e", "AQAAAAIAAYagAAAAEKJnil0VLpR3KBg3FlOnNqToTlmvh/Fh58LyqlrhZKEOB6U02CA8HpdwLuaT8eSBRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55c97cf2-48a1-455c-80e0-307cca32e4fa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3da3541a-fb57-4651-a384-a283565c9ef6", "AQAAAAIAAYagAAAAEJjksWNgPaYRXWTJyzIyTYapgsWZ56Nh4QG4JorbG64ejhp8OXDSL49hSJ1pGXDo6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56de49b5-22c6-4e3e-8e8c-6adb86a24cc9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e9faacd-8bdd-42f4-a9b0-00f0d55faf70", "AQAAAAIAAYagAAAAEIztDBwh1oc4c/G0dHRRX+BZ6xi7zeUGIcdSCmDcJyQL2RJXmrY1wi7tcx3BGjtUtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70369848-8782-4928-b8e3-106db74c5f3f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "122e66da-e5af-4365-8938-47e66804d7b2", "AQAAAAIAAYagAAAAEJH+nBcga2xXX7BfFFoGi2TJFpCaoOVD6ULTwsL/PmUpn0pCHL+WIEdurgHJiEQw1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b5ed246-11b1-4df6-b36a-9be399f60891"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b53a326-acfd-49f3-9076-86114fb5a59b", "AQAAAAIAAYagAAAAEPq5RpRCBmLoP5ye0CLjc1pr2k/Ls+aYZfUoWnq5HTdX7yM4xCaOVWua/h30ADHHXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ac924737-2076-4cab-983a-f184ef7f2f1b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1840aa8-ff24-4dca-ae14-fc3989c4f14e", "AQAAAAIAAYagAAAAELy+Fo1+yOiurKeJ2hTsz565SpEpL5NhqGxf9M7y9Q/7kce7laZh1HXnyezLOZqg/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aeae5ff8-43cd-4f90-8d9e-234b9c2d14b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "193db009-4221-4fbb-bace-0120aec14d6a", "AQAAAAIAAYagAAAAEPaza3tIkkfuUJtlPa/5rtRmgQNFXCLp/vVa6NOW8g6cZIVBGB7j/J66o+qIwThKHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c92627c0-9156-494d-bc90-ad381f136852"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78c77179-2c1b-4762-aaef-a203c329ce85", "AQAAAAIAAYagAAAAEFGBDm0FWOlowibyZMo3NGYbCVtz15YqnWpa1Z8uOscGtn6KZETQsNHgngYNnxDRnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("da1d155d-2eb4-46ad-81ed-ddd99ea58b4e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53aaec1c-6ded-432c-93b3-c504fe327ba5", "AQAAAAIAAYagAAAAENl+2IXmTB9OXlhIGnh3ZhC47FFWQO3Jm41dPc3bdQ/yWxqvOzTaq9tVQwACy4Gapg==" });
        }
    }
}
