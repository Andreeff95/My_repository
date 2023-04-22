/* Напишите программу, которая 
принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
*/ 

int MultNum(int x)
{
    if(x == 1)
    {
        return 1;
    }
    int mult = x*MultNum(x-1); 
    return mult;
}

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до {N} равна {MultNum(N)}");