using MuziekSpelerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuziekSpelerControls.Events
{
    public class MusicChangedEventArgs : EventArgs
    {
        public Music? NewMusic { get; set; }
    }
}
