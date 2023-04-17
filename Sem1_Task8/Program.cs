Console.Write("Введите число N: ");
string N = Console.ReadLine();
int i = 0;
while(i<=int.Parse(N))
{
    if(i%2==0)
    {
        Console.Write(i + " ");
    }
    i++;
}