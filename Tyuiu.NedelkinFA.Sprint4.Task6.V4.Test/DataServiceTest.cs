using Tyuiu.NedelkinFA.Sprint4.Task6.V4.Lib;

namespace Tyuiu.NedelkinFA.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var week = new string[] { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
            int res = ds.Calculate(week);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}