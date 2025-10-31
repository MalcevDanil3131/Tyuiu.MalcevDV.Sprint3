using Tyuiu.MalcevDV.Sprint3.Task7.V26.Lib;
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
var ds = new DataService();
int startValue = -5; int stopValue = 5;
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага= " + stopValue);
int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] res = new double[len];
res = ds.GetMassFunction(startValue, stopValue);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    X     |   f(x)    |");
Console.WriteLine("+----------+-----------+");
for (int i = 0; i < len; i++)
{
    Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, res[i]);
    startValue++;
}
Console.WriteLine("+----------+-----------+");
Console.WriteLine(new string('*', width));