using MuziekSpelerLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MuziekSpelerLib.Helpers
{
    public static class MusicPropertyDeterminator
    {
        public static MusicProperties Determine(string filePath)
        {
            //Verify the path once again since this is a library
            if(!System.IO.File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            var tFile = TagLib.File.Create(filePath);

            return new MusicProperties
            {
                Title = tFile.Tag.Title,
                Album = tFile.Tag.Album,
                Author = tFile.Tag.FirstPerformer,
                Duration = tFile.Properties.Duration
            };
        }
    }
}
