using NaturalNumsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumsTest
{
    [TestClass]
    public class GcdTests
    {
        [TestMethod]
        public void SameValues()
        {
            // ожидаемое значение
            int Expected = 888;
            // фактическое значение, результат работы разработанного метода
            int Actual = NaturalNumbers.GCD(888, 888);
            // тест пройден, если они совпали
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestAnyNumberAndOne()
        {
            
            int Expected = 1; // Ожидаемый НОД, когда одно из чисел равно 1

            
            int Actual = NaturalNumbers.GCD(100, 1); // Вызов функции GCD с числами 100 и 1

            
            Assert.AreEqual(Expected, Actual); // Проверка, что НОД равен 1
        }

        [TestMethod]
        public void TestOneNumberIsDivisorOfTheOther()
        {
            
            int Expected = 15; // Ожидаемый НОД (15 является делителем 45)

            
            int Actual = NaturalNumbers.GCD(45, 15); // Вызов функции GCD с числами 45 и 15

            
            Assert.AreEqual(Expected, Actual); // Проверка, что НОД равен 15
        }

        [TestMethod]
        public void TestMirrorCase()
        {
            
            int Expected = 15; // Ожидаемый НОД (то же самое, что и выше, но порядок чисел изменен)

            
            int Actual = NaturalNumbers.GCD(15, 45); // Вызов функции GCD с числами 15 и 45


            Assert.AreEqual(Expected, Actual); // Проверка, что НОД равен 15
        }

        [TestMethod]
        public void TestGCDNotOneOfTheNumbers()
        {
            
            int Expected = 8; // Ожидаемый НОД (8 не равно ни 24, ни 32)

            
            int Actual = NaturalNumbers.GCD(24, 32); // Вызов функции GCD с числами 24 и 32


            Assert.AreEqual(Expected, Actual); // Проверка, что НОД равен 8
        }

        [TestMethod]
        public void TestRelativelyPrimeNumbers()
        {
            
            int Expected = 1; // Ожидаемый НОД для взаимно простых чисел

            
            int Actual = NaturalNumbers.GCD(49, 50); // Вызов функции GCD с числами 49 и 50


            Assert.AreEqual(Expected, Actual); // Проверка, что НОД равен 1
        }

        [TestMethod]
        public void TestZero()
        {
            
            int Expected = 12; // Ожидаемый НОД, когда одно из чисел равно 0

            
            int Actual = NaturalNumbers.GCD(0, 12); // Вызов функции GCD с числами 0 и 12


            Assert.AreEqual(Expected, Actual); // Проверка, что НОД равен 12
        }

        [TestMethod]
        public void TestNegativeNumbers()
        {
            
            
            int Expected = -3; // Ожидаемый НОД 

           
            int Actual = NaturalNumbers.GCD(-9, 6); // Вызов функции НОД с числами -9 и 6

            
            Assert.AreEqual(Expected, Actual); // Проверка, что НОД равен -3
        }

    }
}
