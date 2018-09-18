using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerliSpotify
{
    class Song
    {
        #region variables
        private string songName;
        private string artist;
        private int songLength;

        #endregion
        #region constructor
        public Song(string songName, string artist, int songLength)
        {
            this.songName = songName;
            this.artist = artist;
            this.songLength = songLength;
        }


        #endregion

        #region setter-getter

        public string GetSongName()
        {
            return songName;
        }

        public string GetArtist()
        {
            return artist;
        }

        public int GetSongLength()
        {
            return songLength;
        }



        #endregion

        #region body
        public void ToString()
        {
            Console.WriteLine("Song Info : "+GetSongName()+" / "+GetArtist()+" / "+GetSongLength());
        }
        #endregion



    }
}
