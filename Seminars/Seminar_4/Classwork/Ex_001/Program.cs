// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
        sum += current; // sum = sum + current;
    return sum;
}

Console.Write("Input a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = GetSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {s}");
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int Outputs_the_number_of_digits(int num)
{
    int count = 0;
    if (num < 0) num *= -1;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int amount = Outputs_the_number_of_digits(number);
Console.WriteLine($"The number of digits in the number {number} is equal to: {amount}");
*/

// Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int GetProduct(int num)
{
    int product = 1;
    if(num < 0) return -1;
    for(int current = 1; current <= num; current++)
        product *= current; // sum = sum * current;
    return product;
}

Console.Write("Input a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int s = GetProduct(a);
if (s == -1)
Console.WriteLine($"Uncorrect product");
else
Console.WriteLine($"Productof numbers from 1 to {a} is {s}");
*/

// Задача 4: Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i =0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
