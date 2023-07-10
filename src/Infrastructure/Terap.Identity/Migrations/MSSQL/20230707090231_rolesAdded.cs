using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Terap.Identity.Migrations
{
    public partial class rolesAdded : Migration
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
                values: new object[] { "02e3e85b-7f98-43ea-916c-e8070f4073e2", "5d3a1593-11a5-4115-af6e-b7534f8460d7", "Therapist", "THERAPIST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ad70a32-f8e0-4d4e-b574-6b5801ed2948", "7c2a5a00-9540-463a-be93-211242a378b5", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f3f2c3a-d5c1-4bf2-aa68-5bd3fcfc13af", "b7a09633-cb71-48ca-bf78-f50f41d869c0", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02e3e85b-7f98-43ea-916c-e8070f4073e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ad70a32-f8e0-4d4e-b574-6b5801ed2948");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f3f2c3a-d5c1-4bf2-aa68-5bd3fcfc13af");

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
