/* Напишите программу замены элементов 
массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
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

// void PrintArray(int[] arr)
// {
//     foreach(var v in arr)
//     {
//         System.Console.Write($"{v}, ");
//     }
//     System.Console.WriteLine("");
// }

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

void ChangeArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = -(arr[i]);
    }
}

RandArray(my_array);
System.Console.WriteLine(PrintArray2(my_array));
ChangeArray(my_array);
System.Console.WriteLine(PrintArray2(my_array));