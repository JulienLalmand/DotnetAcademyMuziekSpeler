namespace MuziekSpelerControls.Controls
{
    partial class PlaylistView
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
            this.tlpPlaylist = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpPlaylist
            // 
            this.tlpPlaylist.AutoScroll = true;
            this.tlpPlaylist.ColumnCount = 1;
            this.tlpPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlaylist.Location = new System.Drawing.Point(0, 0);
            this.tlpPlaylist.Name = "tlpPlaylist";
            this.tlpPlaylist.RowCount = 2;
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpPlaylist.Size = new System.Drawing.Size(310, 833);
            this.tlpPlaylist.TabIndex = 0;
            // 
            // PlaylistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPlaylist);
            this.Name = "PlaylistView";
            this.Size = new System.Drawing.Size(310, 833);
            this.Load += new System.EventHandler(this.PlaylistView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpPlaylist;
    }
}
