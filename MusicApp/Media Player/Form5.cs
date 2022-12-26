using Media_Player.Component;
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
    public partial class Form5 : Form
    {
        private string ListName;
        private string songName;

        public Form5(string SongName_)
        {
            songName = SongName_;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv.Rows[e.RowIndex];
            ListName = row.Cells[1].Value.ToString();
            //Song.Playlist.SonginList.Add
            for (int i = 0; i < Form1.ListPlayList.Count; i++)
            {
                if (Form1.ListPlayList[i].getset_PlayListName == ListName)
                {
                    int x = Form1.ListPlayList[i].getset_SongName.Count;
                    Form1.ListPlayList[i].getset_SongName.Add(songName);
                    label2.Text = "Đã thêm bài hát " + songName;
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.ListPlayList.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = i + 1;
                dgv.Rows[i].Cells[1].Value = Form1.ListPlayList[i].getset_PlayListName;
            }
        }
    }
}
