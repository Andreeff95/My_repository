/* Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 2D 
пространстве.
*/ 

double GetDist(int side1, int side2)
{
    double dist = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
    return dist;
}

int GetSide(int num1, int num2)
{
    int side = Math.Abs(num1 - num2);
    return side;
}

Console.Write("Введите координату X для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int side_x = GetSide(x1, x2);
int side_y = GetSide(y1, y2);
double res = Math.Round(GetDist(side_x, side_y), 2);
System.Console.WriteLine($"Расстояние от первой точки до второй равно: {res}");





