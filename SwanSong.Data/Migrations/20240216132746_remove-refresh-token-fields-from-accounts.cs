using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    public partial class removerefreshtokenfieldsfromaccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expires",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Accounts");

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9061), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9070), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9074), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9107), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9114), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9193), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9197), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9211), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9233), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9240), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9262), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9266), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9269), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9276), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9280), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9290), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9308), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9311), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9341), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9356), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9359), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9371), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9374), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9379), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9384), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9388), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9402), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9413), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9419), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9430), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9517), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9566), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9578), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9585), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9592), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9595), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9600), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9619), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9624), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9632), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9635), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9642), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9645), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9649), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9652), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9659), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9663), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9681), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9702), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9705), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9709), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9712), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9737), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9744), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9747), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9751), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9759), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9764), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9771), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9775), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9789), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9803), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9807), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9814), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9857), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9865), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9868), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9872), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9875), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9879), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9886), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9889), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9893), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9944), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9948), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9963), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9970), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9974), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(29), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(39), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(43), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(51), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(54), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(78), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(89), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(99), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(103), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(106), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(113), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(117), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(120), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(131), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(134), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(137), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(141), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(144), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(148), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(155), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(158), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(162), new DateTime(2024, 2, 16, 13, 27, 42, 760, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7856), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7871), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7875), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7879), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7887), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7901), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7905), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7909), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7913), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7916), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7924), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7927), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7932), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7939), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7946), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7950), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7390), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7406), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7419), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7422), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7435), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7448), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7452), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7460), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7477), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7143), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7165), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7196), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7230), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7237), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7251), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7258), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7262), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7265), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7272), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7282), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7285), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6937), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6952), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6957), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2a0369b6-5327-4597-9fb5-0eccf4cffd57");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "4c5910a3-4fbc-4f93-aad7-1c4defbcd845");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7530), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7548), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7552), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7595), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7604), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7618), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7622), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7626), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7631), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7636), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7639), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7648), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7652), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7656), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7665), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7669), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7678), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7682), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7686), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7694), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7699), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7708), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7712), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7716), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7724), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7727), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7735), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7739), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7743), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7751), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7984), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7988), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7995), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7999), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8038), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8042), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8346), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8353), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8367), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8374), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8399), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8403), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8407), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8417), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8424), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8054), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8057), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8064), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8067), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8071), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8140), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8151), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8158), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8161), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8164), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8074), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8082), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8086), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8096), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8103), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8114), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8131), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8137), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8168), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8171), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8175), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8182), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8189), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8192), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8199), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8202), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8227), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8245), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8257), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8260), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8263), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8321), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8325), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8332), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8335), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8435), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8442), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8456), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8467), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8474), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8482), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8485), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8489), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8492), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8496), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8514), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8572), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8575), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8582), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8589), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8593), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8603), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8607), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8617), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8654), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8675), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8689), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8703), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8707), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8742), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8752), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8756), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8760), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8792), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8803), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8806), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8810), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8813), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8817), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8831), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8838), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8855), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8862), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8904), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8908), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8912), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8915), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8919), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8926), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8930), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8934), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8937), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8941), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8944), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8948), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8952), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8962), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8969), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8973), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8976), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8983), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7366), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7372), new DateTime(2024, 2, 16, 13, 27, 42, 759, DateTimeKind.Local).AddTicks(7374) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Expires",
                table: "Accounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2587), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2591), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2600), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2603), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2607), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2611), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2617), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2624), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2635), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2639), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2642), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2651), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2657), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2661), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2664), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2668), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2671), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2682), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2685), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2690), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2693), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2697), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2700), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2712), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2716), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2720), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2723), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2727), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2734), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2738), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2741), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2745), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2748), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2752), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2756), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2763), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2767), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2770), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2777), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2781), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2784), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2788), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2791), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2795), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2802), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2805), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2809), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2819), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2895), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2900), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2903), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2910), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2926), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2929), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2933), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2936), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2940), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2951), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2965), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2969), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2972), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2976), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2983), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2991), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2995), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3006), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3016), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3020), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3024), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3031), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3056), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3059), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3063), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3066), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3070), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3074), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3077), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3081), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3084), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3099), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3122), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3129), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3178), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3185), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3189), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3197), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3201), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3208), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3211), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3218), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3222), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3225), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3229), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3232), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3236), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3243), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3246), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3253), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3257), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3261), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3279), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3283), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3293), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3307), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3311), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3333), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3336), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3339), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3346), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3357), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3364), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3368), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3371), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3375), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3385), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3388), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3392), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3396), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3403), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3406), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3413), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3417), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3424), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3435), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3452), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3456), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3467), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3470), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3474), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3477), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3481), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3488), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3498), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3537), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3545), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3562), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3565), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3572), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1238), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1256), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1264), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1269), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1273), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1277), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1281), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1287), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1299), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1303), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1306), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1310), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1314), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1330), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1375), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(778), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(786), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(796), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(800), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(804), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(834), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(838), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(848), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(852), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(458), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(463), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(470), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(488), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(495), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(499), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(507), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(528), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(535), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(539), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(546), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(553), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(661), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(671), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(675), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(678), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(681), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(692), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ab3dd894-0fa4-4bcc-b4e5-d79b0fb6c396");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "d8791a1c-5ebb-4e9b-82ee-a2e19ee210a6");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(936), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(941), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(965), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(969), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(978), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(986), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(991), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(995), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(999), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1003), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1009), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1017), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1021), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1039), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1052), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1056), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1096), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1168), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1173), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1177), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1181), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1190), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1194), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(375), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(382), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(385), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(404), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1432), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1436), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1750), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1754), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1757), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1761), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1764), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1768), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1771), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1775), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1778), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1782), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1785), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1789), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1793), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1796), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1800), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1803), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1807), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1814), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1817), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1822), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1825), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1829), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1832), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1452), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1455), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1459), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1463), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1467), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1470), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1548), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1552), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1555), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1559), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1562), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1566), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1484), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1491), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1506), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1514), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1518), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1521), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1525), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1536), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1573), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1577), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1581), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1585), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1589), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1592), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1596), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1603), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1607), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1614), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1630), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1633), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1637), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1641), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1680), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1699), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1713), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1729), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1732), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1736), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1740), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1743), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1836), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1839), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1843), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1875), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1882), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1893), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1896), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1900), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1907), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1914), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1963), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1974), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1977), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1981), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1989), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1992), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1996), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2003), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2006), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2010), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2013), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2017), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2020), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2027), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2031), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2038), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2041), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2045), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2048), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2052), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2062), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2069), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2076), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2080), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2083), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2087), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2099), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2109), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2116), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2124), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2127), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2131), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2134), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2138), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2145), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2152), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2156), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2163), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2167), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2170), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2185), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2188), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2203), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2245), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2256), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2259), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2263), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2273), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2277), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2280), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2288), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2305), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2309), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2312), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2316), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2320), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2323), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2330), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2334), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2344), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2355), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2362), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2366), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2373), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2384), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2388), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2391), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 2, 16, 12, 20, 19, 773, DateTimeKind.Local).AddTicks(743) });
        }
    }
}
