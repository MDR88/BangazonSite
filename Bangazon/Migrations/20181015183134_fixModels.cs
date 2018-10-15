using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class fixModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "034144df-c68d-472c-a048-4f029d93b3d7", "2c7303d0-d025-42c5-85c4-063015f64285" });

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "PaymentType",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68ca57a5-e34c-4293-b736-1493d030cc1d", 0, "Nashville", "754e153c-c7fe-4916-af3c-86049d0cb62f", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENkuLY2aI0PyQiO0yOkqOofdJCqwoi47eSxRucUM588+nJ/v9LBCZpFVvX55SU9f4A==", null, false, "855292cd-e8e9-4895-9b78-2ac937e8e585", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "68ca57a5-e34c-4293-b736-1493d030cc1d" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "68ca57a5-e34c-4293-b736-1493d030cc1d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "68ca57a5-e34c-4293-b736-1493d030cc1d", "754e153c-c7fe-4916-af3c-86049d0cb62f" });

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "PaymentType",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "034144df-c68d-472c-a048-4f029d93b3d7", 0, "2c7303d0-d025-42c5-85c4-063015f64285", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGXj43arQneGF7R2ht8Yg3NSmeSCzJbY9nNaxaNjXP9Vc+Wuzk5sYRdJ11IA00S8Ug==", null, false, "42f3e89a-d686-4ae0-8aac-8b8ebe198c83", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "034144df-c68d-472c-a048-4f029d93b3d7" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "034144df-c68d-472c-a048-4f029d93b3d7" });
        }
    }
}
