// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int RecSumNum(int num)
{
    if(num==0)
    {
        return 0;
    }
    else
    {
        return num%10+RecSumNum(num/10);
    } 
}

System.Console.WriteLine($"{N} -> {RecSumNum(N)}");