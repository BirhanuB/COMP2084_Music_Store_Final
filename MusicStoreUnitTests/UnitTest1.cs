using COMP2084_MusicStore.Controllers;
using COMP2084_MusicStore.Models;
using System;
using Xunit;

namespace MusicStoreUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //SongsController sc = new SongsController();
            Assert.Throws<InvalidOperationException>(
                () =>
            {
                Song s = new Song();
                s.Price = -1;

            });
        }
    }
    public class UnitTest2
    {
        [Fact]
        public void Test2()
        {

        }
    }
    public class UnitTest3
    {
        [Fact]
        public void Test3()
        {

        }
    }
}
