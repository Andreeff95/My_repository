/* Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно 
палиндромом.
*/ 

string TryPalindrom(int N)
{
    if(N>=10000 && N<=99999)
    {
        if(N/10000==N%10)
        {
            N = N%10000;
            N = N/10;
            if(N/100==N%10)
            {
                return "Число является палиндромом.";
            }
        }
        return "Число НЕ является палиндромом";
    }
    return "Число не пятизначное!";
}
System.Console.Write("Введите пятизначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(TryPalindrom(Num));
