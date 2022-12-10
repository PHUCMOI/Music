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
                }    
            }

        }    
    }
}
