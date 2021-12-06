using MuziekSpelerLib.Contracts;

namespace MuziekSpelerLib
{
    public class Playlist
    {
        public Playlist(List<Music> musicList)
        {
            _musicList = musicList;
        }

        private List<Music> _musicList;
        public List<Music> MusicList
        {
            get { return _musicList; }
        }


        private int _currentIndex;
        public Music Current
        {
            get { return _musicList[_currentIndex]; }
        }

        public MusicPlayerOperationResult Next()
        {
            try
            {
                _currentIndex++;
                return new MusicPlayerOperationResult(hasSucceeded: true, relatedMusic: _musicList[_currentIndex]);
            }
            catch (IndexOutOfRangeException)
            {
                _currentIndex = 0;
                return new MusicPlayerOperationResult(true, "The boundary of the playlist has been reached. Jumped.");
            }
            catch (InvalidOperationException ex)
            {
                return new MusicPlayerOperationResult(false, "The playlist is empty.", ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public MusicPlayerOperationResult Previous()
        {
            try
            {
                _currentIndex--;
                return new MusicPlayerOperationResult(hasSucceeded: true, relatedMusic: _musicList[_currentIndex]);
            }
            catch (IndexOutOfRangeException)
            {
                _currentIndex = _musicList.Count - 1;
                return new MusicPlayerOperationResult(true, "The boundary of the playlist has been reached. Jumped.");
            }
            catch (InvalidOperationException ex)
            {
                return new MusicPlayerOperationResult(false, "The playlist is empty.", ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
