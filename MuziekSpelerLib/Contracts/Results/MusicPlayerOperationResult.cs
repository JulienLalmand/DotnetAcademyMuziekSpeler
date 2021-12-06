namespace MuziekSpelerLib.Contracts
{
    public class MusicPlayerOperationResult : IApplicationResult
    {
        private bool _hasSucceeded;
        public bool HasSucceeded
        {
            get { return _hasSucceeded; }
        }

        private string _reason;
        public string Reason
        {
            get { return _reason; }
        }

        private Exception _relatedException;
        public Exception RelatedException
        {
            get { return _relatedException; }
        }

        private Music _relatedMusic;
        public Music RelatedMusic
        {
            get { return _relatedMusic; }
            set { _relatedMusic = value; }
        }

        public MusicPlayerOperationResult(bool hasSucceeded, string reason = "", Exception relatedException = null, Music relatedMusic = null)
        {
            _hasSucceeded = hasSucceeded;
            _reason = reason;
            _relatedException = relatedException;
            _relatedMusic = relatedMusic;
        }

    }
}
