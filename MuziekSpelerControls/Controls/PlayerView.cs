using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuziekSpelerControls.Events;
using MuziekSpelerLib.Domain;
using MuziekSpelerLib.Events;

namespace MuziekSpelerControls.Controls
{
    public partial class PlayerView : UserControl
    {
        private readonly Player _player;
        public event EventHandler<MusicChangedEventArgs>? OnMusicChange;

        public PlayerView()
        {
            _player = new Player();
            InitializeComponent();
        }

        private void PlayerView_Load(object sender, EventArgs e)
        {
            playerControlsView.OnPlayClicked += PlayerControlsView_OnPlayClicked;
            playerControlsView.OnPauseClicked += PlayerControlsView_OnPauseClicked;
            playerControlsView.OnStopClicked += PlayerControlsView_OnStopClicked;
            playerControlsView.OnVolumeChanged += PlayerControlsView_OnVolumeChanged;
            playerControlsView.OnMediaTrackbarChanged += PlayerControlsView_OnMediaTrackbarChanged;
            _player.OnWhilePlayingTick += _player_OnWhilePlayingTick;
        }

        private void PlayerControlsView_OnMediaTrackbarChanged(object? sender, MediaTrackbarChangedEventArgs e)
        {
            try
            {
                _player.SetProgress(e.NewValue);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _player_OnWhilePlayingTick(object? sender, MusicPlayingTickEventArgs e)
        {
            //Operation to set the "hh:mm:ss" string in the view.
            playerControlsView.SetTimeSpanString(e.CurrentTime);

            //Operation to update the actual trackbar control (int 0-100 as a percentage).
            int p1 = e.CurrentTime.Seconds;
            int p2 = e.CurrentMusic.Properties.Duration.Seconds;
            decimal p3 = Decimal.Divide(Convert.ToDecimal(p1), Convert.ToDecimal(p2)) * 100;
            playerControlsView.SetProgressBarValue(Convert.ToInt32(p3));
        }

        public void LoadFile(string filePath)
        {
            try
            {
                _player.LoadFile(filePath);
                OnMusicChange?.Invoke(this, new MusicChangedEventArgs() { NewMusic = _player.CurrentMusic });
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void PlayerControlsView_OnVolumeChanged(object? sender, VolumeChangedEventArgs e)
        {
            try
            {
                _player.Volume = e.NewVolume;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlayerControlsView_OnStopClicked(object? sender, EventArgs e)
        {
            try
            {
                _player.Stop();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlayerControlsView_OnPauseClicked(object? sender, EventArgs e)
        {
            try
            {
                _player.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlayerControlsView_OnPlayClicked(object? sender, EventArgs e)
        {
            try
            {
                _player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
