// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

int EvenNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
           count++;
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
int even = EvenNumbers(myArray);
Console.WriteLine("Amount of even numbers is: " + even);


// Задача 35: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

int SumNumbers(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 1 || array[i] % -2 == -1)
           result += array[i];
    return result;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
int sum = SumNumbers(myArray);
Console.WriteLine("Sum numbers is: " + sum);


// Задача 36: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateRandomArray(int size)
{
    double[] array = new double [size];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element of array: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(double [] array)
{
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();
}

double MaxNumbers(double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
           max = array[i];
    }
    return max;
}

double MinNumbers(double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[0] > array[i])
           min = array[i];
    }
    return min;
}

double TheDifferenceBetweenTheElements(double min, double max)
{
    double dif = 0;
    if(max < 0 || min < 0)
        dif = max + min;
    else
        dif = max - min;
    return dif;    
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(size);
ShowArray(myArray);
double maxNum = MaxNumbers(myArray);
Console.WriteLine($"Maximum array number is {maxNum}");
double minNum = MinNumbers(myArray);
Console.WriteLine($"Minimum array number is {minNum}");
double difference = TheDifferenceBetweenTheElements(minNum, maxNum);
Console.WriteLine($"The difference between the elements is: {difference}");
