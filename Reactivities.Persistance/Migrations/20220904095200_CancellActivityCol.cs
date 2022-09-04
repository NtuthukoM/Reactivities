using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class CancellActivityCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Activities");

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
        }
    }
}
