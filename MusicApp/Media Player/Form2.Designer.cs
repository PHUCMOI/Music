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
            this.btnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pnlLyric = new System.Windows.Forms.Panel();
            this.Lyrics = new System.Windows.Forms.Label();
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
            this.picSong.Location = new System.Drawing.Point(91, 42);
            this.picSong.Name = "picSong";
            this.picSong.Size = new System.Drawing.Size(380, 380);
            this.picSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSong.TabIndex = 0;
            this.picSong.TabStop = false;
            this.picSong.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // btnNext
            // 
            this.btnNext.ActiveImage = null;
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowBuffering = false;
            this.btnNext.AllowToggling = false;
            this.btnNext.AllowZooming = true;
            this.btnNext.AllowZoomingOnFocus = false;
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ErrorImage")));
            this.btnNext.FadeWhenInactive = false;
            this.btnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.ImageLocation = null;
            this.btnNext.ImageMargin = 20;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNext.InitialImage")));
            this.btnNext.Location = new System.Drawing.Point(778, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0;
            this.btnNext.ShowActiveImage = true;
            this.btnNext.ShowCursorChanges = true;
            this.btnNext.ShowImageBorders = true;
            this.btnNext.ShowSizeMarkers = false;
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 22;
            this.btnNext.ToolTipText = "";
            this.btnNext.WaitOnLoad = false;
            this.btnNext.Zoom = 20;
            this.btnNext.ZoomSpeed = 10;
            // 
            // pnlLyric
            // 
            this.pnlLyric.AutoScroll = true;
            this.pnlLyric.Controls.Add(this.Lyrics);
            this.pnlLyric.Controls.Add(this.btnNext);
            this.pnlLyric.Location = new System.Drawing.Point(508, 28);
            this.pnlLyric.Name = "pnlLyric";
            this.pnlLyric.Size = new System.Drawing.Size(878, 568);
            this.pnlLyric.TabIndex = 23;
            // 
            // Lyrics
            // 
            this.Lyrics.AutoSize = true;
            this.Lyrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lyrics.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lyrics.Location = new System.Drawing.Point(0, 0);
            this.Lyrics.Name = "Lyrics";
            this.Lyrics.Size = new System.Drawing.Size(76, 31);
            this.Lyrics.TabIndex = 0;
            this.Lyrics.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 628);
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

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox picSong;
        private Bunifu.UI.WinForms.BunifuImageButton btnNext;
        private System.Windows.Forms.Panel pnlLyric;
        private System.Windows.Forms.Label Lyrics;
    }
}