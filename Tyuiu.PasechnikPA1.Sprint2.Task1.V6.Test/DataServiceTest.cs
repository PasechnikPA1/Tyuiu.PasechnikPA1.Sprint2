﻿using Tyuiu.PasechnikPA1.Sprint2.Task1.V6.Lib;
namespace Tyuiu.PasechnikPA1.Sprint2.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 915;
            int b = 169;
            int c = 174;
            int d = 133;
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
