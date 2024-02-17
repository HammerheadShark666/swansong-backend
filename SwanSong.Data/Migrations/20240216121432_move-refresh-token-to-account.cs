using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    public partial class moverefreshtokentoaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Accounts_AccountId",
                table: "RefreshTokens");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "RefreshTokens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "Expires",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1099), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1119), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1122), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1130), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1137), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1191), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1195), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1198), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1202), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1209), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1216), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1223), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1227), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1234), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1241), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1245), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1257), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1264), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1268), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1275), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1286), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1289), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1293), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1300), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1303), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1310), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1314), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1318), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1329), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1333), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1336), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1343), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1347), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1350), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1357), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1376), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1383), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1387), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1394), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1401), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1405), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1415), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1419), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1437), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1451), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1511), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1515), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1522), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1525), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1533), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1536), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1540), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1547), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1554), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1557), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1561), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1564), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1572), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1576), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1579), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1583), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1587), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1590), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1594), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1597), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1601), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1604), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1608), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1639), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1653), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1660), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1663), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1667), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1674), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1681), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1688), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1698), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1702), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1707), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1714), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1731), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1738), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1742), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1797), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1809), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1814), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1820), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1825), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1830), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1836), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1842), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1848), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1858), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1867), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1884), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1926), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1931), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1944), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1947), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1951), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1965), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1973), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1977), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1980), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1995), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(1998), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2005), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2019), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2023), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2026), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2030), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2038), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2045), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2052), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2056), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2063), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2070), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2077), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2080), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2084), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2087), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2117), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2124), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2127), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2131), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2134), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2139), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2153), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2156), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2163), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2167), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9806), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9822), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9827), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9831), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9845), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9849), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9856), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9868), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9872), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9879), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9886), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9347), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9351), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9356), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9360), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9364), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9368), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9381), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9385), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9389), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9406), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9410), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9414), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9047), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9063), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9066), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9074), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9096), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9106), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9133), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9150), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9192), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9195), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9199), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9205), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8878), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8882), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8888), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "a5d0555f-7bce-4b7c-b0eb-d26d83afba90");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "f175339e-962a-4416-8e6c-8f9f755bf6e6");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9443), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9458), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9463), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9478), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9486), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9496), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9506), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9563), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9589), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9601), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9605), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9613), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9626), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9634), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9639), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9643), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9649), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9653), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9657), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9661), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9689), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9693), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9702), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8998), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9012), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9015), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9944), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9948), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(327), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(331), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(335), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(338), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(349), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(352), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(357), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(367), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(371), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(378), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(381), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(385), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(26), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(38), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(45), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(123), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(137), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(144), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(52), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(78), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(97), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(101), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(116), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(154), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(158), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(162), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(165), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(169), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(172), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(183), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(193), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(197), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(205), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(208), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(223), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(231), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(234), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(238), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(252), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(259), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(314), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(413), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(420), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(437), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(441), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(448), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(455), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(458), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(470), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(474), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(488), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(491), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(495), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(498), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(503), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(507), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(517), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(528), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(582), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(593), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(596), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(603), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(626), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(658), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(661), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(675), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(679), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(686), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(700), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(710), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(714), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(717), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(721), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(725), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(729), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(732), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(736), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(746), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(753), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(760), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(764), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(771), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(778), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(788), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(795), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(803), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(806), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(827), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(842), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(846), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(853), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(857), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(871), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(919), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(941), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(944), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(952), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(955), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(966), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(973), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 2, 16, 12, 14, 28, 225, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 2, 16, 12, 14, 28, 224, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Accounts_AccountId",
                table: "RefreshTokens",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Accounts_AccountId",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "Expires",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Accounts");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "RefreshTokens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(6581), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8141), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8153), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8158), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8192), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8201), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8205), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8212), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8228), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8231), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8238), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8242), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8256), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8260), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8264), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8277), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8350), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8369), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8376), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8383), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8387), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8423), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8427), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8442), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8456), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8472), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8476), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8488), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8491), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8496), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8514), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8525), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8532), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8547), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8558), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8561), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8572), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8576), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8583), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8616), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8619), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8627), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8694), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8701), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8709), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8742), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8758), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8776), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8779), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8783), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8798), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8805), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8809), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8812), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8816), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8823), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8830), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8838), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8863), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8871), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8874), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8878), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8881), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8889), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8892), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8896), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8899), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8903), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8907), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8910), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8914), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8918), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8921), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8925), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8928), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8932), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8936), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8939), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8998), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9005), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9012), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9027), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9031), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9038), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9046), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9053), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9064), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9067), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9075), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9078), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9105), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9108), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9112), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9123), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9148), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9184), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "AlbumSongs",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(5485), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(8140), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9408), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9451), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9456), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9461), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9560), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9576), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(5185), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8571), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8599), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8609), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8622), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8692), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8701), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 784, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 2, 1, 18, 21, 38, 784, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1159), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1191), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1204), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1209), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1226), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1231), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1247), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1252), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1256), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1262), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1268), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1277), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1283), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1293), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1303), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1309), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1314), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1330), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1335), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1339), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1346), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1455), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1463), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1468), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1484), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1492), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1497), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "BirthPlaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1517), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 776, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7656), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7681), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 792, DateTimeKind.Local).AddTicks(5432), new DateTime(2024, 2, 1, 18, 21, 38, 792, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(487), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(520), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(885), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(902), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(984), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(995), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1016), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1021), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1025), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1034), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1041), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1046), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1056), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1074), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1098), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1108), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1112), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1122), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1131), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1135), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1144), new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(5419), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6565), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6589), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6594), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6599), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "RecordLabels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6604), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8874), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8879), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8921), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8925), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8929), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8933), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9395), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9399), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9411), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9415), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9432), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9502), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9507), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9515), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8941), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8960), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8964), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8968), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9194), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9198), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9211), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9219), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9223), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8972), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8983), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9000), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9009), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9013), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9029), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9231), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9235), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9240), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9251), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9260), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9264), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9268), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9272), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9276), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9280), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9285), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9289), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9293), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9322), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9353), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9357), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9382), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9387), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9532), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9544), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9548), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9557), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9565), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9569), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9573), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9586), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9594), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9598), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9602), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9610), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9614), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9619), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9623), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9627), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9631), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9637), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9645), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9649), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9653), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9657), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9661), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9682), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9687), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9700), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9704), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9712), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9717), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9725), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9737), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9749), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9758), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9762), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9846), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9856), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9864), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9869), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9877), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9881), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9902), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9923), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9944), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9957), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9961), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9974), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9978), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9994), new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(7), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(11), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(28), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(40), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(57), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(106), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(123), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(131), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(135), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(139), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(148), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(152), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(156), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(164), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(168), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(172), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(177), new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Accounts_AccountId",
                table: "RefreshTokens",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
