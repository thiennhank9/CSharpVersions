using System;
using _2AnonymousMethod;
using _2GenericClass;
using _2Iterator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2Test
{
    [TestClass]
    public class _2TestAnonymousMethod
    {
        [TestMethod]
        public void Test_AnonymousMethod()
        {
            string actual = DoAnonymousMethod.doAnonymousMethod("hello");
            Assert.AreEqual("hello", actual, "failed");
        }

        [TestMethod]
        public void Test_GenericClass()
        {
            TestGenericClass<int> intGeneric = new TestGenericClass<int>(3);

            for (int i = 0; i < 3; i++)
            {
                intGeneric.setItem(i, i);
                Assert.AreEqual(intGeneric.getItem(i), i);
            }
        }

        [TestMethod]
        public void Test_Interator()
        {
            int actual = 3;
            foreach (int number in DoInterator.SomeNumbers())
            {
                Assert.AreEqual(number, actual);
                actual += 2;
            }
        }
    }
}
