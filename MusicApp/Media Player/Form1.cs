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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Media_Player.Component;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Media_Player
{
    
    public partial class Form1 : Form
    {
        //XML
        public static XmlDocument xmlDoc = new XmlDocument();
        public static XmlNodeList nodeList;

        string SongName;
        SoundPlayer looping;

        Random random = new Random();
        List<int> randlist = new List<int>();
        int index = 0;
        

        public Form1()
        {
            InitializeComponent();
            trackVolume.Value = 50;

            while(index < 20)
            {
                {
                    int randomNum = random.Next(1, 100);
                    randlist.Add(randomNum);
                    if (index == 5)
                    {
                        break;
                    }
                    index++;
                }
            }    

            DataSet dataset = new DataSet();

            dataset.ReadXml("..//..//ListSong.xml");


            //bunifuPages1.SetPage(0);
        }

        #region SlideBar
        private void btnHome_Click(object sender, EventArgs e)
        {
            indicator.Top = btnHome.Top + 11;
            pnlControl.Show();
            //bunifuPages1.SetPage(1);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnExplore.Top + 11;
            //bunifuPages1.SetPage(0);
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            indicator.Top = btnAlbums.Top + 11;
            //bunifuPages1.SetPage(2);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaylist.Top + 11;
            //bunifuPages1.SetPage(3);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            indicator.Top = btnSetting.Top + 11;
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

            /* picBack1.Image = Image.FromFile("..//..//image/back1.jpg");
             picBack2.Image = Image.FromFile("..//..//image/back2.jpg");
             picBack3.Image = Image.FromFile("..//..//image/back3.jpg");*/
            xmlDoc.Load("..//..//ListSong.xml");

            nodeList = xmlDoc.DocumentElement.SelectNodes("/songs/" + "/song");

            for (int i = 0; i < 30; i++)
            {
                Song.ListSong.GlobalSongName.Add(nodeList[i].SelectSingleNode("Title").InnerText);
                Song.ListSong.GlobalAuthor.Add(nodeList[i].SelectSingleNode("Author").InnerText);
                Song.ListSong.GlobalGenre.Add(nodeList[i].SelectSingleNode("Genre").InnerText);
            }
        }

        //playmusic
        public void runmp3(string SongName)
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
            /*int Prev = bunifuDataGridView1.CurrentRow.Index - 1;
            if (Prev < bunifuDataGridView1.Rows.Count)
            {
                this.bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[Prev].Cells[bunifuDataGridView1.CurrentCell.ColumnIndex];
                SongName = bunifuDataGridView1.Rows[Prev].Cells["Title"].FormattedValue.ToString();
                Author = bunifuDataGridView1.Rows[Prev].Cells["Author"].FormattedValue.ToString();
                label3.Text = SongName + " - " + Author + " Playing...";
                runmp3();
            }*/
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            /*Stream resource = Properties.Resources.ResourceManager.GetStream(SongName);
            if (resource == null)
            {
                throw new ArgumentException();
            }
            Stream output = File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Sound.wav");*/
            if (!System.IO.Directory.Exists(@"C:\C#"))
            {
                System.IO.Directory.CreateDirectory(@"C:\C#");
            }

            //Write the file
            using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(@"C:\C#\" + SongName + ".wav"))
            {
                outfile.Write(@"C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\music\\" + SongName + ".wav");
            }
        }

        bool flagloop = false;
        private void btnLoop_Click(object sender, EventArgs e)
        {
            if(flagloop == false)
            {
                looping = new SoundPlayer(@"C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\music\\" + SongName + ".wav");
                looping.PlayLooping();
                flagloop = true;
               //label10.Visible = true;
            }
            else
            {
                looping = null;
                flagloop = false;
                //label10.Visible = false;
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


        //search
        private void txt_Search_TextChange(object sender, EventArgs e)
        {
           /* string searchValue = txt_Search.Text;
            try
            {
                var result_songname = from col in dataTableListSong.AsEnumerable()
                                      where col[1].ToString().Contains(searchValue) 
                                      select col;
                *//*var result_songname = from row in dataTableListSong.AsEnumerable()
                                      where row[1].ToString().Contains(searchValue)
                                      select row;*//*
                if (result_songname.Count() == 0)
                {
                    label11.Text = "Không có kết quả";
                    bunifuDataGridView2.DataSource = dataTableListSong;
                }
                else
                {
                    bunifuDataGridView2.DataSource = result_songname.CopyToDataTable();
                    label11.Text = "có";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }


        //Search
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var musicitem = (MusicItem)item;
                musicitem.Visible = musicitem.lblSongName.Text.ToLower().ToLower().Contains(txt_Search.Text.Trim().ToLower());
                if (musicitem.Visible == false)
                    musicitem.Visible = musicitem.lblAuthor.Text.ToLower().ToLower().Contains(txt_Search.Text.Trim().ToLower());
                if (musicitem.Visible == false)
                    musicitem.Visible = musicitem.lblAlbum.Text.ToLower().ToLower().Contains(txt_Search.Text.Trim().ToLower());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            bunifuFormDock1.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        //
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
                SongName = m.lblSongName.Text;
                picPlaying.Image = m.ImageSong;
                runmp3(SongName);
                label3.Text = SongName + " - " + m.lblAuthor.Text + " Playing...";
            };
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Song.ListSong.GlobalSongName.Count; i++)
            {
                AddMusicItem(Song.ListSong.GlobalSongName[i],
                    Song.ListSong.GlobalAuthor[i],
                    Song.ListSong.GlobalGenre[i],
                    Song.ListSong.GlobalSongName[i] + ".jpg");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var musicitem = (MusicItem)item;
                if (musicitem.lblAlbum.Text == Song.ListSong.GlobalGenre[1])
                    musicitem.Visible = true;
                else
                    musicitem.Visible = false;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var musicitem = (MusicItem)item;
                if (musicitem.lblAlbum.Text == Song.ListSong.GlobalGenre[23])
                    musicitem.Visible = true;
                else
                    musicitem.Visible = false;
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var musicitem = (MusicItem)item;
                if (musicitem.lblAlbum.Text == Song.ListSong.GlobalGenre[27])
                    musicitem.Visible = true;
                else
                    musicitem.Visible = false;
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var musicitem = (MusicItem)item;
                if (musicitem.lblAlbum.Text == Song.ListSong.GlobalGenre[19])
                    musicitem.Visible = true;
                else
                    musicitem.Visible = false;
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var musicitem = (MusicItem)item;
                if (musicitem.lblAlbum.Text == Song.ListSong.GlobalGenre[11])
                    musicitem.Visible = true;
                else
                    musicitem.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var musicitem = (MusicItem)item;
                musicitem.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picPlaying_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(SongName);
            frm2.TopLevel = false;
            pnlControl.Hide();
            panel2.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm2);
            frm2.BringToFront();
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        
    }
}
;
