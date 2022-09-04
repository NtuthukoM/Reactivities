using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class attendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 11, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 2, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 5, 4, 16, 26, 21, 8, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0358f5c2-6013-4e54-93f7-cde105467812", "AQAAAAEAACcQAAAAEOlXpOe6TbUsC+Vnb9sxJS7RKtEACa5IdCqFG0wc8fOUdGZxghPNebkhYFH4UcfNiA==", "c32f0cdb-6582-477a-bc1b-e13036ea3039" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76294e93-3517-4666-92a3-caeff0c26bf1", "AQAAAAEAACcQAAAAECPm4ggSBpQZkVsha98HIa3rD6zEGcygA7xFwpq9X16hECU+ZrtBodtDpO9Crf9ItA==", "3fbb37f5-9182-45d0-aaba-c5d9e6a80bfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd6e0a94-14c2-4ebb-b0a2-6b498f09b9bc", "AQAAAAEAACcQAAAAEP/KGoHpObfhyg9Jpxi2FQy5R0EOaFBcMfMeYXoHAInSDfljzd5bqUU3DHOdVC6Lzg==", "d6177be8-9785-43d4-8ecc-ff23e348f7f2" });

            migrationBuilder.InsertData(
                table: "ActivityAttendees",
                columns: new[] { "ActivityId", "AppUserId", "IsHost" },
                values: new object[,]
                {
                    { 1, "7D891E0A-E166-45E7-9F15-AE1F683EA43A", true },
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { 1, "7D891E0A-E166-45E7-9F15-AE1F683EA43A" });

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
