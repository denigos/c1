Console.WriteLine("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <=999)
{
int lastDigit = number % 10;
Console.Write($"Последняя цифра вашего числа - {lastDigit}"); 
}
else Console.WriteLine("Некоректный ввод");

