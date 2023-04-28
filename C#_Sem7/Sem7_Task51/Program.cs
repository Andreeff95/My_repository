/* Задача 51: Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/ 

System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] my_array = new int[M, N];
int[,] CreateAndPrintMatrix(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i==j)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
    return arr;
}

int SumElem(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i==j)
            {
                sum+=arr[i, j];
            }
        }
    }
    return sum;
    
}


CreateAndPrintMatrix(my_array);
System.Console.WriteLine($"Сумма элементов на главной диагонали: {SumElem(my_array)}");

