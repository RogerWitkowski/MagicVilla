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
                    { 1, "Et nobis in perspiciatis modi qui commodi saepe quo accusamus et sequi voluptatem voluptatem eos deleniti.", new DateTime(2022, 9, 17, 16, 16, 1, 811, DateTimeKind.Local).AddTicks(1370), "Eum voluptatibus cupiditate et debitis qui voluptates aut ipsum ut deserunt tempora tempora officia quisquam.", "https://i.picsum.photos/id/778/200/200.jpg?hmac=fgFK_HI_g_N4MzYuYbssOB8ymhT_m0JK61tNJHfdPYU", "Alyce Hickle", 7, 15.0, 269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Corporis nisi eligendi laboriosam in facere consequuntur rem eius et omnis fuga ipsum consequatur.", new DateTime(2022, 9, 17, 16, 16, 1, 811, DateTimeKind.Local).AddTicks(5251), "Vero nihil commodi recusandae voluptatibus molestiae provident omnis natus accusantium.", "https://i.picsum.photos/id/287/200/200.jpg?hmac=kXFCSMZE2rF7NM-EFSH6c_nl5HlKQWvwCdE8JYL-YNQ", "Shea Osinski", 6, 11.0, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Et nisi vitae sed est aperiam velit eveniet sequi pariatur provident vel.", new DateTime(2022, 9, 17, 16, 16, 1, 811, DateTimeKind.Local).AddTicks(8888), "Architecto dolores beatae ut enim et dolorum et corporis atque explicabo.", "https://i.picsum.photos/id/446/200/200.jpg?hmac=PkaLcCtgL4IvAz-gsxbCXz_tl0qdVUGOrxhYLrywa-c", "Luz Keebler", 6, 2.0, 330, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Officia impedit sapiente esse molestias odio ut ratione perspiciatis voluptatem voluptatem est tempore natus.", new DateTime(2022, 9, 17, 16, 16, 1, 812, DateTimeKind.Local).AddTicks(5179), "Est consequatur dicta voluptas explicabo accusamus tempore consequuntur est velit vel ex maiores dolorem expedita.", "https://i.picsum.photos/id/602/200/200.jpg?hmac=UQpVCHEMGI1-S-kt8OQLic6TfuG2elfLbLTNDl1mqZE", "Einar Deon Ernser V", 2, 7.0, 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Culpa omnis nihil blanditiis itaque ut est voluptates inventore possimus labore voluptate et est voluptas.", new DateTime(2022, 9, 17, 16, 16, 1, 812, DateTimeKind.Local).AddTicks(9411), "Et ad optio atque ea aut vitae molestias cum placeat commodi hic consectetur doloremque.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Dr. Danny Wiegand", 6, 12.0, 134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Odit voluptatum ratione qui doloremque nam voluptatem quidem velit soluta.", new DateTime(2022, 9, 17, 16, 16, 1, 813, DateTimeKind.Local).AddTicks(2815), "Dicta doloremque laborum recusandae excepturi atque voluptatem totam aspernatur aperiam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Gay Rau", 10, 14.0, 226, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Non voluptate aut qui optio velit et non hic autem molestiae amet aliquid a.", new DateTime(2022, 9, 17, 16, 16, 1, 813, DateTimeKind.Local).AddTicks(6617), "In qui pariatur consectetur blanditiis adipisci nemo dolores laborum quasi consectetur.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Pansy Beier", 9, 15.0, 456, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Recusandae nostrum aut voluptas vitae magni eos ab sequi doloribus perspiciatis nostrum quam reprehenderit.", new DateTime(2022, 9, 17, 16, 16, 1, 814, DateTimeKind.Local).AddTicks(1981), "Id voluptatum quo saepe eos consequatur reiciendis nisi quisquam et debitis ut quo.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mrs. Cyril Kennedi Cummings", 2, 4.0, 422, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Odio voluptatibus mollitia accusamus voluptatem dolores velit iure qui aut.", new DateTime(2022, 9, 17, 16, 16, 1, 814, DateTimeKind.Local).AddTicks(6936), "Est nam ut reprehenderit magni rerum odit soluta delectus ad voluptate sed est itaque molestiae sit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Garett Quitzon", 10, 14.0, 486, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Atque animi consequuntur illo recusandae sit sint iure eos quis deleniti error iusto debitis ut.", new DateTime(2022, 9, 17, 16, 16, 1, 815, DateTimeKind.Local).AddTicks(1141), "Doloribus voluptatem aut nam sint iste officia et repudiandae dolorem dolores repellendus ex.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Erna Friesen", 6, 20.0, 267, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Sunt tenetur fuga in quam similique sint cupiditate voluptates quaerat distinctio similique.", new DateTime(2022, 9, 17, 16, 16, 1, 815, DateTimeKind.Local).AddTicks(5280), "Beatae aspernatur aut tempora id eum dolor delectus velit et distinctio perspiciatis sed eius quia.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Leann Robel", 10, 6.0, 315, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Assumenda aut et qui ut corporis adipisci aut vero qui ut blanditiis dolore.", new DateTime(2022, 9, 17, 16, 16, 1, 815, DateTimeKind.Local).AddTicks(9183), "Totam placeat exercitationem facere repellendus non totam deleniti suscipit ratione consequuntur aliquam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Stephanie Rempel", 2, 18.0, 290, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Quo rerum eos minus totam est eius odit expedita vero laboriosam enim esse est omnis magnam.", new DateTime(2022, 9, 17, 16, 16, 1, 816, DateTimeKind.Local).AddTicks(3567), "Dolore tenetur cupiditate delectus non itaque consequuntur ut nulla eum suscipit ipsa ea deserunt.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Rodger Hermiston", 9, 7.0, 311, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Consequatur rerum sunt magni et nulla nisi necessitatibus soluta nostrum dolorem occaecati quibusdam aliquam.", new DateTime(2022, 9, 17, 16, 16, 1, 816, DateTimeKind.Local).AddTicks(7663), "Voluptatum reiciendis corrupti qui ipsam amet sint sit blanditiis omnis laboriosam doloremque blanditiis.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Wiley Donnelly", 1, 11.0, 395, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Impedit non quasi eos minus quia magni quibusdam fuga adipisci et iusto.", new DateTime(2022, 9, 17, 16, 16, 1, 817, DateTimeKind.Local).AddTicks(2673), "Quas cumque qui voluptatem molestiae sit corrupti voluptatem consectetur reprehenderit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Dr. Eloise Miracle Waters", 9, 16.0, 288, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Ipsam rerum nulla neque vel repellendus aut illum harum dolores quis esse sed.", new DateTime(2022, 9, 17, 16, 16, 1, 817, DateTimeKind.Local).AddTicks(6800), "Et consequuntur est est sed minima consequuntur alias quod minus cum sed eveniet quo ad.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Felipe Kautzer", 9, 8.0, 134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Magni tempore officia placeat autem earum enim sequi aut omnis et sapiente voluptatem.", new DateTime(2022, 9, 17, 16, 16, 1, 818, DateTimeKind.Local).AddTicks(718), "Omnis nemo architecto id tempore et ullam reprehenderit autem minus vitae quaerat.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Terrence Barrows", 6, 14.0, 209, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Doloribus magni nesciunt omnis explicabo veritatis beatae distinctio culpa numquam.", new DateTime(2022, 9, 17, 16, 16, 1, 818, DateTimeKind.Local).AddTicks(6017), "Ut autem non ut fuga occaecati qui laborum perspiciatis cumque natus eveniet unde ea est dolorum.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Eunice Liliane Klocko II", 8, 16.0, 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Ut est minima quod velit cumque laborum soluta ut placeat commodi delectus sint eaque.", new DateTime(2022, 9, 17, 16, 16, 1, 818, DateTimeKind.Local).AddTicks(9816), "Quia qui pariatur incidunt et ipsum sit dolorum voluptas vel.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Kieran Kris", 9, 4.0, 367, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Reiciendis libero pariatur qui cumque dolorum sed ea qui error consequatur.", new DateTime(2022, 9, 17, 16, 16, 1, 819, DateTimeKind.Local).AddTicks(3915), "Consectetur porro ut architecto animi expedita id est consequatur rerum id qui possimus voluptatem nam at.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Miss Ava Toy DDS", 8, 4.0, 482, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Delectus debitis harum cupiditate vitae error magni corporis ut eum quasi dignissimos nam deserunt.", new DateTime(2022, 9, 17, 16, 16, 1, 819, DateTimeKind.Local).AddTicks(7737), "Fuga dolores dolores iure non recusandae ullam cumque vitae numquam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Chet Pollich", 4, 18.0, 267, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Sapiente molestias ex alias earum ea sit et fuga qui quos eos.", new DateTime(2022, 9, 17, 16, 16, 1, 820, DateTimeKind.Local).AddTicks(1594), "Eum voluptatem repellendus repellendus nisi soluta nihil et molestias fugiat alias sed architecto.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Magdalena Cummerata", 7, 4.0, 343, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Repellat laboriosam molestiae rerum nobis occaecati culpa veritatis a labore sunt quia consequatur dicta in.", new DateTime(2022, 9, 17, 16, 16, 1, 820, DateTimeKind.Local).AddTicks(7117), "Inventore nesciunt et necessitatibus cumque libero saepe eum quos aut commodi suscipit ut.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mrs. Shanelle Otha Christiansen II", 8, 1.0, 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Quis voluptates tempore dolores aut quae dolores eos praesentium doloremque laborum.", new DateTime(2022, 9, 17, 16, 16, 1, 821, DateTimeKind.Local).AddTicks(780), "Qui corporis magni in explicabo voluptatem et omnis eum eos accusantium.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Ms. Judah Smitham IV", 6, 20.0, 213, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Eligendi suscipit eius aliquam aliquam quia et veniam quis et tenetur sunt.", new DateTime(2022, 9, 17, 16, 16, 1, 821, DateTimeKind.Local).AddTicks(5776), "Magni fugiat a et magni natus cupiditate consectetur voluptatem sit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Twila Greg Goodwin V", 5, 20.0, 171, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Eum rerum eligendi voluptas rerum nemo exercitationem sit odio laboriosam aliquam qui harum porro soluta similique.", new DateTime(2022, 9, 17, 16, 16, 1, 822, DateTimeKind.Local).AddTicks(149), "Voluptas asperiores culpa ex repellat eaque doloremque neque veritatis corporis sed natus voluptatibus fugiat.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Emmie Cummings", 1, 9.0, 299, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Fugit modi dolorem ex laudantium architecto modi voluptatem ex illum consequatur officiis facere.", new DateTime(2022, 9, 17, 16, 16, 1, 822, DateTimeKind.Local).AddTicks(5295), "Est minima est vitae maxime in eos ullam omnis deserunt ex.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Prof. Timmy Monserrat Lebsack PhD", 7, 8.0, 395, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Quas facilis cum et debitis voluptatem itaque labore natus fuga ut.", new DateTime(2022, 9, 17, 16, 16, 1, 825, DateTimeKind.Local).AddTicks(9917), "Sit vitae dolores qui placeat voluptatum quia esse natus et consequatur.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Devon Rosalind Rutherford II", 10, 12.0, 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Quia totam non voluptates officiis id facilis quia iure aut.", new DateTime(2022, 9, 17, 16, 16, 1, 826, DateTimeKind.Local).AddTicks(2082), "Excepturi rerum illo quisquam maiores velit accusantium quia sed consequatur provident ut.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Antonetta Weissnat", 9, 6.0, 435, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Dolores occaecati non laboriosam et dolores ea quo laudantium dolorem expedita esse dolorem non ipsum.", new DateTime(2022, 9, 17, 16, 16, 1, 826, DateTimeKind.Local).AddTicks(4610), "Amet quo quia laboriosam molestias est et est pariatur reprehenderit qui doloremque eum voluptatem ut.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Sydnie Waters", 10, 10.0, 447, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Quas aliquid minima suscipit quo velit officiis magni cum veritatis consequuntur molestias.", new DateTime(2022, 9, 17, 16, 16, 1, 826, DateTimeKind.Local).AddTicks(6836), "Praesentium magni incidunt est exercitationem velit maiores repellat omnis enim quia incidunt.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Helene Fadel PhD", 1, 5.0, 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Dolor sequi voluptates dolorum nihil deserunt et libero est quia ab et tempore et modi.", new DateTime(2022, 9, 17, 16, 16, 1, 826, DateTimeKind.Local).AddTicks(9464), "Rerum et et qui ex dicta ab facere tempore est perspiciatis dolores qui magni dolor magnam.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mr. Gordon Moen", 5, 18.0, 293, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Veritatis at veniam voluptatem mollitia omnis autem occaecati molestiae nisi impedit voluptatem quo.", new DateTime(2022, 9, 17, 16, 16, 1, 827, DateTimeKind.Local).AddTicks(1868), "Asperiores porro natus voluptatibus enim aliquam corrupti facere hic in iste eos quos quas quaerat.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Michale Nader", 2, 12.0, 111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Eveniet ut voluptatem qui architecto assumenda voluptas animi est unde quod.", new DateTime(2022, 9, 17, 16, 16, 1, 827, DateTimeKind.Local).AddTicks(4284), "Iusto repellat vero aut voluptatem voluptatem ratione rerum qui delectus debitis ratione tempora est cumque modi.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Milo Wolf", 2, 14.0, 463, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Modi adipisci deserunt enim neque voluptates sint unde corrupti ea ducimus sint rem enim.", new DateTime(2022, 9, 17, 16, 16, 1, 827, DateTimeKind.Local).AddTicks(7312), "Numquam qui a veniam at ut veritatis iste sed inventore deleniti.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Bethel Hipolito Hand Jr.", 5, 11.0, 348, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Qui odit vel qui laborum soluta rerum nostrum molestias molestias et eius maiores nemo.", new DateTime(2022, 9, 17, 16, 16, 1, 827, DateTimeKind.Local).AddTicks(9858), "Sunt saepe quidem ipsum illum voluptatem sit architecto tempora corporis voluptatem praesentium odio pariatur eos sit.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Green Gutmann", 6, 8.0, 433, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Ratione quidem earum et aut quod modi cupiditate error minima fuga qui.", new DateTime(2022, 9, 17, 16, 16, 1, 828, DateTimeKind.Local).AddTicks(2940), "Omnis quaerat a architecto eum sunt vitae nisi id sequi non aut minus dolorum.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Jensen Candace Witting IV", 10, 1.0, 143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Fuga sunt enim ipsum iure ex expedita quisquam veniam ut repellat velit.", new DateTime(2022, 9, 17, 16, 16, 1, 828, DateTimeKind.Local).AddTicks(5195), "Eos hic quia voluptatem nemo molestiae inventore molestiae aperiam delectus qui velit consequatur.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Bernie Kerluke", 2, 3.0, 315, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Architecto omnis dolor inventore quis quam porro in similique sit velit laboriosam aperiam recusandae sit.", new DateTime(2022, 9, 17, 16, 16, 1, 828, DateTimeKind.Local).AddTicks(8262), "Esse sed ab quisquam quia ut amet et ipsa voluptatibus.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mr. Joy Evie Swift", 10, 18.0, 314, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Et dolor dolor est voluptatem quasi nesciunt accusantium rerum occaecati tempore et aut tempore dicta consequatur.", new DateTime(2022, 9, 17, 16, 16, 1, 829, DateTimeKind.Local).AddTicks(1501), "Dolor nesciunt est nemo odit quaerat aut excepturi quo quaerat dolore omnis voluptatem.", "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE", "Mrs. Gerda Trycia Trantow DDS", 2, 1.0, 244, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(665), "Pariatur voluptates dignissimos quia non et veniam officia necessitatibus distinctio.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 102, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(1995), "Sit cum ullam dolor laborum debitis itaque necessitatibus atque soluta magni sed excepturi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 103, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(3478), "Expedita corrupti sed et sequi nam quidem expedita ut rerum velit id atque in error.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 104, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(4945), "Placeat quod et enim eaque aut tenetur eaque quia ad qui quo tempore et.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 105, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(5951), "Voluptas libero unde placeat nulla quas numquam rerum incidunt eos.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 106, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(7051), "Quis in sapiente voluptatem rerum sapiente rerum vel alias voluptatum odit dolor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 107, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(8175), "Est aspernatur eius amet non reprehenderit laudantium animi error vel ut ratione.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 109, new DateTime(2022, 9, 17, 16, 16, 1, 808, DateTimeKind.Local).AddTicks(9102), "Consectetur esse aspernatur fugit cumque dolore qui et est rerum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 110, new DateTime(2022, 9, 17, 16, 16, 1, 809, DateTimeKind.Local).AddTicks(413), "Impedit maiores sit numquam et qui corporis ducimus alias cum occaecati et voluptas.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 201, new DateTime(2022, 9, 17, 16, 16, 1, 809, DateTimeKind.Local).AddTicks(1897), "Error molestiae aliquam reiciendis et ullam mollitia sit eos et voluptas iure.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 202, new DateTime(2022, 9, 17, 16, 16, 1, 809, DateTimeKind.Local).AddTicks(3747), "Numquam praesentium cum ut possimus excepturi at repudiandae ea quibusdam necessitatibus porro nihil hic.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 203, new DateTime(2022, 9, 17, 16, 16, 1, 809, DateTimeKind.Local).AddTicks(5540), "Animi nesciunt aut eum omnis earum eos eius corporis inventore quibusdam est quod aut ab illum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 204, new DateTime(2022, 9, 17, 16, 16, 1, 809, DateTimeKind.Local).AddTicks(7431), "Itaque et aut provident dolores iusto enim in qui incidunt itaque ullam doloremque eum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 205, new DateTime(2022, 9, 17, 16, 16, 1, 809, DateTimeKind.Local).AddTicks(8884), "Maiores iste eligendi accusantium consequuntur error et non sequi veniam deleniti.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 206, new DateTime(2022, 9, 17, 16, 16, 1, 810, DateTimeKind.Local).AddTicks(918), "Culpa aut et eius cumque aperiam nihil dolore exercitationem aut id aspernatur odit autem minus eligendi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 207, new DateTime(2022, 9, 17, 16, 16, 1, 810, DateTimeKind.Local).AddTicks(2562), "Voluptatibus qui quod atque ipsum itaque id rerum quaerat adipisci qui sint voluptatem inventore et.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 208, new DateTime(2022, 9, 17, 16, 16, 1, 810, DateTimeKind.Local).AddTicks(4067), "Sint odit incidunt error laboriosam tenetur odit accusamus pariatur qui qui assumenda aut quo maxime qui.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 209, new DateTime(2022, 9, 17, 16, 16, 1, 810, DateTimeKind.Local).AddTicks(5033), "Saepe necessitatibus sunt numquam harum eum ut nihil eaque eos.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 210, new DateTime(2022, 9, 17, 16, 16, 1, 810, DateTimeKind.Local).AddTicks(6536), "Iure libero sint saepe voluptatum mollitia veritatis sit et est et velit sapiente aperiam earum quia.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
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
