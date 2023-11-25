using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint4.TaskReview.V15.Lib;
namespace Tyuiu.MolodykhVY.Sprint4.TaskReview.V15.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "10293847";
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
