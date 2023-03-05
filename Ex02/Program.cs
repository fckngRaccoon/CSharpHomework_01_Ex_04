int Prompt(string message)
{
    Console.Write(message);
    string value = Console.Readline();
    int result = Convert.ToInt32(value);
    return result;
}

int GetTrirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number<100)
    {
        Console.WriteLine("Треьтей цифры нет");
        return false;
    }
}

int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetTrirdRank(number));
}