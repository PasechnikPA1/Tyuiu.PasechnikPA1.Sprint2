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
            int g = 2024;
            int m = 2;
            int n = 29;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.03.2024";
            Assert.AreEqual(wait, res);
        }
    }
}
