/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
*/ 

System.Console.Write("Введите количество строк M (первое измерение): ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N (второе измерение): ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество рядов O (третье измерение): ");
int O = Convert.ToInt32(Console.ReadLine());

int[,,] my_array = new int[M, N, O];
System.Console.WriteLine();
CreateAndPrint3dMatrix(my_array);

int[,,] CreateAndPrint3dMatrix(int[,,] arr)
{
    Random rnd = new Random();
    int[] Dict = new int[M*N*O]; 
    int get_rnd;
    int check;
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                do
                {
                get_rnd = rnd.Next(10, 99);
                check = 1;
                foreach (var item in Dict)
                {
                    if(get_rnd == item) check = 0;
                }
                } while (check == 0);
                
                arr[i, j, k] = get_rnd;
                Dict[count++] = get_rnd;

            }
        }
    }
    PrintMatrix(arr);
    foreach (var item in Dict)
    {
        System.Console.Write($"{item}  ");
    }
    return arr;
}

void PrintMatrix(int[,,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           for (int k = 0; k < arr.GetLength(2); k++)
           {
                System.Console.WriteLine($"{i} {j} {k} => {arr[i, j, k]}");
           }
        }
        
    }
  
}

