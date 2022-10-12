// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.


Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine($"max number is {n1}; min number is {n2}");
}
else
{
    Console.WriteLine($"max number is {n2}; min number is {n1}");
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.


Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if(n1 > max)
{
    max = n1;
}
if(n2 > max)
{
    max = n2;  
}
if(n3 > max)
{
    max = n3;
}
Console.Write($"The maximum number of {n1}, {n2}, {n3} is a number {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).


Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0)
{
    Console.WriteLine($"The number {n} is even");
}
else
{
    Console.WriteLine($"The number {n} is odd");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.


Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current  = 1;
if(n > 0)
{
    Console.WriteLine($"The number {n} consists of the following even numbers: ");
    while(current <= n)
    {
        if(current % 2 == 0)
        {
            Console.Write($"{current}, ");
        }
        current++;
    }  
}
else
{
    Console.Write("Uncorrect input");
}
