int num = new Random().Next(100, 1000);
Console.WriteLine($"На вход получаем число => {num}");


int DeleteSecondDigit(int number)
{
    int firstNum = number / 10 % 10;
    return firstNum;
}

Console.WriteLine(DeleteSecondDigit(num));
