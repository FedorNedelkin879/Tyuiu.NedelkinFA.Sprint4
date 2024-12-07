using Tyuiu.NedelkinFA.Sprint4.Task7.V30.Lib;
int rows = 3;
int columns = 3;
int[,] mtrx = new int[rows, columns];
string str = "103050709";
DataService ds = new DataService();
int index  = 0;
Console.WriteLine("\nMassive:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{str[index]}\t");
        index++;
    }
}
int res = ds.Calculate(rows, columns, str);
Console.WriteLine("kolichestvo nulevih elem = " + res);
Console.ReadKey();