/* Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
*/ 

string ToBin(int num)
{
    string temp = "";
    while(num>0)
    {
        temp += Convert.ToString(num%2);
        num = num/2;
    }
    string res = "";
    for (int i = (temp.Length-1); i >= 0; i--)
    {
        res += temp[i];
    }
    return res;
}
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{N} -> {ToBin(N)}");