using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerliSpotify
{
    abstract class User
    {
        protected string userName;
        protected List<Playlist> playList;
        

        public abstract  void Update();
        public abstract void ToString();
        public abstract void SetPlaylist(Playlist playListItem);
    }
}
