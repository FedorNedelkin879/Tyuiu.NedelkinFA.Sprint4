using Tyuiu.NedelkinFA.Sprint4.Task1.V13.Lib;
DataService ds = new DataService();
int len;
Console.WriteLine("kolichestvo elem");
len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("i " + i + "elem massive");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("massive:");
for  (int i = 0;i <= len - 1;i++)
{
    Console.WriteLine(numsArray[i]+"\t");
}
Console.WriteLine();
Console.WriteLine();
int res = ds.Calculate(numsArray);
Console.WriteLine(res);
Console.ReadKey();