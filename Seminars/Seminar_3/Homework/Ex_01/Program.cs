// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


bool Сhecking_palindromes(int num)
{
    int first_digit = num / 1000;
    int last_digit = num % 100;
    int first_ed = first_digit % 10;
    int first_dec = first_digit / 10;
    int last_ed = last_digit % 10;
    int last_dec = last_digit / 10;

    if (first_ed == last_dec && first_dec == last_ed)
        return true;
        return false;
}

Console.WriteLine("Input a five-digit number: ");
int five_digit_number = Convert.ToInt32(Console.ReadLine());
bool result = Сhecking_palindromes(five_digit_number);
Console.Write($"Your result: {result}");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Distance_betwee_points_in_space(double xa, double ya, double za, double xb, double yb, double zb)
{
    double distance = 0;
    distance = (Math.Pow(xb - xa, 2)) + (Math.Pow(yb - ya, 2)) + (Math.Pow(zb - za, 2));
    distance = Math.Sqrt(distance);
    distance = Math.Round(distance, 2);
    return distance;
}

Console.WriteLine("Enter the coordinates of the point A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates of the point B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
double distance_of_point = Distance_betwee_points_in_space(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"The distance between point A: {x1}, {y1}, {z1} and B: {x2}, {y2}, {z2} is: {distance_of_point}");


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Outputs_a_series_of_squares(int num)
{   
    for (double count = 1; count <= num; count++)
    {
        double cube = Math.Pow(count, 3);
        Console.Write($"{cube}; ");
    }
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Output a table of cubes: ");
Outputs_a_series_of_squares(num);
