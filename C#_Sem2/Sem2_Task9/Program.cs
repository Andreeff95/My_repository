/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
N = input("Введите число от 10 до 99")
if len(N)==2:
    if int(N[0])>int(N[1]):
        print(N[0])
    else:
        print(N[1])
else:
    print("Введено неверное число")
*/

int N = new Random().Next(10, 100);
if(N/10>N%10){
    System.Console.WriteLine(N/10);
} else {
    System.Console.WriteLine(N%10);
}