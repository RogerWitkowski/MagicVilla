using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class VillaNumberCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 9, 9, 57, 34, 202, DateTimeKind.Local).AddTicks(1297), "Eum aut quos voluptatem eum laudantium harum minima unde debitis repudiandae.", "Ricky Von", 8, 8.0, 219 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 9, 9, 57, 34, 202, DateTimeKind.Local).AddTicks(4603), "Voluptatum et ut voluptatibus consectetur impedit optio omnis sit voluptatem deserunt a rerum sit sit.", "Eloise Feil", 10, 15.0, 454 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 9, 9, 57, 34, 202, DateTimeKind.Local).AddTicks(7405), "Repellat aut dolores fugit officiis dicta sit porro quaerat et repudiandae quo.", "Adaline Crooks", 8, 19.0, 327 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 9, 9, 57, 34, 203, DateTimeKind.Local).AddTicks(292), "Dicta labore architecto aut voluptatem provident aut qui eum non enim ab deserunt.", "Percival Blanda", 1, 7.0, 284 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 9, 9, 57, 34, 203, DateTimeKind.Local).AddTicks(3815), "Minus eius eveniet dignissimos quia libero aliquid necessitatibus praesentium ipsam est officiis.", "Mrs. Lenny Haag", 8, 8.0, 185 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

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
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 6, 14, 2, 10, 103, DateTimeKind.Local).AddTicks(5655), "Vero quo sunt veritatis voluptatibus alias itaque et dolores quae et eos libero quia eos.", "Vicente Schuster Jr.", 1, 13.0, 493 });

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
    }
}
