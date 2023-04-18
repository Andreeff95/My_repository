/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
*/
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
switch(N){
    case 1:{
        System.Console.WriteLine("Понедельник");
    }
    case 2:{
        System.Console.WriteLine("Вторник");
    }
    case 3:{
        System.Console.WriteLine("Среда");
    }
    case 4:{
        System.Console.WriteLine("Четверг");
    }
    case 5:{
        System.Console.WriteLine("Пятница");
    }
    case 6:{
        System.Console.WriteLine("Суббота");
    }
    case 7:{
        System.Console.WriteLine("Воскресенье");
    }
    default:{
        System.Console.WriteLine("Число несоответствует дню недели");
    }
}
