/* Задача 56: Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.
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
    PrintMatrix(arr);
    return arr;
}

void FindMinArray(int[,] arr){

    int sum_array;
    int[] sum_dict = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum_array = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum_array+=arr[i,j];
        }
        sum_dict[i] = sum_array;
    }
    
    int min_sum = sum_dict[0];
    int min_pos = 0;
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        if(sum_dict[k]<min_sum) {min_sum = sum_dict[k]; min_pos = k;}
    }

    System.Console.WriteLine($"Строка с наименьшей суммой элементов: {min_pos+1}");
    
}

void PrintMatrix(int[,] arr){
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
  
}

System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] my_array = new int[M, N];
CreateAndPrintMatrix(my_array);
System.Console.WriteLine();
FindMinArray(my_array);