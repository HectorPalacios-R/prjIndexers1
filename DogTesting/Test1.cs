
using prjIndexes2;
namespace DogTesting
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestName()
        {
            Dogs dog = new Dogs("Tom", "Pitbull", 5, 87);
            Assert.AreEqual(dog[0], "Tom");
        }
        public void TestAge()
        {
            Dogs dog = new Dogs("Roxy", "Boxer", 7, 72);
            Assert.AreEqual(dog[0], "Tom");
        }
    }
}
