/* Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/ 

Random rnd = new Random();
int[] my_array = new int[rnd.Next(3, 8)];
int[] new_array = new int[my_array.Length];

void RandArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        int add = rnd.Next(1, 10);
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

void UpDownArray(int[] arr1, int[] arr2)
{
    int k = 0;
    for(int i=(arr1.Length)-1; i>=0; i--)
    {
        arr2[k] = arr1[i];
        k++;
    } 
}

RandArray(my_array);
UpDownArray(my_array, new_array);
System.Console.WriteLine($"[{PrintArray(my_array)}] -> [{PrintArray(new_array)}]");