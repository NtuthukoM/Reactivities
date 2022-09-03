using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");



            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 11, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 2, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 5, 3, 14, 59, 57, 370, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "72CC07A3-65A5-47DD-82A3-06F313FC12A7", 0, null, "c1ce2db2-05e3-4204-9224-41a107624f24", "Jane", "jane@example.com", true, false, null, "JANE@EXAMPLE.COM", "JANE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMrn+vDVi91gNi/6qOm7zGooZk7zDu08QFxGD41eeVgvLd8kuxVvMCaxeBiIJPdr1Q==", null, false, "85f6b3bb-9950-4341-a60d-bd06f2e426ce", false, "jane@example.com" },
                    { "7D891E0A-E166-45E7-9F15-AE1F683EA43A", 0, null, "9564e64a-db18-4b72-9ed6-4efb77b21c3e", "Bob", "bob@example.com", true, false, null, "BOB@EXAMPLE.COM", "BOB@EXAMPLE.COM", "AQAAAAEAACcQAAAAECKmi3D8SGvyFN7T0kY1Rh1ZY6GxEssML6OZSiX6tYBTXDEgADlVHeMCaNe77Goy6Q==", null, false, "ca19934e-13eb-4629-b723-ce0a41df54cb", false, "bob@example.com" },
                    { "B61171D5-4848-4F3F-B425-EDECCB408C9B", 0, null, "228ad242-38ed-4b42-a579-76de07cd7b3c", "Tom", "tom@example.com", true, false, null, "TOM@EXAMPLE.COM", "TOM@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMfMpWSPDOfLlGdZKJbJe9ViMtK0pJbEJgsaUaDNCOeQPv7L0uhdKWHwf03v7yx2EA==", null, false, "f408e76a-6c88-4097-b10f-8c9c4364c806", false, "tom@example.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B");


            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);


            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 6, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 7, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 10, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 11, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2022, 12, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 1, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 2, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 3, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 4, 28, 19, 55, 12, 814, DateTimeKind.Local).AddTicks(606));
        }
    }
}
