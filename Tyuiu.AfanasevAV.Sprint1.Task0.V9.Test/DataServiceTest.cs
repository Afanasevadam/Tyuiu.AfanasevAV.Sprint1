using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfanasevAV.Sprint1.Task0.V9.Lib;

namespace Tyuiu.AfanasevAV.Sprint1.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            int wait = 3; // (9/3)*4 = 12; 12/3 = 4; 4/2 = 2; 2+1 = 3
            Assert.AreEqual(wait, res);
        }
    }
}