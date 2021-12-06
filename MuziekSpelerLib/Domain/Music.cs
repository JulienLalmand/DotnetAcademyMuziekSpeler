using MuziekSpelerLib.Domain;

namespace MuziekSpelerLib
{
    public class Music : IEquatable<Music>
    {
        private MusicProperties _musicProperties;
        private string _localPath;
        private FileInfo _fileInfo;

        public Music(string localPath, MusicProperties musicProperties, FileInfo fileInfo = null)
        {
            _musicProperties = musicProperties;
            _localPath = localPath;
            _fileInfo = fileInfo;
        }

        public event EventHandler MusicChanged;

        public FileInfo FileInfo
        {
            get { return _fileInfo; }
        }

        public MusicProperties Properties
        {
            get { return _musicProperties; }
        }


        public string LocalPath { 
            get
            {
                return _localPath;
            }
            set
            {
                _localPath = value;
                MusicChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        #region IEquatable Implementation
        public bool Equals(Music other)
        {
            if (String.IsNullOrEmpty(Properties.Title) || String.IsNullOrEmpty(Properties.Author) || String.IsNullOrEmpty(other.Properties.Title) || String.IsNullOrEmpty(other.Properties.Author))
            {
                return false;
            }
            else
            {
                return (
                    other.Properties.Title.ToUpper().Equals(Properties.Title.ToUpper()) &&
                    other.Properties.Author.ToUpper().Equals(Properties.Author.ToUpper())
                );
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Music);
        }

        public override int GetHashCode()
        {
            return (Properties.Author.GetHashCode() ^ Properties.Title.GetHashCode());
        }

        #endregion

        #region Operator overloading
        public static bool operator ==(Music a, Music b)
        {
            if((object)a == null || (object)b == null)
            {
                return true;
            }
            if (String.IsNullOrEmpty(a.Properties.Title) || String.IsNullOrEmpty(a.Properties.Author) || String.IsNullOrEmpty(b.Properties.Title) || String.IsNullOrEmpty(b.Properties.Author))
            {
                return false;
            }
            else
            {
                return (
                    a.Properties.Title.ToUpper() == b.Properties.Title.ToUpper() &&
                    a.Properties.Author.ToUpper() == b.Properties.Author.ToUpper()
                );
            }
        }
        public static bool operator !=(Music a, Music b)
        {
            if((object)a == null || (object)b == null)
            {
                return true;
            }

            if (String.IsNullOrEmpty(a.Properties.Title) || String.IsNullOrEmpty(a.Properties.Author) || String.IsNullOrEmpty(b.Properties.Title) || String.IsNullOrEmpty(b.Properties.Author))
            {
                return true;
            }
            else
            {
                return !(
                    a.Properties.Title.ToUpper() == b.Properties.Title.ToUpper() &&
                    a.Properties.Author.ToUpper() == b.Properties.Author.ToUpper()
                );
            }
        }

        public static bool operator <(Music a, Music b)
        {
            return a.Properties.Duration < b.Properties.Duration;
        }
        public static bool operator >(Music a, Music b)
        {
            return a.Properties.Duration > b.Properties.Duration;
        }

        #endregion

    }
}