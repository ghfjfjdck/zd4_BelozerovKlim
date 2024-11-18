using NaturalNumsLib;

namespace NaturalNumsTest
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void TwoIsEvenNuber() // (eng) "2 - ������ �����"
        {
            // �������� ��� �����, ����� �������� ����������� ���������
            bool Result = NaturalNumbers.IsEven(2);
            // ���������� � ��������� ���������
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void FiveIsOdd() // 5 - ��������
        {
            bool Result = NaturalNumbers.IsEven(5);
            // �������� ��������!
            // ���������� ������ ������� ������ ���� ��� 5 �������� false
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void Value2020IsEven() // �������� 2020 - ������
        {
            bool Result = NaturalNumbers.IsEven(2020);
            Assert.IsTrue(Result);
        }
    }
}