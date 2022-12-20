using Media_Player.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Media_Player
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void AddMusicItem(string name, string author, string album, string image)
        {
            var m = new MusicItem()
            {
                SongName = name,
                Author = author,
                Album = album,
                ImageSong = Image.FromFile("..//..//image/" + image)
            };

            pnlControl.Controls.Add(m);

            m.OnSelect += (ss, ee) =>
            {
                var musicitem = (MusicItem)ss;
            };
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            //Add List Song
            for (int i = 0; i < Song.ListSong.GlobalSongName.Count; i++)
            {
                AddMusicItem(Song.ListSong.GlobalSongName[i],
                    Song.ListSong.GlobalAuthor[i],
                    Song.ListSong.GlobalGenre[i],
                    Song.ListSong.GlobalSongName[i] + ".jpg");
            }
        }
    }
}
