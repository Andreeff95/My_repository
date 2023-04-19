/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. "456" -> "46"
*/ 
int RandNum = new Random().Next(100, 1000);
System.Console.WriteLine(RandNum);
RandNum = (RandNum/100)*10+RandNum%10;
System.Console.WriteLine(RandNum);
