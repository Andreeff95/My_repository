/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку 
массива.
*/ 

int[,] CreateAndPrintMatrix(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
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
    return arr;
}

void ChangeLines(int[,] arr){
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        // arr[0, j], arr[(arr.GetLength(0)-1), j] = arr[(arr.GetLength(0)-1), j], arr[0, j];
        var temp = arr[0, j];
        arr[0, j] = arr[(arr.GetLength(0)-1), j];
        arr[(arr.GetLength(0)-1), j] = temp;
    }
}
void PrintMatrix(int[,] arr){
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i==0 || i==arr.GetLength(0)-1)
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
}

System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] my_array = new int[M, N];
CreateAndPrintMatrix(my_array);
System.Console.WriteLine();
ChangeLines(my_array);
PrintMatrix(my_array);