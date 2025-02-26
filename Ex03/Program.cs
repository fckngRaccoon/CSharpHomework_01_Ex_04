﻿int Prompt(string message)
{
    Console.Write(message);
    string value = Console.Readline();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if(number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Prompt("Введите день недели >");
if (ValidateWeekday(weekDay))
{
    if(IsWeekend(weekDay))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}