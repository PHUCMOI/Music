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
using System.Xml.Linq;
using System.IO;
using System.Media;
using System.Numerics;
using Image = System.Drawing.Image;
using System.Reflection;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        SoundPlayer looping;
        string SongName;
        string Author;
        public Form1()
        {
            InitializeComponent();
            trackVolume.Value = 50;
            label10.Visible = false;
        }
        #region SlideBar
        private void btnHome_Click(object sender, EventArgs e)
        {
            indicator.Top = btnHome.Top + 11;
            bunifuPages1.SetPage(0);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnExplore.Top + 11;
            bunifuPages1.SetPage(1);

            DataSet dataset = new DataSet();
            dataset.ReadXml("..//..//ListSong.xml");
            bunifuDataGridView1.DataSource = dataset.Tables[0];
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            indicator.Top = btnAlbums.Top + 11;
            bunifuPages1.SetPage(2);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaylist.Top + 11;
            bunifuPages1.SetPage(3);
        }
        #endregion

        #region NavigationBar
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "No Playing...";
        }

        #region ListMusic
        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bunifuDataGridView1.CurrentRow.Selected = true;
                SongName = bunifuDataGridView1.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                Author = bunifuDataGridView1.Rows[e.RowIndex].Cells["Author"].FormattedValue.ToString();
                label3.Text = SongName + " - " + Author + " Playing...";
            }
            bunifuPages1.SetPage(0) ;
            runmp3();
        }

        #endregion
        //playmusic
        private void runmp3()
        {
            PlayMusic.URL = "C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\music\\" + SongName + ".wav";
            PlayMusic.Ctlcontrols.play();
        }

        #region MusicControl
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PlayMusic.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuHSlider1.Maximum = (int)PlayMusic.Ctlcontrols.currentItem.duration;
                bunifuHSlider1.Value = (int)PlayMusic.Ctlcontrols.currentPosition;
                try
                {
                    lblCurrentTime.Text = PlayMusic.Ctlcontrols.currentPositionString;
                    lblTotalTime.Text = PlayMusic.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }
            }    
           
        }
        bool flagMusic = true;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(flagMusic == true)
            {
                PlayMusic.Ctlcontrols.pause();
                flagMusic = false;
                btnPlay.Image = Image.FromFile(@"C:\Users\PC\Documents\GitHub\Music\MusicApp\Media Player\image\pause.png");
            }
            else 
            {
                btnPlay.Image = Image.FromFile(@"C:\Users\PC\Documents\GitHub\Music\MusicApp\Media Player\image\play-button.png");
                PlayMusic.Ctlcontrols.play();
                flagMusic = true;
            }    
        }

        int volume = 0;
        private void trackVolume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            PlayMusic.settings.volume = trackVolume.Value;
            volume = PlayMusic.settings.volume;
            lblTrackVolumeValue.Text = trackVolume.Value.ToString() + "%";    
        }

        private void bunifuHSlider1_MouseDown(object sender, MouseEventArgs e)
        {
            PlayMusic.Ctlcontrols.currentPosition = PlayMusic.currentMedia.duration * e.X / bunifuHSlider1.Width;
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int Prev = bunifuDataGridView1.CurrentRow.Index - 1;
            if (Prev < bunifuDataGridView1.Rows.Count)
            {
                this.bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[Prev].Cells[bunifuDataGridView1.CurrentCell.ColumnIndex];
                SongName = bunifuDataGridView1.Rows[Prev].Cells["Title"].FormattedValue.ToString();
                Author = bunifuDataGridView1.Rows[Prev].Cells["Author"].FormattedValue.ToString();
                label3.Text = SongName + " - " + Author + " Playing...";
                runmp3();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int Next = bunifuDataGridView1.CurrentRow.Index + 1;
            if (Next < bunifuDataGridView1.Rows.Count)
            {
                this.bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[Next].Cells[bunifuDataGridView1.CurrentCell.ColumnIndex];
                SongName = bunifuDataGridView1.Rows[Next].Cells["Title"].FormattedValue.ToString();
                Author = bunifuDataGridView1.Rows[Next].Cells["Author"].FormattedValue.ToString();
                label3.Text = SongName + " - " + Author + " Playing...";
                runmp3();
            }    
            
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            Stream resource = Properties.Resources.ResourceManager.GetStream(SongName);
            if (resource == null)
            {
                throw new ArgumentException();
            }
            Stream output = File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Sound.wav");
            /*if (!System.IO.Directory.Exists(@"C:\C#"))
            {
                System.IO.Directory.CreateDirectory(@"C:\C#");
            }

            //Write the file
            using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(@"C:\C#\" + SongName + ".wav"))
            {
                outfile.Write(@"C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\music\\" + SongName + ".wav");
            }*/
        }

        bool flagloop = false;
        private void btnLoop_Click(object sender, EventArgs e)
        {
            if(flagloop == false)
            {
                looping = new SoundPlayer(@"C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\music\\" + SongName + ".wav");
                looping.PlayLooping();
                flagloop = true;
                label10.Visible = true;
            }
            else
            {
                looping = null;
                flagloop = false;
                label10.Visible = false;
            }

        }

        bool flagMute = false;
        private void btnMuteVolume_Click(object sender, EventArgs e)
        {
            if(flagMute == false)
            {
                PlayMusic.settings.volume = 0;
                flagMute = true;
                btnMuteVolume.Image = Image.FromFile("C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\image\\mute.png");
            }
            else
            {
                btnMuteVolume.Image = Image.FromFile("C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\image\\volume.png");
                PlayMusic.settings.volume = volume;
                flagMute = false;
            }
        }
        #endregion

    }
}
