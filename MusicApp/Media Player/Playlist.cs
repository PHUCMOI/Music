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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Media_Player
{
    public partial class Playlist : UserControl
    {
        public event EventHandler OnSelect = null;

        public Playlist()
        {
            InitializeComponent();
        }
        public string PlaylistName { get => lblPlaylistName.Text; set => lblPlaylistName.Text = value; }

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

        

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Song.Playlist.GlobalPlaylistName.IndexOf(this.PlaylistName);
            Song.Playlist.GlobalPlaylistName.RemoveAt(x);
            Form3 newform = (Form3)this.Parent.Parent;
            this.Parent.Controls.Remove(this);

        }
    }
}
