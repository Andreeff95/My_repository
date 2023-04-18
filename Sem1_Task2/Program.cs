Console.Write("Введите первое число: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_b = Convert.ToInt32(Console.ReadLine());
if(num_a>num_b)
{
    Console.Write("max = ");
    Console.WriteLine(num_a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num_b);
}
