using Tyuiu.BorovinskikhSV.Sprint1.Task7.V12.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(2, 1);
            double wait = 45; 

            Assert.AreEqual(wait, res);
        }
    }
}