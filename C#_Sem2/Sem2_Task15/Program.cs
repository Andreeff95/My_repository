/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/ 
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if(num == 6 || num == 7){
    System.Console.WriteLine("Да");
} else if(num>0 && num <6) {
    System.Console.WriteLine("Нет");
} else {
    System.Console.WriteLine("Ошибочное число!");
}