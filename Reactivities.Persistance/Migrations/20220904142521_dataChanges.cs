using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class dataChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 7, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 11, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 12, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 2, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 5, 4, 11, 51, 59, 864, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2504c0dd-98d7-44a8-a124-b754069d9cfa", "AQAAAAEAACcQAAAAEE/yv0i08GQHWBKe/HWZPEOTvtHfeYNsACfMJz3WK37m+Wtmo43ck3QYIgYdIb+fFQ==", "ce3ba0fa-dec2-4cf9-8d74-6754fda78f34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bace95c-c628-4fb8-86a7-ee0da71d92c9", "AQAAAAEAACcQAAAAEPuqYEsVUfUzPYiZHRA7coMUlRnBNrM3zUep5JpSTPF5otKKlwMNT5lL5NiMQmY0zg==", "034d56c8-7cc4-4f26-898d-54b4ca0b596e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8178f827-c499-4bd2-a9fb-3710fc14268a", "AQAAAAEAACcQAAAAEPT3KK+zdLIhWsmhl9EepAguCo7d8Fdk6oeanH0YAQowVDCwr49VHv3uPc9x5Mpezw==", "c66f90a8-76fc-427c-bb7b-70e0be90dcf2" });
        }
    }
}
