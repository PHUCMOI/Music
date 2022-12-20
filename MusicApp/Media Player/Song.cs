﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
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

        public class HistorySong
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

        public class FavoriteSong
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

        public class Track
        {
            public int TrackID { get; set; }
            public string Name { get; set; }
            /*
            public string Artist { get; set; }
            public string Album { get; set; }
            public int PlayCount { get; set; }
            public int SkipCount { get; set; }*/
        }
        public class Playlist
        {
            private static List<string> PlaylistName = new List<string>();


            public static List<string> GlobalPlaylistName
            {
                get
                {
                    return PlaylistName;
                }
                set
                {
                    PlaylistName.Add(value.ToString());
                }
            }
        }

        public static int CheckDuplicate(string SongName)
        {
            for (int i = 0; i < FavoriteSong.GlobalSongName.Count; i++)
            {
                if (SongName == FavoriteSong.GlobalSongName[i])
                    return 0;
            }
            return 1;
        }
    }
}
