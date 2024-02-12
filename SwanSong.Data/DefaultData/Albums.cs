using SwanSong.Domain;
using System;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData;

public class Albums
{
    public static List<Album> GetAlbumDefaultData()
    {
        return new List<Album>()
        {
            new Album { Id = 1, Name = "Led Zeppelin 1", ArtistId = 1, ReleaseDate = new DateTime(1969, 3, 31), LabelId = 1, Photo = "11d15486-fefc-463c-8b7d-c755b08466dc.jpg" },
            new Album { Id = 2, Name = "The North Star Grassman and the Ravens", ArtistId = 2, ReleaseDate = new DateTime(1986, 9, 1), LabelId = 7, RecordedDate = new DateTime(1971, 9, 1), StudioId = 1, Producers = "John Wood, Richard Thompson, Sandy Denny", Arrangers = "Sandy Denny", Engineers = "John Wood", Artwork = "Keef", Photo = "e3b74057-75df-4cfe-ba42-9ed4f57623f5.jpg"},
            new Album { Id = 3, Name = "Led Zeppelin 2", ArtistId = 1, ReleaseDate = new DateTime(1969, 10, 22), LabelId = 1, Photo = "ee552af1-7a5a-457b-b336-823bc1285dac.jpg" },
            new Album { Id = 4, Name = "Led Zeppelin 3", ArtistId = 1, ReleaseDate = new DateTime(1970, 10, 5), LabelId = 1, Photo = "9cf368d3-db16-4120-af40-7dd697b934fa.jpg" },
            new Album { Id = 5, Name = "Led Zeppelin IV", ArtistId = 1, ReleaseDate = new DateTime(1971, 11, 8), LabelId = 1, Photo = "3e7e88f2-5fa8-4402-ad90-39d5f14f14c7.jpg" },
            new Album { Id = 6, Name = "Houses of the Holy", ArtistId = 1, ReleaseDate = new DateTime(1973, 3, 28), LabelId = 1, Photo = "45e3d1ea-6cb0-43c5-93c9-b2593b4f64d4.jpg" },
            new Album { Id = 7, Name = "Physical Graffiti", ArtistId = 1, ReleaseDate = new DateTime(1975, 2, 24), LabelId = 2, Photo = "7f616f0b-8c58-4bbd-a438-0692b803ba50.jpg" },
            new Album { Id = 8, Name = "The Song Remains The Same", ArtistId = 1, ReleaseDate = new DateTime(1976, 9, 28), LabelId = 2, Photo = "d2710986-0720-4231-8582-4383eb9ffe12.jpg" },
            new Album { Id = 9, Name = "Presence", ArtistId = 1, ReleaseDate = new DateTime(1976, 3, 31), LabelId = 2, Photo = "a0ec6d77-a1f6-4118-baed-157e40c5a50b.jpg" },
            new Album { Id = 10, Name = "In Through The OutDoor", ArtistId = 1, ReleaseDate = new DateTime(1979, 8, 15), LabelId = 2, Photo = "6fcc74a1-bd11-439a-8a71-c52f50273617.jpg" },
            new Album { Id = 11, Name = "Electric Ladyland", ArtistId = 15, ReleaseDate = new DateTime(1968, 10, 16), LabelId = 8, Photo = "5a90f23e-c8bc-42f6-b707-d2367e9944bb.jpg" },
            new Album { Id = 12, Name = "Rumours", ArtistId = 16, ReleaseDate = new DateTime(1977, 4, 2), Producers = "Fleetwood Mac, Ken Caillat, Richard Dashut", Photo = "549c2970-fcf9-4ac4-824b-31f69a4f2159.jpg" },
            new Album { Id = 13, Name = "The River", ArtistId = 3, Photo = "6fc79109-d0db-4a34-8d07-f7c9866ddd5e.jpg" },
            new Album { Id = 14, Name = "Born To Run", ArtistId = 3, Photo = "a4f987e1-17d4-44a6-a929-ad29002dd31b.jpg" },
            new Album { Id = 15, Name = "Darkness on the Edge of Town", ArtistId = 3, Photo = "5f63ee74-d7c8-480d-8ab9-4362ccf26492.jpg" },
            new Album { Id = 16, Name = "Bark At The Moon", ArtistId = 9, Photo = "7413f9cb-77fc-4a2b-9372-51e0abd9ccea.jpg" },
            new Album { Id = 17, Name = "The Raven", ArtistId = 10, ReleaseDate = new DateTime(1979, 9, 14), LabelId = 9, Photo = "c5d29d3d-3bf8-4a60-ad9a-411b86c026dd.jpg" },
            new Album { Id = 19, Name = "Nebraska", ArtistId = 3, Photo = "6e2e5c69-75cd-480e-9b28-6d3726df576f.jpg" },
            new Album { Id = 20, Name = "Iron Fist", ArtistId = 13, Photo = "39c3f690-87cd-4cd2-8a9a-54ba8af3a50f.jpg" },
            new Album { Id = 21, Name = "Stormbringer", ArtistId = 12, Photo = "d96d1eac-982a-41a2-b2dd-ff65707940e1.jpg" },
            new Album { Id = 22, Name = "Nashville Skyline", ArtistId = 7, Photo = "722792d3-787b-4698-916d-0ff766e68fd6.jpg" },
            new Album { Id = 23, Name = "Born In The Usa", ArtistId = 3, Photo = "66c0e775-c22b-427d-a327-e6bfd9b5673e.jpg" },
            new Album { Id = 24, Name = "Nevermind", ArtistId = 17, ReleaseDate = new DateTime(1991, 8, 31), Photo = "a3828e09-6f78-484f-80b0-d57f6a1e972b.jpg" }
           };
    }
}