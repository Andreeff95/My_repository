/* Задача 57: Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент 
входных данных.
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

void FractalDict(int[,] arr){
    int[] Dict = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Dict[arr[i, j]]++;
        }
    }
    
    for (int k = 0; k < Dict.Length; k++)
    {
        if(Dict[k]>0){
            System.Console.WriteLine($"Цифра {k} встречается {Dict[k]} раз.");
        }
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
FractalDict(my_array);