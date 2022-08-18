using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SwanSong.Data.Migrations
{
    public partial class Createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptTerms = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordReset = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecordLabels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordLabels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    FormationYear = table.Column<int>(type: "int", nullable: true),
                    DisbandYear = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BirthPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirthPlaces_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RecordedDate = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    LabelId = table.Column<int>(type: "int", nullable: true),
                    StudioId = table.Column<int>(type: "int", nullable: true),
                    ArtistId = table.Column<long>(type: "bigint", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Producers = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Arrangers = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Engineers = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Artwork = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_RecordLabels_LabelId",
                        column: x => x.LabelId,
                        principalTable: "RecordLabels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Albums_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<long>(type: "bigint", nullable: true),
                    StageName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthPlaceId1 = table.Column<int>(type: "int", nullable: true),
                    BirthPlaceId = table.Column<long>(type: "bigint", nullable: true),
                    IsSongWriter = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Members_BirthPlaces_BirthPlaceId1",
                        column: x => x.BirthPlaceId1,
                        principalTable: "BirthPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<long>(type: "bigint", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlbumSongs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<long>(type: "bigint", nullable: false),
                    SongId = table.Column<long>(type: "bigint", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Side = table.Column<int>(type: "int", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumSongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlbumSongs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongWriter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    SongId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongWriter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SongWriter_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AcceptTerms", "Created", "Email", "FirstName", "LastName", "PasswordHash", "PasswordReset", "ResetToken", "ResetTokenExpires", "Role", "Title", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test100@hotmail.com", "test", "test", "$2a$11$6J/RawAXn5hbcQwiVor7A.dEtLcMcUF8BI/EOMrAa2002hNJB8ZKC", null, "142CEC560EBE8EA56F8344E178948EE76022B02B0D407A974611AFCDA7849FCD83826607543C0CA0", null, 0, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 17, 16, 49, 35, 132, DateTimeKind.Local).AddTicks(1376), new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(6150), "England" },
                    { 2, new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8038), new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8065), "Scotland" },
                    { 3, new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8072), new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8079), "Wales" },
                    { 4, new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8084), new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8089), "Northern Ireland" },
                    { 5, new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8217), new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8223), "United States of America" },
                    { 6, new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8237), "Australia" },
                    { 7, new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 8, 17, 16, 49, 35, 136, DateTimeKind.Local).AddTicks(8242), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "35b56ddd-d019-45c4-8e8b-fab9b32bad0f", "USER", "USER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "acbc17f7-32dd-4e35-8087-5d0fe90cd6ef", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "RecordLabels",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3665), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3668), "United Artists" },
                    { 8, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3658), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3661), "Reprise" },
                    { 7, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3654), "Island Records" },
                    { 5, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3633), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3636), "Sony Music Entertainment" },
                    { 6, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3644), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3647), "Columbia Label Group" },
                    { 3, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3623), "RCA Records" },
                    { 2, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3598), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3612), "Swan Song Records" },
                    { 1, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(2617), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(2650), "Atlantic Records" },
                    { 4, new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3626), new DateTime(2022, 8, 17, 16, 49, 35, 139, DateTimeKind.Local).AddTicks(3629), "Universal Music Publishing Group" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 180L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1854), "6:53", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1855), "Forever" },
                    { 179L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1850), "2:51", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1851), "Now You See It (Now You Don't)" },
                    { 178L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1846), "5:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1847), "You're No Different" },
                    { 177L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1842), "4:32", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1844), "Bark at the Moon" },
                    { 176L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1838), "4:03", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1840), "Rock 'n' Roll Rebel" },
                    { 175L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1834), "4:30", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1836), "Darkness on the Edge of Town" },
                    { 173L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1826), "4:09", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1828), "Streets of Fire" },
                    { 172L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1822), "2:17", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1823), "Factory" },
                    { 171L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1818), "4:33", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1819), "The Promised Land" },
                    { 170L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1814), "6:53", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1815), "Racing in the Street" },
                    { 169L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1810), "2:51", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1812), "Candy's Room" },
                    { 174L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1830), "3:56", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1832), "Prove It All Night" },
                    { 181L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1857), "4:33", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1859), "So Tired" },
                    { 190L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1893), "4:50", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1894), "Shah Shah a Go Go" },
                    { 183L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1865), "4:09", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1867), "Spiders" },
                    { 184L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1869), "1:10", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1871), "Longships" },
                    { 185L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1873), "5:13", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1875), "The Raven" },
                    { 186L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1877), "2:24", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1879), "Dead Loss Angeles" },
                    { 187L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1881), "3:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1882), "Ice" },
                    { 188L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1885), "3:50", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1886), "Baroque Bordello" },
                    { 189L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1889), "3:32", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1890), "Nuclear Device(The Wizard of Aus)" },
                    { 168L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1806), "5:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1808), "Something in the Night" },
                    { 191L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1896), "4:09", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1898), "Don't Bring Harry" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 192L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1900), "2:30", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1902), "Duchess" },
                    { 193L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1904), "4:48", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1906), "Meninblack" },
                    { 194L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1908), "5:16", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1910), "Genetix" },
                    { 182L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1861), "2:17", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1863), "Waiting for Darkness" },
                    { 167L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1802), "4:32", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1804), "Adam Raised a Cain" },
                    { 150L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1723), "6:05", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1725), "Point Blank" },
                    { 158L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1754), "3:53", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1756), "Wreck on the Highway" },
                    { 131L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1645), "3:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1647), "Don't Stop" },
                    { 132L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1649), "3:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1651), "Go Your Own Way" },
                    { 133L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1653), "3:20", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1655), "Songbird" },
                    { 134L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1657), "4:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1658), "The Chain" },
                    { 135L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1662), "3:31", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1664), "You Make Loving Fun" },
                    { 136L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1666), "3:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1668), "I Don't Want to Know" },
                    { 137L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1672), "3:54", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1674), "Oh Daddy" },
                    { 138L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1676), "4:51", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1678), "Gold Dust Woman" },
                    { 139L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1680), "3:33", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1682), "The Ties That Bind" },
                    { 140L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1684), "4:02", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1686), "Sherry Darling" },
                    { 141L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1688), "3:04", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1690), "Jackson Cage" },
                    { 142L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1692), "2:42", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1694), "Two Hearts" },
                    { 143L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1696), "4:46", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1698), "Independence Day" },
                    { 144L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1700), "3:19", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1702), "Hungry Heart" },
                    { 145L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1704), "4:17", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1705), "Out in the Street" },
                    { 146L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1708), "3:10", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1709), "Crush on You" },
                    { 147L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1711), "2:36", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1713), "You Can Look (But You Better Not Touch)" },
                    { 148L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1715), "3:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1717), "I Wanna Marry You" },
                    { 149L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1719), "4:59", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1721), "The River" },
                    { 195L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1912), "4:32", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1914), "Nebraska" },
                    { 151L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1727), "3:02", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1729), "Cadillac Ranch" },
                    { 152L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1731), "3:34", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1733), "I'm a Rocker" },
                    { 153L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1735), "4:40", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1737), "Fade Away" },
                    { 154L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1739), "3:53", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1741), "Stolen Car" },
                    { 155L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1743), "4:04", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1744), "Ramrod" },
                    { 156L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1747), "5:27", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1748), "The Price You Pay" },
                    { 157L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1751), "8:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1752), "Drive All Night" },
                    { 166L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1797), "4:03", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1799), "Badlands" },
                    { 196L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1916), "4:00", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1918), "Atlantic City" },
                    { 205L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1952), "2:55", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1954), "Iron Fist" },
                    { 198L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1924), "3:44", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1926), "Johnny 99" },
                    { 230L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2059), "2:01", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2062), "Peggy Day" },
                    { 231L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2065), "3:18", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2068), "Lay Lady Lay" },
                    { 232L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2072), "2:23", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2074), "One More Night" },
                    { 233L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2078), "2:41", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2080), "Tell Me That It Isn't True" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 234L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2083), "1:37", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2085), "Country Pie" },
                    { 235L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2089), "3:23", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2091), "Tonight I'll Be Staying Here with You" },
                    { 236L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2116), "4:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2119), "Born in the U.S.A." },
                    { 237L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2124), "3:29", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2126), "Cover Me" },
                    { 238L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2129), "4:48", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2132), "Darlington County" },
                    { 239L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2135), "3:13", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2138), "Working on the Highway" },
                    { 240L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2141), "3:35", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2143), "Downbound Train" },
                    { 241L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2146), "2:40", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2148), "I'm on Fire" },
                    { 229L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2054), "2:23", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2056), "I Threw It All Away" },
                    { 242L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2151), "4:01", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2154), "No Surrender" },
                    { 244L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2164), "3:30", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2166), "I'm Goin' Down" },
                    { 245L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2169), "4:15", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2174), "Glory Days" },
                    { 246L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2180), "4:04", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2182), "Dancing in the Dark" },
                    { 247L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2185), "4:34", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2187), "My Hometown" },
                    { 248L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2191), "4:49", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2193), "Thunder Road" },
                    { 249L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2196), "3:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2199), "Tenth Avenue Freeze-Out" },
                    { 250L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2202), "3:00", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2205), "Night" },
                    { 251L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2208), "6:30", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2210), "Backstreets" },
                    { 252L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2278), "4:31", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2283), "Born to Run" },
                    { 253L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2287), "4:30", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2289), "She's the One" },
                    { 254L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2293), "3:18", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2295), "Meeting Across the River" },
                    { 255L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2299), "9:34", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2301), "Jungleland" },
                    { 243L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2157), "3:48", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2160), "Bobby Jean" },
                    { 228L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2047), "2:07", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2050), "To Be Alone with You" },
                    { 227L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2041), "3:12", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2044), "Nashville Skyline Rag" },
                    { 226L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2036), "3:41", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2038), "Girl from the North Country" },
                    { 199L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1928), "5:40", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1930), "Highway Patrolman" },
                    { 200L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1932), "3:17", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1934), "State Trooper" },
                    { 201L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1936), "3:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1938), "Used Cars" },
                    { 202L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1940), "2:58", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1941), "Open All Night" },
                    { 203L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1944), "5:07", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1946), "My Father's House" },
                    { 204L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1948), "4:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1950), "Reason to Believe" },
                    { 130L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1641), "2:02", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1643), "Never Going Back Again" },
                    { 206L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1956), "3:04", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1958), "Heart of Stone" },
                    { 207L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1960), "2:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1962), "I'm the Doctor" },
                    { 208L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1964), "3:10", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1965), "Go to Hell" },
                    { 209L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1968), "3:57", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1969), "Loser" },
                    { 210L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1972), "2:10", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1973), "Sex & Outrage" },
                    { 211L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1976), "3:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1977), "America" },
                    { 212L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1979), "2:41", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1981), "Shut It Down" },
                    { 213L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1983), "3:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1985), "Speedfreak" },
                    { 214L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1987), "3:08", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1989), "(Don't Let 'Em) Grind Ya Down" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 215L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1991), "2:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1993), "(Don't Need) Religion" },
                    { 216L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1995), "2:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1997), "Bang to Rights" },
                    { 217L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1999), "4:03", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2001), "Stormbringer" },
                    { 218L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2003), "4:23", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2005), "Love Don't Mean a Thing" },
                    { 219L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2007), "4:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2008), "Holy Man" },
                    { 220L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2011), "5:05", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2012), "Hold On" },
                    { 221L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2015), "3:19", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2016), "Lady Double Dealer" },
                    { 222L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2019), "3:24", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2020), "You Can't Do It Right (With the One You Love)" },
                    { 223L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2023), "4:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2024), "High Ball Shooter" },
                    { 224L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2026), "4:05", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2028), "The Gypsy" },
                    { 225L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2030), "3:14", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(2033), "Soldier of Fortune" },
                    { 197L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1920), "4:08", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1922), "Mansion on the Hill" },
                    { 129L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1637), "4:14", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1639), "Dreams" },
                    { 119L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1598), "3:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1600), "Gypsy Eyes" },
                    { 127L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1629), "5:06", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1631), "Voodoo Child (Slight Return)" },
                    { 70L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1008), "4:49", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1010), "Four Sticks" },
                    { 71L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1012), "3:36", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1014), "Going to California" },
                    { 72L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1018), "7:08", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1020), "When the Levee Breaks" },
                    { 47L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1023), "5:32", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1024), "The Song Remains the Same" },
                    { 48L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1027), "7:39", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1028), "The Rain Song" },
                    { 49L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1031), "4:50", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1032), "Over the Hills and Far Away" },
                    { 50L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1035), "3:17", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1036), "The Crunge" },
                    { 51L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1039), "3:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1040), "Dancing Days" },
                    { 52L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1043), "4:23", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1044), "D'yer Mak'er" },
                    { 53L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1047), "7:00", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1048), "No Quarter" },
                    { 54L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1051), "4:31", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1052), "The Ocean" },
                    { 73L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1055), "4:13", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1056), "Custard Pie" },
                    { 69L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1004), "4:39", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1006), "Misty Mountain Hop" },
                    { 74L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1059), "5:36", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1061), "The Rover" },
                    { 76L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1070), "4:01", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1072), "Houses of the Holy" },
                    { 77L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1076), "5:35", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1079), "Trampled Under Foot" },
                    { 78L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1082), "8:37", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1085), "Kashmir" },
                    { 79L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1088), "8:44", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1091), "In the Light" },
                    { 80L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1094), "2:06", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1097), "Bron-Yr-Aur" },
                    { 81L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1100), "5:14", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1103), "Down by the Seaside" },
                    { 82L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1106), "6:31", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1109), "Ten Years Gone" },
                    { 83L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1112), "3:36", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1115), "Night Flight" },
                    { 84L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1133), "4:06", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1142), "The Wanton Song" },
                    { 85L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1147), "3:51", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1150), "Boogie with Stu" },
                    { 86L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1153), "4:24", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1155), "Black Country Woman" },
                    { 87L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1163), "4:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1170), "Sick Again" },
                    { 75L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1064), "11:04", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1066), "In My Time of Dying" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 68L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1000), "7:55", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1002), "Stairway to Heaven" },
                    { 67L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(996), "5:51", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(998), "The Battle of Evermore" },
                    { 66L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(992), "3:40", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(994), "Rock and Roll" },
                    { 1L, new DateTime(2022, 8, 17, 16, 49, 35, 165, DateTimeKind.Local).AddTicks(8987), "2:46", null, new DateTime(2022, 8, 17, 16, 49, 35, 165, DateTimeKind.Local).AddTicks(9022), "Good Times Bad Times" },
                    { 2L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(695), "6:42", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(709), "Babe I'm Gonna Leave You" },
                    { 3L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(716), "6:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(718), "You Shook Me" },
                    { 4L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(721), "6:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(724), "Dazed and Confused" },
                    { 5L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(727), "4:34", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(729), "Your Time Is Gonna Come" },
                    { 6L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(738), "2:12", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(744), "Black Mountain Side" },
                    { 7L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(747), "2:30", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(749), "Communication Breakdown" },
                    { 8L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(752), "4:42", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(755), "I Can't Quit You Baby" },
                    { 9L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(758), "8:27", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(761), "How Many More Times" },
                    { 40L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(765), "5:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(768), "Whole Lotta Love" },
                    { 41L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(772), "4:33", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(774), "What Is and What Should Never Be" },
                    { 42L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(778), "4:21", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(780), "Thank You" },
                    { 43L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(784), "6:20", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(787), "The Lemon Song" },
                    { 44L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(791), " 4:14", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(793), "Heartbreaker" },
                    { 45L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(797), "2:39", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(800), "Living Loving Maid(She's Just a Woman)" },
                    { 46L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(803), "4:34", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(805), "Ramble On" },
                    { 55L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(809), "2:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(811), "Immigrant Song" },
                    { 56L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(815), "3:55", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(818), "Friends" },
                    { 57L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(822), "3:29", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(824), "Celebration Day" },
                    { 58L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(937), "7:25", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(948), "Since I've Been Loving You" },
                    { 59L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(957), "4:04", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(959), "Out on the Tiles" },
                    { 60L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(963), "4:58", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(965), "Gallows Pole" },
                    { 61L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(971), "3:12", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(973), "Tangerine" },
                    { 62L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(976), "5:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(977), "That's the Way" },
                    { 63L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(980), "4:20", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(982), "Bron-Y-Aur Stomp" },
                    { 64L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(984), "3:41", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(986), "Hats Off to (Roy) Harper" },
                    { 65L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(988), "4:55", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(990), "Black Dog" },
                    { 88L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1178), "4:03", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1186), "Rock and Roll" },
                    { 89L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1189), "3:49", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1192), "Celebration Day" },
                    { 90L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1195), "6:00", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1198), "The Song Remains the Same" },
                    { 91L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1201), "8:24", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1207), "The Rain Song" },
                    { 22L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1520), "4:14", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1521), "In Bloom" },
                    { 23L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1524), "3:39", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1525), "Come as You Are" },
                    { 24L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1528), "3:03", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1529), "Breed" },
                    { 25L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1532), "4:17", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1533), "Lithium" },
                    { 26L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1536), "2:57", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1537), "Polly" },
                    { 27L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1543), "2:22", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1545), "Territorial Pissings" },
                    { 28L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1547), "3:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1549), "Drain You" },
                    { 29L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1551), "2:36", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1553), "Lounge Act" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 30L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1555), "3:32", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1556), "Stay Away" },
                    { 31L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1559), "3:16", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1560), "On a Plain" },
                    { 32L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1563), "3:52", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1564), "Something in the Way" },
                    { 33L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1566), "6:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1568), "Endless, Nameless" },
                    { 21L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1516), "5:01", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1517), "Smells Like Teen Spirit" },
                    { 112L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1570), "1:19", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1572), "...And the Gods Made Love" },
                    { 114L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1578), "2:25", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1580), "Crosstown Traffic" },
                    { 115L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1582), "14:50", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1584), "Voodoo Chile" },
                    { 116L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1586), "2:47", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1588), "Little Miss Strange" },
                    { 117L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1590), "3:21", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1592), "Long Hot Summer Night" },
                    { 118L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1594), "4:04", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1596), "Come On (Part 1)" },
                    { 120L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1602), "3:33", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1604), "Burning of the Midnight Lamp" },
                    { 121L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1606), "3:39", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1608), "Rainy Day, Dream Away" },
                    { 122L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1610), "13:25", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1612), "1983... (A Merman I Should Turn to Be)" },
                    { 123L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1614), "0:58", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1615), "Moon, Turn the Tides....Gently Gently Away" },
                    { 124L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1618), "4:19", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1619), "Still Raining, Still Dreaming" },
                    { 125L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1622), "4:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1623), "House Burning Down" },
                    { 126L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1625), "3:54", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1627), "All Along the Watchtower" },
                    { 113L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1574), "2:08", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1576), "Have You Ever Been (To Electric Ladyland)" },
                    { 128L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1633), "2:43", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1635), "Second Hand News" },
                    { 20L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1512), "3:22", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1513), "Crazy Lady Blues" },
                    { 18L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1502), "2:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1505), "Wretched Wilbur" },
                    { 92L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1215), "26:53", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1221), "Dazed and Confused" },
                    { 93L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1227), "12:30", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1229), "No Quarter" },
                    { 94L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1232), "10:58", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1235), "Stairway to Heaven" },
                    { 95L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1238), "12:47", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1241), "Moby Dick" },
                    { 96L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1248), "14:24", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1255), "Whole Lotta Love" },
                    { 97L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1263), "10:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1266), "Achilles Last Stand" },
                    { 98L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1269), "6:21", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1272), "For Your Life" },
                    { 99L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1279), "2:58", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1301), "Royal Orleans" },
                    { 101L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1310), "6:27", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1313), "Nobody's Fault but Mine" },
                    { 102L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1317), "4:10", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1320), "Candy Store Rock" },
                    { 103L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1323), "4:42", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1326), "Hots On for Nowhere" },
                    { 104L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1331), "9:27", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1333), "Tea for One" },
                    { 19L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1508), "3:27", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1510), "The North Star Grassman and the Ravens" },
                    { 105L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1337), "6:48", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1339), "In the Evening" },
                    { 107L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1348), "6:08", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1350), "Fool in the Rain" },
                    { 108L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1352), "3:15", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1354), "Hot Dog" },
                    { 109L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1356), "10:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1358), "Carouselambra" },
                    { 110L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1360), "5:51", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1362), "All My Love" },
                    { 111L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1364), "5:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1366), "I'm Gonna Crawl" },
                    { 10L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1368), "4:28", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1370), "Late November" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 11L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1372), "4:07", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1374), "Blackwaterside(Traditional) " },
                    { 12L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1377), "3:09", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1378), "The Sea Captain" },
                    { 13L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1380), "3:20", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1382), "Down in the Flood(Bob Dylan)" },
                    { 14L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1385), "4:38", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1386), "John the Gun" },
                    { 15L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1389), "4:26", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1390), "Next Time Around" },
                    { 16L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1393), "3:24", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1394), "The Optimist" },
                    { 17L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1397), "2:42", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1398), "Let’s Jump the Broomstick(Charles Robins)" },
                    { 106L, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1342), "4:11", null, new DateTime(2022, 8, 17, 16, 49, 35, 166, DateTimeKind.Local).AddTicks(1345), "South Bound Saurez" }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 17, 16, 49, 35, 143, DateTimeKind.Local).AddTicks(1022), new DateTime(2022, 8, 17, 16, 49, 35, 143, DateTimeKind.Local).AddTicks(1040), "Island Studios London, Sound Techniques London" },
                    { 2, new DateTime(2022, 8, 17, 16, 49, 35, 143, DateTimeKind.Local).AddTicks(2408), new DateTime(2022, 8, 17, 16, 49, 35, 143, DateTimeKind.Local).AddTicks(2426), "914 Sound Studios, Blauvelt, New York" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "AddedDate", "CountryId", "DisbandYear", "FormationYear", "ModifiedDate", "Name", "Photo" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(3800), 1, 1980, 1967, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(3839), "Led Zeppelin", "458eb53a-aba7-42a2-a5ed-526da552966e.jpg" },
                    { 11L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9475), 2, null, 1977, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9478), "Simple Minds", "2a39824d-1c56-46fe-b4bc-b7e87dfb7bb3.jpg" },
                    { 8L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9450), 3, null, 1986, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9453), "Manic Street Preachers", "8117dfa2-41a4-4be1-a33f-fd7484ae5d7a.jpg" },
                    { 3L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9237), 5, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9243), "Bruce Springsteen", "32ce9c93-9129-4bff-b166-db5ada039757.jpg" },
                    { 4L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9249), 5, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9251), "John Denver", "f94fb03e-c368-4562-9c66-2b2db5722252.jpg" },
                    { 7L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9439), 5, null, 1962, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9444), "Bob Dylan", "567552b5-27d5-4a6e-acc5-449017fcd47e.jpg" },
                    { 17L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9535), 5, null, 1987, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9539), "Nirvana", "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
                    { 19L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9560), 5, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9566), "Tori Amos", "22d853a2-cd81-4362-a6a5-d15c17c83194.jpg" },
                    { 14L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9500), 6, null, 1973, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9502), "ACDC", "85d9174f-1f0d-4221-8635-f86c211caa4d.jpg" },
                    { 20L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9574), 1, null, 1975, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9577), "U2", "af794a29-19e8-440f-a5e2-113319932b40.jpg" },
                    { 15L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9509), 5, 1970, 1961, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9516), "Jimi Hendrix", "f304b989-f26e-4aa5-8c78-1d1b49850bee.jpg" },
                    { 16L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9525), 1, null, 1967, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9531), "Fleetwood Mac", "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
                    { 13L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9489), 1, null, 1975, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9496), "Motorhead", "2691c7fa-2546-401e-a10b-1608e00711d2.jpg" },
                    { 12L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9483), 1, null, 1968, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9485), "Deep Purple", "5863254c-693f-43e3-b0f8-a7ebdeb8ec33.jpg" },
                    { 10L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9467), 1, null, 1974, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9470), "The Stranglers", "8b728b1e-c506-4d08-b87d-9f320f4cc920.jpg" },
                    { 9L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9457), 1, null, 1979, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9461), "Ozzy Osbourne", "99cc2dbe-5671-4eca-947d-8f7a4f1759af.jpg" },
                    { 6L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9274), 1, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9277), "John Lennon", "e0ceb7ed-5481-4cc1-926f-59cf31fd2e69.jpg" },
                    { 18L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9550), 1, null, 1975, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9556), "Kate Bush", "909e5592-09a3-4018-a3a8-e067612c7388.jpg" },
                    { 5L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9256), 1, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9262), "Elton John", "64fa7eb5-dca2-4ed3-a465-fa6904bba895.jpg" },
                    { 2L, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9205), 1, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 145, DateTimeKind.Local).AddTicks(9225), "Sandy Denny", "0ed76f7d-e5da-4e5b-87b0-a8ecb4a165cd.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 42, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6701), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6704), "Bexleyheath, Kent" },
                    { 43, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6707), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6711), "Newton, North Carolina" },
                    { 44, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6718), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6723), "Dublin, Ireland" },
                    { 45, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6729), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6734), "Barking, Essex" },
                    { 46, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6741), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6745), "Chinnor, Oxfordshire" },
                    { 47, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6751), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6758), "Artane, Dublin" },
                    { 22, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6424), 2, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6426), "Toryglen, Glasgow" },
                    { 6, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6315), 3, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6318), "Pontypool" },
                    { 24, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6444), 2, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6450), "Dundee" },
                    { 26, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6458), 3, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6461), "Brecon" },
                    { 41, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6695), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6698), "Warren, Ohio" },
                    { 5, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6307), 5, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6310), "Seattle" },
                    { 10, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6344), 5, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6347), "Long Branch, New Jersey" },
                    { 11, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6351), 5, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6353), "Monterey Bay" },
                    { 15, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6373), 5, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6375), "Duluth, Minnesota" },
                    { 23, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6430), 2, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6436), "Glasgow" },
                    { 40, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6690), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6692), "Compton, California" },
                    { 34, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6628), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6636), "Redruth, Cornwall, Gateshead" },
                    { 38, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6669), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6673), "Palo Alto, California" },
                    { 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(4417), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(4454), "Aston, Birmingham" },
                    { 2, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6261), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6281), "Birmingham" },
                    { 3, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6289), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6293), "West Bromwich" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6300), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6303), "Heston" },
                    { 7, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6321), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6323), "Sidcup" },
                    { 8, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6331), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6333), "Reddich" },
                    { 9, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6336), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6340), "Merton Park, London" },
                    { 12, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6356), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6358), "Pinner, Middlesex" },
                    { 13, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6361), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6363), "Liverpool, Lancashire" },
                    { 16, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6379), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6381), "Marston Green, Warwickshire" },
                    { 17, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6384), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6387), "Tufnell Park, North London" },
                    { 18, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6396), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6403), "Notting Hill, London" },
                    { 19, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6412), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6416), "Brighton, London" },
                    { 21, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6419), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6421), "Ilford, Essex" },
                    { 25, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6453), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6456), "Nottingham" },
                    { 27, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6464), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6467), "Chiswick, London" },
                    { 28, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6471), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6474), "Stoke-on-Trent, Staffordshire" },
                    { 29, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6478), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6481), "London" },
                    { 30, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6484), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6487), "Twickenham, Middlesex" },
                    { 32, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6504), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6508), "Romford, Essex" },
                    { 33, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6515), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6517), "Dunston, Gateshead" },
                    { 31, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6496), 6, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6498), "Melbourne, Victoria" },
                    { 35, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6646), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6650), "Phoenix, Arizona" },
                    { 36, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6655), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6661), "Ealing, Middlesex" },
                    { 37, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6664), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6666), "Bouth, Lancashire" },
                    { 39, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6680), 1, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6686), "Aberdeen, Washington" },
                    { 14, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6367), 7, new DateTime(2022, 8, 17, 16, 49, 35, 142, DateTimeKind.Local).AddTicks(6369), "Vancover" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AddedDate", "Arrangers", "ArtistId", "Artwork", "Engineers", "LabelId", "Length", "ModifiedDate", "Name", "Photo", "Producers", "RecordedDate", "ReleaseDate", "StudioId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(3033), null, 1L, null, null, 1, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(3064), "Led Zeppelin 1", "11d15486-fefc-463c-8b7d-c755b08466dc.jpg", null, null, new DateTime(1969, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8665), null, 3L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8667), "Nebraska", "6e2e5c69-75cd-480e-9b28-6d3726df576f.jpg", null, null, null, null },
                    { 21L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8673), null, 12L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8674), "Stormbringer", "d96d1eac-982a-41a2-b2dd-ff65707940e1.jpg", null, null, null, null },
                    { 22L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8677), null, 7L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8678), "Nashville Skyline", "722792d3-787b-4698-916d-0ff766e68fd6.jpg", null, null, null, null },
                    { 15L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8652), null, 3L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8653), "Darkness on the Edge of Town", "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg", null, null, null, null },
                    { 11L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8545), null, 15L, null, null, 8, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8547), "Electric Ladyland", "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg", null, null, new DateTime(1968, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8646), null, 3L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8649), "Born To Run", "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg", null, null, null, null },
                    { 17L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8660), null, 10L, null, null, 9, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8661), "The Raven", "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg", null, null, new DateTime(1979, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8685), null, 17L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8686), "Nevermind", "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg", null, null, new DateTime(1991, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8656), null, 9L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8657), "Bark At The Moon", "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg", null, null, null, null },
                    { 12L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8550), null, 16L, null, null, null, "39:43", new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8552), "Rumours", "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg", "Fleetwood Mac, Ken Caillat, Richard Dashut", null, new DateTime(1977, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8555), null, 3L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8556), "The River", "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg", null, null, null, null },
                    { 20L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8669), null, 13L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8671), "Iron Fist", "39c3f690-87cd-4cd2-8a9a-54ba8af3a50f.jpg", null, null, null, null },
                    { 2L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(6612), "Sandy Denny", 2L, "Keef", "John Wood", 7, "39:41", new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(6629), "The North Star Grassman and the Ravens", "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg", "John Wood, Richard Thompson, Sandy Denny", new DateTime(1971, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8541), null, 1L, null, null, 2, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8543), "In Through The OutDoor", "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg", null, null, new DateTime(1979, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8536), null, 1L, null, null, 2, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8537), "Presence", "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg", null, null, new DateTime(1976, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8531), null, 1L, null, null, 2, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8533), "The Song Remains The Same", "d2710986-0720-4231-8582-4383eb9ffe12.jpg", null, null, new DateTime(1976, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8527), null, 1L, null, null, 2, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8528), "Physical Graffiti", "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg", null, null, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8522), null, 1L, null, null, 1, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8524), "Houses of the Holy", "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg", null, null, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8512), null, 1L, null, null, 1, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8514), "Led Zeppelin IV", "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg", null, null, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8508), null, 1L, null, null, 1, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8509), "Led Zeppelin 3", "9cf368d3-db16-4120-af40-7dd697b934fa.jpg", null, null, new DateTime(1970, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8490), null, 1L, null, null, 1, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8501), "Led Zeppelin 2", "ee552af1-7a5a-457b-b336-823bc1285dac.jpg", null, null, new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8681), null, 3L, null, null, null, null, new DateTime(2022, 8, 17, 16, 49, 35, 158, DateTimeKind.Local).AddTicks(8682), "Born In The Usa", "66c0e775-c22b-427d-a327-e6bfd9b5673e.jpg", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 13L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2628), 8L, 6L, null, new DateTime(1968, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sean", true, "Anthony", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2629), "18bc8103-9380-4bde-ae46-01b8160887a3.jpg", "Sean Moore", "Moore" },
                    { 11L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2617), 8L, 6L, null, new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Dean", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2619), "3d39a220-fd12-4533-adcb-7741b0c4f8ab.jpg", "James Dean Bradfield", "Bradfield" },
                    { 21L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2664), 11L, 24L, null, new DateTime(1962, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ged", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2666), "4b9eee24-56a3-493f-9dfa-3159a80396fd.jpg", "Ged Grimes", "Grimes" },
                    { 20L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2659), 11L, 23L, null, new DateTime(1959, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2661), "83a85c7e-609d-420a-b380-d2ff190a452a.jpg", "Charlie Burchill", "Burchill" },
                    { 12L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2623), 8L, 6L, null, new DateTime(1969, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicholas", true, "Allen", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2625), "450e17c5-c352-452f-a1d8-4b6c4154cf9d.jpg", "Nicky Wire", "Jones" },
                    { 47L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2823), 15L, 14L, null, new DateTime(1942, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", true, "Allen", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2828), "9a7bff27-93b5-43cf-8fed-743074f6182b.jpg", "Jimi Hendrix", "Hendrix" },
                    { 7L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2515), 4L, 11L, null, new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2517), "08dc96d6-bbe4-429d-90b6-094b04ae8f9d.jpg", "John Denver", "Denver" },
                    { 10L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2530), 7L, 15L, null, new DateTime(1941, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Allen", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2532), "bb655ce4-9a14-4805-b6d3-9f84a26a250a.jpg", "Bob Dylan", "Zimmerman" },
                    { 19L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2655), 11L, 22L, null, new DateTime(1959, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2657), "60267eb0-f2f5-48c8-b245-83df9a7986bd.jpg", "Jim Kerr", "Kerr" },
                    { 38L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2743), 17L, 39L, null, new DateTime(1967, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurt", true, "Donald", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2746), "10ec8163-a6de-4c64-bd80-3a949886905e.jpg", "Kurt Cobain", "Cobain" },
                    { 39L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2750), 17L, 40L, null, new DateTime(1965, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Krist", true, "Anthony", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2753), "657837dd-f7c1-4ed5-a58e-39cc0e279d83.jpg", "Krist Novoselic", "Novoselic" },
                    { 40L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2756), 17L, 41L, null, new DateTime(1969, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Eric", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2758), "7dd70c41-8fcf-4cd1-a825-78fb30c7c0ca.jpg", "Dave Grohl", "Grohl" },
                    { 42L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2769), 19L, 43L, null, new DateTime(1963, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Myra", true, "Ellen", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2771), "d4f764a9-75d6-44ff-9263-94d2cd30703e.jpg", "Tori Amos", "Amos" },
                    { 28L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2694), 14L, 23L, null, new DateTime(1955, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Angus", true, "McKinnon", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2696), "273cc6e3-995f-44ef-9665-4b06d76ce7eb.jpg", "Angus Young", "Young" },
                    { 29L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2700), 14L, 23L, null, new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malcolm", true, "Mitchell", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2701), "c79c5ae5-8678-488d-a9f0-6bc18e83abb3.jpg", "Malcolm Young", "Young" },
                    { 30L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2704), 14L, 29L, null, new DateTime(1954, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phillip", true, "Hugh Norman Witschke", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2706), "44b350e7-ed7f-4e3c-b6e1-5b286836e383.jpg", "Phil Rudd", "Rudzevecuis" },
                    { 6L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2502), 3L, 10L, null, new DateTime(1949, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2511), "734770c0-05f1-4bd9-ae4b-748cbdc64167.jpg", "Bruce Springsteen", "Springsteen" },
                    { 46L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2795), 20L, 47L, null, new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lawrence", true, " Joseph", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2798), "9f24c9d9-6b23-4594-bdf3-f71da4311af7.jpg", "Larry Mullen Jr.", "Mullen Jr." },
                    { 34L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2722), 16L, 35L, null, new DateTime(1948, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie", true, "Lynn", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2724), "88153d6b-9d63-4f87-b49b-a660683f7adf.jpg", "Stevie Nicks", "Nicks" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 44L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2783), 20L, 45L, null, new DateTime(1961, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Howell", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2785), "7ad787f2-d136-4d35-9fbf-be9bcddd34c3.jpg", "The Edge", "Evans" },
                    { 1L, new DateTime(2022, 8, 17, 16, 49, 35, 155, DateTimeKind.Local).AddTicks(7187), 1L, 4L, null, new DateTime(1944, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Patrick", new DateTime(2022, 8, 17, 16, 49, 35, 155, DateTimeKind.Local).AddTicks(7246), "a0033bc9-c0b8-4248-8e31-f9d3938e1e34.jpg", "Jimmy Page", "Page" },
                    { 2L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2047), 1L, 3L, null, new DateTime(1948, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Anthony", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2076), "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg", "Robert Plant", "Plant" },
                    { 3L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2089), 1L, 7L, null, new DateTime(1946, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Jones", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2091), "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg", "John Paul Jones", "Paul" },
                    { 4L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2094), 1L, 8L, null, new DateTime(1948, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Bonham", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2096), "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg", "John Bonham", "Henry" },
                    { 5L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2100), 2L, 9L, null, new DateTime(1947, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandra", true, "Elene MacLean", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2102), "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg", "Sandy Denny", "Denny" },
                    { 8L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2520), 5L, 12L, null, new DateTime(1947, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elton", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2521), "06cb3132-accb-4b58-a532-47bb49bdc29b.jpg", "Elton John", "John" },
                    { 9L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2524), 6L, 13L, null, new DateTime(1940, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2526), "69e916a9-94e6-47ce-9762-1ca6650fa434.jpg", "John Lennon", "Lennon" },
                    { 14L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2632), 9L, 16L, null, new DateTime(1948, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Michael", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2634), "9366d83c-e30d-47ab-924e-f61a42d17efe.jpg", "Ozzy Osbourne", "Osbourne" },
                    { 15L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2636), 10L, 17L, null, new DateTime(1949, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hugh", true, "Alan", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2638), "e962871a-23ec-4049-a772-d5ef262c9adb.jpg", "Hugh Cornwell", "Cornwell" },
                    { 16L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2641), 10L, 18L, null, new DateTime(1952, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Jacques", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2642), "f5fc3019-2a61-4d80-b071-351845c5992c.jpg", "Jean-Jacques Burnel", "Burnel" },
                    { 17L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2645), 10L, 19L, null, new DateTime(1949, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", true, "Paul", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2646), "8f567b5f-7982-44d9-b4b5-e9337595f8e1.jpg", "David Greenfield", "Greenfield" },
                    { 18L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2651), 10L, 21L, null, new DateTime(1938, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "John", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2652), "9833b134-75c7-456a-a1d2-f5a286dc892e.jpg", "Jet Black", "Duffy" },
                    { 22L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2668), 12L, 25L, null, new DateTime(1948, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, "Anderson", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2670), "5166d6e2-42a6-44f6-bbca-ffb41733ef48.jpg", "Ian Paice", "Paice" },
                    { 23L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2673), 12L, 26L, null, new DateTime(1945, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", true, "David", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2674), "85717e2f-36bf-4c2b-8920-f42c90817ce8.jpg", "Roger Glover", "Glover" },
                    { 24L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2677), 12L, 27L, null, new DateTime(1945, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2679), "883f0129-b075-454d-a68c-e3d7f07bbdda.jpg", "Ian Gillan", "Gillan" },
                    { 25L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2681), 13L, 28L, null, new DateTime(1954, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian", true, "Fraser", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2683), "1a7a6266-a256-4b08-87f0-640d8e3ace60.jpg", "Lemmy", "Kilmister" },
                    { 26L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2685), 13L, 29L, null, new DateTime(1954, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", true, "John", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2687), "04f9d8e6-1b84-4a0a-800e-1716732aaf5e.jpg", "Phil 'Philthy Animal' Taylor", "Taylor" },
                    { 27L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2690), 13L, 30L, null, new DateTime(1950, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", true, "Allan", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2691), "1dbe7e17-567f-4f12-883d-b253ef2d25a2.jpg", "'Fast' Eddie Clarke", "Clarke" },
                    { 33L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2717), 16L, 34L, null, new DateTime(1947, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", true, "John Kells", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2719), "75ce147a-b9e9-49f4-8a71-c4f36dc9d3cd.jpg", "Mick Fleetwood", "Fleetwood" },
                    { 31L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2708), 14L, 32L, null, new DateTime(1949, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clifford", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2710), "0445ae2a-a3ef-4636-9850-2c4420d5f91e.jpg", "Cliff Williams", "Williams" },
                    { 35L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2726), 16L, 36L, null, new DateTime(1945, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Graham", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2728), "8c1fc01a-79e2-479c-b92d-ec6f9ba9135d.jpg", "John McVie", "McVie" },
                    { 36L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2732), 16L, 37L, null, new DateTime(1943, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christine", true, "Anne", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2734), "1fa68d08-2072-47cc-ad2b-96a27af42351.jpg", "Christine McVie", "Perfect" },
                    { 37L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2737), 16L, 38L, null, new DateTime(1949, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lindsey", true, "Adams", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2739), "8154868a-c01d-49e4-85d1-f85c0b0c9302.jpg", "Lindsey Buckingham", "Buckingham" },
                    { 41L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2762), 18L, 42L, null, new DateTime(1958, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catherine", true, null, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2764), "dfdae93a-d393-41e9-ba05-78970f0b1ee1.jpg", "Kate Bush", "Bush" },
                    { 43L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2776), 20L, 44L, null, new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", true, "David", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2778), "5b1d901a-ad92-40ad-8439-af151e472b5d.jpg", "Bono", "Hewson" },
                    { 45L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2789), 20L, 46L, null, new DateTime(1960, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adam", true, "Charles", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2792), "73375c6c-cd17-41c4-824c-c5f8af912a28.jpg", "Adam Clayton", "Clayton" },
                    { 32L, new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2713), 14L, 33L, null, new DateTime(1947, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "Francis", new DateTime(2022, 8, 17, 16, 49, 35, 156, DateTimeKind.Local).AddTicks(2714), "3ab89167-5769-478e-95a8-29277316e028.jpg", "Brian Johnson", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(8001), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(8041), 1, 1, 1L },
                    { 152L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(256), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(258), 6, 2, 149L },
                    { 153L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(260), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(261), 1, 3, 150L },
                    { 154L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(264), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(265), 2, 3, 151L },
                    { 155L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(268), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(269), 3, 3, 152L },
                    { 156L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(271), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(273), 4, 3, 153L },
                    { 157L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(275), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(277), 5, 3, 154L },
                    { 158L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(279), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(281), 1, 4, 155L },
                    { 159L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(283), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(285), 2, 4, 156L },
                    { 160L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(287), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(289), 3, 4, 157L },
                    { 161L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(291), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(292), 4, 4, 158L },
                    { 250L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(657), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(659), 1, 1, 248L },
                    { 251L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(661), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(663), 2, 1, 249L },
                    { 151L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(252), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(254), 5, 2, 148L },
                    { 252L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(665), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(667), 3, 1, 250L },
                    { 254L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(673), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(674), 1, 2, 252L },
                    { 255L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(677), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(679), 2, 2, 253L },
                    { 256L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(681), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(682), 3, 2, 254L },
                    { 257L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(685), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(686), 4, 2, 255L },
                    { 168L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(295), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(296), 1, 1, 166L },
                    { 169L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(298), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(300), 2, 1, 167L },
                    { 170L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(303), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(305), 3, 1, 168L },
                    { 171L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(307), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(309), 4, 1, 169L },
                    { 172L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(311), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(313), 5, 1, 170L },
                    { 173L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(315), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(316), 1, 2, 171L },
                    { 174L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(319), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(320), 2, 2, 172L },
                    { 175L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(322), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(324), 3, 2, 173L },
                    { 253L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(669), 14L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(671), 4, 1, 251L },
                    { 176L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(326), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(328), 4, 2, 174L },
                    { 150L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(248), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(250), 4, 2, 147L },
                    { 148L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(241), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(242), 2, 2, 145L },
                    { 210L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(505), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(506), 4, 1, 208L },
                    { 211L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(508), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(510), 5, 1, 209L },
                    { 212L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(512), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(514), 6, 1, 210L },
                    { 213L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(516), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(518), 1, 2, 211L },
                    { 214L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(520), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(521), 2, 2, 212L },
                    { 215L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(524), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(525), 3, 2, 213L },
                    { 216L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(528), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(529), 4, 2, 214L },
                    { 217L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(531), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(533), 5, 2, 215L },
                    { 218L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(535), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(537), 6, 2, 216L },
                    { 131L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(176), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(177), 1, 1, 128L },
                    { 132L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(180), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(181), 2, 1, 129L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 133L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(183), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(185), 3, 1, 130L },
                    { 149L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(245), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(246), 3, 2, 146L },
                    { 134L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(187), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(189), 4, 1, 131L },
                    { 136L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(195), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(196), 6, 1, 133L },
                    { 137L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(198), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(200), 1, 2, 134L },
                    { 138L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(202), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(204), 2, 2, 135L },
                    { 139L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(206), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(208), 3, 2, 136L },
                    { 140L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(211), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(212), 4, 2, 137L },
                    { 141L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(214), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(216), 5, 2, 138L },
                    { 142L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(218), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(220), 1, 1, 139L },
                    { 143L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(222), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(223), 2, 1, 140L },
                    { 144L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(226), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(227), 3, 1, 141L },
                    { 145L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(230), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(231), 4, 1, 142L },
                    { 146L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(233), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(235), 5, 1, 143L },
                    { 147L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(237), 13L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(239), 1, 2, 144L },
                    { 135L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(191), 12L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(192), 5, 1, 132L },
                    { 177L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(330), 15L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(332), 5, 2, 175L },
                    { 197L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(455), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(456), 1, 1, 195L },
                    { 198L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(458), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(460), 2, 1, 196L },
                    { 116L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(119), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(121), 2, 1, 113L },
                    { 117L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(123), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(124), 3, 1, 114L },
                    { 118L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(127), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(128), 4, 1, 115L },
                    { 119L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(130), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(132), 1, 2, 116L },
                    { 120L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(134), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(136), 2, 2, 117L },
                    { 121L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(138), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(140), 3, 2, 118L },
                    { 122L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(142), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(143), 4, 2, 119L },
                    { 123L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(146), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(147), 5, 2, 120L },
                    { 124L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(149), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(151), 3, 3, 121L },
                    { 125L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(153), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(155), 4, 3, 122L },
                    { 126L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(157), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(159), 1, 3, 123L },
                    { 127L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(161), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(162), 1, 4, 124L },
                    { 115L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(115), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(117), 1, 1, 112L },
                    { 128L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(165), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(166), 2, 4, 125L },
                    { 130L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(172), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(174), 4, 4, 127L },
                    { 21L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9673), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9674), 1, 1, 21L },
                    { 22L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9677), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9678), 2, 1, 22L },
                    { 23L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9681), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9682), 3, 1, 23L },
                    { 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9685), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9686), 4, 1, 24L },
                    { 25L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9688), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9690), 5, 1, 25L },
                    { 26L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9692), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9694), 6, 1, 26L },
                    { 27L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9696), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9698), 1, 2, 27L },
                    { 28L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9700), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9702), 2, 2, 28L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 29L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9774), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9777), 3, 2, 29L },
                    { 30L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9780), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9781), 4, 2, 30L },
                    { 31L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9784), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9785), 5, 2, 31L },
                    { 129L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(168), 11L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(170), 3, 4, 126L },
                    { 237L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(608), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(610), 5, 2, 235L },
                    { 236L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(604), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(606), 4, 2, 234L },
                    { 235L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(600), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(602), 3, 2, 233L },
                    { 199L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(462), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(464), 3, 1, 197L },
                    { 200L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(466), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(467), 4, 1, 198L },
                    { 201L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(470), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(471), 5, 1, 199L },
                    { 202L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(473), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(475), 6, 1, 200L },
                    { 203L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(477), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(479), 1, 2, 201L },
                    { 204L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(481), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(483), 2, 2, 202L },
                    { 205L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(485), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(487), 3, 2, 203L },
                    { 206L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(489), 19L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(490), 4, 2, 204L },
                    { 238L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(612), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(613), 1, 1, 236L },
                    { 239L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(615), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(617), 2, 1, 237L },
                    { 240L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(619), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(621), 3, 1, 238L },
                    { 241L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(623), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(625), 4, 1, 239L },
                    { 242L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(627), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(628), 5, 1, 240L },
                    { 243L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(631), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(632), 6, 1, 241L },
                    { 244L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(634), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(636), 1, 2, 242L },
                    { 245L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(638), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(640), 2, 2, 243L },
                    { 246L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(642), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(644), 3, 2, 244L },
                    { 247L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(646), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(648), 4, 2, 245L },
                    { 248L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(650), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(651), 5, 2, 246L },
                    { 249L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(654), 23L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(655), 6, 2, 247L },
                    { 228L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(574), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(575), 1, 1, 226L },
                    { 229L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(578), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(579), 2, 1, 227L },
                    { 230L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(581), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(583), 3, 1, 228L },
                    { 231L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(585), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(587), 4, 1, 229L },
                    { 232L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(589), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(591), 5, 1, 230L },
                    { 233L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(593), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(594), 1, 2, 231L },
                    { 234L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(597), 22L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(598), 2, 2, 232L },
                    { 209L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(501), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(503), 3, 1, 207L },
                    { 34L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9787), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9789), 6, 2, 32L },
                    { 208L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(497), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(499), 2, 1, 206L },
                    { 227L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(570), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(572), 5, 2, 225L },
                    { 73L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9911), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9912), 3, 2, 70L },
                    { 74L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9915), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9916), 3, 2, 71L },
                    { 75L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9919), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9921), 4, 2, 72L },
                    { 50L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9822), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9824), 1, 1, 47L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 51L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9827), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9829), 2, 1, 48L },
                    { 52L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9831), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9833), 3, 1, 49L },
                    { 53L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9835), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9837), 4, 1, 50L },
                    { 54L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9839), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9840), 1, 2, 51L },
                    { 55L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9843), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9844), 2, 2, 52L },
                    { 56L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9846), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9848), 3, 2, 53L },
                    { 57L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9850), 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9852), 4, 2, 54L },
                    { 76L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9923), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9925), 1, 1, 73L },
                    { 72L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9907), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9909), 2, 2, 69L },
                    { 77L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9927), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9928), 2, 1, 74L },
                    { 79L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9934), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9936), 1, 2, 76L },
                    { 80L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9938), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9940), 2, 2, 77L },
                    { 81L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9942), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9943), 3, 2, 78L },
                    { 82L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9946), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9947), 1, 3, 79L },
                    { 83L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9949), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9951), 2, 3, 80L },
                    { 84L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9953), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9955), 3, 3, 81L },
                    { 85L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9957), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9959), 4, 3, 82L },
                    { 86L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9961), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9962), 1, 4, 83L },
                    { 87L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9965), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9966), 2, 4, 84L },
                    { 88L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9969), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9971), 3, 4, 85L },
                    { 89L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9973), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9975), 4, 4, 86L },
                    { 90L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9977), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9979), 5, 4, 87L },
                    { 78L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9931), 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9932), 3, 1, 75L },
                    { 91L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9981), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9982), 1, 1, 88L },
                    { 71L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9903), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9905), 4, 1, 68L },
                    { 69L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9896), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9897), 2, 1, 66L },
                    { 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9583), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9593), 2, 1, 2L },
                    { 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9596), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9598), 3, 1, 3L },
                    { 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9600), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9602), 4, 1, 4L },
                    { 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9604), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9606), 5, 2, 5L },
                    { 6L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9614), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9616), 6, 2, 6L },
                    { 7L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9618), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9619), 7, 2, 7L },
                    { 8L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9622), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9623), 8, 2, 8L },
                    { 9L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9625), 1L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9627), 9, 2, 9L },
                    { 43L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9796), 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9797), 1, 1, 40L },
                    { 44L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9799), 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9801), 2, 1, 41L },
                    { 45L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9803), 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9805), 4, 1, 42L },
                    { 46L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9807), 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9809), 3, 1, 43L },
                    { 70L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9900), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9901), 3, 1, 67L },
                    { 47L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9811), 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9813), 1, 2, 44L },
                    { 49L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9819), 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9820), 3, 2, 46L },
                    { 58L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9854), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9855), 1, 1, 55L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 59L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9858), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9859), 2, 1, 56L },
                    { 60L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9861), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9863), 3, 1, 57L },
                    { 61L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9865), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9867), 4, 1, 58L },
                    { 62L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9869), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9871), 5, 1, 59L },
                    { 63L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9873), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9875), 1, 2, 60L },
                    { 64L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9877), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9878), 2, 2, 61L },
                    { 65L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9880), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9882), 3, 2, 62L },
                    { 66L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9884), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9886), 4, 2, 63L },
                    { 67L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9888), 4L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9890), 5, 2, 64L },
                    { 68L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9892), 5L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9893), 1, 1, 65L },
                    { 48L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9815), 3L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9816), 2, 2, 45L },
                    { 92L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9985), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9986), 2, 1, 89L },
                    { 93L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9988), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9990), 3, 1, 90L },
                    { 94L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9992), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9994), 4, 1, 91L },
                    { 179L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(338), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(339), 2, 1, 177L },
                    { 180L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(342), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(343), 3, 1, 178L },
                    { 181L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(345), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(347), 4, 1, 179L },
                    { 182L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(349), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(351), 1, 2, 180L },
                    { 183L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(353), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(355), 2, 2, 181L },
                    { 184L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(357), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(358), 3, 2, 182L },
                    { 185L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(361), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(362), 4, 2, 183L },
                    { 186L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(364), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(366), 1, 1, 184L },
                    { 187L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(368), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(370), 2, 1, 185L },
                    { 188L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(372), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(374), 3, 1, 186L },
                    { 189L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(376), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(378), 4, 1, 187L },
                    { 190L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(427), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(429), 5, 1, 188L },
                    { 178L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(334), 16L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(336), 1, 1, 176L },
                    { 191L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(432), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(434), 6, 1, 189L },
                    { 193L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(440), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(441), 2, 2, 191L },
                    { 194L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(443), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(445), 3, 2, 192L },
                    { 195L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(447), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(449), 4, 2, 193L },
                    { 196L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(451), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(452), 5, 2, 194L },
                    { 219L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(539), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(541), 1, 1, 217L },
                    { 220L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(543), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(544), 2, 1, 218L },
                    { 221L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(546), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(548), 3, 1, 219L },
                    { 222L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(550), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(552), 4, 1, 220L },
                    { 223L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(554), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(556), 1, 2, 221L },
                    { 224L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(558), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(559), 2, 2, 222L },
                    { 225L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(562), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(563), 3, 2, 223L },
                    { 226L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(566), 21L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(568), 4, 2, 224L },
                    { 192L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(436), 17L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(437), 1, 2, 190L },
                    { 20L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9669), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9671), 11, 2, 20L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 19L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9665), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9667), 10, 2, 19L },
                    { 18L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9661), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9663), 9, 2, 18L },
                    { 95L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9996), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9998), 1, 2, 92L },
                    { 96L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(2), 1, 3, 93L },
                    { 97L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(4), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(5), 2, 3, 94L },
                    { 98L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(8), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(9), 1, 4, 95L },
                    { 99L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(11), 8L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(13), 2, 4, 96L },
                    { 100L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(15), 9L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(17), 1, 1, 97L },
                    { 102L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(19), 9L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(20), 2, 1, 98L },
                    { 103L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(23), 9L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(24), 3, 1, 99L },
                    { 104L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(26), 9L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(28), 1, 2, 101L },
                    { 105L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(30), 9L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(32), 2, 2, 102L },
                    { 106L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(34), 9L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(36), 3, 2, 103L },
                    { 107L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(38), 9L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(39), 4, 2, 104L },
                    { 108L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(42), 10L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(44), 1, 1, 105L },
                    { 109L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(46), 10L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(48), 2, 1, 106L },
                    { 110L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(50), 10L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(52), 3, 1, 107L },
                    { 111L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(54), 10L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(55), 4, 1, 108L },
                    { 112L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(58), 10L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(59), 1, 2, 109L },
                    { 113L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(61), 10L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(63), 2, 2, 110L },
                    { 114L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(110), 10L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(112), 3, 2, 111L },
                    { 10L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9630), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9632), 1, 1, 10L },
                    { 11L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9634), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9636), 2, 1, 11L },
                    { 12L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9638), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9639), 3, 1, 12L },
                    { 13L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9642), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9643), 4, 1, 13L },
                    { 14L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9645), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9647), 5, 1, 14L },
                    { 15L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9649), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9651), 6, 2, 15L },
                    { 16L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9653), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9654), 7, 2, 16L },
                    { 17L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9657), 2L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9658), 8, 2, 17L },
                    { 207L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(493), 20L, new DateTime(2022, 8, 17, 16, 49, 35, 178, DateTimeKind.Local).AddTicks(495), 1, 1, 205L },
                    { 35L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9791), 24L, new DateTime(2022, 8, 17, 16, 49, 35, 177, DateTimeKind.Local).AddTicks(9793), 7, 2, 33L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_LabelId",
                table: "Albums",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_StudioId",
                table: "Albums",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumSongs_AlbumId",
                table: "AlbumSongs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumSongs_SongId",
                table: "AlbumSongs",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_CountryId",
                table: "Artists",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BirthPlaces_CountryId",
                table: "BirthPlaces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_ArtistId",
                table: "Members",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_BirthPlaceId1",
                table: "Members",
                column: "BirthPlaceId1");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_AccountId",
                table: "RefreshTokens",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_MemberId",
                table: "Songs",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SongWriter_SongId",
                table: "SongWriter",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumSongs");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "SongWriter");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "RecordLabels");

            migrationBuilder.DropTable(
                name: "Studios");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "BirthPlaces");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
