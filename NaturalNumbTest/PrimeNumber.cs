using NaturalNumsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumsTest
{
    [TestClass]
    public class PrimeNumber
    {
        [TestMethod]
        public void TestIsPrime_1()
        {
            
            bool expected = true; // Ожидаемое значение: true (2 - простое число)

           
            bool actual = NaturalNumbers.IsPrime(2);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsPrime_2()
        {
            
            bool expected = true; // Ожидаемое значение: true (3 - простое число)

            
            bool actual = NaturalNumbers.IsPrime(3);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsPrime_3()
        {
            
            bool expected = false; // Ожидаемое значение: false (4 - составное число)

            
            bool actual = NaturalNumbers.IsPrime(4);

            
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestIsPrime_997()
        {
            
            bool expected = true; // Ожидаемое значение: true (997 - простое число)

            
            bool actual = NaturalNumbers.IsPrime(997);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsPrime_1000()
        {
            
            bool expected = false; // Ожидаемое значение: false (1000 - составное число)

            
            bool actual = NaturalNumbers.IsPrime(1000);

            
            Assert.AreEqual(expected, actual);
        }

    }
}
