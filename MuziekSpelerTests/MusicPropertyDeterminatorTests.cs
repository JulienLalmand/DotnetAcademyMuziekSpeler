using MuziekSpelerLib;
using MuziekSpelerLib.Domain;
using MuziekSpelerLib.Helpers;
using System;
using Xunit;

namespace MuziekSpelerTests
{
    public class MusicPropertyDeterminatorTests
    {
        [Fact]
        public void Should_be_able_to_fetch_author()
        {
            MusicProperties properties = MusicPropertyDeterminator.Determine(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            Assert.Equal("Kevin MacLeod", properties.Author);
        }

        [Fact]
        public void Should_be_able_to_fetch_duration()
        {
            MusicProperties properties = MusicPropertyDeterminator.Determine(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            Assert.Equal<int>(TimeSpan.FromSeconds(52).Seconds, properties.Duration.Seconds);
        }

        [Fact]
        public void Should_be_able_to_fetch_album()
        {
            MusicProperties properties = MusicPropertyDeterminator.Determine(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            Assert.Equal("YouTube Audio Library", properties.Album);
        }

        [Fact]
        public void Should_be_able_to_fetch_title()
        {
            MusicProperties properties = MusicPropertyDeterminator.Determine(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            Assert.Equal("Impact Moderato", properties.Title);
        }



    }
}