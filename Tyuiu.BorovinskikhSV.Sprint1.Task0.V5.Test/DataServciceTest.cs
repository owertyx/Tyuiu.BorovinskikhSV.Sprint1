using Tyuiu.BorovinskikhSV.Sprint1.Task0.V5.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServciceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(12, res);
        }
    }
}
