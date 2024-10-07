using Tyuiu.MolodchikovEE.Sprint5.Task0.V25.Lib;

namespace Tyuiu.MolodchikovEE.Sprint5.Task0.V25.Test
{
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            int x = 3;
            double result = Math.Round((3 * Math.Pow(x, 4) + 1) / (Math.Pow(x, 3)), 3);
            double wait = 9.037;
            Assert.AreEqual(wait, result);
        }
    }
}