/*  Напишите программу, которая 
принимает на вход число (А) и выдаёт сумму чисел 
от 1 до А.
*/ 

int SumNum(int x)
{
    if(x == 1)
    {
        return 1;
    }
    int sum = x+SumNum(x-1); 
    return sum;
}

System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел от 1 до {A} равна {SumNum(A)}");