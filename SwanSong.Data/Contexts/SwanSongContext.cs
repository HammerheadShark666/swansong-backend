using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SwanSong.Domain;
using System;

namespace SwanSong.Data
{
    public class SwanSongContext : DbContext
    {
        public SwanSongContext(DbContextOptions<SwanSongContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<BirthPlace> BirthPlaces { get; set; }
        public DbSet<RecordLabel> RecordLabels { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; } 
        public DbSet<Member> Members { get; set; } 
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artist>()
              .HasMany<Member>(c => c.Members)
              .WithOne(s => s.Artist)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AlbumSong>()
                .HasOne<Song>(s => s.Song); 

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "England" },
                new Country { Id = 2, Name = "Scotland" },
                new Country { Id = 3, Name = "Wales" },
                new Country { Id = 4, Name = "Northern Ireland" },
                new Country { Id = 5, Name = "United States of America" },
                new Country { Id = 6, Name = "Australia" },
                new Country { Id = 7, Name = "Canada" }
            );

            modelBuilder.Entity<RecordLabel>().HasData(
                new RecordLabel { Id = 1, Name = "Atlantic Records" },
                new RecordLabel { Id = 2, Name = "Swan Song Records" },
                new RecordLabel { Id = 3, Name = "RCA Records" },
                new RecordLabel { Id = 4, Name = "Universal Music Publishing Group" },
                new RecordLabel { Id = 5, Name = "Sony Music Entertainment" },
                new RecordLabel { Id = 6, Name = "Columbia Label Group" },
                new RecordLabel { Id = 7, Name = "Island Records" },
                new RecordLabel { Id = 8, Name = "Reprise" },
                new RecordLabel { Id = 9, Name = "United Artists" }
            );
             
