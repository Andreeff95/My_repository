/*Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.

*/ 

int[] my_array = new int[4];
Random rnd = new Random();
void RandArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        int add = rnd.Next(-10, 11);
        arr[i] = add;
    }
}

string PrintArray2(int[] arr)
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

string FindNum(int x, int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        if(x == arr[i])
        {
            return "Да";
        }
    }
    return "Нет";
}

RandArray(my_array);
// PrintArray1(my_array);
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{N}; массив [{PrintArray2(my_array)}] -> {FindNum(N, my_array)}");