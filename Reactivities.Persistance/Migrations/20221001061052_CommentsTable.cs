using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class CommentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 11, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 12, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 1, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 2, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 3, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 5, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 6, 1, 8, 10, 51, 863, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "780c0151-52ed-4391-843f-8915d19cc1b7", "AQAAAAEAACcQAAAAEDkQq81ogPJIyotkBbhXkQPTwyb123SUy8SrhXJOGkkM6chAmYIjNtII3lsE1z4lOQ==", "cff89bfc-b5ef-4658-b77e-d96925a10075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4611901-99a3-4bd9-8bfd-36978b3b32ea", "AQAAAAEAACcQAAAAELWW0jX4QCeSYhEHEjv/AVK5jgLaJxk7/rMj91HJjGAmi/DJY0OriwLk9jeLFi/PsQ==", "d162f7c8-9892-4f18-b2cf-e7f7208edde9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c873b9bb-07e8-482b-871e-bba54e31a765", "AQAAAAEAACcQAAAAEPbeO7QU3UdKDUfd8xlkVV6aZuZtzEWkkjJA85VdtHwz+iOpQyKEDSfByIqSXGPPjA==", "9e54d87f-45dc-45e7-8ecb-fa3b4ed54fbf" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ActivityId",
                table: "Comments",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

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
        }
    }
}
