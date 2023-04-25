/*Задайте одномерный массив из 10 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. 
*/ 

int[] my_array = new int[10];
Random rnd = new Random();
void RandArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        int add = rnd.Next(0, 200);
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

int FindElem(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]>=10 && arr[i]<=99)
        {
            count++;
        }
    }
    return count;
}

RandArray(my_array);
System.Console.WriteLine($"[{PrintArray(my_array)}] -> {FindElem(my_array)}");