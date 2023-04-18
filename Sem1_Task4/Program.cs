Console.Write("Введите первое число: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num_c = Convert.ToInt32(Console.ReadLine());

int max = num_a;

if(num_b>max)
{
    max = num_b;
}
if(num_c>max)
{
    max = num_c;
}
Console.Write("max = ");
Console.WriteLine(max);