using Tyuiu.PasechnikPA1.Sprint2.Task6.V6.Lib;
namespace Tyuiu.PasechnikPA1.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 14;
            string res = ds.FindCardNameAndValue(m, k);
            string wait = "Туз пики";

            Assert.AreEqual(wait, res);
        }
    }
}
