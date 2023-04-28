/* Задача 46: Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
*/ 



System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

void CreateAndPrintMatrix(int a, int b)
{
    Random rnd = new Random();
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int add = rnd.Next(1, 10);
            arr[i, j] = add;
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

CreateAndPrintMatrix(M, N);