using Tyuiu.BorovinskikhSV.Sprint1.Task6.V14.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckLowerCaseRusLetters()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckLowerCaseRusLetters("привет"));
        }


        [TestMethod]
        public void InvalidCheckLowerCaseRusLetters()
        {
            DataService ds = new DataService();
            Assert.IsFalse(ds.CheckLowerCaseRusLetters("Привет"));
            Assert.IsFalse(ds.CheckLowerCaseRusLetters("привет1"));
            Assert.IsFalse(ds.CheckLowerCaseRusLetters("hello"));
        }
    }
}
