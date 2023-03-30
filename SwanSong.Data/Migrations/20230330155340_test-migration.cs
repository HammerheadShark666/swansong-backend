using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SwanSong.Data.Migrations
{
    public partial class testmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "test",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(3115), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4805), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4813), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4848), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4859), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4863), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4867), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4872), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4876), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4879), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4883), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4894), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4898), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4902), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4917), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4924), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4936), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4951), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4955), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4959), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4962), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4966), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4973), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4977), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5089), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5109), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5123), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5132), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5159), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5162), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5189), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5193), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5215), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5226), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5237), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5245), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5249), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5256), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5267), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5282), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5294), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5297), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5301), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5305), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5309), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5316), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5325), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5342), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5358), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5363), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5368), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5374), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5437), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5460), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5465), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5475), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5481), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5487), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5492), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5502), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5515), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5533), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5553), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5559), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5567), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5585), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5593), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5615), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5627), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5634), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5638), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5649), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5665), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5672), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5676), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5687), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5691), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5699), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5710), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5729), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5787), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5792), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5804), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5807), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5833), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5837), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5845), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5860), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5886), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5946), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5953), new DateTime(2023, 3, 30, 16, 53, 38, 537, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 519, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 3, 30, 16, 53, 38, 519, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(967), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2132), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2153), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2193), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2197), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 3, 30, 16, 53, 38, 520, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5549), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5553), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5579), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5585), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5746), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 3, 30, 16, 53, 38, 513, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7336), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7353), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7422), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7430), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7442), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7445), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7449), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7460), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7476), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7479), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7483), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7487), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7494), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7498), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7501), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7505), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7510), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7517), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 3, 30, 16, 53, 38, 511, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 504, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5019), new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5036), new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 3, 30, 16, 53, 38, 507, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ee72a513-713b-4791-8891-25f6b1795da3");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "355df2c4-11da-45c8-b930-ccbb48bf5499");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 517, DateTimeKind.Local).AddTicks(7815), new DateTime(2023, 3, 30, 16, 53, 38, 517, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(931), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(948), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(952), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(957), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1255), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1266), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1271), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1275), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1281), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1286), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1291), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1295), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1304), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1308), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1312), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1318), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1322), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1424), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1431), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1435), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1443), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1448), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1452), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1456), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1462), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1466), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1470), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1478), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1483), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1497), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1501), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1505), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1514), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1518), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1539), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 3, 30, 16, 53, 38, 518, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6112), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6118), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6124), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6139), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 3, 30, 16, 53, 38, 509, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4291), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4648), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4651), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4655), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4659), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4662), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4667), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4682), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4693), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4697), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4701), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4704), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4708), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4713), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4728), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4731), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4735), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4303), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4307), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4311), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4314), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4318), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4322), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4475), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4481), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4484), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4488), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4326), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4334), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4357), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4360), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4372), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4375), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4379), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4383), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4387), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4391), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4503), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4507), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4514), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4519), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4523), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4526), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4541), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4545), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4549), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4563), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4567), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4586), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4591), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4607), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4622), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4625), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4633), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4636), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4644), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4739), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4742), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4746), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4843), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4847), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4851), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4854), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4869), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4873), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4877), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4888), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4892), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4910), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4914), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4917), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4921), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4925), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4936), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4951), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4955), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4959), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4966), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4974), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4977), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4981), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4985), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5003), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5007), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5019), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5023), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5027), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5030), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5041), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5045), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5057), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5064), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5072), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5117), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5125), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5129), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5133), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5148), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5159), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5189), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5192), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5196), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5215), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5218), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5222), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5226), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5233), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5237), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5245), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5248), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5252), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5256), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5259), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5267), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5282), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5289), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5293), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5297), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5304), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5308), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5319), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5327), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5331), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5334), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5338), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5342), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5345), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5349), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5356), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5360), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5364), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5368), new DateTime(2023, 3, 30, 16, 53, 38, 526, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(599), new DateTime(2023, 3, 30, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(1203), new DateTime(2023, 3, 30, 16, 53, 38, 512, DateTimeKind.Local).AddTicks(1211) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Artists");

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(221), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1763), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1785), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1798), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1802), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1814), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1818), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1838), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1842), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1847), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1851), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1855), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1859), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1862), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1866), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1970), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1975), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1979), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1990), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1994), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1998), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2002), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2006), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2013), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2020), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2024), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2028), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2032), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2039), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2051), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2081), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2085), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2100), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2104), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2108), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2115), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2122), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2126), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2135), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2154), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2158), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2173), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2184), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2188), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2203), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2218), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2222), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2226), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2233), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2237), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2311), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2364), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2372), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2375), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2379), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2387), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2391), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2410), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2414), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2423), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2426), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2445), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2449), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2453), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2464), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2468), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2484), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2491), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2495), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2502), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2513), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2521), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2525), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2611), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2615), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2637), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2641), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2672), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2704), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2715), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2731), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2795), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2833), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2851), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(3164), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8207), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8241), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8263), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8271), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8278), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8286), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8296), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8432), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8439), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8446), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8453), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8475), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8482), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8489), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8026), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8151), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8158), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8175), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8183), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8191), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8208), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8214), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8222), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8228), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8236), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8243), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8258), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8267), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8274), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8281), new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(5423), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6676), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6698), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6709), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6713), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6720), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6744), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6763), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6845), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6853), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6871), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6874), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6897), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6908), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6914), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6918), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6921), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6925), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6928), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 95, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 3, 30, 16, 50, 12, 98, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(995), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1008), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1012), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1025), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "6d4d1f71-6ca4-48cd-aa47-860bb7d1b2b8");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "01419bec-85f9-4521-b914-a8fb36faa10c");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5007), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5030), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5044), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5564), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5614), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5621), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5636), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5653), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5678), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5685), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5707), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5729), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5735), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5742), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5766), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5774), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5781), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5804), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5818), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5833), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(3651), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4749), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4773), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4778), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(4363), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6136), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6154), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6161), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6184), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6191), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6198), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6204), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7056), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7062), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7067), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7139), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7156), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7172), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7187), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7218), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7234), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7266), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7275), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7293), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7309), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7322), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7327), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7333), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7344), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7359), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6225), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6793), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6804), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6679), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6695), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6709), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6722), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6727), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6734), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6766), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6781), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6845), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6901), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6907), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6919), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6924), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6936), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6942), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6948), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6954), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6960), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6969), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6975), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6987), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6993), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6999), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7005), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7011), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7017), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7023), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7029), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7040), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7051), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7365), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7446), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7457), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7487), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7494), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7499), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7508), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7517), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7524), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7530), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7542), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7549), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7555), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7561), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7567), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7573), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7579), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7585), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7603), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7674), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7683), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7688), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7695), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7701), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7706), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7718), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7732), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7738), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7785), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7797), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7804), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7811), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7818), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7824), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7836), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7843), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7851), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7898), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7963), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7992), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7999), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8012), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8024), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8067), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8074), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8081), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8094), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8132), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8150), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8162), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8174), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8181), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8188), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8202), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8262), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8282), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8289), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8305), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8321), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8332), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8337), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8342), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8353), new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 50, 12, 104, DateTimeKind.Local).AddTicks(128), new DateTime(2023, 3, 30, 16, 50, 12, 104, DateTimeKind.Local).AddTicks(136) });
        }
    }
}
