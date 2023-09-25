using net_calculator_tester;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAdd()
        {

            float x = 5.0f;
            float y = 3.0f;
            float expectedResult = 8.0f;

            // Act
            float result = Calculator.Add(x, y);


            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestAddWithNegativeNumber()
        {
            // Arrange
            float x = -2.5f;
            float y = 1.5f;
            float expectedResult = -1.0f;

            // Act
            float result = Calculator.Add(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void TestSubtraction()
        {
            // Arrange
            float x = 10.0f;
            float y = 3.0f;
            float expectedResult = 7.0f;

            // Act
            float result = Calculator.Subtract(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void TestSubtractionWithNegativeNumbers()
        {
            // Arrange
            float x = -5.0f;
            float y = -2.0f;
            float expectedResult = -3.0f;

            // Act
            float result = Calculator.Subtract(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestMultiplication()
        {
            // Arrange
            float x = 4.0f;
            float y = 5.0f;
            float expectedResult = 20.0f;

            // Act
            float result = Calculator.Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestMultiplicationWithNegativeNumbers()
        {
            // Arrange
            float x = -3.0f;
            float y = 2.0f;
            float expectedResult = -6.0f;

            // Act
            float result = Calculator.Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestMultiplicationWithZero()
        {
            // Arrange
            float x = 8.0f;
            float y = 0.0f;
            float expectedResult = 0.0f;

            // Act
            float result = Calculator.Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestDivision()
        {
            // Arrange
            float x = 10.0f;
            float y = 2.0f;
            float expectedResult = 5.0f;

            // Act
            float result = Calculator.Divide(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void TestDivisionWithNegativeNumbers()
        {
            // Arrange
            float x = -6.0f;
            float y = 3.0f;
            float expectedResult = -2.0f;

            // Act
            float result = Calculator.Divide(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestDivisionByZero()
        {
            // Arrange
            float x = 8.0f;
            float y = 0.0f;

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(x, y), "non puoi dividere un numero per zero, CAPRA!");
        }
    }
}