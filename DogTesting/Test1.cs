
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
        [TestMethod]
        public void testBreed()
        {
            Dogs dog = new Dogs("Roxy", "Boxer", 7, 72);
            Assert.AreEqual(dog["breed"], "Maltese Poodle");
        }
        [TestMethod]
        public void updateAge()
        {
            Dogs dog = new Dogs("Roxy", "Boxer", 7, 72);
            dog["age"] = 8;
            Assert.AreEqual(dog["age"], 8);
        }
    }
}
