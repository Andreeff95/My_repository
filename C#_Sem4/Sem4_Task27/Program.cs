/* Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
*/ 

int Sum(int num)
{
    int res = 0;
    while(num>0)
    {
        res+=num%10;
        num/=10;
    }
    return res;
}
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе: {Sum(N)}");