using MuziekSpelerLib.Contracts;
using MuziekSpelerLib.Events;
using MuziekSpelerLib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MuziekSpelerLib.Domain
{
    public class Player
    {
        private readonly WindowsMediaPlayer _windowsMediaPlayer;
        private System.Timers.Timer _timer;
        public event EventHandler<MusicPlayingTickEventArgs> OnWhilePlayingTick;
        private static string[] __SUPPORTED_FORMATS =
        {
            ".MP3"
        };

        public Player()
        {
            _windowsMediaPlayer = new WindowsMediaPlayer();
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += _timer_Tick;
            _timer.Enabled = true;
            _timer.Start();
        }
            
        private void _timer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(_isPlaying && _currentMusic != null)
            {
                OnWhilePlayingTick?.Invoke(this, new MusicPlayingTickEventArgs() { CurrentTime = this.CurrentTime, CurrentMusic = _currentMusic });
            }
        }

        public void LoadFile(string filePath)
        {
            try
            {
                if(!File.Exists(filePath))
                {
                    throw new FileNotFoundException();
                }

                if (!__SUPPORTED_FORMATS.Contains(Path.GetExtension(filePath).ToUpper()))
                {
                    throw new FileFormatException();
                }

                var music = new Music(filePath, MusicPropertyDeterminator.Determine(filePath), new FileInfo(filePath));

                _currentMusic = music;
                _windowsMediaPlayer.URL = filePath;
                _isPlaying = true;

            }
            catch(FileNotFoundException)
            {
                throw;
            }
            catch(FileFormatException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw new FileLoadException($"Could not load the provided file at {filePath}.", ex);
            }
        }


        private Music _currentMusic;

        public Music CurrentMusic
        {
            get { return _currentMusic; }
        }

        public TimeSpan CurrentTime
        {
            get { return TimeSpan.FromSeconds(_windowsMediaPlayer.controls.currentPosition); }
        }

        private bool _isPlaying;

        public bool IsPlaying
        {
            get { return _isPlaying; }
        }

        public MusicPlayerOperationResult Play()
        {
            if (_currentMusic is not null)
            {
                _isPlaying = true;
                _windowsMediaPlayer.controls.play();
                return new MusicPlayerOperationResult(true);
            }
            else
            {
                return new MusicPlayerOperationResult(false, "No music is currently loaded.");
            }
        }

        public void Pause()
        {
            if(_currentMusic != null)
            {
                _isPlaying = false;
                _windowsMediaPlayer.controls.pause();
            }
        }

        public void Stop()
        {
            _windowsMediaPlayer.controls.stop();
            _isPlaying = false;
        }

        public void SetProgress(double percentage)
        {
            try
            {
                if(_currentMusic is not null && percentage >= 0 && percentage <= 100)
                {
                    double p1 = Convert.ToDouble(_currentMusic.Properties.Duration.Seconds) / 100;
                    double p2 = p1 * Convert.ToDouble(percentage);
                    _windowsMediaPlayer.controls.currentPosition = Convert.ToInt32(p2);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Volume
        {
            get { return _windowsMediaPlayer.settings.volume; }
            set { _windowsMediaPlayer.settings.volume = value; }
        }



    }
}
