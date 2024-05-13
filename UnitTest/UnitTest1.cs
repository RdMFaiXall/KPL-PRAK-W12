using modul12_1302220093;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        // deklarasi method TestNilaiPangkat1
        // untuk mengecek kondisi pada soal C poin iii
        [TestMethod]
        public void TestNilaiPangkat1()
        {
            // Arrange
            int a = 5;
            int b = 11;
            int hasilYgDiharapkan = -2;

            // Act
            int hasilDefault = Pangkat.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(hasilYgDiharapkan, hasilDefault);
        }

        // deklarasi method TestNilaiPangkat2
        // untuk mengecek kondisi pada soal C poin i
        [TestMethod]
        public void TestNilaiPangkat2()
        {
            // Arrange
            int a = 5;
            int b = 0;
            int hasilYgDiharapkan = 1;

            // Act
            int hasilDefault = Pangkat.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(hasilYgDiharapkan, hasilDefault);
        }

        // deklarasi method TestNilaiPangkat3
        // untuk mengecek kondisi pada soal C poin i
        [TestMethod]
        public void TestNilaiPangkat3()
        {
            // Arrange
            int a = 5;
            int b = -3;
            int hasilYgDiharapkan = -1;

            // Act
            int hasilDefault = Pangkat.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(hasilYgDiharapkan, hasilDefault);
        }

        // deklarasi method TestNilaiPangkat4
        // untuk mengecek kondisi pada soal C poin iv
        [TestMethod]
        public void TestNilaiPangkat4()
        {
            // Arrange
            int a = 99;
            int b = 9;
            int hasilYgDiharapkan = -3;

            // Act
            int hasilDefault = Pangkat.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(hasilYgDiharapkan, hasilDefault);
        }
    }
}