using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerliSpotify
{
    abstract class Playlist
    {
        protected string playListName;
        protected List<Song> songList;
        protected List<User> userList;

        public abstract void NotifyUsers();
        public abstract void AddUser(User user);
        public abstract void AddSong(Song song);
        public abstract void ToString();
        public abstract void UserToString();

    }
}
