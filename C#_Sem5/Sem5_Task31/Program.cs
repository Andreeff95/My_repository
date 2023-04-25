/* Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
*/ 

void Task31()
{
    int[] my_array = new int[12];
    Random rnd = new Random();
    void RandArray(int[] arr)
    {
        for(int i=0; i<arr.Length; i++)
        {
            int add = rnd.Next(-9, 10);
            arr[i] = add;
        }
    }

    void PrintArray(int[] arr)
    {
        foreach(var v in arr)
        {
            System.Console.Write($"{v}, ");
        }
        System.Console.WriteLine("");
    }

    int SumPlus(int[] arr)
    {
        int plus = 0;
        for(int i=0; i<arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                plus += arr[i];
            }
            else
            {
                continue;
            }
        }
        return plus; 
    }

    int SumMinus(int[] arr)
    {
        int minus = 0;
        for(int i=0; i<arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                continue;
            }
            else
            {
                minus += arr[i];
            }
        }

        return minus; 
    }

    RandArray(my_array);
    PrintArray(my_array);
    System.Console.WriteLine($"Сумма положительных чисел: {SumPlus(my_array)}. Сумма отрицательных чисел: {SumMinus(my_array)}.");
}
Task31();
