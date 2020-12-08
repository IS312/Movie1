using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movie1.DataBaseOperations;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SqlConnection sql = Connection.StartConnection();
            bool conStatus = sql != null;
            Assert.AreEqual(true, conStatus);
        }
    }
}
