
using NewTest;
namespace TestProject
{
    [TestFixture]
    public class TestSoChan
    {
        private SoChan soChan;
        [SetUp]
        public void Setup()
        {
            soChan = new SoChan();
        }

        [Test]
        public void TimSoChanTest()
        {
            var input = new List<int> { 0, 4, 5, 6, 18, 10, 9, 21, 25, 40 };
            var expected = new List<int> { 0, 4, 6, 18, 10, 40 };
            var result = soChan.TimSoChan(input);

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}