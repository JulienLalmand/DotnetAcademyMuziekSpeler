using MuziekSpelerLib.Events;
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
    public partial class PlayerControlsView : UserControl
    {

        public event EventHandler? OnPlayClicked;
        public event EventHandler? OnPauseClicked;
        public event EventHandler? OnStopClicked;
        public event EventHandler<VolumeChangedEventArgs>? OnVolumeChanged;
        public event EventHandler<MediaTrackbarChangedEventArgs>? OnMediaTrackbarChanged;

        public PlayerControlsView()
        {
            InitializeComponent();
        }

        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            lblVolume.Text = $"{tbVolume.Value.ToString()}%";
            OnVolumeChanged?.Invoke(this, new VolumeChangedEventArgs() { NewVolume = tbVolume.Value });
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OnPlayClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            OnPauseClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            OnStopClicked?.Invoke(this, EventArgs.Empty);
        }

        delegate void SetProgressBarValueCallback(int progress);
        delegate void SetTimeSpanStringCallback(TimeSpan time);

        public void SetProgressBarValue(int progress)
        {
            if(tbMusicProgress.InvokeRequired)
            {
                SetProgressBarValueCallback c = new SetProgressBarValueCallback(SetProgressBarValue);
                this.Invoke(c, new object[] { progress });
            }
            else
            {
                if (progress <= 100)
                {
                    tbMusicProgress.Value = progress;
                }
            }
        }

        public void SetTimeSpanString(TimeSpan time)
        {
            if(lblCurrentTime.InvokeRequired)
            {
                SetTimeSpanStringCallback c = new SetTimeSpanStringCallback(SetTimeSpanString);
                this.Invoke(c, new object[] { time });
            }
            else
            {
                lblCurrentTime.Text = time.ToString(@"hh\:mm\:ss");
            }
        }

        private void tbMusicProgress_Scroll(object sender, EventArgs e)
        {
            OnMediaTrackbarChanged?.Invoke(this, new MediaTrackbarChangedEventArgs() { NewValue = tbMusicProgress.Value });
        }
    }
}
