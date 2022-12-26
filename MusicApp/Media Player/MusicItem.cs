using RestSharp.Extensions;
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
using System.IO;
using System.Globalization;

namespace Media_Player.Component
{
    public partial class MusicItem : UserControl
    {
        public static XmlDocument xmlDoc = new XmlDocument();
        public static XmlNodeList nodeList;

        public event EventHandler OnSelect = null;    
        public MusicItem()
        {
            InitializeComponent();
        }

        public string SongName { get => lblSongName.Text; set => lblSongName.Text = value; }
        public string Author { get => lblAuthor.Text; set => lblAuthor.Text = value; }
        public string Album { get => lblAlbum.Text; set => lblAlbum.Text = value; }
        public Image ImageSong { get => picSong.Image; set => picSong.Image = value; }

        private void picSong_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void MusicItem_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void MusicItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        public XmlDocument doc = new XmlDocument();
        public XmlElement root;

        private string fileName = @"..//..//FavoriteSong.xml";
        

        public void AddItem(string Title, string Author, string Genre)
        {
            doc.Load(fileName);

            root = doc.DocumentElement;

            XmlNode item = doc.CreateElement("song");

            XmlElement Title_ = doc.CreateElement("Title");
            Title_.InnerText = Title;
            item.AppendChild(Title_);

            XmlElement Author_ = doc.CreateElement("Author");
            Author_.InnerText = Author;
            item.AppendChild(Author_);

            XmlElement Genre_ = doc.CreateElement("Genre");
            Genre_.InnerText = Genre;
            item.AppendChild(Genre_);

            root.AppendChild(item);
            doc.Save(fileName);
        }


        private void btnFavortie_Click(object sender, EventArgs e)
        {
            if (Song.CheckDuplicate(SongName) == 1)
            {
                Song.FavoriteSong.GlobalSongName.Add(SongName);
                Song.FavoriteSong.GlobalAuthor.Add(Author);
                Song.FavoriteSong.GlobalGenre.Add(Album);
                int n = Song.FavoriteSong.GlobalSongName.Count;
                AddItem(Song.FavoriteSong.GlobalSongName[n - 1], Song.FavoriteSong.GlobalAuthor[n -1], Song.FavoriteSong.GlobalGenre[n - 1]);
            }
            btnFavortie.Image = Image.FromFile(@"..//..//image/redheart.png");
        }
        private void MusicItem_Load(object sender, EventArgs e)
        {
            if (Song.CheckDuplicate(SongName) == 0)
            {
                btnFavortie.Image = Image.FromFile(@"..//..//image/redheart.png");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(Form3.flagCheckOpenform == true)
            {
                for(int i = 0; i < Form1.ListPlayList.Count; i++)
                {
                    if (Form1.ListPlayList[i].getset_PlayListName == Form4.PlayListName)
                    {
                        int x = Form1.ListPlayList[i].getset_SongName.Count;
                        Form1.ListPlayList[i].getset_SongName.Add(SongName);
                    }   
                }    
            }
            else
            {
                Form5 frm5 = new Form5(SongName);
                frm5.ShowDialog();
            }
        }

        string despath = "";
        string fileToCopy = "";
        private void btnDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                despath = ofd.SelectedPath;
            }


            fileToCopy = "C:\\Users\\PC\\Documents\\GitHub\\Music\\MusicApp\\Media Player\\music\\" + lblSongName.Text + ".wav";
            File.Copy(fileToCopy, despath + Path.GetFileName(fileToCopy));
        }
    }
} 
