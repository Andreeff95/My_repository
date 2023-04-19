/* Напишите программу, которая принимает на вход трёхзначное число, а на выходе показывает последнюю цифру этого числа. Пример: "456" -> "6"
Python:
N=input()
if len(N)=3:
    print(N[2])
else:
    print("Введено неверное число")
*/ 
System.Console.Write("Введите трех значное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N>=100 && N<=999){
    System.Console.Write("Последняя цифра этого числа: ");
    System.Console.WriteLine(N%10);
} else{
    System.Console.WriteLine("Введено неверное число");
}