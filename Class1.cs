using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input3point7and4point8_Returns8point5()
        {

            //Arrange
            double number1 = 3.7;
            double number2 = 4.8;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetAddition_Input6point4and9point6_Returns16point0()
        {

            //Arrange
            double number1 = 6.4;
            double number2 = 9.6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetAddition_Input12point4and20point8_Returns33point2()
        {

            //Arrange
            double number1 = 12.4;
            double number2 = 20.8;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetMultiplication_Input18point0and5point0_Returns90point0()
        {

            //Arrange
            double number1 = 18.0;
            double number2 = 5.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetMultiplication_Input13point3and25point4_Returns337point82()
        {

            //Arrange
            double number1 = 13.3;
            double number2 = 25.4;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetMultiplication_Input2point3and6point4_Returns15point0()
        {

            //Arrange
            double number1 = 2.5;
            double number2 = 6.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetDivision_Inpu15point0and3point0_Returns5point0()
        {

            //Arrange
            double number1 = 15.0;
            double number2 = 3.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetDivision_Input12point0and2point0_Returns6point0()
        {

            //Arrange
            double number1 = 12.0;
            double number2 = 2.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetDivision_Input100point0and20point0_Returns5point0()
        {

            //Arrange
            double number1 = 100.0;
            double number2 = 20.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetSubtraction_Input5point0and3point0_Returns2point0()
        {

            //Arrange
            double number1 = 5.0;
            double number2 = 3.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }





        [Test]
        public void GetSubtraction_Input13point5and7point5_Returns6point0()
        {

            //Arrange
            double number1 = 13.5;
            double number2 = 7.5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetSubtraction_Input30point0and23point0_Returns7point0()
        {

            //Arrange
            double number1 = 30.0;
            double number2 = 23.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input2point0and1point0_Returns2point0()
        {

            //Arrange
            double number1 = 2.0;
            double number2 = 1.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetDivision_Input1point0and3point0_Returns3point0()
        {

            //Arrange
            double number1 = 1.0;
            double number2 = 3.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }




        [Test]
        public void GetDivision_Input9point0and3point0_Returns3point0()
        {

            //Arrange
            double number1 = 9.0;
            double number2 = 3.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
