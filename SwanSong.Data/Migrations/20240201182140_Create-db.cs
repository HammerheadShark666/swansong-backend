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
                    { 1, new DateTime(2024, 2, 1, 18, 21, 38, 776, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(6216), "England" },
                    { 2, new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7656), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7669), "Scotland" },
                    { 3, new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7677), "Wales" },
                    { 4, new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7681), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7684), "Northern Ireland" },
                    { 5, new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7690), "United States of America" },
                    { 6, new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7704), "Australia" },
                    { 7, new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 2, 1, 18, 21, 38, 780, DateTimeKind.Local).AddTicks(7710), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "USER", "USER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "RecordLabels",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6604), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6606), "United Artists" },
                    { 8, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6599), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6602), "Reprise" },
                    { 7, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6594), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6597), "Island Records" },
                    { 5, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6578), "Sony Music Entertainment" },
                    { 6, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6589), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6591), "Columbia Label Group" },
                    { 3, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6565), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6568), "RCA Records" },
                    { 2, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6561), "Swan Song Records" },
                    { 1, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(5419), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(5450), "Atlantic Records" },
                    { 4, new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 2, 1, 18, 21, 38, 782, DateTimeKind.Local).AddTicks(6573), "Universal Music Publishing Group" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 180L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9864), "6:53", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9866), "Forever" },
                    { 179L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9860), "2:51", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9862), "Now You See It (Now You Don't)" },
                    { 178L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9856), "5:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9858), "You're No Different" },
                    { 177L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9852), "4:32", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9854), "Bark at the Moon" },
                    { 176L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9846), "4:03", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9849), "Rock 'n' Roll Rebel" },
                    { 175L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9766), "4:30", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9768), "Darkness on the Edge of Town" },
                    { 173L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9758), "4:09", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9760), "Streets of Fire" },
                    { 172L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9754), "2:17", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9755), "Factory" },
                    { 171L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9749), "4:33", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9751), "The Promised Land" },
                    { 170L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9745), "6:53", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9747), "Racing in the Street" },
                    { 169L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9741), "2:51", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9743), "Candy's Room" },
                    { 174L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9762), "3:56", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9764), "Prove It All Night" },
                    { 181L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9869), "4:33", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9870), "So Tired" },
                    { 190L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9907), "4:50", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9908), "Shah Shah a Go Go" },
                    { 183L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9877), "4:09", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9879), "Spiders" },
                    { 184L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9881), "1:10", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9883), "Longships" },
                    { 185L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9885), "5:13", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9887), "The Raven" },
                    { 186L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9890), "2:24", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9892), "Dead Loss Angeles" },
                    { 187L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9894), "3:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9896), "Ice" },
                    { 188L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9898), "3:50", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9900), "Baroque Bordello" },
                    { 189L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9902), "3:32", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9904), "Nuclear Device(The Wizard of Aus)" },
                    { 168L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9737), "5:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9739), "Something in the Night" },
                    { 191L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9911), "4:09", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9912), "Don't Bring Harry" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 192L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9915), "2:30", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9917), "Duchess" },
                    { 193L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9919), "4:48", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9921), "Meninblack" },
                    { 194L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9923), "5:16", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9925), "Genetix" },
                    { 182L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9873), "2:17", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9875), "Waiting for Darkness" },
                    { 167L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9733), "4:32", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9735), "Adam Raised a Cain" },
                    { 150L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9691), "6:05", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9693), "Point Blank" },
                    { 158L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9725), "3:53", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9727), "Wreck on the Highway" },
                    { 131L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9610), "3:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9612), "Don't Stop" },
                    { 132L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9614), "3:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9616), "Go Your Own Way" },
                    { 133L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9619), "3:20", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9620), "Songbird" },
                    { 134L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9623), "4:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9625), "The Chain" },
                    { 135L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9627), "3:31", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9629), "You Make Loving Fun" },
                    { 136L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9631), "3:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9633), "I Don't Want to Know" },
                    { 137L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9637), "3:54", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9638), "Oh Daddy" },
                    { 138L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9641), "4:51", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9643), "Gold Dust Woman" },
                    { 139L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9645), "3:33", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9647), "The Ties That Bind" },
                    { 140L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9649), "4:02", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9651), "Sherry Darling" },
                    { 141L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9653), "3:04", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9655), "Jackson Cage" },
                    { 142L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9657), "2:42", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9659), "Two Hearts" },
                    { 143L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9661), "4:46", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9663), "Independence Day" },
                    { 144L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9666), "3:19", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9667), "Hungry Heart" },
                    { 145L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9670), "4:17", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9671), "Out in the Street" },
                    { 146L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9674), "3:10", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9676), "Crush on You" },
                    { 147L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9678), "2:36", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9680), "You Can Look (But You Better Not Touch)" },
                    { 148L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9682), "3:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9684), "I Wanna Marry You" },
                    { 149L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9687), "4:59", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9689), "The River" },
                    { 195L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9927), "4:32", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9929), "Nebraska" },
                    { 151L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9695), "3:02", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9697), "Cadillac Ranch" },
                    { 152L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9700), "3:34", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9702), "I'm a Rocker" },
                    { 153L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9704), "4:40", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9706), "Fade Away" },
                    { 154L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9708), "3:53", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9710), "Stolen Car" },
                    { 155L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9712), "4:04", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9714), "Ramrod" },
                    { 156L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9717), "5:27", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9718), "The Price You Pay" },
                    { 157L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9721), "8:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9722), "Drive All Night" },
                    { 166L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9729), "4:03", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9731), "Badlands" },
                    { 196L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9932), "4:00", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9933), "Atlantic City" },
                    { 205L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9969), "2:55", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9971), "Iron Fist" },
                    { 198L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9940), "3:44", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9942), "Johnny 99" },
                    { 230L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(73), "2:01", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(75), "Peggy Day" },
                    { 231L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(77), "3:18", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(79), "Lay Lady Lay" },
                    { 232L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(82), "2:23", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(83), "One More Night" },
                    { 233L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(86), "2:41", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(87), "Tell Me That It Isn't True" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 234L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(90), "1:37", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(92), "Country Pie" },
                    { 235L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(94), "3:23", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(96), "Tonight I'll Be Staying Here with You" },
                    { 236L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(98), "4:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(100), "Born in the U.S.A." },
                    { 237L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(102), "3:29", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(104), "Cover Me" },
                    { 238L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(106), "4:48", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(108), "Darlington County" },
                    { 239L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(110), "3:13", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(112), "Working on the Highway" },
                    { 240L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(114), "3:35", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(116), "Downbound Train" },
                    { 241L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(119), "2:40", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(120), "I'm on Fire" },
                    { 229L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(69), "2:23", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(71), "I Threw It All Away" },
                    { 242L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(123), "4:01", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(125), "No Surrender" },
                    { 244L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(131), "3:30", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(133), "I'm Goin' Down" },
                    { 245L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(135), "4:15", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(137), "Glory Days" },
                    { 246L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(139), "4:04", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(141), "Dancing in the Dark" },
                    { 247L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(143), "4:34", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(145), "My Hometown" },
                    { 248L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(148), "4:49", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(149), "Thunder Road" },
                    { 249L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(152), "3:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(153), "Tenth Avenue Freeze-Out" },
                    { 250L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(156), "3:00", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(158), "Night" },
                    { 251L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(160), "6:30", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(162), "Backstreets" },
                    { 252L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(164), "4:31", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(166), "Born to Run" },
                    { 253L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(168), "4:30", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(170), "She's the One" },
                    { 254L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(172), "3:18", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(174), "Meeting Across the River" },
                    { 255L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(177), "9:34", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(178), "Jungleland" },
                    { 243L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(127), "3:48", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(129), "Bobby Jean" },
                    { 228L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(65), "2:07", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(67), "To Be Alone with You" },
                    { 227L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(61), "3:12", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(63), "Nashville Skyline Rag" },
                    { 226L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(57), "3:41", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(59), "Girl from the North Country" },
                    { 199L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9944), "5:40", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9946), "Highway Patrolman" },
                    { 200L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9949), "3:17", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9950), "State Trooper" },
                    { 201L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9953), "3:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9954), "Used Cars" },
                    { 202L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9957), "2:58", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9959), "Open All Night" },
                    { 203L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9961), "5:07", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9963), "My Father's House" },
                    { 204L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9965), "4:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9967), "Reason to Believe" },
                    { 130L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9606), "2:02", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9608), "Never Going Back Again" },
                    { 206L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9974), "3:04", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9975), "Heart of Stone" },
                    { 207L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9978), "2:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9980), "I'm the Doctor" },
                    { 208L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9982), "3:10", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9984), "Go to Hell" },
                    { 209L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9986), "3:57", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9988), "Loser" },
                    { 210L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9990), "2:10", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9992), "Sex & Outrage" },
                    { 211L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9994), "3:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9996), "America" },
                    { 212L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9999), "2:41", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local), "Shut It Down" },
                    { 213L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(3), "3:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(4), "Speedfreak" },
                    { 214L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(7), "3:08", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(8), "(Don't Let 'Em) Grind Ya Down" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 215L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(11), "2:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(13), "(Don't Need) Religion" },
                    { 216L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(15), "2:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(17), "Bang to Rights" },
                    { 217L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(20), "4:03", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(21), "Stormbringer" },
                    { 218L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(24), "4:23", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(25), "Love Don't Mean a Thing" },
                    { 219L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(28), "4:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(30), "Holy Man" },
                    { 220L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(32), "5:05", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(34), "Hold On" },
                    { 221L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(36), "3:19", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(38), "Lady Double Dealer" },
                    { 222L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(40), "3:24", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(42), "You Can't Do It Right (With the One You Love)" },
                    { 223L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(44), "4:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(46), "High Ball Shooter" },
                    { 224L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(49), "4:05", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(50), "The Gypsy" },
                    { 225L, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(53), "3:14", null, new DateTime(2024, 2, 1, 18, 21, 38, 801, DateTimeKind.Local).AddTicks(55), "Soldier of Fortune" },
                    { 197L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9936), "4:08", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9938), "Mansion on the Hill" },
                    { 129L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9602), "4:14", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9604), "Dreams" },
                    { 119L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9561), "3:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9563), "Gypsy Eyes" },
                    { 127L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9594), "5:06", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9595), "Voodoo Child (Slight Return)" },
                    { 70L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9180), "4:49", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9182), "Four Sticks" },
                    { 71L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9185), "3:36", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9186), "Going to California" },
                    { 72L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9190), "7:08", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9192), "When the Levee Breaks" },
                    { 47L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9194), "5:32", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9196), "The Song Remains the Same" },
                    { 48L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9198), "7:39", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9200), "The Rain Song" },
                    { 49L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9202), "4:50", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9204), "Over the Hills and Far Away" },
                    { 50L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9206), "3:17", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9208), "The Crunge" },
                    { 51L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9211), "3:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9212), "Dancing Days" },
                    { 52L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9215), "4:23", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9217), "D'yer Mak'er" },
                    { 53L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9219), "7:00", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9221), "No Quarter" },
                    { 54L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9223), "4:31", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9225), "The Ocean" },
                    { 73L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9227), "4:13", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9229), "Custard Pie" },
                    { 69L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9175), "4:39", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9177), "Misty Mountain Hop" },
                    { 74L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9231), "5:36", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9233), "The Rover" },
                    { 76L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9240), "4:01", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9241), "Houses of the Holy" },
                    { 77L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9247), "5:35", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9249), "Trampled Under Foot" },
                    { 78L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9251), "8:37", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9253), "Kashmir" },
                    { 79L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9256), "8:44", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9257), "In the Light" },
                    { 80L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9260), "2:06", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9262), "Bron-Yr-Aur" },
                    { 81L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9264), "5:14", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9266), "Down by the Seaside" },
                    { 82L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9268), "6:31", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9270), "Ten Years Gone" },
                    { 83L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9272), "3:36", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9274), "Night Flight" },
                    { 84L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9276), "4:06", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9278), "The Wanton Song" },
                    { 85L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9280), "3:51", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9282), "Boogie with Stu" },
                    { 86L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9285), "4:24", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9286), "Black Country Woman" },
                    { 87L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9289), "4:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9290), "Sick Again" },
                    { 75L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9235), "11:04", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9237), "In My Time of Dying" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 68L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9170), "7:55", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9173), "Stairway to Heaven" },
                    { 67L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9029), "5:51", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9031), "The Battle of Evermore" },
                    { 66L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9025), "3:40", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9027), "Rock and Roll" },
                    { 1L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(7294), "2:46", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(7336), "Good Times Bad Times" },
                    { 2L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8859), "6:42", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8869), "Babe I'm Gonna Leave You" },
                    { 3L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8874), "6:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8876), "You Shook Me" },
                    { 4L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8879), "6:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8881), "Dazed and Confused" },
                    { 5L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8883), "4:34", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8885), "Your Time Is Gonna Come" },
                    { 6L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8921), "2:12", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8923), "Black Mountain Side" },
                    { 7L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8925), "2:30", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8927), "Communication Breakdown" },
                    { 8L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8929), "4:42", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8931), "I Can't Quit You Baby" },
                    { 9L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8933), "8:27", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8937), "How Many More Times" },
                    { 40L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8941), "5:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8943), "Whole Lotta Love" },
                    { 41L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8947), "4:33", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8949), "What Is and What Should Never Be" },
                    { 42L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8951), "4:21", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8953), "Thank You" },
                    { 43L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8955), "6:20", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8957), "The Lemon Song" },
                    { 44L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8960), " 4:14", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8961), "Heartbreaker" },
                    { 45L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8964), "2:39", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8966), "Living Loving Maid(She's Just a Woman)" },
                    { 46L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8968), "4:34", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8970), "Ramble On" },
                    { 55L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8972), "2:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8974), "Immigrant Song" },
                    { 56L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8983), "3:55", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8985), "Friends" },
                    { 57L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8987), "3:29", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8989), "Celebration Day" },
                    { 58L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8992), "7:25", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8994), "Since I've Been Loving You" },
                    { 59L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8996), "4:04", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(8998), "Out on the Tiles" },
                    { 60L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9000), "4:58", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9002), "Gallows Pole" },
                    { 61L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9004), "3:12", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9006), "Tangerine" },
                    { 62L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9009), "5:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9010), "That's the Way" },
                    { 63L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9013), "4:20", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9015), "Bron-Y-Aur Stomp" },
                    { 64L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9017), "3:41", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9019), "Hats Off to (Roy) Harper" },
                    { 65L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9021), "4:55", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9023), "Black Dog" },
                    { 88L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9293), "4:03", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9295), "Rock and Roll" },
                    { 89L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9297), "3:49", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9299), "Celebration Day" },
                    { 90L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9301), "6:00", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9303), "The Song Remains the Same" },
                    { 91L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9306), "8:24", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9307), "The Rain Song" },
                    { 22L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9440), "4:14", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9442), "In Bloom" },
                    { 23L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9444), "3:39", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9446), "Come as You Are" },
                    { 24L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9449), "3:03", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9450), "Breed" },
                    { 25L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9453), "4:17", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9454), "Lithium" },
                    { 26L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9457), "2:57", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9459), "Polly" },
                    { 27L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9502), "2:22", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9504), "Territorial Pissings" },
                    { 28L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9507), "3:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9509), "Drain You" },
                    { 29L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9511), "2:36", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9513), "Lounge Act" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 30L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9515), "3:32", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9517), "Stay Away" },
                    { 31L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9519), "3:16", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9521), "On a Plain" },
                    { 32L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9523), "3:52", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9525), "Something in the Way" },
                    { 33L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9528), "6:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9529), "Endless, Nameless" },
                    { 21L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9436), "5:01", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9438), "Smells Like Teen Spirit" },
                    { 112L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9532), "1:19", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9534), "...And the Gods Made Love" },
                    { 114L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9540), "2:25", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9542), "Crosstown Traffic" },
                    { 115L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9544), "14:50", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9546), "Voodoo Chile" },
                    { 116L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9548), "2:47", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9550), "Little Miss Strange" },
                    { 117L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9552), "3:21", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9554), "Long Hot Summer Night" },
                    { 118L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9557), "4:04", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9558), "Come On (Part 1)" },
                    { 120L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9565), "3:33", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9567), "Burning of the Midnight Lamp" },
                    { 121L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9569), "3:39", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9571), "Rainy Day, Dream Away" },
                    { 122L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9573), "13:25", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9575), "1983... (A Merman I Should Turn to Be)" },
                    { 123L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9577), "0:58", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9579), "Moon, Turn the Tides....Gently Gently Away" },
                    { 124L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9581), "4:19", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9583), "Still Raining, Still Dreaming" },
                    { 125L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9586), "4:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9587), "House Burning Down" },
                    { 126L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9590), "3:54", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9591), "All Along the Watchtower" },
                    { 113L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9536), "2:08", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9538), "Have You Ever Been (To Electric Ladyland)" },
                    { 128L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9598), "2:43", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9600), "Second Hand News" },
                    { 20L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9432), "3:22", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9434), "Crazy Lady Blues" },
                    { 18L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9424), "2:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9426), "Wretched Wilbur" },
                    { 92L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9310), "26:53", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9312), "Dazed and Confused" },
                    { 93L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9314), "12:30", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9316), "No Quarter" },
                    { 94L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9318), "10:58", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9320), "Stairway to Heaven" },
                    { 95L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9322), "12:47", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9324), "Moby Dick" },
                    { 96L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9328), "14:24", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9330), "Whole Lotta Love" },
                    { 97L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9332), "10:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9334), "Achilles Last Stand" },
                    { 98L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9336), "6:21", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9338), "For Your Life" },
                    { 99L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9340), "2:58", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9342), "Royal Orleans" },
                    { 101L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9344), "6:27", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9346), "Nobody's Fault but Mine" },
                    { 102L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9348), "4:10", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9350), "Candy Store Rock" },
                    { 103L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9353), "4:42", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9354), "Hots On for Nowhere" },
                    { 104L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9357), "9:27", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9358), "Tea for One" },
                    { 19L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9428), "3:27", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9430), "The North Star Grassman and the Ravens" },
                    { 105L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9361), "6:48", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9363), "In the Evening" },
                    { 107L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9369), "6:08", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9371), "Fool in the Rain" },
                    { 108L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9373), "3:15", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9375), "Hot Dog" },
                    { 109L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9378), "10:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9379), "Carouselambra" },
                    { 110L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9382), "5:51", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9384), "All My Love" },
                    { 111L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9387), "5:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9389), "I'm Gonna Crawl" },
                    { 10L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9391), "4:28", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9393), "Late November" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 11L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9395), "4:07", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9397), "Blackwaterside(Traditional) " },
                    { 12L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9399), "3:09", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9401), "The Sea Captain" },
                    { 13L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9403), "3:20", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9405), "Down in the Flood(Bob Dylan)" },
                    { 14L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9407), "4:38", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9409), "John the Gun" },
                    { 15L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9411), "4:26", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9413), "Next Time Around" },
                    { 16L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9415), "3:24", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9417), "The Optimist" },
                    { 17L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9420), "2:42", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9421), "Let’s Jump the Broomstick(Charles Robins)" },
                    { 106L, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9365), "4:11", null, new DateTime(2024, 2, 1, 18, 21, 38, 800, DateTimeKind.Local).AddTicks(9367), "South Bound Saurez" }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(4653), "Island Studios London, Sound Techniques London" },
                    { 2, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(5297), "914 Sound Studios, Blauvelt, New York" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "AddedDate", "CountryId", "DisbandYear", "FormationYear", "ModifiedDate", "Name", "Photo" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(5185), 1, 1980, 1967, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(5201), "Led Zeppelin", "458eb53a-aba7-42a2-a5ed-526da552966e.jpg" },
                    { 11L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8688), 2, null, 1977, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8689), "Simple Minds", "2a39824d-1c56-46fe-b4bc-b7e87dfb7bb3.jpg" },
                    { 8L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8618), 3, null, 1986, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8619), "Manic Street Preachers", "8117dfa2-41a4-4be1-a33f-fd7484ae5d7a.jpg" },
                    { 3L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8590), 5, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8592), "Bruce Springsteen", "32ce9c93-9129-4bff-b166-db5ada039757.jpg" },
                    { 4L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8595), 5, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8597), "John Denver", "f94fb03e-c368-4562-9c66-2b2db5722252.jpg" },
                    { 7L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8613), 5, null, 1962, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8615), "Bob Dylan", "567552b5-27d5-4a6e-acc5-449017fcd47e.jpg" },
                    { 17L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8714), 5, null, 1987, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8716), "Nirvana", "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
                    { 19L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8724), 5, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8725), "Tori Amos", "22d853a2-cd81-4362-a6a5-d15c17c83194.jpg" },
                    { 14L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8701), 6, null, 1973, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8702), "ACDC", "85d9174f-1f0d-4221-8635-f86c211caa4d.jpg" },
                    { 20L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8728), 1, null, 1975, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8729), "U2", "af794a29-19e8-440f-a5e2-113319932b40.jpg" },
                    { 15L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8705), 5, 1970, 1961, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8707), "Jimi Hendrix", "f304b989-f26e-4aa5-8c78-1d1b49850bee.jpg" },
                    { 16L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8710), 1, null, 1967, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8711), "Fleetwood Mac", "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
                    { 13L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8696), 1, null, 1975, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8698), "Motorhead", "2691c7fa-2546-401e-a10b-1608e00711d2.jpg" },
                    { 12L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8692), 1, null, 1968, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8694), "Deep Purple", "5863254c-693f-43e3-b0f8-a7ebdeb8ec33.jpg" },
                    { 10L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8682), 1, null, 1974, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8684), "The Stranglers", "8b728b1e-c506-4d08-b87d-9f320f4cc920.jpg" },
                    { 9L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8622), 1, null, 1979, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8624), "Ozzy Osbourne", "99cc2dbe-5671-4eca-947d-8f7a4f1759af.jpg" },
                    { 6L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8609), 1, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8611), "John Lennon", "e0ceb7ed-5481-4cc1-926f-59cf31fd2e69.jpg" },
                    { 18L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8719), 1, null, 1975, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8721), "Kate Bush", "909e5592-09a3-4018-a3a8-e067612c7388.jpg" },
                    { 5L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8599), 1, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8601), "Elton John", "64fa7eb5-dca2-4ed3-a465-fa6904bba895.jpg" },
                    { 2L, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8571), 1, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 786, DateTimeKind.Local).AddTicks(8584), "Sandy Denny", "0ed76f7d-e5da-4e5b-87b0-a8ecb4a165cd.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 42, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1492), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1494), "Bexleyheath, Kent" },
                    { 43, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1497), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1499), "Newton, North Carolina" },
                    { 44, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1502), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1505), "Dublin, Ireland" },
                    { 45, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1507), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1509), "Barking, Essex" },
                    { 46, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1512), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1514), "Chinnor, Oxfordshire" },
                    { 47, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1517), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1519), "Artane, Dublin" },
                    { 22, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1283), 2, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1285), "Toryglen, Glasgow" },
                    { 6, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1204), 3, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1206), "Pontypool" },
                    { 24, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1293), 2, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1296), "Dundee" },
                    { 26, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1303), 3, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1306), "Brecon" },
                    { 41, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1484), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1488), "Warren, Ohio" },
                    { 5, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1191), 5, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1193), "Seattle" },
                    { 10, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1226), 5, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1228), "Long Branch, New Jersey" },
                    { 11, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1231), 5, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1233), "Monterey Bay" },
                    { 15, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1252), 5, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1254), "Duluth, Minnesota" },
                    { 23, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1288), 2, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1290), "Glasgow" },
                    { 40, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1479), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1481), "Compton, California" },
                    { 34, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1346), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1348), "Redruth, Cornwall, Gateshead" },
                    { 38, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1468), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1471), "Palo Alto, California" },
                    { 1, new DateTime(2024, 2, 1, 18, 21, 38, 784, DateTimeKind.Local).AddTicks(9206), 1, new DateTime(2024, 2, 1, 18, 21, 38, 784, DateTimeKind.Local).AddTicks(9251), "Aston, Birmingham" },
                    { 2, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1159), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1175), "Birmingham" },
                    { 3, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1180), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1182), "West Bromwich" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1185), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1187), "Heston" },
                    { 7, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1209), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1211), "Sidcup" },
                    { 8, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1213), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1216), "Reddich" },
                    { 9, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1220), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1222), "Merton Park, London" },
                    { 12, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1236), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1238), "Pinner, Middlesex" },
                    { 13, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1242), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1244), "Liverpool, Lancashire" },
                    { 16, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1256), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1259), "Marston Green, Warwickshire" },
                    { 17, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1262), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1264), "Tufnell Park, North London" },
                    { 18, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1268), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1270), "Notting Hill, London" },
                    { 19, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1272), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1275), "Brighton, London" },
                    { 21, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1277), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1280), "Ilford, Essex" },
                    { 25, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1298), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1300), "Nottingham" },
                    { 27, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1309), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1312), "Chiswick, London" },
                    { 28, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1314), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1317), "Stoke-on-Trent, Staffordshire" },
                    { 29, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1320), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1322), "London" },
                    { 30, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1326), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1328), "Twickenham, Middlesex" },
                    { 32, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1335), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1337), "Romford, Essex" },
                    { 33, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1339), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1343), "Dunston, Gateshead" },
                    { 31, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1330), 6, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1332), "Melbourne, Victoria" },
                    { 35, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1353), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1355), "Phoenix, Arizona" },
                    { 36, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1455), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1458), "Ealing, Middlesex" },
                    { 37, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1463), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1465), "Bouth, Lancashire" },
                    { 39, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1474), 1, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1476), "Aberdeen, Washington" },
                    { 14, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1247), 7, new DateTime(2024, 2, 1, 18, 21, 38, 785, DateTimeKind.Local).AddTicks(1249), "Vancover" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AddedDate", "Arrangers", "ArtistId", "Artwork", "Engineers", "LabelId", "ModifiedDate", "Name", "Photo", "Producers", "RecordedDate", "ReleaseDate", "StudioId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(5485), null, 1L, null, null, 1, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(5513), "Led Zeppelin 1", "11d15486-fefc-463c-8b7d-c755b08466dc.jpg", null, null, new DateTime(1969, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9560), null, 3L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9561), "Nebraska", "6e2e5c69-75cd-480e-9b28-6d3726df576f.jpg", null, null, null, null },
                    { 21L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9568), null, 12L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9570), "Stormbringer", "d96d1eac-982a-41a2-b2dd-ff65707940e1.jpg", null, null, null, null },
                    { 22L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9572), null, 7L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9574), "Nashville Skyline", "722792d3-787b-4698-916d-0ff766e68fd6.jpg", null, null, null, null },
                    { 15L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9484), null, 3L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9486), "Darkness on the Edge of Town", "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg", null, null, null, null },
                    { 11L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9466), null, 15L, null, null, 8, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9468), "Electric Ladyland", "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg", null, null, new DateTime(1968, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9479), null, 3L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9481), "Born To Run", "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg", null, null, null, null },
                    { 17L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9553), null, 10L, null, null, 9, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9555), "The Raven", "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg", null, null, new DateTime(1979, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9580), null, 17L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9582), "Nevermind", "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg", null, null, new DateTime(1991, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9488), null, 9L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9490), "Bark At The Moon", "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg", null, null, null, null },
                    { 12L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9471), null, 16L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9472), "Rumours", "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg", "Fleetwood Mac, Ken Caillat, Richard Dashut", null, new DateTime(1977, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9475), null, 3L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9477), "The River", "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg", null, null, null, null },
                    { 20L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9564), null, 13L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9566), "Iron Fist", "39c3f690-87cd-4cd2-8a9a-54ba8af3a50f.jpg", null, null, null, null },
                    { 2L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(8140), "Sandy Denny", 2L, "Keef", "John Wood", 7, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(8151), "The North Star Grassman and the Ravens", "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg", "John Wood, Richard Thompson, Sandy Denny", new DateTime(1971, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9461), null, 1L, null, null, 2, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9463), "In Through The OutDoor", "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg", null, null, new DateTime(1979, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9456), null, 1L, null, null, 2, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9457), "Presence", "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg", null, null, new DateTime(1976, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9451), null, 1L, null, null, 2, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9452), "The Song Remains The Same", "d2710986-0720-4231-8582-4383eb9ffe12.jpg", null, null, new DateTime(1976, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9446), null, 1L, null, null, 2, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9448), "Physical Graffiti", "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg", null, null, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9442), null, 1L, null, null, 1, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9444), "Houses of the Holy", "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg", null, null, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9428), null, 1L, null, null, 1, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9430), "Led Zeppelin IV", "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg", null, null, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9423), null, 1L, null, null, 1, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9425), "Led Zeppelin 3", "9cf368d3-db16-4120-af40-7dd697b934fa.jpg", null, null, new DateTime(1970, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9408), null, 1L, null, null, 1, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9417), "Led Zeppelin 2", "ee552af1-7a5a-457b-b336-823bc1285dac.jpg", null, null, new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9576), null, 3L, null, null, null, new DateTime(2024, 2, 1, 18, 21, 38, 794, DateTimeKind.Local).AddTicks(9578), "Born In The Usa", "66c0e775-c22b-427d-a327-e6bfd9b5673e.jpg", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 13L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(916), 8L, 6L, null, new DateTime(1968, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sean", true, "Anthony", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(917), "18bc8103-9380-4bde-ae46-01b8160887a3.jpg", "Sean Moore", "Moore" },
                    { 11L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(907), 8L, 6L, null, new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Dean", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(909), "3d39a220-fd12-4533-adcb-7741b0c4f8ab.jpg", "James Dean Bradfield", "Bradfield" },
                    { 21L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1021), 11L, 24L, null, new DateTime(1962, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ged", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1022), "4b9eee24-56a3-493f-9dfa-3159a80396fd.jpg", "Ged Grimes", "Grimes" },
                    { 20L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1016), 11L, 23L, null, new DateTime(1959, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1018), "83a85c7e-609d-420a-b380-d2ff190a452a.jpg", "Charlie Burchill", "Burchill" },
                    { 12L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(911), 8L, 6L, null, new DateTime(1969, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicholas", true, "Allen", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(913), "450e17c5-c352-452f-a1d8-4b6c4154cf9d.jpg", "Nicky Wire", "Jones" },
                    { 47L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1144), 15L, 14L, null, new DateTime(1942, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", true, "Allen", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1146), "9a7bff27-93b5-43cf-8fed-743074f6182b.jpg", "Jimi Hendrix", "Hendrix" },
                    { 7L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(885), 4L, 11L, null, new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(887), "08dc96d6-bbe4-429d-90b6-094b04ae8f9d.jpg", "John Denver", "Denver" },
                    { 10L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(902), 7L, 15L, null, new DateTime(1941, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Allen", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(904), "bb655ce4-9a14-4805-b6d3-9f84a26a250a.jpg", "Bob Dylan", "Zimmerman" },
                    { 19L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1011), 11L, 22L, null, new DateTime(1959, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1013), "60267eb0-f2f5-48c8-b245-83df9a7986bd.jpg", "Jim Kerr", "Kerr" },
                    { 38L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1103), 17L, 39L, null, new DateTime(1967, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurt", true, "Donald", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1104), "10ec8163-a6de-4c64-bd80-3a949886905e.jpg", "Kurt Cobain", "Cobain" },
                    { 39L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1108), 17L, 40L, null, new DateTime(1965, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Krist", true, "Anthony", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1110), "657837dd-f7c1-4ed5-a58e-39cc0e279d83.jpg", "Krist Novoselic", "Novoselic" },
                    { 40L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1112), 17L, 41L, null, new DateTime(1969, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Eric", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1114), "7dd70c41-8fcf-4cd1-a825-78fb30c7c0ca.jpg", "Dave Grohl", "Grohl" },
                    { 42L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1122), 19L, 43L, null, new DateTime(1963, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Myra", true, "Ellen", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1123), "d4f764a9-75d6-44ff-9263-94d2cd30703e.jpg", "Tori Amos", "Amos" },
                    { 28L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1056), 14L, 23L, null, new DateTime(1955, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Angus", true, "McKinnon", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1057), "273cc6e3-995f-44ef-9665-4b06d76ce7eb.jpg", "Angus Young", "Young" },
                    { 29L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1060), 14L, 23L, null, new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malcolm", true, "Mitchell", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1062), "c79c5ae5-8678-488d-a9f0-6bc18e83abb3.jpg", "Malcolm Young", "Young" },
                    { 30L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1065), 14L, 29L, null, new DateTime(1954, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phillip", true, "Hugh Norman Witschke", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1066), "44b350e7-ed7f-4e3c-b6e1-5b286836e383.jpg", "Phil Rudd", "Rudzevecuis" },
                    { 6L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(872), 3L, 10L, null, new DateTime(1949, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(880), "734770c0-05f1-4bd9-ae4b-748cbdc64167.jpg", "Bruce Springsteen", "Springsteen" },
                    { 46L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1140), 20L, 47L, null, new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lawrence", true, " Joseph", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1141), "9f24c9d9-6b23-4594-bdf3-f71da4311af7.jpg", "Larry Mullen Jr.", "Mullen Jr." },
                    { 34L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1084), 16L, 35L, null, new DateTime(1948, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie", true, "Lynn", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1086), "88153d6b-9d63-4f87-b49b-a660683f7adf.jpg", "Stevie Nicks", "Nicks" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 44L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1131), 20L, 45L, null, new DateTime(1961, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Howell", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1132), "7ad787f2-d136-4d35-9fbf-be9bcddd34c3.jpg", "The Edge", "Evans" },
                    { 1L, new DateTime(2024, 2, 1, 18, 21, 38, 792, DateTimeKind.Local).AddTicks(5432), 1L, 4L, null, new DateTime(1944, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Patrick", new DateTime(2024, 2, 1, 18, 21, 38, 792, DateTimeKind.Local).AddTicks(5476), "a0033bc9-c0b8-4248-8e31-f9d3938e1e34.jpg", "Jimmy Page", "Page" },
                    { 2L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(487), 1L, 3L, null, new DateTime(1948, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Anthony", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(507), "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg", "Robert Plant", "Plant" },
                    { 3L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(514), 1L, 7L, null, new DateTime(1946, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Jones", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(516), "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg", "John Paul Jones", "Paul" },
                    { 4L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(520), 1L, 8L, null, new DateTime(1948, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Bonham", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(522), "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg", "John Bonham", "Henry" },
                    { 5L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(525), 2L, 9L, null, new DateTime(1947, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandra", true, "Elene MacLean", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(526), "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg", "Sandy Denny", "Denny" },
                    { 8L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(890), 5L, 12L, null, new DateTime(1947, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elton", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(892), "06cb3132-accb-4b58-a532-47bb49bdc29b.jpg", "Elton John", "John" },
                    { 9L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(895), 6L, 13L, null, new DateTime(1940, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(897), "69e916a9-94e6-47ce-9762-1ca6650fa434.jpg", "John Lennon", "Lennon" },
                    { 14L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(984), 9L, 16L, null, new DateTime(1948, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Michael", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(986), "9366d83c-e30d-47ab-924e-f61a42d17efe.jpg", "Ozzy Osbourne", "Osbourne" },
                    { 15L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(990), 10L, 17L, null, new DateTime(1949, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hugh", true, "Alan", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(992), "e962871a-23ec-4049-a772-d5ef262c9adb.jpg", "Hugh Cornwell", "Cornwell" },
                    { 16L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(995), 10L, 18L, null, new DateTime(1952, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Jacques", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(996), "f5fc3019-2a61-4d80-b071-351845c5992c.jpg", "Jean-Jacques Burnel", "Burnel" },
                    { 17L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1001), 10L, 19L, null, new DateTime(1949, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", true, "Paul", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1002), "8f567b5f-7982-44d9-b4b5-e9337595f8e1.jpg", "David Greenfield", "Greenfield" },
                    { 18L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1007), 10L, 21L, null, new DateTime(1938, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "John", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1009), "9833b134-75c7-456a-a1d2-f5a286dc892e.jpg", "Jet Black", "Duffy" },
                    { 22L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1025), 12L, 25L, null, new DateTime(1948, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, "Anderson", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1027), "5166d6e2-42a6-44f6-bbca-ffb41733ef48.jpg", "Ian Paice", "Paice" },
                    { 23L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1030), 12L, 26L, null, new DateTime(1945, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", true, "David", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1032), "85717e2f-36bf-4c2b-8920-f42c90817ce8.jpg", "Roger Glover", "Glover" },
                    { 24L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1034), 12L, 27L, null, new DateTime(1945, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1036), "883f0129-b075-454d-a68c-e3d7f07bbdda.jpg", "Ian Gillan", "Gillan" },
                    { 25L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1041), 13L, 28L, null, new DateTime(1954, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian", true, "Fraser", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1043), "1a7a6266-a256-4b08-87f0-640d8e3ace60.jpg", "Lemmy", "Kilmister" },
                    { 26L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1046), 13L, 29L, null, new DateTime(1954, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", true, "John", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1048), "04f9d8e6-1b84-4a0a-800e-1716732aaf5e.jpg", "Phil 'Philthy Animal' Taylor", "Taylor" },
                    { 27L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1051), 13L, 30L, null, new DateTime(1950, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", true, "Allan", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1053), "1dbe7e17-567f-4f12-883d-b253ef2d25a2.jpg", "'Fast' Eddie Clarke", "Clarke" },
                    { 33L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1079), 16L, 34L, null, new DateTime(1947, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", true, "John Kells", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1081), "75ce147a-b9e9-49f4-8a71-c4f36dc9d3cd.jpg", "Mick Fleetwood", "Fleetwood" },
                    { 31L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1069), 14L, 32L, null, new DateTime(1949, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clifford", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1071), "0445ae2a-a3ef-4636-9850-2c4420d5f91e.jpg", "Cliff Williams", "Williams" },
                    { 35L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1089), 16L, 36L, null, new DateTime(1945, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Graham", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1091), "8c1fc01a-79e2-479c-b92d-ec6f9ba9135d.jpg", "John McVie", "McVie" },
                    { 36L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1094), 16L, 37L, null, new DateTime(1943, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christine", true, "Anne", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1095), "1fa68d08-2072-47cc-ad2b-96a27af42351.jpg", "Christine McVie", "Perfect" },
                    { 37L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1098), 16L, 38L, null, new DateTime(1949, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lindsey", true, "Adams", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1100), "8154868a-c01d-49e4-85d1-f85c0b0c9302.jpg", "Lindsey Buckingham", "Buckingham" },
                    { 41L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1117), 18L, 42L, null, new DateTime(1958, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catherine", true, null, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1118), "dfdae93a-d393-41e9-ba05-78970f0b1ee1.jpg", "Kate Bush", "Bush" },
                    { 43L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1126), 20L, 44L, null, new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", true, "David", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1128), "5b1d901a-ad92-40ad-8439-af151e472b5d.jpg", "Bono", "Hewson" },
                    { 45L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1135), 20L, 46L, null, new DateTime(1960, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adam", true, "Charles", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1137), "73375c6c-cd17-41c4-824c-c5f8af912a28.jpg", "Adam Clayton", "Clayton" },
                    { 32L, new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1074), 14L, 33L, null, new DateTime(1947, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "Francis", new DateTime(2024, 2, 1, 18, 21, 38, 793, DateTimeKind.Local).AddTicks(1076), "3ab89167-5769-478e-95a8-29277316e028.jpg", "Brian Johnson", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(6581), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(6618), 1, 1, 1L },
                    { 152L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8790), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8792), 6, 2, 149L },
                    { 153L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8794), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8795), 1, 3, 150L },
                    { 154L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8798), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8799), 2, 3, 151L },
                    { 155L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8801), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8803), 3, 3, 152L },
                    { 156L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8805), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8807), 4, 3, 153L },
                    { 157L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8809), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8810), 5, 3, 154L },
                    { 158L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8812), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8814), 1, 4, 155L },
                    { 159L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8816), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8817), 2, 4, 156L },
                    { 160L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8820), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8821), 3, 4, 157L },
                    { 161L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8823), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8825), 4, 4, 158L },
                    { 250L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9163), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9164), 1, 1, 248L },
                    { 251L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9166), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9168), 2, 1, 249L },
                    { 151L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8787), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8788), 5, 2, 148L },
                    { 252L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9170), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9171), 3, 1, 250L },
                    { 254L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9177), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9179), 1, 2, 252L },
                    { 255L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9181), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9182), 2, 2, 253L },
                    { 256L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9184), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9186), 3, 2, 254L },
                    { 257L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9188), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9190), 4, 2, 255L },
                    { 168L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8827), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8828), 1, 1, 166L },
                    { 169L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8830), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8832), 2, 1, 167L },
                    { 170L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8834), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8835), 3, 1, 168L },
                    { 171L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8838), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8839), 4, 1, 169L },
                    { 172L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8841), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8843), 5, 1, 170L },
                    { 173L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8845), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8846), 1, 2, 171L },
                    { 174L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8848), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8850), 2, 2, 172L },
                    { 175L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8852), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8854), 3, 2, 173L },
                    { 253L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9174), 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9175), 4, 1, 251L },
                    { 176L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8856), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8857), 4, 2, 174L },
                    { 150L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8783), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8785), 4, 2, 147L },
                    { 148L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8776), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8777), 2, 2, 145L },
                    { 210L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9017), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9018), 4, 1, 208L },
                    { 211L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9020), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9022), 5, 1, 209L },
                    { 212L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9024), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9025), 6, 1, 210L },
                    { 213L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9027), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9029), 1, 2, 211L },
                    { 214L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9031), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9033), 2, 2, 212L },
                    { 215L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9035), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9036), 3, 2, 213L },
                    { 216L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9038), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9040), 4, 2, 214L },
                    { 217L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9042), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9044), 5, 2, 215L },
                    { 218L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9046), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9047), 6, 2, 216L },
                    { 131L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8712), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8714), 1, 1, 128L },
                    { 132L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8716), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8717), 2, 1, 129L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 133L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8720), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8721), 3, 1, 130L },
                    { 149L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8779), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8781), 3, 2, 146L },
                    { 134L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8723), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8725), 4, 1, 131L },
                    { 136L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8731), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8733), 6, 1, 133L },
                    { 137L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8735), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8736), 1, 2, 134L },
                    { 138L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8738), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8740), 2, 2, 135L },
                    { 139L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8742), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8743), 3, 2, 136L },
                    { 140L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8747), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8749), 4, 2, 137L },
                    { 141L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8751), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8752), 5, 2, 138L },
                    { 142L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8754), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8756), 1, 1, 139L },
                    { 143L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8758), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8759), 2, 1, 140L },
                    { 144L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8761), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8763), 3, 1, 141L },
                    { 145L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8765), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8767), 4, 1, 142L },
                    { 146L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8769), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8770), 5, 1, 143L },
                    { 147L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8772), 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8774), 1, 2, 144L },
                    { 135L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8728), 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8729), 5, 1, 132L },
                    { 177L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8859), 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8861), 5, 2, 175L },
                    { 197L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8932), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8934), 1, 1, 195L },
                    { 198L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8936), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8937), 2, 1, 196L },
                    { 116L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8616), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8617), 2, 1, 113L },
                    { 117L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8619), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8621), 3, 1, 114L },
                    { 118L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8623), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8625), 4, 1, 115L },
                    { 119L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8627), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8628), 1, 2, 116L },
                    { 120L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8630), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8632), 2, 2, 117L },
                    { 121L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8634), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8635), 3, 2, 118L },
                    { 122L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8637), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8639), 4, 2, 119L },
                    { 123L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8641), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8643), 5, 2, 120L },
                    { 124L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8686), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8688), 3, 3, 121L },
                    { 125L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8691), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8692), 4, 3, 122L },
                    { 126L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8694), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8696), 1, 3, 123L },
                    { 127L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8698), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8699), 1, 4, 124L },
                    { 115L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8612), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8613), 1, 1, 112L },
                    { 128L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8701), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8703), 2, 4, 125L },
                    { 130L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8709), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8710), 4, 4, 127L },
                    { 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8231), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8233), 1, 1, 21L },
                    { 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8235), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8236), 2, 1, 22L },
                    { 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8238), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8240), 3, 1, 23L },
                    { 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8242), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8243), 4, 1, 24L },
                    { 25L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8246), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8247), 5, 1, 25L },
                    { 26L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8249), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8251), 6, 1, 26L },
                    { 27L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8253), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8254), 1, 2, 27L },
                    { 28L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8256), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8258), 2, 2, 28L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 29L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8260), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8262), 3, 2, 29L },
                    { 30L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8264), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8265), 4, 2, 30L },
                    { 31L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8269), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8271), 5, 2, 31L },
                    { 129L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8705), 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8707), 3, 4, 126L },
                    { 237L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9115), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9117), 5, 2, 235L },
                    { 236L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9112), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9113), 4, 2, 234L },
                    { 235L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9108), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9110), 3, 2, 233L },
                    { 199L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8939), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8941), 3, 1, 197L },
                    { 200L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8978), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8980), 4, 1, 198L },
                    { 201L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8982), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8984), 5, 1, 199L },
                    { 202L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8986), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8988), 6, 1, 200L },
                    { 203L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8990), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8992), 1, 2, 201L },
                    { 204L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8994), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8996), 2, 2, 202L },
                    { 205L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8998), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8999), 3, 2, 203L },
                    { 206L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9001), 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9003), 4, 2, 204L },
                    { 238L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9119), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9121), 1, 1, 236L },
                    { 239L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9123), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9124), 2, 1, 237L },
                    { 240L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9126), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9128), 3, 1, 238L },
                    { 241L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9130), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9131), 4, 1, 239L },
                    { 242L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9134), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9135), 5, 1, 240L },
                    { 243L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9137), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9139), 6, 1, 241L },
                    { 244L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9141), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9142), 1, 2, 242L },
                    { 245L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9144), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9146), 2, 2, 243L },
                    { 246L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9148), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9150), 3, 2, 244L },
                    { 247L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9152), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9153), 4, 2, 245L },
                    { 248L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9155), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9157), 5, 2, 246L },
                    { 249L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9159), 23L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9160), 6, 2, 247L },
                    { 228L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9082), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9083), 1, 1, 226L },
                    { 229L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9085), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9087), 2, 1, 227L },
                    { 230L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9089), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9091), 3, 1, 228L },
                    { 231L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9093), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9095), 4, 1, 229L },
                    { 232L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9097), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9098), 5, 1, 230L },
                    { 233L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9100), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9102), 1, 2, 231L },
                    { 234L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9105), 22L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9106), 2, 2, 232L },
                    { 209L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9012), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9014), 3, 1, 207L },
                    { 34L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8273), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8274), 6, 2, 32L },
                    { 208L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9008), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9010), 2, 1, 206L },
                    { 227L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9078), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9080), 5, 2, 225L },
                    { 73L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8460), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8461), 3, 2, 70L },
                    { 74L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8464), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8465), 3, 2, 71L },
                    { 75L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8469), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8470), 4, 2, 72L },
                    { 50L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8376), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8378), 1, 1, 47L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 51L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8380), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8381), 2, 1, 48L },
                    { 52L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8383), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8385), 3, 1, 49L },
                    { 53L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8387), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8388), 4, 1, 50L },
                    { 54L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8390), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8392), 1, 2, 51L },
                    { 55L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8394), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8395), 2, 2, 52L },
                    { 56L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8398), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8399), 3, 2, 53L },
                    { 57L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8401), 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8403), 4, 2, 54L },
                    { 76L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8472), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8474), 1, 1, 73L },
                    { 72L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8456), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8458), 2, 2, 69L },
                    { 77L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8476), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8477), 2, 1, 74L },
                    { 79L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8484), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8485), 1, 2, 76L },
                    { 80L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8488), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8489), 2, 2, 77L },
                    { 81L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8491), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8493), 3, 2, 78L },
                    { 82L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8496), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8497), 1, 3, 79L },
                    { 83L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8500), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8501), 2, 3, 80L },
                    { 84L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8503), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8505), 3, 3, 81L },
                    { 85L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8507), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8509), 4, 3, 82L },
                    { 86L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8511), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8512), 1, 4, 83L },
                    { 87L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8514), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8516), 2, 4, 84L },
                    { 88L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8518), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8519), 3, 4, 85L },
                    { 89L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8521), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8523), 4, 4, 86L },
                    { 90L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8525), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8527), 5, 4, 87L },
                    { 78L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8480), 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8482), 3, 1, 75L },
                    { 91L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8529), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8530), 1, 1, 88L },
                    { 71L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8453), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8454), 4, 1, 68L },
                    { 69L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8445), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8447), 2, 1, 66L },
                    { 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8141), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8150), 2, 1, 2L },
                    { 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8153), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8155), 3, 1, 3L },
                    { 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8158), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8159), 4, 1, 4L },
                    { 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8162), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8163), 5, 2, 5L },
                    { 6L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8172), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8174), 6, 2, 6L },
                    { 7L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8176), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8178), 7, 2, 7L },
                    { 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8180), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8181), 8, 2, 8L },
                    { 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8183), 1L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8186), 9, 2, 9L },
                    { 43L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8350), 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8352), 1, 1, 40L },
                    { 44L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8354), 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8356), 2, 1, 41L },
                    { 45L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8358), 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8359), 4, 1, 42L },
                    { 46L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8362), 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8363), 3, 1, 43L },
                    { 70L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8449), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8451), 3, 1, 67L },
                    { 47L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8365), 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8367), 1, 2, 44L },
                    { 49L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8372), 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8374), 3, 2, 46L },
                    { 58L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8405), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8406), 1, 1, 55L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 59L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8409), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8411), 2, 1, 56L },
                    { 60L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8413), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8414), 3, 1, 57L },
                    { 61L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8416), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8418), 4, 1, 58L },
                    { 62L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8420), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8421), 5, 1, 59L },
                    { 63L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8423), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8425), 1, 2, 60L },
                    { 64L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8427), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8429), 2, 2, 61L },
                    { 65L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8431), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8432), 3, 2, 62L },
                    { 66L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8434), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8436), 4, 2, 63L },
                    { 67L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8438), 4L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8440), 5, 2, 64L },
                    { 68L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8442), 5L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8443), 1, 1, 65L },
                    { 48L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8369), 3L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8370), 2, 2, 45L },
                    { 92L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8532), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8534), 2, 1, 89L },
                    { 93L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8536), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8538), 3, 1, 90L },
                    { 94L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8540), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8541), 4, 1, 91L },
                    { 179L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8867), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8869), 2, 1, 177L },
                    { 180L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8871), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8872), 3, 1, 178L },
                    { 181L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8874), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8876), 4, 1, 179L },
                    { 182L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8878), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8879), 1, 2, 180L },
                    { 183L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8881), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8883), 2, 2, 181L },
                    { 184L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8885), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8887), 3, 2, 182L },
                    { 185L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8889), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8890), 4, 2, 183L },
                    { 186L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8892), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8894), 1, 1, 184L },
                    { 187L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8896), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8897), 2, 1, 185L },
                    { 188L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8899), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8901), 3, 1, 186L },
                    { 189L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8903), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8905), 4, 1, 187L },
                    { 190L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8907), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8908), 5, 1, 188L },
                    { 178L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8863), 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8865), 1, 1, 176L },
                    { 191L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8910), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8912), 6, 1, 189L },
                    { 193L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8918), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8919), 2, 2, 191L },
                    { 194L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8921), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8923), 3, 2, 192L },
                    { 195L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8925), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8926), 4, 2, 193L },
                    { 196L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8928), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8930), 5, 2, 194L },
                    { 219L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9049), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9051), 1, 1, 217L },
                    { 220L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9053), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9054), 2, 1, 218L },
                    { 221L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9056), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9058), 3, 1, 219L },
                    { 222L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9060), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9062), 4, 1, 220L },
                    { 223L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9064), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9065), 1, 2, 221L },
                    { 224L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9067), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9069), 2, 2, 222L },
                    { 225L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9071), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9073), 3, 2, 223L },
                    { 226L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9075), 21L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9076), 4, 2, 224L },
                    { 192L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8914), 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8915), 1, 2, 190L },
                    { 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8228), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8229), 11, 2, 20L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 19L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8224), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8225), 10, 2, 19L },
                    { 18L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8220), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8222), 9, 2, 18L },
                    { 95L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8543), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8545), 1, 2, 92L },
                    { 96L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8547), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8548), 1, 3, 93L },
                    { 97L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8550), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8552), 2, 3, 94L },
                    { 98L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8554), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8556), 1, 4, 95L },
                    { 99L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8558), 8L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8559), 2, 4, 96L },
                    { 100L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8561), 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8563), 1, 1, 97L },
                    { 102L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8565), 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8566), 2, 1, 98L },
                    { 103L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8568), 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8570), 3, 1, 99L },
                    { 104L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8572), 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8574), 1, 2, 101L },
                    { 105L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8576), 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8577), 2, 2, 102L },
                    { 106L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8579), 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8581), 3, 2, 103L },
                    { 107L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8583), 9L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8584), 4, 2, 104L },
                    { 108L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8586), 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8588), 1, 1, 105L },
                    { 109L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8590), 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8591), 2, 1, 106L },
                    { 110L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8594), 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8595), 3, 1, 107L },
                    { 111L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8597), 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8599), 4, 1, 108L },
                    { 112L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8601), 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8602), 1, 2, 109L },
                    { 113L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8604), 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8606), 2, 2, 110L },
                    { 114L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8608), 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8610), 3, 2, 111L },
                    { 10L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8188), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8190), 1, 1, 10L },
                    { 11L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8192), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8194), 2, 1, 11L },
                    { 12L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8196), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8197), 3, 1, 12L },
                    { 13L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8201), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8203), 4, 1, 13L },
                    { 14L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8205), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8206), 5, 1, 14L },
                    { 15L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8209), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8210), 6, 2, 15L },
                    { 16L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8212), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8214), 7, 2, 16L },
                    { 17L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8216), 2L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8217), 8, 2, 17L },
                    { 207L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9005), 20L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(9006), 1, 1, 205L },
                    { 35L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8277), 24L, new DateTime(2024, 2, 1, 18, 21, 38, 813, DateTimeKind.Local).AddTicks(8278), 7, 2, 33L }
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
