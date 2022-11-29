// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2d array creating:");

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {  
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
    Console.WriteLine();    
}

void ArrangeRowsDescendingOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int x = 0; x < array.GetLength(1) - j - 1; x++)
                if (array[i, x + 1] > array[i, x])
                {
                    temp = array[i, x + 1];
                    array[i, x + 1] = array[i, x];
                    array[i, x] = temp;
                }
    }
    Console.WriteLine("Let's order the elements of each row in descending order in a 2d array:");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ArrangeRowsDescendingOrder(myArray);
Show2dArray(myArray);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2d array creating:");

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {  
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
    Console.WriteLine();    
}

void SmallestSumRowElements(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        int[] sumRow = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int num = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                num += array[i, j];
            sumRow[i] = num;
        }
        int sumMinRow = sumRow[0];
        int iMinRow = 0;
        for (int i = 1; i < sumRow.Length; i++)
            if (sumMinRow > sumRow[i])
            {
                sumMinRow = sumRow[i];
                iMinRow = i;
            }
        Console.WriteLine($"The row with the smallest sum of elements - {iMinRow + 1} row;");
        Console.WriteLine($"The sum of the line is equal to - {sumMinRow};");
    }
    else
        Console.WriteLine("Square array. Enter a rectangular array.");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SmallestSumRowElements(myArray);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 1
*/

int m = InputNumbers("Enter the number of rows of the 1st matrix: ");
int n = InputNumbers("Enter the number of columns of the 1st matrix and rows of the 2nd: ");
int p = InputNumbers("Enter the number of columns of the 2nd matrix: ");
int range = InputNumbers("Enter a range of random numbers: from 0 to ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"The first matrix:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine($"The second matrix:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"The product of the first and second matrices:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int NumberRequest(string reqNum) 
{
    Console.Write($"{reqNum}");
    var stringNumber = Console.ReadLine();
    int numValue;
    bool isNumber = int.TryParse(stringNumber, out numValue);
    return numValue;
}

void СreatingArrayNoRepeatingElementsArray(int[] array)
{
    int element = new Random().Next(10, 100);
    array[0] = element;
    for (int i = 1; i < array.Length; i++)
    {
        while (Array.IndexOf(array, element) != -1)
            element = new Random().Next(10, 100);
        array[i] = element;       
    }
}

void Transformation3dArray(int[,,] array3d, int[] array) 
{
    int arrayIndex = 0;
    for (int i = 0; i < array3d.GetLength(0); i++)
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = array[arrayIndex];
                arrayIndex++;
            }
        }
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            if (j / array.GetLength(2) == 0)
                Console.WriteLine();
        }
}

bool CheckingArrayMaximumNumberElements(int num) 
{
    int MaxCountNumberElements = 64;
    if(num > MaxCountNumberElements) 
    return false;
    return true;
}

int x = NumberRequest("Input a number x: ");
int y = NumberRequest("Input a number y: ");
int z = NumberRequest("Input a number z: ");

if (CheckingArrayMaximumNumberElements(x * y * z)) 
{
    int[,,] array3d = new int [x, y, z];
    int[] array = new int [array3d.Length];
    СreatingArrayNoRepeatingElementsArray(array);
    Transformation3dArray(array3d, array);
    Show3DArray(array3d);
} 
else 
    Console.WriteLine("The length of the array of non-repeating elements is greater than the allowable");


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] CreateSpiralArray(int size)
{
    int[,] array = new int[size, size];
    int x = 0, y = 0;
    int count = 1;
    while (size > 0)
    {
        for (int i = y; i <= y + size - 1; i++)
            array[x, i] = count++;
        for (int j = x + 1; j <= x + size - 1; j++)
            array[j, y + size - 1] = count++;
        for (int i = y + size - 2; i >= y; i--)
            array[x + size - 1, i] = count++;
        for (int i = x + size - 2; i >= x + 1; i--)
            array[i, y] = count++;
        x++;
        y++;
        size = size - 2;
    }
    return (array);
}

void ShowSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else 
            Console.WriteLine(".");
    }
}

int[,] myArray = CreateSpiralArray(4);
ShowSpiralArray(myArray);
