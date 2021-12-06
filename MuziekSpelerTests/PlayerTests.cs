using MuziekSpelerLib;
using MuziekSpelerLib.Domain;
using System;
using System.IO;
using System.Timers;
using Xunit;

namespace MuziekSpelerTests
{
    public class PlayerTests
    {
  
        [Fact]
        public void Should_throw_FileNotFoundException_when_file_doesnt_exist()
        {
            Player player = new Player();
            Assert.Throws<FileNotFoundException>(() => { player.LoadFile("C:/Some/Non/Existing/Path.mp3"); });
        }

        [Fact]
        public void Should_throw_FileFormatException_when_format_is_invalid()
        {
            Player player = new Player();
            string currentDirectory = Environment.CurrentDirectory;
            Assert.Throws<FileFormatException>(() => { player.LoadFile(Environment.CurrentDirectory + "\\SampleMusic\\validmusic.mp4"); });
        }

        [Fact]
        public void Should_not_throw_anything_when_file_is_valid()
        {
            Player player = new Player();
            try
            {
                player.LoadFile(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            }
            catch(Exception ex)
            {
                Assert.True(false);
            }
            Assert.True(true);
        }

        [Fact]
        public void Should_immediately_be_playing_after_loading_music()
        {
            Player player = new Player();
            player.LoadFile(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            Assert.True(player.IsPlaying);
        }

        [Fact]
        public void Should_not_be_playing_after_pausing()
        {
            Player player = new Player();
            player.LoadFile(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            player.Pause();
            Assert.False(player.IsPlaying);
        }

        [Fact]
        public void Should_not_be_playing_after_stopping()
        {
            Player player = new Player();
            player.LoadFile(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            player.Stop();
            Assert.False(player.IsPlaying);
        }

        [Fact]
        public void Should_be_able_to_set_progress_as_percentage()
        {
            Player player = new Player();
            player.LoadFile(Environment.CurrentDirectory + "\\SampleMusic\\actuallyvalidmusic.mp3");
            //Sample song is 52 seconds. 50% should therefore set the time to 26 seconds.
            player.SetProgress(50);
            player.Pause();
            Assert.Equal<TimeSpan>(TimeSpan.FromSeconds(26), player.CurrentTime);
        }

    }
}