using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class attendanceData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ActivityAttendees",
                columns: new[] { "ActivityId", "AppUserId", "IsHost" },
                values: new object[,]
                {
                    { 2, "72CC07A3-65A5-47DD-82A3-06F313FC12A7", false },
                    { 2, "7D891E0A-E166-45E7-9F15-AE1F683EA43A", true },
                    { 3, "72CC07A3-65A5-47DD-82A3-06F313FC12A7", false },
                    { 3, "B61171D5-4848-4F3F-B425-EDECCB408C9B", true },
                    { 4, "7D891E0A-E166-45E7-9F15-AE1F683EA43A", true },
                    { 4, "B61171D5-4848-4F3F-B425-EDECCB408C9B", false },
                    { 5, "72CC07A3-65A5-47DD-82A3-06F313FC12A7", true },
                    { 5, "7D891E0A-E166-45E7-9F15-AE1F683EA43A", false },
                    { 6, "72CC07A3-65A5-47DD-82A3-06F313FC12A7", true },
                    { 7, "72CC07A3-65A5-47DD-82A3-06F313FC12A7", false },
                    { 7, "7D891E0A-E166-45E7-9F15-AE1F683EA43A", true },
                    { 8, "72CC07A3-65A5-47DD-82A3-06F313FC12A7", false },
                    { 8, "B61171D5-4848-4F3F-B425-EDECCB408C9B", true },
                    { 9, "7D891E0A-E166-45E7-9F15-AE1F683EA43A", true },
                    { 9, "B61171D5-4848-4F3F-B425-EDECCB408C9B", false },
                    { 10, "72CC07A3-65A5-47DD-82A3-06F313FC12A7", false },
                    { 10, "B61171D5-4848-4F3F-B425-EDECCB408C9B", true }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 2, "72CC07A3-65A5-47DD-82A3-06F313FC12A7" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 2, "7D891E0A-E166-45E7-9F15-AE1F683EA43A" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 3, "72CC07A3-65A5-47DD-82A3-06F313FC12A7" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 3, "B61171D5-4848-4F3F-B425-EDECCB408C9B" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 4, "7D891E0A-E166-45E7-9F15-AE1F683EA43A" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 4, "B61171D5-4848-4F3F-B425-EDECCB408C9B" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 5, "72CC07A3-65A5-47DD-82A3-06F313FC12A7" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 5, "7D891E0A-E166-45E7-9F15-AE1F683EA43A" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 6, "72CC07A3-65A5-47DD-82A3-06F313FC12A7" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 7, "72CC07A3-65A5-47DD-82A3-06F313FC12A7" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 7, "7D891E0A-E166-45E7-9F15-AE1F683EA43A" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 8, "72CC07A3-65A5-47DD-82A3-06F313FC12A7" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 8, "B61171D5-4848-4F3F-B425-EDECCB408C9B" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 9, "7D891E0A-E166-45E7-9F15-AE1F683EA43A" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 9, "B61171D5-4848-4F3F-B425-EDECCB408C9B" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 10, "72CC07A3-65A5-47DD-82A3-06F313FC12A7" });

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 10, "B61171D5-4848-4F3F-B425-EDECCB408C9B" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 11, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 2, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 5, 4, 16, 25, 21, 365, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90048c72-aae9-4220-ab90-e9cab699ead7", "AQAAAAEAACcQAAAAEKAz4DbD0ejwRvNiBlnm2x5PujuXLxL35pdiQxXSffir+0GBnL8oN7TALCYL/19BKg==", "e017cb31-7d86-485c-8952-872c537fb9f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd9b959-135b-47db-bc38-92ac603cb750", "AQAAAAEAACcQAAAAEJAy1U5G3jBjH/b8P2fZoqbFmDYQR96+iD09ZNmZO+YEoT3UlHlD8DZ0+szsPyr37Q==", "bb7289ca-cadb-42b1-989c-ee06734475e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a58cba1-51f3-40ff-ad37-02788b8e0090", "AQAAAAEAACcQAAAAELhLq4XH/xm1bsUMCH0O6q3RSuIJyb7whjA+47ebnXNpiCBBdztXddyW6jb+YFgWjg==", "4c8c7bf6-2bdf-427e-86de-9c42cf1c1902" });
        }
    }
}
