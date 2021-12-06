namespace MuziekSpelerControls.Controls
{
    partial class PlayListNew
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
            this.lvPlaylist = new System.Windows.Forms.ListView();
            this.colMusicName = new System.Windows.Forms.ColumnHeader();
            this.colMusicAuthor = new System.Windows.Forms.ColumnHeader();
            this.colDuration = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvPlaylist
            // 
            this.lvPlaylist.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMusicName,
            this.colMusicAuthor,
            this.colDuration});
            this.lvPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPlaylist.FullRowSelect = true;
            this.lvPlaylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPlaylist.Location = new System.Drawing.Point(0, 0);
            this.lvPlaylist.MultiSelect = false;
            this.lvPlaylist.Name = "lvPlaylist";
            this.lvPlaylist.Size = new System.Drawing.Size(299, 607);
            this.lvPlaylist.TabIndex = 0;
            this.lvPlaylist.TileSize = new System.Drawing.Size(400, 45);
            this.lvPlaylist.UseCompatibleStateImageBehavior = false;
            this.lvPlaylist.View = System.Windows.Forms.View.Details;
            // 
            // colMusicName
            // 
            this.colMusicName.Text = "Music";
            // 
            // colMusicAuthor
            // 
            this.colMusicAuthor.Text = "Author";
            // 
            // colDuration
            // 
            this.colDuration.Text = "Duration";
            // 
            // PlayListNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPlaylist);
            this.Name = "PlayListNew";
            this.Size = new System.Drawing.Size(299, 607);
            this.Load += new System.EventHandler(this.PlayListNew_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvPlaylist;
        private ColumnHeader colMusicName;
        private ColumnHeader colMusicAuthor;
        private ColumnHeader colDuration;
    }
}
