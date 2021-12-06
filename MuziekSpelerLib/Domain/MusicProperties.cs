using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuziekSpelerLib.Domain
{
    public class MusicProperties
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }

    }
}