            modelBuilder.Entity<BirthPlace>().HasData(
                new BirthPlace { Id = 1, Name = "Aston, Birmingham", CountryId = 1 },
                new BirthPlace { Id = 2, Name = "Birmingham", CountryId = 1 },
                new BirthPlace { Id = 3, Name = "West Bromwich", CountryId = 1 },
                new BirthPlace { Id = 4, Name = "Heston", CountryId = 1 },
                new BirthPlace { Id = 5, Name = "Seattle", CountryId = 5 },
                new BirthPlace { Id = 6, Name = "Pontypool", CountryId = 3 },
                new BirthPlace { Id = 7, Name = "Sidcup", CountryId = 1 },
                new BirthPlace { Id = 8, Name = "Reddich", CountryId = 1 },
                new BirthPlace { Id = 9, Name = "Merton Park, London", CountryId = 1 },
                new BirthPlace { Id = 10, Name = "Long Branch, New Jersey", CountryId = 5 },
                new BirthPlace { Id = 11, Name = "Monterey Bay", CountryId = 5 },
                new BirthPlace { Id = 12, Name = "Pinner, Middlesex", CountryId = 1 },
                new BirthPlace { Id = 13, Name = "Liverpool, Lancashire", CountryId = 1 },
                new BirthPlace { Id = 14, Name = "Vancouver", CountryId = 7 }
            );

            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, Name = "Led Zeppelin", FormationYear = 1967, DisbandYear = 1980, CountryId = 1, Photo = "458eb53a-aba7-42a2-a5ed-526da552966e.jpg" },
                new Artist { Id = 2, Name = "Sandy Denny", CountryId = 1, Photo = "0ed76f7d-e5da-4e5b-87b0-a8ecb4a165cd.jpg" },
                new Artist { Id = 3, Name = "Bruce Springsteen", CountryId = 5, Photo = "32ce9c93-9129-4bff-b166-db5ada039757.jpg" },
                new Artist { Id = 4, Name = "John Denver", CountryId = 5, Photo = "f94fb03e-c368-4562-9c66-2b2db5722252.jpg" },
                new Artist { Id = 5, Name = "Elton John", CountryId = 1, Photo = "64fa7eb5-dca2-4ed3-a465-fa6904bba895.jpg" },
                new Artist { Id = 6, Name = "John Lennon", CountryId = 1, Photo = "e0ceb7ed-5481-4cc1-926f-59cf31fd2e69.jpg" },
                new Artist { Id = 7, Name = "Bob Dylan", FormationYear = 1962, CountryId = 5, Photo = "567552b5-27d5-4a6e-acc5-449017fcd47e.jpg" },
                new Artist { Id = 8, Name = "Manic Street Preachers", FormationYear = 1986, CountryId = 3, Photo = "8117dfa2-41a4-4be1-a33f-fd7484ae5d7a.jpg" },
                new Artist { Id = 9, Name = "Ozzy Osbourne", FormationYear = 1979, CountryId = 1, Photo = "99cc2dbe-5671-4eca-947d-8f7a4f1759af.jpg" },
                new Artist { Id = 10, Name = "The Stranglers", FormationYear = 1974, CountryId = 1, Photo = "8b728b1e-c506-4d08-b87d-9f320f4cc920.jpg" },
                new Artist { Id = 11, Name = "Simple Minds", FormationYear = 1977, CountryId = 2, Photo = "2a39824d-1c56-46fe-b4bc-b7e87dfb7bb3.jpg" },
                new Artist { Id = 12, Name = "Deep Purple", FormationYear = 1968, CountryId = 1, Photo = "5863254c-693f-43e3-b0f8-a7ebdeb8ec33.jpg" },
                new Artist { Id = 13, Name = "Motorhead", FormationYear = 1975, CountryId = 1, Photo = "2691c7fa-2546-401e-a10b-1608e00711d2.jpg" },
                new Artist { Id = 14, Name = "ACDC", FormationYear = 1973, CountryId = 6, Photo = "85d9174f-1f0d-4221-8635-f86c211caa4d.jpg" },
                new Artist { Id = 15, Name = "Jimi Hendrix", FormationYear = 1961, DisbandYear = 1970, CountryId = 5, Photo = "f44802e4-ab03-4d2c-be3e-c094eced3c99.jpg" },
                new Artist { Id = 16, Name = "Fleetwood Mac", FormationYear = 1967, CountryId = 1, Photo = "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
                new Artist { Id = 17, Name = "Nirvana", FormationYear = 1987, CountryId = 5, Photo = "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
                new Artist { Id = 18, Name = "Kate Bush", FormationYear = 1975, CountryId = 1, Photo = "default-artist-image.jpg" },
                new Artist { Id = 19, Name = "Tori Amos", FormationYear = null, CountryId = 5, Photo = "default-artist-image.jpg" },
                new Artist { Id = 20, Name = "U2", FormationYear = 1975, CountryId = 1, Photo = "default-artist-image.jpg" }
            );

            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, ArtistId = 1, StageName = "Jimmy Page", FirstName = "James", Surname = "Page", MiddleName = "Patrick", DateOfBirth = new DateTime(1944, 1, 9), BirthPlaceId = 4, IsSongWriter = true, Photo = "jimmy-page.jpg" },
                new Member { Id = 2, ArtistId = 1, StageName = "Robert Plant", FirstName = "Robert", Surname = "Plant", MiddleName = "Anthony", DateOfBirth = new DateTime(1948, 8, 20), BirthPlaceId = 3, IsSongWriter = true, Photo = "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg" },
                new Member { Id = 3, ArtistId = 1, StageName = "John Paul Jones", FirstName = "John", Surname = "Paul", MiddleName = "Jones", DateOfBirth = new DateTime(1946, 1, 3), BirthPlaceId = 7, IsSongWriter = true, Photo = "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg" },
                new Member { Id = 4, ArtistId = 1, StageName = "John Bonham", FirstName = "John", Surname = "Henry", MiddleName = "Bonham", DateOfBirth = new DateTime(1948, 5, 31), BirthPlaceId = 8, IsSongWriter = true, Photo = "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg" },
                new Member { Id = 5, ArtistId = 2, StageName = "Sandy Denny", FirstName = "Alexandra", Surname = "Denny", MiddleName = "Elene MacLean", DateOfBirth = new DateTime(1947, 1, 6), DateOfDeath = new DateTime(1978, 4, 21), BirthPlaceId = 9, IsSongWriter = true, Photo = "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg" },
                new Member { Id = 6, ArtistId = 3, StageName = "Bruce Springsteen", FirstName = "Bruce", Surname = "Springsteen", DateOfBirth = new DateTime(1949, 9, 23), BirthPlaceId = 10, IsSongWriter = true },
                new Member { Id = 7, ArtistId = 4, StageName = "John Denver", FirstName = "John", Surname = "Denver", DateOfBirth = new DateTime(1943, 12, 31), DateOfDeath = new DateTime(1997, 10, 12), BirthPlaceId = 11, IsSongWriter = true },
                new Member { Id = 8, ArtistId = 5, StageName = "Elton John", FirstName = "Elton", Surname = "John", DateOfBirth = new DateTime(1947, 3, 25), BirthPlaceId = 12, IsSongWriter = true },
                new Member { Id = 9, ArtistId = 6, StageName = "John Lennon", FirstName = "John", Surname = "Lennon", DateOfBirth = new DateTime(1940, 10, 9), DateOfDeath = new DateTime(1980, 12, 8), BirthPlaceId = 13, IsSongWriter = true },
                new Member { Id = 10, ArtistId = 15, StageName = "Jimi Hendrix", FirstName = "James", MiddleName = "Allen", Surname = "Hendrix", DateOfBirth = new DateTime(1942, 11, 27), DateOfDeath = new DateTime(1970, 9, 18), BirthPlaceId = 14, IsSongWriter = true }
            );

            modelBuilder.Entity<Studio>().HasData(
                new Studio { Id = 1, Name = "Island Studios London, Sound Techniques London" },
                new Studio { Id = 2, Name = "914 Sound Studios, Blauvelt, New York" }
            );

            modelBuilder.Entity<Album>().HasData(
                new Album { Id = 1, Name = "Led Zeppelin 1", ArtistId = 1, ReleaseDate = new DateTime(1969, 3, 31), LabelId = 1, Photo = "11d15486-fefc-463c-8b7d-c755b08466dc.jpg" },
                new Album
                {
                    Id = 2,
                    Name = "The North Star Grassman and the Ravens",
                    ArtistId = 2,
                    ReleaseDate = new DateTime(1986, 9, 1),
                    LabelId = 7,
                    RecordedDate = new DateTime(1971, 9, 1),
                    StudioId = 1,
                    Length = "39:41",
                    Producers = "John Wood, Richard Thompson, Sandy Denny",
                    Arrangers = "Sandy Denny",
                    Engineers = "John Wood",
                    Artwork = "Keef",
                    Photo = "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg"
                },
                new Album { Id = 3, Name = "Led Zeppelin 2", ArtistId = 1, ReleaseDate = new DateTime(1969, 10, 22), LabelId = 1, Photo = "ee552af1-7a5a-457b-b336-823bc1285dac.jpg" },
                new Album { Id = 4, Name = "Led Zeppelin 3", ArtistId = 1, ReleaseDate = new DateTime(1970, 10, 5), LabelId = 1, Photo = "9cf368d3-db16-4120-af40-7dd697b934fa.jpg" },
                new Album { Id = 5, Name = "Led Zeppelin IV", ArtistId = 1, ReleaseDate = new DateTime(1971, 11, 8), LabelId = 1, Photo = "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg" },
                new Album { Id = 6, Name = "Houses of the Holy", ArtistId = 1, ReleaseDate = new DateTime(1973, 3, 28), LabelId = 1, Photo = "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg" },
                new Album { Id = 7, Name = "Physical Graffiti", ArtistId = 1, ReleaseDate = new DateTime(1975, 2, 24), LabelId = 2, Photo = "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg" },
                new Album { Id = 8, Name = "The Song Remains The Same", ArtistId = 1, ReleaseDate = new DateTime(1976, 9, 28), LabelId = 2, Photo = "d2710986-0720-4231-8582-4383eb9ffe12.jpg" },
                new Album { Id = 9, Name = "Presence", ArtistId = 1, ReleaseDate = new DateTime(1976, 3, 31), LabelId = 2, Photo = "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg" },
                new Album { Id = 10, Name = "In Through The OutDoor", ArtistId = 1, ReleaseDate = new DateTime(1979, 8, 15), LabelId = 2, Photo = "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg" },
                new Album { Id = 11, Name = "Electric Ladyland", ArtistId = 15, ReleaseDate = new DateTime(1968, 10, 16), LabelId = 8, Photo = "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg" },
                new Album { Id = 12, Name = "Rumours", ArtistId = 16, ReleaseDate = new DateTime(1977, 4, 2), Length = "39:43", Producers = "Fleetwood Mac, Ken Caillat, Richard Dashut", Photo = "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg" },
                new Album { Id = 13, Name = "The River", ArtistId = 3, Photo = "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg" },
                new Album { Id = 14, Name = "Born To Run", ArtistId = 3, Photo = "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg" },
                new Album { Id = 15, Name = "Darkness on the Edge of Town", ArtistId = 3, Photo = "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg" },
                new Album { Id = 16, Name = "Bark At The Moon", ArtistId = 9, Photo = "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg" },
                new Album { Id = 17, Name = "The Raven", ArtistId = 10, ReleaseDate = new DateTime(1979, 9, 14), LabelId = 9, Photo = "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg" },
                new Album { Id = 18, Name = "Men In Black", ArtistId = 10, Photo = "default-album-image.jpg" },
                new Album { Id = 19, Name = "Nebraska", ArtistId = 3, Photo = "default-album-image.jpg" },
                new Album { Id = 20, Name = "Iron Fist", ArtistId = 13, Photo = "default-album-image.jpg" },
                new Album { Id = 21, Name = "Stormbringer", ArtistId = 12, Photo = "default-album-image.jpg" },
                new Album { Id = 22, Name = "Nashville Skyline", ArtistId = 7, Photo = "default-album-image.jpg" },
                new Album { Id = 23, Name = "Born In The Usa", ArtistId = 3, Photo = "default-album-image.jpg" },
                new Album { Id = 24, Name = "Nevermind", ArtistId = 17, ReleaseDate = new DateTime(1991, 8, 31), Photo = "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg" }
            );

            modelBuilder.Entity<Song>().HasData(
                new Song { Id = 1, Title = "Good Times Bad Times", Length = "2:46" },
                new Song { Id = 2, Title = "Babe I'm Gonna Leave You", Length = "6:42" },
                new Song { Id = 3, Title = "You Shook Me", Length = "6:28" },
                new Song { Id = 4, Title = "Dazed and Confused", Length = "6:28" },
                new Song { Id = 5, Title = "Your Time Is Gonna Come", Length = "4:34" },
                new Song { Id = 6, Title = "Black Mountain Side", Length = "2:12" },
                new Song { Id = 7, Title = "Communication Breakdown", Length = "2:30" },
                new Song { Id = 8, Title = "I Can't Quit You Baby", Length = "4:42" },
                new Song { Id = 9, Title = "How Many More Times", Length = "8:27" },
                new Song { Id = 10, Title = "Late November", Length = "4:28" },
                new Song { Id = 11, Title = "Blackwaterside(Traditional) ", Length = "4:07" },
                new Song { Id = 12, Title = "The Sea Captain", Length = "3:09" },
                new Song { Id = 13, Title = "Down in the Flood(Bob Dylan)", Length = "3:20" },
                new Song { Id = 14, Title = "John the Gun", Length = "4:38" },
                new Song { Id = 15, Title = "Next Time Around", Length = "4:26" },
                new Song { Id = 16, Title = "The Optimist", Length = "3:24" },
                new Song { Id = 17, Title = "Let’s Jump the Broomstick(Charles Robins)", Length = "2:42" },
                new Song { Id = 18, Title = "Wretched Wilbur", Length = "2:38" },
                new Song { Id = 19, Title = "The North Star Grassman and the Ravens", Length = "3:27" },
                new Song { Id = 20, Title = "Crazy Lady Blues", Length = "3:22" },
                new Song { Id = 21, Title = "Smells Like Teen Spirit", Length = "5:01" },
                new Song { Id = 22, Title = "In Bloom", Length = "4:14" },
                new Song { Id = 23, Title = "Come as You Are", Length = "3:39" },
                new Song { Id = 24, Title = "Breed", Length = "3:03" },
                new Song { Id = 25, Title = "Lithium", Length = "4:17" },
                new Song { Id = 26, Title = "Polly", Length = "2:57" },
                new Song { Id = 27, Title = "Territorial", Length = "Pissings    2:22" },
                new Song { Id = 28, Title = "Drain You", Length = "3:43" },
                new Song { Id = 29, Title = "Lounge Act", Length = "2:36" },
                new Song { Id = 30, Title = "Stay Away", Length = "3:32" },
                new Song { Id = 31, Title = "On a Plain", Length = "3:16" },
                new Song { Id = 32, Title = "Something in the Way", Length = "3:52" },
                new Song { Id = 33, Title = "Endless, Nameless", Length = "6:43" },
                new Song { Id = 34, Title = "Longships", Length = "1:10" },
                new Song { Id = 35, Title = "The Raven", Length = "5:13" },
                new Song { Id = 36, Title = "Dead Loss Angeles", Length = "2:24" },
                new Song { Id = 37, Title = "Ice", Length = "3:26" },
                new Song { Id = 38, Title = "Baroque Bordello", Length = "3:50" },
                new Song { Id = 39, Title = "Nuclear Device(The Wizard of Aus)", Length = "3:32" },
                new Song { Id = 40, Title = "Whole Lotta Love", Length = "5:38" },
                new Song { Id = 41, Title = "What Is and What Should Never Be", Length = "4:33" },
                new Song { Id = 42, Title = "Thank You", Length = "4:21" },
                new Song { Id = 43, Title = "The Lemon Song", Length = "6:20" },
                new Song { Id = 44, Title = "Heartbreaker", Length = " 4:14" },
                new Song { Id = 45, Title = "Living Loving Maid(She's Just a Woman)", Length = "2:39" },
                new Song { Id = 46, Title = "Ramble On", Length = "4:34" },
                new Song { Id = 47, Title = "The Song Remains the Same", Length = "5:32" },
                new Song { Id = 48, Title = "The Rain Song", Length = "7:39" },
                new Song { Id = 49, Title = "Over the Hills and Far Away", Length = "4:50" },
                new Song { Id = 50, Title = "The Crunge", Length = "3:17" },
                new Song { Id = 51, Title = "Dancing Days", Length = "3:43" },
                new Song { Id = 52, Title = "D'yer Mak'er", Length = "4:23" },
                new Song { Id = 53, Title = "No Quarter", Length = "7:00" },
                new Song { Id = 54, Title = "The Ocean", Length = "4:31" }
            );

            modelBuilder.Entity<AlbumSong>().HasData(
                new AlbumSong { Id = 1, AlbumId = 1, SongId = 1, Order = 1, Side = 1 },
                new AlbumSong { Id = 2, AlbumId = 1, SongId = 2, Order = 2, Side = 1 },
                new AlbumSong { Id = 3, AlbumId = 1, SongId = 3, Order = 3, Side = 1 },
                new AlbumSong { Id = 4, AlbumId = 1, SongId = 4, Order = 4, Side = 1 },
                new AlbumSong { Id = 5, AlbumId = 1, SongId = 5, Order = 5, Side = 2 },
                new AlbumSong { Id = 6, AlbumId = 1, SongId = 6, Order = 6, Side = 2 },
                new AlbumSong { Id = 7, AlbumId = 1, SongId = 7, Order = 7, Side = 2 },
                new AlbumSong { Id = 8, AlbumId = 1, SongId = 8, Order = 8, Side = 2 },
                new AlbumSong { Id = 9, AlbumId = 1, SongId = 9, Order = 9, Side = 2 },
                new AlbumSong { Id = 10, AlbumId = 2, SongId = 10, Order = 1, Side = 1 },
                new AlbumSong { Id = 11, AlbumId = 2, SongId = 11, Order = 2, Side = 1 },
                new AlbumSong { Id = 12, AlbumId = 2, SongId = 12, Order = 3, Side = 1 },
                new AlbumSong { Id = 13, AlbumId = 2, SongId = 13, Order = 4, Side = 1 },
                new AlbumSong { Id = 14, AlbumId = 2, SongId = 14, Order = 5, Side = 1 },
                new AlbumSong { Id = 15, AlbumId = 2, SongId = 15, Order = 6, Side = 2 },
                new AlbumSong { Id = 16, AlbumId = 2, SongId = 16, Order = 7, Side = 2 },
                new AlbumSong { Id = 17, AlbumId = 2, SongId = 17, Order = 8, Side = 2 },
                new AlbumSong { Id = 18, AlbumId = 2, SongId = 18, Order = 9, Side = 2 },
                new AlbumSong { Id = 19, AlbumId = 2, SongId = 19, Order = 10, Side = 2 },
                new AlbumSong { Id = 20, AlbumId = 2, SongId = 20, Order = 11, Side = 2 },
                new AlbumSong { Id = 21, AlbumId = 24, SongId = 21, Order = 1, Side = 1 },
                new AlbumSong { Id = 22, AlbumId = 24, SongId = 22, Order = 2, Side = 1 },
                new AlbumSong { Id = 23, AlbumId = 24, SongId = 23, Order = 3, Side = 1 },
                new AlbumSong { Id = 24, AlbumId = 24, SongId = 24, Order = 4, Side = 1 },
                new AlbumSong { Id = 25, AlbumId = 24, SongId = 25, Order = 5, Side = 1 },
                new AlbumSong { Id = 26, AlbumId = 24, SongId = 26, Order = 6, Side = 1 },
                new AlbumSong { Id = 27, AlbumId = 24, SongId = 27, Order = 1, Side = 2 },
                new AlbumSong { Id = 28, AlbumId = 24, SongId = 28, Order = 2, Side = 2 },
                new AlbumSong { Id = 29, AlbumId = 24, SongId = 29, Order = 3, Side = 2 },
                new AlbumSong { Id = 30, AlbumId = 24, SongId = 30, Order = 4, Side = 2 },
                new AlbumSong { Id = 31, AlbumId = 24, SongId = 31, Order = 5, Side = 2 },
                new AlbumSong { Id = 34, AlbumId = 24, SongId = 32, Order = 6, Side = 2 },
                new AlbumSong { Id = 35, AlbumId = 24, SongId = 33, Order = 7, Side = 2 },
                new AlbumSong { Id = 36, AlbumId = 17, SongId = 34, Order = 7, Side = 2 },
                new AlbumSong { Id = 37, AlbumId = 17, SongId = 35, Order = 1, Side = 1 },
                new AlbumSong { Id = 38, AlbumId = 17, SongId = 36, Order = 2, Side = 1 },
                new AlbumSong { Id = 39, AlbumId = 17, SongId = 37, Order = 3, Side = 1 },
                new AlbumSong { Id = 40, AlbumId = 17, SongId = 38, Order = 4, Side = 1 },
                new AlbumSong { Id = 41, AlbumId = 17, SongId = 39, Order = 5, Side = 1 },
                new AlbumSong { Id = 43, AlbumId = 3, SongId = 40, Order = 1, Side = 1 },
                new AlbumSong { Id = 44, AlbumId = 3, SongId = 41, Order = 2, Side = 1 },
                new AlbumSong { Id = 45, AlbumId = 3, SongId = 42, Order = 4, Side = 1 },
                new AlbumSong { Id = 46, AlbumId = 3, SongId = 43, Order = 3, Side = 1 },
                new AlbumSong { Id = 47, AlbumId = 3, SongId = 44, Order = 1, Side = 2 },
                new AlbumSong { Id = 48, AlbumId = 3, SongId = 45, Order = 2, Side = 2 },
                new AlbumSong { Id = 49, AlbumId = 3, SongId = 46, Order = 3, Side = 2 },
                new AlbumSong { Id = 50, AlbumId = 6, SongId = 47, Order = 1, Side = 1 },
                new AlbumSong { Id = 51, AlbumId = 6, SongId = 48, Order = 2, Side = 1 },
                new AlbumSong { Id = 52, AlbumId = 6, SongId = 49, Order = 3, Side = 1 },
                new AlbumSong { Id = 53, AlbumId = 6, SongId = 50, Order = 4, Side = 1 },
                new AlbumSong { Id = 54, AlbumId = 6, SongId = 51, Order = 1, Side = 2 },
                new AlbumSong { Id = 55, AlbumId = 6, SongId = 52, Order = 2, Side = 2 },
                new AlbumSong { Id = 56, AlbumId = 6, SongId = 53, Order = 3, Side = 2 },
                new AlbumSong { Id = 57, AlbumId = 6, SongId = 54, Order = 4, Side = 2 }
            );

            modelBuilder.Entity<SongWriter>().HasData(
                new SongWriter { Id = 1, SongId = 1, PersonId = 1 },
                new SongWriter { Id = 2, SongId = 1, PersonId = 2 },
                new SongWriter { Id = 3, SongId = 1, PersonId = 3 },
                new SongWriter { Id = 4, SongId = 1, PersonId = 4 },
                new SongWriter { Id = 5, SongId = 10, PersonId = 5 }
            );

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = 1,
                    FirstName = "test",
                    LastName = "test",
                    Email = "Test100@hotmail.com",
                    PasswordHash = "$2a$11$6J/RawAXn5hbcQwiVor7A.dEtLcMcUF8BI/EOMrAa2002hNJB8ZKC",
                    AcceptTerms = false,
                    Role = Domain.Helper.Enums.Role.SuperAdmin,
                    Verified = new DateTime(),
                    ResetToken = "142CEC560EBE8EA56F8344E178948EE76022B02B0D407A974611AFCDA7849FCD83826607543C0CA0",
                    Created = new DateTime()
                }
            );

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "USER", NormalizedName = "USER".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "ADMIN", NormalizedName = "ADMIN".ToUpper() });
         }
    }
}


//Add-Migration Create-db
//update-database   
