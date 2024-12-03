using Tyuiu.NedelkinFA.Sprint4.Task2.V15.Lib;

namespace Tyuiu.NedelkinFA.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 0, 3, 12, 11 };
            int res = ds.Calculate(numsArray);
            int wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}
