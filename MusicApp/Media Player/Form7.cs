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
    public partial class Form7 : Form
    {
        public Form7()
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

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            for (int i = Song.HistorySong.GlobalSongName.Count - 1; i > -1; i--)
            {
                for(int j = 0; j < Song.ListSong.GlobalSongName.Count; j++)
                {
                    if(Song.HistorySong.GlobalSongName[i] == Song.ListSong.GlobalSongName[j])
                    {
                        AddFavoriteMusicItem(Song.ListSong.GlobalSongName[j],
                                            Song.ListSong.GlobalAuthor[j],
                                            Song.ListSong.GlobalGenre[j],
                                            Song.ListSong.GlobalSongName[j] + ".jpg");
                    }    
                }    
            }
        }
    }
}
