namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        public Lommeregner.Caculator calculator = new Lommeregner.Caculator();

        [TestMethod]
        public void TestAdd()
        {
                Assert.AreEqual(5, calculator.Add(2, 3));
        }

        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(-1, calculator.Subtract(2, 3));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(0.6666666666666666, calculator.Divide(2, 3));
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(2, 0));
        }
    }
}
