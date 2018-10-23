using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogLibary.Test
{
    [TestClass]
    public class LogLibaryTest
    {
        [TestMethod]
        public void LogError_Text_Test()
        {
            // Act, Arrange, Asset
            Log log = Log.Instance;

            log.LogToTextFile = true;
            log.LogToDatabase = false;

            Exception ex = new Exception("Test exception");
            int i = log.Error("Test error", null, ex, "");

            Assert.AreNotEqual(0, i);
        }
    }
}
