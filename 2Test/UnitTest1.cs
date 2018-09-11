using System;
using _2AnonymousMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2Test
{
    [TestClass]
    public class _2TestAnonymousMethod
    {
        [TestMethod]
        public void TestMethod1()
        {
            string actual = DoAnonymousMethod.doAnonymousMethod("hello");
            Assert.AreEqual("hello", actual, "failed");
        }
    }
}
