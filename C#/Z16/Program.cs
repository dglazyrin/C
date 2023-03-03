int A = new Random().Next(1,13);
int B = new Random().Next(1,31);                                 // Загадаем два числа
int A_square = A*A; 
int B_square = B*B;                                              // Сразу найдём квадраты этих чисел
string Square_flag = " не";                                      // Флаг условия "В не является квадратом А"
Console.WriteLine("Есть два числа - " + A + " и " + B);          // Вывод полученных чисел
Console.WriteLine("Квадрат первого - " + A_square + ", квадрат второго - " + B_square);   // Вывод квадратов
if (A_square==B)                                                                          // Второе является квадратом первого?
{
   Square_flag = "";                                                                      // Если нет - используем приставку "НЕ"
}
Console.WriteLine("Число " + B + Square_flag + " является квадратом числа " + A);        
if (A>B)
{
     Console.WriteLine("Число " + A + " больше числа " + B);
}
else
     Console.WriteLine("Число " + A + " меньше числа " + B);