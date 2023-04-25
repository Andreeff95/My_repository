﻿/*Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
*/ 

int[] my_array = new int[4];
int[] new_array = new int[my_array.Length/2];
Random rnd = new Random();
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

void FillArray(int[] arr1, int[] arr2)
{
    for(int i=0; i<arr2.Length; i++)
    {
        arr2[i] = arr1[i]*arr1[arr1.Length-(i+1)];
    }
}

RandArray(my_array);
System.Console.Write($"[{PrintArray(my_array)}] -> ");
FillArray(my_array, new_array);
System.Console.WriteLine($"{PrintArray(new_array)}");