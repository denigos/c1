using System;
using System.Transactions;
Console.WriteLine("Введите координаты точек");
Console.Write("x: ");
int xCoorinate = Convert.ToInt32(Console.ReadLine());

Console.Write("y: ");
int yCoorinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoorinate, yCoorinate);

string result = quarter > 0
? $"Указанные координаты соответствуют четверти {quarter}"
: "Введены координаты < 0";

Console.WriteLine(result);
// metod
int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}



