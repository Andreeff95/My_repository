/* Напишите программу, которая 
выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
*/ 

int num = 8;
int[] my_array = new int[num];

void RandArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        int bin = new Random().Next(0, 2);
        arr[i] = bin;
    }
}

void PrintArray(int[] arr)
{
    foreach(var v in arr)
    {
        System.Console.Write($"{v}, ");
    }
}
RandArray(my_array);
PrintArray(my_array);
