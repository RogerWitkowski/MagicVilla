using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(9864), "Sequi sint commodi est qui veritatis maxime odio porro voluptatibus magni quia vel.", "https://i.picsum.photos/id/778/200/200.jpg?hmac=fgFK_HI_g_N4MzYuYbssOB8ymhT_m0JK61tNJHfdPYU", "Alec Schulist", 9, 3.0, 328, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2022, 9, 11, 15, 51, 19, 586, DateTimeKind.Local).AddTicks(2348), "Neque ipsum maxime cumque iusto recusandae pariatur qui ea cupiditate.", "https://i.picsum.photos/id/287/200/200.jpg?hmac=kXFCSMZE2rF7NM-EFSH6c_nl5HlKQWvwCdE8JYL-YNQ", "Herman Wehner", 8, 10.0, 430, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2022, 9, 11, 15, 51, 19, 586, DateTimeKind.Local).AddTicks(4857), "Accusamus sed laudantium ullam enim aperiam in aspernatur sequi aliquam.", "https://i.picsum.photos/id/446/200/200.jpg?hmac=PkaLcCtgL4IvAz-gsxbCXz_tl0qdVUGOrxhYLrywa-c", "Alvera Wilderman", 8, 2.0, 130, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2022, 9, 11, 15, 51, 19, 586, DateTimeKind.Local).AddTicks(8764), "Repellendus modi sunt voluptatem omnis et ipsa officiis dolor qui molestias earum.", "https://i.picsum.photos/id/602/200/200.jpg?hmac=UQpVCHEMGI1-S-kt8OQLic6TfuG2elfLbLTNDl1mqZE", "Alejandrin Bailey Walsh II", 9, 8.0, 421, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2022, 9, 11, 15, 51, 19, 587, DateTimeKind.Local).AddTicks(1647), "Perspiciatis tempore error illum non repellat eligendi sit molestias quo officia velit unde dolore.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Jimmy Schowalter", 8, 12.0, 410, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "", new DateTime(2022, 9, 11, 15, 51, 19, 587, DateTimeKind.Local).AddTicks(5601), "Unde amet necessitatibus voluptate qui voluptatibus nulla sint est laborum voluptatum aliquam voluptatem ullam hic id.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ashlee Heller Sr.", 7, 11.0, 271, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "", new DateTime(2022, 9, 11, 15, 51, 19, 587, DateTimeKind.Local).AddTicks(9975), "Qui id et est aut eaque voluptatem laboriosam ut ea libero aperiam qui suscipit debitis aut.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Miss Kassandra Triston Frami V", 9, 1.0, 335, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "", new DateTime(2022, 9, 11, 15, 51, 19, 588, DateTimeKind.Local).AddTicks(2430), "Repellat tempore sit voluptates ut eligendi fugiat eos est qui.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Gladys Schowalter", 4, 20.0, 326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "", new DateTime(2022, 9, 11, 15, 51, 19, 588, DateTimeKind.Local).AddTicks(5028), "Dolor optio neque eveniet et voluptas dolorem labore nisi ut est.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Vern Luettgen Sr.", 2, 4.0, 126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "", new DateTime(2022, 9, 11, 15, 51, 19, 588, DateTimeKind.Local).AddTicks(8846), "Voluptatem et nihil doloribus sint quod quidem commodi error fugit amet.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ms. Ofelia Tatum Simonis", 10, 1.0, 263, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "", new DateTime(2022, 9, 11, 15, 51, 19, 589, DateTimeKind.Local).AddTicks(2950), "Ratione facere tenetur sapiente quibusdam veniam occaecati reiciendis ut earum voluptate dolorem corrupti debitis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mrs. Lucas Lura Franecki", 3, 20.0, 239, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "", new DateTime(2022, 9, 11, 15, 51, 19, 589, DateTimeKind.Local).AddTicks(5608), "Dolorem nulla ipsa aut est officiis et aut maxime aut velit sed.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Domingo Braun MD", 4, 16.0, 472, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "", new DateTime(2022, 9, 11, 15, 51, 19, 589, DateTimeKind.Local).AddTicks(8639), "Iste dolores pariatur et reiciendis velit repellat culpa explicabo est enim itaque cum unde ea inventore.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Derek Watsica", 8, 3.0, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "", new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(1238), "Necessitatibus atque atque sit nemo laborum incidunt voluptatibus qui quia ut.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mr. Leta Robel", 6, 7.0, 487, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "", new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(3695), "Neque consequuntur nam aut dicta id temporibus odio cum dolores.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Jakob Rodriguez", 9, 19.0, 478, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "", new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(6147), "Ut earum iure dignissimos amet reiciendis consectetur laudantium velit quis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Burdette Nikolaus", 7, 18.0, 448, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "", new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(8870), "Consequatur quo qui accusantium consequatur enim at quae cum animi aut iusto velit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Samanta Turcotte", 5, 6.0, 222, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "", new DateTime(2022, 9, 11, 15, 51, 19, 591, DateTimeKind.Local).AddTicks(1615), "Sint perspiciatis dignissimos natus eos dolorem molestiae pariatur dolorem at commodi ex laborum.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Isaias Keeling", 7, 1.0, 358, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "", new DateTime(2022, 9, 11, 15, 51, 19, 591, DateTimeKind.Local).AddTicks(5566), "Quasi ea nihil architecto laboriosam dignissimos exercitationem suscipit error corrupti sapiente et.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Jade Vella Williamson PhD", 4, 18.0, 346, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "", new DateTime(2022, 9, 11, 15, 51, 19, 591, DateTimeKind.Local).AddTicks(8528), "Rerum et architecto consequatur et est laboriosam sed nostrum optio a et velit esse hic.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Marcelo Runolfsson", 5, 15.0, 246, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "", new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(1170), "Commodi labore sapiente rerum ut enim nostrum unde voluptates non veritatis quia.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Laron Feil", 1, 4.0, 398, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "", new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(3785), "Illo est consequuntur blanditiis eum dolorem recusandae dolorem occaecati consequatur perspiciatis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mr. Tamia Ledner PhD", 3, 8.0, 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "", new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(6320), "Numquam facilis exercitationem voluptatem nemo impedit sunt non molestias vero et.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Randi Bogan", 5, 9.0, 451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "", new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(8963), "Ex rerum sit voluptatum quisquam id ut nam labore veritatis delectus qui.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Dorothy Schinner", 6, 9.0, 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "", new DateTime(2022, 9, 11, 15, 51, 19, 593, DateTimeKind.Local).AddTicks(1414), "Porro numquam id rem sapiente est dolor ea reprehenderit quo.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Hunter Collier", 10, 16.0, 364, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "", new DateTime(2022, 9, 11, 15, 51, 19, 593, DateTimeKind.Local).AddTicks(4093), "Qui omnis doloribus accusamus aut velit dicta impedit excepturi impedit consequuntur perferendis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Randal Douglas", 6, 20.0, 366, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "", new DateTime(2022, 9, 11, 15, 51, 19, 593, DateTimeKind.Local).AddTicks(6617), "Debitis facilis aut sint dolor fugiat suscipit rerum voluptas est.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Tomasa Barton", 5, 13.0, 173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "", new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(727), "Quis sunt sit omnis temporibus velit et ut voluptas sunt commodi blanditiis illum qui.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Celestine Chanel Romaguera DDS", 2, 4.0, 142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "", new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(3380), "Laudantium assumenda magnam vitae sunt ut error officiis possimus sapiente debitis molestiae.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Sam Hudson PhD", 5, 12.0, 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "", new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(6232), "Qui et voluptatum asperiores adipisci sed molestias corrupti totam suscipit magnam voluptatibus ullam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Zoila Runolfsson", 3, 14.0, 275, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "", new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(9957), "Praesentium error dolorem laudantium animi voluptas porro sapiente corrupti ut.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Adell Anissa Wolf III", 2, 17.0, 238, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "", new DateTime(2022, 9, 11, 15, 51, 19, 595, DateTimeKind.Local).AddTicks(3014), "Sed esse itaque tempore eaque mollitia omnis magnam eligendi qui repellat nulla minus qui accusamus.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Betty Glover", 6, 10.0, 430, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "", new DateTime(2022, 9, 11, 15, 51, 19, 595, DateTimeKind.Local).AddTicks(6152), "Et doloremque aliquam et officiis quis neque maxime ut veritatis temporibus ratione consequatur ut cum.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Russell Lindgren PhD", 5, 11.0, 427, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "", new DateTime(2022, 9, 11, 15, 51, 19, 595, DateTimeKind.Local).AddTicks(9094), "Facilis aut et blanditiis aut culpa a est sint ut esse id et quis exercitationem.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Elton Muller", 3, 3.0, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "", new DateTime(2022, 9, 11, 15, 51, 19, 596, DateTimeKind.Local).AddTicks(3803), "Impedit tempora sint qui voluptatem est id dolorum accusantium consequatur animi aut laboriosam qui perspiciatis sit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Monroe Andy Kertzmann", 5, 7.0, 425, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "", new DateTime(2022, 9, 11, 15, 51, 19, 596, DateTimeKind.Local).AddTicks(6707), "Molestias itaque velit nihil aut dolorem dolores dolore beatae animi quo.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Chelsea Stamm", 7, 18.0, 320, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "", new DateTime(2022, 9, 11, 15, 51, 19, 597, DateTimeKind.Local).AddTicks(1535), "Recusandae odit nisi facilis tenetur nesciunt adipisci et laborum cumque corrupti quam aut reprehenderit eveniet aperiam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Bradley Samara Zieme DVM", 6, 9.0, 391, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "", new DateTime(2022, 9, 11, 15, 51, 19, 597, DateTimeKind.Local).AddTicks(4761), "Dolorem quibusdam autem qui doloribus quas animi expedita amet possimus eaque iure nam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Karianne Gulgowski", 6, 1.0, 258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "", new DateTime(2022, 9, 11, 15, 51, 19, 597, DateTimeKind.Local).AddTicks(9606), "Rerum hic ut est a possimus amet magni ea ratione et fugiat molestiae velit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Hosea Federico Marks Jr.", 5, 4.0, 484, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "", new DateTime(2022, 9, 11, 15, 51, 19, 598, DateTimeKind.Local).AddTicks(2661), "Iste ut ducimus fugiat qui rerum quasi possimus dolores earum in similique.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Hudson Hills", 9, 9.0, 268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 9, 11, 15, 51, 19, 584, DateTimeKind.Local).AddTicks(7289), "Maiores autem in tempore veritatis eveniet sapiente dignissimos consequatur corrupti laudantium laboriosam repellendus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 102, new DateTime(2022, 9, 11, 15, 51, 19, 584, DateTimeKind.Local).AddTicks(8554), "Tenetur ipsam suscipit consectetur aut quibusdam cumque aut atque sed et accusantium.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 103, new DateTime(2022, 9, 11, 15, 51, 19, 584, DateTimeKind.Local).AddTicks(9503), "Et reiciendis accusamus placeat atque odit laboriosam velit est saepe.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 104, new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(1018), "Quae consectetur sunt fugiat vel voluptas et incidunt qui non aspernatur labore eos et dolorem at.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 105, new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(2142), "Magnam et et ab ad porro omnis maxime commodi doloribus nihil a.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 106, new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(3223), "Sequi quisquam totam voluptas neque et quia alias enim aut non.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 107, new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(4311), "Quis omnis voluptas molestiae accusantium ex vitae doloribus ratione sit ut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 109, new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(5743), "Aut deleniti non labore eligendi voluptas repellendus delectus ut ut voluptatem fugiat qui aut tenetur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 110, new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(6771), "Dolore placeat animi praesentium sint est et dolores laudantium soluta aliquam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
