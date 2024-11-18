using NaturalNumsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumsTest
{
    [TestClass]
    public class LCMclass
    {
        [TestMethod]
        
        public void TestLCM_1()
        {
           
            int expected = 2; // Ожидаемое значение НОК(1, 2)
            int a = 1;
            int b = 2;

            
            int actual = NaturalNumbers.LCM(a, b);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLCM_2()
        {
           
            int expected = 6; // Ожидаемое значение НОК(2, 3)
            int a = 2;
            int b = 3;

            
            int actual = NaturalNumbers.LCM(a, b);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLCM_3()
        {
            
            int expected = 35; // Ожидаемое значение НОК(5, 7)
            int a = 5;
            int b = 7;

            
            int actual = NaturalNumbers.LCM(a, b);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLCM_4()
        {
            
            int expected = 36; // Ожидаемое значение НОК(12, 18)
            int a = 12;
            int b = 18;

            
            int actual = NaturalNumbers.LCM(a, b);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLCM_5()
        {
            
            int expected = 0; // НОК с нулем всегда 0
            int a = 0;
            int b = 10;

           
            int actual = NaturalNumbers.LCM(a, b);

            
            Assert.AreEqual(expected, actual);
        }
    }
}
