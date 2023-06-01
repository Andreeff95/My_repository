/* Задача 62: Заполните спирально массив 4 на 4.
*/ 

System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] my_array = new int[M, N];
System.Console.WriteLine();
FillSpiral(my_array);


void FillSpiral(int[,] arr){
    int count = 1;
    int pos_x = 0; // текущая позиция по оси x (первое измерение матрицы)
    int pos_y = -1; // текущая позиция по оси y (второе измерение матрицы)
    int mov_x = 0; // направление движения по оси ("0" - ось не смещается,
    int mov_y = 1; // "1" - ось смещается на +1, "-1" - ось смещается на -1)
    while(count<=arr.GetLength(0)*arr.GetLength(1))
    {
        if((0<=pos_x+mov_x && pos_x+mov_x<arr.GetLength(0))&& // проверка на наличие ячейки по оси x (сверху/снизу)
            (0<=pos_y+mov_y&&pos_y+mov_y<arr.GetLength(1))&& // проверка на наличие ячейки по оси y (справа/слева)
            (arr[pos_x+mov_x, pos_y+mov_y]==0)) // проверка на наличие незаполненной ячейки
        {
            pos_x+=mov_x; pos_y+=mov_y;
            arr[pos_x, pos_y] = count++;
        }
        else
        {
            if(mov_y==1) // поворот вниз
            {
                mov_y=0; mov_x=1;
            }
            else if(mov_x==1) // поворот налево
            {
                mov_x=0; mov_y=-1;
            }
            else if(mov_y==-1) // поворот наверх
            {
                mov_y=0; mov_x=-1;
            }
            else if(mov_x==-1) // поворот направо
            {
                mov_x=0; mov_y=1;
            }
        }
    }
    PrintMatrix(arr);

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

