using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class PhotosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 11, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 2, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 5, 10, 14, 47, 4, 364, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "331b37c4-7aea-4ac8-852d-fdc06c00114f", "AQAAAAEAACcQAAAAEL7gwCBUu4qlF5mLtRaCHRMhE5zqflDbq5YUY4v8uwWLvUWmNkMu1pEkmgvH4T8Yjg==", "f87022fa-1d90-4158-bf96-364c9570b6b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43acc0e0-acf5-419d-89aa-04b5b1c329fd", "AQAAAAEAACcQAAAAEGLQDo9zh//gRgGIWJqw5LGB25x4LqV/c84I9ErgLbkHYa83u8oTh8UNKWKxER0LAQ==", "66016e97-c19f-45f2-bab7-49712fd5de96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e53b0fdc-a76e-4003-842e-9f0e21edc6b9", "AQAAAAEAACcQAAAAEOf0EwxbiNDush9MCtkfQP7LOKeYFsgFyr0bcNMZg39yHuINOCW3LPLz51PW0j+voA==", "dc22d759-985d-4494-be0a-1002c33ea1da" });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 11, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 2, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 5, 9, 21, 11, 47, 960, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2c3c57d-5f2b-41e2-a907-d337e5654cdd", "AQAAAAEAACcQAAAAEMf30TR+nRT+oehnVX/SKoa/SR30i0/manLU6YMoo26hqxnyRS+Ljqpiy7Ji6oeaoQ==", "69a29c84-08e7-4c11-a2ac-6a2efe6cc65c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "389c5699-b38b-4aea-9496-410fb95c5268", "AQAAAAEAACcQAAAAEFfItep5GKmMaerFCr23NjjUVGcTEFtBBIrJgWtIbwQ+GDx8mcS0Yj8WXBBXg+8mqg==", "0cf1859d-447c-4c9b-80d1-14b86aedf22f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10591a41-3079-4c21-b31a-e32a8b8f792b", "AQAAAAEAACcQAAAAEAnr0Yc3D4TDy+VtjJiVlE637ZPwv42gadrIAkW9KUzfVY0KN0jRv8PQLBDvtDlHcQ==", "c8e925c3-1db3-467f-878a-987991658ce1" });
        }
    }
}
