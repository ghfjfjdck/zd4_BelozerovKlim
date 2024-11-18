using NaturalNumsLib;

namespace NaturalNumsTest
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void TwoIsEvenNuber() // (eng) "2 - четное число"
        {
            // вызываем наш метод, чтобы получить фактический результат
            bool Result = NaturalNumbers.IsEven(2);
            // сравниваем с ожидаемым значением
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void FiveIsOdd() // 5 - нечетное
        {
            bool Result = NaturalNumbers.IsEven(5);
            // обратите внимание!
            // правильная работа функции должна дать для 5 значение false
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void Value2020IsEven() // значение 2020 - четное
        {
            bool Result = NaturalNumbers.IsEven(2020);
            Assert.IsTrue(Result);
        }
    }
}