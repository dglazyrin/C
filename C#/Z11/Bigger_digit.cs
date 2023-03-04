int A = new Random().Next(10,100);
Console.Write("У нас есть число " + A);
if (((A%100-A%10)/10)>(A%10))
{
     Console.Write(" И наибольшая цифра в нём - " + (A%100-A%10)/10);
}
else
{
     Console.Write(" И наибольшая цифра в нём - " + A%10);
}