Console.WriteLine("Введите целое число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = 0;
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            if (count > 0)
            {
                Console.Write($"{count} ");
            }
        }
        count += 1;
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}