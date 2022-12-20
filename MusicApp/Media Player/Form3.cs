using Media_Player.Component;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Media_Player
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static XmlDocument xmlPlaylistDoc = new XmlDocument();
        public static XmlNodeList playlist;
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private XDocument xmldoc;
        private string fileName = @"..//..//Playlist.xml";
        public void AddItem(string Title)
        {
            doc.Load(fileName);

            root = doc.DocumentElement;

            XmlNode item = doc.CreateElement("Playlist");

            XmlElement Title_ = doc.CreateElement("Title");
            Title_.InnerText = Title;
            item.AppendChild(Title_);

            root.AppendChild(item);
            doc.Save(fileName);
        }

        public void AddPlaylistItem(string name)
        {
            var m = new Playlist()
            {
                PlaylistName = name,
            };

            pnlControlPlaylist.Controls.Add(m);

            m.OnSelect += (ss, ee) =>
            {
                var musicitem = (Playlist)ss;
                Form4 frm3 = new Form4();
                frm3.TopLevel = false;
                pnlControlPlaylist.Hide();
                if (pnlControlPlaylist.Visible == false)
                {
                    panel1.Visible = true;
                    panel1.Dock = DockStyle.Fill;
                    panel1.Controls.Add(frm3);
                    frm3.BringToFront();
                    frm3.Dock = DockStyle.Fill;
                    frm3.Show();
                }
            };
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            string Content = Interaction.InputBox("Nhập tên playlist: ", "Tên playlist", "", 500, 300);
            Song.Playlist.GlobalPlaylistName.Add(Content);
            Playlist playlist = new Playlist();

            playlist.PlaylistName = Content;
            AddPlaylistItem(Content);
            /*XElement emp = new XElement("Playlist",
                new XElement("PlaylistName", Content),
                
                new XElement("fullname", txt_fullname.Text),
                new XElement("salary", txt_salary.Text),
                new XElement("email", txt_email.Text),
                new XElement("address", txt_address.Text));
            xmldoc.Root.Add(emp);
            xmldoc.Save("..//..//Playlist.xml");*/
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*xmldoc = XDocument.Load("..//..//Playlist.xml");

            xmlPlaylistDoc.Load("..//..//Playlist.xml");

            playlist = xmlPlaylistDoc.DocumentElement.SelectNodes("/songs/" + "/song");
            for (int i = 0; i < playlist.Count; i++)
            {
                Song.FavoriteSong.GlobalSongName.Add(playlist[i].SelectSingleNode("Title").InnerText);
                Song.FavoriteSong.GlobalAuthor.Add(playlist[i].SelectSingleNode("Author").InnerText);
                Song.FavoriteSong.GlobalGenre.Add(playlist[i].SelectSingleNode("Genre").InnerText);
            }*/
        }
    }
}
