using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 812, DateTimeKind.Local).AddTicks(944), "Placeat rerum deserunt est voluptas similique soluta odio consequatur et placeat." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 812, DateTimeKind.Local).AddTicks(2484), "Pariatur quis aut repellendus eum suscipit quis ad blanditiis accusamus amet ipsam corporis dolores labore quos." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 812, DateTimeKind.Local).AddTicks(3770), "Aut et dignissimos quidem qui sunt assumenda consequuntur explicabo velit repellendus error sed." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 812, DateTimeKind.Local).AddTicks(4729), "Rerum sapiente est fugit provident nostrum laboriosam occaecati sit praesentium." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 105,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 812, DateTimeKind.Local).AddTicks(5689), "Itaque occaecati earum accusantium nesciunt eum illum vel maiores expedita." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 106,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 812, DateTimeKind.Local).AddTicks(7107), "Ducimus sunt in ipsam quia et sed quo incidunt omnis explicabo saepe quidem qui sint." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 107,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 812, DateTimeKind.Local).AddTicks(8500), "Aut fuga dolorem blanditiis eligendi vel quam qui aperiam in officia non minus impedit voluptatem." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 109,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 813, DateTimeKind.Local).AddTicks(1176), "Consectetur doloribus eligendi et ut aliquam voluptates unde rerum quia quam temporibus ut rerum velit est." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 110,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 813, DateTimeKind.Local).AddTicks(2535), "Sed atque praesentium qui repellendus qui est velit voluptatem eos cum enim ut." });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 201, new DateTime(2022, 9, 11, 15, 56, 34, 813, DateTimeKind.Local).AddTicks(3719), "Omnis est aut a minima quae aut voluptatem debitis non error odio.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 202, new DateTime(2022, 9, 11, 15, 56, 34, 813, DateTimeKind.Local).AddTicks(4874), "Recusandae molestiae ea possimus illum est commodi nam perspiciatis beatae sequi quod.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 203, new DateTime(2022, 9, 11, 15, 56, 34, 813, DateTimeKind.Local).AddTicks(6276), "Eaque ut quod nesciunt aut voluptatem et distinctio quasi incidunt minus facilis quos voluptas mollitia.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 204, new DateTime(2022, 9, 11, 15, 56, 34, 813, DateTimeKind.Local).AddTicks(7637), "Illum quia saepe excepturi aut et id dolores aperiam error quas sit dolor commodi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 205, new DateTime(2022, 9, 11, 15, 56, 34, 813, DateTimeKind.Local).AddTicks(9086), "Eum explicabo rem ea tenetur qui possimus vitae sunt non voluptatibus esse corporis aut exercitationem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 206, new DateTime(2022, 9, 11, 15, 56, 34, 814, DateTimeKind.Local).AddTicks(187), "Voluptas rerum nam nemo aut repellat illum in molestias exercitationem consequatur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 207, new DateTime(2022, 9, 11, 15, 56, 34, 814, DateTimeKind.Local).AddTicks(1629), "Quisquam porro aut explicabo soluta similique accusamus consequatur sed iste porro eaque facilis doloremque aperiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 208, new DateTime(2022, 9, 11, 15, 56, 34, 814, DateTimeKind.Local).AddTicks(3226), "Facilis asperiores est rerum quod ut et provident eius commodi ut necessitatibus reiciendis voluptas dolorem officia.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 209, new DateTime(2022, 9, 11, 15, 56, 34, 814, DateTimeKind.Local).AddTicks(4175), "Corporis amet consequatur autem rem in sapiente sed officia inventore.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 210, new DateTime(2022, 9, 11, 15, 56, 34, 814, DateTimeKind.Local).AddTicks(5232), "Dolorem velit ab blanditiis libero earum qui sunt mollitia nisi aut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 814, DateTimeKind.Local).AddTicks(8544), "Consequatur quidem consectetur praesentium ullam voluptatem distinctio cupiditate sit dolor quia sunt deserunt ea.", "Nicolas Schuppe", 3, 14.0, 431 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 815, DateTimeKind.Local).AddTicks(1060), "Ipsam voluptatum suscipit voluptates quos iusto sint qui vel tempora.", "Maurice Russel", 4, 11.0, 308 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 815, DateTimeKind.Local).AddTicks(3939), "Quas non tempora molestiae officiis aut velit et natus blanditiis sed vitae ut.", "Candido Mraz", 7, 12.0, 386 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 815, DateTimeKind.Local).AddTicks(6970), "Dolorem aliquam corrupti autem aut in non molestiae nihil labore consequatur qui ipsum ullam veritatis.", "Oma Wilderman", 3, 401 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 815, DateTimeKind.Local).AddTicks(9562), "Quos occaecati aut sapiente quia laudantium quas non incidunt aliquam sequi.", "Junius Blick", 4, 5.0, 146 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 816, DateTimeKind.Local).AddTicks(2073), "Accusamus architecto nostrum provident ea in occaecati quod possimus sed.", "Dorris McKenzie", 3, 7.0, 434 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 816, DateTimeKind.Local).AddTicks(4919), "Dolorem nostrum ipsa deleniti sit voluptas blanditiis sapiente quia neque tenetur enim eligendi.", "Foster Auer V", 10, 2.0, 323 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 816, DateTimeKind.Local).AddTicks(7541), "Quis a perspiciatis ab quos deleniti quibusdam amet fugiat et reiciendis.", "Mr. Joelle Murphy", 6, 16.0, 185 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 817, DateTimeKind.Local).AddTicks(1910), "Vel maiores sequi quo quod quasi nesciunt quo ut maxime voluptatem voluptas veritatis dicta maxime porro.", "Dr. Guiseppe Raina Schaefer", 7, 2.0, 180 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 817, DateTimeKind.Local).AddTicks(4415), "Reiciendis sunt aperiam et perspiciatis nesciunt quisquam voluptatem asperiores eligendi.", "Lourdes Barrows", 8, 15.0, 400 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 817, DateTimeKind.Local).AddTicks(7138), "Ducimus tempore asperiores non occaecati et quam perspiciatis repellat autem inventore tempore eaque.", "Jarrell Bogisich", 10, 10.0, 458 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 818, DateTimeKind.Local).AddTicks(102), "Asperiores sed vitae modi qui sed voluptatem omnis cupiditate voluptatem neque molestiae autem voluptates tempore.", "Hailey Hayes", 3, 14.0, 296 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 818, DateTimeKind.Local).AddTicks(3242), "Voluptatum dolorum explicabo omnis inventore nam eos est sed ab rem aut harum eos odio nesciunt.", "Shanel Nienow IV", 18.0, 137 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 818, DateTimeKind.Local).AddTicks(7325), "Velit odit sunt numquam accusantium nihil voluptas sunt officiis inventore adipisci alias et.", "Pearline Friedrich Hyatt Jr.", 10, 13.0, 126 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 819, DateTimeKind.Local).AddTicks(286), "Modi occaecati perferendis iste velit ratione et at qui ut soluta odit autem sunt et.", "Mariah Rogahn", 4, 14.0, 205 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 819, DateTimeKind.Local).AddTicks(3424), "Totam ex nobis qui harum consequuntur ad et ullam et amet et minima omnis atque sunt.", "Samanta Auer", 8, 2.0, 286 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 819, DateTimeKind.Local).AddTicks(6115), "Aut possimus dignissimos in et ab cum doloribus dolores tempora aut laborum.", "Jessica Streich", 3, 4.0, 316 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 819, DateTimeKind.Local).AddTicks(8826), "Eveniet ipsa quos voluptatem et voluptatem architecto corporis neque nulla dolore ea similique.", "Deshaun Berge III", 1, 7.0, 110 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 820, DateTimeKind.Local).AddTicks(1740), "Tempore enim ea voluptatum non quaerat consequatur neque fugiat ut nostrum unde rerum.", "Ms. Elta Mann", 8, 19.0, 279 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 820, DateTimeKind.Local).AddTicks(5864), "Porro similique aperiam reiciendis qui nesciunt recusandae quia in velit quae et veniam.", "Dr. Kamren Hildegard West III", 7, 16.0, 492 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 820, DateTimeKind.Local).AddTicks(9855), "Officia quasi laudantium laboriosam porro id rem ut eveniet vitae cupiditate.", "Bryana Flo Frami Jr.", 9, 13.0, 209 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 821, DateTimeKind.Local).AddTicks(2531), "Quis qui voluptatem voluptatem id delectus consequuntur aut optio excepturi voluptas.", "Stone Metz", 1, 5.0, 156 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Details", "Name", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 821, DateTimeKind.Local).AddTicks(5377), "Ipsa nihil hic qui voluptatibus voluptas ut voluptatum explicabo dolores rerum sed similique.", "Nyah Kunde", 167 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 821, DateTimeKind.Local).AddTicks(8622), "Sequi ea voluptates ut provident optio ut velit porro excepturi aperiam quia natus nemo.", "Sonya Rempel", 2.0, 222 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 822, DateTimeKind.Local).AddTicks(1753), "Eaque voluptatum accusantium libero unde nihil eius repellat maiores magni possimus et iste aliquam aut.", "Dr. Anika Wiegand", 4, 220 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 822, DateTimeKind.Local).AddTicks(4656), "Neque consequatur non corporis ut alias facere tempore quisquam dolore sed.", "Sydnee Hauck", 8, 1.0, 226 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 822, DateTimeKind.Local).AddTicks(7393), "Amet corrupti totam dolores eligendi voluptatem et fugit quo quo.", "Jessyca Will", 2, 8.0, 295 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 823, DateTimeKind.Local).AddTicks(66), "Deleniti et quae veritatis et placeat corporis illum similique qui.", "Dr. Oscar Kuhn PhD", 5, 16.0, 169 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 823, DateTimeKind.Local).AddTicks(2712), "Dolorem et sequi recusandae eligendi cupiditate quibusdam ea sapiente voluptatem aut.", "Jerome Shields", 1, 8.0, 333 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 823, DateTimeKind.Local).AddTicks(5882), "Modi totam qui cum sunt et est itaque magni enim illum sint quis aliquam.", "Ora Hansen", 6, 5.0, 363 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 823, DateTimeKind.Local).AddTicks(8742), "Nemo hic numquam aut reiciendis minima quo ea qui error dolores laboriosam veritatis.", "Dr. Earnestine Bednar", 4, 8.0, 158 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 824, DateTimeKind.Local).AddTicks(1981), "Qui autem suscipit harum natus sunt consequatur non sunt saepe ipsam architecto sed enim sit.", "Jedediah Homenick", 5, 19.0, 190 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 824, DateTimeKind.Local).AddTicks(4887), "Est necessitatibus porro officia inventore cum nihil numquam asperiores dolor veritatis nam.", "Buford Cronin", 4, 15.0, 401 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 824, DateTimeKind.Local).AddTicks(7637), "Voluptates ipsam debitis est quas repudiandae sint sit dolor aut ex.", "Mr. Stanton Swaniawski", 9, 8.0, 436 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 825, DateTimeKind.Local).AddTicks(728), "Accusamus et maiores et consectetur consequatur mollitia quasi quae consequatur culpa quis ipsa dolorem ipsam nisi.", "Ken Hahn DDS", 2, 14.0, 341 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 825, DateTimeKind.Local).AddTicks(3286), "Aliquam aliquam est architecto eum sunt labore quo ipsa placeat velit.", "Prof. Reva Rippin Jr.", 10, 408 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 825, DateTimeKind.Local).AddTicks(5884), "Perspiciatis et eaque et fugiat maiores cupiditate totam iure nihil libero.", "Gladyce Murazik", 1, 14.0, 450 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 825, DateTimeKind.Local).AddTicks(8856), "Dicta fuga laboriosam molestiae maxime ratione sapiente omnis esse soluta officia illo fugiat dolorum assumenda.", "Lora Koepp", 7, 6.0, 483 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 826, DateTimeKind.Local).AddTicks(1563), "Aliquid eius ducimus atque inventore provident quia fugiat corporis architecto odit rerum.", "Miss Bud Stokes DDS", 2, 1.0, 190 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 56, 34, 826, DateTimeKind.Local).AddTicks(4382), "Ut sed aut rerum fugiat iusto eum at unde error totam qui autem perferendis.", "Otis Padberg IV", 6, 17.0, 430 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 210);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 584, DateTimeKind.Local).AddTicks(7289), "Maiores autem in tempore veritatis eveniet sapiente dignissimos consequatur corrupti laudantium laboriosam repellendus." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 584, DateTimeKind.Local).AddTicks(8554), "Tenetur ipsam suscipit consectetur aut quibusdam cumque aut atque sed et accusantium." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 584, DateTimeKind.Local).AddTicks(9503), "Et reiciendis accusamus placeat atque odit laboriosam velit est saepe." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(1018), "Quae consectetur sunt fugiat vel voluptas et incidunt qui non aspernatur labore eos et dolorem at." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 105,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(2142), "Magnam et et ab ad porro omnis maxime commodi doloribus nihil a." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 106,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(3223), "Sequi quisquam totam voluptas neque et quia alias enim aut non." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 107,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(4311), "Quis omnis voluptas molestiae accusantium ex vitae doloribus ratione sit ut." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 109,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(5743), "Aut deleniti non labore eligendi voluptas repellendus delectus ut ut voluptatem fugiat qui aut tenetur." });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 110,
                columns: new[] { "CreatedDate", "SpecialDetails" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(6771), "Dolore placeat animi praesentium sint est et dolores laudantium soluta aliquam." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 585, DateTimeKind.Local).AddTicks(9864), "Sequi sint commodi est qui veritatis maxime odio porro voluptatibus magni quia vel.", "Alec Schulist", 9, 3.0, 328 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 586, DateTimeKind.Local).AddTicks(2348), "Neque ipsum maxime cumque iusto recusandae pariatur qui ea cupiditate.", "Herman Wehner", 8, 10.0, 430 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 586, DateTimeKind.Local).AddTicks(4857), "Accusamus sed laudantium ullam enim aperiam in aspernatur sequi aliquam.", "Alvera Wilderman", 8, 2.0, 130 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 586, DateTimeKind.Local).AddTicks(8764), "Repellendus modi sunt voluptatem omnis et ipsa officiis dolor qui molestias earum.", "Alejandrin Bailey Walsh II", 9, 421 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 587, DateTimeKind.Local).AddTicks(1647), "Perspiciatis tempore error illum non repellat eligendi sit molestias quo officia velit unde dolore.", "Jimmy Schowalter", 8, 12.0, 410 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 587, DateTimeKind.Local).AddTicks(5601), "Unde amet necessitatibus voluptate qui voluptatibus nulla sint est laborum voluptatum aliquam voluptatem ullam hic id.", "Ashlee Heller Sr.", 7, 11.0, 271 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 587, DateTimeKind.Local).AddTicks(9975), "Qui id et est aut eaque voluptatem laboriosam ut ea libero aperiam qui suscipit debitis aut.", "Miss Kassandra Triston Frami V", 9, 1.0, 335 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 588, DateTimeKind.Local).AddTicks(2430), "Repellat tempore sit voluptates ut eligendi fugiat eos est qui.", "Gladys Schowalter", 4, 20.0, 326 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 588, DateTimeKind.Local).AddTicks(5028), "Dolor optio neque eveniet et voluptas dolorem labore nisi ut est.", "Vern Luettgen Sr.", 2, 4.0, 126 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 588, DateTimeKind.Local).AddTicks(8846), "Voluptatem et nihil doloribus sint quod quidem commodi error fugit amet.", "Ms. Ofelia Tatum Simonis", 10, 1.0, 263 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 589, DateTimeKind.Local).AddTicks(2950), "Ratione facere tenetur sapiente quibusdam veniam occaecati reiciendis ut earum voluptate dolorem corrupti debitis.", "Mrs. Lucas Lura Franecki", 3, 20.0, 239 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 589, DateTimeKind.Local).AddTicks(5608), "Dolorem nulla ipsa aut est officiis et aut maxime aut velit sed.", "Domingo Braun MD", 4, 16.0, 472 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 589, DateTimeKind.Local).AddTicks(8639), "Iste dolores pariatur et reiciendis velit repellat culpa explicabo est enim itaque cum unde ea inventore.", "Derek Watsica", 3.0, 400 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(1238), "Necessitatibus atque atque sit nemo laborum incidunt voluptatibus qui quia ut.", "Mr. Leta Robel", 6, 7.0, 487 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(3695), "Neque consequuntur nam aut dicta id temporibus odio cum dolores.", "Jakob Rodriguez", 9, 19.0, 478 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(6147), "Ut earum iure dignissimos amet reiciendis consectetur laudantium velit quis.", "Burdette Nikolaus", 7, 18.0, 448 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 590, DateTimeKind.Local).AddTicks(8870), "Consequatur quo qui accusantium consequatur enim at quae cum animi aut iusto velit.", "Samanta Turcotte", 5, 6.0, 222 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 591, DateTimeKind.Local).AddTicks(1615), "Sint perspiciatis dignissimos natus eos dolorem molestiae pariatur dolorem at commodi ex laborum.", "Isaias Keeling", 7, 1.0, 358 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 591, DateTimeKind.Local).AddTicks(5566), "Quasi ea nihil architecto laboriosam dignissimos exercitationem suscipit error corrupti sapiente et.", "Jade Vella Williamson PhD", 4, 18.0, 346 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 591, DateTimeKind.Local).AddTicks(8528), "Rerum et architecto consequatur et est laboriosam sed nostrum optio a et velit esse hic.", "Prof. Marcelo Runolfsson", 5, 15.0, 246 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(1170), "Commodi labore sapiente rerum ut enim nostrum unde voluptates non veritatis quia.", "Laron Feil", 1, 4.0, 398 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(3785), "Illo est consequuntur blanditiis eum dolorem recusandae dolorem occaecati consequatur perspiciatis.", "Mr. Tamia Ledner PhD", 3, 8.0, 170 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Details", "Name", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(6320), "Numquam facilis exercitationem voluptatem nemo impedit sunt non molestias vero et.", "Randi Bogan", 451 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Details", "Name", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 592, DateTimeKind.Local).AddTicks(8963), "Ex rerum sit voluptatum quisquam id ut nam labore veritatis delectus qui.", "Dorothy Schinner", 9.0, 206 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 593, DateTimeKind.Local).AddTicks(1414), "Porro numquam id rem sapiente est dolor ea reprehenderit quo.", "Hunter Collier", 10, 364 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 593, DateTimeKind.Local).AddTicks(4093), "Qui omnis doloribus accusamus aut velit dicta impedit excepturi impedit consequuntur perferendis.", "Randal Douglas", 6, 20.0, 366 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 593, DateTimeKind.Local).AddTicks(6617), "Debitis facilis aut sint dolor fugiat suscipit rerum voluptas est.", "Tomasa Barton", 5, 13.0, 173 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(727), "Quis sunt sit omnis temporibus velit et ut voluptas sunt commodi blanditiis illum qui.", "Prof. Celestine Chanel Romaguera DDS", 2, 4.0, 142 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(3380), "Laudantium assumenda magnam vitae sunt ut error officiis possimus sapiente debitis molestiae.", "Sam Hudson PhD", 5, 12.0, 208 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(6232), "Qui et voluptatum asperiores adipisci sed molestias corrupti totam suscipit magnam voluptatibus ullam.", "Zoila Runolfsson", 3, 14.0, 275 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 594, DateTimeKind.Local).AddTicks(9957), "Praesentium error dolorem laudantium animi voluptas porro sapiente corrupti ut.", "Prof. Adell Anissa Wolf III", 2, 17.0, 238 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 595, DateTimeKind.Local).AddTicks(3014), "Sed esse itaque tempore eaque mollitia omnis magnam eligendi qui repellat nulla minus qui accusamus.", "Betty Glover", 6, 10.0, 430 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 595, DateTimeKind.Local).AddTicks(6152), "Et doloremque aliquam et officiis quis neque maxime ut veritatis temporibus ratione consequatur ut cum.", "Russell Lindgren PhD", 5, 11.0, 427 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 595, DateTimeKind.Local).AddTicks(9094), "Facilis aut et blanditiis aut culpa a est sint ut esse id et quis exercitationem.", "Elton Muller", 3, 3.0, 109 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 596, DateTimeKind.Local).AddTicks(3803), "Impedit tempora sint qui voluptatem est id dolorum accusantium consequatur animi aut laboriosam qui perspiciatis sit.", "Prof. Monroe Andy Kertzmann", 5, 7.0, 425 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 596, DateTimeKind.Local).AddTicks(6707), "Molestias itaque velit nihil aut dolorem dolores dolore beatae animi quo.", "Prof. Chelsea Stamm", 7, 320 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 597, DateTimeKind.Local).AddTicks(1535), "Recusandae odit nisi facilis tenetur nesciunt adipisci et laborum cumque corrupti quam aut reprehenderit eveniet aperiam.", "Bradley Samara Zieme DVM", 6, 9.0, 391 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 597, DateTimeKind.Local).AddTicks(4761), "Dolorem quibusdam autem qui doloribus quas animi expedita amet possimus eaque iure nam.", "Karianne Gulgowski", 6, 1.0, 258 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 597, DateTimeKind.Local).AddTicks(9606), "Rerum hic ut est a possimus amet magni ea ratione et fugiat molestiae velit.", "Hosea Federico Marks Jr.", 5, 4.0, 484 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2022, 9, 11, 15, 51, 19, 598, DateTimeKind.Local).AddTicks(2661), "Iste ut ducimus fugiat qui rerum quasi possimus dolores earum in similique.", "Hudson Hills", 9, 9.0, 268 });
        }
    }
}
