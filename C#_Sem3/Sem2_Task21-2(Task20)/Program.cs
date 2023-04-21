/* Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.
*/ 

double GetDist(double side1, double side2)
{
    double dist = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
    return dist;
}

double GetSide(double num1, double num2)
{
    double side = Math.Abs(num1 - num2);
    return side;
}

Console.Write("Введите координату X для первой точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y для первой точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z для третьей точки: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X для второй точки: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y для второй точки: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z для третьей точки: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double side_x = GetSide(x1, x2);
double side_y = GetSide(y1, y2);
double side_z = GetSide(z1, z2);
double temp_res = GetDist(side_x, side_y);
double get_res = Math.Round(GetDist(side_z, temp_res), 2);
System.Console.WriteLine($"Расстояние от первой точки до второй равно: {get_res}");