/* Напишите программу, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго.
*/

Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if(num_1==num_2*num_2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}