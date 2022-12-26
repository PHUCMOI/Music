using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player
{
    public class PlayListSong
    {
        private string PlayListName = "";
        private List<string> SongName = new List<string>();
        
        public PlayListSong(string playlistname)
        {
            PlayListName = playlistname;
        }

        public string getset_PlayListName
        {
            get
            {
                return PlayListName;   
            }
            set
            {
                PlayListName = value;
            }
        }    

        public List<string> getset_SongName
        {
            get
            {
                return SongName;
            }
            set
            {
                SongName.Add(value.ToString());
            }
        }
    }
}
