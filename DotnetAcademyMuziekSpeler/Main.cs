using MuziekSpelerLib;
using WMPLib;

namespace DotnetAcademyMuziekSpeler
{
    public partial class Main : Form
    {
        OpenFileDialog _openFileDialog;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            playerView1.OnMusicChange += PlayerView1_OnMusicChange;
        }

        private void PlayerView1_OnMusicChange(object? sender, MuziekSpelerControls.Events.MusicChangedEventArgs e)
        {
            toolstripStatusCurrentSong.Text = $"Currently playing: {e.NewMusic.Properties.Title} by {e.NewMusic.Properties.Author}";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            _openFileDialog.Filter = "MP3 File (*.mp3)|*.mp3";
            _openFileDialog.CheckFileExists = true;
            _openFileDialog.Title = "Choose your song...";
            _openFileDialog.FileOk += Ofd_FileChosen;
            _openFileDialog.ShowDialog();
        }

        private void Ofd_FileChosen(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            
            LoadSingleSong(_openFileDialog.FileName);
        }

        private void LoadSingleSong(string localPath)
        {
            try
            {
                playerView1.LoadFile(localPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }


    }
}