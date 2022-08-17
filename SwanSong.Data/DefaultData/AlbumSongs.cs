﻿using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData
{
    public class AlbumSongs
    {
        public static List<AlbumSong> GetAlbumSongDefaultData()
        {
            return new List<AlbumSong>()
            {
                //Led Zeppelin 1
                new AlbumSong { Id = 1, AlbumId = 1, SongId = 1, Order = 1, Side = 1 },
                new AlbumSong { Id = 2, AlbumId = 1, SongId = 2, Order = 2, Side = 1 },
                new AlbumSong { Id = 3, AlbumId = 1, SongId = 3, Order = 3, Side = 1 },
                new AlbumSong { Id = 4, AlbumId = 1, SongId = 4, Order = 4, Side = 1 },
                new AlbumSong { Id = 5, AlbumId = 1, SongId = 5, Order = 5, Side = 2 },
                new AlbumSong { Id = 6, AlbumId = 1, SongId = 6, Order = 6, Side = 2 },
                new AlbumSong { Id = 7, AlbumId = 1, SongId = 7, Order = 7, Side = 2 },
                new AlbumSong { Id = 8, AlbumId = 1, SongId = 8, Order = 8, Side = 2 },
                new AlbumSong { Id = 9, AlbumId = 1, SongId = 9, Order = 9, Side = 2 },

                //The North Star Grassman and the Ravens
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
                               
                //Nevermind
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

                //Led Zeppelin 2
                new AlbumSong { Id = 43, AlbumId = 3, SongId = 40, Order = 1, Side = 1 },
                new AlbumSong { Id = 44, AlbumId = 3, SongId = 41, Order = 2, Side = 1 },
                new AlbumSong { Id = 45, AlbumId = 3, SongId = 42, Order = 4, Side = 1 },
                new AlbumSong { Id = 46, AlbumId = 3, SongId = 43, Order = 3, Side = 1 },
                new AlbumSong { Id = 47, AlbumId = 3, SongId = 44, Order = 1, Side = 2 },
                new AlbumSong { Id = 48, AlbumId = 3, SongId = 45, Order = 2, Side = 2 },
                new AlbumSong { Id = 49, AlbumId = 3, SongId = 46, Order = 3, Side = 2 },                 

                //Houses of the Holy
                new AlbumSong { Id = 50, AlbumId = 6, SongId = 47, Order = 1, Side = 1 },
                new AlbumSong { Id = 51, AlbumId = 6, SongId = 48, Order = 2, Side = 1 },
                new AlbumSong { Id = 52, AlbumId = 6, SongId = 49, Order = 3, Side = 1 },
                new AlbumSong { Id = 53, AlbumId = 6, SongId = 50, Order = 4, Side = 1 },
                new AlbumSong { Id = 54, AlbumId = 6, SongId = 51, Order = 1, Side = 2 },
                new AlbumSong { Id = 55, AlbumId = 6, SongId = 52, Order = 2, Side = 2 },
                new AlbumSong { Id = 56, AlbumId = 6, SongId = 53, Order = 3, Side = 2 },
                new AlbumSong { Id = 57, AlbumId = 6, SongId = 54, Order = 4, Side = 2 },

                //Led Zeppelin 3
                new AlbumSong { Id = 58, AlbumId = 4, SongId = 55, Order = 1, Side = 1 },
                new AlbumSong { Id = 59, AlbumId = 4, SongId = 56, Order = 2, Side = 1 },
                new AlbumSong { Id = 60, AlbumId = 4, SongId = 57, Order = 3, Side = 1 },
                new AlbumSong { Id = 61, AlbumId = 4, SongId = 58, Order = 4, Side = 1 },
                new AlbumSong { Id = 62, AlbumId = 4, SongId = 59, Order = 5, Side = 1 },
                new AlbumSong { Id = 63, AlbumId = 4, SongId = 60, Order = 1, Side = 2 },
                new AlbumSong { Id = 64, AlbumId = 4, SongId = 61, Order = 2, Side = 2 },
                new AlbumSong { Id = 65, AlbumId = 4, SongId = 62, Order = 3, Side = 2 },
                new AlbumSong { Id = 66, AlbumId = 4, SongId = 63, Order = 4, Side = 2 },
                new AlbumSong { Id = 67, AlbumId = 4, SongId = 64, Order = 5, Side = 2 },

                //Led Zeppelin 4
                new AlbumSong { Id = 68, AlbumId = 5, SongId = 65, Order = 1, Side = 1 },
                new AlbumSong { Id = 69, AlbumId = 5, SongId = 66, Order = 2, Side = 1 },
                new AlbumSong { Id = 70, AlbumId = 5, SongId = 67, Order = 3, Side = 1 },
                new AlbumSong { Id = 71, AlbumId = 5, SongId = 68, Order = 4, Side = 1 },
                new AlbumSong { Id = 72, AlbumId = 5, SongId = 69, Order = 2, Side = 2 },
                new AlbumSong { Id = 73, AlbumId = 5, SongId = 70, Order = 3, Side = 2 },
                new AlbumSong { Id = 74, AlbumId = 5, SongId = 71, Order = 3, Side = 2 },
                new AlbumSong { Id = 75, AlbumId = 5, SongId = 72, Order = 4, Side = 2 },
                 
                //Physical Graffiti
                new AlbumSong { Id = 76, AlbumId = 7, SongId = 73, Order = 1, Side = 1 },
                new AlbumSong { Id = 77, AlbumId = 7, SongId = 74, Order = 2, Side = 1 },
                new AlbumSong { Id = 78, AlbumId = 7, SongId = 75, Order = 3, Side = 1 },
                new AlbumSong { Id = 79, AlbumId = 7, SongId = 76, Order = 1, Side = 2 },
                new AlbumSong { Id = 80, AlbumId = 7, SongId = 77, Order = 2, Side = 2 },
                new AlbumSong { Id = 81, AlbumId = 7, SongId = 78, Order = 3, Side = 2 },
                new AlbumSong { Id = 82, AlbumId = 7, SongId = 79, Order = 1, Side = 3 },
                new AlbumSong { Id = 83, AlbumId = 7, SongId = 80, Order = 2, Side = 3 },
                new AlbumSong { Id = 84, AlbumId = 7, SongId = 81, Order = 3, Side = 3 },
                new AlbumSong { Id = 85, AlbumId = 7, SongId = 82, Order = 4, Side = 3 },
                new AlbumSong { Id = 86, AlbumId = 7, SongId = 83, Order = 1, Side = 4 },
                new AlbumSong { Id = 87, AlbumId = 7, SongId = 84, Order = 2, Side = 4 },
                new AlbumSong { Id = 88, AlbumId = 7, SongId = 85, Order = 3, Side = 4 },
                new AlbumSong { Id = 89, AlbumId = 7, SongId = 86, Order = 4, Side = 4 },
                new AlbumSong { Id = 90, AlbumId = 7, SongId = 87, Order = 5, Side = 4 }, 

                //The Song Remains the Same                 
                new AlbumSong { Id = 91, AlbumId = 8, SongId = 88, Order = 1, Side = 1 },
                new AlbumSong { Id = 92, AlbumId = 8, SongId = 89, Order = 2, Side = 1 },
                new AlbumSong { Id = 93, AlbumId = 8, SongId = 90, Order = 3, Side = 1 },
                new AlbumSong { Id = 94, AlbumId = 8, SongId = 91, Order = 4, Side = 1 },
                new AlbumSong { Id = 95, AlbumId = 8, SongId = 92, Order = 1, Side = 2 },
                new AlbumSong { Id = 96, AlbumId = 8, SongId = 93, Order = 1, Side = 3 },
                new AlbumSong { Id = 97, AlbumId = 8, SongId = 94, Order = 2, Side = 3 },
                new AlbumSong { Id = 98, AlbumId = 8, SongId = 95, Order = 1, Side = 4 },
                new AlbumSong { Id = 99, AlbumId = 8, SongId = 96, Order = 2, Side = 4 },

                //Presence                
                new AlbumSong { Id = 100, AlbumId = 9, SongId = 97, Order = 1, Side = 1 },
                new AlbumSong { Id = 102, AlbumId = 9, SongId = 98, Order = 2, Side = 1 },
                new AlbumSong { Id = 103, AlbumId = 9, SongId = 99, Order = 3, Side = 1 },
                new AlbumSong { Id = 104, AlbumId = 9, SongId = 101, Order = 1, Side = 2 },
                new AlbumSong { Id = 105, AlbumId = 9, SongId = 102, Order = 2, Side = 2 },
                new AlbumSong { Id = 106, AlbumId = 9, SongId = 103, Order = 3, Side = 2 },
                new AlbumSong { Id = 107, AlbumId = 9, SongId = 104, Order = 4, Side = 2 },  

                //In Through The OutDoor        
                new AlbumSong { Id = 108, AlbumId = 10, SongId = 105, Order = 1, Side = 1 },
                new AlbumSong { Id = 109, AlbumId = 10, SongId = 106, Order = 2, Side = 1 },
                new AlbumSong { Id = 110, AlbumId = 10, SongId = 107, Order = 3, Side = 1 },
                new AlbumSong { Id = 111, AlbumId = 10, SongId = 108, Order = 4, Side = 1 },
                new AlbumSong { Id = 112, AlbumId = 10, SongId = 109, Order = 1, Side = 2 },
                new AlbumSong { Id = 113, AlbumId = 10, SongId = 110, Order = 2, Side = 2 },
                new AlbumSong { Id = 114, AlbumId = 10, SongId = 111, Order = 3, Side = 2 }, 
                
                //Electric Ladyland
                new AlbumSong { Id = 115, AlbumId = 11, SongId = 112, Order = 1, Side = 1 },
                new AlbumSong { Id = 116, AlbumId = 11, SongId = 113, Order = 2, Side = 1 },
                new AlbumSong { Id = 117, AlbumId = 11, SongId = 114, Order = 3, Side = 1 },
                new AlbumSong { Id = 118, AlbumId = 11, SongId = 115, Order = 4, Side = 1 },
                new AlbumSong { Id = 119, AlbumId = 11, SongId = 116, Order = 1, Side = 2 },
                new AlbumSong { Id = 120, AlbumId = 11, SongId = 117, Order = 2, Side = 2 },
                new AlbumSong { Id = 121, AlbumId = 11, SongId = 118, Order = 3, Side = 2 },
                new AlbumSong { Id = 122, AlbumId = 11, SongId = 119, Order = 4, Side = 2 },
                new AlbumSong { Id = 123, AlbumId = 11, SongId = 120, Order = 5, Side = 2 },
                new AlbumSong { Id = 124, AlbumId = 11, SongId = 121, Order = 3, Side = 3 },
                new AlbumSong { Id = 125, AlbumId = 11, SongId = 122, Order = 4, Side = 3 },
                new AlbumSong { Id = 126, AlbumId = 11, SongId = 123, Order = 1, Side = 3 },
                new AlbumSong { Id = 127, AlbumId = 11, SongId = 124, Order = 1, Side = 4 },
                new AlbumSong { Id = 128, AlbumId = 11, SongId = 125, Order = 2, Side = 4 },
                new AlbumSong { Id = 129, AlbumId = 11, SongId = 126, Order = 3, Side = 4 },
                new AlbumSong { Id = 130, AlbumId = 11, SongId = 127, Order = 4, Side = 4 },  
                
                //Rumours
                new AlbumSong { Id = 131, AlbumId = 12, SongId = 128, Order = 1, Side = 1 },
                new AlbumSong { Id = 132, AlbumId = 12, SongId = 129, Order = 2, Side = 1 },
                new AlbumSong { Id = 133, AlbumId = 12, SongId = 130, Order = 3, Side = 1 },
                new AlbumSong { Id = 134, AlbumId = 12, SongId = 131, Order = 4, Side = 1 },
                new AlbumSong { Id = 135, AlbumId = 12, SongId = 132, Order = 5, Side = 1 },
                new AlbumSong { Id = 136, AlbumId = 12, SongId = 133, Order = 6, Side = 1 },
                new AlbumSong { Id = 137, AlbumId = 12, SongId = 134, Order = 1, Side = 2 },
                new AlbumSong { Id = 138, AlbumId = 12, SongId = 135, Order = 2, Side = 2 },
                new AlbumSong { Id = 139, AlbumId = 12, SongId = 136, Order = 3, Side = 2 },
                new AlbumSong { Id = 140, AlbumId = 12, SongId = 137, Order = 4, Side = 2 },
                new AlbumSong { Id = 141, AlbumId = 12, SongId = 138, Order = 5, Side = 2 },

                //The River                 
                new AlbumSong { Id = 142, AlbumId = 13, SongId = 139, Order = 1, Side = 1 },
                new AlbumSong { Id = 143, AlbumId = 13, SongId = 140, Order = 2, Side = 1 },
                new AlbumSong { Id = 144, AlbumId = 13, SongId = 141, Order = 3, Side = 1 },
                new AlbumSong { Id = 145, AlbumId = 13, SongId = 142, Order = 4, Side = 1 },
                new AlbumSong { Id = 146, AlbumId = 13, SongId = 143, Order = 5, Side = 1 },                                                                  
                new AlbumSong { Id = 147, AlbumId = 13, SongId = 144, Order = 1, Side = 2 },
                new AlbumSong { Id = 148, AlbumId = 13, SongId = 145, Order = 2, Side = 2 },
                new AlbumSong { Id = 149, AlbumId = 13, SongId = 146, Order = 3, Side = 2 },
                new AlbumSong { Id = 150, AlbumId = 13, SongId = 147, Order = 4, Side = 2 },
                new AlbumSong { Id = 151, AlbumId = 13, SongId = 148, Order = 5, Side = 2 },
                new AlbumSong { Id = 152, AlbumId = 13, SongId = 149, Order = 6, Side = 2 },                                                     
                new AlbumSong { Id = 153, AlbumId = 13, SongId = 150, Order = 1, Side = 3 },
                new AlbumSong { Id = 154, AlbumId = 13, SongId = 151, Order = 2, Side = 3 },
                new AlbumSong { Id = 155, AlbumId = 13, SongId = 152, Order = 3, Side = 3 },
                new AlbumSong { Id = 156, AlbumId = 13, SongId = 153, Order = 4, Side = 3 },
                new AlbumSong { Id = 157, AlbumId = 13, SongId = 154, Order = 5, Side = 3 },                                                     
                new AlbumSong { Id = 158, AlbumId = 13, SongId = 155, Order = 1, Side = 4 },
                new AlbumSong { Id = 159, AlbumId = 13, SongId = 156, Order = 2, Side = 4 },
                new AlbumSong { Id = 160, AlbumId = 13, SongId = 157, Order = 3, Side = 4 },
                new AlbumSong { Id = 161, AlbumId = 13, SongId = 158, Order = 4, Side = 4 },
                  
                //Darkness on the Edge of Town
                new AlbumSong { Id = 168, AlbumId = 15, SongId = 166, Order = 1, Side = 1 },
                new AlbumSong { Id = 169, AlbumId = 15, SongId = 167, Order = 2, Side = 1 },
                new AlbumSong { Id = 170, AlbumId = 15, SongId = 168, Order = 3, Side = 1 },
                new AlbumSong { Id = 171, AlbumId = 15, SongId = 169, Order = 4, Side = 1 },
                new AlbumSong { Id = 172, AlbumId = 15, SongId = 170, Order = 5, Side = 1 },
                new AlbumSong { Id = 173, AlbumId = 15, SongId = 171, Order = 1, Side = 2 },
                new AlbumSong { Id = 174, AlbumId = 15, SongId = 172, Order = 2, Side = 2 },
                new AlbumSong { Id = 175, AlbumId = 15, SongId = 173, Order = 3, Side = 2 },
                new AlbumSong { Id = 176, AlbumId = 15, SongId = 174, Order = 4, Side = 2 },
                new AlbumSong { Id = 177, AlbumId = 15, SongId = 175, Order = 5, Side = 2 },

                //Bark At The Moon
                new AlbumSong { Id = 178, AlbumId = 16, SongId = 176, Order = 1, Side = 1 },
                new AlbumSong { Id = 179, AlbumId = 16, SongId = 177, Order = 2, Side = 1 },
                new AlbumSong { Id = 180, AlbumId = 16, SongId = 178, Order = 3, Side = 1 },
                new AlbumSong { Id = 181, AlbumId = 16, SongId = 179, Order = 4, Side = 1 },
                new AlbumSong { Id = 182, AlbumId = 16, SongId = 180, Order = 1, Side = 2 },
                new AlbumSong { Id = 183, AlbumId = 16, SongId = 181, Order = 2, Side = 2 },
                new AlbumSong { Id = 184, AlbumId = 16, SongId = 182, Order = 3, Side = 2 },
                new AlbumSong { Id = 185, AlbumId = 16, SongId = 183, Order = 4, Side = 2 }, 
                 
                //The Raven
                new AlbumSong { Id = 186, AlbumId = 17, SongId = 184, Order = 1, Side = 1 },
                new AlbumSong { Id = 187, AlbumId = 17, SongId = 185, Order = 2, Side = 1 },
                new AlbumSong { Id = 188, AlbumId = 17, SongId = 186, Order = 3, Side = 1 },
                new AlbumSong { Id = 189, AlbumId = 17, SongId = 187, Order = 4, Side = 1 },
                new AlbumSong { Id = 190, AlbumId = 17, SongId = 188, Order = 5, Side = 1 },
                new AlbumSong { Id = 191, AlbumId = 17, SongId = 189, Order = 6, Side = 1 },
                new AlbumSong { Id = 192, AlbumId = 17, SongId = 190, Order = 1, Side = 2 },
                new AlbumSong { Id = 193, AlbumId = 17, SongId = 191, Order = 2, Side = 2 },
                new AlbumSong { Id = 194, AlbumId = 17, SongId = 192, Order = 3, Side = 2 },
                new AlbumSong { Id = 195, AlbumId = 17, SongId = 193, Order = 4, Side = 2 },
                new AlbumSong { Id = 196, AlbumId = 17, SongId = 194, Order = 5, Side = 2 },

                //Nebraska
                new AlbumSong { Id = 197, AlbumId = 19, SongId = 195, Order = 1, Side = 1 },
                new AlbumSong { Id = 198, AlbumId = 19, SongId = 196, Order = 2, Side = 1 },
                new AlbumSong { Id = 199, AlbumId = 19, SongId = 197, Order = 3, Side = 1 },
                new AlbumSong { Id = 200, AlbumId = 19, SongId = 198, Order = 4, Side = 1 },
                new AlbumSong { Id = 201, AlbumId = 19, SongId = 199, Order = 5, Side = 1 },
                new AlbumSong { Id = 202, AlbumId = 19, SongId = 200, Order = 6, Side = 1 },
                new AlbumSong { Id = 203, AlbumId = 19, SongId = 201, Order = 1, Side = 2 },
                new AlbumSong { Id = 204, AlbumId = 19, SongId = 202, Order = 2, Side = 2 },
                new AlbumSong { Id = 205, AlbumId = 19, SongId = 203, Order = 3, Side = 2 },
                new AlbumSong { Id = 206, AlbumId = 19, SongId = 204, Order = 4, Side = 2 },

                //Iron Fist
                new AlbumSong { Id = 207, AlbumId = 20, SongId = 205, Order = 1, Side = 1 },
                new AlbumSong { Id = 208, AlbumId = 20, SongId = 206, Order = 2, Side = 1 },
                new AlbumSong { Id = 209, AlbumId = 20, SongId = 207, Order = 3, Side = 1 },
                new AlbumSong { Id = 210, AlbumId = 20, SongId = 208, Order = 4, Side = 1 },
                new AlbumSong { Id = 211, AlbumId = 20, SongId = 209, Order = 5, Side = 1 },
                new AlbumSong { Id = 212, AlbumId = 20, SongId = 210, Order = 6, Side = 1 },
                new AlbumSong { Id = 213, AlbumId = 20, SongId = 211, Order = 1, Side = 2 },
                new AlbumSong { Id = 214, AlbumId = 20, SongId = 212, Order = 2, Side = 2 },
                new AlbumSong { Id = 215, AlbumId = 20, SongId = 213, Order = 3, Side = 2 },
                new AlbumSong { Id = 216, AlbumId = 20, SongId = 214, Order = 4, Side = 2 },
                new AlbumSong { Id = 217, AlbumId = 20, SongId = 215, Order = 5, Side = 2 },
                new AlbumSong { Id = 218, AlbumId = 20, SongId = 216, Order = 6, Side = 2 },

                //Stormbringer
                new AlbumSong { Id = 219, AlbumId = 21, SongId = 217, Order = 1, Side = 1 },
                new AlbumSong { Id = 220, AlbumId = 21, SongId = 218, Order = 2, Side = 1 },
                new AlbumSong { Id = 221, AlbumId = 21, SongId = 219, Order = 3, Side = 1 },
                new AlbumSong { Id = 222, AlbumId = 21, SongId = 220, Order = 4, Side = 1 },
                new AlbumSong { Id = 223, AlbumId = 21, SongId = 221, Order = 1, Side = 2 },
                new AlbumSong { Id = 224, AlbumId = 21, SongId = 222, Order = 2, Side = 2 },
                new AlbumSong { Id = 225, AlbumId = 21, SongId = 223, Order = 3, Side = 2 },
                new AlbumSong { Id = 226, AlbumId = 21, SongId = 224, Order = 4, Side = 2 },
                new AlbumSong { Id = 227, AlbumId = 21, SongId = 225, Order = 5, Side = 2 }, 

                //Nashville Skyline
                new AlbumSong { Id = 228, AlbumId = 22, SongId = 226, Order = 1, Side = 1 },
                new AlbumSong { Id = 229, AlbumId = 22, SongId = 227, Order = 2, Side = 1 }, 
                new AlbumSong { Id = 230, AlbumId = 22, SongId = 228, Order = 3, Side = 1 },
                new AlbumSong { Id = 231, AlbumId = 22, SongId = 229, Order = 4, Side = 1 },
                new AlbumSong { Id = 232, AlbumId = 22, SongId = 230, Order = 5, Side = 1 },
                new AlbumSong { Id = 233, AlbumId = 22, SongId = 231, Order = 1, Side = 2 },
                new AlbumSong { Id = 234, AlbumId = 22, SongId = 232, Order = 2, Side = 2 },
                new AlbumSong { Id = 235, AlbumId = 22, SongId = 233, Order = 3, Side = 2 },
                new AlbumSong { Id = 236, AlbumId = 22, SongId = 234, Order = 4, Side = 2 },
                new AlbumSong { Id = 237, AlbumId = 22, SongId = 235, Order = 5, Side = 2 },

                //Born in the U.S.A.
                new AlbumSong { Id = 238, AlbumId = 23, SongId = 236, Order = 1, Side = 1 },
                new AlbumSong { Id = 239, AlbumId = 23, SongId = 237, Order = 2, Side = 1 },
                new AlbumSong { Id = 240, AlbumId = 23, SongId = 238, Order = 3, Side = 1 },
                new AlbumSong { Id = 241, AlbumId = 23, SongId = 239, Order = 4, Side = 1 },
                new AlbumSong { Id = 242, AlbumId = 23, SongId = 240, Order = 5, Side = 1 },
                new AlbumSong { Id = 243, AlbumId = 23, SongId = 241, Order = 6, Side = 1 },
                new AlbumSong { Id = 244, AlbumId = 23, SongId = 242, Order = 1, Side = 2 },
                new AlbumSong { Id = 245, AlbumId = 23, SongId = 243, Order = 2, Side = 2 },
                new AlbumSong { Id = 246, AlbumId = 23, SongId = 244, Order = 3, Side = 2 },
                new AlbumSong { Id = 247, AlbumId = 23, SongId = 245, Order = 4, Side = 2 },
                new AlbumSong { Id = 248, AlbumId = 23, SongId = 246, Order = 5, Side = 2 },
                new AlbumSong { Id = 249, AlbumId = 23, SongId = 247, Order = 6, Side = 2 },

                //Born To Run
                new AlbumSong { Id = 250, AlbumId = 14, SongId = 248, Order = 1, Side = 1 },
                new AlbumSong { Id = 251, AlbumId = 14, SongId = 249, Order = 2, Side = 1 },
                new AlbumSong { Id = 252, AlbumId = 14, SongId = 250, Order = 3, Side = 1 },
                new AlbumSong { Id = 253, AlbumId = 14, SongId = 251, Order = 4, Side = 1 },
                new AlbumSong { Id = 254, AlbumId = 14, SongId = 252, Order = 1, Side = 2 },
                new AlbumSong { Id = 255, AlbumId = 14, SongId = 253, Order = 2, Side = 2 },
                new AlbumSong { Id = 256, AlbumId = 14, SongId = 254, Order = 3, Side = 2 },
                new AlbumSong { Id = 257, AlbumId = 14, SongId = 255, Order = 4, Side = 2 },
            };
        }
    }
}
