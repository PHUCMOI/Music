using Media_Player.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Media_Player
{
    public partial class Form4 : Form
    {
        public Form1 frm1;
        public static string PlayListName;
        public Form4(string PlayListName_)
        {
            InitializeComponent();
            PlayListName = PlayListName_;
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
                Form1 frm1 = (Form1)this.Parent.Parent.Parent.Parent;
                frm1.runmp3(m.SongName);
                frm1.picPlaying.Image = m.ImageSong;
                frm1.label3.Text = m.SongName + " playing...";
            };
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            for(int i = 0; i < Form1.ListPlayList.Count; i++)
            {
                if(Form1.ListPlayList[i].getset_PlayListName == PlayListName)
                {
                    for(var j = 0; j < Form1.ListPlayList[i].getset_SongName.Count; j++)
                    {
                        for(int k = 0; k < Song.ListSong.GlobalSongName.Count; k++)
                        {
                            if (Form1.ListPlayList[i].getset_SongName[j] == Song.ListSong.GlobalSongName[k])
                            {
                                AddMusicItem(Song.ListSong.GlobalSongName[k],
                                    Song.ListSong.GlobalAuthor[k],
                                    Song.ListSong.GlobalGenre[k],
                                    Song.ListSong.GlobalSongName[k] + ".jpg");
                            }    
                        }    
                    }    
                }    
            }
            Form3.flagCheckOpenform = false;
        }

    }
}
