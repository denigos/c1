Console.WriteLine("Please enter 1 number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter 2 number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool IsSquareToNumbers(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

bool result = IsSquareToNumbers(firstNum, secondNum);

Console.WriteLine(result ? $"{firstNum}, {secondNum} => yes" : $"{firstNum}, {secondNum} => no");