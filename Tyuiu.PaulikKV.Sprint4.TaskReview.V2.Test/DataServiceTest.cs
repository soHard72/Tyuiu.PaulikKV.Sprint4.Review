using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint4.TaskReview.V2.Lib;

namespace Tyuiu.PaulikKV.Sprint4.TaskReview.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            string str = "597643158942";
            int res = ds.Calculate(rows, columns, str);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
