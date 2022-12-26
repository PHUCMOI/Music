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

namespace Media_Player
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public void AddFavoriteMusicItem(string name, string author, string album, string image)
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
                Form1 frm1 = (Form1)this.Parent.Parent;
                frm1.runmp3(m.lblSongName.Text);
                frm1.picPlaying.Image = m.ImageSong;
                frm1.label3.Text = m.lblSongName.Text + " - " + m.lblAuthor.Text + " Playing...";
            };
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Song.FavoriteSong.GlobalSongName.Count; i++)
            {
                AddFavoriteMusicItem(Song.FavoriteSong.GlobalSongName[i],
                    Song.FavoriteSong.GlobalAuthor[i],
                    Song.FavoriteSong.GlobalGenre[i],
                    Song.FavoriteSong.GlobalSongName[i] + ".jpg");
            }
        }
    }
}
