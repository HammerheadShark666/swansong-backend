using SwanSong.Domain;
using SwanSong.Domain.Dto;
using System.Collections.Generic;

namespace SwanSong.Helper;

public class AutoMapperProfile : AutoMapper.Profile
{
    public AutoMapperProfile()
    {   
        CreateMap<Member, MemberAddRequest>().ReverseMap();
        CreateMap<Member, MemberUpdateRequest>().ReverseMap();
        CreateMap<Member, MemberActionResponse>().ReverseMap();
        CreateMap<Member, MemberResponse>().ReverseMap(); 

        CreateMap<Artist, ArtistAddRequest>().ReverseMap();
        CreateMap<Artist, ArtistUpdateRequest>().ReverseMap();
        CreateMap<Artist, ArtistActionResponse>().ReverseMap();
        CreateMap<Artist, ArtistResponse>().ReverseMap();
        CreateMap<Artist, ArtistLookUpResponse>() //.ReverseMap();
          .ConstructUsing((artist, c) => new ArtistLookUpResponse(
              artist.Id,
              artist.Name,
              artist.Photo));

        CreateMap<Album, AlbumAddRequest>().ReverseMap();
        CreateMap<Album, AlbumUpdateRequest>().ReverseMap();
        CreateMap<Album, AlbumActionResponse>().ReverseMap();
        CreateMap<Album, AlbumResponse>()
          .ConstructUsing((album, c) => new AlbumResponse(               
              album.Id,
              album.Name,
              album.ArtistId,
              album.Artist.Name,
              album.ReleaseDate,
              album.RecordedDate,
              album.LabelId,
              album.StudioId,
              album.Producers,
              album.Arrangers,
              album.Engineers,
              album.Artwork,
              album.Photo,
              c.Mapper.Map<List<AlbumSongResponse>>(album.AlbumSongs))); 
         
        CreateMap<Album, AlbumLookUpResponse>()
          .ConstructUsing(album => new AlbumLookUpResponse(
              album.Id,
              album.Name,
              album.ReleaseDate, "",
              album.Photo, "", ""));

        CreateMap<AlbumSong, AlbumSongAddRequest>().ReverseMap();
        CreateMap<AlbumSong, AlbumSongUpdateRequest>().ReverseMap();
        CreateMap<AlbumSong, AlbumSongActionResponse>().ReverseMap();

        CreateMap<AlbumSong, AlbumSongResponse>()
            .ConstructUsing(albumSong => new AlbumSongResponse(
                albumSong.Id,
                albumSong.AlbumId,
                albumSong.SongId, 
                new SongResponse(albumSong.Song.Id, albumSong.Song.Title, albumSong.Song.Length),              
                albumSong.Order,
                albumSong.Side
                ));

        CreateMap<Song, AlbumSongSongAddRequest>().ReverseMap();
        CreateMap<Song, AlbumSongSongUpdateRequest>().ReverseMap();
        CreateMap<Song, SongActionResponse>().ReverseMap();

        CreateMap<Song, SongResponse>()
            .ConstructUsing(song => new SongResponse(
                song.Id,
                song.Title,
                song.Length
                ));         
          
        CreateMap<ProfilePasswordChangeRequest, ProfilePasswordChangeActionResponse>().ReverseMap(); 
        CreateMap<Account, ProfilePasswordChangeRequest>().ReverseMap();
        CreateMap<Account, ProfileResponse>().ReverseMap();
        CreateMap<Account, ProfileRequest>().ReverseMap();
        CreateMap<Account, JwtRefreshTokenActionResponse>().ReverseMap();
        CreateMap<Account, LoginActionResponse>().ReverseMap(); 
        CreateMap<RegisterRequest, Account>().ReverseMap(); 

        CreateMap<RecordLabel, RecordLabelResponse>().ReverseMap();
        CreateMap<RecordLabel, RecordLabelActionResponse>().ReverseMap();
        CreateMap<RecordLabel, RecordLabelAddRequest>().ReverseMap();
        CreateMap<RecordLabel, RecordLabelUpdateRequest>().ReverseMap();

        CreateMap<Country, CountryResponse>().ReverseMap();
        CreateMap<Country, CountryActionResponse>().ReverseMap();
        CreateMap<Country, CountryAddRequest>().ReverseMap();
        CreateMap<Country, CountryUpdateRequest>().ReverseMap();

        CreateMap<Studio, StudioResponse>().ReverseMap();
        CreateMap<Studio, StudioActionResponse>().ReverseMap();
        CreateMap<Studio, StudioAddRequest>().ReverseMap();
        CreateMap<Studio, StudioUpdateRequest>().ReverseMap();

        CreateMap<BirthPlace, BirthPlaceResponse>().ReverseMap();
        CreateMap<BirthPlace, BirthPlaceActionResponse>().ReverseMap();
        CreateMap<BirthPlace, BirthPlaceAddRequest>().ReverseMap();
        CreateMap<BirthPlace, BirthPlaceUpdateRequest>().ReverseMap();  
    }
}