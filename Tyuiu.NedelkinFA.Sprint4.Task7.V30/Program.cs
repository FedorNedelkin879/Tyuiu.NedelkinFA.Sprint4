using Tyuiu.NedelkinFA.Sprint4.Task7.V30.Lib;
int rows = 5;
int columns = 3;
int[,] mtrx = new int[rows, columns];
string str = "684259137159648";
DataService ds = new DataService();
int index = 0;
Console.WriteLine("\nMassive:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        mtrx[i, j] = int.Parse(str[index].ToString());
        Console.Write($"{mtrx[i, j]}\t");
        index++;
    }
}
int res = ds.Calculate(mtrx);
Console.WriteLine("\nProizvedenie chetnykh chisel = " + res);
Console.ReadKey();