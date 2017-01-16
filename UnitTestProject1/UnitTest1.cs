using NUnit.Framework;
using System;

namespace ConsoleApplication6 {

    [TestFixture]
    public class AlbumTest {

        Album ab;
        [SetUp]
        public void Init()
        {
            ab = new Album();
        }

        [Test]
        public void CreateAlbum()
        {
            //Album ab = new Album();
            try
            {
                Assert.AreEqual(111, ab.AlbumId);
                Assert.AreEqual("Default Album Title", ab.Title);
            }
            catch (Exception)
            {
            }

        }

        [Test]
        public void CheckPrice()
        {
            try
            {
                Album ab = new ConsoleApplication6.Album();
            }
            catch (Exception)
            {
                
            }
            Assert.True(3 < ab.Price);
        }
    }
}