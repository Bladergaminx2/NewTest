
using NewTest;
namespace TestProject
{
    public class TestHieu4PT
    {
        private Hieu4PT hieu4PT;
        [SetUp]
        public void Setup()
        {

        }

        [Test]

        [TestCase(10, 2, 3, 1, 4)]    
        [TestCase(20, 5, 5, 5, 5)]    
        [TestCase(0, 0, 0, 0, 0)]     
        public void TinhTongHieuTest(int a, int b, int c, int d, int expected)
        {

            hieu4PT = new Hieu4PT(a, b, c, d);

            var result = hieu4PT.TinhTongHieu();
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}