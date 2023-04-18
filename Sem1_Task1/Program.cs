/* Напишите программу, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго.
Python:
num_1 = int(input())
num_2 = int(input())
if num_1 = num_2**2:
    print("Да")
else:
    print("Нет")
*/

Console.Write("Введите первое число: ");
string num_1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string num_2 = Console.ReadLine();
if(Convert.ToInt32(num_1)==(Convert.ToInt32(num_2))*(Convert.ToInt32(num_2)))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}