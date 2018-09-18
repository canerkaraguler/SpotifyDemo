using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerliSpotify
{
    class PayedUser : User
    {

        #region constructor

        public PayedUser(string userName)
        {
            this.userName = userName;
            this.playList = new List<Playlist>();
        }

        #endregion


        #region setter-getter

        public override void SetPlaylist(Playlist playListItem)
        {
            this.playList.Add(playListItem);
            playListItem.AddUser(this);
        }

        public string GetUserName()
        {
            return userName;
        }

        #endregion

        #region body
        public override void Update()
        {
            Console.WriteLine("Downloaded new songs");
        }

        public override void ToString()
        {
            Console.WriteLine("I am a paid user : "+GetUserName());
        }

        #endregion

    }
}
