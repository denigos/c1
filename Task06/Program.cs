Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberA = number % 2;

if (numberA == 0)
{
    Console.Write($"Введенное вами  число  {number}, является четным");
}
else
{
    Console.Write($"Введенное вами  число  {number}, не является четным");
}
