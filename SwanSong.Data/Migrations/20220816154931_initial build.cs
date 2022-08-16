using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SwanSong.Data.Migrations
{
    public partial class initialbuild : Migration
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
                    { 1, new DateTime(2022, 8, 16, 16, 49, 31, 71, DateTimeKind.Local).AddTicks(908), new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(7960), "England" },
                    { 2, new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8909), new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8920), "Scotland" },
                    { 3, new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8923), new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8924), "Wales" },
                    { 4, new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8926), new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8928), "Northern Ireland" },
                    { 5, new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8932), "United States of America" },
                    { 6, new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8934), new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8935), "Australia" },
                    { 7, new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8937), new DateTime(2022, 8, 16, 16, 49, 31, 73, DateTimeKind.Local).AddTicks(8939), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "72e19a3f-bc76-465e-b1d4-83fbded7c49c", "USER", "USER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2a2eaa7d-2ecb-4b35-99a3-90cf0daac298", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "RecordLabels",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9392), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9394), "United Artists" },
                    { 8, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9389), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9390), "Reprise" },
                    { 7, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9385), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9387), "Island Records" },
                    { 5, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9378), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9379), "Sony Music Entertainment" },
                    { 6, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9381), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9383), "Columbia Label Group" },
                    { 3, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9370), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9372), "RCA Records" },
                    { 2, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9360), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9368), "Swan Song Records" },
                    { 1, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(8724), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(8741), "Atlantic Records" },
                    { 4, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9374), new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9376), "Universal Music Publishing Group" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 40L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(436), "5:38", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(438), "Whole Lotta Love" },
                    { 30L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(400), "3:32", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(401), "Stay Away" },
                    { 31L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(403), "3:16", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(405), "On a Plain" },
                    { 32L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(407), "3:52", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(409), "Something in the Way" },
                    { 33L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(411), "6:43", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(412), "Endless, Nameless" },
                    { 34L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(414), "1:10", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(416), "Longships" },
                    { 35L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(418), "5:13", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(420), "The Raven" },
                    { 36L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(422), "2:24", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(423), "Dead Loss Angeles" },
                    { 37L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(425), "3:26", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(427), "Ice" },
                    { 38L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(429), "3:50", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(431), "Baroque Bordello" },
                    { 39L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(433), "3:32", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(434), "Nuclear Device(The Wizard of Aus)" },
                    { 41L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(440), "4:33", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(442), "What Is and What Should Never Be" },
                    { 51L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(476), "3:43", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(478), "Dancing Days" },
                    { 43L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(447), "6:20", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(449), "The Lemon Song" },
                    { 44L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(451), " 4:14", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(452), "Heartbreaker" },
                    { 45L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(454), "2:39", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(456), "Living Loving Maid(She's Just a Woman)" },
                    { 46L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(458), "4:34", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(460), "Ramble On" },
                    { 47L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(462), "5:32", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(463), "The Song Remains the Same" },
                    { 48L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(465), "7:39", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(467), "The Rain Song" },
                    { 49L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(469), "4:50", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(470), "Over the Hills and Far Away" },
                    { 50L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(472), "3:17", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(474), "The Crunge" },
                    { 29L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(396), "2:36", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(398), "Lounge Act" },
                    { 52L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(536), "4:23", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(538), "D'yer Mak'er" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 53L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(541), "7:00", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(542), "No Quarter" },
                    { 54L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(544), "4:31", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(546), "The Ocean" },
                    { 42L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(444), "4:21", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(445), "Thank You" },
                    { 28L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(392), "3:43", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(394), "Drain You" },
                    { 19L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(359), "3:27", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(360), "The North Star Grassman and the Ravens" },
                    { 26L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(384), "2:57", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(386), "Polly" },
                    { 1L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(9266), "2:46", null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(9275), "Good Times Bad Times" },
                    { 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(286), "6:42", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(294), "Babe I'm Gonna Leave You" },
                    { 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(299), "6:28", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(301), "You Shook Me" },
                    { 4L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(303), "6:28", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(305), "Dazed and Confused" },
                    { 5L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(307), "4:34", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(309), "Your Time Is Gonna Come" },
                    { 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(311), "2:12", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(312), "Black Mountain Side" },
                    { 7L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(314), "2:30", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(316), "Communication Breakdown" },
                    { 8L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(318), "4:42", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(320), "I Can't Quit You Baby" },
                    { 9L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(322), "8:27", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(323), "How Many More Times" },
                    { 10L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(325), "4:28", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(327), "Late November" },
                    { 11L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(329), "4:07", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(331), "Blackwaterside(Traditional) " },
                    { 12L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(333), "3:09", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(335), "The Sea Captain" },
                    { 13L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(337), "3:20", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(338), "Down in the Flood(Bob Dylan)" },
                    { 14L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(340), "4:38", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(342), "John the Gun" },
                    { 15L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(344), "4:26", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(346), "Next Time Around" },
                    { 16L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(348), "3:24", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(349), "The Optimist" },
                    { 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(351), "2:42", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(353), "Let’s Jump the Broomstick(Charles Robins)" },
                    { 18L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(355), "2:38", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(357), "Wretched Wilbur" },
                    { 20L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(362), "3:22", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(364), "Crazy Lady Blues" },
                    { 21L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(366), "5:01", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(367), "Smells Like Teen Spirit" },
                    { 22L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(369), "4:14", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(371), "In Bloom" },
                    { 23L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(373), "3:39", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(375), "Come as You Are" },
                    { 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(377), "3:03", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(378), "Breed" },
                    { 25L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(380), "4:17", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(382), "Lithium" },
                    { 27L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(389), "Pissings    2:22", null, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(390), "Territorial" }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(2601), new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(2610), "Island Studios London, Sound Techniques London" },
                    { 2, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(3185), new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(3193), "914 Sound Studios, Blauvelt, New York" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "AddedDate", "CountryId", "DisbandYear", "FormationYear", "ModifiedDate", "Name", "Photo" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(1948), 1, 1980, 1967, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(1956), "Led Zeppelin", "458eb53a-aba7-42a2-a5ed-526da552966e.jpg" },
                    { 8L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5186), 3, null, 1986, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5188), "Manic Street Preachers", "8117dfa2-41a4-4be1-a33f-fd7484ae5d7a.jpg" },
                    { 11L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5204), 2, null, 1977, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5207), "Simple Minds", "2a39824d-1c56-46fe-b4bc-b7e87dfb7bb3.jpg" },
                    { 7L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5180), 5, null, 1962, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5182), "Bob Dylan", "567552b5-27d5-4a6e-acc5-449017fcd47e.jpg" },
                    { 15L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5227), 5, 1970, 1961, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5229), "Jimi Hendrix", "f44802e4-ab03-4d2c-be3e-c094eced3c99.jpg" },
                    { 17L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5238), 5, null, 1987, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5240), "Nirvana", "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
                    { 19L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5249), 5, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5251), "Tori Amos", "default-artist-image.jpg" },
                    { 14L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5221), 6, null, 1973, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5223), "ACDC", "85d9174f-1f0d-4221-8635-f86c211caa4d.jpg" },
                    { 4L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5163), 5, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5165), "John Denver", "f94fb03e-c368-4562-9c66-2b2db5722252.jpg" },
                    { 20L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5254), 1, null, 1975, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5256), "U2", "default-artist-image.jpg" },
                    { 3L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5155), 5, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5158), "Bruce Springsteen", "32ce9c93-9129-4bff-b166-db5ada039757.jpg" },
                    { 16L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5233), 1, null, 1967, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5235), "Fleetwood Mac", "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
                    { 13L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5215), 1, null, 1975, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5218), "Motorhead", "2691c7fa-2546-401e-a10b-1608e00711d2.jpg" },
                    { 12L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5210), 1, null, 1968, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5212), "Deep Purple", "5863254c-693f-43e3-b0f8-a7ebdeb8ec33.jpg" },
                    { 10L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5198), 1, null, 1974, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5201), "The Stranglers", "8b728b1e-c506-4d08-b87d-9f320f4cc920.jpg" },
                    { 9L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5192), 1, null, 1979, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5194), "Ozzy Osbourne", "99cc2dbe-5671-4eca-947d-8f7a4f1759af.jpg" },
                    { 6L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5174), 1, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5176), "John Lennon", "e0ceb7ed-5481-4cc1-926f-59cf31fd2e69.jpg" },
                    { 5L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5168), 1, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5171), "Elton John", "64fa7eb5-dca2-4ed3-a465-fa6904bba895.jpg" },
                    { 2L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(4954), 1, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5134), "Sandy Denny", "0ed76f7d-e5da-4e5b-87b0-a8ecb4a165cd.jpg" },
                    { 18L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5243), 1, null, 1975, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(5246), "Kate Bush", "default-artist-image.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BirthPlaces",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 11, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(805), 5, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(806), "Monterey Bay" },
                    { 10, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(801), 5, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(803), "Long Branch, New Jersey" },
                    { 5, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(783), 5, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(785), "Seattle" },
                    { 14, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(815), 7, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(817), "Vancouver" },
                    { 13, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(812), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(813), "Liverpool, Lancashire" },
                    { 12, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(808), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(810), "Pinner, Middlesex" },
                    { 9, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(798), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(799), "Merton Park, London" },
                    { 8, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(794), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(796), "Reddich" },
                    { 7, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(790), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(792), "Sidcup" },
                    { 4, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(779), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(781), "Heston" },
                    { 3, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(776), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(777), "West Bromwich" },
                    { 2, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(765), 1, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(773), "Birmingham" },
                    { 1, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9952), 1, new DateTime(2022, 8, 16, 16, 49, 31, 74, DateTimeKind.Local).AddTicks(9961), "Aston, Birmingham" },
                    { 6, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(787), 3, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(788), "Pontypool" }
                });

            migrationBuilder.InsertData(
                table: "SongWriter",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "PersonId", "SongId" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3879), new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3880), 4L, 1L },
                    { 1, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3047), new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3055), 1L, 1L },
                    { 2, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3865), new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3872), 2L, 1L },
                    { 3, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3875), new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3877), 3L, 1L },
                    { 5, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3882), new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(3884), 5L, 10L }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AddedDate", "Arrangers", "ArtistId", "Artwork", "Engineers", "LabelId", "Length", "ModifiedDate", "Name", "Photo", "Producers", "RecordedDate", "ReleaseDate", "StudioId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(4858), null, 1L, null, null, 1, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(4869), "Led Zeppelin 1", "11d15486-fefc-463c-8b7d-c755b08466dc.jpg", null, null, new DateTime(1969, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8360), null, 15L, null, null, 8, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8362), "Electric Ladyland", "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg", null, null, new DateTime(1968, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8478), null, 7L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8479), "Nashville Skyline", "default-album-image.jpg", null, null, null, null },
                    { 23L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8482), null, 3L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8483), "Born In The Usa", "default-album-image.jpg", null, null, null, null },
                    { 19L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8467), null, 3L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8468), "Nebraska", "default-album-image.jpg", null, null, null, null },
                    { 15L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8376), null, 3L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8378), "Darkness on the Edge of Town", "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg", null, null, null, null },
                    { 14L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8373), null, 3L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8374), "Born To Run", "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg", null, null, null, null },
                    { 13L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8369), null, 3L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8371), "The River", "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg", null, null, null, null },
                    { 12L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8365), null, 16L, null, null, null, "39:43", new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8366), "Rumours", "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg", "Fleetwood Mac, Ken Caillat, Richard Dashut", null, new DateTime(1977, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8470), null, 13L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8472), "Iron Fist", "default-album-image.jpg", null, null, null, null },
                    { 21L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8474), null, 12L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8476), "Stormbringer", "default-album-image.jpg", null, null, null, null },
                    { 18L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8463), null, 10L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8464), "Men In Black", "default-album-image.jpg", null, null, null, null },
                    { 17L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8457), null, 10L, null, null, 9, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8460), "The Raven", "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg", null, null, new DateTime(1979, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8380), null, 9L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8382), "Bark At The Moon", "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg", null, null, null, null },
                    { 24L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8485), null, 17L, null, null, null, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8487), "Nevermind", "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg", null, null, new DateTime(1991, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8348), null, 1L, null, null, 2, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8349), "The Song Remains The Same", "d2710986-0720-4231-8582-4383eb9ffe12.jpg", null, null, new DateTime(1976, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8315), null, 1L, null, null, 1, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8323), "Led Zeppelin 2", "ee552af1-7a5a-457b-b336-823bc1285dac.jpg", null, null, new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(6932), "Sandy Denny", 2L, "Keef", "John Wood", 7, "39:41", new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(6941), "The North Star Grassman and the Ravens", "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg", "John Wood, Richard Thompson, Sandy Denny", new DateTime(1971, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8329), null, 1L, null, null, 1, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8331), "Led Zeppelin 3", "9cf368d3-db16-4120-af40-7dd697b934fa.jpg", null, null, new DateTime(1970, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8333), null, 1L, null, null, 1, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8335), "Led Zeppelin IV", "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg", null, null, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8356), null, 1L, null, null, 2, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8357), "In Through The OutDoor", "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg", null, null, new DateTime(1979, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8352), null, 1L, null, null, 2, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8353), "Presence", "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg", null, null, new DateTime(1976, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8338), null, 1L, null, null, 1, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8340), "Houses of the Holy", "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg", null, null, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8342), null, 1L, null, null, 2, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(8344), "Physical Graffiti", "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg", null, null, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "BirthPlaceId1", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 7L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1898), 4L, 11L, null, new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1899), null, "John Denver", "Denver" },
                    { 6L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1886), 3L, 10L, null, new DateTime(1949, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", true, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1893), null, "Bruce Springsteen", "Springsteen" },
                    { 8L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1904), 5L, 12L, null, new DateTime(1947, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elton", true, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1905), null, "Elton John", "John" },
                    { 1L, new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(7321), 1L, 4L, null, new DateTime(1944, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Patrick", new DateTime(2022, 8, 16, 16, 49, 31, 75, DateTimeKind.Local).AddTicks(7618), "jimmy-page.jpg", "Jimmy Page", "Page" },
                    { 2L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1562), 1L, 3L, null, new DateTime(1948, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Anthony", new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1576), "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg", "Robert Plant", "Plant" },
                    { 3L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1581), 1L, 7L, null, new DateTime(1946, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Jones", new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1583), "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg", "John Paul Jones", "Paul" },
                    { 4L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1587), 1L, 8L, null, new DateTime(1948, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Bonham", new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1588), "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg", "John Bonham", "Henry" },
                    { 10L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1914), 15L, 14L, null, new DateTime(1942, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", true, "Allen", new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1915), null, "Jimi Hendrix", "Hendrix" },
                    { 5L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1592), 2L, 9L, null, new DateTime(1947, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandra", true, "Elene MacLean", new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1594), "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg", "Sandy Denny", "Denny" },
                    { 9L, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1909), 6L, 13L, null, new DateTime(1940, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2022, 8, 16, 16, 49, 31, 76, DateTimeKind.Local).AddTicks(1911), null, "John Lennon", "Lennon" }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(1051), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(1059), 1, 1, 1L },
                    { 15L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2296), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2298), 6, 2, 15L },
                    { 16L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2300), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2302), 7, 2, 16L },
                    { 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2311), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2313), 8, 2, 17L },
                    { 18L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2315), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2317), 9, 2, 18L },
                    { 19L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2319), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2320), 10, 2, 19L },
                    { 20L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2322), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2324), 11, 2, 20L },
                    { 36L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2388), 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2390), 7, 2, 34L },
                    { 37L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2392), 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2394), 1, 1, 35L },
                    { 38L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2397), 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2399), 2, 1, 36L },
                    { 39L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2401), 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2402), 3, 1, 37L },
                    { 40L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2405), 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2406), 4, 1, 38L },
                    { 41L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2408), 17L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2410), 5, 1, 39L },
                    { 21L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2326), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2328), 1, 1, 21L },
                    { 22L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2339), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2341), 2, 1, 22L },
                    { 23L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2343), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2344), 3, 1, 23L },
                    { 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2346), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2348), 4, 1, 24L },
                    { 25L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2350), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2352), 5, 1, 25L },
                    { 26L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2354), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2355), 6, 1, 26L },
                    { 27L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2357), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2359), 1, 2, 27L },
                    { 28L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2361), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2362), 2, 2, 28L },
                    { 29L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2364), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2366), 3, 2, 29L },
                    { 30L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2374), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2375), 4, 2, 30L },
                    { 31L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2377), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2379), 5, 2, 31L },
                    { 14L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2293), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2294), 5, 1, 14L },
                    { 13L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2289), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2291), 4, 1, 13L },
                    { 12L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2285), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2287), 3, 1, 12L },
                    { 11L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2282), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2283), 2, 1, 11L },
                    { 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2241), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2249), 2, 1, 2L },
                    { 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2252), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2253), 3, 1, 3L },
                    { 4L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2256), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2257), 4, 1, 4L },
                    { 5L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2260), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2261), 5, 2, 5L },
                    { 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2263), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2265), 6, 2, 6L },
                    { 7L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2267), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2269), 7, 2, 7L },
                    { 8L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2271), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2272), 8, 2, 8L },
                    { 9L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2274), 1L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2276), 9, 2, 9L },
                    { 43L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2412), 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2413), 1, 1, 40L },
                    { 44L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2415), 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2417), 2, 1, 41L },
                    { 45L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2419), 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2421), 4, 1, 42L },
                    { 34L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2381), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2382), 6, 2, 32L },
                    { 46L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2423), 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2424), 3, 1, 43L },
                    { 48L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2430), 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2432), 2, 2, 45L }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 49L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2434), 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2435), 3, 2, 46L },
                    { 50L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2437), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2439), 1, 1, 47L },
                    { 51L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2441), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2443), 2, 1, 48L },
                    { 52L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2445), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2446), 3, 1, 49L },
                    { 53L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2448), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2450), 4, 1, 50L },
                    { 54L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2452), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2453), 1, 2, 51L },
                    { 55L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2456), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2457), 2, 2, 52L },
                    { 56L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2463), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2464), 3, 2, 53L },
                    { 57L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2466), 6L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2468), 4, 2, 54L },
                    { 10L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2278), 2L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2280), 1, 1, 10L },
                    { 47L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2426), 3L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2428), 1, 2, 44L },
                    { 35L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2385), 24L, new DateTime(2022, 8, 16, 16, 49, 31, 77, DateTimeKind.Local).AddTicks(2386), 7, 2, 33L }
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
