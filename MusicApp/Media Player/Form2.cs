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
    public partial class Form2 : Form
    {
        public static XmlDocument xmlDoc = new XmlDocument();
        public static XmlNodeList nodeList;
        private string SongName;
        private string Genre;
        public Form2(string _SongName)
        {
            InitializeComponent();
            SongName = _SongName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            xmlDoc.Load("..//..//ListSong.xml");

            nodeList = xmlDoc.DocumentElement.SelectNodes("/songs/" + "/song");
            
            for(int i = 0; i < nodeList.Count; i++)
            {
                if (nodeList[i].SelectSingleNode("Title").InnerText == SongName)
                {
                    Lyrics.Text = nodeList[i].SelectSingleNode("Lyric").InnerText.Trim();
                    picSong.Image = Image.FromFile(@"..//..//image/" + nodeList[i].SelectSingleNode("Title").InnerText + ".jpg");
                    lblAuthor.Text = nodeList[i].SelectSingleNode("Author").InnerText.Trim();
                    Genre = nodeList[i].SelectSingleNode("Genre").InnerText.Trim();
                }    
            }

            if(CheckDuplicate(SongName) == 0)
            {
                btnFavorite.Image = Image.FromFile(@"..//..//image/redheart.png");
            }    
        }


        #region add FavoriteSong
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

        public int CheckDuplicate(string SongName)
        {
            for (int i = 0; i < Song.FavoriteSong.GlobalSongName.Count; i++)
            {
                if (SongName == Song.FavoriteSong.GlobalSongName[i])
                    return 0;
            }
            return 1;
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (CheckDuplicate(SongName) == 1)
            {
                Song.FavoriteSong.GlobalSongName.Add(SongName);
                Song.FavoriteSong.GlobalAuthor.Add(lblAuthor.Text);
                Song.FavoriteSong.GlobalGenre.Add(Genre);
                int n = Song.FavoriteSong.GlobalSongName.Count;
                AddItem(Song.FavoriteSong.GlobalSongName[n - 1], Song.FavoriteSong.GlobalAuthor[n - 1], Song.FavoriteSong.GlobalGenre[n - 1]);
            }
            btnFavorite.Image = Image.FromFile(@"..//..//image/redheart.png");
        }
        #endregion
    }
}
