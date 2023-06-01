/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это 
невозможно, программа должна вывести сообщение для 
пользователя.
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

bool ChangeLines(int[,] arr){
    if(arr.GetLength(0)!=arr.GetLength(1)){
        System.Console.WriteLine("Замена невозможна");
        return false;
    }
    else{
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
            // arr[i, j], arr[j, i] = arr[j, i], arr[0, j];
            var temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
            }
        }
        return true;
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

System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] my_array = new int[M, N];
CreateAndPrintMatrix(my_array);
System.Console.WriteLine();
if(ChangeLines(my_array)) PrintMatrix(my_array); 
