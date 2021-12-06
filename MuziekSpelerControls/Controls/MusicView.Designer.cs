namespace MuziekSpelerControls.Controls
{
    partial class MusicView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMusicCard = new System.Windows.Forms.TableLayoutPanel();
            this.pbMusic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMusicDuration = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMusicAuthor = new System.Windows.Forms.Label();
            this.lblMusicTitle = new System.Windows.Forms.Label();
            this.tlpMusicCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMusicCard
            // 
            this.tlpMusicCard.ColumnCount = 2;
            this.tlpMusicCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMusicCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpMusicCard.Controls.Add(this.pbMusic, 0, 0);
            this.tlpMusicCard.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpMusicCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMusicCard.Location = new System.Drawing.Point(0, 0);
            this.tlpMusicCard.Name = "tlpMusicCard";
            this.tlpMusicCard.RowCount = 1;
            this.tlpMusicCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMusicCard.Size = new System.Drawing.Size(327, 107);
            this.tlpMusicCard.TabIndex = 0;
            // 
            // pbMusic
            // 
            this.pbMusic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMusic.Location = new System.Drawing.Point(6, 3);
            this.pbMusic.Name = "pbMusic";
            this.pbMusic.Size = new System.Drawing.Size(68, 100);
            this.pbMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMusic.TabIndex = 0;
            this.pbMusic.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lblMusicDuration, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(84, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 101);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.Location = new System.Drawing.Point(172, 35);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(64, 30);
            this.lblMusicDuration.TabIndex = 4;
            this.lblMusicDuration.Text = "MUSIC_DURATION";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblMusicAuthor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMusicTitle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(162, 95);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblMusicAuthor
            // 
            this.lblMusicAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMusicAuthor.AutoSize = true;
            this.lblMusicAuthor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMusicAuthor.Location = new System.Drawing.Point(33, 63);
            this.lblMusicAuthor.Name = "lblMusicAuthor";
            this.lblMusicAuthor.Size = new System.Drawing.Size(95, 15);
            this.lblMusicAuthor.TabIndex = 2;
            this.lblMusicAuthor.Text = "MUSIC_AUTHOR";
            // 
            // lblMusicTitle
            // 
            this.lblMusicTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMusicTitle.AutoSize = true;
            this.lblMusicTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMusicTitle.Location = new System.Drawing.Point(34, 13);
            this.lblMusicTitle.Name = "lblMusicTitle";
            this.lblMusicTitle.Size = new System.Drawing.Size(94, 20);
            this.lblMusicTitle.TabIndex = 1;
            this.lblMusicTitle.Text = "MUSIC_TITLE";
            // 
            // MusicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMusicCard);
            this.Name = "MusicView";
            this.Size = new System.Drawing.Size(327, 107);
            this.Load += new System.EventHandler(this.MusicView_Load);
            this.tlpMusicCard.ResumeLayout(false);
            this.tlpMusicCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMusicCard;
        private PictureBox pbMusic;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMusicDuration;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblMusicAuthor;
        private Label lblMusicTitle;
    }
}
