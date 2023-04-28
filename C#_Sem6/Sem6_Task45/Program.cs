/* Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.
*/ 

System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] my_array = new int[size];
int[] new_array = new int[my_array.Length];

void FullArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        System.Console.Write($"Введите {i} элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

string PrintArray(int[] arr)
{
    string res = "";
    for(int i=0; i<(arr.Length)-1; i++)
    {
        res += Convert.ToString(arr[i]);
        res += ", ";
    }
    res += Convert.ToString(arr[(arr.Length)-1]);
    return res;
}

void CopyArray(int[] arr1, int[] arr2)
{
    for(int i=0; i<arr1.Length; i++)
    {
        arr2[i] = arr1[i];
    }
}

FullArray(my_array);
System.Console.WriteLine($"Массив 1: [{PrintArray(my_array)}]");
CopyArray(my_array, new_array);
System.Console.WriteLine($"Массив 2: [{PrintArray(new_array)}]");