using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class FollowingEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFollowings",
                columns: table => new
                {
                    ObserverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TargetId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollowings", x => new { x.ObserverId, x.TargetId });
                    table.ForeignKey(
                        name: "FK_UserFollowings_AspNetUsers_ObserverId",
                        column: x => x.ObserverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserFollowings_AspNetUsers_TargetId",
                        column: x => x.TargetId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 11, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 12, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 1, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 2, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 3, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 5, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 6, 1, 16, 28, 37, 400, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72CC07A3-65A5-47DD-82A3-06F313FC12A7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89412066-f6b5-4e3b-8c93-a0e66dd5bb2e", "AQAAAAEAACcQAAAAEO4SLxzPIBtVT04HWuzhlGDp5s7iz1kSMyYYfxoHyq1QZxXcdQsTnWfPEfcST+tmtQ==", "50300cbe-8e80-4b93-8750-71e49ca58a8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7D891E0A-E166-45E7-9F15-AE1F683EA43A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e060bfb-b81e-4520-82a7-b12c688aa4e7", "AQAAAAEAACcQAAAAEGVHbH9gxxA/vknwPDR+2qPtQEpkwG/cQ5bbp+sLXwoUjQLOXS9sLgE7uMUGRKYs3w==", "dc5a5912-fa98-4506-9645-d42b296ac0bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B61171D5-4848-4F3F-B425-EDECCB408C9B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62ad0132-e4af-4303-b95f-81c34b328670", "AQAAAAEAACcQAAAAEAmnpwmJRn4YmtoTTXCp8HpB8Ma7+AOloisx8SSIq27RG7EKwbDPHHObnenY8t4D8w==", "4addb173-881e-4bc9-8cf0-3a768dfbf833" });

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowings_TargetId",
                table: "UserFollowings",
                column: "TargetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFollowings");

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
        }
    }
}
