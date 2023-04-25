/* Задайте массив вещественных чисел. Найдите 
разницу между максимальным и минимальным элементов 
массива.
*/ 

double[] my_array = new double[4];
Random rnd = new Random();
void RandArray(double[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        double add = Math.Round((rnd.Next(-9999, 10000))*0.01, 2);
        arr[i] = add;
    }
}

string PrintArray(double[] arr)
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

double GetDiff(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>max)
        {
            max=arr[i];
        } else if(arr[i]<min) 
        {
            min=arr[i];
        }
    }
    return Math.Round(max-min, 2);
}


RandArray(my_array);
System.Console.WriteLine($"[{PrintArray(my_array)}] -> {GetDiff(my_array)}");