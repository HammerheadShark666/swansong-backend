using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Domain.Model.Profile;

namespace SwanSong.Service.Helper
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<AccountDto, Account>();

            CreateMap<Account, ProfileDto>();
            CreateMap<ProfileDto, Account>();

            CreateMap<SwanSong.Domain.Model.Profile.Profile, ProfileDto>();
            CreateMap<ProfileDto, SwanSong.Domain.Model.Profile.Profile>();

            CreateMap<ProfilePasswordChange, ProfilePasswordChangeDto>();
            CreateMap<ProfilePasswordChangeDto, ProfilePasswordChange>();

            CreateMap<Account, ProfilePasswordChangeDto>();
            CreateMap<ProfilePasswordChangeDto, Account>();

            base.CreateMap<Account, LoginDto>() 
                .ForMember(dest => dest.IsAuthenticated, act => act.MapFrom(src => src.IsAuthenticated));

            base.CreateMap<Account, JwtRefreshTokenDto>()
                .ForPath(dest => dest.User.LastName, opts => opts.MapFrom(src => src.LastName))
                .ForPath(dest => dest.User.FirstName, opts => opts.MapFrom(src => src.FirstName))
                .ForPath(dest => dest.User.Title, opts => opts.MapFrom(src => src.Title))
                .ForPath(dest => dest.User.Email, opts => opts.MapFrom(src => src.Email))
                .ForPath(dest => dest.User.Role, opts => opts.MapFrom(src => src.Role))
                .ForMember(dest => dest.IsAuthenticated, act => act.MapFrom(src => src.IsAuthenticated));
              
            CreateMap<Account, User>();

            CreateMap<ResetPassword, ResetPasswordDto>();

            CreateMap<ResetPasswordDto, ResetPassword>();

            CreateMap<Register, Account>();

            CreateMap<Register, RegisterDto>();

            CreateMap<RegisterDto, Register>();
 
            CreateMap<Login, LoginDto>();

            CreateMap<LoginDto, Login>();

            CreateMap<JwtRefreshToken, JwtRefreshTokenDto>();

            CreateMap<JwtRefreshTokenDto, JwtRefreshToken>();

            CreateMap<RegisterVerifyEmailDto, RegisterVerifyEmail>();

            CreateMap<RegisterVerifyEmail, RegisterVerifyEmailDto>();
                  
            base.CreateMap<Artist, ArtistDto>();

            base.CreateMap<ArtistDto, Artist>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.FormationYear, act => act.MapFrom(src => src.FormationYear))
                .ForMember(dest => dest.DisbandYear, act => act.MapFrom(src => src.DisbandYear))
                .ForMember(dest => dest.CountryId, act => act.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.Photo, opt => opt.Ignore());

            base.CreateMap<Member, MemberDto>()
                .ForMember(dest => dest.StageName, act => act.MapFrom(src => src.StageName)) 
                .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.MiddleName, act => act.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.Surname, act => act.MapFrom(src => src.Surname))
                .ForMember(dest => dest.Photo, act => act.MapFrom(src => src.Photo))
                .ForMember(dest => dest.DateOfBirth, act => act.MapFrom(src => src.DateOfBirth))
                .ForMember(dest => dest.DateOfDeath, act => act.MapFrom(src => src.DateOfDeath))
                .ForMember(dest => dest.BirthPlace, act => act.MapFrom(src => src.BirthPlace));

            base.CreateMap<MemberDto, Member>();

            base.CreateMap<ArtistLookupDto, Artist>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name));

            base.CreateMap<Album, AlbumReadOnlyDto>() 
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.ArtistName, act => act.MapFrom(src => src.Artist.Name))
                .ForMember(dest => dest.ReleaseDate, act => act.MapFrom(src => src.ReleaseDate))
                .ForMember(dest => dest.Photo, act => act.MapFrom(src => src.Photo));  

            base.CreateMap<AlbumReadOnlyDto, Album>(); 
            
            base.CreateMap<Artist, ArtistLookupDto>();

            base.CreateMap<ArtistReadOnlyDto, Artist>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.FormationYear, act => act.MapFrom(src => src.FormationYear))
                .ForMember(dest => dest.Photo, act => act.MapFrom(src => src.Photo));

            base.CreateMap<Album, AlbumReadOnlyDto>();

            base.CreateMap<AlbumReadOnlyDto, Album>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.ReleaseDate, act => act.MapFrom(src => src.ReleaseDate))
                .ForMember(dest => dest.Photo, act => act.MapFrom(src => src.Photo));

            base.CreateMap<Artist, ArtistReadOnlyDto>();

            base.CreateMap<MemberReadOnlyDto, Member>();

            base.CreateMap<Member, MemberReadOnlyDto>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.StageName, act => act.MapFrom(src => src.StageName))
                .ForMember(dest => dest.ArtistName, act => act.MapFrom(src => src.Artist.Name))
                .ForMember(dest => dest.Photo, act => act.MapFrom(src => src.Photo));

            base.CreateMap<StudioDto, Studio>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name));

            base.CreateMap<Studio, StudioDto>();

            base.CreateMap<StudioReadOnlyDto, Studio>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name));            

            base.CreateMap<Studio, StudioReadOnlyDto>();

            base.CreateMap<Album, AlbumDto>()
                .ForMember(dest => dest.ArtistName, act => act.MapFrom(src => src.Artist.Name))
                .ForMember(dest => dest.LabelName, act => act.MapFrom(src => src.Label.Name))
                .ForMember(dest => dest.ArtistName, act => act.MapFrom(src => src.Artist.Name));
             
            base.CreateMap<AlbumDto, Album>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.ArtistId, act => act.MapFrom(src => src.ArtistId))               
                .ForMember(dest => dest.RecordedDate, act => act.MapFrom(src => src.RecordedDate))
                .ForMember(dest => dest.ReleaseDate, act => act.MapFrom(src => src.ReleaseDate))
                .ForMember(dest => dest.LabelId, act => act.MapFrom(src => src.LabelId))
                .ForMember(dest => dest.StudioId, act => act.MapFrom(src => src.StudioId))
                .ForMember(dest => dest.Studio, opt => opt.Ignore())
                .ForMember(dest => dest.Length, act => act.MapFrom(src => src.Length))
                .ForMember(dest => dest.Producers, act => act.MapFrom(src => src.Producers))
                .ForMember(dest => dest.Arrangers, act => act.MapFrom(src => src.Arrangers))
                .ForMember(dest => dest.Engineers, act => act.MapFrom(src => src.Engineers))
                .ForMember(dest => dest.Artwork, act => act.MapFrom(src => src.Artwork))
                .ForMember(dest => dest.Photo, act => act.MapFrom(src => src.Photo));

            base.CreateMap<RecordLabel, RecordLabelDto>();
            base.CreateMap<RecordLabelDto, RecordLabel>();

            base.CreateMap<RecordLabel, RecordLabelReadOnlyDto>();
            base.CreateMap<RecordLabelReadOnlyDto, RecordLabel>();             

            base.CreateMap<Country, CountryDto>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name));

            base.CreateMap<CountryDto, Country>();

            base.CreateMap<Country, CountryReadOnlyDto>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name));

            base.CreateMap<CountryReadOnlyDto, Country>();
             
            base.CreateMap<BirthPlace, BirthPlaceDto>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.Country, act => act.MapFrom(src => src.Country));

            base.CreateMap<BirthPlaceDto, BirthPlace>();

            base.CreateMap<SongDto, Song>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, act => act.MapFrom(src => src.Title))
                .ForMember(dest => dest.Length, act => act.MapFrom(src => src.Length));

            base.CreateMap<Song, SongDto>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, act => act.MapFrom(src => src.Title))
                .ForMember(dest => dest.Length, act => act.MapFrom(src => src.Length));

            base.CreateMap<AlbumSongDto, AlbumSong>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.AlbumId, act => act.MapFrom(src => src.AlbumId))
                .ForMember(dest => dest.Side, act => act.MapFrom(src => src.Side))
                .ForMember(dest => dest.Order, act => act.MapFrom(src => src.Order))
                .ForMember(dest => dest.Song, act => act.MapFrom(src => src.Song));

            base.CreateMap<AlbumSong, AlbumSongDto>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.AlbumId, act => act.MapFrom(src => src.AlbumId))
                .ForMember(dest => dest.Side, act => act.MapFrom(src => src.Side))
                .ForMember(dest => dest.Order, act => act.MapFrom(src => src.Order))
                .ForMember(dest => dest.Song, act => act.MapFrom(src => src.Song));
        }
    }
}