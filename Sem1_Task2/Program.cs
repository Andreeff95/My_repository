Console.Write("Введите первое число: ");
string num_a = Console.ReadLine();
Console.Write("Введите второе число: ");
string num_b = Console.ReadLine();
if(int.Parse(num_a)>int.Parse(num_b))
{
    Console.Write("max = ");
    Console.WriteLine(num_a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num_b);
}
