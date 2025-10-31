using Tyuiu.MalcevDV.Sprint3.Task5.V17.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #3", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #3", width);
PrintCenteredLine("Вариант #23", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которая заменяет символы в строке", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
DataService ds = new DataService();
int x = 2;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 12;
Console.WriteLine("Переменная X = " + x);
Console.WriteLine("Старт шага1 = " + startValue1);
Console.WriteLine("Конец шага1= " + stopValue1);
Console.WriteLine("Старт шага2= " + startValue2);
Console.WriteLine("Конец шага2 = " + stopValue2);
var res = ds.GetSumSumSeries(startValue1, stopValue1, startValue2, stopValue2, x);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{res}", width);
Console.WriteLine(new string('*', width));
