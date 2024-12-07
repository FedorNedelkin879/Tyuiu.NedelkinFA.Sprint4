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
            var cities = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            string[] res = ds.Calculate(cities);
            string[] wait = new string[] { "Москва", "Самара" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}