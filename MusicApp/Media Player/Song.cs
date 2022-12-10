using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player
{
    internal class Song
    {
        public static class ListSong
        {
            private static List<string> SongName = new List<string>();
            private static List<string> Author = new List<string>();
            private static List<string> Genre = new List<string>();

            public static List<string> GlobalSongName
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

            public static List<string> GlobalAuthor
            {
                get
                {
                    return Author;
                }
                set
                {
                    Author.Add(value.ToString());
                }
            }

            public static List<string> GlobalGenre
            {
                get
                {
                    return Genre;
                }
                set
                {
                    Genre.Add(value.ToString());
                }
            }
        }
    }
}
