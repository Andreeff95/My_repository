/*  Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B.
*/ 

int Pow(int x1, int x2)
{
    int res = 1;
    for(int i = 0; i < x2; i++)
    {
        res*=x1;
    }
    return res;
}

System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Результат: {Pow(A, B)}");