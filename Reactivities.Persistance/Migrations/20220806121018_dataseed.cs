using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistance.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { 1, "drinks", "London", new DateTime(2022, 6, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7870), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { 2, "culture", "Paris", new DateTime(2022, 7, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7896), "Activity 1 month ago", "Past Activity 2", "The Louvre" },
                    { 3, "music", "London", new DateTime(2022, 9, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7899), "Activity 1 month in future", "Future Activity 1", "Wembly Stadium" },
                    { 4, "food", "London", new DateTime(2022, 10, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7901), "Activity 2 months in future", "Future Activity 2", "Jamies Italian" },
                    { 5, "drinks", "London", new DateTime(2022, 11, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7973), "Activity 3 months in future", "Future Activity 3", "Pub" },
                    { 6, "culture", "London", new DateTime(2022, 12, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7977), "Activity 4 months in future", "Future Activity 4", "British Museum" },
                    { 7, "drinks", "London", new DateTime(2023, 1, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7978), "Activity 5 months in future", "Future Activity 5", "Punch and Judy" },
                    { 8, "music", "London", new DateTime(2023, 2, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7980), "Activity 6 months in future", "Future Activity 6", "O2 Arena" },
                    { 9, "travel", "Berlin", new DateTime(2023, 3, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7982), "Activity 7 months in future", "Future Activity 7", "All" },
                    { 10, "drinks", "London", new DateTime(2023, 4, 6, 14, 10, 18, 156, DateTimeKind.Local).AddTicks(7983), "Activity 8 months in future", "Future Activity 8", "Pub" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
