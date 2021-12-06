using MuziekSpelerLib;
using Xunit;

namespace MuziekSpelerTests
{
    public class MusicTests
    {
        [Fact]
        public void Should_be_equal_when_title_and_author_are_the_same()
        {
            Music a = new Music("C:/", new MuziekSpelerLib.Domain.MusicProperties() { Author = "Julien", Title = "WillekeurigeTitel" });
            Music b = new Music("D:/", new MuziekSpelerLib.Domain.MusicProperties() { Author = "Julien", Title = "WillekeurigeTitel" });

            Assert.Equal<Music>(a, b);

        }

        [Fact]
        public void Should_not_be_equal_when_title_and_author_are_different()
        {
            Music a = new Music("C:/", new MuziekSpelerLib.Domain.MusicProperties() { Author = "Julien", Title = "WillekeurigeTitel" });
            Music c = new Music("D:/", new MuziekSpelerLib.Domain.MusicProperties() { Author = "Julien", Title = "AndereTitel" });
            Music d = new Music("D:/", new MuziekSpelerLib.Domain.MusicProperties() { Author = "AndereAuthor", Title = "WillekeurigeTitel" });

            Assert.NotEqual<Music>(a, c);
            Assert.NotEqual<Music>(a, d);
        }

        [Fact]
        public void Should_be_greater_than_when_duration_is_higher()
        {
            Music a = new Music("C:/", new MuziekSpelerLib.Domain.MusicProperties() { Author = "Julien", Title = "WillekeurigeTitel", Duration = System.TimeSpan.FromSeconds(150) });
            Music b = new Music("C:/", new MuziekSpelerLib.Domain.MusicProperties() { Author = "Julien", Title = "WillekeurigeTitel", Duration = System.TimeSpan.FromSeconds(151) });

            Assert.True(b > a);
        }


    }
}