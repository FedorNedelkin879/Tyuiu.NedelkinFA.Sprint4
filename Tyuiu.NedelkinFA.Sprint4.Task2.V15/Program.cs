using Tyuiu.NedelkinFA.Sprint4.Task2.V15.Lib;
Random rnd = new Random();
DataService ds = new DataService();
Console.WriteLine("колич элем масива");
int len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];
for (int i = 0; i <= len - 1; i++)
{
    numsArray[i] = rnd.Next(2, 8);
}
Console.WriteLine("massive");
for (int i = 0; i <= len - 1; i++)
{
    Console.Write(numsArray[i] + "\t");
}
Console.WriteLine();
int res = ds.Calculate(numsArray);
Console.WriteLine("summa chet elem: " + res);
Console.ReadKey();
