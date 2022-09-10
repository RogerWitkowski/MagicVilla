using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class foreignKeyToVillaCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 14, 39, 785, DateTimeKind.Local).AddTicks(3547), "Incidunt molestiae itaque facere quia quo recusandae qui aspernatur veritatis tempora tempore aut fugit quisquam.", "Raphael Frederic Witting Jr.", 4.0, 320 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 14, 39, 785, DateTimeKind.Local).AddTicks(8729), "Optio aspernatur qui quas possimus reiciendis qui aliquid esse impedit et.", "Dr. Felton Jarod Luettgen", 3, 7.0, 374 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 14, 39, 786, DateTimeKind.Local).AddTicks(2054), "Ex qui dolores non sapiente eligendi deserunt quia porro non praesentium numquam numquam quisquam.", "Mrs. Richard Farrell IV", 4, 9.0, 139 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 14, 39, 786, DateTimeKind.Local).AddTicks(5055), "Officia necessitatibus dolorum repudiandae saepe vel odit quia totam sint qui voluptates voluptatem fuga cumque.", "Mabel Stanton", 9, 5.0, 399 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 14, 39, 786, DateTimeKind.Local).AddTicks(8187), "In expedita cupiditate quam ducimus ipsa est modi recusandae expedita corrupti voluptas in nihil veniam sit.", "Stewart Lindgren", 2, 16.0, 269 });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 9, 9, 57, 34, 202, DateTimeKind.Local).AddTicks(1297), "Eum aut quos voluptatem eum laudantium harum minima unde debitis repudiandae.", "Ricky Von", 8.0, 219 });

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
    }
}
