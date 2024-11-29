using Tyuiu.PasechnikPA1.Sprint2.Task5.V13.Lib;
namespace Tyuiu.PasechnikPA1.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0, ds.FindDateOfNextDay(1000, 31, 321));
            Assert.AreEqual(20240301, ds.FindDateOfNextDay(2024, 2, 29));
        }
    }
}
