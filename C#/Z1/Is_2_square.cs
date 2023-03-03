int A = new Random().Next(1,100);
int B = new Random().Next(1,100);                                 // Загадаем два числа
int B_square = B*B;                                              // Сразу найдём квадраты этих чисел
string Square_flag = " не";                                      // Флаг условия "В не является квадратом А"
Console.WriteLine("Есть два числа - " + A + " и " + B);          // Вывод полученных чисел
if (B_square==A)                                                                          // Второе является квадратом первого?
{
   Square_flag = "";                                                                      // Если нет - используем приставку "НЕ"
}
Console.WriteLine("Число " + A + Square_flag + " является квадратом числа " + B);