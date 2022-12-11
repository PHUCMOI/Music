namespace Media_Player
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picSong = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnFavorite = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pnlLyric = new System.Windows.Forms.Panel();
            this.Lyrics = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).BeginInit();
            this.pnlLyric.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSong
            // 
            this.picSong.AllowFocused = false;
            this.picSong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSong.AutoSizeHeight = true;
            this.picSong.BorderRadius = 0;
            this.picSong.Image = ((System.Drawing.Image)(resources.GetObject("picSong.Image")));
            this.picSong.IsCircle = false;
            this.picSong.Location = new System.Drawing.Point(53, 37);
            this.picSong.Name = "picSong";
            this.picSong.Size = new System.Drawing.Size(380, 380);
            this.picSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSong.TabIndex = 0;
            this.picSong.TabStop = false;
            this.picSong.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // btnFavorite
            // 
            this.btnFavorite.ActiveImage = null;
            this.btnFavorite.AllowAnimations = true;
            this.btnFavorite.AllowBuffering = false;
            this.btnFavorite.AllowToggling = false;
            this.btnFavorite.AllowZooming = true;
            this.btnFavorite.AllowZoomingOnFocus = false;
            this.btnFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFavorite.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFavorite.ErrorImage")));
            this.btnFavorite.FadeWhenInactive = false;
            this.btnFavorite.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorite.Image")));
            this.btnFavorite.ImageActive = null;
            this.btnFavorite.ImageLocation = null;
            this.btnFavorite.ImageMargin = 20;
            this.btnFavorite.ImageSize = new System.Drawing.Size(41, 40);
            this.btnFavorite.ImageZoomSize = new System.Drawing.Size(61, 60);
            this.btnFavorite.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFavorite.InitialImage")));
            this.btnFavorite.Location = new System.Drawing.Point(372, 536);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Rotation = 0;
            this.btnFavorite.ShowActiveImage = true;
            this.btnFavorite.ShowCursorChanges = true;
            this.btnFavorite.ShowImageBorders = true;
            this.btnFavorite.ShowSizeMarkers = false;
            this.btnFavorite.Size = new System.Drawing.Size(61, 60);
            this.btnFavorite.TabIndex = 22;
            this.btnFavorite.ToolTipText = "";
            this.btnFavorite.WaitOnLoad = false;
            this.btnFavorite.Zoom = 20;
            this.btnFavorite.ZoomSpeed = 10;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // pnlLyric
            // 
            this.pnlLyric.AutoScroll = true;
            this.pnlLyric.Controls.Add(this.Lyrics);
            this.pnlLyric.Location = new System.Drawing.Point(459, 28);
            this.pnlLyric.Name = "pnlLyric";
            this.pnlLyric.Size = new System.Drawing.Size(902, 568);
            this.pnlLyric.TabIndex = 23;
            // 
            // Lyrics
            // 
            this.Lyrics.AllowDrop = true;
            this.Lyrics.AutoEllipsis = true;
            this.Lyrics.AutoSize = true;
            this.Lyrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lyrics.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Lyrics.Location = new System.Drawing.Point(0, 0);
            this.Lyrics.Name = "Lyrics";
            this.Lyrics.Size = new System.Drawing.Size(65, 28);
            this.Lyrics.TabIndex = 0;
            this.Lyrics.Text = "label1";
            this.Lyrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(46, 441);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(177, 41);
            this.lblAuthor.TabIndex = 24;
            this.lblAuthor.Text = "BLACKPINK";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 628);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.pnlLyric);
            this.Controls.Add(this.picSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).EndInit();
            this.pnlLyric.ResumeLayout(false);
            this.pnlLyric.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox picSong;
        private Bunifu.UI.WinForms.BunifuImageButton btnFavorite;
        private System.Windows.Forms.Panel pnlLyric;
        private System.Windows.Forms.Label Lyrics;
        private System.Windows.Forms.Label lblAuthor;
    }
}