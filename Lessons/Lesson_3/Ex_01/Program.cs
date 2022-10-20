// 1 группа методов:

/*
void Method1()
{
Console.WriteLine("Автор...");
}
Method1();
*/

// 2 группа методов:

/*
void Method2(string msq)
{
    Console.WriteLine(msq);
}
Method2(msq: "Текст сообщения");
*/
/*
void Method21(string msq, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msq);
        i++;
    }
}
Method21(msq:"Текст", count: 4);
*/

// 3 группа методов:

/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// 4 группа методов:

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // Пустая строка, ввод результата

    while (i < count)
    {
        result = result + text; 
        i++;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);
*/

/*
// Рассмотрим цикл For:
string Method4(int count, string text)
{
    string result = String.Empty; // Пустая строка, ввод результата
    for (int i = 0; i < count; i++)
    {
        result = result + text;  
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);
*/

// Рассмотрим цикл в цикле:

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

// Задача: Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с"

// Ясна ли задача?

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text [i] == oldValue) 
        result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();
*/

// Задача:
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен эотго значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть не отсортированные элементы.

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) 
            minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
