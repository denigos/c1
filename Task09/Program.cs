int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число {number}");

int fistdigit = number / 10;
int secondDigit = number % 10;

if (fistdigit>secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {fistdigit}");
else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int maxDigit = fistdigit > secondDigit ? fistdigit : secondDigit; // Тернарный оператор на замену if/else, тот
                                                                    // же результат
