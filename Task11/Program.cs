int num = new Random().Next(100, 1000);
Console.WriteLine($"На вход получаем число => {num}");


int DeleteSecondDigit(int number)
{
    int firstNum = number / 100;
    int lastNum = number % 10;
    return firstNum * 10 + lastNum;
}

Console.WriteLine(DeleteSecondDigit(num));
