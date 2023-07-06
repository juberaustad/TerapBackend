using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Terap.Identity.Migrations
{
    public partial class roledataseeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a7fd7ed-8db9-49df-a7d5-ae8f6108f13d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9bbe108-df1d-4141-81ee-fabd2df1a994");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd90db2a-bafd-4559-a441-af5f1cf9c073");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8de92482-27a6-419a-bb92-df16f7199df7", "d32f4cc7-4fc1-4234-86e8-5f28d3302c96", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf8c37c4-ea9a-4e2f-94d7-8719da55fb97", "182efb32-e7d4-4651-ac78-a2eab9029a81", "Therapist", "THERAPIST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd04eb54-dfed-4026-a516-af3a588635bf", "7a305146-4197-4bb5-86d0-0330b1051f5c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8de92482-27a6-419a-bb92-df16f7199df7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8c37c4-ea9a-4e2f-94d7-8719da55fb97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd04eb54-dfed-4026-a516-af3a588635bf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a7fd7ed-8db9-49df-a7d5-ae8f6108f13d", "06719617-7b9b-4da6-8e8d-5444953c7f5a", "Therapist", "THERAPIST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9bbe108-df1d-4141-81ee-fabd2df1a994", "c3eca985-2b09-4519-9610-80bfacfca32c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd90db2a-bafd-4559-a441-af5f1cf9c073", "d65b6134-e5a1-495d-b0ae-c28a3b104373", "User", "User" });
        }
    }
}
