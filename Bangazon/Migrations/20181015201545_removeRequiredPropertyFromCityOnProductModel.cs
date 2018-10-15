using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class removeRequiredPropertyFromCityOnProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e7dea6c0-7263-4bd4-aa11-f8fba643ebdb", "7c0e54c6-ca90-4d33-8daf-e80bb37165b7" });

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bc345cff-fa39-4d72-9271-841542f9c697", 0, "ad3e5630-4a56-4b48-b1a7-7e8b518625c1", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGJhCcQ6kP95q6wdCEswiJYKAFuKikQG96aioAlNTwy4UVXyEEypgQhozUdR0uNu3Q==", null, false, "7e00dd17-9c79-4365-a06c-dfe4ef7d2a74", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bc345cff-fa39-4d72-9271-841542f9c697" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bc345cff-fa39-4d72-9271-841542f9c697" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bc345cff-fa39-4d72-9271-841542f9c697", "ad3e5630-4a56-4b48-b1a7-7e8b518625c1" });

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e7dea6c0-7263-4bd4-aa11-f8fba643ebdb", 0, "7c0e54c6-ca90-4d33-8daf-e80bb37165b7", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGMlxW28LvMW8aelb+IIZ5voyrn74J20lRooLhNf1jGocLc/toxJ4SFqR/Anqkw2uA==", null, false, "4b77bca1-af25-4e26-85a2-bfe10ecefa4d", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e7dea6c0-7263-4bd4-aa11-f8fba643ebdb" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e7dea6c0-7263-4bd4-aa11-f8fba643ebdb" });
        }
    }
}
