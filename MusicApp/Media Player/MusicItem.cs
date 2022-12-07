using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player.Component
{
    public partial class MusicItem : UserControl
    {
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
    }
}
