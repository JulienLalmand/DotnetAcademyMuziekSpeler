using MuziekSpelerLib;
using System.Windows.Forms;

namespace MuziekSpelerControls.Controls
{
    public partial class MusicView : UserControl, IMusicPlayerCustomControl
    {
        public MusicView()
        {
            InitializeComponent();
        }

        private Music _music;

        public Music Music
        {
            get { return _music; }
            set { 
                if(value != null)
                {
                    _music = value;
                    _music.MusicChanged += MusicChanged;
                }
            }
        }

        private void MusicChanged(object sender, EventArgs e)
        {
            RefreshRender();
        }

        private void MusicView_Load(object sender, EventArgs e)
        {
            RefreshRender();
            pbMusic.Image = Properties.Resources.music_note;
        }

        public void RefreshRender()
        {
            if(_music != null)
            {
                lblMusicTitle.Text = _music.Properties.Title;
                lblMusicAuthor.Text = _music.Properties.Author;
                lblMusicDuration.Text = _music.Properties.Duration.ToString(@"hh\:mm\:ss");
            }
        }

    }
}
