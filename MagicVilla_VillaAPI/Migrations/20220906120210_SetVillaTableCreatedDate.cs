using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class SetVillaTableCreatedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 6, 14, 2, 10, 103, DateTimeKind.Local).AddTicks(1249), "Distinctio quam et inventore alias et facilis deserunt explicabo eos dolores quia fugit amet.", "Ms. Easton DuBuque", 3, 11.0, 451 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 6, 14, 2, 10, 103, DateTimeKind.Local).AddTicks(5655), "Vero quo sunt veritatis voluptatibus alias itaque et dolores quae et eos libero quia eos.", "Vicente Schuster Jr.", 13.0, 493 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 6, 14, 2, 10, 103, DateTimeKind.Local).AddTicks(8814), "Ab iure id iure non suscipit et rerum suscipit sequi tempore non.", "Miss Mekhi Halvorson MD", 4, 8.0, 121 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 6, 14, 2, 10, 104, DateTimeKind.Local).AddTicks(1308), "Et ducimus voluptatibus labore repellendus et distinctio qui repellat minima.", "Mr. Brant Nicolas II", 8, 20.0, 103 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 6, 14, 2, 10, 104, DateTimeKind.Local).AddTicks(6225), "Aut sint aspernatur mollitia quae voluptate voluptatem inventore dicta rerum ullam eligendi nam.", "Miss Mayra Shannon Ruecker MD", 5, 19.0, 389 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non et tempora esse suscipit magni sed debitis qui voluptatem voluptatem velit.", "Ms. Owen Hans Runolfsson", 9, 14.0, 146 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemo dolores consectetur ut exercitationem deleniti omnis inventore voluptas consequatur nihil.", "Suzanne Jacobi", 15.0, 325 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numquam reprehenderit excepturi dicta corporis pariatur alias cumque quas fuga qui inventore consectetur fuga id quod.", "Mrs. Foster Skiles", 7, 13.0, 189 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil quae voluptatum ut expedita enim nam beatae consequatur aperiam cumque provident.", "Terrill Doyle DVM", 1, 1.0, 262 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus possimus nihil dolorem rerum possimus omnis ipsum quidem fugiat reprehenderit omnis nisi minima nemo vero.", "Mr. Ronaldo Shanna Kihn Jr.", 3, 14.0, 261 });
        }
    }
}
