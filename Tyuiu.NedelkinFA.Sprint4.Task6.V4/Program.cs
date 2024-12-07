using Tyuiu.NedelkinFA.Sprint4.Task6.V4.Lib;
using System;

DataService ds = new DataService();
var cities = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
Console.WriteLine("ishodniy massive: ");
for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}
Console.WriteLine("goroda s dlinoy menshe 7 znakov: ");
string[] result = ds.Calculate(cities);
foreach (var city in result)
{
    Console.WriteLine(city);
}
Console.ReadKey();