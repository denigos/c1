Console.WriteLine("Введите первое целое число больше 0: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 0)
{
    int count = -numberA;
    while (count <= numberA)
    {
        Console.Write($"{count} ");
        count += 1;
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}
