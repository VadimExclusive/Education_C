// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

/*
int Converting_Three_Digit_Number_To_The_Second (int threeDigit)
{
    int result;
    if (threeDigit > 99 && threeDigit < 1000 || threeDigit < -99 && threeDigit > -1000 )
    {
        int dec = (threeDigit % 100) / 10;
        result = dec;
        return result;
    }
    else
        return -1;
    
}
Console.Write("Input a three-digit number: ");
int three_digit_number = Convert.ToInt32(Console.ReadLine());

int theSecondDigit = Converting_Three_Digit_Number_To_The_Second (three_digit_number);
if (theSecondDigit == -1)
    Console.WriteLine($"Uncorrect input");
else
    Console.WriteLine($"The second digit of a three-digit number: {theSecondDigit}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int Outputs_the_digit_of_the_third_number(int number)
{
    int result;
    if(number <= 99 && number >= -99)
        return -1;
    else
        if(number > 99 && number < 999 ||number < -99 && number > -999)
            result = number % 10;
        else
            do
                number = number / 10;
            while (number > 999 || number < -999);
            result = number % 10;
        return result;    
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int the_third_digit = Outputs_the_digit_of_the_third_number (number);
if (the_third_digit == -1)
    Console.WriteLine($"There is no third number");
else
    Console.WriteLine($"The third-digit number: {the_third_digit}");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int The_number_what_is_this_day_like(int num)
{
if (num  >= 1 && num <= 5)
{
    int weekday = num;
    Console.WriteLine("This day is a working day");
    return weekday;
}
else
    if (num > 5 && num <= 7)
    {
        int weekends = num;
        Console.WriteLine("This day is a weekend");
        return weekends;
    }
    else
        return -1;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int what_is_this_day_like = The_number_what_is_this_day_like (number);

if (what_is_this_day_like == -1)
    Console.WriteLine($"This day of the week does not exist");
    */