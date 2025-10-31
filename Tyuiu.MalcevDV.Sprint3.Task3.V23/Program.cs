using Tyuiu.MalcevDV.Sprint3.Task3.V23.Lib;
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
string value = "fdsst siu vsrs";
char replaceable = 's';
char replacement = '8';
Console.WriteLine("Строка = " + value);
Console.WriteLine("Заменяемый символ = " + replaceable);
Console.WriteLine("Заменяющий символ = " + replacement);
var res = ds.ReplaceCharOnNum(value, replaceable, replacement);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"{res}", width);
Console.WriteLine(new string('*', width));