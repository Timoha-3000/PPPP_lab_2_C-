
using System;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Program_brenching_1_returned()
        {
            //Arrange
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 0;
            double f = 0;
            double expected = 5;
            

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            foreach (var item in actual)
            {
                Assert.Equal(expected, item);
            }
        }
        [Fact]
        public void Program_brenching_2_returned()
        {
            //Arrange
            double a = 1;
            double b = 2;
            double c = 3;
            double d = 4;
            double e = 5;
            double f = 6;
            List<double> expected = new List<double>() { 2, -4, 4.5};

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_3_1_returned()
        {
            //Arrange
            double a = 1;
            double b = 2;
            double c = 2;
            double d = 4;
            double e = 5;
            double f = 6;
            List<double> expected = new List<double>() { 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_3_2_returned()
        {
            //Arrange
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 5;
            double f = 6;
            List<double> expected = new List<double>() { 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_4_returned()
        {
            //Arrange
            double a = 0;
            double b = 2;
            double c = 0;
            double d = 4;
            double e = 0;
            double f = 6;
            List<double> expected = new List<double>() { 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_4_1_returned() // предпоследнее
        {
            //Arrange
            double a = 1;
            double b = 2;
            double c = 2;
            double d = 4;
            double e = 2;
            double f = 4;
            List<double> expected = new List<double>() { 1, -0.5, 1 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_4_2_returned()
        {
            //Arrange
            double a = 0;
            double b = 2;
            double c = 0;
            double d = 4;
            double e = 5;
            double f = 6;
            List<double> expected = new List<double>() { 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_4_3_returned()
        {
            //Arrange
            double a = 1;
            double b = 0;
            double c = 2;
            double d = 0;
            double e = 5;
            double f = 6;
            List<double> expected = new List<double>() { 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_5_returned()
        {
            //Arrange
            double a = 3;
            double b = 0;
            double c = 4;
            double d = 0;
            double e = 0;
            double f = 0;
            List<double> expected = new List<double>() { 3, 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_6_returned()
        {
            //Arrange
            double a = 0;
            double b = 0;
            double c = 2;
            double d = 0;
            double e = 1;
            double f = 0;
            List<double> expected = new List<double>() { 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_7_returned()
        {
            //Arrange
            double a = 3;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 0;
            double f = 0;
            List<double> expected = new List<double>() { 3, 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_8_returned() // -
        {
            //Arrange
            double a = 0;
            double b = 3;
            double c = 0;
            double d = 3;
            double e = 0;
            double f = 0;
            List<double> expected = new List<double>() { 4, 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_9_returned() 
        {
            //Arrange
            double a = 0;
            double b = 0;
            double c = 3;
            double d = 6;
            double e = 0;
            double f = 6;
            List<double> expected = new List<double>() { 3, -0.5, 1 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_10_returned() // -
        {
            //Arrange
            double a = 0;
            double b = 5;
            double c = 0;
            double d = 0;
            double e = 5;
            double f = 0;
            List<double> expected = new List<double>() { 3, 1};

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_11_returned() // -
        {
            //Arrange
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 8;
            double e = 0;
            double f = 8;
            List<double> expected = new List<double>() { 3, 1 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_10_1_returned()
        {
            //Arrange
            double a = 3;
            double b = 3;
            double c = 4;
            double d = 0;
            double e = 0;
            double f = 0;
            List<double> expected = new List<double>() { 1, -1, 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_11_1_returned()
        {
            //Arrange
            double a = 0;
            double b = 3;
            double c = 4;
            double d = 2;
            double e = 0;
            double f = 0;

            List<double> expected = new List<double>() { 1, -0.5, 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Program_brenching_12_returned()
        {
            //Arrange
            double a = 4;
            double b = 3;
            double c = 0;
            double d = 2;
            double e = 0;
            double f = 0;
            List<double> expected = new List<double>() { 1, -0.75, 0 };

            //Act
            List<double> actual = new List<double>();
            Program.MainLogic(a, b, c, d, e, f, actual);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}