using prjIndexers1;
namespace TestingIndexes
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestID()
        {
            Employee employee = new Employee("E002", "Reece", "Wanvig", "Boss", 50);
            Assert.AreEqual(employee[0], "E002");
        }
        [TestMethod]
        public void TestUpdatedName()
        {
            Employee employee = new Employee("E003", "Jo", "Hart", "Big Boss", 500);
            employee[1] = "Joanne";
            Assert.AreEqual(employee[1], "Joanne");
        }
    }
}
