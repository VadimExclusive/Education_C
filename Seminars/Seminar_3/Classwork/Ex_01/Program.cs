// Задача_1: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int FindQuart(double x, double y)
{
    int num = 0;

    if (x > 0 && y > 0) num = 1;
    if (x < 0 && y > 0) num = 2;
    if (x < 0 && y < 0) num = 3;
    if (x > 0 && y < 0) num = 4;

    return num;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

int quartNum = FindQuart(x,y);
Console.WriteLine($"The point A({x}, {y}) is in {quartNum} quart");
*/

// Задача_2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double FindDistance (double xa, double ya, double xb, double yb)
{
    double distance = 0;
    distance = (Math.Pow(xa - xb, 2)) + (Math.Pow(ya - yb, 2));
    distance = Math.Sqrt(distance);
    distance = Math.Round(distance, 2);
    return distance;
}

Console.WriteLine("Enter the coordinates of the point A: ");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates of the point B: ");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());

double distanceOfPoint = FindDistance(xa, xb, ya, yb);
Console.WriteLine($"The distance between point A: {xa}, {ya} and B: {xb}, {yb} is {distanceOfPoint}");
*/

// Задача_3: Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

/*
void Outputs_a_series_of_squares(int num)
{   
    for (double count = 1; count <= num; count++)
    {
        double square = Math.Pow(count, 2);
        Console.Write($"{square}; ");
    }
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Outputs a series of squares: ");
Outputs_a_series_of_squares(num);
*/