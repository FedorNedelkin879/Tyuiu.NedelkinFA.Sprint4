using Tyuiu.NedelkinFA.Sprint4.Task0.V15.Lib;

DataService ds = new DataService();
int[] numsArray = { 4, 0, 3, 0, 10 };
Console.WriteLine("исходящий massive");
for (int i = 0; i <= numsArray.Length - 1; i++)
{
    Console.WriteLine(numsArray[1]);
}
Console.WriteLine("результативный massive");
numsArray = ds.Calculate(numsArray);
for (int i = 0; i <= numsArray.Length - 1; i++)
{
    Console.WriteLine(numsArray[i]+"\t");
}
Console.WriteLine();
Console.ReadKey(); 