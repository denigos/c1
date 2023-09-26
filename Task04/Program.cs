Console.WriteLine("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе  целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье  целое число: ");
int numberС = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max<numberB)
{
    max = numberB;
}
if (max < numberС)
{
    max = numberС;
    
}
Console.WriteLine($"Max number: {max}");