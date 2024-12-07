using Tyuiu.NedelkinFA.Sprint4.Task6.V4.Lib;
DataService ds = new DataService();
var week = new string[] { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
Console.WriteLine("ishodniy massive: ");
for  (int i = 0; i <= week.Length - 1; i++)
{
    Console.WriteLine(week[i]);
}
Console.WriteLine("kolich elem s 7 znakami: ");
int nums = ds.Calculate(week);
Console.WriteLine(nums);
Console.ReadKey();