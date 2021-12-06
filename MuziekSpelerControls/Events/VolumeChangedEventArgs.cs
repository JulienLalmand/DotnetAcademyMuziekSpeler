using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuziekSpelerLib.Events
{
    public class VolumeChangedEventArgs : EventArgs
    {
        public int NewVolume { get; set; }
    }
}
