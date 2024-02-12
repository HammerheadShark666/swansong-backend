using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData;

public class Artists
{
    public static List<Artist> GetArtistDefaultData()
    {
        return new List<Artist>()
        {
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
            new Artist { Id = 15, Name = "Jimi Hendrix", FormationYear = 1961, DisbandYear = 1970, CountryId = 5, Photo = "f304b989-f26e-4aa5-8c78-1d1b49850bee.jpg" },
            new Artist { Id = 16, Name = "Fleetwood Mac", FormationYear = 1967, CountryId = 1, Photo = "c75ac394-e941-412a-8f83-701b7aeb1e83.jpg" },
            new Artist { Id = 17, Name = "Nirvana", FormationYear = 1987, CountryId = 5, Photo = "3f9452b1-99c8-4a79-89bd-bd5db4c2d908.jpg" },
            new Artist { Id = 18, Name = "Kate Bush", FormationYear = 1975, CountryId = 1, Photo = "909e5592-09a3-4018-a3a8-e067612c7388.jpg" },
            new Artist { Id = 19, Name = "Tori Amos", FormationYear = null, CountryId = 5, Photo = "22d853a2-cd81-4362-a6a5-d15c17c83194.jpg" },
            new Artist { Id = 20, Name = "U2", FormationYear = 1975, CountryId = 1, Photo = "af794a29-19e8-440f-a5e2-113319932b40.jpg" }
        };
    }
}