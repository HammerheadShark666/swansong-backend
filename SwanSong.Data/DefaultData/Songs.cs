﻿using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData
{
    public class Songs
    {
        public static List<Song> GetSongDefaultData()
        {
            return new List<Song>()
            {
                //Led Zeppelin 1
                new Song { Id = 1, Title = "Good Times Bad Times", Length = "2:46" },
                new Song { Id = 2, Title = "Babe I'm Gonna Leave You", Length = "6:42" },
                new Song { Id = 3, Title = "You Shook Me", Length = "6:28" },
                new Song { Id = 4, Title = "Dazed and Confused", Length = "6:28" },
                new Song { Id = 5, Title = "Your Time Is Gonna Come", Length = "4:34" },
                new Song { Id = 6, Title = "Black Mountain Side", Length = "2:12" },
                new Song { Id = 7, Title = "Communication Breakdown", Length = "2:30" },
                new Song { Id = 8, Title = "I Can't Quit You Baby", Length = "4:42" },
                new Song { Id = 9, Title = "How Many More Times", Length = "8:27" },

                //Led Zeppelin 2
                new Song { Id = 40, Title = "Whole Lotta Love", Length = "5:38" },
                new Song { Id = 41, Title = "What Is and What Should Never Be", Length = "4:33" },
                new Song { Id = 42, Title = "Thank You", Length = "4:21" },
                new Song { Id = 43, Title = "The Lemon Song", Length = "6:20" },
                new Song { Id = 44, Title = "Heartbreaker", Length = " 4:14" },
                new Song { Id = 45, Title = "Living Loving Maid(She's Just a Woman)", Length = "2:39" },
                new Song { Id = 46, Title = "Ramble On", Length = "4:34" },

                //Led Zeppelin 3
                new Song { Id = 55, Title = "Immigrant Song", Length = "2:26" },
                new Song { Id = 56, Title = "Friends", Length = "3:55" },
                new Song { Id = 57, Title = "Celebration Day", Length = "3:29" },
                new Song { Id = 58, Title = "Since I've Been Loving You", Length = "7:25" },
                new Song { Id = 59, Title = "Out on the Tiles", Length = "4:04" },
                new Song { Id = 60, Title = "Gallows Pole", Length = "4:58" },
                new Song { Id = 61, Title = "Tangerine", Length = "3:12" },
                new Song { Id = 62, Title = "That's the Way", Length = "5:38" },
                new Song { Id = 63, Title = "Bron-Y-Aur Stomp", Length = "4:20" },
                new Song { Id = 64, Title = "Hats Off to (Roy) Harper", Length = "3:41" },

                //Led Zeppelin 4
                new Song { Id = 65, Title = "Black Dog", Length = "4:55" },
                new Song { Id = 66, Title = "Rock and Roll", Length = "3:40" },
                new Song { Id = 67, Title = "The Battle of Evermore", Length = "5:51" },
                new Song { Id = 68, Title = "Stairway to Heaven", Length = "7:55" },
                new Song { Id = 69, Title = "Misty Mountain Hop", Length = "4:39" },
                new Song { Id = 70, Title = "Four Sticks", Length = "4:49" },
                new Song { Id = 71, Title = "Going to California", Length = "3:36" },
                new Song { Id = 72, Title = "When the Levee Breaks", Length = "7:08" },

                //Houses of the Holy
                new Song { Id = 47, Title = "The Song Remains the Same", Length = "5:32" },
                new Song { Id = 48, Title = "The Rain Song", Length = "7:39" },
                new Song { Id = 49, Title = "Over the Hills and Far Away", Length = "4:50" },
                new Song { Id = 50, Title = "The Crunge", Length = "3:17" },
                new Song { Id = 51, Title = "Dancing Days", Length = "3:43" },
                new Song { Id = 52, Title = "D'yer Mak'er", Length = "4:23" },
                new Song { Id = 53, Title = "No Quarter", Length = "7:00" },
                new Song { Id = 54, Title = "The Ocean", Length = "4:31" },

                //Physical Graffiti
                new Song { Id = 73, Title = "Custard Pie", Length = "4:13" },
                new Song { Id = 74, Title = "The Rover", Length = "5:36" },
                new Song { Id = 75, Title = "In My Time of Dying", Length = "11:04" },
                new Song { Id = 76, Title = "Houses of the Holy", Length = "4:01" },
                new Song { Id = 77, Title = "Trampled Under Foot", Length = "5:35" },
                new Song { Id = 78, Title = "Kashmir", Length = "8:37" },
                new Song { Id = 79, Title = "In the Light", Length = "8:44" },
                new Song { Id = 80, Title = "Bron-Yr-Aur", Length = "2:06" },
                new Song { Id = 81, Title = "Down by the Seaside", Length = "5:14" },
                new Song { Id = 82, Title = "Ten Years Gone", Length = "6:31" },
                new Song { Id = 83, Title = "Night Flight", Length = "3:36" },
                new Song { Id = 84, Title = "The Wanton Song", Length = "4:06" },
                new Song { Id = 85, Title = "Boogie with Stu", Length = "3:51" },
                new Song { Id = 86, Title = "Black Country Woman", Length = "4:24" },
                new Song { Id = 87, Title = "Sick Again", Length = "4:43" },        
                
                //The Song Remains The Same
                new Song { Id = 88, Title = "Rock and Roll", Length = "4:03" },
                new Song { Id = 89, Title = "Celebration Day", Length = "3:49" },
                new Song { Id = 90, Title = "The Song Remains the Same", Length = "6:00" },
                new Song { Id = 91, Title = "The Rain Song", Length = "8:24" },
                new Song { Id = 92, Title = "Dazed and Confused", Length = "26:53" },
                new Song { Id = 93, Title = "No Quarter", Length = "12:30" },
                new Song { Id = 94, Title = "Stairway to Heaven", Length = "10:58" },
                new Song { Id = 95, Title = "Moby Dick", Length = "12:47" },
                new Song { Id = 96, Title = "Whole Lotta Love", Length = "14:24" }, 

                //Presence
                new Song { Id = 97, Title = "Achilles Last Stand", Length = "10:26" },
                new Song { Id = 98, Title = "For Your Life", Length = "6:21" },
                new Song { Id = 99, Title = "Royal Orleans", Length = "2:58" },
                new Song { Id = 101, Title = "Nobody's Fault but Mine", Length = "6:27" },
                new Song { Id = 102, Title = "Candy Store Rock", Length = "4:10" },
                new Song { Id = 103, Title = "Hots On for Nowhere", Length = "4:42" },
                new Song { Id = 104, Title = "Tea for One", Length = "9:27" },

                //In Through The OutDoor
                new Song { Id = 105, Title = "In the Evening", Length = "6:48" },
                new Song { Id = 106, Title = "South Bound Saurez", Length = "4:11" },
                new Song { Id = 107, Title = "Fool in the Rain", Length = "6:08" },
                new Song { Id = 108, Title = "Hot Dog", Length = "3:15" },
                new Song { Id = 109, Title = "Carouselambra", Length = "10:28" },
                new Song { Id = 110, Title = "All My Love", Length = "5:51" },
                new Song { Id = 111, Title = "I'm Gonna Crawl", Length = "5:28" },
                 
                //The North Star Grassman and the Ravens
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

                //Nevermind
                new Song { Id = 21, Title = "Smells Like Teen Spirit", Length = "5:01" },
                new Song { Id = 22, Title = "In Bloom", Length = "4:14" },
                new Song { Id = 23, Title = "Come as You Are", Length = "3:39" },
                new Song { Id = 24, Title = "Breed", Length = "3:03" },
                new Song { Id = 25, Title = "Lithium", Length = "4:17" },
                new Song { Id = 26, Title = "Polly", Length = "2:57" },
                new Song { Id = 27, Title = "Territorial Pissings", Length = "2:22" },
                new Song { Id = 28, Title = "Drain You", Length = "3:43" },
                new Song { Id = 29, Title = "Lounge Act", Length = "2:36" },
                new Song { Id = 30, Title = "Stay Away", Length = "3:32" },
                new Song { Id = 31, Title = "On a Plain", Length = "3:16" },
                new Song { Id = 32, Title = "Something in the Way", Length = "3:52" },
                new Song { Id = 33, Title = "Endless, Nameless", Length = "6:43" },

                //Electric Ladyland
                new Song { Id = 112, Title = "...And the Gods Made Love", Length = "1:19" },
                new Song { Id = 113, Title = "Have You Ever Been (To Electric Ladyland)", Length = "2:08" },
                new Song { Id = 114, Title = "Crosstown Traffic", Length = "2:25" },
                new Song { Id = 115, Title = "Voodoo Chile", Length = "14:50" },
                new Song { Id = 116, Title = "Little Miss Strange", Length = "2:47" },
                new Song { Id = 117, Title = "Long Hot Summer Night", Length = "3:21" },
                new Song { Id = 118, Title = "Come On (Part 1)", Length = "4:04" },
                new Song { Id = 119, Title = "Gypsy Eyes", Length = "3:38" },
                new Song { Id = 120, Title = "Burning of the Midnight Lamp", Length = "3:33" },
                new Song { Id = 121, Title = "Rainy Day, Dream Away", Length = "3:39" },
                new Song { Id = 122, Title = "1983... (A Merman I Should Turn to Be)", Length = "13:25" },
                new Song { Id = 123, Title = "Moon, Turn the Tides....Gently Gently Away", Length = "0:58" },
                new Song { Id = 124, Title = "Still Raining, Still Dreaming", Length = "4:19" },
                new Song { Id = 125, Title = "House Burning Down", Length = "4:26" },
                new Song { Id = 126, Title = "All Along the Watchtower", Length = "3:54" },
                new Song { Id = 127, Title = "Voodoo Child (Slight Return)", Length = "5:06" },

                //Rumours
                new Song { Id = 128, Title = "Second Hand News", Length = "2:43" },
                new Song { Id = 129, Title = "Dreams", Length = "4:14" },
                new Song { Id = 130, Title = "Never Going Back Again", Length = "2:02" },
                new Song { Id = 131, Title = "Don't Stop", Length = "3:11" },
                new Song { Id = 132, Title = "Go Your Own Way", Length = "3:38" },
                new Song { Id = 133, Title = "Songbird", Length = "3:20" },
                new Song { Id = 134, Title = "The Chain", Length = "4:28" },
                new Song { Id = 135, Title = "You Make Loving Fun", Length = "3:31" },
                new Song { Id = 136, Title = "I Don't Want to Know", Length = "3:11" },
                new Song { Id = 137, Title = "Oh Daddy", Length = "3:54" },
                new Song { Id = 138, Title = "Gold Dust Woman", Length = "4:51" },

                //The River                
                new Song { Id = 139, Title = "The Ties That Bind", Length = "3:33" },
                new Song { Id = 140, Title = "Sherry Darling", Length = "4:02" },
                new Song { Id = 141, Title = "Jackson Cage", Length = "3:04" },
                new Song { Id = 142, Title = "Two Hearts", Length = "2:42" },
                new Song { Id = 143, Title = "Independence Day", Length = "4:46" },
                new Song { Id = 144, Title = "Hungry Heart", Length = "3:19" },
                new Song { Id = 145, Title = "Out in the Street", Length = "4:17" },
                new Song { Id = 146, Title = "Crush on You", Length = "3:10" },
                new Song { Id = 147, Title = "You Can Look (But You Better Not Touch)", Length = "2:36" },
                new Song { Id = 148, Title = "I Wanna Marry You", Length = "3:26" },
                new Song { Id = 149, Title = "The River", Length = "4:59" },
                new Song { Id = 150, Title = "Point Blank", Length = "6:05" },
                new Song { Id = 151, Title = "Cadillac Ranch", Length = "3:02" },
                new Song { Id = 152, Title = "I'm a Rocker", Length = "3:34" },
                new Song { Id = 153, Title = "Fade Away", Length = "4:40" },
                new Song { Id = 154, Title = "Stolen Car", Length = "3:53" },
                new Song { Id = 155, Title = "Ramrod", Length = "4:04" },
                new Song { Id = 156, Title = "The Price You Pay", Length = "5:27" },
                new Song { Id = 157, Title = "Drive All Night", Length = "8:26" },
                new Song { Id = 158, Title = "Wreck on the Highway", Length = "3:53" }, 
            
                //Darkness on the Edge of Town
                new Song { Id = 166, Title = "Badlands", Length = "4:03" },
                new Song { Id = 167, Title = "Adam Raised a Cain", Length = "4:32" },
                new Song { Id = 168, Title = "Something in the Night", Length = "5:11" },
                new Song { Id = 169, Title = "Candy's Room", Length = "2:51" },
                new Song { Id = 170, Title = "Racing in the Street", Length = "6:53" },
                new Song { Id = 171, Title = "The Promised Land", Length = "4:33" },
                new Song { Id = 172, Title = "Factory", Length = "2:17" },
                new Song { Id = 173, Title = "Streets of Fire", Length = "4:09" },
                new Song { Id = 174, Title = "Prove It All Night", Length = "3:56" },
                new Song { Id = 175, Title = "Darkness on the Edge of Town", Length = "4:30" },

                //Bark At The Moon
                new Song { Id = 176, Title = "Rock 'n' Roll Rebel", Length = "4:03" },
                new Song { Id = 177, Title = "Bark at the Moon", Length = "4:32" },
                new Song { Id = 178, Title = "You're No Different", Length = "5:11" },
                new Song { Id = 179, Title = "Now You See It (Now You Don't)", Length = "2:51" },
                new Song { Id = 180, Title = "Forever", Length = "6:53" },
                new Song { Id = 181, Title = "So Tired", Length = "4:33" },
                new Song { Id = 182, Title = "Waiting for Darkness", Length = "2:17" },
                new Song { Id = 183, Title = "Spiders", Length = "4:09" },                

                //The Raven
                new Song { Id = 184, Title = "Longships", Length = "1:10" },
                new Song { Id = 185, Title = "The Raven", Length = "5:13" },
                new Song { Id = 186, Title = "Dead Loss Angeles", Length = "2:24" },
                new Song { Id = 187, Title = "Ice", Length = "3:26" },
                new Song { Id = 188, Title = "Baroque Bordello", Length = "3:50" },
                new Song { Id = 189, Title = "Nuclear Device(The Wizard of Aus)", Length = "3:32" },
                new Song { Id = 190, Title = "Shah Shah a Go Go", Length = "4:50" },
                new Song { Id = 191, Title = "Don't Bring Harry", Length = "4:09" },
                new Song { Id = 192, Title = "Duchess", Length = "2:30" },
                new Song { Id = 193, Title = "Meninblack", Length = "4:48" },
                new Song { Id = 194, Title = "Genetix", Length = "5:16" },

                //Nebraska
                new Song { Id = 195, Title = "Nebraska", Length = "4:32" },
                new Song { Id = 196, Title = "Atlantic City", Length = "4:00" },
                new Song { Id = 197, Title = "Mansion on the Hill", Length = "4:08" },
                new Song { Id = 198, Title = "Johnny 99", Length = "3:44" },
                new Song { Id = 199, Title = "Highway Patrolman", Length = "5:40" },
                new Song { Id = 200, Title = "State Trooper", Length = "3:17" },                                
                new Song { Id = 201, Title = "Used Cars", Length = "3:11" },
                new Song { Id = 202, Title = "Open All Night", Length = "2:58" },
                new Song { Id = 203, Title = "My Father's House", Length = "5:07" },
                new Song { Id = 204, Title = "Reason to Believe", Length = "4:11" },
                 
                //Iron Fist
                new Song { Id = 205, Title = "Iron Fist", Length = "2:55" },
                new Song { Id = 206, Title = "Heart of Stone", Length = "3:04" },
                new Song { Id = 207, Title = "I'm the Doctor", Length = "2:43" },
                new Song { Id = 208, Title = "Go to Hell", Length = "3:10" },
                new Song { Id = 209, Title = "Loser", Length = "3:57" },
                new Song { Id = 210, Title = "Sex & Outrage", Length = "2:10" },
                new Song { Id = 211, Title = "America", Length = "3:38" },
                new Song { Id = 212, Title = "Shut It Down", Length = "2:41" },
                new Song { Id = 213, Title = "Speedfreak", Length = "3:28" },
                new Song { Id = 214, Title = "(Don't Let 'Em) Grind Ya Down", Length = "3:08" },
                new Song { Id = 215, Title = "(Don't Need) Religion", Length = "2:43" },
                new Song { Id = 216, Title = "Bang to Rights", Length = "2:43" },
                 
                //Stormbringer
                new Song { Id = 217, Title = "Stormbringer", Length = "4:03" },
                new Song { Id = 218, Title = "Love Don't Mean a Thing", Length = "4:23" },
                new Song { Id = 219, Title = "Holy Man", Length = "4:28" },
                new Song { Id = 220, Title = "Hold On", Length = "5:05" },
                new Song { Id = 221, Title = "Lady Double Dealer", Length = "3:19" },
                new Song { Id = 222, Title = "You Can't Do It Right (With the One You Love)", Length = "3:24" },
                new Song { Id = 223, Title = "High Ball Shooter", Length = "4:26" },
                new Song { Id = 224, Title = "The Gypsy", Length = "4:05" },
                new Song { Id = 225, Title = "Soldier of Fortune", Length = "3:14" }, 
 
                //Nashville Skyline
                new Song { Id = 226, Title = "Girl from the North Country", Length = "3:41" },                                 
                new Song { Id = 227, Title = "Nashville Skyline Rag", Length = "3:12" },
                new Song { Id = 228, Title = "To Be Alone with You", Length = "2:07" },
                new Song { Id = 229, Title = "I Threw It All Away", Length = "2:23" },
                new Song { Id = 230, Title = "Peggy Day", Length = "2:01" },   
                new Song { Id = 231, Title = "Lay Lady Lay", Length = "3:18" },
                new Song { Id = 232, Title = "One More Night", Length = "2:23" },
                new Song { Id = 233, Title = "Tell Me That It Isn't True", Length = "2:41" },
                new Song { Id = 234, Title = "Country Pie", Length = "1:37" },
                new Song { Id = 235, Title = "Tonight I'll Be Staying Here with You", Length = "3:23" },
                 
                //Born in the U.S.A.
                new Song { Id = 236, Title = "Born in the U.S.A.", Length = "4:38" },
                new Song { Id = 237, Title = "Cover Me", Length = "3:29" },
                new Song { Id = 238, Title = "Darlington County", Length = "4:48" },
                new Song { Id = 239, Title = "Working on the Highway", Length = "3:13" },
                new Song { Id = 240, Title = "Downbound Train", Length = "3:35" },
                new Song { Id = 241, Title = "I'm on Fire", Length = "2:40" },
                new Song { Id = 242, Title = "No Surrender", Length = "4:01" },
                new Song { Id = 243, Title = "Bobby Jean", Length = "3:48" },
                new Song { Id = 244, Title = "I'm Goin' Down", Length = "3:30" },
                new Song { Id = 245, Title = "Glory Days", Length = "4:15" },
                new Song { Id = 246, Title = "Dancing in the Dark", Length = "4:04" },
                new Song { Id = 247, Title = "My Hometown", Length = "4:34" },         

                 //Born To Run
                new Song { Id = 248, Title = "Thunder Road", Length = "4:49" },
                new Song { Id = 249, Title = "Tenth Avenue Freeze-Out", Length = "3:11" },
                new Song { Id = 250, Title = "Night", Length = "3:00" },
                new Song { Id = 251, Title = "Backstreets", Length = "6:30" },
                new Song { Id = 252, Title = "Born to Run", Length = "4:31" },
                new Song { Id = 253, Title = "She's the One", Length = "4:30" },
                new Song { Id = 254, Title = "Meeting Across the River", Length = "3:18" },
                new Song { Id = 255, Title = "Jungleland", Length = "9:34" },
            };
        }
    }
}
