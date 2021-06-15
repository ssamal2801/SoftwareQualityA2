using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareQualityA2.Test
{
    [TestClass]
    public class RectangleTest
    {
        //Cheching default constructor. Default Length and
        //Width value set to 5 in constructor so test should return 5
        [TestMethod]        
        public void CheckDefaultConstructor()
        {
            // arrange
            Rectangle rectangle = new Rectangle();

            // act            
            //Nill

            // assert
            Assert.AreEqual(5, rectangle.GetLength());
            Assert.AreEqual(5, rectangle.GetWidth());
        }

        
        [TestMethod]//Checking parametrised constructor.
        public void CheckParametrisedConstructor()
        {
            // arrange
            var rectangle = new Rectangle(10, 7);

            // act            
            //Nill

            // assert
            Assert.AreEqual(10, rectangle.GetLength());
            Assert.AreEqual(7, rectangle.GetWidth());
        }

       [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void ConstructorShouldNotTakeWidthZero()
        {
            // arrange
            var rectangle = new Rectangle(5, 0);

            // act
            // Nill

            // assert
            // Nill
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void ConstructorShouldNotTakeLengthZero()
        {
            // arrange
            var rectangle = new Rectangle(0, 5);

            // act
            //Nill

            // assert
            //  Nill
        }

        
        [TestMethod]// checking if GetArea() function works fine.
        public void GetAreaTest()
        {
            //Arrange
            int length = 5, width = 5;
            int result = length * width;
            var rectangle = new Rectangle(length, width);

            //Act
            int getFuncResult = rectangle.GetArea();

            //Assert
            Assert.AreEqual(result, getFuncResult);
        }

        [TestMethod] //GetArea() Should return Integer when fed in Integer
        public void GetAreaTestForReturnType()
        {
            //Arrange 
            int length = 5, width = 5;
            var rectangle = new Rectangle(length, width);

            //Act
            int actualResult = rectangle.GetArea();

            //Assert
            Assert.IsInstanceOfType(actualResult, typeof(int));
        }


        
        [TestMethod]//Checking if GetPerimeter() function works fine.
        public void GetPerimeterTest()
        {
            //Arrange
            int length = 5, width = 5;
            int shoudGet = 2 * (length + width);
            var rectangle = new Rectangle(length, width);

            //Act
            int getting = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(shoudGet, getting);
        }

        [TestMethod]//Passing two integers should return integer.
        public void GetPerimeterRetrnTypeTest()
        {
            int length = 5, width = 5;
            var rectangle = new Rectangle(length, width);

            //Act
            int actualResult = rectangle.GetPerimeter();

            //Assert
            Assert.IsInstanceOfType(actualResult, typeof(int));
        }


        [TestMethod]//Check if GetLength() Method is working.
        public void GetLengthTest()
        {
            //Arrange            
            var rectangle = new Rectangle(5, 5);

            //Act
            int getLength = rectangle.GetLength();

            //Assert
            Assert.AreEqual(5, getLength);
        }

        [TestMethod]//Check if GetLength() return type is int.
        public void GetLengthReturnTypeTest()
        {
            //Arrange            
            var rectangle = new Rectangle(5, 5);

            //Act
            int getLength = rectangle.GetLength();

            //Assert
            Assert.IsInstanceOfType(getLength, typeof(int));
        }


        [TestMethod]//Check if SetLength() Works
        public void SetLengthTest()
        {
            //Arrange            
            var rectangle = new Rectangle();

            //Act
            int actualResult = rectangle.SetLength(5);

            //Assert
            Assert.AreEqual(5, actualResult);
        }

        [TestMethod]//SetLength() return type test.
        public void SetLengthReturnTypeTest()
        {
            //Arrange            
            var rectangle = new Rectangle();

            //Act
            int result = rectangle.SetLength(5);

            //Assert
            Assert.IsInstanceOfType(result, typeof(int));
        }

        [TestMethod]//Set method shouldn't update data if value is 0
        public void SetLengthUpdateTest()
        {
            //Arrange            
            var rectangle = new Rectangle(5, 5);

            //Act
            int result = rectangle.SetLength(0);

            //Assert
            Assert.AreEqual(5, result);
        }


        [TestMethod]//CHeck if GetWidth() works.
        public void GetWidthTest()
        {
            int width = 5;

            //Arrange            
            var rectangle = new Rectangle(5, width);

            //Act
            int result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, result);
        }

        [TestMethod]//Check if GetWidth() return type is int.
        public void GetWidth_InputInteger_ReturnsInteger()
        {
            int width = 5;

            //Arrange            
            var rectangle = new Rectangle(5, width);

            //Act
            int result = rectangle.GetWidth();

            //Assert
            Assert.IsInstanceOfType(result, typeof(int));
        }


        [TestMethod]//Check if SetWidth() works.
        public void SetWidth_Input6_Returns6()
        {
            //Arrange            
            var rectangle = new Rectangle();

            //Act
            int actualResult = rectangle.SetWidth(6);

            //Assert
            Assert.AreEqual(6, actualResult);
        }

        [TestMethod]//Check if SetWidth() returns integer.
        public void SetWidthReturnTypeTest()
        {
            //Arrange            
            var rectangle = new Rectangle();

            //Act
            int result = rectangle.SetWidth(5);

            //Assert
            Assert.IsInstanceOfType(result, typeof(int));
        }

        [TestMethod]//Check if update method takes in 0.
        public void SetWidth_InputValueLessThan1_ReturnsTheLastValidValue()
        {
            //Arrange            
            var rectangle = new Rectangle(5, 5);

            //Act
            int result = rectangle.SetWidth(0);

            //Assert
            Assert.AreEqual(5, result);
        }
    }
}
