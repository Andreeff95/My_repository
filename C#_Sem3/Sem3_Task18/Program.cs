/* Напишите программу, которая по 
заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/ 
Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());
switch(x){
    case 1:
        System.Console.WriteLine("Диапазон возможных кооринат: x>0, y>0");
        break;
    case 2:
        System.Console.WriteLine("Диапазон возможных кооринат: x<0, y>0");
        break;
    case 3:
        System.Console.WriteLine("Диапазон возможных кооринат: x>0, y<0");
        break;
    case 4:
        System.Console.WriteLine("Диапазон возможных кооринат: x<0, y<0");
        break;
    default:
        System.Console.WriteLine("Ошибка ввода!");
        break;
}
