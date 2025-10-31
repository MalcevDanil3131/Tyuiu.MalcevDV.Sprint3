using Tyuiu.MalcevDV.Sprint3.Task0.V13.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #2", width);
PrintCenteredLine("Тема: Создание итогового решения по спринту", width);
PrintCenteredLine("Задание #7", width);
PrintCenteredLine("Вариант #6", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, которое вычисляет сумму ряда", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine("Введите :", width);
DataService ds = new DataService();
double value = 0.5;
int startValue = 1;
int stopValue = 20;
Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);
var res = ds.GetSumSeries(value, startValue, stopValue);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{res}", width);
Console.WriteLine(new string('*', width));