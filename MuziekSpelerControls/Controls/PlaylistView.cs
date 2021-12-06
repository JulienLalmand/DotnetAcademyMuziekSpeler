using MuziekSpelerLib;

namespace MuziekSpelerControls.Controls
{
    public partial class PlaylistView : UserControl, IMusicPlayerCustomControl
    {
        private Playlist _playlist;

        public Playlist PlayList
        {
            get { return _playlist; }
            set
            {
                if(value != null)
                {
                    _playlist = value;
                    RefreshRender();
                }
            }
        }

        public PlaylistView()
        {
            _playlist = new Playlist(new List<Music>());
            InitializeComponent();
        }

        private void PlaylistView_Load(object sender, EventArgs e)
        {
            //RefreshRender();
        }

        public void RefreshRender()
        {
            tlpPlaylist.Controls.Clear();
            foreach (Music music in _playlist.MusicList)
            {
                AddMusicToUI(music);
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
            tlpPlaylist.Controls.Add(control);
        }

    }
}
