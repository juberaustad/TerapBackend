using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Terap.Identity.Migrations
{
    public partial class foridentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a972e02-bd92-4f19-b68e-072717c524dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccacba83-5872-438b-826a-16d418032e23");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0a972e02-bd92-4f19-b68e-072717c524dc", "8978dd6c-909b-402f-beab-846c9e03fa2a", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccacba83-5872-438b-826a-16d418032e23", "908d4509-95d6-495d-b13e-c52e4f6e7e49", "Administrator", "ADMINISTRATOR" });
        }
    }
}
