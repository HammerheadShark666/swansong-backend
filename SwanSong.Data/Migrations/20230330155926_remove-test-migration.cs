using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SwanSong.Data.Migrations
{
    public partial class removetestmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Artists");

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6276), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6297), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6412), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6417), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6422), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6430), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6433), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6437), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6441), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6461), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6464), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6474), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6482), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6486), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6489), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6508), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6512), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6523), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6528), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6531), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6561), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6565), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6572), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6576), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6583), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6592), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6603), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6607), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6612), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6621), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6625), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6629), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6662), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6666), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6669), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6673), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6677), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6681), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6685), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6689), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6693), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6696), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6748), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6782), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6798), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6802), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6806), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6839), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6873), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6908), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6918), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6922), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6926), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6929), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6933), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6937), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6944), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6949), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6952), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6956), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6960), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6963), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6967), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6971), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6974), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6982), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6985), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6989), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6993), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7004), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7008), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7011), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7015), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7059), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7064), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7068), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7075), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7079), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7083), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7086), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7090), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7097), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7101), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7105), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7109), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7117), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7121), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7125), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7129), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7136), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7140), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7144), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7147), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7155), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7158), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7162), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7166), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7170), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7174), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7177), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7181), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7189), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7192), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7196), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7201), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7205), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7212), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7216), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7220), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7224), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7228), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7231), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7235), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7239), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7243), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7246), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7257), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7260), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7264), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7268), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7271), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7276), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7284), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7287), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7291), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7295), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7298), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7302), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7309), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7313), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7317), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7324), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7332), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7335), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7339), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7346), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 3, 30, 16, 59, 25, 2, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9674), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9706), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9789), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9819), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9830), new DateTime(2023, 3, 30, 16, 59, 24, 983, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5913), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5948), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5953), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5962), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5967), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5976), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5980), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5985), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5989), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5998), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(6007), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 3, 30, 16, 59, 24, 975, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 973, DateTimeKind.Local).AddTicks(9343), new DateTime(2023, 3, 30, 16, 59, 24, 973, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(388), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(403), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(416), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(428), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(433), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(452), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(522), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(526), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(641), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(646), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(649), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(653), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(657), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(661), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(665), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(668), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(672), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(676), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(681), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(684), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(688), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(691), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(695), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(704), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(707), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(711), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(718), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(722), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(725), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(729), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(733), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(737), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(740), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(744), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(747), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 968, DateTimeKind.Local).AddTicks(1325), new DateTime(2023, 3, 30, 16, 59, 24, 970, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 3, 30, 16, 59, 24, 971, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "89419137-2517-49bd-a94c-9ae5785cc195");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "f4ca674d-47db-48b4-bc94-79dd1951a4b5");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 981, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 3, 30, 16, 59, 24, 981, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2416), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2420), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2839), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2905), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2909), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2925), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2935), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2951), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2958), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2975), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 3, 30, 16, 59, 24, 982, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2019), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2699), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 3, 30, 16, 59, 24, 972, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5485), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5503), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5514), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5531), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5979), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5983), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5986), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5995), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5999), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6059), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5540), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5675), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5758), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5769), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5773), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5781), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5784), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5696), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5708), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5713), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5729), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5744), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5753), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5788), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5792), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5795), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5799), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5803), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5807), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5818), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5823), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5828), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5835), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5843), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5865), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5886), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6081), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6086), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6090), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6093), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6097), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6101), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6105), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6109), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6113), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6122), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6125), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6133), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6137), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6155), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6163), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6172), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6175), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6184), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6191), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6198), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6202), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6275), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6279), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6286), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6298), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6368), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6372), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6388), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6392), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6395), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6403), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6407), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6410), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6425), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6429), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6433), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6436), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6444), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6448), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6451), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6459), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6462), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6474), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6477), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6481), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6489), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6492), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6509), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6516), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6527), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6531), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6553), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6561), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6565), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6572), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6619), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6635), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6649), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6653), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6657), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6661), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 3, 30, 16, 59, 24, 989, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(3392), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 3, 30, 16, 59, 24, 974, DateTimeKind.Local).AddTicks(3990) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
