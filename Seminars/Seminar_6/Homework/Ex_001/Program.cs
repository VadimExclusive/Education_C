// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void CountingNumbersAfterZero()
{
    Console.Write("Input number of digit: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int dig = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine ($"Input a digit {i+1}: ");
        dig = Convert.ToInt32(Console.ReadLine());
        if(dig > 0)
        count++;
    }
    Console.WriteLine($"Counting numbers after zero is: {count}");
}

CountingNumbersAfterZero();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2) - точка X
y = k1 * x + b1 - точка Y
b1 == b2, k1 == k2 - прямые совпадают
k1 == k2 - параллельны
*/

void ThePointOfIntersectionOfTwoStraightLines()
{
    Console.Write("Input b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    double xInter = 0;
    double yInter = 0;
    if(b1 == b2 && k1 == k2) Console.WriteLine("Straight lines match");
    else
        if (k1==k2) Console.WriteLine("Straight lines are parallel");
        else
        {
            xInter = (b2 - b1) / (k1 - k2);
            yInter = k1 * xInter + b1;
            Console.WriteLine($"The point of intersection of two straight lines: {xInter}, {yInter}");
        }
}

ThePointOfIntersectionOfTwoStraightLines();
