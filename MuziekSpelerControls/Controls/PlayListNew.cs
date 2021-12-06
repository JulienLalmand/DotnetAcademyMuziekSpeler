using MuziekSpelerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuziekSpelerControls.Controls
{
    public partial class PlayListNew : UserControl
    {
        public PlayListNew()
        {
            InitializeComponent();
            _playlist = new Playlist(new List<Music>());
        }

        private Playlist _playlist;

        public Playlist PlayList
        {
            get { return _playlist; }
            set
            {
                if (value != null)
                {
                    _playlist = value;
                    RefreshRender();
                }
            }
        }

        private void PlaylistView_Load(object sender, EventArgs e)
        {
            //RefreshRender();
        }

        public void RefreshRender()
        {
            lvPlaylist.Items.Clear();
            foreach(Music music in _playlist.MusicList)
            {
                lvPlaylist.Items.Add(new ListViewItem(new string[] { music.Properties.Title, music.Properties.Author, music.Properties.Duration.ToString(@"hh\:mm\:ss") }));
            }
        }

        private void AddMusicToUI(Music music)
        {
            //Instantiate the control
            var control = new MusicView
            {
                Music = music
            };

            //Add it to our TableLayoutPanel
            //TODO: Correct sizetype?
            lvPlaylist.Items.Add(new ListViewItem(new string[] { music.Properties.Title, music.Properties.Author, music.Properties.Duration.ToString(@"hh\:mm\:ss") }));
        }

        private void PlayListNew_Load(object sender, EventArgs e)
        { 
        }
    }
}
