// Задача_1: Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.

/*
int FineBiggerDigit(int num)
{
    int result;

    if(num < 10 || num >= 100)
        return -1;    
    else
    {
        int ed = num % 10;
        int dec = num / 10;

        if(ed > dec)
            result = ed;
        else
            result = dec;
    }
    return result;
}

Console.Write("Input a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int biggerDigit = FineBiggerDigit(number);
Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");
*/

// Задача_2: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

/*
int randomThreeDigit = new Random().Next(100, 999);
Console.WriteLine($"Random three-digit number is: {randomThreeDigit}");

int RemovingTheSecondDigit(int num)
{
    int ed = (num / 100) % 10;
    int hun = num % 10;
    int result = ed * 10 + hun;
    int secCat = (randomThreeDigit % 100) / 10;
    Console.WriteLine($"Delete two category number is: {secCat}");
    return result;
}

Console.WriteLine($"it turned out the number: {RemovingTheSecondDigit(randomThreeDigit)}");
*/

// Задача_3: Напишите программу, которая принимает на вход число "n" и проверяет, кратно ли оно одновременно "a" и "b" (цельночисленные делители, так же задаются пользователем).

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a divider A: ");
int dividerA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a divider B: ");
int dividerB = Convert.ToInt32(Console.ReadLine());




