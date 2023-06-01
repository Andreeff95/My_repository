// Задача 65: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void RecOrder(int start, int end)
{
    if(start<end)
    {
        System.Console.Write(start+" ");
        RecOrder(start+1, end);
    }
    else System.Console.Write(start+" ");
    
}

RecOrder(M, N);