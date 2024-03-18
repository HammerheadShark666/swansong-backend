using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "SWSG_Account",
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
                    table.PrimaryKey("PK_SWSG_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWSG_Country",
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
                    table.PrimaryKey("PK_SWSG_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWSG_RecordLabel",
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
                    table.PrimaryKey("PK_SWSG_RecordLabel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWSG_Studio",
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
                    table.PrimaryKey("PK_SWSG_Studio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWSG_RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_SWSG_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_RefreshToken_SWSG_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "SWSG_Account",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SWSG_Artist",
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
                    table.PrimaryKey("PK_SWSG_Artist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_Artist_SWSG_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SWSG_Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SWSG_BirthPlace",
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
                    table.PrimaryKey("PK_SWSG_BirthPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_BirthPlace_SWSG_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SWSG_Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SWSG_Album",
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
                    table.PrimaryKey("PK_SWSG_Album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_Album_SWSG_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "SWSG_Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SWSG_Album_SWSG_RecordLabel_LabelId",
                        column: x => x.LabelId,
                        principalTable: "SWSG_RecordLabel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SWSG_Album_SWSG_Studio_StudioId",
                        column: x => x.StudioId,
                        principalTable: "SWSG_Studio",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SWSG_Member",
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
                    BirthPlaceId = table.Column<int>(type: "int", nullable: true),
                    IsSongWriter = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWSG_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_Member_SWSG_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "SWSG_Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SWSG_Member_SWSG_BirthPlace_BirthPlaceId",
                        column: x => x.BirthPlaceId,
                        principalTable: "SWSG_BirthPlace",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SWSG_Song",
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
                    table.PrimaryKey("PK_SWSG_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_Song_SWSG_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "SWSG_Member",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SWSG_AlbumSong",
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
                    table.PrimaryKey("PK_SWSG_AlbumSong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_AlbumSong_SWSG_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "SWSG_Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SWSG_AlbumSong_SWSG_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "SWSG_Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SWSG_SongWriter",
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
                    table.PrimaryKey("PK_SWSG_SongWriter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_SongWriter_SWSG_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "SWSG_Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "b38c4c03-5476-471f-bbed-4800b69a8bb5", "USER", "USER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "42fdc14d-43b7-4995-93b0-6951e2487635", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Account",
                columns: new[] { "Id", "AcceptTerms", "Created", "Email", "FirstName", "LastName", "PasswordHash", "PasswordReset", "ResetToken", "ResetTokenExpires", "Role", "Title", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test100@hotmail.com", "test", "test", "$2a$11$6J/RawAXn5hbcQwiVor7A.dEtLcMcUF8BI/EOMrAa2002hNJB8ZKC", null, "142CEC560EBE8EA56F8344E178948EE76022B02B0D407A974611AFCDA7849FCD83826607543C0CA0", null, 0, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "SWSG_Country",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6846), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6892), "England" },
                    { 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6903), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6905), "Scotland" },
                    { 3, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6910), "Wales" },
                    { 4, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6913), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6915), "Northern Ireland" },
                    { 5, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6920), "United States of America" },
                    { 6, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6927), "Australia" },
                    { 7, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6931), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_RecordLabel",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7369), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7378), "Atlantic Records" },
                    { 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7387), "Swan Song Records" },
                    { 3, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7392), "RCA Records" },
                    { 4, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7394), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7396), "Universal Music Publishing Group" },
                    { 5, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7401), "Sony Music Entertainment" },
                    { 6, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7406), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7408), "Columbia Label Group" },
                    { 7, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7412), "Island Records" },
                    { 8, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7414), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7416), "Reprise" },
                    { 9, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7420), "United Artists" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Song",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8927), "2:46", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8931), "Good Times Bad Times" },
                    { 2L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8941), "6:42", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8943), "Babe I'm Gonna Leave You" },
                    { 3L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8946), "6:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8948), "You Shook Me" },
                    { 4L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8952), "6:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8959), "Dazed and Confused" },
                    { 5L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8965), "4:34", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8967), "Your Time Is Gonna Come" },
                    { 6L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8971), "2:12", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8973), "Black Mountain Side" },
                    { 7L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8976), "2:30", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8978), "Communication Breakdown" },
                    { 8L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8981), "4:42", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8983), "I Can't Quit You Baby" },
                    { 9L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8986), "8:27", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8988), "How Many More Times" },
                    { 10L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9689), "4:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9692), "Late November" },
                    { 11L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9695), "4:07", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9698), "Blackwaterside(Traditional) " },
                    { 12L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9701), "3:09", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9704), "The Sea Captain" },
                    { 13L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9707), "3:20", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9713), "Down in the Flood(Bob Dylan)" },
                    { 14L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9721), "4:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9726), "John the Gun" },
                    { 15L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9729), "4:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9735), "Next Time Around" },
                    { 16L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9740), "3:24", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9742), "The Optimist" },
                    { 17L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9746), "2:42", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9749), "Let’s Jump the Broomstick(Charles Robins)" },
                    { 18L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9758), "2:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9761), "Wretched Wilbur" },
                    { 19L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9766), "3:27", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9772), "The North Star Grassman and the Ravens" },
                    { 20L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9779), "3:22", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9803), "Crazy Lady Blues" },
                    { 21L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9810), "5:01", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9813), "Smells Like Teen Spirit" },
                    { 22L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9817), "4:14", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9823), "In Bloom" },
                    { 23L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9833), "3:39", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9835), "Come as You Are" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Song",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 24L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9838), "3:03", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9843), "Breed" },
                    { 25L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9851), "4:17", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9853), "Lithium" },
                    { 26L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9859), "2:57", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9865), "Polly" },
                    { 27L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9868), "2:22", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9870), "Territorial Pissings" },
                    { 28L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9873), "3:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9876), "Drain You" },
                    { 29L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9879), "2:36", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9881), "Lounge Act" },
                    { 30L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9884), "3:32", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9887), "Stay Away" },
                    { 31L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9890), "3:16", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9892), "On a Plain" },
                    { 32L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9894), "3:52", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9896), "Something in the Way" },
                    { 33L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9899), "6:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9901), "Endless, Nameless" },
                    { 40L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8992), "5:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8994), "Whole Lotta Love" },
                    { 41L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8996), "4:33", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8998), "What Is and What Should Never Be" },
                    { 42L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9003), "4:21", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9010), "Thank You" },
                    { 43L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9014), "6:20", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9018), "The Lemon Song" },
                    { 44L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9026), " 4:14", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9028), "Heartbreaker" },
                    { 45L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9032), "2:39", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9038), "Living Loving Maid(She's Just a Woman)" },
                    { 46L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9042), "4:34", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9044), "Ramble On" },
                    { 47L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9218), "5:32", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9222), "The Song Remains the Same" },
                    { 48L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9230), "7:39", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9231), "The Rain Song" },
                    { 49L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9236), "4:50", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9241), "Over the Hills and Far Away" },
                    { 50L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9246), "3:17", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9248), "The Crunge" },
                    { 51L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9255), "3:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9259), "Dancing Days" },
                    { 52L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9262), "4:23", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9268), "D'yer Mak'er" },
                    { 53L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9273), "7:00", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9275), "No Quarter" },
                    { 54L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9281), "4:31", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9287), "The Ocean" },
                    { 55L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9052), "2:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9056), "Immigrant Song" },
                    { 56L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9062), "3:55", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9069), "Friends" },
                    { 57L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9072), "3:29", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9074), "Celebration Day" },
                    { 58L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9084), "7:25", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9086), "Since I've Been Loving You" },
                    { 59L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9088), "4:04", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9095), "Out on the Tiles" },
                    { 60L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9100), "4:58", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9102), "Gallows Pole" },
                    { 61L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9108), "3:12", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9114), "Tangerine" },
                    { 62L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9116), "5:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9120), "That's the Way" },
                    { 63L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9128), "4:20", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9130), "Bron-Y-Aur Stomp" },
                    { 64L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9134), "3:41", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9140), "Hats Off to (Roy) Harper" },
                    { 65L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9144), "4:55", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9146), "Black Dog" },
                    { 66L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9154), "3:40", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9158), "Rock and Roll" },
                    { 67L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9161), "5:51", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9167), "The Battle of Evermore" },
                    { 68L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9173), "7:55", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9175), "Stairway to Heaven" },
                    { 69L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9182), "4:39", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9186), "Misty Mountain Hop" },
                    { 70L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9189), "4:49", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9194), "Four Sticks" },
                    { 71L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9201), "3:36", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9202), "Going to California" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Song",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 72L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9210), "7:08", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9215), "When the Levee Breaks" },
                    { 73L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9289), "4:13", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9293), "Custard Pie" },
                    { 74L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9301), "5:36", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9303), "The Rover" },
                    { 75L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9306), "11:04", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9312), "In My Time of Dying" },
                    { 76L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9317), "4:01", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9320), "Houses of the Holy" },
                    { 77L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9326), "5:35", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9331), "Trampled Under Foot" },
                    { 78L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9334), "8:37", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9338), "Kashmir" },
                    { 79L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9345), "8:44", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9347), "In the Light" },
                    { 80L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9351), "2:06", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9357), "Bron-Yr-Aur" },
                    { 81L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9362), "5:14", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9364), "Down by the Seaside" },
                    { 82L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9372), "6:31", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9375), "Ten Years Gone" },
                    { 83L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9378), "3:36", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9384), "Night Flight" },
                    { 84L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9391), "4:06", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9397), "The Wanton Song" },
                    { 85L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9404), "3:51", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9425), "Boogie with Stu" },
                    { 86L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9436), "4:24", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9439), "Black Country Woman" },
                    { 87L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9442), "4:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9445), "Sick Again" },
                    { 88L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9449), "4:03", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9451), "Rock and Roll" },
                    { 89L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9454), "3:49", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9457), "Celebration Day" },
                    { 90L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9460), "6:00", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9462), "The Song Remains the Same" },
                    { 91L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9465), "8:24", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9468), "The Rain Song" },
                    { 92L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9472), "26:53", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9474), "Dazed and Confused" },
                    { 93L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9477), "12:30", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9480), "No Quarter" },
                    { 94L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9483), "10:58", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9485), "Stairway to Heaven" },
                    { 95L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9489), "12:47", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9492), "Moby Dick" },
                    { 96L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9565), "14:24", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9569), "Whole Lotta Love" },
                    { 97L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9573), "10:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9575), "Achilles Last Stand" },
                    { 98L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9577), "6:21", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9579), "For Your Life" },
                    { 99L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9582), "2:58", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9589), "Royal Orleans" },
                    { 101L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9595), "6:27", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9601), "Nobody's Fault but Mine" },
                    { 102L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9609), "4:10", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9612), "Candy Store Rock" },
                    { 103L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9615), "4:42", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9617), "Hots On for Nowhere" },
                    { 104L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9624), "9:27", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9630), "Tea for One" },
                    { 105L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9637), "6:48", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9642), "In the Evening" },
                    { 106L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9645), "4:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9647), "South Bound Saurez" },
                    { 107L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9650), "6:08", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9652), "Fool in the Rain" },
                    { 108L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9654), "3:15", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9657), "Hot Dog" },
                    { 109L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9660), "10:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9662), "Carouselambra" },
                    { 110L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9668), "5:51", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9674), "All My Love" },
                    { 111L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9682), "5:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9686), "I'm Gonna Crawl" },
                    { 112L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9904), "1:19", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9906), "...And the Gods Made Love" },
                    { 113L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9909), "2:08", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9911), "Have You Ever Been (To Electric Ladyland)" },
                    { 114L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9914), "2:25", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9916), "Crosstown Traffic" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Song",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 115L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9919), "14:50", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9922), "Voodoo Chile" },
                    { 116L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9925), "2:47", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9927), "Little Miss Strange" },
                    { 117L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9930), "3:21", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9932), "Long Hot Summer Night" },
                    { 118L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9935), "4:04", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9937), "Come On (Part 1)" },
                    { 119L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9940), "3:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9942), "Gypsy Eyes" },
                    { 120L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9945), "3:33", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9947), "Burning of the Midnight Lamp" },
                    { 121L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9950), "3:39", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9952), "Rainy Day, Dream Away" },
                    { 122L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9954), "13:25", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9957), "1983... (A Merman I Should Turn to Be)" },
                    { 123L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9959), "0:58", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9962), "Moon, Turn the Tides....Gently Gently Away" },
                    { 124L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9964), "4:19", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9967), "Still Raining, Still Dreaming" },
                    { 125L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9971), "4:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9974), "House Burning Down" },
                    { 126L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9977), "3:54", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9979), "All Along the Watchtower" },
                    { 127L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9983), "5:06", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9986), "Voodoo Child (Slight Return)" },
                    { 128L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9989), "2:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9991), "Second Hand News" },
                    { 129L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9993), "4:14", null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9995), "Dreams" },
                    { 130L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9998), "2:02", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1), "Never Going Back Again" },
                    { 131L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(4), "3:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(6), "Don't Stop" },
                    { 132L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(10), "3:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(12), "Go Your Own Way" },
                    { 133L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(15), "3:20", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(18), "Songbird" },
                    { 134L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(21), "4:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(24), "The Chain" },
                    { 135L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(27), "3:31", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(29), "You Make Loving Fun" },
                    { 136L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(32), "3:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(34), "I Don't Want to Know" },
                    { 137L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(114), "3:54", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(117), "Oh Daddy" },
                    { 138L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(121), "4:51", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(123), "Gold Dust Woman" },
                    { 139L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(125), "3:33", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(127), "The Ties That Bind" },
                    { 140L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(130), "4:02", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(132), "Sherry Darling" },
                    { 141L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(136), "3:04", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(142), "Jackson Cage" },
                    { 142L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(147), "2:42", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(149), "Two Hearts" },
                    { 143L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(152), "4:46", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(154), "Independence Day" },
                    { 144L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(156), "3:19", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(158), "Hungry Heart" },
                    { 145L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(161), "4:17", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(163), "Out in the Street" },
                    { 146L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(165), "3:10", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(167), "Crush on You" },
                    { 147L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(170), "2:36", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(172), "You Can Look (But You Better Not Touch)" },
                    { 148L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(174), "3:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(180), "I Wanna Marry You" },
                    { 149L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(186), "4:59", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(188), "The River" },
                    { 150L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(193), "6:05", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(198), "Point Blank" },
                    { 151L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(203), "3:02", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(205), "Cadillac Ranch" },
                    { 152L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(212), "3:34", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(216), "I'm a Rocker" },
                    { 153L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(219), "4:40", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(221), "Fade Away" },
                    { 154L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(224), "3:53", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(226), "Stolen Car" },
                    { 155L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(229), "4:04", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(231), "Ramrod" },
                    { 156L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(234), "5:27", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(236), "The Price You Pay" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Song",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 157L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(239), "8:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(241), "Drive All Night" },
                    { 158L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(245), "3:53", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(247), "Wreck on the Highway" },
                    { 166L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(250), "4:03", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(251), "Badlands" },
                    { 167L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(254), "4:32", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(256), "Adam Raised a Cain" },
                    { 168L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(258), "5:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(260), "Something in the Night" },
                    { 169L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(263), "2:51", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(265), "Candy's Room" },
                    { 170L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(268), "6:53", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(270), "Racing in the Street" },
                    { 171L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(274), "4:33", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(276), "The Promised Land" },
                    { 172L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(278), "2:17", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(280), "Factory" },
                    { 173L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(283), "4:09", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(285), "Streets of Fire" },
                    { 174L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(289), "3:56", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(290), "Prove It All Night" },
                    { 175L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(293), "4:30", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(295), "Darkness on the Edge of Town" },
                    { 176L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(298), "4:03", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(300), "Rock 'n' Roll Rebel" },
                    { 177L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(302), "4:32", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(304), "Bark at the Moon" },
                    { 178L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(307), "5:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(309), "You're No Different" },
                    { 179L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(312), "2:51", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(315), "Now You See It (Now You Don't)" },
                    { 180L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(318), "6:53", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(320), "Forever" },
                    { 181L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(323), "4:33", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(325), "So Tired" },
                    { 182L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(328), "2:17", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(331), "Waiting for Darkness" },
                    { 183L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(334), "4:09", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(336), "Spiders" },
                    { 184L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(339), "1:10", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(342), "Longships" },
                    { 185L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(346), "5:13", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(348), "The Raven" },
                    { 186L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(350), "2:24", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(352), "Dead Loss Angeles" },
                    { 187L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(355), "3:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(357), "Ice" },
                    { 188L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(360), "3:50", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(362), "Baroque Bordello" },
                    { 189L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(365), "3:32", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(367), "Nuclear Device(The Wizard of Aus)" },
                    { 190L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(369), "4:50", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(371), "Shah Shah a Go Go" },
                    { 191L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(374), "4:09", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(376), "Don't Bring Harry" },
                    { 192L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(378), "2:30", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(380), "Duchess" },
                    { 193L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(383), "4:48", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(386), "Meninblack" },
                    { 194L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(389), "5:16", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(391), "Genetix" },
                    { 195L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(395), "4:32", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(396), "Nebraska" },
                    { 196L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(399), "4:00", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(401), "Atlantic City" },
                    { 197L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(404), "4:08", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(407), "Mansion on the Hill" },
                    { 198L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(410), "3:44", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(412), "Johnny 99" },
                    { 199L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(415), "5:40", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(417), "Highway Patrolman" },
                    { 200L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(420), "3:17", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(422), "State Trooper" },
                    { 201L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(425), "3:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(427), "Used Cars" },
                    { 202L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(430), "2:58", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(432), "Open All Night" },
                    { 203L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(434), "5:07", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(436), "My Father's House" },
                    { 204L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(439), "4:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(441), "Reason to Believe" },
                    { 205L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(444), "2:55", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(446), "Iron Fist" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Song",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 206L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(448), "3:04", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(450), "Heart of Stone" },
                    { 207L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(453), "2:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(454), "I'm the Doctor" },
                    { 208L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(457), "3:10", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(459), "Go to Hell" },
                    { 209L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(462), "3:57", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(464), "Loser" },
                    { 210L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(466), "2:10", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(468), "Sex & Outrage" },
                    { 211L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(471), "3:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(474), "America" },
                    { 212L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(476), "2:41", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(478), "Shut It Down" },
                    { 213L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(482), "3:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(484), "Speedfreak" },
                    { 214L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(486), "3:08", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(488), "(Don't Let 'Em) Grind Ya Down" },
                    { 215L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(491), "2:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(494), "(Don't Need) Religion" },
                    { 216L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(497), "2:43", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(499), "Bang to Rights" },
                    { 217L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(502), "4:03", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(504), "Stormbringer" },
                    { 218L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(508), "4:23", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(510), "Love Don't Mean a Thing" },
                    { 219L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(629), "4:28", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(633), "Holy Man" },
                    { 220L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(638), "5:05", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(641), "Hold On" },
                    { 221L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(644), "3:19", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(646), "Lady Double Dealer" },
                    { 222L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(649), "3:24", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(651), "You Can't Do It Right (With the One You Love)" },
                    { 223L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(654), "4:26", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(656), "High Ball Shooter" },
                    { 224L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(659), "4:05", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(662), "The Gypsy" },
                    { 225L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(665), "3:14", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(667), "Soldier of Fortune" },
                    { 226L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(670), "3:41", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(672), "Girl from the North Country" },
                    { 227L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(676), "3:12", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(678), "Nashville Skyline Rag" },
                    { 228L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(681), "2:07", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(683), "To Be Alone with You" },
                    { 229L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(686), "2:23", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(688), "I Threw It All Away" },
                    { 230L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(691), "2:01", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(694), "Peggy Day" },
                    { 231L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(697), "3:18", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(699), "Lay Lady Lay" },
                    { 232L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(703), "2:23", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(705), "One More Night" },
                    { 233L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(708), "2:41", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(710), "Tell Me That It Isn't True" },
                    { 234L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(713), "1:37", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(716), "Country Pie" },
                    { 235L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(719), "3:23", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(721), "Tonight I'll Be Staying Here with You" },
                    { 236L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(724), "4:38", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(726), "Born in the U.S.A." },
                    { 237L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(729), "3:29", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(732), "Cover Me" },
                    { 238L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(735), "4:48", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(737), "Darlington County" },
                    { 239L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(740), "3:13", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(742), "Working on the Highway" },
                    { 240L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(745), "3:35", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(747), "Downbound Train" },
                    { 241L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(751), "2:40", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(753), "I'm on Fire" },
                    { 242L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(757), "4:01", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(759), "No Surrender" },
                    { 243L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(762), "3:48", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(764), "Bobby Jean" },
                    { 244L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(767), "3:30", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(769), "I'm Goin' Down" },
                    { 245L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(773), "4:15", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(775), "Glory Days" },
                    { 246L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(778), "4:04", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(780), "Dancing in the Dark" },
                    { 247L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(783), "4:34", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(785), "My Hometown" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Song",
                columns: new[] { "Id", "AddedDate", "Length", "MemberId", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 248L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(788), "4:49", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(790), "Thunder Road" },
                    { 249L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(794), "3:11", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(796), "Tenth Avenue Freeze-Out" },
                    { 250L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(799), "3:00", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(802), "Night" },
                    { 251L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(805), "6:30", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(807), "Backstreets" },
                    { 252L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(810), "4:31", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(812), "Born to Run" },
                    { 253L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(815), "4:30", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(818), "She's the One" },
                    { 254L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(821), "3:18", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(823), "Meeting Across the River" },
                    { 255L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(826), "9:34", null, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(828), "Jungleland" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Studio",
                columns: new[] { "Id", "AddedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7830), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7833), "Island Studios London, Sound Techniques London" },
                    { 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7841), "914 Sound Studios, Blauvelt, New York" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Artist",
                columns: new[] { "Id", "AddedDate", "CountryId", "DisbandYear", "FormationYear", "ModifiedDate", "Name", "Photo" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7882), 1, 1980, 1967, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7889), "Led Zeppelin", "458eb53a-aba7-42a2-a5ed-526da552966e.jpg" },
                    { 2L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7907), 1, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7915), "Sandy Denny", "0ed76f7d-e5da-4e5b-87b0-a8ecb4a165cd.jpg" },
                    { 3L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7925), 5, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7932), "Bruce Springsteen", "32ce9c93-9129-4bff-b166-db5ada039757.jpg" },
                    { 4L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7943), 5, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7950), "John Denver", "f94fb03e-c368-4562-9c66-2b2db5722252.jpg" },
                    { 5L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7959), 1, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7966), "Elton John", "64fa7eb5-dca2-4ed3-a465-fa6904bba895.jpg" },
                    { 6L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7977), 1, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7984), "John Lennon", "e0ceb7ed-5481-4cc1-926f-59cf31fd2e69.jpg" },
                    { 7L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7991), 5, null, 1962, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7993), "Bob Dylan", "567552b5-27d5-4a6e-acc5-449017fcd47e.jpg" },
                    { 8L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7997), 3, null, 1986, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7998), "Manic Street Preachers", "8117dfa2-41a4-4be1-a33f-fd7484ae5d7a.jpg" },
                    { 9L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8001), 1, null, 1979, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8003), "Ozzy Osbourne", "99cc2dbe-5671-4eca-947d-8f7a4f1759af.jpg" },
                    { 10L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8009), 1, null, 1974, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8011), "The Stranglers", "8b728b1e-c506-4d08-b87d-9f320f4cc920.jpg" },
                    { 11L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8014), 2, null, 1977, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8016), "Simple Minds", "2a39824d-1c56-46fe-b4bc-b7e87dfb7bb3.jpg" },
                    { 12L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8024), 1, null, 1968, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8030), "Deep Purple", "5863254c-693f-43e3-b0f8-a7ebdeb8ec33.jpg" },
                    { 13L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8039), 1, null, 1975, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8046), "Motorhead", "2691c7fa-2546-401e-a10b-1608e00711d2.jpg" },
                    { 14L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8053), 6, null, 1973, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8055), "ACDC", "85d9174f-1f0d-4221-8635-f86c211caa4d.jpg" },
                    { 15L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8058), 5, 1970, 1961, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8060), "Jimi Hendrix", "f304b989-f26e-4aa5-8c78-1d1b49850bee.jpg" },
                    { 16L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8063), 1, null, 1967, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8065), "Fleetwood Mac", "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
                    { 17L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8068), 5, null, 1987, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8070), "Nirvana", "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
                    { 18L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8075), 1, null, 1975, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8077), "Kate Bush", "909e5592-09a3-4018-a3a8-e067612c7388.jpg" },
                    { 19L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8080), 5, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8082), "Tori Amos", "22d853a2-cd81-4362-a6a5-d15c17c83194.jpg" },
                    { 20L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8086), 1, null, 1975, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8088), "U2", "af794a29-19e8-440f-a5e2-113319932b40.jpg" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_BirthPlace",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7469), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7472), "Aston, Birmingham" },
                    { 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7480), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7482), "Birmingham" },
                    { 3, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7487), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7489), "West Bromwich" },
                    { 4, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7491), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7493), "Heston" },
                    { 5, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7496), 5, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7497), "Seattle" },
                    { 6, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7501), 3, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7503), "Pontypool" },
                    { 7, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7505), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7507), "Sidcup" },
                    { 8, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7509), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7511), "Reddich" },
                    { 9, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7514), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7517), "Merton Park, London" },
                    { 10, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7521), 5, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7523), "Long Branch, New Jersey" },
                    { 11, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7526), 5, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7528), "Monterey Bay" },
                    { 12, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7531), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7533), "Pinner, Middlesex" },
                    { 13, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7535), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7537), "Liverpool, Lancashire" },
                    { 14, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7540), 7, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7541), "Vancover" },
                    { 15, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7544), 5, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7546), "Duluth, Minnesota" },
                    { 16, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7549), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7551), "Marston Green, Warwickshire" },
                    { 17, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7553), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7555), "Tufnell Park, North London" },
                    { 18, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7559), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7561), "Notting Hill, London" },
                    { 19, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7563), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7565), "Brighton, London" },
                    { 21, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7568), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7570), "Ilford, Essex" },
                    { 22, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7573), 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7575), "Toryglen, Glasgow" },
                    { 23, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7577), 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7580), "Glasgow" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_BirthPlace",
                columns: new[] { "Id", "AddedDate", "CountryId", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 24, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7583), 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7585), "Dundee" },
                    { 25, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7587), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7589), "Nottingham" },
                    { 26, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7592), 3, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7595), "Brecon" },
                    { 27, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7597), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7600), "Chiswick, London" },
                    { 28, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7602), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7604), "Stoke-on-Trent, Staffordshire" },
                    { 29, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7607), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7608), "London" },
                    { 30, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7611), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7613), "Twickenham, Middlesex" },
                    { 31, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7616), 6, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7618), "Melbourne, Victoria" },
                    { 32, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7620), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7622), "Romford, Essex" },
                    { 33, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7624), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7627), "Dunston, Gateshead" },
                    { 34, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7629), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7631), "Redruth, Cornwall, Gateshead" },
                    { 35, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7707), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7710), "Phoenix, Arizona" },
                    { 36, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7714), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7716), "Ealing, Middlesex" },
                    { 37, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7719), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7720), "Bouth, Lancashire" },
                    { 38, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7723), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7725), "Palo Alto, California" },
                    { 39, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7727), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7729), "Aberdeen, Washington" },
                    { 40, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7731), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7733), "Compton, California" },
                    { 41, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7736), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7738), "Warren, Ohio" },
                    { 42, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7741), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7743), "Bexleyheath, Kent" },
                    { 43, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7745), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7747), "Newton, North Carolina" },
                    { 44, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7750), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7752), "Dublin, Ireland" },
                    { 45, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7754), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7756), "Barking, Essex" },
                    { 46, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7759), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7761), "Chinnor, Oxfordshire" },
                    { 47, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7764), 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7766), "Artane, Dublin" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Album",
                columns: new[] { "Id", "AddedDate", "Arrangers", "ArtistId", "Artwork", "Engineers", "LabelId", "ModifiedDate", "Name", "Photo", "Producers", "RecordedDate", "ReleaseDate", "StudioId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8645), null, 1L, null, null, 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8648), "Led Zeppelin 1", "11d15486-fefc-463c-8b7d-c755b08466dc.jpg", null, null, new DateTime(1969, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8659), "Sandy Denny", 2L, "Keef", "John Wood", 7, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8661), "The North Star Grassman and the Ravens", "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg", "John Wood, Richard Thompson, Sandy Denny", new DateTime(1971, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8666), null, 1L, null, null, 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8668), "Led Zeppelin 2", "ee552af1-7a5a-457b-b336-823bc1285dac.jpg", null, null, new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8671), null, 1L, null, null, 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8673), "Led Zeppelin 3", "9cf368d3-db16-4120-af40-7dd697b934fa.jpg", null, null, new DateTime(1970, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8677), null, 1L, null, null, 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8679), "Led Zeppelin IV", "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg", null, null, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8684), null, 1L, null, null, 1, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8686), "Houses of the Holy", "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg", null, null, new DateTime(1973, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8690), null, 1L, null, null, 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8692), "Physical Graffiti", "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg", null, null, new DateTime(1975, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8696), null, 1L, null, null, 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8698), "The Song Remains The Same", "d2710986-0720-4231-8582-4383eb9ffe12.jpg", null, null, new DateTime(1976, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8701), null, 1L, null, null, 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8706), "Presence", "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg", null, null, new DateTime(1976, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8717), null, 1L, null, null, 2, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8725), "In Through The OutDoor", "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg", null, null, new DateTime(1979, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8732), null, 15L, null, null, 8, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8734), "Electric Ladyland", "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg", null, null, new DateTime(1968, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8738), null, 16L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8739), "Rumours", "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg", "Fleetwood Mac, Ken Caillat, Richard Dashut", null, new DateTime(1977, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8743), null, 3L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8745), "The River", "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg", null, null, null, null },
                    { 14L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8747), null, 3L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8749), "Born To Run", "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg", null, null, null, null },
                    { 15L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8752), null, 3L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8754), "Darkness on the Edge of Town", "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg", null, null, null, null },
                    { 16L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8758), null, 9L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8760), "Bark At The Moon", "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg", null, null, null, null },
                    { 17L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8763), null, 10L, null, null, 9, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8765), "The Raven", "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg", null, null, new DateTime(1979, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8770), null, 3L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8772), "Nebraska", "6e2e5c69-75cd-480e-9b28-6d3726df576f.jpg", null, null, null, null },
                    { 20L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8774), null, 13L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8776), "Iron Fist", "39c3f690-87cd-4cd2-8a9a-54ba8af3a50f.jpg", null, null, null, null },
                    { 21L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8779), null, 12L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8781), "Stormbringer", "d96d1eac-982a-41a2-b2dd-ff65707940e1.jpg", null, null, null, null },
                    { 22L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8783), null, 7L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8786), "Nashville Skyline", "722792d3-787b-4698-916d-0ff766e68fd6.jpg", null, null, null, null },
                    { 23L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8789), null, 3L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8791), "Born In The Usa", "66c0e775-c22b-427d-a327-e6bfd9b5673e.jpg", null, null, null, null },
                    { 24L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8793), null, 17L, null, null, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8796), "Nevermind", "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg", null, null, new DateTime(1991, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Member",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8142), 1L, 4, new DateTime(1944, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Patrick", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8147), "a0033bc9-c0b8-4248-8e31-f9d3938e1e34.jpg", "Jimmy Page", "Page" },
                    { 2L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8241), 1L, 3, new DateTime(1948, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Anthony", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8243), "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg", "Robert Plant", "Plant" },
                    { 3L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8249), 1L, 7, new DateTime(1946, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Jones", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8251), "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg", "John Paul Jones", "Paul" },
                    { 4L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8255), 1L, 8, new DateTime(1948, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Bonham", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8257), "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg", "John Bonham", "Henry" },
                    { 5L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8261), 2L, 9, new DateTime(1947, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandra", true, "Elene MacLean", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8263), "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg", "Sandy Denny", "Denny" },
                    { 6L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8269), 3L, 10, new DateTime(1949, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8271), "734770c0-05f1-4bd9-ae4b-748cbdc64167.jpg", "Bruce Springsteen", "Springsteen" },
                    { 7L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8275), 4L, 11, new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8277), "08dc96d6-bbe4-429d-90b6-094b04ae8f9d.jpg", "John Denver", "Denver" },
                    { 8L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8283), 5L, 12, new DateTime(1947, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elton", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8285), "06cb3132-accb-4b58-a532-47bb49bdc29b.jpg", "Elton John", "John" },
                    { 9L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8288), 6L, 13, new DateTime(1940, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8290), "69e916a9-94e6-47ce-9762-1ca6650fa434.jpg", "John Lennon", "Lennon" },
                    { 10L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8295), 7L, 15, new DateTime(1941, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", true, "Allen", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8297), "bb655ce4-9a14-4805-b6d3-9f84a26a250a.jpg", "Bob Dylan", "Zimmerman" },
                    { 11L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8300), 8L, 6, new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, "Dean", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8302), "3d39a220-fd12-4533-adcb-7741b0c4f8ab.jpg", "James Dean Bradfield", "Bradfield" },
                    { 12L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8305), 8L, 6, new DateTime(1969, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicholas", true, "Allen", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8307), "450e17c5-c352-452f-a1d8-4b6c4154cf9d.jpg", "Nicky Wire", "Jones" },
                    { 13L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8311), 8L, 6, new DateTime(1968, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sean", true, "Anthony", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8313), "18bc8103-9380-4bde-ae46-01b8160887a3.jpg", "Sean Moore", "Moore" },
                    { 14L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8316), 9L, 16, new DateTime(1948, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Michael", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8318), "9366d83c-e30d-47ab-924e-f61a42d17efe.jpg", "Ozzy Osbourne", "Osbourne" },
                    { 15L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8322), 10L, 17, new DateTime(1949, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hugh", true, "Alan", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8324), "e962871a-23ec-4049-a772-d5ef262c9adb.jpg", "Hugh Cornwell", "Cornwell" },
                    { 16L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8328), 10L, 18, new DateTime(1952, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Jacques", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8330), "f5fc3019-2a61-4d80-b071-351845c5992c.jpg", "Jean-Jacques Burnel", "Burnel" },
                    { 17L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8334), 10L, 19, new DateTime(1949, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", true, "Paul", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8336), "8f567b5f-7982-44d9-b4b5-e9337595f8e1.jpg", "David Greenfield", "Greenfield" },
                    { 18L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8341), 10L, 21, new DateTime(1938, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "John", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8342), "9833b134-75c7-456a-a1d2-f5a286dc892e.jpg", "Jet Black", "Duffy" },
                    { 19L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8346), 11L, 22, new DateTime(1959, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8348), "60267eb0-f2f5-48c8-b245-83df9a7986bd.jpg", "Jim Kerr", "Kerr" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_Member",
                columns: new[] { "Id", "AddedDate", "ArtistId", "BirthPlaceId", "DateOfBirth", "DateOfDeath", "FirstName", "IsSongWriter", "MiddleName", "ModifiedDate", "Photo", "StageName", "Surname" },
                values: new object[,]
                {
                    { 20L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8351), 11L, 23, new DateTime(1959, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8353), "83a85c7e-609d-420a-b380-d2ff190a452a.jpg", "Charlie Burchill", "Burchill" },
                    { 21L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8357), 11L, 24, new DateTime(1962, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ged", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8358), "4b9eee24-56a3-493f-9dfa-3159a80396fd.jpg", "Ged Grimes", "Grimes" },
                    { 22L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8362), 12L, 25, new DateTime(1948, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, "Anderson", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8364), "5166d6e2-42a6-44f6-bbca-ffb41733ef48.jpg", "Ian Paice", "Paice" },
                    { 23L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8367), 12L, 26, new DateTime(1945, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", true, "David", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8369), "85717e2f-36bf-4c2b-8920-f42c90817ce8.jpg", "Roger Glover", "Glover" },
                    { 24L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8373), 12L, 27, new DateTime(1945, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ian", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8376), "883f0129-b075-454d-a68c-e3d7f07bbdda.jpg", "Ian Gillan", "Gillan" },
                    { 25L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8379), 13L, 28, new DateTime(1954, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian", true, "Fraser", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8381), "1a7a6266-a256-4b08-87f0-640d8e3ace60.jpg", "Lemmy", "Kilmister" },
                    { 26L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8385), 13L, 29, new DateTime(1954, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", true, "John", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8387), "04f9d8e6-1b84-4a0a-800e-1716732aaf5e.jpg", "Phil 'Philthy Animal' Taylor", "Taylor" },
                    { 27L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8391), 13L, 30, new DateTime(1950, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", true, "Allan", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8393), "1dbe7e17-567f-4f12-883d-b253ef2d25a2.jpg", "'Fast' Eddie Clarke", "Clarke" },
                    { 28L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8397), 14L, 23, new DateTime(1955, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Angus", true, "McKinnon", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8399), "273cc6e3-995f-44ef-9665-4b06d76ce7eb.jpg", "Angus Young", "Young" },
                    { 29L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8402), 14L, 23, new DateTime(1953, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malcolm", true, "Mitchell", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8404), "c79c5ae5-8678-488d-a9f0-6bc18e83abb3.jpg", "Malcolm Young", "Young" },
                    { 30L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8408), 14L, 29, new DateTime(1954, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phillip", true, "Hugh Norman Witschke", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8410), "44b350e7-ed7f-4e3c-b6e1-5b286836e383.jpg", "Phil Rudd", "Rudzevecuis" },
                    { 31L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8413), 14L, 32, new DateTime(1949, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clifford", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8415), "0445ae2a-a3ef-4636-9850-2c4420d5f91e.jpg", "Cliff Williams", "Williams" },
                    { 32L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8420), 14L, 33, new DateTime(1947, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", true, "Francis", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8422), "3ab89167-5769-478e-95a8-29277316e028.jpg", "Brian Johnson", "Johnson" },
                    { 33L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8425), 16L, 34, new DateTime(1947, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michael", true, "John Kells", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8427), "75ce147a-b9e9-49f4-8a71-c4f36dc9d3cd.jpg", "Mick Fleetwood", "Fleetwood" },
                    { 34L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8432), 16L, 35, new DateTime(1948, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie", true, "Lynn", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8434), "88153d6b-9d63-4f87-b49b-a660683f7adf.jpg", "Stevie Nicks", "Nicks" },
                    { 35L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8437), 16L, 36, new DateTime(1945, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "John", true, "Graham", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8439), "8c1fc01a-79e2-479c-b92d-ec6f9ba9135d.jpg", "John McVie", "McVie" },
                    { 36L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8443), 16L, 37, new DateTime(1943, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christine", true, "Anne", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8445), "1fa68d08-2072-47cc-ad2b-96a27af42351.jpg", "Christine McVie", "Perfect" },
                    { 37L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8448), 16L, 38, new DateTime(1949, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lindsey", true, "Adams", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8450), "8154868a-c01d-49e4-85d1-f85c0b0c9302.jpg", "Lindsey Buckingham", "Buckingham" },
                    { 38L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8453), 17L, 39, new DateTime(1967, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurt", true, "Donald", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8455), "10ec8163-a6de-4c64-bd80-3a949886905e.jpg", "Kurt Cobain", "Cobain" },
                    { 39L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8459), 17L, 40, new DateTime(1965, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Krist", true, "Anthony", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8461), "657837dd-f7c1-4ed5-a58e-39cc0e279d83.jpg", "Krist Novoselic", "Novoselic" },
                    { 40L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8464), 17L, 41, new DateTime(1969, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Eric", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8466), "7dd70c41-8fcf-4cd1-a825-78fb30c7c0ca.jpg", "Dave Grohl", "Grohl" },
                    { 41L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8470), 18L, 42, new DateTime(1958, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catherine", true, null, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8472), "dfdae93a-d393-41e9-ba05-78970f0b1ee1.jpg", "Kate Bush", "Bush" },
                    { 42L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8475), 19L, 43, new DateTime(1963, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Myra", true, "Ellen", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8477), "d4f764a9-75d6-44ff-9263-94d2cd30703e.jpg", "Tori Amos", "Amos" },
                    { 43L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8479), 20L, 44, new DateTime(1960, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", true, "David", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8481), "5b1d901a-ad92-40ad-8439-af151e472b5d.jpg", "Bono", "Hewson" },
                    { 44L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8542), 20L, 45, new DateTime(1961, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", true, "Howell", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8545), "7ad787f2-d136-4d35-9fbf-be9bcddd34c3.jpg", "The Edge", "Evans" },
                    { 45L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8551), 20L, 46, new DateTime(1960, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adam", true, "Charles", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8553), "73375c6c-cd17-41c4-824c-c5f8af912a28.jpg", "Adam Clayton", "Clayton" },
                    { 46L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8557), 20L, 47, new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lawrence", true, " Joseph", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8559), "9f24c9d9-6b23-4594-bdf3-f71da4311af7.jpg", "Larry Mullen Jr.", "Mullen Jr." },
                    { 47L, new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8562), 15L, 14, new DateTime(1942, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", true, "Allen", new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8564), "9a7bff27-93b5-43cf-8fed-743074f6182b.jpg", "Jimi Hendrix", "Hendrix" }
                });

            migrationBuilder.InsertData(
                table: "SWSG_AlbumSong",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(978), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(982), 1, 1, 1L },
                    { 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1048), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1051), 2, 1, 2L },
                    { 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1055), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1057), 3, 1, 3L },
                    { 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1060), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1062), 4, 1, 4L },
                    { 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1065), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1067), 5, 2, 5L },
                    { 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1072), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1075), 6, 2, 6L },
                    { 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1077), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1079), 7, 2, 7L },
                    { 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1082), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1085), 8, 2, 8L },
                    { 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1088), 1L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1090), 9, 2, 9L },
                    { 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1094), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1097), 1, 1, 10L },
                    { 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1100), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1102), 2, 1, 11L },
                    { 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1105), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1107), 3, 1, 12L },
                    { 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1110), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1113), 4, 1, 13L },
                    { 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1116), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1118), 5, 1, 14L },
                    { 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1121), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1123), 6, 2, 15L },
                    { 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1126), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1129), 7, 2, 16L },
                    { 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1132), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1134), 8, 2, 17L },
                    { 18L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1140), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1142), 9, 2, 18L },
                    { 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1145), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1147), 10, 2, 19L },
                    { 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1150), 2L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1152), 11, 2, 20L },
                    { 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1155), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1157), 1, 1, 21L },
                    { 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1160), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1163), 2, 1, 22L },
                    { 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1165), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1168), 3, 1, 23L },
                    { 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1171), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1173), 4, 1, 24L },
                    { 25L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1176), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1178), 5, 1, 25L },
                    { 26L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1181), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1184), 6, 1, 26L },
                    { 27L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1187), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1189), 1, 2, 27L },
                    { 28L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1193), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1195), 2, 2, 28L },
                    { 29L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1198), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1201), 3, 2, 29L },
                    { 30L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1204), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1206), 4, 2, 30L },
                    { 31L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1210), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1212), 5, 2, 31L },
                    { 34L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1215), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1217), 6, 2, 32L },
                    { 35L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1220), 24L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1223), 7, 2, 33L },
                    { 43L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1228), 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1230), 1, 1, 40L },
                    { 44L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1233), 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1235), 2, 1, 41L },
                    { 45L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1238), 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1240), 4, 1, 42L },
                    { 46L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1244), 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1246), 3, 1, 43L },
                    { 47L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1250), 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1252), 1, 2, 44L },
                    { 48L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1255), 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1257), 2, 2, 45L },
                    { 49L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1260), 3L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1262), 3, 2, 46L },
                    { 50L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1266), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1268), 1, 1, 47L },
                    { 51L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1271), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1273), 2, 1, 48L }
                });

            migrationBuilder.InsertData(
                table: "SWSG_AlbumSong",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 52L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1277), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1279), 3, 1, 49L },
                    { 53L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1282), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1285), 4, 1, 50L },
                    { 54L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1288), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1290), 1, 2, 51L },
                    { 55L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1294), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1296), 2, 2, 52L },
                    { 56L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1299), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1301), 3, 2, 53L },
                    { 57L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1304), 6L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1307), 4, 2, 54L },
                    { 58L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1310), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1312), 1, 1, 55L },
                    { 59L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1314), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1317), 2, 1, 56L },
                    { 60L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1320), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1322), 3, 1, 57L },
                    { 61L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1325), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1328), 4, 1, 58L },
                    { 62L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1331), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1333), 5, 1, 59L },
                    { 63L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1336), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1339), 1, 2, 60L },
                    { 64L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1342), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1345), 2, 2, 61L },
                    { 65L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1348), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1351), 3, 2, 62L },
                    { 66L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1354), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1357), 4, 2, 63L },
                    { 67L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1360), 4L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1362), 5, 2, 64L },
                    { 68L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1365), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1368), 1, 1, 65L },
                    { 69L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1371), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1373), 2, 1, 66L },
                    { 70L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1377), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1379), 3, 1, 67L },
                    { 71L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1382), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1385), 4, 1, 68L },
                    { 72L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1388), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1390), 2, 2, 69L },
                    { 73L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1393), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1396), 3, 2, 70L },
                    { 74L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1399), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1401), 3, 2, 71L },
                    { 75L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1406), 5L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1408), 4, 2, 72L },
                    { 76L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1411), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1413), 1, 1, 73L },
                    { 77L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1416), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1418), 2, 1, 74L },
                    { 78L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1421), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1424), 3, 1, 75L },
                    { 79L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1427), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1429), 1, 2, 76L },
                    { 80L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1487), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1490), 2, 2, 77L },
                    { 81L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1495), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1497), 3, 2, 78L },
                    { 82L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1500), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1502), 1, 3, 79L },
                    { 83L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1507), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1510), 2, 3, 80L },
                    { 84L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1512), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1515), 3, 3, 81L },
                    { 85L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1518), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1520), 4, 3, 82L },
                    { 86L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1523), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1525), 1, 4, 83L },
                    { 87L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1528), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1531), 2, 4, 84L },
                    { 88L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1534), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1536), 3, 4, 85L },
                    { 89L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1539), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1541), 4, 4, 86L },
                    { 90L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1544), 7L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1546), 5, 4, 87L },
                    { 91L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1550), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1552), 1, 1, 88L },
                    { 92L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1555), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1558), 2, 1, 89L },
                    { 93L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1561), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1563), 3, 1, 90L }
                });

            migrationBuilder.InsertData(
                table: "SWSG_AlbumSong",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 94L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1566), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1568), 4, 1, 91L },
                    { 95L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1572), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1574), 1, 2, 92L },
                    { 96L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1578), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1580), 1, 3, 93L },
                    { 97L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1583), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1585), 2, 3, 94L },
                    { 98L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1589), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1591), 1, 4, 95L },
                    { 99L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1594), 8L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1597), 2, 4, 96L },
                    { 100L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1599), 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1602), 1, 1, 97L },
                    { 102L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1605), 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1608), 2, 1, 98L },
                    { 103L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1612), 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1614), 3, 1, 99L },
                    { 104L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1617), 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1620), 1, 2, 101L },
                    { 105L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1622), 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1624), 2, 2, 102L },
                    { 106L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1628), 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1631), 3, 2, 103L },
                    { 107L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1634), 9L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1636), 4, 2, 104L },
                    { 108L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1640), 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1642), 1, 1, 105L },
                    { 109L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1645), 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1647), 2, 1, 106L },
                    { 110L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1650), 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1653), 3, 1, 107L },
                    { 111L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1656), 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1658), 4, 1, 108L },
                    { 112L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1661), 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1663), 1, 2, 109L },
                    { 113L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1666), 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1669), 2, 2, 110L },
                    { 114L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1672), 10L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1675), 3, 2, 111L },
                    { 115L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1678), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1681), 1, 1, 112L },
                    { 116L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1684), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1687), 2, 1, 113L },
                    { 117L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1690), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1692), 3, 1, 114L },
                    { 118L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1695), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1698), 4, 1, 115L },
                    { 119L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1701), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1703), 1, 2, 116L },
                    { 120L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1706), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1708), 2, 2, 117L },
                    { 121L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1711), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1714), 3, 2, 118L },
                    { 122L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1717), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1720), 4, 2, 119L },
                    { 123L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1723), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1726), 5, 2, 120L },
                    { 124L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1729), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1732), 3, 3, 121L },
                    { 125L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1735), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1737), 4, 3, 122L },
                    { 126L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1741), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1743), 1, 3, 123L },
                    { 127L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1747), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1749), 1, 4, 124L },
                    { 128L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1752), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1755), 2, 4, 125L },
                    { 129L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1758), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1761), 3, 4, 126L },
                    { 130L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1763), 11L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1766), 4, 4, 127L },
                    { 131L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1769), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1772), 1, 1, 128L },
                    { 132L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1775), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1777), 2, 1, 129L },
                    { 133L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1780), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1782), 3, 1, 130L },
                    { 134L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1786), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1788), 4, 1, 131L },
                    { 135L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1791), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1793), 5, 1, 132L },
                    { 136L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1796), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1799), 6, 1, 133L }
                });

            migrationBuilder.InsertData(
                table: "SWSG_AlbumSong",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 137L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1802), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1804), 1, 2, 134L },
                    { 138L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1807), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1809), 2, 2, 135L },
                    { 139L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1812), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1814), 3, 2, 136L },
                    { 140L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1821), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1824), 4, 2, 137L },
                    { 141L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1826), 12L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1829), 5, 2, 138L },
                    { 142L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1832), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1834), 1, 1, 139L },
                    { 143L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1837), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1840), 2, 1, 140L },
                    { 144L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1843), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1846), 3, 1, 141L },
                    { 145L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1849), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1852), 4, 1, 142L },
                    { 146L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1854), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1857), 5, 1, 143L },
                    { 147L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1859), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1862), 1, 2, 144L },
                    { 148L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1864), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1867), 2, 2, 145L },
                    { 149L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1870), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1872), 3, 2, 146L },
                    { 150L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1927), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1930), 4, 2, 147L },
                    { 151L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1934), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1936), 5, 2, 148L },
                    { 152L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1939), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1943), 6, 2, 149L },
                    { 153L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1946), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1948), 1, 3, 150L },
                    { 154L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1952), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1955), 2, 3, 151L },
                    { 155L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1957), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1960), 3, 3, 152L },
                    { 156L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1963), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1966), 4, 3, 153L },
                    { 157L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1969), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1971), 5, 3, 154L },
                    { 158L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1975), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1977), 1, 4, 155L },
                    { 159L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1981), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1983), 2, 4, 156L },
                    { 160L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1986), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1989), 3, 4, 157L },
                    { 161L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1992), 13L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1994), 4, 4, 158L },
                    { 168L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1997), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2000), 1, 1, 166L },
                    { 169L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2003), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2005), 2, 1, 167L },
                    { 170L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2009), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2011), 3, 1, 168L },
                    { 171L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2014), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2016), 4, 1, 169L },
                    { 172L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2019), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2022), 5, 1, 170L },
                    { 173L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2025), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2027), 1, 2, 171L },
                    { 174L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2030), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2033), 2, 2, 172L },
                    { 175L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2036), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2038), 3, 2, 173L },
                    { 176L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2041), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2044), 4, 2, 174L },
                    { 177L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2047), 15L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2050), 5, 2, 175L },
                    { 178L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2053), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2055), 1, 1, 176L },
                    { 179L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2058), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2061), 2, 1, 177L },
                    { 180L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2064), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2066), 3, 1, 178L },
                    { 181L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2069), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2072), 4, 1, 179L },
                    { 182L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2075), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2077), 1, 2, 180L },
                    { 183L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2080), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2083), 2, 2, 181L },
                    { 184L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2087), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2089), 3, 2, 182L }
                });

            migrationBuilder.InsertData(
                table: "SWSG_AlbumSong",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 185L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2092), 16L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2094), 4, 2, 183L },
                    { 186L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2097), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2099), 1, 1, 184L },
                    { 187L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2103), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2105), 2, 1, 185L },
                    { 188L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2108), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2110), 3, 1, 186L },
                    { 189L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2113), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2116), 4, 1, 187L },
                    { 190L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2118), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2120), 5, 1, 188L },
                    { 191L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2123), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2126), 6, 1, 189L },
                    { 192L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2129), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2131), 1, 2, 190L },
                    { 193L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2134), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2137), 2, 2, 191L },
                    { 194L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2140), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2142), 3, 2, 192L },
                    { 195L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2145), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2148), 4, 2, 193L },
                    { 196L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2151), 17L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2153), 5, 2, 194L },
                    { 197L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2156), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2159), 1, 1, 195L },
                    { 198L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2162), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2164), 2, 1, 196L },
                    { 199L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2167), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2169), 3, 1, 197L },
                    { 200L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2172), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2175), 4, 1, 198L },
                    { 201L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2177), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2180), 5, 1, 199L },
                    { 202L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2183), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2186), 6, 1, 200L },
                    { 203L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2189), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2191), 1, 2, 201L },
                    { 204L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2194), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2196), 2, 2, 202L },
                    { 205L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2200), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2202), 3, 2, 203L },
                    { 206L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2205), 19L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2207), 4, 2, 204L },
                    { 207L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2210), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2213), 1, 1, 205L },
                    { 208L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2215), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2218), 2, 1, 206L },
                    { 209L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2221), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2223), 3, 1, 207L },
                    { 210L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2226), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2228), 4, 1, 208L },
                    { 211L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2232), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2234), 5, 1, 209L },
                    { 212L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2237), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2239), 6, 1, 210L },
                    { 213L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2242), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2244), 1, 2, 211L },
                    { 214L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2250), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2253), 2, 2, 212L },
                    { 215L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2256), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2258), 3, 2, 213L },
                    { 216L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2262), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2264), 4, 2, 214L },
                    { 217L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2268), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2270), 5, 2, 215L },
                    { 218L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2273), 20L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2276), 6, 2, 216L },
                    { 219L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2279), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2281), 1, 1, 217L },
                    { 220L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2284), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2286), 2, 1, 218L },
                    { 221L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2291), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2293), 3, 1, 219L },
                    { 222L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2296), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2298), 4, 1, 220L },
                    { 223L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2301), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2303), 1, 2, 221L },
                    { 224L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2307), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2309), 2, 2, 222L },
                    { 225L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2313), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2315), 3, 2, 223L },
                    { 226L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2318), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2320), 4, 2, 224L }
                });

            migrationBuilder.InsertData(
                table: "SWSG_AlbumSong",
                columns: new[] { "Id", "AddedDate", "AlbumId", "ModifiedDate", "Order", "Side", "SongId" },
                values: new object[,]
                {
                    { 227L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2324), 21L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2326), 5, 2, 225L },
                    { 228L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2329), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2331), 1, 1, 226L },
                    { 229L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2334), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2337), 2, 1, 227L },
                    { 230L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2340), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2342), 3, 1, 228L },
                    { 231L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2345), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2348), 4, 1, 229L },
                    { 232L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2351), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2354), 5, 1, 230L },
                    { 233L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2357), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2359), 1, 2, 231L },
                    { 234L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2362), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2364), 2, 2, 232L },
                    { 235L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2368), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2370), 3, 2, 233L },
                    { 236L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2373), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2376), 4, 2, 234L },
                    { 237L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2379), 22L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2382), 5, 2, 235L },
                    { 238L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2385), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2387), 1, 1, 236L },
                    { 239L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2391), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2393), 2, 1, 237L },
                    { 240L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2396), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2399), 3, 1, 238L },
                    { 241L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2402), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2404), 4, 1, 239L },
                    { 242L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2407), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2410), 5, 1, 240L },
                    { 243L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2413), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2415), 6, 1, 241L },
                    { 244L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2418), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2421), 1, 2, 242L },
                    { 245L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2424), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2426), 2, 2, 243L },
                    { 246L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2429), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2432), 3, 2, 244L },
                    { 247L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2435), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2438), 4, 2, 245L },
                    { 248L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2441), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2443), 5, 2, 246L },
                    { 249L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2502), 23L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2505), 6, 2, 247L },
                    { 250L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2509), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2511), 1, 1, 248L },
                    { 251L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2514), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2517), 2, 1, 249L },
                    { 252L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2520), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2522), 3, 1, 250L },
                    { 253L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2526), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2528), 4, 1, 251L },
                    { 254L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2531), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2534), 1, 2, 252L },
                    { 255L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2537), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2539), 2, 2, 253L },
                    { 256L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2542), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2545), 3, 2, 254L },
                    { 257L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2548), 14L, new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2550), 4, 2, 255L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_Album_ArtistId",
                table: "SWSG_Album",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_Album_LabelId",
                table: "SWSG_Album",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_Album_StudioId",
                table: "SWSG_Album",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_AlbumSong_AlbumId",
                table: "SWSG_AlbumSong",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_AlbumSong_SongId",
                table: "SWSG_AlbumSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_Artist_CountryId",
                table: "SWSG_Artist",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_BirthPlace_CountryId",
                table: "SWSG_BirthPlace",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_Member_ArtistId",
                table: "SWSG_Member",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_Member_BirthPlaceId",
                table: "SWSG_Member",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_RefreshToken_AccountId",
                table: "SWSG_RefreshToken",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_Song_MemberId",
                table: "SWSG_Song",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_SongWriter_SongId",
                table: "SWSG_SongWriter",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "SWSG_AlbumSong");

            migrationBuilder.DropTable(
                name: "SWSG_RefreshToken");

            migrationBuilder.DropTable(
                name: "SWSG_SongWriter");

            migrationBuilder.DropTable(
                name: "SWSG_Album");

            migrationBuilder.DropTable(
                name: "SWSG_Account");

            migrationBuilder.DropTable(
                name: "SWSG_Song");

            migrationBuilder.DropTable(
                name: "SWSG_RecordLabel");

            migrationBuilder.DropTable(
                name: "SWSG_Studio");

            migrationBuilder.DropTable(
                name: "SWSG_Member");

            migrationBuilder.DropTable(
                name: "SWSG_Artist");

            migrationBuilder.DropTable(
                name: "SWSG_BirthPlace");

            migrationBuilder.DropTable(
                name: "SWSG_Country");
        }
    }
}
