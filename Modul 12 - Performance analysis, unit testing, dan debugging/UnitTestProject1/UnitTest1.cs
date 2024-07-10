using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tpmodul12_1302223074;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CariTandaBilangan_Positif()
        {
            // Arrange
            int input = 3;
            string expected = "Positif";
            Form1 form = new Form1();

            // Act
            string actual = form.CariTandaBilangan(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CariTandaBilangan_Negatif()
        {
            // Arrange
            int input = -5;
            string expected = "Negatif";
            Form1 form = new Form1();

            // Act
            string actual = form.CariTandaBilangan(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CariTandaBilangan_Nol()
        {
            // Arrange
            int input = 0;
            string expected = "Nol";
            Form1 form = new Form1();

            // Act
            string actual = form.CariTandaBilangan(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
