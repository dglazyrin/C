int A = new Random().Next(1,1000);
Console.Write("У нас есть число " + A + " и его третья цифра ");
if (((A%1000-A%100)/100) > 0)
{
     Console.Write((A%1000-A%100)/100);
}
else
{
     Console.Write("отсутствует.");
}