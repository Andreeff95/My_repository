/* Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/ 

string GetCube(int x)
{
    string line = ($"{x}x{x}x{x}={Math.Pow(x, 3)}");
    return line;
}
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(GetCube(i));
}