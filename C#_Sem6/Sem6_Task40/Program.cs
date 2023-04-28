/* Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
*/

string CheckTriangle(int a, int b, int c)
{
    if(a>0 && b > 0 && c>0 &&
        a+b>c &&
       b+c>a &&
       a+c>b )
       {
        return "Треугольник существует";
       }
    return "Треугольник не существует";
}

System.Console.Write("Введите первую сторону треугольника: ");
int side1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую сторону треугольника: ");
int side2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третью сторону треугольника: ");
int side3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckTriangle(side1, side2, side3)); 