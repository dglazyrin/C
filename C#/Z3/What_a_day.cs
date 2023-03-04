string [] day = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"}; // Массив с днями недели
Console.WriteLine("День-то сегодня какой?");
string input_day_number = Console.ReadLine();                                                  // Спрашиваем номер дня
int day_number = int.Parse(input_day_number) - 1;                                              // Парсим введённое число
day_number = day_number;                                                                       // Ищем название дня в массиве
Console.Write("Значит сегодня - " + day[day_number]);