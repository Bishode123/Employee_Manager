using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee_Manager;
namespace Employee_Manager_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Manager m1 = new Manager();
            bool result = m1.manage();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Manager m1 = new Manager();
            bool result = m1.manage();
            Assert.AreEqual(false, result);
        }
    }
}
