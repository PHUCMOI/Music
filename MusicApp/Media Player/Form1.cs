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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            indicator.Top = btnHome.Top + 11;
            bunifuPages1.SetPage(0);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnExplore.Top + 11;
            bunifuPages1.SetPage(1);
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            indicator.Top = btnAlbums.Top + 11;
            bunifuPages1.SetPage(1);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaylist.Top + 11;
            bunifuPages1.SetPage(1);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
