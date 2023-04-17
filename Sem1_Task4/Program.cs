Console.Write("Введите первое число: ");
string num_a = Console.ReadLine();
Console.Write("Введите второе число: ");
string num_b = Console.ReadLine();
Console.Write("Введите третье число: ");
string num_c = Console.ReadLine();
int a = int.Parse(num_a);
int b = int.Parse(num_b);
int c = int.Parse(num_c);
int max = a;

if(b>max)
{
    max = b;
}
if(c>max)
{
    max = c;
}
Console.Write("max = ");
Console.WriteLine(max);