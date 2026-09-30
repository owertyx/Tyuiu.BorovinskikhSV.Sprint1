using Tyuiu.BorovinskikhSV.Sprint1.Task2.V12.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateParallelepipedVolume(x, x, x);
            Assert.AreEqual(8, res);
        }
    }
}
