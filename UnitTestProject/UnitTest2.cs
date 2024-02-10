using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest_Class2
    {
        [TestMethod]
        public void TestMethod_List()
        {
            ClassLibrary.Class2 cl = new ClassLibrary.Class2();

            List<string> result;
            List<string> test = new List<string> { "A", "B", "C" };

            result = cl.ListWithLetters();

            CollectionAssert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethod_Bool_True()
        {
            ClassLibrary.Class2 cl = new ClassLibrary.Class2();
            bool result = cl.FuncReturnTrueOrFalse(1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_Bool_False()
        {
            ClassLibrary.Class2 cl = new ClassLibrary.Class2();
            bool result = cl.FuncReturnTrueOrFalse(0);

            Assert.IsFalse(result);
        }
    }
}
