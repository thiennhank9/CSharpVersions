using System;
using _2GenericDelegate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2TestGenericDelegate
{
    [TestClass]
    public class TestGenericDelegate
    {
        [TestMethod]
        public void TestGetNum()
        {
            int expectNum = GenericDelegate.getNum();

            Assert.AreEqual(10, expectNum);
        }

        [TestMethod]
        public void TestSetNum()
        {
            GenericDelegate.setNumber(10);
            int expectNum = GenericDelegate.getNum();

            Assert.AreEqual(10, expectNum);
        }

        [TestMethod]
        public void TestAddNum()
        {
            GenericDelegate.setNumber(10);
            int expectNum = GenericDelegate.AddNum(12);

            Assert.AreEqual(22, expectNum);
        }

        [TestMethod]
        public void TestMultNum()
        {
            GenericDelegate.setNumber(10);
            int expectNum = GenericDelegate.MultNum(1);

            Assert.AreEqual(10, expectNum);
        }
    }
}
