// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string SearchQuarter(int x, int y) 
{
    if(x==0 && y==0){
        Console.WriteLine("Точка находится в центре координат.");
    } else if(x==0 && y!=0){
        Console.WriteLine("Точка находится на оси X.");
    } else if(x!=0 && y==0){
        Console.WriteLine("Точка находится на оси Y.");
    } else if(x>0 && y>0){
        Console.WriteLine("Точка находится в первой четверти.");
    } else if(x<0 && y>0){
        Console.WriteLine("Точка находится во второй четверти.");
    }else if(x>0 && y<0){
        Console.WriteLine("Точка находится в третьей четверти.");
    } else if(x<0 && y<0) {
        Console.WriteLine("Точка находится в четвертой четверти.");
    } else {
        Console.WriteLine("Ошибка ввода!");
    }
}

SearchQuarter(x, y); */

 int ReadInt(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    int i;
    while(!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число.");
    }
    return i;
}

int GetQuart(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    } else if(x < 0 && y > 0)
    {
        return 2;
    } else if(x > 0 && y < 0)
    {
        return 3;
    } else if(x < 0 && y < 0)
    {
        return 4;
    }
    else {
        return 0;
    }
}
int x = ReadInt("X");
int y = ReadInt("Y");
System.Console.WriteLine($"Точка находится в {GetQuart(x, y)} четверти.");
