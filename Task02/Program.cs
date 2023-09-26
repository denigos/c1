Console.WriteLine("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"{numberA} Больше {numberB}");
}
else
{
    Console.WriteLine($"{numberA} Меньше {numberB}");
}
