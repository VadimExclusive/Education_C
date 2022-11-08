// Задача 1

/*
int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine();
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

int[] ChangeArray(int[] array)
{
    int[] newArray = new int[array.Length];

    newArray[0] = array[0] + 10;
    for (int i = 1; i < array.Length; i++) 
        newArray[i] = array[i];
    return newArray;
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
int[] array2 = ChangeArray(myArray);
ShowArray(array2);
*/

// Задача 2: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine();
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

void ChangeArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ChangeArray(myArray);
ShowArray(myArray);
*/

// Задача 3: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool DoesATriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;
        else
        return false;
}

Console.Write($"input the first number: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write($"input the second number: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write($"input the third number: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool result = DoesATriangleExist(sideA, sideB, sideC);
if(result) Console.Write("A triangle is possible");
else Console.Write("Triangle is impossible");
*/

// Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int [] array)
{
    Console.WriteLine();
    Console.WriteLine("The array you created:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];

     for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
CopyArray(myArray);
ShowArray(myArray);
myArray[0] = 8;
ShowArray(myArray);
*/

// Задача 5: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/*
int Fibonacci(int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 0; i < n; i++)
        array[i] = array[i-2] + array[i-1];
    return array[i];
}

Console.Write($"input the N number: ");
int sideN = Convert.ToInt32(Console.ReadLine());
Console.Write($"input the A number: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write($"input the B number: ");
int sideB = Convert.ToInt32(Console.ReadLine());

int myArray = Fibonacci(sideN, sideA, sideB);
Console.WriteLine($"Number Fibonacci is: {myArray},  ");
*/