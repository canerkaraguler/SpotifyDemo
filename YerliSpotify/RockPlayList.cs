using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerliSpotify
{
    class RockPlayList : Playlist
    {

        #region variables

        #endregion

        #region constructor
        public RockPlayList(string playListName)
        {
            this.playListName = playListName;
            this.songList = new List<Song>();
            this.userList = new List<User>();

        }

        #endregion


        #region body

        override
        public void AddUser(User user)
        {
            this.userList.Add(user);
        }
        override
        public void AddSong(Song song)
        {
            this.songList.Add(song);
            NotifyUsers();
        }

        #endregion

        #region body

        public override void NotifyUsers()
        {
            foreach(User user in userList)
            {
                user.Update();
            }
        }

        public override void ToString()
        {
            foreach(Song song in songList)
            {
                song.ToString();
            }
        }

        public override void UserToString()
        {
            foreach (User user in userList)
            {
                user.ToString();
            }
        }

        #endregion
    }
}
