// Задача: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// 1 5 2  // 1 6 4
// 6 3 8  // 5 3 7
// 4 7 9  // 2 8 9

/*
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

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++) // цикл отвечает за строки
    {  
        for(int j = 0; j < columns; j++)  // цик отвечает за столбцы
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

void ChangeArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
        Console.WriteLine("Impossible to change!");
    else
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ChangeArray(myArray);
Show2dArray(myArray);
*/

// Задача: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
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

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++) // цикл отвечает за строки
    {  
        for(int j = 0; j < columns; j++)  // цик отвечает за столбцы
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

void СhangeFirstLastRowColumn(int[,] array, int rowFirst, int rowLast)
{
    if(rowFirst <= array.GetLength(0) && rowLast <= array.GetLength(0))
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[rowFirst,j];
            array[rowFirst,j] = array[rowLast,j];
            array[rowLast,j] = temp;
        }
    else
        Console.WriteLine("Uncorrect");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine($"Введите номер строки 1: ");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите номер строки 2: ");
int str2 = Convert.ToInt32(Console.ReadLine());
СhangeFirstLastRowColumn(myArray, str1 - 1, str2 - 1);
Show2dArray(myArray);
*/

// Задача: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minVal, int maxVal)
{
int[,] array = new int[rows, columns];
for (int i = 0; i < rows; i++)
for (int j = 0; j < columns; j++)
array[i,j] = new Random().Next(minVal, maxVal + 1);
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

int[,] CutArray(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i,j] < array[minI,minJ])
            {
                minI = i;
                minJ = j;
            }
    int [,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, x = 0; i < array.GetLength(0); i++)
        if(i != minI) // != - не равно
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++)
                if(j != minJ)
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }
            x++;
        }
    return newArray;
}

int[,] myArray = CreateRandom2dArray(4,4,1,9);
Show2dArray(myArray);
int[,] newArray = CutArray(myArray);
Console.WriteLine();
Show2dArray(newArray);
*/