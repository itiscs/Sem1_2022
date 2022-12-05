using FractionApp;
using System.Runtime.InteropServices;

namespace TestFraction
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestToString()
        {
            //Arrange
            Fraction f = new Fraction(1, 2);

            //Act
            var str = f.ToString();

            //Assert
            Assert.AreEqual(1, f.Numerator);
            Assert.AreEqual(2, f.Denominator);
            Assert.AreEqual("1/2", str);
        }

        [Test]
        public void TestFractionWithInt()
        {
            //Arrange
            Fraction f = new Fraction(20);

            //Act
            var str = f.ToString();

            //Assert
            Assert.AreEqual("20", str);
        }

        [Test]
        public void TestLessTwoFraction()
        {
            //Arrange
            Fraction f1 = new Fraction(2,3);
            Fraction f2 = new Fraction(3,4);

            //Act
            var fl = f1 > f2;

            //Assert
            Assert.IsFalse(fl);            
        }


        private void CreateFraction()
        {
            var f =  new Fraction(2, 0);
        }

        [Test]
        public void TestZeroDenom()
        {            
            Assert.Throws<ArgumentException>(CreateFraction);
        }

        private void SetDenom()
        {
            var f = new Fraction(2, 1);
            f.Denominator = 0;
        }

        [Test]
        public void TestZeroSetDenom()
        {            
            Assert.Throws<ArgumentException>(SetDenom);
        }


        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(13, 22)]
     //  [TestCase(1, 0)]
        public void TestToString(int a, int b)
        {
            //Arrange
            Fraction f = new Fraction(a, b);

            //Act
            var str = f.ToString();

            //Assert
            Assert.AreEqual(a, f.Numerator);
            Assert.AreEqual(b, f.Denominator);
            Assert.AreEqual($"{a}/{b}", str);
        }




    }
}