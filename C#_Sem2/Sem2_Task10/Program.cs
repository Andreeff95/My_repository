/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/ 
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num>=100 && num<=999){
    System.Console.WriteLine((num/10)%10);
} else {
    System.Console.WriteLine("Введено неверное число");
}