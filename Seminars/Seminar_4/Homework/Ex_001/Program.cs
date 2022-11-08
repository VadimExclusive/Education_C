// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Raises_a_number_to_a_degrees(int num, int deg)
{
    int num_deg = 1;
for (int count = 0; count < deg; count++ )
    num_deg *= num;
    return num_deg;
}

Console.Write("Input a first number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int degrees = Convert.ToInt32(Console.ReadLine());

int sum_number = Raises_a_number_to_a_degrees(number, degrees);
Console.WriteLine($"From a given number {number}, {degrees} the sum of the digits is: {sum_number}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int The_sum_of_digits_in_a_number(int num)
{
    int sum = 0;
    int ed = 0;
    while (num > 0)
    {
        ed = num % 10;
        num = num / 10;
        sum = sum + ed;
    }
    return sum;    
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum_number = The_sum_of_digits_in_a_number(number);
Console.WriteLine($"From a given number {number} the sum of the digits is: {sum_number}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateRandomArray (int size)
{
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine($"Array of {array.Length} elements: ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
*/

// Задача на создание массива и ввод его в ручном виде:


int[] CreateArray (int size)
{
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input the index of the element {i}:  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
