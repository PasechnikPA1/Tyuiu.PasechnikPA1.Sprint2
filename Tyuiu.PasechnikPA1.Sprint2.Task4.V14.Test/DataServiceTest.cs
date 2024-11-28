using Tyuiu.PasechnikPA1.Sprint2.Task4.V14.Lib;
namespace Tyuiu.PasechnikPA1.Sprint2.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 81;
            Assert.AreEqual(wait, res);
        }
    }
}
