/* Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на 
пересечении которых расположен наименьший элемент 
массива
*/ 

System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] my_array = new int[M, N];
CreateAndPrintMatrix(my_array);
System.Console.WriteLine();
FindAndRemoveMin(my_array);


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

void FindAndRemoveMin(int[,] arr){
    int[,] new_array = new int [M-1, N-1];
    int min = arr[0, 0];
    int min_dim1 = 0;
    int min_dim2 = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < min) {
                min = arr[i,j]; 
                min_dim1 = i;
                min_dim2 = j;
            }
        }
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i==min_dim1 || j==min_dim2) continue;
            else if(i>min_dim1 && j>min_dim2) new_array[i-1,j-1] = arr[i,j];
            else if(i>min_dim1) new_array[i-1, j] = arr[i,j];
            else if(j>min_dim2) new_array[i,j-1] = arr[i,j];
            else new_array[i,j] = arr[i,j];
        }
    }
    PrintMatrix(new_array);
    
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

