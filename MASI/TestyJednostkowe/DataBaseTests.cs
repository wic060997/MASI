using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniterm;

namespace TestyJednostkowe
{
    [TestClass()]
    public class DataBaseTests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            var db = new DataBase();
            Assert.IsNotNull(db);
            Assert.IsTrue(db.Connect());
        }

        [TestMethod()]
        [ExpectedException(typeof(SqlException))]
        public void ConnectTest_NonExistingDb_Throws()
        {
            string conString = @"Data Source=LAPTOP-B6QNMRB5\SQLEXPRESS;Initial Catalog=MASITest;Integrated Security=True";


            var db = new DataBase(conString);
            Assert.IsTrue(db.Connect());
        }
    }
}
