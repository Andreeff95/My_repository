// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.

System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int RecPow(int num1, int num2)
{
    if(num2==0)
    {
        return 1;
    }
    else
    {
        return num1*(RecPow(num1, num2-1));
    } 
}

System.Console.WriteLine($"A = {A}; B = {B} -> {RecPow(A, B)}");