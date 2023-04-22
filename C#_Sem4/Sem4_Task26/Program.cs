/* Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
*/
int ReadInt(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    int i;
    while(!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.Write($"Это не число. Введите {arg}: ");
    }
    return i;
}

int LenNum(int x)
{
    return Convert.ToString(x).Length;
}

int N = ReadInt("число");

System.Console.WriteLine($"Количество цифр в числе: {LenNum(N)}");