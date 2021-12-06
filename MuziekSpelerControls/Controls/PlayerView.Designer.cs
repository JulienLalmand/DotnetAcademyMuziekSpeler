namespace MuziekSpelerControls.Controls
{
    partial class PlayerView
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
            this.playerControlsView = new MuziekSpelerControls.Controls.PlayerControlsView();
            this.tlpPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerControlsView
            // 
            this.playerControlsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerControlsView.Location = new System.Drawing.Point(3, 669);
            this.playerControlsView.Name = "playerControlsView";
            this.playerControlsView.Size = new System.Drawing.Size(1067, 152);
            this.playerControlsView.TabIndex = 3;
            // 
            // tlpPlayer
            // 
            this.tlpPlayer.ColumnCount = 1;
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer.Controls.Add(this.playerControlsView, 0, 1);
            this.tlpPlayer.Controls.Add(this.panel1, 0, 0);
            this.tlpPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlayer.Location = new System.Drawing.Point(0, 0);
            this.tlpPlayer.Name = "tlpPlayer";
            this.tlpPlayer.RowCount = 2;
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.88889F));
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.11111F));
            this.tlpPlayer.Size = new System.Drawing.Size(1073, 824);
            this.tlpPlayer.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::MuziekSpelerControls.Properties.Resources.music_3x;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 660);
            this.panel1.TabIndex = 4;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPlayer);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(1073, 824);
            this.Load += new System.EventHandler(this.PlayerView_Load);
            this.tlpPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerControlsView playerControlsView;
        private TableLayoutPanel tlpPlayer;
        private Panel panel1;
    }
}
