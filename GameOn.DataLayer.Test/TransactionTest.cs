using System;
using System.Linq;
using GameOn.DataLayer.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOn.DataLayer.Test
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void TestAlive()
        {
            var manager = new UserManager();
            var users = manager.GetList();
            Assert.IsTrue(users.Count > 0);
        }
    }
}
