/*Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в 
массиве. 
*/ 

int[] my_array = new int[4];
Random rnd = new Random();
void RandArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        int add = rnd.Next(100, 1000);
        arr[i] = add;
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

int FindEven(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

RandArray(my_array);
System.Console.WriteLine($"[{PrintArray(my_array)}] -> {FindEven(my_array)}");