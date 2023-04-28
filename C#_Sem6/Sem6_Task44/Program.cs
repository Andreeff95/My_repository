/* Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1
*/ 

void Fibon(int x)
{
    int fib1 = 0;
    int fib2 = 1;
    if(x<0)
    {
        System.Console.WriteLine("Неверное число!");
    }
    else if(x==1)
    {
        System.Console.WriteLine($"N = {x} -> {fib1}");
    }
    else if(x==2)
    {
        System.Console.WriteLine($"N = {x} -> {fib1} {fib2}");
    }
    else
    {
        System.Console.WriteLine($"N = {x} -> {fib1} {fib2}");
        for(int i=3; i<=x; i++)
        {
            System.Console.Write($"{fib1+fib2} ");
            fib2 = fib1+fib2;
            fib1 = fib2-fib1;
        }
    }
}

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Fibon(N);
