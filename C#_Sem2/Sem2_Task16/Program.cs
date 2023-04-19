/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/ 
Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if(num_1==num_2*num_2 || num_2==num_1*num_1){
    System.Console.WriteLine("да");
} else {
    System.Console.Write("нет");
}
