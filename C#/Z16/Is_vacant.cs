int WhatADay(string arg)
{
     int result = int.Parse(arg)-1;              // Парсим введённое число
     return result;
}
string [] day = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"}; // Массив с днями недели
Console.WriteLine("День-то сегодня какой?");      // Спрашиваем номер дня
string input_day_number = Console.ReadLine();                       
int day_number = WhatADay(input_day_number);
Console.Write("Значит сегодня - " + day[day_number]);
if((day_number+1)<6)
{
     Console.WriteLine(", идите работать!");
}
else
{
     Console.WriteLine(", отдыхайте!");
}