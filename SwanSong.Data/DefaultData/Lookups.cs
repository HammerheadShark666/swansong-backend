using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData;

public class Lookups
{
    public static List<Country> GetCountryDefaultData()
    {
        return new List<Country>()
        {
            new Country { Id = 1, Name = "England" },
            new Country { Id = 2, Name = "Scotland" },
            new Country { Id = 3, Name = "Wales" },
            new Country { Id = 4, Name = "Northern Ireland" },
            new Country { Id = 5, Name = "United States of America" },
            new Country { Id = 6, Name = "Australia" },
            new Country { Id = 7, Name = "Canada" }
        };
    }

    public static List<RecordLabel> GetRecordLabelDefaultData()
    {
        return new List<RecordLabel>()
        {
            new RecordLabel { Id = 1, Name = "Atlantic Records" },
            new RecordLabel { Id = 2, Name = "Swan Song Records" },
            new RecordLabel { Id = 3, Name = "RCA Records" },
            new RecordLabel { Id = 4, Name = "Universal Music Publishing Group" },
            new RecordLabel { Id = 5, Name = "Sony Music Entertainment" },
            new RecordLabel { Id = 6, Name = "Columbia Label Group" },
            new RecordLabel { Id = 7, Name = "Island Records" },
            new RecordLabel { Id = 8, Name = "Reprise" },
            new RecordLabel { Id = 9, Name = "United Artists" }
        };
    }

    public static List<BirthPlace> GetBirthPlaceDefaultData()
    {
        return new List<BirthPlace>()
        {
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
            new BirthPlace { Id = 14, Name = "Vancover", CountryId = 7 },
            new BirthPlace { Id = 15, Name = "Duluth, Minnesota", CountryId = 5 },
            new BirthPlace { Id = 16, Name = "Marston Green, Warwickshire", CountryId = 1 },
            new BirthPlace { Id = 17, Name = "Tufnell Park, North London", CountryId = 1 },
            new BirthPlace { Id = 18, Name = "Notting Hill, London", CountryId = 1 },
            new BirthPlace { Id = 19, Name = "Brighton, London", CountryId = 1 },
            new BirthPlace { Id = 21, Name = "Ilford, Essex", CountryId = 1 },
            new BirthPlace { Id = 22, Name = "Toryglen, Glasgow", CountryId = 2 },
            new BirthPlace { Id = 23, Name = "Glasgow", CountryId = 2 },
            new BirthPlace { Id = 24, Name = "Dundee", CountryId = 2 },
            new BirthPlace { Id = 25, Name = "Nottingham", CountryId = 1 },
            new BirthPlace { Id = 26, Name = "Brecon", CountryId = 3 },
            new BirthPlace { Id = 27, Name = "Chiswick, London", CountryId = 1 },
            new BirthPlace { Id = 28, Name = "Stoke-on-Trent, Staffordshire", CountryId = 1 },
            new BirthPlace { Id = 29, Name = "London", CountryId = 1 },
            new BirthPlace { Id = 30, Name = "Twickenham, Middlesex", CountryId = 1 },
            new BirthPlace { Id = 31, Name = "Melbourne, Victoria", CountryId = 6 },
            new BirthPlace { Id = 32, Name = "Romford, Essex", CountryId = 1 },
            new BirthPlace { Id = 33, Name = "Dunston, Gateshead", CountryId = 1 },
            new BirthPlace { Id = 34, Name = "Redruth, Cornwall, Gateshead", CountryId = 1 },
            new BirthPlace { Id = 35, Name = "Phoenix, Arizona", CountryId = 1 },
            new BirthPlace { Id = 36, Name = "Ealing, Middlesex", CountryId = 1 },
            new BirthPlace { Id = 37, Name = "Bouth, Lancashire", CountryId = 1 },
            new BirthPlace { Id = 38, Name = "Palo Alto, California", CountryId = 1 },
            new BirthPlace { Id = 39, Name = "Aberdeen, Washington", CountryId = 1 },
            new BirthPlace { Id = 40, Name = "Compton, California", CountryId = 1 },
            new BirthPlace { Id = 41, Name = "Warren, Ohio", CountryId = 1 },
            new BirthPlace { Id = 42, Name = "Bexleyheath, Kent", CountryId = 1 },
            new BirthPlace { Id = 43, Name = "Newton, North Carolina", CountryId = 1 },
            new BirthPlace { Id = 44, Name = "Dublin, Ireland", CountryId = 1 },
            new BirthPlace { Id = 45, Name = "Barking, Essex", CountryId = 1 },
            new BirthPlace { Id = 46, Name = "Chinnor, Oxfordshire", CountryId = 1 },
            new BirthPlace { Id = 47, Name = "Artane, Dublin", CountryId = 1 },                
        };
    }

    public static List<Studio> GetStudioDefaultData()
    {
        return new List<Studio>()
        {
            new Studio { Id = 1, Name = "Island Studios London, Sound Techniques London" },
            new Studio { Id = 2, Name = "914 Sound Studios, Blauvelt, New York" }
        };
    }
}