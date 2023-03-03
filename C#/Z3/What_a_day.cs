string [] day = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
Console.WriteLine("День-то сегодня какой?");
string input_day_number = Console.ReadLine();
int day_number = int.Parse(input_day_number) - 1;
day_number = day_number;
Console.Write("Значит сегодня - " + day[day_number]);