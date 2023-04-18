/* Напишите программу, которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N. 
N = int(input())
N_neg = N-(2*N)
for i in range(N_neg, N+1):
    print(i)
*/
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=-N; i<N; i++){
    System.Console.Write(i+", ");
}
System.Console.WriteLine(N);
