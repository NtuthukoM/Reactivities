using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class activityAttendees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityAttendees",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    IsHost = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAttendees", x => new { x.ActivityId, x.AppUserId });
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 11, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 2, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 5, 4, 10, 47, 46, 343, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bccb6c33-5ff0-457a-a9c0-cf27b10cd1fa", "AQAAAAEAACcQAAAAEHrKXfuRSV9o6UZEgEFUmEwwTmGTTk2YXVb6GgA3/jVjsxTWrthd8LELnZC7uSSrew==", "8ba4d767-992b-45a7-833e-a37daae1a8a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6fd19d0-3a0a-4bd6-9687-d10b3b8382eb", "AQAAAAEAACcQAAAAEAacksHiJoGohNJtEEErPpe7brGcIDYBHJeD+Oo7Eaeg85zot7IV+UHGSX1NQoOWCA==", "0875b33e-51f5-46ba-8a1d-7bebd6f22869" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c685f647-d560-40eb-a923-8dfc99be6315", "AQAAAAEAACcQAAAAENDZMgfT0dHnCy2WJVA5B/jOAKClThs8KNGiplk2b329ig4JIx8TqMwy55/fnaz7mw==", "80540be1-8074-42c8-bff8-6d5b0dda3238" });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAttendees_AppUserId",
                table: "ActivityAttendees",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityAttendees");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1ce2db2-05e3-4204-9224-41a107624f24", "AQAAAAEAACcQAAAAEMrn+vDVi91gNi/6qOm7zGooZk7zDu08QFxGD41eeVgvLd8kuxVvMCaxeBiIJPdr1Q==", "85f6b3bb-9950-4341-a60d-bd06f2e426ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9564e64a-db18-4b72-9ed6-4efb77b21c3e", "AQAAAAEAACcQAAAAECKmi3D8SGvyFN7T0kY1Rh1ZY6GxEssML6OZSiX6tYBTXDEgADlVHeMCaNe77Goy6Q==", "ca19934e-13eb-4629-b723-ce0a41df54cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "228ad242-38ed-4b42-a579-76de07cd7b3c", "AQAAAAEAACcQAAAAEMfMpWSPDOfLlGdZKJbJe9ViMtK0pJbEJgsaUaDNCOeQPv7L0uhdKWHwf03v7yx2EA==", "f408e76a-6c88-4097-b10f-8c9c4364c806" });
        }
    }
}
