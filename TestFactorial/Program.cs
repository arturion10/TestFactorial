bool isValidNumber = int.TryParse(Console.ReadLine(), out int number);
if (isValidNumber)
{
    Console.WriteLine($"!" + number + " = " + Factorial(number));
}
else
{
    Console.WriteLine("Введите целое число");
}

int Factorial(int number)
{
    var fact = 1;
    if (number == 0)
    {
        return 1;
    }
    for (int i = number; i > 1; i--)
    {
        fact *= i;
    }
    return fact;
}