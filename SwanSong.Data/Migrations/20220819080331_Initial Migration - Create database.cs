using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SwanSong.Data.Migrations
{
    public partial class InitialMigrationCreatedatabase : Migration
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
                    { 1, new DateTime(2022, 8, 19, 9, 3, 30, 208, DateTimeKind.Local).AddTicks(3587), new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(8382), "England" },
                    { 2, new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9327), new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9337), "Scotland" },
                    { 3, new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9341), new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9343), "Wales" },
                    { 4, new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9345), new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9347), "Northern Ireland" },
                    { 5, new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9349), new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9350), "United States of America" },
                    { 6, new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9357), new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9358), "Australia" },
                    { 7, new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9361), new DateTime(2022, 8, 19, 9, 3, 30, 210, DateTimeKind.Local).AddTicks(9362), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "3dac0e26-1c91-4953-851d-c4c2099b9faf", "USER", "USER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d87d721d-61e2-4ecd-9bb9-a0e1b64f9c7b", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "RecordLabels",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1768), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1769), "United Artists" },
                    { 8, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1764), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1766), "Reprise" },
                    { 7, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1761), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1762), "Island Records" },
                    { 5, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1643), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1644), "Sony Music Entertainment" },
                    { 6, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1756), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1758), "Columbia Label Group" },
                    { 3, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1637), "RCA Records" },
                    { 2, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1632), "Swan Song Records" },
                    { 1, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(993), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1007), "Atlantic Records" },
                    { 4, new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 8, 19, 9, 3, 30, 212, DateTimeKind.Local).AddTicks(1641), "Universal Music Publishing Group" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 180L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1126), "6:53", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1128), "Forever" },
                    { 179L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1122), "2:51", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1124), "Now You See It (Now You Don't)" },
                    { 178L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1119), "5:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1120), "You're No Different" },
                    { 177L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1115), "4:32", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1116), "Bark at the Moon" },
                    { 176L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1111), "4:03", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1113), "Rock 'n' Roll Rebel" },
                    { 175L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1107), "4:30", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1109), "Darkness on the Edge of Town" },
                    { 173L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1100), "4:09", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1101), "Streets of Fire" },
                    { 172L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1096), "2:17", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1098), "Factory" },
                    { 171L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1092), "4:33", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1094), "The Promised Land" },
                    { 170L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1089), "6:53", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1090), "Racing in the Street" },
                    { 169L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1085), "2:51", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1087), "Candy's Room" },
                    { 174L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1104), "3:56", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1105), "Prove It All Night" },
                    { 181L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1130), "4:33", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1132), "So Tired" },
                    { 190L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1204), "4:50", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1206), "Shah Shah a Go Go" },
                    { 183L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1137), "4:09", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1139), "Spiders" },
                    { 184L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1141), "1:10", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1143), "Longships" },
                    { 185L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1145), "5:13", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1146), "The Raven" },
                    { 186L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1149), "2:24", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1150), "Dead Loss Angeles" },
                    { 187L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1152), "3:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1154), "Ice" },
                    { 188L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1196), "3:50", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1198), "Baroque Bordello" },
                    { 189L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1200), "3:32", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1202), "Nuclear Device(The Wizard of Aus)" },
                    { 168L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1081), "5:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1083), "Something in the Night" },
                    { 191L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1208), "4:09", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1210), "Don't Bring Harry" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 192L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1212), "2:30", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1213), "Duchess" },
                    { 193L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1215), "4:48", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1217), "Meninblack" },
                    { 194L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1219), "5:16", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1221), "Genetix" },
                    { 182L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1134), "2:17", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1135), "Waiting for Darkness" },
                    { 167L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1077), "4:32", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1079), "Adam Raised a Cain" },
                    { 150L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1039), "6:05", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1041), "Point Blank" },
                    { 158L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1070), "3:53", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1071), "Wreck on the Highway" },
                    { 131L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(966), "3:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(968), "Don't Stop" },
                    { 132L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(970), "3:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(971), "Go Your Own Way" },
                    { 133L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(973), "3:20", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(975), "Songbird" },
                    { 134L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(977), "4:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(979), "The Chain" },
                    { 135L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(981), "3:31", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(983), "You Make Loving Fun" },
                    { 136L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(985), "3:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(986), "I Don't Want to Know" },
                    { 137L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(990), "3:54", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(991), "Oh Daddy" },
                    { 138L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(993), "4:51", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(995), "Gold Dust Woman" },
                    { 139L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(997), "3:33", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(999), "The Ties That Bind" },
                    { 140L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1001), "4:02", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1003), "Sherry Darling" },
                    { 141L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1005), "3:04", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1007), "Jackson Cage" },
                    { 142L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1009), "2:42", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1010), "Two Hearts" },
                    { 143L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1013), "4:46", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1014), "Independence Day" },
                    { 144L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1016), "3:19", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1018), "Hungry Heart" },
                    { 145L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1020), "4:17", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1022), "Out in the Street" },
                    { 146L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1024), "3:10", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1025), "Crush on You" },
                    { 147L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1028), "2:36", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1029), "You Can Look (But You Better Not Touch)" },
                    { 148L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1031), "3:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1033), "I Wanna Marry You" },
                    { 149L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1035), "4:59", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1037), "The River" },
                    { 195L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1223), "4:32", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1225), "Nebraska" },
                    { 151L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1043), "3:02", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1045), "Cadillac Ranch" },
                    { 152L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1047), "3:34", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1048), "I'm a Rocker" },
                    { 153L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1051), "4:40", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1052), "Fade Away" },
                    { 154L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1054), "3:53", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1056), "Stolen Car" },
                    { 155L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1058), "4:04", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1060), "Ramrod" },
                    { 156L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1062), "5:27", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1064), "The Price You Pay" },
                    { 157L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1066), "8:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1068), "Drive All Night" },
                    { 166L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1074), "4:03", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1075), "Badlands" },
                    { 196L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1227), "4:00", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1228), "Atlantic City" },
                    { 205L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1261), "2:55", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1262), "Iron Fist" },
                    { 198L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1234), "3:44", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1236), "Johnny 99" },
                    { 230L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1356), "2:01", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1358), "Peggy Day" },
                    { 231L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1360), "3:18", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1361), "Lay Lady Lay" },
                    { 232L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1364), "2:23", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1365), "One More Night" },
                    { 233L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1367), "2:41", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1369), "Tell Me That It Isn't True" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 234L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1371), "1:37", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1373), "Country Pie" },
                    { 235L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1375), "3:23", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1376), "Tonight I'll Be Staying Here with You" },
                    { 236L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1378), "4:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1380), "Born in the U.S.A." },
                    { 237L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1382), "3:29", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1384), "Cover Me" },
                    { 238L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1386), "4:48", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1388), "Darlington County" },
                    { 239L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1390), "3:13", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1392), "Working on the Highway" },
                    { 240L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1394), "3:35", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1395), "Downbound Train" },
                    { 241L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1397), "2:40", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1399), "I'm on Fire" },
                    { 229L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1352), "2:23", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1354), "I Threw It All Away" },
                    { 242L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1401), "4:01", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1403), "No Surrender" },
                    { 244L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1409), "3:30", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1410), "I'm Goin' Down" },
                    { 245L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1412), "4:15", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1414), "Glory Days" },
                    { 246L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1416), "4:04", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1418), "Dancing in the Dark" },
                    { 247L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1420), "4:34", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1421), "My Hometown" },
                    { 248L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1424), "4:49", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1425), "Thunder Road" },
                    { 249L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1428), "3:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1429), "Tenth Avenue Freeze-Out" },
                    { 250L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1431), "3:00", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1433), "Night" },
                    { 251L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1435), "6:30", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1437), "Backstreets" },
                    { 252L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1439), "4:31", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1440), "Born to Run" },
                    { 253L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1443), "4:30", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1444), "She's the One" },
                    { 254L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1446), "3:18", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1448), "Meeting Across the River" },
                    { 255L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1450), "9:34", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1452), "Jungleland" },
                    { 243L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1405), "3:48", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1406), "Bobby Jean" },
                    { 228L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1348), "2:07", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1350), "To Be Alone with You" },
                    { 227L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1345), "3:12", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1346), "Nashville Skyline Rag" },
                    { 226L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1340), "3:41", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1342), "Girl from the North Country" },
                    { 199L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1238), "5:40", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1240), "Highway Patrolman" },
                    { 200L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1242), "3:17", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1243), "State Trooper" },
                    { 201L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1246), "3:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1247), "Used Cars" },
                    { 202L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1249), "2:58", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1251), "Open All Night" },
                    { 203L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1253), "5:07", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1255), "My Father's House" },
                    { 204L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1257), "4:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1258), "Reason to Believe" },
                    { 130L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(962), "2:02", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(964), "Never Going Back Again" },
                    { 206L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1264), "3:04", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1266), "Heart of Stone" },
                    { 207L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1268), "2:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1270), "I'm the Doctor" },
                    { 208L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1272), "3:10", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1274), "Go to Hell" },
                    { 209L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1276), "3:57", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1277), "Loser" },
                    { 210L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1279), "2:10", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1281), "Sex & Outrage" },
                    { 211L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1283), "3:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1285), "America" },
                    { 212L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1287), "2:41", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1289), "Shut It Down" },
                    { 213L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1291), "3:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1292), "Speedfreak" },
                    { 214L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1294), "3:08", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1296), "(Don't Let 'Em) Grind Ya Down" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 215L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1298), "2:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1300), "(Don't Need) Religion" },
                    { 216L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1302), "2:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1304), "Bang to Rights" },
                    { 217L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1306), "4:03", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1307), "Stormbringer" },
                    { 218L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1310), "4:23", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1311), "Love Don't Mean a Thing" },
                    { 219L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1313), "4:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1315), "Holy Man" },
                    { 220L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1317), "5:05", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1319), "Hold On" },
                    { 221L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1321), "3:19", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1323), "Lady Double Dealer" },
                    { 222L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1325), "3:24", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1326), "You Can't Do It Right (With the One You Love)" },
                    { 223L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1329), "4:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1330), "High Ball Shooter" },
                    { 224L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1332), "4:05", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1334), "The Gypsy" },
                    { 225L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1336), "3:14", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1338), "Soldier of Fortune" },
                    { 197L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1230), "4:08", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(1232), "Mansion on the Hill" },
                    { 129L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(959), "4:14", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(960), "Dreams" },
                    { 119L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(921), "3:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(922), "Gypsy Eyes" },
                    { 127L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(951), "5:06", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(953), "Voodoo Child (Slight Return)" },
                    { 70L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(497), "4:49", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(499), "Four Sticks" },
                    { 71L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(501), "3:36", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(503), "Going to California" },
                    { 72L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(506), "7:08", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(507), "When the Levee Breaks" },
                    { 47L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(510), "5:32", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(511), "The Song Remains the Same" },
                    { 48L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(513), "7:39", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(515), "The Rain Song" },
                    { 49L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(592), "4:50", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(594), "Over the Hills and Far Away" },
                    { 50L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(596), "3:17", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(598), "The Crunge" },
                    { 51L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(600), "3:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(602), "Dancing Days" },
                    { 52L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(604), "4:23", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(606), "D'yer Mak'er" },
                    { 53L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(608), "7:00", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(609), "No Quarter" },
                    { 54L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(612), "4:31", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(613), "The Ocean" },
                    { 73L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(615), "4:13", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(617), "Custard Pie" },
                    { 69L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(494), "4:39", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(495), "Misty Mountain Hop" },
                    { 74L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(619), "5:36", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(621), "The Rover" },
                    { 76L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(627), "4:01", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(629), "Houses of the Holy" },
                    { 77L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(631), "5:35", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(633), "Trampled Under Foot" },
                    { 78L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(635), "8:37", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(637), "Kashmir" },
                    { 79L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(639), "8:44", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(641), "In the Light" },
                    { 80L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(643), "2:06", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(644), "Bron-Yr-Aur" },
                    { 81L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(646), "5:14", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(648), "Down by the Seaside" },
                    { 82L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(650), "6:31", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(652), "Ten Years Gone" },
                    { 83L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(654), "3:36", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(656), "Night Flight" },
                    { 84L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(658), "4:06", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(659), "The Wanton Song" },
                    { 85L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(662), "3:51", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(663), "Boogie with Stu" },
                    { 86L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(665), "4:24", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(667), "Black Country Woman" },
                    { 87L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(669), "4:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(671), "Sick Again" },
                    { 75L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(623), "11:04", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(625), "In My Time of Dying" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 68L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(490), "7:55", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(492), "Stairway to Heaven" },
                    { 67L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(486), "5:51", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(488), "The Battle of Evermore" },
                    { 66L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(482), "3:40", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(484), "Rock and Roll" },
                    { 1L, new DateTime(2022, 8, 19, 9, 3, 30, 232, DateTimeKind.Local).AddTicks(9013), "2:46", null, new DateTime(2022, 8, 19, 9, 3, 30, 232, DateTimeKind.Local).AddTicks(9050), "Good Times Bad Times" },
                    { 2L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(362), "6:42", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(372), "Babe I'm Gonna Leave You" },
                    { 3L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(377), "6:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(379), "You Shook Me" },
                    { 4L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(381), "6:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(383), "Dazed and Confused" },
                    { 5L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(385), "4:34", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(387), "Your Time Is Gonna Come" },
                    { 6L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(396), "2:12", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(398), "Black Mountain Side" },
                    { 7L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(400), "2:30", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(402), "Communication Breakdown" },
                    { 8L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(404), "4:42", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(406), "I Can't Quit You Baby" },
                    { 9L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(408), "8:27", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(409), "How Many More Times" },
                    { 40L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(413), "5:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(414), "Whole Lotta Love" },
                    { 41L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(416), "4:33", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(418), "What Is and What Should Never Be" },
                    { 42L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(420), "4:21", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(422), "Thank You" },
                    { 43L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(424), "6:20", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(426), "The Lemon Song" },
                    { 44L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(428), " 4:14", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(429), "Heartbreaker" },
                    { 45L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(431), "2:39", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(433), "Living Loving Maid(She's Just a Woman)" },
                    { 46L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(435), "4:34", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(437), "Ramble On" },
                    { 55L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(439), "2:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(441), "Immigrant Song" },
                    { 56L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(444), "3:55", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(446), "Friends" },
                    { 57L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(448), "3:29", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(449), "Celebration Day" },
                    { 58L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(451), "7:25", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(453), "Since I've Been Loving You" },
                    { 59L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(455), "4:04", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(457), "Out on the Tiles" },
                    { 60L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(459), "4:58", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(461), "Gallows Pole" },
                    { 61L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(463), "3:12", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(465), "Tangerine" },
                    { 62L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(467), "5:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(469), "That's the Way" },
                    { 63L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(471), "4:20", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(473), "Bron-Y-Aur Stomp" },
                    { 64L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(475), "3:41", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(476), "Hats Off to (Roy) Harper" },
                    { 65L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(479), "4:55", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(480), "Black Dog" },
                    { 88L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(673), "4:03", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(675), "Rock and Roll" },
                    { 89L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(677), "3:49", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(678), "Celebration Day" },
                    { 90L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(681), "6:00", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(682), "The Song Remains the Same" },
                    { 91L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(684), "8:24", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(686), "The Rain Song" },
                    { 22L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(808), "4:14", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(810), "In Bloom" },
                    { 23L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(812), "3:39", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(814), "Come as You Are" },
                    { 24L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(816), "3:03", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(817), "Breed" },
                    { 25L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(819), "4:17", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(821), "Lithium" },
                    { 26L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(823), "2:57", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(825), "Polly" },
                    { 27L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(827), "2:22", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(828), "Territorial Pissings" },
                    { 28L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(831), "3:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(832), "Drain You" },
                    { 29L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(834), "2:36", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(836), "Lounge Act" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 30L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(838), "3:32", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(840), "Stay Away" },
                    { 31L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(842), "3:16", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(844), "On a Plain" },
                    { 32L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(846), "3:52", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(847), "Something in the Way" },
                    { 33L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(850), "6:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(851), "Endless, Nameless" },
                    { 21L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(804), "5:01", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(806), "Smells Like Teen Spirit" },
                    { 112L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(853), "1:19", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(855), "...And the Gods Made Love" },
                    { 114L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(861), "2:25", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(862), "Crosstown Traffic" },
                    { 115L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(864), "14:50", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(866), "Voodoo Chile" },
                    { 116L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(868), "2:47", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(870), "Little Miss Strange" },
                    { 117L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(872), "3:21", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(874), "Long Hot Summer Night" },
                    { 118L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(916), "4:04", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(918), "Come On (Part 1)" },
                    { 120L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(925), "3:33", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(926), "Burning of the Midnight Lamp" },
                    { 121L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(928), "3:39", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(930), "Rainy Day, Dream Away" },
                    { 122L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(932), "13:25", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(934), "1983... (A Merman I Should Turn to Be)" },
                    { 123L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(936), "0:58", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(937), "Moon, Turn the Tides....Gently Gently Away" },
                    { 124L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(940), "4:19", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(941), "Still Raining, Still Dreaming" },
                    { 125L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(944), "4:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(945), "House Burning Down" },
                    { 126L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(947), "3:54", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(949), "All Along the Watchtower" },
                    { 113L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(857), "2:08", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(859), "Have You Ever Been (To Electric Ladyland)" },
                    { 128L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(955), "2:43", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(956), "Second Hand News" },
                    { 20L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(801), "3:22", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(802), "Crazy Lady Blues" },
                    { 18L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(792), "2:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(794), "Wretched Wilbur" },
                    { 92L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(688), "26:53", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(690), "Dazed and Confused" },
                    { 93L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(692), "12:30", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(694), "No Quarter" },
                    { 94L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(696), "10:58", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(697), "Stairway to Heaven" },
                    { 95L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(699), "12:47", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(701), "Moby Dick" },
                    { 96L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(705), "14:24", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(706), "Whole Lotta Love" },
                    { 97L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(709), "10:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(710), "Achilles Last Stand" },
                    { 98L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(712), "6:21", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(714), "For Your Life" },
                    { 99L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(716), "2:58", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(718), "Royal Orleans" },
                    { 101L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(720), "6:27", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(722), "Nobody's Fault but Mine" },
                    { 102L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(724), "4:10", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(725), "Candy Store Rock" },
                    { 103L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(727), "4:42", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(729), "Hots On for Nowhere" },
                    { 104L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(731), "9:27", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(733), "Tea for One" },
                    { 19L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(796), "3:27", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(798), "The North Star Grassman and the Ravens" },
                    { 105L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(735), "6:48", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(737), "In the Evening" },
                    { 107L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(743), "6:08", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(745), "Fool in the Rain" },
                    { 108L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(747), "3:15", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(748), "Hot Dog" },
                    { 109L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(750), "10:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(752), "Carouselambra" },
                    { 110L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(754), "5:51", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(756), "All My Love" },
                    { 111L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(758), "5:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(759), "I'm Gonna Crawl" },
                    { 10L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(762), "4:28", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(763), "Late November" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 11L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(765), "4:07", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(767), "Blackwaterside(Traditional) " },
                    { 12L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(769), "3:09", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(771), "The Sea Captain" },
                    { 13L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(773), "3:20", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(774), "Down in the Flood(Bob Dylan)" },
                    { 14L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(776), "4:38", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(778), "John the Gun" },
                    { 15L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(780), "4:26", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(782), "Next Time Around" },
                    { 16L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(784), "3:24", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(785), "The Optimist" },
                    { 17L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(788), "2:42", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(789), "Let’s Jump the Broomstick(Charles Robins)" },
                    { 106L, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(739), "4:11", null, new DateTime(2022, 8, 19, 9, 3, 30, 233, DateTimeKind.Local).AddTicks(740), "South Bound Saurez" }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(7260), new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(7271), "Island Studios London, Sound Techniques London" },
                    { 2, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(7829), new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(7837), "914 Sound Studios, Blauvelt, New York" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "AddedDate", "CountryId", "DisbandYear", "FormationYear", "ModifiedDate", "Name", "Photo" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(6533), 1, 1980, 1967, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(6545), "Led Zeppelin", "458eb53a-aba7-42a2-a5ed-526da552966e.jpg" },
                    { 11L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9442), 2, null, 1977, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9443), "Simple Minds", "2a39824d-1c56-46fe-b4bc-b7e87dfb7bb3.jpg" },
                    { 8L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9428), 3, null, 1986, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9430), "Manic Street Preachers", "8117dfa2-41a4-4be1-a33f-fd7484ae5d7a.jpg" },
                    { 3L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9403), 5, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9405), "Bruce Springsteen", "32ce9c93-9129-4bff-b166-db5ada039757.jpg" },
                    { 4L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9407), 5, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9409), "John Denver", "f94fb03e-c368-4562-9c66-2b2db5722252.jpg" },
                    { 7L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9423), 5, null, 1962, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9425), "Bob Dylan", "567552b5-27d5-4a6e-acc5-449017fcd47e.jpg" },
                    { 17L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9527), 5, null, 1987, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9530), "Nirvana", "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
                    { 19L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9538), 5, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9540), "Tori Amos", "22d853a2-cd81-4362-a6a5-d15c17c83194.jpg" },
                    { 14L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9455), 6, null, 1973, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9456), "ACDC", "85d9174f-1f0d-4221-8635-f86c211caa4d.jpg" },
                    { 20L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9543), 1, null, 1975, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9544), "U2", "af794a29-19e8-440f-a5e2-113319932b40.jpg" },
                    { 15L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9459), 5, 1970, 1961, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9461), "Jimi Hendrix", "f304b989-f26e-4aa5-8c78-1d1b49850bee.jpg" },
                    { 16L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9464), 1, null, 1967, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9465), "Fleetwood Mac", "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
                    { 13L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9450), 1, null, 1975, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9452), "Motorhead", "2691c7fa-2546-401e-a10b-1608e00711d2.jpg" },
                    { 12L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9446), 1, null, 1968, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9448), "Deep Purple", "5863254c-693f-43e3-b0f8-a7ebdeb8ec33.jpg" },
                    { 10L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9438), 1, null, 1974, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9439), "The Stranglers", "8b728b1e-c506-4d08-b87d-9f320f4cc920.jpg" },
                    { 9L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9432), 1, null, 1979, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9434), "Ozzy Osbourne", "99cc2dbe-5671-4eca-947d-8f7a4f1759af.jpg" },
                    { 6L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9419), 1, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9421), "John Lennon", "e0ceb7ed-5481-4cc1-926f-59cf31fd2e69.jpg" },
                    { 18L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9534), 1, null, 1975, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9536), "Kate Bush", "909e5592-09a3-4018-a3a8-e067612c7388.jpg" },
                    { 5L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9412), 1, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9413), "Elton John", "64fa7eb5-dca2-4ed3-a465-fa6904bba895.jpg" },
                    { 2L, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9387), 1, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 214, DateTimeKind.Local).AddTicks(9397), "Sandy Denny", "0ed76f7d-e5da-4e5b-87b0-a8ecb4a165cd.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 42, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5296), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5297), "Bexleyheath, Kent" },
                    { 43, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5299), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5301), "Newton, North Carolina" },
                    { 44, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5303), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5305), "Dublin, Ireland" },
                    { 45, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5307), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5309), "Barking, Essex" },
                    { 46, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5311), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5312), "Chinnor, Oxfordshire" },
                    { 47, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5314), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5316), "Artane, Dublin" },
                    { 22, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5221), 2, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5223), "Toryglen, Glasgow" },
                    { 6, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5163), 3, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5165), "Pontypool" },
                    { 24, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5228), 2, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5230), "Dundee" },
                    { 26, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5236), 3, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5237), "Brecon" },
                    { 41, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5292), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5294), "Warren, Ohio" },
                    { 5, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5157), 5, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5158), "Seattle" },
                    { 10, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5179), 5, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5181), "Long Branch, New Jersey" },
                    { 11, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5183), 5, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5185), "Monterey Bay" },
                    { 15, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5198), 5, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5199), "Duluth, Minnesota" },
                    { 23, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5225), 2, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5226), "Glasgow" },
                    { 40, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5288), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5290), "Compton, California" },
                    { 34, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5266), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5267), "Redruth, Cornwall, Gateshead" },
                    { 38, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5281), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5283), "Palo Alto, California" },
                    { 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(4209), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(4223), "Aston, Birmingham" },
                    { 2, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5137), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5145), "Birmingham" },
                    { 3, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5149), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5151), "West Bromwich" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5153), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5155), "Heston" },
                    { 7, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5167), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5169), "Sidcup" },
                    { 8, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5171), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5173), "Reddich" },
                    { 9, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5175), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5176), "Merton Park, London" },
                    { 12, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5187), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5189), "Pinner, Middlesex" },
                    { 13, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5191), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5192), "Liverpool, Lancashire" },
                    { 16, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5201), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5203), "Marston Green, Warwickshire" },
                    { 17, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5205), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5207), "Tufnell Park, North London" },
                    { 18, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5210), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5212), "Notting Hill, London" },
                    { 19, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5214), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5215), "Brighton, London" },
                    { 21, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5217), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5219), "Ilford, Essex" },
                    { 25, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5232), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5234), "Nottingham" },
                    { 27, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5239), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5241), "Chiswick, London" },
                    { 28, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5243), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5245), "Stoke-on-Trent, Staffordshire" },
                    { 29, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5247), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5248), "London" },
                    { 30, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5250), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5252), "Twickenham, Middlesex" },
                    { 32, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5258), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5260), "Romford, Essex" },
                    { 33, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5262), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5264), "Dunston, Gateshead" },
                    { 31, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5254), 6, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5256), "Melbourne, Victoria" },
                    { 35, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5270), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5272), "Phoenix, Arizona" },
                    { 36, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5274), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5275), "Ealing, Middlesex" },
                    { 37, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5277), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5279), "Bouth, Lancashire" },
                    { 39, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5285), 1, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5286), "Aberdeen, Washington" },
                    { 14, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5194), 7, new DateTime(2022, 8, 19, 9, 3, 30, 213, DateTimeKind.Local).AddTicks(5196), "Vancover" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AddedDate", "Arrangers", "ArtistId", "Artwork", "Engineers", "LabelId", "ModifiedDate", "Name", "Photo", "Producers", "RecordedDate", "ReleaseDate", "StudioId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 19, 9, 3, 30, 222, DateTimeKind.Local).AddTicks(8104), null, 1L, null, null, 1, new DateTime(2022, 8, 19, 9, 3, 30, 222, DateTimeKind.Local).AddTicks(8127), "Led Zeppelin 1", "11d15486-fefc-463c-8b7d-c755b08466dc.jpg", null, null, new DateTime(1969, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4072), null, 3L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4075), "Nebraska", "6e2e5c69-75cd-480e-9b28-6d3726df576f.jpg", null, null, null, null },
                    { 21L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4085), null, 12L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4087), "Stormbringer", "d96d1eac-982a-41a2-b2dd-ff65707940e1.jpg", null, null, null, null },
                    { 22L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4178), null, 7L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4183), "Nashville Skyline", "722792d3-787b-4698-916d-0ff766e68fd6.jpg", null, null, null, null },
                    { 15L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4052), null, 3L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4054), "Darkness on the Edge of Town", "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg", null, null, null, null },
                    { 11L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4024), null, 15L, null, null, 8, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4026), "Electric Ladyland", "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg", null, null, new DateTime(1968, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4045), null, 3L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4048), "Born To Run", "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg", null, null, null, null },
                    { 17L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4064), null, 10L, null, null, 9, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4067), "The Raven", "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg", null, null, new DateTime(1979, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4192), null, 17L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4194), "Nevermind", "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg", null, null, new DateTime(1991, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4059), null, 9L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4061), "Bark At The Moon", "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg", null, null, null, null },
                    { 12L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4031), null, 16L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4034), "Rumours", "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg", "Fleetwood Mac, Ken Caillat, Richard Dashut", null, new DateTime(1977, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4038), null, 3L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4041), "The River", "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg", null, null, null, null },
                    { 20L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4079), null, 13L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4082), "Iron Fist", "39c3f690-87cd-4cd2-8a9a-54ba8af3a50f.jpg", null, null, null, null },
                    { 2L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(2029), "Sandy Denny", 2L, "Keef", "John Wood", 7, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(2044), "The North Star Grassman and the Ravens", "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg", "John Wood, Richard Thompson, Sandy Denny", new DateTime(1971, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4017), null, 1L, null, null, 2, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4020), "In Through The OutDoor", "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg", null, null, new DateTime(1979, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4008), null, 1L, null, null, 2, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4010), "Presence", "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg", null, null, new DateTime(1976, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4001), null, 1L, null, null, 2, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4004), "The Song Remains The Same", "d2710986-0720-4231-8582-4383eb9ffe12.jpg", null, null, new DateTime(1976, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3995), null, 1L, null, null, 2, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3998), "Physical Graffiti", "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg", null, null, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3988), null, 1L, null, null, 1, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3990), "Houses of the Holy", "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg", null, null, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3969), null, 1L, null, null, 1, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3972), "Led Zeppelin IV", "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg", null, null, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3961), null, 1L, null, null, 1, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3964), "Led Zeppelin 3", "9cf368d3-db16-4120-af40-7dd697b934fa.jpg", null, null, new DateTime(1970, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3939), null, 1L, null, null, 1, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(3951), "Led Zeppelin 2", "ee552af1-7a5a-457b-b336-823bc1285dac.jpg", null, null, new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4187), null, 3L, null, null, null, new DateTime(2022, 8, 19, 9, 3, 30, 223, DateTimeKind.Local).AddTicks(4190), "Born In The Usa", "66c0e775-c22b-427d-a327-e6bfd9b5673e.jpg", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 13L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5537), 8L, 6L, null, new DateTime(1968, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sean", true, "Anthony", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5539), "18bc8103-9380-4bde-ae46-01b8160887a3.jpg", "Sean Moore", "Moore" },
                    { 11L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5529), 8L, 6L, null, new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Dean", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5530), "3d39a220-fd12-4533-adcb-7741b0c4f8ab.jpg", "James Dean Bradfield", "Bradfield" },
                    { 21L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5640), 11L, 24L, null, new DateTime(1962, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ged", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5641), "4b9eee24-56a3-493f-9dfa-3159a80396fd.jpg", "Ged Grimes", "Grimes" },
                    { 20L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5634), 11L, 23L, null, new DateTime(1959, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5636), "83a85c7e-609d-420a-b380-d2ff190a452a.jpg", "Charlie Burchill", "Burchill" },
                    { 12L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5533), 8L, 6L, null, new DateTime(1969, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicholas", true, "Allen", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5535), "450e17c5-c352-452f-a1d8-4b6c4154cf9d.jpg", "Nicky Wire", "Jones" },
                    { 47L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5757), 15L, 14L, null, new DateTime(1942, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", true, "Allen", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5758), "9a7bff27-93b5-43cf-8fed-743074f6182b.jpg", "Jimi Hendrix", "Hendrix" },
                    { 7L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5507), 4L, 11L, null, new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5509), "08dc96d6-bbe4-429d-90b6-094b04ae8f9d.jpg", "John Denver", "Denver" },
                    { 10L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5523), 7L, 15L, null, new DateTime(1941, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Allen", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5525), "bb655ce4-9a14-4805-b6d3-9f84a26a250a.jpg", "Bob Dylan", "Zimmerman" },
                    { 19L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5565), 11L, 22L, null, new DateTime(1959, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5567), "60267eb0-f2f5-48c8-b245-83df9a7986bd.jpg", "Jim Kerr", "Kerr" },
                    { 38L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5717), 17L, 39L, null, new DateTime(1967, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurt", true, "Donald", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5719), "10ec8163-a6de-4c64-bd80-3a949886905e.jpg", "Kurt Cobain", "Cobain" },
                    { 39L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5722), 17L, 40L, null, new DateTime(1965, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Krist", true, "Anthony", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5723), "657837dd-f7c1-4ed5-a58e-39cc0e279d83.jpg", "Krist Novoselic", "Novoselic" },
                    { 40L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5726), 17L, 41L, null, new DateTime(1969, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Eric", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5728), "7dd70c41-8fcf-4cd1-a825-78fb30c7c0ca.jpg", "Dave Grohl", "Grohl" },
                    { 42L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5736), 19L, 43L, null, new DateTime(1963, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Myra", true, "Ellen", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5737), "d4f764a9-75d6-44ff-9263-94d2cd30703e.jpg", "Tori Amos", "Amos" },
                    { 28L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5673), 14L, 23L, null, new DateTime(1955, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Angus", true, "McKinnon", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5674), "273cc6e3-995f-44ef-9665-4b06d76ce7eb.jpg", "Angus Young", "Young" },
                    { 29L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5677), 14L, 23L, null, new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malcolm", true, "Mitchell", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5679), "c79c5ae5-8678-488d-a9f0-6bc18e83abb3.jpg", "Malcolm Young", "Young" },
                    { 30L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5681), 14L, 29L, null, new DateTime(1954, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phillip", true, "Hugh Norman Witschke", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5683), "44b350e7-ed7f-4e3c-b6e1-5b286836e383.jpg", "Phil Rudd", "Rudzevecuis" },
                    { 6L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5495), 3L, 10L, null, new DateTime(1949, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5502), "734770c0-05f1-4bd9-ae4b-748cbdc64167.jpg", "Bruce Springsteen", "Springsteen" },
                    { 46L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5753), 20L, 47L, null, new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lawrence", true, " Joseph", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5754), "9f24c9d9-6b23-4594-bdf3-f71da4311af7.jpg", "Larry Mullen Jr.", "Mullen Jr." },
                    { 34L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5700), 16L, 35L, null, new DateTime(1948, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie", true, "Lynn", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5702), "88153d6b-9d63-4f87-b49b-a660683f7adf.jpg", "Stevie Nicks", "Nicks" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 44L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5744), 20L, 45L, null, new DateTime(1961, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Howell", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5746), "7ad787f2-d136-4d35-9fbf-be9bcddd34c3.jpg", "The Edge", "Evans" },
                    { 1L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(2172), 1L, 4L, null, new DateTime(1944, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Patrick", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(2207), "a0033bc9-c0b8-4248-8e31-f9d3938e1e34.jpg", "Jimmy Page", "Page" },
                    { 2L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5175), 1L, 3L, null, new DateTime(1948, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Anthony", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5186), "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg", "Robert Plant", "Plant" },
                    { 3L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5192), 1L, 7L, null, new DateTime(1946, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Jones", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5193), "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg", "John Paul Jones", "Paul" },
                    { 4L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5200), 1L, 8L, null, new DateTime(1948, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Bonham", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5202), "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg", "John Bonham", "Henry" },
                    { 5L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5206), 2L, 9L, null, new DateTime(1947, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandra", true, "Elene MacLean", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5207), "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg", "Sandy Denny", "Denny" },
                    { 8L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5513), 5L, 12L, null, new DateTime(1947, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elton", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5514), "06cb3132-accb-4b58-a532-47bb49bdc29b.jpg", "Elton John", "John" },
                    { 9L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5517), 6L, 13L, null, new DateTime(1940, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5519), "69e916a9-94e6-47ce-9762-1ca6650fa434.jpg", "John Lennon", "Lennon" },
                    { 14L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5542), 9L, 16L, null, new DateTime(1948, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Michael", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5543), "9366d83c-e30d-47ab-924e-f61a42d17efe.jpg", "Ozzy Osbourne", "Osbourne" },
                    { 15L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5546), 10L, 17L, null, new DateTime(1949, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hugh", true, "Alan", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5548), "e962871a-23ec-4049-a772-d5ef262c9adb.jpg", "Hugh Cornwell", "Cornwell" },
                    { 16L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5551), 10L, 18L, null, new DateTime(1952, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Jacques", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5552), "f5fc3019-2a61-4d80-b071-351845c5992c.jpg", "Jean-Jacques Burnel", "Burnel" },
                    { 17L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5555), 10L, 19L, null, new DateTime(1949, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", true, "Paul", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5557), "8f567b5f-7982-44d9-b4b5-e9337595f8e1.jpg", "David Greenfield", "Greenfield" },
                    { 18L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5561), 10L, 21L, null, new DateTime(1938, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "John", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5562), "9833b134-75c7-456a-a1d2-f5a286dc892e.jpg", "Jet Black", "Duffy" },
                    { 22L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5644), 12L, 25L, null, new DateTime(1948, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, "Anderson", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5646), "5166d6e2-42a6-44f6-bbca-ffb41733ef48.jpg", "Ian Paice", "Paice" },
                    { 23L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5648), 12L, 26L, null, new DateTime(1945, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", true, "David", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5650), "85717e2f-36bf-4c2b-8920-f42c90817ce8.jpg", "Roger Glover", "Glover" },
                    { 24L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5653), 12L, 27L, null, new DateTime(1945, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5655), "883f0129-b075-454d-a68c-e3d7f07bbdda.jpg", "Ian Gillan", "Gillan" },
                    { 25L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5657), 13L, 28L, null, new DateTime(1954, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian", true, "Fraser", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5659), "1a7a6266-a256-4b08-87f0-640d8e3ace60.jpg", "Lemmy", "Kilmister" },
                    { 26L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5661), 13L, 29L, null, new DateTime(1954, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", true, "John", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5663), "04f9d8e6-1b84-4a0a-800e-1716732aaf5e.jpg", "Phil 'Philthy Animal' Taylor", "Taylor" },
                    { 27L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5668), 13L, 30L, null, new DateTime(1950, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", true, "Allan", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5670), "1dbe7e17-567f-4f12-883d-b253ef2d25a2.jpg", "'Fast' Eddie Clarke", "Clarke" },
                    { 33L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5694), 16L, 34L, null, new DateTime(1947, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", true, "John Kells", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5696), "75ce147a-b9e9-49f4-8a71-c4f36dc9d3cd.jpg", "Mick Fleetwood", "Fleetwood" },
                    { 31L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5686), 14L, 32L, null, new DateTime(1949, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clifford", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5687), "0445ae2a-a3ef-4636-9850-2c4420d5f91e.jpg", "Cliff Williams", "Williams" },
                    { 35L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5705), 16L, 36L, null, new DateTime(1945, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Graham", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5706), "8c1fc01a-79e2-479c-b92d-ec6f9ba9135d.jpg", "John McVie", "McVie" },
                    { 36L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5709), 16L, 37L, null, new DateTime(1943, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christine", true, "Anne", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5710), "1fa68d08-2072-47cc-ad2b-96a27af42351.jpg", "Christine McVie", "Perfect" },
                    { 37L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5713), 16L, 38L, null, new DateTime(1949, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lindsey", true, "Adams", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5715), "8154868a-c01d-49e4-85d1-f85c0b0c9302.jpg", "Lindsey Buckingham", "Buckingham" },
                    { 41L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5731), 18L, 42L, null, new DateTime(1958, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catherine", true, null, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5733), "dfdae93a-d393-41e9-ba05-78970f0b1ee1.jpg", "Kate Bush", "Bush" },
                    { 43L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5740), 20L, 44L, null, new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", true, "David", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5741), "5b1d901a-ad92-40ad-8439-af151e472b5d.jpg", "Bono", "Hewson" },
                    { 45L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5748), 20L, 46L, null, new DateTime(1960, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adam", true, "Charles", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5750), "73375c6c-cd17-41c4-824c-c5f8af912a28.jpg", "Adam Clayton", "Clayton" },
                    { 32L, new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5690), 14L, 33L, null, new DateTime(1947, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "Francis", new DateTime(2022, 8, 19, 9, 3, 30, 220, DateTimeKind.Local).AddTicks(5691), "3ab89167-5769-478e-95a8-29277316e028.jpg", "Brian Johnson", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(1434), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(1477), 1, 1, 1L },
                    { 152L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3656), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3658), 6, 2, 149L },
                    { 153L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3660), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3662), 1, 3, 150L },
                    { 154L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3664), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3666), 2, 3, 151L },
                    { 155L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3668), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3670), 3, 3, 152L },
                    { 156L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3672), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3674), 4, 3, 153L },
                    { 157L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3677), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3678), 5, 3, 154L },
                    { 158L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3680), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3682), 1, 4, 155L },
                    { 159L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3684), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3686), 2, 4, 156L },
                    { 160L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3688), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3689), 3, 4, 157L },
                    { 161L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3692), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3693), 4, 4, 158L },
                    { 250L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4056), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4058), 1, 1, 248L },
                    { 251L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4060), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4061), 2, 1, 249L },
                    { 151L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3652), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3654), 5, 2, 148L },
                    { 252L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4064), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4065), 3, 1, 250L },
                    { 254L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4071), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4073), 1, 2, 252L },
                    { 255L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4075), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4076), 2, 2, 253L },
                    { 256L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4079), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4080), 3, 2, 254L },
                    { 257L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4082), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4084), 4, 2, 255L },
                    { 168L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3695), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3697), 1, 1, 166L },
                    { 169L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3699), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3701), 2, 1, 167L },
                    { 170L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3703), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3704), 3, 1, 168L },
                    { 171L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3707), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3708), 4, 1, 169L },
                    { 172L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3710), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3712), 5, 1, 170L },
                    { 173L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3714), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3716), 1, 2, 171L },
                    { 174L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3718), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3719), 2, 2, 172L },
                    { 175L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3721), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3723), 3, 2, 173L },
                    { 253L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4067), 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4069), 4, 1, 251L },
                    { 176L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3725), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3727), 4, 2, 174L },
                    { 150L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3648), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3650), 4, 2, 147L },
                    { 148L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3640), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3642), 2, 2, 145L },
                    { 210L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3855), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3857), 4, 1, 208L },
                    { 211L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3859), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3861), 5, 1, 209L },
                    { 212L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3863), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3864), 6, 1, 210L },
                    { 213L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3866), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3868), 1, 2, 211L },
                    { 214L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3915), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3917), 2, 2, 212L },
                    { 215L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3919), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3921), 3, 2, 213L },
                    { 216L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3923), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3925), 4, 2, 214L },
                    { 217L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3927), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3929), 5, 2, 215L },
                    { 218L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3931), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3932), 6, 2, 216L },
                    { 131L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3535), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3536), 1, 1, 128L },
                    { 132L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3538), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3540), 2, 1, 129L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 133L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3542), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3544), 3, 1, 130L },
                    { 149L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3644), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3646), 3, 2, 146L },
                    { 134L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3546), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3547), 4, 1, 131L },
                    { 136L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3553), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3555), 6, 1, 133L },
                    { 137L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3557), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3559), 1, 2, 134L },
                    { 138L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3599), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3601), 2, 2, 135L },
                    { 139L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3604), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3605), 3, 2, 136L },
                    { 140L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3610), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3611), 4, 2, 137L },
                    { 141L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3614), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3615), 5, 2, 138L },
                    { 142L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3617), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3619), 1, 1, 139L },
                    { 143L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3621), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3623), 2, 1, 140L },
                    { 144L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3625), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3626), 3, 1, 141L },
                    { 145L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3629), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3630), 4, 1, 142L },
                    { 146L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3632), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3634), 5, 1, 143L },
                    { 147L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3636), 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3638), 1, 2, 144L },
                    { 135L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3550), 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3551), 5, 1, 132L },
                    { 177L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3729), 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3731), 5, 2, 175L },
                    { 197L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3806), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3808), 1, 1, 195L },
                    { 198L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3810), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3811), 2, 1, 196L },
                    { 116L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3478), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3479), 2, 1, 113L },
                    { 117L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3482), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3483), 3, 1, 114L },
                    { 118L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3485), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3487), 4, 1, 115L },
                    { 119L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3489), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3491), 1, 2, 116L },
                    { 120L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3493), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3495), 2, 2, 117L },
                    { 121L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3497), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3498), 3, 2, 118L },
                    { 122L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3501), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3503), 4, 2, 119L },
                    { 123L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3505), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3507), 5, 2, 120L },
                    { 124L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3509), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3510), 3, 3, 121L },
                    { 125L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3512), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3514), 4, 3, 122L },
                    { 126L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3516), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3518), 1, 3, 123L },
                    { 127L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3520), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3521), 1, 4, 124L },
                    { 115L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3474), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3476), 1, 1, 112L },
                    { 128L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3524), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3525), 2, 4, 125L },
                    { 130L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3531), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3533), 4, 4, 127L },
                    { 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3082), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3084), 1, 1, 21L },
                    { 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3086), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3087), 2, 1, 22L },
                    { 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3090), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3091), 3, 1, 23L },
                    { 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3094), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3095), 4, 1, 24L },
                    { 25L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3097), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3099), 5, 1, 25L },
                    { 26L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3101), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3103), 6, 1, 26L },
                    { 27L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3105), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3107), 1, 2, 27L },
                    { 28L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3109), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3110), 2, 2, 28L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 29L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3112), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3114), 3, 2, 29L },
                    { 30L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3116), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3118), 4, 2, 30L },
                    { 31L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3120), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3121), 5, 2, 31L },
                    { 129L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3527), 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3529), 3, 4, 126L },
                    { 237L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4004), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4006), 5, 2, 235L },
                    { 236L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4000), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4002), 4, 2, 234L },
                    { 235L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3997), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3998), 3, 2, 233L },
                    { 199L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3813), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3815), 3, 1, 197L },
                    { 200L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3817), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3819), 4, 1, 198L },
                    { 201L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3821), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3823), 5, 1, 199L },
                    { 202L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3826), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3827), 6, 1, 200L },
                    { 203L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3829), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3831), 1, 2, 201L },
                    { 204L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3833), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3835), 2, 2, 202L },
                    { 205L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3837), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3838), 3, 2, 203L },
                    { 206L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3840), 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3842), 4, 2, 204L },
                    { 238L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4008), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4009), 1, 1, 236L },
                    { 239L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4015), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4016), 2, 1, 237L },
                    { 240L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4018), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4020), 3, 1, 238L },
                    { 241L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4022), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4024), 4, 1, 239L },
                    { 242L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4026), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4027), 5, 1, 240L },
                    { 243L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4030), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4031), 6, 1, 241L },
                    { 244L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4033), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4035), 1, 2, 242L },
                    { 245L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4037), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4039), 2, 2, 243L },
                    { 246L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4041), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4043), 3, 2, 244L },
                    { 247L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4045), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4046), 4, 2, 245L },
                    { 248L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4049), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4050), 5, 2, 246L },
                    { 249L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4052), 23L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(4054), 6, 2, 247L },
                    { 228L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3970), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3971), 1, 1, 226L },
                    { 229L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3974), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3975), 2, 1, 227L },
                    { 230L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3977), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3979), 3, 1, 228L },
                    { 231L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3981), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3983), 4, 1, 229L },
                    { 232L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3985), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3987), 5, 1, 230L },
                    { 233L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3989), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3991), 1, 2, 231L },
                    { 234L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3993), 22L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3994), 2, 2, 232L },
                    { 209L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3852), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3853), 3, 1, 207L },
                    { 34L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3124), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3125), 6, 2, 32L },
                    { 208L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3848), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3850), 2, 1, 206L },
                    { 227L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3966), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3968), 5, 2, 225L },
                    { 73L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3315), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3316), 3, 2, 70L },
                    { 74L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3319), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3320), 3, 2, 71L },
                    { 75L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3324), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3325), 4, 2, 72L },
                    { 50L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3159), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3161), 1, 1, 47L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 51L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3163), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3165), 2, 1, 48L },
                    { 52L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3167), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3169), 3, 1, 49L },
                    { 53L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3171), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3172), 4, 1, 50L },
                    { 54L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3174), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3176), 1, 2, 51L },
                    { 55L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3178), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3180), 2, 2, 52L },
                    { 56L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3248), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3250), 3, 2, 53L },
                    { 57L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3254), 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3255), 4, 2, 54L },
                    { 76L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3327), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3329), 1, 1, 73L },
                    { 72L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3311), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3313), 2, 2, 69L },
                    { 77L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3331), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3333), 2, 1, 74L },
                    { 79L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3338), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3340), 1, 2, 76L },
                    { 80L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3342), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3344), 2, 2, 77L },
                    { 81L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3346), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3347), 3, 2, 78L },
                    { 82L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3350), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3351), 1, 3, 79L },
                    { 83L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3354), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3356), 2, 3, 80L },
                    { 84L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3358), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3360), 3, 3, 81L },
                    { 85L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3362), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3363), 4, 3, 82L },
                    { 86L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3366), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3367), 1, 4, 83L },
                    { 87L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3369), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3371), 2, 4, 84L },
                    { 88L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3373), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3375), 3, 4, 85L },
                    { 89L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3377), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3379), 4, 4, 86L },
                    { 90L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3381), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3382), 5, 4, 87L },
                    { 78L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3335), 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3336), 3, 1, 75L },
                    { 91L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3384), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3386), 1, 1, 88L },
                    { 71L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3307), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3309), 4, 1, 68L },
                    { 69L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3300), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3301), 2, 1, 66L },
                    { 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(2986), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(2994), 2, 1, 2L },
                    { 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(2998), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3000), 3, 1, 3L },
                    { 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3003), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3005), 4, 1, 4L },
                    { 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3007), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3008), 5, 2, 5L },
                    { 6L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3020), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3021), 6, 2, 6L },
                    { 7L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3024), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3025), 7, 2, 7L },
                    { 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3027), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3029), 8, 2, 8L },
                    { 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3031), 1L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3033), 9, 2, 9L },
                    { 43L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3132), 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3134), 1, 1, 40L },
                    { 44L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3136), 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3138), 2, 1, 41L },
                    { 45L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3140), 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3141), 4, 1, 42L },
                    { 46L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3144), 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3146), 3, 1, 43L },
                    { 70L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3303), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3305), 3, 1, 67L },
                    { 47L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3148), 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3150), 1, 2, 44L },
                    { 49L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3156), 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3157), 3, 2, 46L },
                    { 58L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3257), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3259), 1, 1, 55L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 59L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3261), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3263), 2, 1, 56L },
                    { 60L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3265), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3266), 3, 1, 57L },
                    { 61L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3268), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3270), 4, 1, 58L },
                    { 62L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3272), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3274), 5, 1, 59L },
                    { 63L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3276), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3278), 1, 2, 60L },
                    { 64L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3281), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3283), 2, 2, 61L },
                    { 65L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3285), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3286), 3, 2, 62L },
                    { 66L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3288), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3290), 4, 2, 63L },
                    { 67L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3292), 4L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3294), 5, 2, 64L },
                    { 68L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3296), 5L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3298), 1, 1, 65L },
                    { 48L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3152), 3L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3153), 2, 2, 45L },
                    { 92L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3388), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3390), 2, 1, 89L },
                    { 93L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3392), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3393), 3, 1, 90L },
                    { 94L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3396), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3397), 4, 1, 91L },
                    { 179L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3737), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3738), 2, 1, 177L },
                    { 180L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3740), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3742), 3, 1, 178L },
                    { 181L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3744), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3746), 4, 1, 179L },
                    { 182L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3748), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3749), 1, 2, 180L },
                    { 183L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3752), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3754), 2, 2, 181L },
                    { 184L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3757), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3759), 3, 2, 182L },
                    { 185L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3761), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3762), 4, 2, 183L },
                    { 186L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3764), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3766), 1, 1, 184L },
                    { 187L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3768), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3770), 2, 1, 185L },
                    { 188L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3772), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3774), 3, 1, 186L },
                    { 189L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3776), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3777), 4, 1, 187L },
                    { 190L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3780), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3781), 5, 1, 188L },
                    { 178L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3733), 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3734), 1, 1, 176L },
                    { 191L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3783), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3785), 6, 1, 189L },
                    { 193L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3791), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3792), 2, 2, 191L },
                    { 194L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3795), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3796), 3, 2, 192L },
                    { 195L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3798), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3800), 4, 2, 193L },
                    { 196L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3802), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3804), 5, 2, 194L },
                    { 219L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3935), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3936), 1, 1, 217L },
                    { 220L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3938), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3940), 2, 1, 218L },
                    { 221L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3943), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3945), 3, 1, 219L },
                    { 222L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3947), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3949), 4, 1, 220L },
                    { 223L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3951), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3952), 1, 2, 221L },
                    { 224L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3955), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3956), 2, 2, 222L },
                    { 225L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3958), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3960), 3, 2, 223L },
                    { 226L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3962), 21L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3964), 4, 2, 224L },
                    { 192L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3787), 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3789), 1, 2, 190L },
                    { 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3078), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3080), 11, 2, 20L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 19L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3075), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3076), 10, 2, 19L },
                    { 18L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3071), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3072), 9, 2, 18L },
                    { 95L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3401), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3402), 1, 2, 92L },
                    { 96L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3405), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3407), 1, 3, 93L },
                    { 97L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3409), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3410), 2, 3, 94L },
                    { 98L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3413), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3414), 1, 4, 95L },
                    { 99L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3417), 8L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3419), 2, 4, 96L },
                    { 100L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3421), 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3423), 1, 1, 97L },
                    { 102L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3425), 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3426), 2, 1, 98L },
                    { 103L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3429), 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3430), 3, 1, 99L },
                    { 104L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3432), 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3434), 1, 2, 101L },
                    { 105L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3436), 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3438), 2, 2, 102L },
                    { 106L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3440), 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3442), 3, 2, 103L },
                    { 107L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3444), 9L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3445), 4, 2, 104L },
                    { 108L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3447), 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3449), 1, 1, 105L },
                    { 109L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3451), 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3453), 2, 1, 106L },
                    { 110L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3455), 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3457), 3, 1, 107L },
                    { 111L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3459), 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3461), 4, 1, 108L },
                    { 112L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3463), 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3464), 1, 2, 109L },
                    { 113L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3467), 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3468), 2, 2, 110L },
                    { 114L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3470), 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3472), 3, 2, 111L },
                    { 10L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3037), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3038), 1, 1, 10L },
                    { 11L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3040), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3043), 2, 1, 11L },
                    { 12L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3046), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3047), 3, 1, 12L },
                    { 13L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3049), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3051), 4, 1, 13L },
                    { 14L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3053), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3055), 5, 1, 14L },
                    { 15L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3057), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3059), 6, 2, 15L },
                    { 16L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3061), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3062), 7, 2, 16L },
                    { 17L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3065), 2L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3066), 8, 2, 17L },
                    { 207L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3844), 20L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3846), 1, 1, 205L },
                    { 35L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3127), 24L, new DateTime(2022, 8, 19, 9, 3, 30, 247, DateTimeKind.Local).AddTicks(3129), 7, 2, 33L }
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
