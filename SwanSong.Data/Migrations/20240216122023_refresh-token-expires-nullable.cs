using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    public partial class refreshtokenexpiresnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "Accounts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Expires",
                value: null);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Expires",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
