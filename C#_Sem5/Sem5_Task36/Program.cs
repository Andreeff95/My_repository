/* Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов с 
нечётными индексами.
*/ 

int[] my_array = new int[4];
Random rnd = new Random();
void RandArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        int add = rnd.Next(-99, 100);
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

int SumOdd(int[] arr)
{
    int sum = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(i%2==1)
        {
            sum+=arr[i];
        }
    }
    return sum;
}

RandArray(my_array);
System.Console.WriteLine($"[{PrintArray(my_array)}] -> {SumOdd(my_array)}");