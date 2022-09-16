using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

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
                    { 1, "", new DateTime(2022, 9, 14, 22, 23, 26, 0, DateTimeKind.Local).AddTicks(1553), "Autem ut et aspernatur ut et architecto dolorem et animi nesciunt et ea corrupti inventore consequuntur.", "https://i.picsum.photos/id/778/200/200.jpg?hmac=fgFK_HI_g_N4MzYuYbssOB8ymhT_m0JK61tNJHfdPYU", "Dana Cordie Bednar IV", 3, 13.0, 473, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2022, 9, 14, 22, 23, 26, 0, DateTimeKind.Local).AddTicks(4113), "Corrupti et est voluptate at minus et magni est voluptates.", "https://i.picsum.photos/id/287/200/200.jpg?hmac=kXFCSMZE2rF7NM-EFSH6c_nl5HlKQWvwCdE8JYL-YNQ", "Kennedi Feest", 9, 11.0, 268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2022, 9, 14, 22, 23, 26, 0, DateTimeKind.Local).AddTicks(6965), "Blanditiis recusandae iste voluptate sequi aliquam consequuntur dolor necessitatibus id eaque blanditiis nobis molestias.", "https://i.picsum.photos/id/446/200/200.jpg?hmac=PkaLcCtgL4IvAz-gsxbCXz_tl0qdVUGOrxhYLrywa-c", "Markus Swaniawski", 5, 8.0, 485, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2022, 9, 14, 22, 23, 26, 0, DateTimeKind.Local).AddTicks(9605), "Repudiandae molestiae est esse aliquid et sit provident qui consequuntur consectetur.", "https://i.picsum.photos/id/602/200/200.jpg?hmac=UQpVCHEMGI1-S-kt8OQLic6TfuG2elfLbLTNDl1mqZE", "Stephon Robel", 5, 2.0, 269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2022, 9, 14, 22, 23, 26, 1, DateTimeKind.Local).AddTicks(3749), "Quia similique nisi enim impedit laborum consequatur id aliquam expedita hic nemo tempore.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ms. Kevon Brown Veum", 7, 9.0, 259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "", new DateTime(2022, 9, 14, 22, 23, 26, 1, DateTimeKind.Local).AddTicks(6534), "Quam aut et quo dolor nemo commodi placeat eligendi minus vel repellat ut.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Betty Kerluke", 1, 13.0, 497, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "", new DateTime(2022, 9, 14, 22, 23, 26, 2, DateTimeKind.Local).AddTicks(831), "Corrupti veritatis sit ut dolore natus voluptatem debitis nulla dolore omnis quia eos itaque quos.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Vince Jacinto Hegmann", 7, 1.0, 191, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "", new DateTime(2022, 9, 14, 22, 23, 26, 2, DateTimeKind.Local).AddTicks(3841), "Ut dolorum harum voluptatem incidunt corrupti vero qui inventore deleniti dolores quae nobis suscipit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Skyla Koelpin", 6, 20.0, 278, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "", new DateTime(2022, 9, 14, 22, 23, 26, 2, DateTimeKind.Local).AddTicks(7865), "Illum maiores aut sed aut quia temporibus quod corporis repellendus illum neque.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Dr. Naomi Anastasia Deckow MD", 9, 3.0, 275, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "", new DateTime(2022, 9, 14, 22, 23, 26, 3, DateTimeKind.Local).AddTicks(1889), "Dolorem dolorem quisquam dolore iusto impedit eius repudiandae fugiat facere ratione.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Shayne Bernard McClure DDS", 3, 9.0, 235, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "", new DateTime(2022, 9, 14, 22, 23, 26, 3, DateTimeKind.Local).AddTicks(4411), "Omnis praesentium molestias eum numquam ab occaecati eos dolore sint.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ike Nitzsche", 3, 19.0, 375, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "", new DateTime(2022, 9, 14, 22, 23, 26, 3, DateTimeKind.Local).AddTicks(7378), "Repudiandae eligendi rerum dolorem omnis dolore omnis aut accusantium nihil delectus corrupti exercitationem voluptas.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Marion Rolfson", 10, 9.0, 422, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "", new DateTime(2022, 9, 14, 22, 23, 26, 4, DateTimeKind.Local).AddTicks(595), "Saepe dolorem quis enim voluptate et quidem sapiente magnam aliquid harum corrupti maiores eos eaque atque.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mr. Monique Lubowitz", 2, 17.0, 451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "", new DateTime(2022, 9, 14, 22, 23, 26, 4, DateTimeKind.Local).AddTicks(3376), "Sed omnis et aliquam expedita incidunt ipsum qui et amet quas error.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Wilfrid Ebert", 6, 5.0, 496, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "", new DateTime(2022, 9, 14, 22, 23, 26, 4, DateTimeKind.Local).AddTicks(6556), "Aut sit ad sequi et laudantium sequi eaque esse ab consequuntur iure et corporis odio.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Orval Lakin", 7, 5.0, 152, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "", new DateTime(2022, 9, 14, 22, 23, 26, 4, DateTimeKind.Local).AddTicks(9623), "Rerum velit qui in qui et molestiae deleniti quia suscipit autem magni non aliquam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Alexandre Hermiston", 3, 4.0, 432, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "", new DateTime(2022, 9, 14, 22, 23, 26, 5, DateTimeKind.Local).AddTicks(2333), "Vero accusamus ipsum aut tempora incidunt inventore iure asperiores numquam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Kian Dare", 4, 10.0, 263, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "", new DateTime(2022, 9, 14, 22, 23, 26, 5, DateTimeKind.Local).AddTicks(5323), "Sed temporibus dolore et ratione molestiae explicabo cupiditate quis id voluptatem provident totam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Bria Greenholt", 5, 17.0, 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "", new DateTime(2022, 9, 14, 22, 23, 26, 5, DateTimeKind.Local).AddTicks(8094), "Ut doloremque quisquam est sequi voluptas ut id voluptate corporis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Marianna Kuhn Jr.", 7, 12.0, 179, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "", new DateTime(2022, 9, 14, 22, 23, 26, 6, DateTimeKind.Local).AddTicks(849), "Et blanditiis voluptates qui deserunt quidem accusantium rem iure repellat.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Bethel Oberbrunner", 5, 19.0, 187, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "", new DateTime(2022, 9, 14, 22, 23, 26, 6, DateTimeKind.Local).AddTicks(3822), "Magni ut rerum dolorem inventore dolores officia voluptas consequatur rem nihil voluptatem.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Scarlett Lehner", 6, 10.0, 315, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "", new DateTime(2022, 9, 14, 22, 23, 26, 6, DateTimeKind.Local).AddTicks(8314), "Modi incidunt voluptas sequi esse dolor odit animi asperiores eius deserunt repellat consequatur id.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Miss Edythe Matteo Goyette", 6, 20.0, 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "", new DateTime(2022, 9, 14, 22, 23, 26, 7, DateTimeKind.Local).AddTicks(1374), "Et voluptatem corrupti dolorem illo quis reiciendis molestiae voluptatem expedita corporis omnis eum.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Cameron Rempel", 4, 4.0, 432, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "", new DateTime(2022, 9, 14, 22, 23, 26, 7, DateTimeKind.Local).AddTicks(4049), "Nesciunt sed dolore non enim rerum vel magni voluptas occaecati.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Kamille Fay", 9, 15.0, 234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "", new DateTime(2022, 9, 14, 22, 23, 26, 7, DateTimeKind.Local).AddTicks(6931), "Perferendis voluptas non id pariatur voluptate sed ratione cupiditate provident odio velit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Sherwood Bechtelar PhD", 3, 4.0, 161, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "", new DateTime(2022, 9, 14, 22, 23, 26, 8, DateTimeKind.Local).AddTicks(261), "Ducimus inventore tempora hic vel consectetur sed ea tenetur at repudiandae eum ea officiis rem omnis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Austyn Murray", 9, 18.0, 280, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "", new DateTime(2022, 9, 14, 22, 23, 26, 8, DateTimeKind.Local).AddTicks(4215), "Ipsa maiores expedita odit sunt voluptatem rerum possimus et officia.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Willie Eryn Mohr III", 6, 12.0, 183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "", new DateTime(2022, 9, 14, 22, 23, 26, 8, DateTimeKind.Local).AddTicks(6922), "Repudiandae consequuntur nostrum distinctio eveniet ipsa expedita explicabo iure aut quaerat.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Jake Mueller MD", 10, 16.0, 414, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "", new DateTime(2022, 9, 14, 22, 23, 26, 8, DateTimeKind.Local).AddTicks(9468), "Incidunt et soluta dolorem ipsam dolores aliquam distinctio magnam est.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Velva Hermann Jr.", 2, 8.0, 128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "", new DateTime(2022, 9, 14, 22, 23, 26, 9, DateTimeKind.Local).AddTicks(2327), "Vel est tenetur repellat natus ipsa nesciunt qui omnis quo recusandae ut ea et.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Arnulfo Mante III", 9, 10.0, 373, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "", new DateTime(2022, 9, 14, 22, 23, 26, 9, DateTimeKind.Local).AddTicks(5324), "Hic numquam reiciendis quasi voluptas assumenda neque laborum et praesentium quo non et exercitationem.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ms. Torey McGlynn III", 10, 3.0, 410, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "", new DateTime(2022, 9, 14, 22, 23, 26, 9, DateTimeKind.Local).AddTicks(8191), "Aut illo quam delectus consequatur dolor et et mollitia fuga porro aut voluptas nobis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Annalise Jewess", 6, 2.0, 395, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "", new DateTime(2022, 9, 14, 22, 23, 26, 10, DateTimeKind.Local).AddTicks(821), "Quis facilis hic occaecati excepturi dolor cumque dolorem voluptatibus blanditiis nulla.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Andres Funk MD", 3, 20.0, 112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "", new DateTime(2022, 9, 14, 22, 23, 26, 10, DateTimeKind.Local).AddTicks(4603), "Atque voluptatum ut quo libero dignissimos voluptas quibusdam incidunt reprehenderit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ms. Federico Arturo Robel III", 7, 3.0, 474, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "", new DateTime(2022, 9, 14, 22, 23, 26, 10, DateTimeKind.Local).AddTicks(7513), "Et dolorem est eos eos et eum maiores porro est et sunt et aut labore.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Abdullah Hilll", 1, 11.0, 381, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "", new DateTime(2022, 9, 14, 22, 23, 26, 11, DateTimeKind.Local).AddTicks(193), "Qui dicta accusantium qui molestias rerum sapiente alias id repellat sapiente facere.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Zena Koss", 5, 16.0, 318, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "", new DateTime(2022, 9, 14, 22, 23, 26, 11, DateTimeKind.Local).AddTicks(2905), "Nisi qui rem debitis rerum ipsum sunt debitis quisquam voluptates ut placeat.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Arvel Grimes PhD", 1, 11.0, 291, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "", new DateTime(2022, 9, 14, 22, 23, 26, 11, DateTimeKind.Local).AddTicks(7030), "A velit in quibusdam rerum doloribus laboriosam cupiditate perspiciatis officiis impedit ipsa earum.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Dessie Zack Schroeder PhD", 3, 13.0, 441, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "", new DateTime(2022, 9, 14, 22, 23, 26, 12, DateTimeKind.Local).AddTicks(1064), "Itaque ducimus iste architecto fugit iste placeat sint necessitatibus quae ad consequatur saepe.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ewell Orin Schultz DDS", 2, 10.0, 162, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "", new DateTime(2022, 9, 14, 22, 23, 26, 12, DateTimeKind.Local).AddTicks(4289), "Quo dolor quaerat nemo ullam dolore beatae sint et ratione qui est cumque illo eius voluptate.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Virginie Lynch", 6, 8.0, 255, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 9, 14, 22, 23, 25, 996, DateTimeKind.Local).AddTicks(3449), "Fugit odit omnis tenetur ex veniam neque ut mollitia ut aut voluptates.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 102, new DateTime(2022, 9, 14, 22, 23, 25, 996, DateTimeKind.Local).AddTicks(5140), "Molestiae quam deleniti et unde quia non perspiciatis sed nulla maxime.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 103, new DateTime(2022, 9, 14, 22, 23, 25, 996, DateTimeKind.Local).AddTicks(6765), "Odio sapiente dolor dicta doloremque et dolor quae voluptatem magni ut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 104, new DateTime(2022, 9, 14, 22, 23, 25, 996, DateTimeKind.Local).AddTicks(8765), "Vero voluptatem id doloribus sit dolor odio molestias sunt laudantium consequatur quibusdam a iste.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 105, new DateTime(2022, 9, 14, 22, 23, 25, 997, DateTimeKind.Local).AddTicks(264), "Soluta et nam iusto corrupti illo facilis est odit reprehenderit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 106, new DateTime(2022, 9, 14, 22, 23, 25, 997, DateTimeKind.Local).AddTicks(1843), "Laboriosam sunt pariatur enim rerum dolor fuga voluptas sed fugit provident.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 107, new DateTime(2022, 9, 14, 22, 23, 25, 997, DateTimeKind.Local).AddTicks(3298), "Quia explicabo qui et nobis repudiandae ut dolor consequatur reiciendis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 109, new DateTime(2022, 9, 14, 22, 23, 25, 997, DateTimeKind.Local).AddTicks(5608), "Exercitationem qui quia repellat dolorum qui veritatis et nulla tempore aut corrupti totam id itaque quis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 110, new DateTime(2022, 9, 14, 22, 23, 25, 997, DateTimeKind.Local).AddTicks(7893), "Voluptas tempora unde dicta quod cum et exercitationem laborum et totam ipsam ipsa hic et aut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 201, new DateTime(2022, 9, 14, 22, 23, 25, 998, DateTimeKind.Local).AddTicks(53), "Iure neque eum ea ut voluptatem assumenda molestiae dicta inventore tempora dignissimos ipsam nam architecto.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 202, new DateTime(2022, 9, 14, 22, 23, 25, 998, DateTimeKind.Local).AddTicks(1947), "Tempore amet deleniti consectetur reiciendis assumenda ex adipisci autem unde et sunt aliquid.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 203, new DateTime(2022, 9, 14, 22, 23, 25, 998, DateTimeKind.Local).AddTicks(3940), "Aliquam est illum dolorem sed provident exercitationem rerum odit ipsam distinctio dolorem et in.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 204, new DateTime(2022, 9, 14, 22, 23, 25, 998, DateTimeKind.Local).AddTicks(5687), "Autem et dolorem non et autem eum accusamus earum fuga eaque quam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 205, new DateTime(2022, 9, 14, 22, 23, 25, 998, DateTimeKind.Local).AddTicks(7371), "Occaecati adipisci libero deleniti voluptatum praesentium exercitationem doloribus veritatis omnis sunt accusamus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 206, new DateTime(2022, 9, 14, 22, 23, 25, 998, DateTimeKind.Local).AddTicks(9536), "Expedita aspernatur nulla alias labore nulla corrupti optio voluptatem debitis ipsum accusamus dolor dignissimos vero.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 207, new DateTime(2022, 9, 14, 22, 23, 25, 999, DateTimeKind.Local).AddTicks(1525), "Et ea nihil accusantium rem quidem dolorum quis a id sunt voluptatem vitae qui consectetur velit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 208, new DateTime(2022, 9, 14, 22, 23, 25, 999, DateTimeKind.Local).AddTicks(3531), "Magnam ipsa nihil voluptatibus assumenda et nulla incidunt labore id eligendi consequatur omnis dicta asperiores exercitationem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 209, new DateTime(2022, 9, 14, 22, 23, 25, 999, DateTimeKind.Local).AddTicks(5559), "Excepturi tempora dolores eligendi qui hic ut omnis maiores reiciendis quo est aliquid.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 210, new DateTime(2022, 9, 14, 22, 23, 25, 999, DateTimeKind.Local).AddTicks(6634), "Et cumque ex consequatur iusto corrupti voluptas ullam quibusdam dolores vel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
