// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

/*
int[] CreateArray(int size)
{
    int[] array = new int [size];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);
    return array;
}

int SumOfNegatives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = SumOfNegatives(myArray);
Console.WriteLine("Sum of negative elements is" + result);
*/

// Задача 2: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] CreateArray(int size)
{
    int[] array = new int [size];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

void ReversePositiveElementsToNegative(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Reverse positive elements to negative ones:");
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        res = array[i] * -1;
        Console.Write($"{res} ");
    }
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
ReversePositiveElementsToNegative(myArray);
*/

// Задача 3: Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*
int[] CreateRandomArray()
{
    int[] array = new int [12];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 201);
    }
    Console.WriteLine("Complete!");
    return array;
    
}

void ShowArray(int [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

int TheNumberOfArrayElementsInTheSegment(int[] array)
{
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] <= 99 && array[i] >= 10)
            count++;
    return count;
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
int result = TheNumberOfArrayElementsInTheSegment(myArray);
Console.WriteLine("The number of array elements in the segment is: " + result);
*/

// Задача 4: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*
int[] CreateArray(int size)
{
    int[] array = new int [size];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

bool TheNumberOfArrayElementsInTheSegment(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        return true;
    }
    return false;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = TheNumberOfArrayElementsInTheSegment(myArray, number);
Console.Write($"{result}");
*/