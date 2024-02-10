using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest_Class1_Summa
    {
        [TestMethod]
        public void TestMethod_summa_areEqual()
        {
            Class1 cl = new ClassLibrary.Class1();
            int result = cl.summa(2, 5);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMethod_summa_areNotEqual()
        {
            Class1 cl = new Class1();
            int result = cl.summa(2, 5);

            Assert.AreNotEqual(5, result);
        }
    }

    [TestClass]
    public class UnitTest_Class1_Difference
    {
        [TestMethod]
        public void TestMethod_difference_areEqual()
        {
            Class1 cl = new ClassLibrary.Class1();
            int result = cl.difference(5, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod_difference_areNotEqual()
        {
            Class1 cl = new Class1();
            int result = cl.difference(5, 2);

            Assert.AreNotEqual(7, result);
        }
    }
}
