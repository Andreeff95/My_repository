/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
*/
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
switch(N) {
    case 1:{
        System.Console.WriteLine("Понедельник");
        break;
    }
    case 2:{
        System.Console.WriteLine("Вторник");
        break;
    }
    case 3:{
        System.Console.WriteLine("Среда");
        break;
    }
    case 4:{
        System.Console.WriteLine("Четверг");
        break;
    }
    case 5:{
        System.Console.WriteLine("Пятница");
        break;
    }
    case 6:{
        System.Console.WriteLine("Суббота");
        break;
    }
    case 7:{
        System.Console.WriteLine("Воскресенье");
        break;
    }
    default:{
        System.Console.WriteLine("Число несоответствует дню недели");
        break;
    }
}
