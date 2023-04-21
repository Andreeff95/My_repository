/* Напишите программу, которая 
принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
*/ 

string GetQuart(int x)
{
    string line = ($"{x}x{x}={Math.Pow(x, 2)}");
    return line;
}
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(GetQuart(i));
}