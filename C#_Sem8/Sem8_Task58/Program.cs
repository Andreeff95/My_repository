/* Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
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

void MultipleMatrix(int[,] arr1, int[,] arr2){

    if(arr1.GetLength(1)!=arr2.GetLength(0)) System.Console.WriteLine("Произведение двух матриц невозможно!");
    else
    {
        int[,] mult_array = new int[arr1.GetLength(0),arr2.GetLength(1)];
        for (int j = 0; j < arr1.GetLength(0); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                int res = 0;
                for (int i = 0; i < arr1.GetLength(1); i++)
                {
                    res+=arr1[j,i]*arr2[i,k];
                }
                mult_array[j,k] = res;
            }
        }
    PrintMatrix(mult_array);
    }
    
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

System.Console.Write("Введите количество строк M для первой матрицы: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N для первой матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] my_array1 = new int[M, N];
CreateAndPrintMatrix(my_array1);

System.Console.Write("Введите количество строк M для второй матрицы: ");
M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N для второй матрицы: ");
N = Convert.ToInt32(Console.ReadLine());

int[,] my_array2 = new int[M, N];
CreateAndPrintMatrix(my_array2);

System.Console.WriteLine();
MultipleMatrix(my_array1, my_array2);