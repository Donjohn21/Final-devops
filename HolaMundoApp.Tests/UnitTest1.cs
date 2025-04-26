using Xunit;
using System.IO;
using System;

namespace HolaMundoApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestHolaMundo()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(new string[0]);
                var result = sw.ToString().Trim();
                Assert.Equal("Hola Mundo!", result);
            }
        }
    }
}
