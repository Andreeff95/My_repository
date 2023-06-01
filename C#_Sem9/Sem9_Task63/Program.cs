// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 1;

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

