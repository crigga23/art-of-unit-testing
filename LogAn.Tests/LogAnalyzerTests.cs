using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LogAn.Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            // arrange
            LogAnalyzer analyzer = new LogAnalyzer();
            // act
            bool result = analyzer.IsValidLogFileName("whatever.slf");
            // assert
            Assert.IsTrue(result);
        }
    }
}
