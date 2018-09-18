using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerliSpotify
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("song1", "artist1", 120);
            Song song2 = new Song("song2", "artist2", 130);
            Song song3 = new Song("song3", "artist3", 140);
            Song song4 = new Song("song4", "artist4", 150);
            Song song5 = new Song("song5", "artist5", 160);
            Song song6 = new Song("song6", "artist6", 180);
            Song song7 = new Song("song7", "artist7", 180);
            Song song8 = new Song("song8", "artist8", 180);
            Song song9 = new Song("song9", "artist9", 180);


            Playlist rockPlayList = new RockPlayList("Rock Play List");
            Playlist popPlayList = new PopPlayList("Pop Play List");

            User user2 = new FreeUser("user2");
            User user1 = new PayedUser("user1");



            rockPlayList.AddSong(song1);
            rockPlayList.AddSong(song2);
            rockPlayList.AddSong(song3);
            rockPlayList.AddSong(song4);

            popPlayList.AddSong(song5);
            popPlayList.AddSong(song6);

            user1.SetPlaylist(rockPlayList);
            user1.SetPlaylist(popPlayList);

            user2.SetPlaylist(rockPlayList);

            Console.WriteLine("----------------------------------");
            popPlayList.AddSong(song7);
            rockPlayList.AddSong(song8);

            Console.WriteLine("-----------------RockPlayList-----------------");
            rockPlayList.UserToString();
            Console.WriteLine("-----------------PopPlayList-----------------");
            popPlayList.UserToString();


            Console.WriteLine("-----------------RockPlayList-----------------");
            rockPlayList.ToString();

            Console.WriteLine("-----------------PopPlayList-----------------");
            popPlayList.ToString();


            rockPlayList.AddSong(song9);







            Console.ReadKey();
        }
    }
}
