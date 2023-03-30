using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SwanSong.Data.Migrations
{
    public partial class createdb : Migration
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
                    { 1, new DateTime(2023, 3, 30, 16, 50, 12, 95, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 3, 30, 16, 50, 12, 98, DateTimeKind.Local).AddTicks(9979), "England" },
                    { 2, new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(995), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1006), "Scotland" },
                    { 3, new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1008), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1010), "Wales" },
                    { 4, new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1012), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1014), "Northern Ireland" },
                    { 5, new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1017), "United States of America" },
                    { 6, new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1025), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1027), "Australia" },
                    { 7, new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 3, 30, 16, 50, 12, 99, DateTimeKind.Local).AddTicks(1031), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "6d4d1f71-6ca4-48cd-aa47-860bb7d1b2b8", "USER", "USER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "01419bec-85f9-4521-b914-a8fb36faa10c", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "RecordLabels",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4790), "United Artists" },
                    { 8, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4786), "Reprise" },
                    { 7, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4778), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4780), "Island Records" },
                    { 5, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4760), "Sony Music Entertainment" },
                    { 6, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4773), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4775), "Columbia Label Group" },
                    { 3, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4749), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4751), "RCA Records" },
                    { 2, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4744), "Swan Song Records" },
                    { 1, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(3651), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(3699), "Atlantic Records" },
                    { 4, new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 3, 30, 16, 50, 12, 101, DateTimeKind.Local).AddTicks(4756), "Universal Music Publishing Group" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 180L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7797), "6:53", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7800), "Forever" },
                    { 179L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7791), "2:51", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7793), "Now You See It (Now You Don't)" },
                    { 178L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7785), "5:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7787), "You're No Different" },
                    { 177L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7778), "4:32", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7781), "Bark at the Moon" },
                    { 176L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7772), "4:03", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7775), "Rock 'n' Roll Rebel" },
                    { 175L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7766), "4:30", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7768), "Darkness on the Edge of Town" },
                    { 173L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7752), "4:09", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7755), "Streets of Fire" },
                    { 172L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7745), "2:17", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7748), "Factory" },
                    { 171L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7738), "4:33", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7741), "The Promised Land" },
                    { 170L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7732), "6:53", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7735), "Racing in the Street" },
                    { 169L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7725), "2:51", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7728), "Candy's Room" },
                    { 174L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7759), "3:56", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7762), "Prove It All Night" },
                    { 181L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7804), "4:33", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7807), "So Tired" },
                    { 190L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7864), "4:50", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7866), "Shah Shah a Go Go" },
                    { 183L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7818), "4:09", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7820), "Spiders" },
                    { 184L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7824), "1:10", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7827), "Longships" },
                    { 185L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7830), "5:13", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7833), "The Raven" },
                    { 186L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7836), "2:24", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7839), "Dead Loss Angeles" },
                    { 187L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7843), "3:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7846), "Ice" },
                    { 188L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7851), "3:50", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7854), "Baroque Bordello" },
                    { 189L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7858), "3:32", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7861), "Nuclear Device(The Wizard of Aus)" },
                    { 168L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7718), "5:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7721), "Something in the Night" },
                    { 191L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7870), "4:09", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7872), "Don't Bring Harry" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 192L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7876), "2:30", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7878), "Duchess" },
                    { 193L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7882), "4:48", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7885), "Meninblack" },
                    { 194L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7888), "5:16", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7890), "Genetix" },
                    { 182L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7811), "2:17", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7814), "Waiting for Darkness" },
                    { 167L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7712), "4:32", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7714), "Adam Raised a Cain" },
                    { 150L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7597), "6:05", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7599), "Point Blank" },
                    { 158L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7701), "3:53", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7703), "Wreck on the Highway" },
                    { 131L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7474), "3:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7477), "Don't Stop" },
                    { 132L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7482), "3:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7484), "Go Your Own Way" },
                    { 133L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7487), "3:20", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7490), "Songbird" },
                    { 134L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7494), "4:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7496), "The Chain" },
                    { 135L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7499), "3:31", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7502), "You Make Loving Fun" },
                    { 136L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7508), "3:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7510), "I Don't Want to Know" },
                    { 137L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7517), "3:54", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7520), "Oh Daddy" },
                    { 138L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7524), "4:51", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7527), "Gold Dust Woman" },
                    { 139L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7530), "3:33", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7533), "The Ties That Bind" },
                    { 140L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7536), "4:02", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7539), "Sherry Darling" },
                    { 141L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7542), "3:04", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7545), "Jackson Cage" },
                    { 142L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7549), "2:42", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7551), "Two Hearts" },
                    { 143L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7555), "4:46", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7557), "Independence Day" },
                    { 144L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7561), "3:19", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7563), "Hungry Heart" },
                    { 145L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7567), "4:17", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7570), "Out in the Street" },
                    { 146L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7573), "3:10", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7575), "Crush on You" },
                    { 147L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7579), "2:36", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7582), "You Can Look (But You Better Not Touch)" },
                    { 148L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7585), "3:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7587), "I Wanna Marry You" },
                    { 149L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7590), "4:59", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7592), "The River" },
                    { 195L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7893), "4:32", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7896), "Nebraska" },
                    { 151L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7603), "3:02", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7605), "Cadillac Ranch" },
                    { 152L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7608), "3:34", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7610), "I'm a Rocker" },
                    { 153L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7613), "4:40", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7615), "Fade Away" },
                    { 154L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7674), "3:53", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7678), "Stolen Car" },
                    { 155L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7683), "4:04", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7685), "Ramrod" },
                    { 156L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7688), "5:27", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7691), "The Price You Pay" },
                    { 157L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7695), "8:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7697), "Drive All Night" },
                    { 166L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7706), "4:03", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7708), "Badlands" },
                    { 196L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7898), "4:00", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7901), "Atlantic City" },
                    { 205L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7952), "2:55", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7954), "Iron Fist" },
                    { 198L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7909), "3:44", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7911), "Johnny 99" },
                    { 230L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8107), "2:01", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8109), "Peggy Day" },
                    { 231L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8112), "3:18", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8115), "Lay Lady Lay" },
                    { 232L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8119), "2:23", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8122), "One More Night" },
                    { 233L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8126), "2:41", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8128), "Tell Me That It Isn't True" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 234L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8132), "1:37", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8134), "Country Pie" },
                    { 235L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8138), "3:23", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8140), "Tonight I'll Be Staying Here with You" },
                    { 236L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8144), "4:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8146), "Born in the U.S.A." },
                    { 237L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8150), "3:29", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8152), "Cover Me" },
                    { 238L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8156), "4:48", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8159), "Darlington County" },
                    { 239L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8162), "3:13", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8165), "Working on the Highway" },
                    { 240L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8168), "3:35", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8170), "Downbound Train" },
                    { 241L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8174), "2:40", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8177), "I'm on Fire" },
                    { 229L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8101), "2:23", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8104), "I Threw It All Away" },
                    { 242L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8181), "4:01", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8184), "No Surrender" },
                    { 244L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8195), "3:30", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8198), "I'm Goin' Down" },
                    { 245L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8202), "4:15", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8204), "Glory Days" },
                    { 246L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8262), "4:04", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8271), "Dancing in the Dark" },
                    { 247L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8282), "4:34", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8284), "My Hometown" },
                    { 248L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8289), "4:49", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8297), "Thunder Road" },
                    { 249L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8305), "3:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8312), "Tenth Avenue Freeze-Out" },
                    { 250L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8321), "3:00", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8329), "Night" },
                    { 251L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8332), "6:30", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8334), "Backstreets" },
                    { 252L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8337), "4:31", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8339), "Born to Run" },
                    { 253L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8342), "4:30", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8344), "She's the One" },
                    { 254L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8348), "3:18", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8350), "Meeting Across the River" },
                    { 255L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8353), "9:34", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8355), "Jungleland" },
                    { 243L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8188), "3:48", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8191), "Bobby Jean" },
                    { 228L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8094), "2:07", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8097), "To Be Alone with You" },
                    { 227L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8087), "3:12", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8090), "Nashville Skyline Rag" },
                    { 226L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8081), "3:41", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8084), "Girl from the North Country" },
                    { 199L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7915), "5:40", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7917), "Highway Patrolman" },
                    { 200L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7920), "3:17", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7922), "State Trooper" },
                    { 201L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7926), "3:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7929), "Used Cars" },
                    { 202L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7932), "2:58", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7935), "Open All Night" },
                    { 203L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7938), "5:07", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7942), "My Father's House" },
                    { 204L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7946), "4:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7948), "Reason to Believe" },
                    { 130L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7468), "2:02", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7471), "Never Going Back Again" },
                    { 206L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7957), "3:04", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7960), "Heart of Stone" },
                    { 207L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7963), "2:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7965), "I'm the Doctor" },
                    { 208L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7968), "3:10", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7971), "Go to Hell" },
                    { 209L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7974), "3:57", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7976), "Loser" },
                    { 210L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7980), "2:10", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7983), "Sex & Outrage" },
                    { 211L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7986), "3:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7989), "America" },
                    { 212L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7992), "2:41", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7995), "Shut It Down" },
                    { 213L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7999), "3:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8002), "Speedfreak" },
                    { 214L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8006), "3:08", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8009), "(Don't Let 'Em) Grind Ya Down" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 215L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8012), "2:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8015), "(Don't Need) Religion" },
                    { 216L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8018), "2:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8021), "Bang to Rights" },
                    { 217L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8024), "4:03", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8027), "Stormbringer" },
                    { 218L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8031), "4:23", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8034), "Love Don't Mean a Thing" },
                    { 219L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8039), "4:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8041), "Holy Man" },
                    { 220L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8045), "5:05", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8047), "Hold On" },
                    { 221L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8050), "3:19", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8052), "Lady Double Dealer" },
                    { 222L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8055), "3:24", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8058), "You Can't Do It Right (With the One You Love)" },
                    { 223L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8061), "4:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8064), "High Ball Shooter" },
                    { 224L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8067), "4:05", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8070), "The Gypsy" },
                    { 225L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8074), "3:14", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(8077), "Soldier of Fortune" },
                    { 197L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7904), "4:08", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7906), "Mansion on the Hill" },
                    { 129L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7462), "4:14", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7465), "Dreams" },
                    { 119L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7405), "3:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7407), "Gypsy Eyes" },
                    { 127L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7451), "5:06", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7454), "Voodoo Child (Slight Return)" },
                    { 70L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6766), "4:49", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6768), "Four Sticks" },
                    { 71L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6771), "3:36", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6773), "Going to California" },
                    { 72L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6781), "7:08", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6783), "When the Levee Breaks" },
                    { 47L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6786), "5:32", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6789), "The Song Remains the Same" },
                    { 48L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6793), "7:39", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6795), "The Rain Song" },
                    { 49L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6799), "4:50", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6801), "Over the Hills and Far Away" },
                    { 50L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6804), "3:17", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6807), "The Crunge" },
                    { 51L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6810), "3:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6812), "Dancing Days" },
                    { 52L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6816), "4:23", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6819), "D'yer Mak'er" },
                    { 53L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6822), "7:00", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6824), "No Quarter" },
                    { 54L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6828), "4:31", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6831), "The Ocean" },
                    { 73L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6834), "4:13", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6836), "Custard Pie" },
                    { 69L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6760), "4:39", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6762), "Misty Mountain Hop" },
                    { 74L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6840), "5:36", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6842), "The Rover" },
                    { 76L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6851), "4:01", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6853), "Houses of the Holy" },
                    { 77L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6857), "5:35", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6859), "Trampled Under Foot" },
                    { 78L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6863), "8:37", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6865), "Kashmir" },
                    { 79L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6867), "8:44", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6869), "In the Light" },
                    { 80L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6872), "2:06", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6874), "Bron-Yr-Aur" },
                    { 81L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6880), "5:14", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6882), "Down by the Seaside" },
                    { 82L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6885), "6:31", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6887), "Ten Years Gone" },
                    { 83L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6890), "3:36", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6892), "Night Flight" },
                    { 84L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6896), "4:06", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6898), "The Wanton Song" },
                    { 85L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6901), "3:51", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6904), "Boogie with Stu" },
                    { 86L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6907), "4:24", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6910), "Black Country Woman" },
                    { 87L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6913), "4:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6915), "Sick Again" },
                    { 75L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6845), "11:04", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6848), "In My Time of Dying" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 68L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6753), "7:55", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6756), "Stairway to Heaven" },
                    { 67L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6747), "5:51", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6750), "The Battle of Evermore" },
                    { 66L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6741), "3:40", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6744), "Rock and Roll" },
                    { 1L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(4363), "2:46", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(4406), "Good Times Bad Times" },
                    { 2L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6136), "6:42", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6148), "Babe I'm Gonna Leave You" },
                    { 3L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6154), "6:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6157), "You Shook Me" },
                    { 4L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6161), "6:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6164), "Dazed and Confused" },
                    { 5L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6168), "4:34", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6171), "Your Time Is Gonna Come" },
                    { 6L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6184), "2:12", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6187), "Black Mountain Side" },
                    { 7L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6191), "2:30", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6194), "Communication Breakdown" },
                    { 8L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6198), "4:42", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6200), "I Can't Quit You Baby" },
                    { 9L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6204), "8:27", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6206), "How Many More Times" },
                    { 40L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6212), "5:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6214), "Whole Lotta Love" },
                    { 41L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6218), "4:33", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6220), "What Is and What Should Never Be" },
                    { 42L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6225), "4:21", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6227), "Thank You" },
                    { 43L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6230), "6:20", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6233), "The Lemon Song" },
                    { 44L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6237), " 4:14", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6240), "Heartbreaker" },
                    { 45L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6243), "2:39", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6246), "Living Loving Maid(She's Just a Woman)" },
                    { 46L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6250), "4:34", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6252), "Ramble On" },
                    { 55L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6257), "2:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6260), "Immigrant Song" },
                    { 56L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6628), "3:55", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6638), "Friends" },
                    { 57L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6648), "3:29", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6655), "Celebration Day" },
                    { 58L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6664), "7:25", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6671), "Since I've Been Loving You" },
                    { 59L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6679), "4:04", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6686), "Out on the Tiles" },
                    { 60L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6695), "4:58", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6702), "Gallows Pole" },
                    { 61L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6709), "3:12", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6712), "Tangerine" },
                    { 62L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6716), "5:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6718), "That's the Way" },
                    { 63L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6722), "4:20", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6724), "Bron-Y-Aur Stomp" },
                    { 64L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6727), "3:41", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6730), "Hats Off to (Roy) Harper" },
                    { 65L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6734), "4:55", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6737), "Black Dog" },
                    { 88L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6919), "4:03", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6921), "Rock and Roll" },
                    { 89L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6924), "3:49", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6927), "Celebration Day" },
                    { 90L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6930), "6:00", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6933), "The Song Remains the Same" },
                    { 91L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6936), "8:24", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6938), "The Rain Song" },
                    { 22L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7275), "4:14", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7277), "In Bloom" },
                    { 23L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7280), "3:39", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7285), "Come as You Are" },
                    { 24L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7293), "3:03", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7300), "Breed" },
                    { 25L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7309), "4:17", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7316), "Lithium" },
                    { 26L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7322), "2:57", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7324), "Polly" },
                    { 27L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7327), "2:22", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7329), "Territorial Pissings" },
                    { 28L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7333), "3:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7335), "Drain You" },
                    { 29L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7338), "2:36", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7341), "Lounge Act" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 30L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7344), "3:32", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7346), "Stay Away" },
                    { 31L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7349), "3:16", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7351), "On a Plain" },
                    { 32L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7354), "3:52", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7356), "Something in the Way" },
                    { 33L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7359), "6:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7362), "Endless, Nameless" },
                    { 21L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7266), "5:01", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7270), "Smells Like Teen Spirit" },
                    { 112L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7365), "1:19", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7367), "...And the Gods Made Love" },
                    { 114L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7377), "2:25", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7380), "Crosstown Traffic" },
                    { 115L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7383), "14:50", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7385), "Voodoo Chile" },
                    { 116L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7388), "2:47", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7390), "Little Miss Strange" },
                    { 117L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7394), "3:21", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7396), "Long Hot Summer Night" },
                    { 118L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7399), "4:04", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7402), "Come On (Part 1)" },
                    { 120L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7412), "3:33", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7414), "Burning of the Midnight Lamp" },
                    { 121L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7418), "3:39", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7420), "Rainy Day, Dream Away" },
                    { 122L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7423), "13:25", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7425), "1983... (A Merman I Should Turn to Be)" },
                    { 123L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7429), "0:58", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7431), "Moon, Turn the Tides....Gently Gently Away" },
                    { 124L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7434), "4:19", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7437), "Still Raining, Still Dreaming" },
                    { 125L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7440), "4:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7442), "House Burning Down" },
                    { 126L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7446), "3:54", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7448), "All Along the Watchtower" },
                    { 113L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7370), "2:08", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7373), "Have You Ever Been (To Electric Ladyland)" },
                    { 128L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7457), "2:43", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7459), "Second Hand News" },
                    { 20L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7250), "3:22", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7256), "Crazy Lady Blues" },
                    { 18L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7218), "2:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7225), "Wretched Wilbur" },
                    { 92L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6942), "26:53", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6944), "Dazed and Confused" },
                    { 93L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6948), "12:30", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6950), "No Quarter" },
                    { 94L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6954), "10:58", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6957), "Stairway to Heaven" },
                    { 95L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6960), "12:47", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6963), "Moby Dick" },
                    { 96L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6969), "14:24", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6971), "Whole Lotta Love" },
                    { 97L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6975), "10:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6977), "Achilles Last Stand" },
                    { 98L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6981), "6:21", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6984), "For Your Life" },
                    { 99L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6987), "2:58", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6990), "Royal Orleans" },
                    { 101L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6993), "6:27", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6996), "Nobody's Fault but Mine" },
                    { 102L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(6999), "4:10", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7002), "Candy Store Rock" },
                    { 103L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7005), "4:42", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7008), "Hots On for Nowhere" },
                    { 104L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7011), "9:27", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7013), "Tea for One" },
                    { 19L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7234), "3:27", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7241), "The North Star Grassman and the Ravens" },
                    { 105L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7017), "6:48", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7019), "In the Evening" },
                    { 107L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7029), "6:08", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7031), "Fool in the Rain" },
                    { 108L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7034), "3:15", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7037), "Hot Dog" },
                    { 109L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7040), "10:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7042), "Carouselambra" },
                    { 110L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7045), "5:51", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7047), "All My Love" },
                    { 111L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7051), "5:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7053), "I'm Gonna Crawl" },
                    { 10L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7056), "4:28", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7058), "Late November" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 11L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7062), "4:07", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7064), "Blackwaterside(Traditional) " },
                    { 12L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7067), "3:09", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7070), "The Sea Captain" },
                    { 13L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7139), "3:20", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7147), "Down in the Flood(Bob Dylan)" },
                    { 14L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7156), "4:38", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7163), "John the Gun" },
                    { 15L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7172), "4:26", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7179), "Next Time Around" },
                    { 16L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7187), "3:24", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7194), "The Optimist" },
                    { 17L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7202), "2:42", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7209), "Let’s Jump the Broomstick(Charles Robins)" },
                    { 106L, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7023), "4:11", null, new DateTime(2023, 3, 30, 16, 50, 12, 125, DateTimeKind.Local).AddTicks(7025), "South Bound Saurez" }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(9568), "Island Studios London, Sound Techniques London" },
                    { 2, new DateTime(2023, 3, 30, 16, 50, 12, 104, DateTimeKind.Local).AddTicks(128), new DateTime(2023, 3, 30, 16, 50, 12, 104, DateTimeKind.Local).AddTicks(136), "914 Sound Studios, Blauvelt, New York" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "AddedDate", "CountryId", "DisbandYear", "FormationYear", "ModifiedDate", "Name", "Photo" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(3621), 1, 1980, 1967, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(3733), "Led Zeppelin", "458eb53a-aba7-42a2-a5ed-526da552966e.jpg" },
                    { 11L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8214), 2, null, 1977, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8217), "Simple Minds", "2a39824d-1c56-46fe-b4bc-b7e87dfb7bb3.jpg" },
                    { 8L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8191), 3, null, 1986, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8195), "Manic Street Preachers", "8117dfa2-41a4-4be1-a33f-fd7484ae5d7a.jpg" },
                    { 3L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8141), 5, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8145), "Bruce Springsteen", "32ce9c93-9129-4bff-b166-db5ada039757.jpg" },
                    { 4L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8151), 5, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8153), "John Denver", "f94fb03e-c368-4562-9c66-2b2db5722252.jpg" },
                    { 7L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8183), 5, null, 1962, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8186), "Bob Dylan", "567552b5-27d5-4a6e-acc5-449017fcd47e.jpg" },
                    { 17L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8258), 5, null, 1987, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8260), "Nirvana", "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
                    { 19L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8274), 5, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8277), "Tori Amos", "22d853a2-cd81-4362-a6a5-d15c17c83194.jpg" },
                    { 14L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8236), 6, null, 1973, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8238), "ACDC", "85d9174f-1f0d-4221-8635-f86c211caa4d.jpg" },
                    { 20L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8281), 1, null, 1975, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8284), "U2", "af794a29-19e8-440f-a5e2-113319932b40.jpg" },
                    { 15L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8243), 5, 1970, 1961, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8245), "Jimi Hendrix", "f304b989-f26e-4aa5-8c78-1d1b49850bee.jpg" },
                    { 16L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8250), 1, null, 1967, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8253), "Fleetwood Mac", "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
                    { 13L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8228), 1, null, 1975, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8231), "Motorhead", "2691c7fa-2546-401e-a10b-1608e00711d2.jpg" },
                    { 12L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8222), 1, null, 1968, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8224), "Deep Purple", "5863254c-693f-43e3-b0f8-a7ebdeb8ec33.jpg" },
                    { 10L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8208), 1, null, 1974, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8210), "The Stranglers", "8b728b1e-c506-4d08-b87d-9f320f4cc920.jpg" },
                    { 9L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8199), 1, null, 1979, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8201), "Ozzy Osbourne", "99cc2dbe-5671-4eca-947d-8f7a4f1759af.jpg" },
                    { 6L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8175), 1, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8178), "John Lennon", "e0ceb7ed-5481-4cc1-926f-59cf31fd2e69.jpg" },
                    { 18L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8267), 1, null, 1975, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8270), "Kate Bush", "909e5592-09a3-4018-a3a8-e067612c7388.jpg" },
                    { 5L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8158), 1, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8161), "Elton John", "64fa7eb5-dca2-4ed3-a465-fa6904bba895.jpg" },
                    { 2L, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8026), 1, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 105, DateTimeKind.Local).AddTicks(8045), "Sandy Denny", "0ed76f7d-e5da-4e5b-87b0-a8ecb4a165cd.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 42, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6908), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6910), "Bexleyheath, Kent" },
                    { 43, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6914), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6916), "Newton, North Carolina" },
                    { 44, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6918), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6919), "Dublin, Ireland" },
                    { 45, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6921), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6923), "Barking, Essex" },
                    { 46, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6925), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6926), "Chinnor, Oxfordshire" },
                    { 47, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6928), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6930), "Artane, Dublin" },
                    { 22, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6834), 2, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6836), "Toryglen, Glasgow" },
                    { 6, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6709), 3, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6711), "Pontypool" },
                    { 24, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6842), 2, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6843), "Dundee" },
                    { 26, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6849), 3, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6850), "Brecon" },
                    { 41, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6904), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6906), "Warren, Ohio" },
                    { 5, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6698), 5, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6700), "Seattle" },
                    { 10, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6725), 5, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6727), "Long Branch, New Jersey" },
                    { 11, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6729), 5, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6731), "Monterey Bay" },
                    { 15, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6744), 5, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6745), "Duluth, Minnesota" },
                    { 23, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6838), 2, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6840), "Glasgow" },
                    { 40, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6901), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6903), "Compton, California" },
                    { 34, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6878), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6880), "Redruth, Cornwall, Gateshead" },
                    { 38, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6894), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6895), "Palo Alto, California" },
                    { 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(5423), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(5477), "Aston, Birmingham" },
                    { 2, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6676), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6687), "Birmingham" },
                    { 3, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6690), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6692), "West Bromwich" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6694), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6696), "Heston" },
                    { 7, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6713), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6714), "Sidcup" },
                    { 8, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6716), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6718), "Reddich" },
                    { 9, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6720), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6721), "Merton Park, London" },
                    { 12, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6733), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6734), "Pinner, Middlesex" },
                    { 13, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6736), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6738), "Liverpool, Lancashire" },
                    { 16, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6747), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6749), "Marston Green, Warwickshire" },
                    { 17, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6751), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6752), "Tufnell Park, North London" },
                    { 18, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6756), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6757), "Notting Hill, London" },
                    { 19, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6759), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6761), "Brighton, London" },
                    { 21, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6763), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6765), "Ilford, Essex" },
                    { 25, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6845), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6847), "Nottingham" },
                    { 27, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6853), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6854), "Chiswick, London" },
                    { 28, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6856), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6858), "Stoke-on-Trent, Staffordshire" },
                    { 29, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6860), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6862), "London" },
                    { 30, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6864), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6865), "Twickenham, Middlesex" },
                    { 32, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6871), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6872), "Romford, Essex" },
                    { 33, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6874), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6876), "Dunston, Gateshead" },
                    { 31, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6867), 6, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6869), "Melbourne, Victoria" },
                    { 35, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6883), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6885), "Phoenix, Arizona" },
                    { 36, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6887), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6888), "Ealing, Middlesex" },
                    { 37, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6890), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6892), "Bouth, Lancashire" },
                    { 39, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6897), 1, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6899), "Aberdeen, Washington" },
                    { 14, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6740), 7, new DateTime(2023, 3, 30, 16, 50, 12, 103, DateTimeKind.Local).AddTicks(6741), "Vancover" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AddedDate", "Arrangers", "ArtistId", "Artwork", "Engineers", "LabelId", "ModifiedDate", "Name", "Photo", "Producers", "RecordedDate", "ReleaseDate", "StudioId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(3164), null, 1L, null, null, 1, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(3204), "Led Zeppelin 1", "11d15486-fefc-463c-8b7d-c755b08466dc.jpg", null, null, new DateTime(1969, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8475), null, 3L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8478), "Nebraska", "6e2e5c69-75cd-480e-9b28-6d3726df576f.jpg", null, null, null, null },
                    { 21L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8489), null, 12L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8491), "Stormbringer", "d96d1eac-982a-41a2-b2dd-ff65707940e1.jpg", null, null, null, null },
                    { 22L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8496), null, 7L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8499), "Nashville Skyline", "722792d3-787b-4698-916d-0ff766e68fd6.jpg", null, null, null, null },
                    { 15L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8446), null, 3L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8449), "Darkness on the Edge of Town", "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg", null, null, null, null },
                    { 11L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8414), null, 15L, null, null, 8, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8418), "Electric Ladyland", "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg", null, null, new DateTime(1968, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8439), null, 3L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8442), "Born To Run", "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg", null, null, null, null },
                    { 17L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8460), null, 10L, null, null, 9, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8463), "The Raven", "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg", null, null, new DateTime(1979, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8510), null, 17L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8513), "Nevermind", "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg", null, null, new DateTime(1991, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8453), null, 9L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8456), "Bark At The Moon", "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg", null, null, null, null },
                    { 12L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8424), null, 16L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8427), "Rumours", "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg", "Fleetwood Mac, Ken Caillat, Richard Dashut", null, new DateTime(1977, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8432), null, 3L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8435), "The River", "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg", null, null, null, null },
                    { 20L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8482), null, 13L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8485), "Iron Fist", "39c3f690-87cd-4cd2-8a9a-54ba8af3a50f.jpg", null, null, null, null },
                    { 2L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(6539), "Sandy Denny", 2L, "Keef", "John Wood", 7, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(6553), "The North Star Grassman and the Ravens", "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg", "John Wood, Richard Thompson, Sandy Denny", new DateTime(1971, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8296), null, 1L, null, null, 2, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8299), "In Through The OutDoor", "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg", null, null, new DateTime(1979, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8286), null, 1L, null, null, 2, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8289), "Presence", "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg", null, null, new DateTime(1976, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8278), null, 1L, null, null, 2, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8281), "The Song Remains The Same", "d2710986-0720-4231-8582-4383eb9ffe12.jpg", null, null, new DateTime(1976, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8271), null, 1L, null, null, 2, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8274), "Physical Graffiti", "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg", null, null, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8263), null, 1L, null, null, 1, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8266), "Houses of the Holy", "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg", null, null, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8241), null, 1L, null, null, 1, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8244), "Led Zeppelin IV", "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg", null, null, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8230), null, 1L, null, null, 1, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8232), "Led Zeppelin 3", "9cf368d3-db16-4120-af40-7dd697b934fa.jpg", null, null, new DateTime(1970, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8207), null, 1L, null, null, 1, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8221), "Led Zeppelin 2", "ee552af1-7a5a-457b-b336-823bc1285dac.jpg", null, null, new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8503), null, 3L, null, null, null, new DateTime(2023, 3, 30, 16, 50, 12, 116, DateTimeKind.Local).AddTicks(8506), "Born In The Usa", "66c0e775-c22b-427d-a327-e6bfd9b5673e.jpg", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 13L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5607), 8L, 6L, null, new DateTime(1968, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sean", true, "Anthony", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5609), "18bc8103-9380-4bde-ae46-01b8160887a3.jpg", "Sean Moore", "Moore" },
                    { 11L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5592), 8L, 6L, null, new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Dean", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5595), "3d39a220-fd12-4533-adcb-7741b0c4f8ab.jpg", "James Dean Bradfield", "Bradfield" },
                    { 21L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5670), 11L, 24L, null, new DateTime(1962, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ged", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5672), "4b9eee24-56a3-493f-9dfa-3159a80396fd.jpg", "Ged Grimes", "Grimes" },
                    { 20L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5661), 11L, 23L, null, new DateTime(1959, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5664), "83a85c7e-609d-420a-b380-d2ff190a452a.jpg", "Charlie Burchill", "Burchill" },
                    { 12L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5599), 8L, 6L, null, new DateTime(1969, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicholas", true, "Allen", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5602), "450e17c5-c352-452f-a1d8-4b6c4154cf9d.jpg", "Nicky Wire", "Jones" },
                    { 47L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5861), 15L, 14L, null, new DateTime(1942, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", true, "Allen", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5864), "9a7bff27-93b5-43cf-8fed-743074f6182b.jpg", "Jimi Hendrix", "Hendrix" },
                    { 7L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5555), 4L, 11L, null, new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5558), "08dc96d6-bbe4-429d-90b6-094b04ae8f9d.jpg", "John Denver", "Denver" },
                    { 10L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5584), 7L, 15L, null, new DateTime(1941, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Allen", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5587), "bb655ce4-9a14-4805-b6d3-9f84a26a250a.jpg", "Bob Dylan", "Zimmerman" },
                    { 19L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5653), 11L, 22L, null, new DateTime(1959, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5656), "60267eb0-f2f5-48c8-b245-83df9a7986bd.jpg", "Jim Kerr", "Kerr" },
                    { 38L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5796), 17L, 39L, null, new DateTime(1967, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurt", true, "Donald", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5799), "10ec8163-a6de-4c64-bd80-3a949886905e.jpg", "Kurt Cobain", "Cobain" },
                    { 39L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5804), 17L, 40L, null, new DateTime(1965, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Krist", true, "Anthony", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5807), "657837dd-f7c1-4ed5-a58e-39cc0e279d83.jpg", "Krist Novoselic", "Novoselic" },
                    { 40L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5811), 17L, 41L, null, new DateTime(1969, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Eric", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5813), "7dd70c41-8fcf-4cd1-a825-78fb30c7c0ca.jpg", "Dave Grohl", "Grohl" },
                    { 42L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5826), 19L, 43L, null, new DateTime(1963, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Myra", true, "Ellen", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5828), "d4f764a9-75d6-44ff-9263-94d2cd30703e.jpg", "Tori Amos", "Amos" },
                    { 28L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5722), 14L, 23L, null, new DateTime(1955, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Angus", true, "McKinnon", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5725), "273cc6e3-995f-44ef-9665-4b06d76ce7eb.jpg", "Angus Young", "Young" },
                    { 29L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5729), 14L, 23L, null, new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malcolm", true, "Mitchell", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5732), "c79c5ae5-8678-488d-a9f0-6bc18e83abb3.jpg", "Malcolm Young", "Young" },
                    { 30L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5735), 14L, 29L, null, new DateTime(1954, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phillip", true, "Hugh Norman Witschke", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5738), "44b350e7-ed7f-4e3c-b6e1-5b286836e383.jpg", "Phil Rudd", "Rudzevecuis" },
                    { 6L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5457), 3L, 10L, null, new DateTime(1949, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5467), "734770c0-05f1-4bd9-ae4b-748cbdc64167.jpg", "Bruce Springsteen", "Springsteen" },
                    { 46L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5854), 20L, 47L, null, new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lawrence", true, " Joseph", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5857), "9f24c9d9-6b23-4594-bdf3-f71da4311af7.jpg", "Larry Mullen Jr.", "Mullen Jr." },
                    { 34L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5766), 16L, 35L, null, new DateTime(1948, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie", true, "Lynn", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5769), "88153d6b-9d63-4f87-b49b-a660683f7adf.jpg", "Stevie Nicks", "Nicks" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 44L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5840), 20L, 45L, null, new DateTime(1961, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Howell", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5843), "7ad787f2-d136-4d35-9fbf-be9bcddd34c3.jpg", "The Edge", "Evans" },
                    { 1L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(838), 1L, 4L, null, new DateTime(1944, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Patrick", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(876), "a0033bc9-c0b8-4248-8e31-f9d3938e1e34.jpg", "Jimmy Page", "Page" },
                    { 2L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5007), 1L, 3L, null, new DateTime(1948, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Anthony", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5022), "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg", "Robert Plant", "Plant" },
                    { 3L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5030), 1L, 7L, null, new DateTime(1946, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Jones", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5032), "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg", "John Paul Jones", "Paul" },
                    { 4L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5037), 1L, 8L, null, new DateTime(1948, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Bonham", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5040), "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg", "John Bonham", "Henry" },
                    { 5L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5044), 2L, 9L, null, new DateTime(1947, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandra", true, "Elene MacLean", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5047), "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg", "Sandy Denny", "Denny" },
                    { 8L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5564), 5L, 12L, null, new DateTime(1947, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elton", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5567), "06cb3132-accb-4b58-a532-47bb49bdc29b.jpg", "Elton John", "John" },
                    { 9L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5572), 6L, 13L, null, new DateTime(1940, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5574), "69e916a9-94e6-47ce-9762-1ca6650fa434.jpg", "John Lennon", "Lennon" },
                    { 14L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5614), 9L, 16L, null, new DateTime(1948, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Michael", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5616), "9366d83c-e30d-47ab-924e-f61a42d17efe.jpg", "Ozzy Osbourne", "Osbourne" },
                    { 15L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5621), 10L, 17L, null, new DateTime(1949, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hugh", true, "Alan", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5623), "e962871a-23ec-4049-a772-d5ef262c9adb.jpg", "Hugh Cornwell", "Cornwell" },
                    { 16L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5628), 10L, 18L, null, new DateTime(1952, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Jacques", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5631), "f5fc3019-2a61-4d80-b071-351845c5992c.jpg", "Jean-Jacques Burnel", "Burnel" },
                    { 17L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5636), 10L, 19L, null, new DateTime(1949, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", true, "Paul", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5639), "8f567b5f-7982-44d9-b4b5-e9337595f8e1.jpg", "David Greenfield", "Greenfield" },
                    { 18L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5647), 10L, 21L, null, new DateTime(1938, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "John", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5649), "9833b134-75c7-456a-a1d2-f5a286dc892e.jpg", "Jet Black", "Duffy" },
                    { 22L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5678), 12L, 25L, null, new DateTime(1948, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, "Anderson", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5681), "5166d6e2-42a6-44f6-bbca-ffb41733ef48.jpg", "Ian Paice", "Paice" },
                    { 23L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5685), 12L, 26L, null, new DateTime(1945, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", true, "David", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5688), "85717e2f-36bf-4c2b-8920-f42c90817ce8.jpg", "Roger Glover", "Glover" },
                    { 24L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5692), 12L, 27L, null, new DateTime(1945, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5694), "883f0129-b075-454d-a68c-e3d7f07bbdda.jpg", "Ian Gillan", "Gillan" },
                    { 25L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5700), 13L, 28L, null, new DateTime(1954, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian", true, "Fraser", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5702), "1a7a6266-a256-4b08-87f0-640d8e3ace60.jpg", "Lemmy", "Kilmister" },
                    { 26L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5707), 13L, 29L, null, new DateTime(1954, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", true, "John", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5710), "04f9d8e6-1b84-4a0a-800e-1716732aaf5e.jpg", "Phil 'Philthy Animal' Taylor", "Taylor" },
                    { 27L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5715), 13L, 30L, null, new DateTime(1950, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", true, "Allan", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5717), "1dbe7e17-567f-4f12-883d-b253ef2d25a2.jpg", "'Fast' Eddie Clarke", "Clarke" },
                    { 33L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5757), 16L, 34L, null, new DateTime(1947, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", true, "John Kells", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5760), "75ce147a-b9e9-49f4-8a71-c4f36dc9d3cd.jpg", "Mick Fleetwood", "Fleetwood" },
                    { 31L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5742), 14L, 32L, null, new DateTime(1949, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clifford", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5745), "0445ae2a-a3ef-4636-9850-2c4420d5f91e.jpg", "Cliff Williams", "Williams" },
                    { 35L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5774), 16L, 36L, null, new DateTime(1945, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Graham", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5777), "8c1fc01a-79e2-479c-b92d-ec6f9ba9135d.jpg", "John McVie", "McVie" },
                    { 36L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5781), 16L, 37L, null, new DateTime(1943, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christine", true, "Anne", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5784), "1fa68d08-2072-47cc-ad2b-96a27af42351.jpg", "Christine McVie", "Perfect" },
                    { 37L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5789), 16L, 38L, null, new DateTime(1949, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lindsey", true, "Adams", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5791), "8154868a-c01d-49e4-85d1-f85c0b0c9302.jpg", "Lindsey Buckingham", "Buckingham" },
                    { 41L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5818), 18L, 42L, null, new DateTime(1958, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catherine", true, null, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5821), "dfdae93a-d393-41e9-ba05-78970f0b1ee1.jpg", "Kate Bush", "Bush" },
                    { 43L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5833), 20L, 44L, null, new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", true, "David", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5836), "5b1d901a-ad92-40ad-8439-af151e472b5d.jpg", "Bono", "Hewson" },
                    { 45L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5847), 20L, 46L, null, new DateTime(1960, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adam", true, "Charles", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5849), "73375c6c-cd17-41c4-824c-c5f8af912a28.jpg", "Adam Clayton", "Clayton" },
                    { 32L, new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5750), 14L, 33L, null, new DateTime(1947, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "Francis", new DateTime(2023, 3, 30, 16, 50, 12, 113, DateTimeKind.Local).AddTicks(5752), "3ab89167-5769-478e-95a8-29277316e028.jpg", "Brian Johnson", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(221), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(262), 1, 1, 1L },
                    { 152L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2464), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2466), 6, 2, 149L },
                    { 153L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2468), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2469), 1, 3, 150L },
                    { 154L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2472), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2473), 2, 3, 151L },
                    { 155L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2476), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2478), 3, 3, 152L },
                    { 156L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2480), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2481), 4, 3, 153L },
                    { 157L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2484), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2485), 5, 3, 154L },
                    { 158L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2487), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2489), 1, 4, 155L },
                    { 159L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2491), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2493), 2, 4, 156L },
                    { 160L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2495), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2496), 3, 4, 157L },
                    { 161L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2498), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2500), 4, 4, 158L },
                    { 250L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2855), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2857), 1, 1, 248L },
                    { 251L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2859), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2861), 2, 1, 249L },
                    { 151L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2460), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2462), 5, 2, 148L },
                    { 252L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2863), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2864), 3, 1, 250L },
                    { 254L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2870), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2872), 1, 2, 252L },
                    { 255L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2874), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2876), 2, 2, 253L },
                    { 256L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2878), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2879), 3, 2, 254L },
                    { 257L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2882), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2884), 4, 2, 255L },
                    { 168L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2502), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2504), 1, 1, 166L },
                    { 169L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2506), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2508), 2, 1, 167L },
                    { 170L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2510), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2511), 3, 1, 168L },
                    { 171L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2513), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2515), 4, 1, 169L },
                    { 172L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2517), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2519), 5, 1, 170L },
                    { 173L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2521), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2522), 1, 2, 171L },
                    { 174L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2525), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2526), 2, 2, 172L },
                    { 175L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2528), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2530), 3, 2, 173L },
                    { 253L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2867), 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2868), 4, 1, 251L },
                    { 176L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2532), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2534), 4, 2, 174L },
                    { 150L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2456), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2458), 4, 2, 147L },
                    { 148L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2449), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2450), 2, 2, 145L },
                    { 210L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2704), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2706), 4, 1, 208L },
                    { 211L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2708), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2709), 5, 1, 209L },
                    { 212L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2711), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2713), 6, 1, 210L },
                    { 213L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2715), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2717), 1, 2, 211L },
                    { 214L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2719), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2720), 2, 2, 212L },
                    { 215L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2722), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2724), 3, 2, 213L },
                    { 216L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2727), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2729), 4, 2, 214L },
                    { 217L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2731), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2732), 5, 2, 215L },
                    { 218L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2735), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2736), 6, 2, 216L },
                    { 131L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2383), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2385), 1, 1, 128L },
                    { 132L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2387), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2388), 2, 1, 129L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 133L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2391), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2392), 3, 1, 130L },
                    { 149L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2453), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2454), 3, 2, 146L },
                    { 134L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2394), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2396), 4, 1, 131L },
                    { 136L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2403), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2404), 6, 1, 133L },
                    { 137L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2407), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2408), 1, 2, 134L },
                    { 138L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2410), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2412), 2, 2, 135L },
                    { 139L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2414), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2416), 3, 2, 136L },
                    { 140L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2419), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2421), 4, 2, 137L },
                    { 141L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2423), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2424), 5, 2, 138L },
                    { 142L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2426), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2428), 1, 1, 139L },
                    { 143L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2430), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2432), 2, 1, 140L },
                    { 144L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2434), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2436), 3, 1, 141L },
                    { 145L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2438), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2439), 4, 1, 142L },
                    { 146L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2441), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2443), 5, 1, 143L },
                    { 147L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2445), 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2447), 1, 2, 144L },
                    { 135L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2398), 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2400), 5, 1, 132L },
                    { 177L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2536), 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2537), 5, 2, 175L },
                    { 197L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2653), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2654), 1, 1, 195L },
                    { 198L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2657), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2659), 2, 1, 196L },
                    { 116L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2326), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2327), 2, 1, 113L },
                    { 117L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2330), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2332), 3, 1, 114L },
                    { 118L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2334), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2336), 4, 1, 115L },
                    { 119L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2338), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2339), 1, 2, 116L },
                    { 120L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2342), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2343), 2, 2, 117L },
                    { 121L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2345), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2347), 3, 2, 118L },
                    { 122L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2349), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2351), 4, 2, 119L },
                    { 123L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2353), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2354), 5, 2, 120L },
                    { 124L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2356), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2358), 3, 3, 121L },
                    { 125L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2360), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2362), 4, 3, 122L },
                    { 126L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2364), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2366), 1, 3, 123L },
                    { 127L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2368), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2369), 1, 4, 124L },
                    { 115L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2322), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2323), 1, 1, 112L },
                    { 128L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2372), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2373), 2, 4, 125L },
                    { 130L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2379), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2381), 4, 4, 127L },
                    { 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1859), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1860), 1, 1, 21L },
                    { 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1862), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1864), 2, 1, 22L },
                    { 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1866), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1868), 3, 1, 23L },
                    { 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1970), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1972), 4, 1, 24L },
                    { 25L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1975), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1976), 5, 1, 25L },
                    { 26L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1979), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1980), 6, 1, 26L },
                    { 27L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1982), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1984), 1, 2, 27L },
                    { 28L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1986), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1988), 2, 2, 28L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 29L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1990), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1991), 3, 2, 29L },
                    { 30L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1994), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1995), 4, 2, 30L },
                    { 31L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1998), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1999), 5, 2, 31L },
                    { 129L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2375), 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2377), 3, 4, 126L },
                    { 237L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2807), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2808), 5, 2, 235L },
                    { 236L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2803), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2805), 4, 2, 234L },
                    { 235L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2799), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2801), 3, 2, 233L },
                    { 199L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2661), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2663), 3, 1, 197L },
                    { 200L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2665), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2666), 4, 1, 198L },
                    { 201L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2669), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2670), 5, 1, 199L },
                    { 202L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2672), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2674), 6, 1, 200L },
                    { 203L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2676), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2678), 1, 2, 201L },
                    { 204L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2680), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2681), 2, 2, 202L },
                    { 205L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2684), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2685), 3, 2, 203L },
                    { 206L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2687), 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2689), 4, 2, 204L },
                    { 238L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2811), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2812), 1, 1, 236L },
                    { 239L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2814), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2816), 2, 1, 237L },
                    { 240L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2818), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2819), 3, 1, 238L },
                    { 241L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2822), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2823), 4, 1, 239L },
                    { 242L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2825), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2827), 5, 1, 240L },
                    { 243L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2829), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2831), 6, 1, 241L },
                    { 244L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2833), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2834), 1, 2, 242L },
                    { 245L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2837), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2838), 2, 2, 243L },
                    { 246L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2840), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2842), 3, 2, 244L },
                    { 247L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2844), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2846), 4, 2, 245L },
                    { 248L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2848), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2849), 5, 2, 246L },
                    { 249L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2851), 23L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2853), 6, 2, 247L },
                    { 228L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2772), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2774), 1, 1, 226L },
                    { 229L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2776), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2778), 2, 1, 227L },
                    { 230L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2780), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2781), 3, 1, 228L },
                    { 231L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2783), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2785), 4, 1, 229L },
                    { 232L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2787), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2789), 5, 1, 230L },
                    { 233L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2791), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2792), 1, 2, 231L },
                    { 234L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2795), 22L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2796), 2, 2, 232L },
                    { 209L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2700), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2701), 3, 1, 207L },
                    { 34L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2002), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2004), 6, 2, 32L },
                    { 208L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2695), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2697), 2, 1, 206L },
                    { 227L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2769), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2770), 5, 2, 225L },
                    { 73L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2126), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2128), 3, 2, 70L },
                    { 74L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2130), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2131), 3, 2, 71L },
                    { 75L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2135), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2136), 4, 2, 72L },
                    { 50L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2039), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2041), 1, 1, 47L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 51L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2043), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2045), 2, 1, 48L },
                    { 52L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2047), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2048), 3, 1, 49L },
                    { 53L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2051), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2052), 4, 1, 50L },
                    { 54L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2054), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2056), 1, 2, 51L },
                    { 55L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2058), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2060), 2, 2, 52L },
                    { 56L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2062), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2063), 3, 2, 53L },
                    { 57L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2066), 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2067), 4, 2, 54L },
                    { 76L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2138), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2140), 1, 1, 73L },
                    { 72L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2122), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2124), 2, 2, 69L },
                    { 77L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2142), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2144), 2, 1, 74L },
                    { 79L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2150), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2152), 1, 2, 76L },
                    { 80L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2154), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2156), 2, 2, 77L },
                    { 81L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2158), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2160), 3, 2, 78L },
                    { 82L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2162), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2163), 1, 3, 79L },
                    { 83L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2166), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2167), 2, 3, 80L },
                    { 84L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2169), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2171), 3, 3, 81L },
                    { 85L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2173), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2175), 4, 3, 82L },
                    { 86L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2177), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2178), 1, 4, 83L },
                    { 87L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2180), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2182), 2, 4, 84L },
                    { 88L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2184), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2186), 3, 4, 85L },
                    { 89L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2188), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2190), 4, 4, 86L },
                    { 90L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2192), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2193), 5, 4, 87L },
                    { 78L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2146), 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2147), 3, 1, 75L },
                    { 91L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2196), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2197), 1, 1, 88L },
                    { 71L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2119), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2120), 4, 1, 68L },
                    { 69L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2111), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2113), 2, 1, 66L },
                    { 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1763), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1773), 2, 1, 2L },
                    { 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1777), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1779), 3, 1, 3L },
                    { 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1781), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1783), 4, 1, 4L },
                    { 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1785), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1786), 5, 2, 5L },
                    { 6L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1798), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1799), 6, 2, 6L },
                    { 7L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1802), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1803), 7, 2, 7L },
                    { 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1806), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1807), 8, 2, 8L },
                    { 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1810), 1L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1811), 9, 2, 9L },
                    { 43L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2013), 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2015), 1, 1, 40L },
                    { 44L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2017), 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2018), 2, 1, 41L },
                    { 45L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2020), 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2022), 4, 1, 42L },
                    { 46L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2024), 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2026), 3, 1, 43L },
                    { 70L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2115), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2117), 3, 1, 67L },
                    { 47L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2028), 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2030), 1, 2, 44L },
                    { 49L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2036), 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2037), 3, 2, 46L },
                    { 58L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2069), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2071), 1, 1, 55L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 59L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2073), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2075), 2, 1, 56L },
                    { 60L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2078), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2079), 3, 1, 57L },
                    { 61L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2081), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2083), 4, 1, 58L },
                    { 62L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2085), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2087), 5, 1, 59L },
                    { 63L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2089), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2091), 1, 2, 60L },
                    { 64L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2093), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2094), 2, 2, 61L },
                    { 65L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2096), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2098), 3, 2, 62L },
                    { 66L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2100), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2102), 4, 2, 63L },
                    { 67L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2104), 4L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2105), 5, 2, 64L },
                    { 68L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2108), 5L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2109), 1, 1, 65L },
                    { 48L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2032), 3L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2034), 2, 2, 45L },
                    { 92L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2199), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2201), 2, 1, 89L },
                    { 93L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2203), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2204), 3, 1, 90L },
                    { 94L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2207), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2208), 4, 1, 91L },
                    { 179L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2544), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2546), 2, 1, 177L },
                    { 180L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2548), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2549), 3, 1, 178L },
                    { 181L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2552), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2553), 4, 1, 179L },
                    { 182L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2555), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2557), 1, 2, 180L },
                    { 183L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2559), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2561), 2, 2, 181L },
                    { 184L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2602), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2604), 3, 2, 182L },
                    { 185L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2607), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2608), 4, 2, 183L },
                    { 186L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2611), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2612), 1, 1, 184L },
                    { 187L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2615), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2616), 2, 1, 185L },
                    { 188L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2619), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2620), 3, 1, 186L },
                    { 189L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2622), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2624), 4, 1, 187L },
                    { 190L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2626), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2628), 5, 1, 188L },
                    { 178L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2539), 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2541), 1, 1, 176L },
                    { 191L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2630), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2632), 6, 1, 189L },
                    { 193L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2637), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2639), 2, 2, 191L },
                    { 194L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2641), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2643), 3, 2, 192L },
                    { 195L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2645), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2646), 4, 2, 193L },
                    { 196L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2649), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2650), 5, 2, 194L },
                    { 219L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2738), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2740), 1, 1, 217L },
                    { 220L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2742), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2744), 2, 1, 218L },
                    { 221L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2746), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2747), 3, 1, 219L },
                    { 222L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2750), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2751), 4, 1, 220L },
                    { 223L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2754), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2755), 1, 2, 221L },
                    { 224L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2757), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2759), 2, 2, 222L },
                    { 225L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2761), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2763), 3, 2, 223L },
                    { 226L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2765), 21L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2766), 4, 2, 224L },
                    { 192L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2634), 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2635), 1, 2, 190L },
                    { 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1855), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1857), 11, 2, 20L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 19L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1851), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1853), 10, 2, 19L },
                    { 18L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1847), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1849), 9, 2, 18L },
                    { 95L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2210), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2212), 1, 2, 92L },
                    { 96L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2214), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2216), 1, 3, 93L },
                    { 97L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2218), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2220), 2, 3, 94L },
                    { 98L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2222), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2223), 1, 4, 95L },
                    { 99L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2226), 8L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2227), 2, 4, 96L },
                    { 100L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2230), 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2231), 1, 1, 97L },
                    { 102L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2233), 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2235), 2, 1, 98L },
                    { 103L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2237), 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2239), 3, 1, 99L },
                    { 104L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2241), 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2243), 1, 2, 101L },
                    { 105L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2245), 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2246), 2, 2, 102L },
                    { 106L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2249), 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2250), 3, 2, 103L },
                    { 107L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2252), 9L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2254), 4, 2, 104L },
                    { 108L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2295), 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2297), 1, 1, 105L },
                    { 109L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2299), 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2301), 2, 1, 106L },
                    { 110L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2303), 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2305), 3, 1, 107L },
                    { 111L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2307), 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2309), 4, 1, 108L },
                    { 112L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2311), 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2312), 1, 2, 109L },
                    { 113L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2315), 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2316), 2, 2, 110L },
                    { 114L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2318), 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2320), 3, 2, 111L },
                    { 10L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1814), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1816), 1, 1, 10L },
                    { 11L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1818), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1820), 2, 1, 11L },
                    { 12L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1822), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1824), 3, 1, 12L },
                    { 13L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1826), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1827), 4, 1, 13L },
                    { 14L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1831), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1832), 5, 1, 14L },
                    { 15L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1835), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1836), 6, 2, 15L },
                    { 16L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1838), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1840), 7, 2, 16L },
                    { 17L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1842), 2L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(1844), 8, 2, 17L },
                    { 207L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2691), 20L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2693), 1, 1, 205L },
                    { 35L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2006), 24L, new DateTime(2023, 3, 30, 16, 50, 12, 142, DateTimeKind.Local).AddTicks(2008), 7, 2, 33L }
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
