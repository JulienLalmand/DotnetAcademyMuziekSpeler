using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuziekSpelerLib.Events
{
    public class MusicPlayingTickEventArgs
    {
        public Music CurrentMusic { get; set; }
        public TimeSpan CurrentTime { get; set; }
    }
}
