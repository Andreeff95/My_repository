/* Напишите программу, которая которая будет принимать два числа и выводить, является ли второе число кратное первому. 
   Если число 2 не кратно числу 1, то программа выводит остаток от деления.
*/
Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if(num_1%num_2==0){
    System.Console.WriteLine("кратно");
} else {
    System.Console.Write("не кратно, остаток ");
    System.Console.WriteLine(num_1%num_2);
}
