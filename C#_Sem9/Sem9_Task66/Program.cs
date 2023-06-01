// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int RecSum(int num1, int num2)
{
    if(num2==0)
    {
        return 0;
    }
    else
    {
        return num2+(RecSum(num1, num2-1));
    } 
}

System.Console.WriteLine($"M = {M}; N = {N} -> {RecSum(M, N)}");