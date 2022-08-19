using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SwanSong.Domain;

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

            modelBuilder.Entity<Country>().HasData(DefaultData.Lookups.GetCountryDefaultData());
            modelBuilder.Entity<RecordLabel>().HasData(DefaultData.Lookups.GetRecordLabelDefaultData());
            modelBuilder.Entity<BirthPlace>().HasData(DefaultData.Lookups.GetBirthPlaceDefaultData());
            modelBuilder.Entity<Studio>().HasData(DefaultData.Lookups.GetStudioDefaultData());
            modelBuilder.Entity<Artist>().HasData(DefaultData.Artists.GetArtistDefaultData());
            modelBuilder.Entity<Member>().HasData(DefaultData.Members.GetMemberDefaultData());
            modelBuilder.Entity<Album>().HasData(DefaultData.Albums.GetAlbumDefaultData());
            modelBuilder.Entity<Song>().HasData(DefaultData.Songs.GetSongDefaultData());
            modelBuilder.Entity<AlbumSong>().HasData(DefaultData.AlbumSongs.GetAlbumSongDefaultData());
            modelBuilder.Entity<Account>().HasData(DefaultData.Accounts.GetAccountDefaultData());
            modelBuilder.Entity<IdentityRole>().HasData(DefaultData.IdentityRoles.GetIdentityRoleDefaultData()); 
        }
    }
}


//Add-Migration Create-db
//update-database   
