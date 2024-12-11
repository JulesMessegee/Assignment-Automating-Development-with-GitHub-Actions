using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello, World!", HelloWorld.Program.GetGreeting());
        }
    }
}