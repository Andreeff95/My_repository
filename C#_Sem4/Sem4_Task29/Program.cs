/* Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
*/

int num = 8;
int[] my_array = new int[num];

void RandArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] =  new Random().Next(1, 100);
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
