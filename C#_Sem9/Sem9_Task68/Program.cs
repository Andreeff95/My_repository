// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n. 

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Ackermann(int num1, int num2)
{
    if(num1==0) return num2+1;
    else if (num2==0) return Ackermann(num1-1, 1);
    else return Ackermann(num1-1, Ackermann(num1, num2-1));
}

System.Console.WriteLine($"m = {M}, n = {N} -> A(m, n) = {Ackermann(M, N)}"); 