using System;
using _3AutoImplementProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3Test
{
    [TestClass]
    public class Test3
    {
        delegate int del(int i);

        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer(40.0, "nhan", 1);
            customer.TotalPurchases += 40.0;
            Assert.AreEqual(customer.TotalPurchases, 80.0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Assert.AreEqual(j, 25);
        }
        
    }
}
