byte Digit2Number(int X)             // Метод определения разрядности двоичного числа
{
     byte res=1;
     while ((Math.Pow(2,res)<=X))
     {
          res++;
     }
     return res;
}
double Number10To2(int X, byte Y)        // Метод перевода числа 10 -> 2
{
     byte myCount=0;
     double res=0;//Math.Pow(10,Y);
     Console.WriteLine("Начало Х " + X + " Y " + Y + " X-X/2 " + (X%2));
     while (X>0)
     {
          if ((X%2)==1)
          {
               res = res + Math.Pow(10,myCount);     
          }
          X=X/2;
          myCount++;
     }
     return res;
}

int myNumber10 = 257;//new Random().Next(1,12);   //Заглушка для проверки
byte digitNumber = Digit2Number(myNumber10);
double myNumber2 = Number10To2(myNumber10,digitNumber);
Console.WriteLine("У нас есть число - " + myNumber10 + " у него " + digitNumber + " бит.");
Console.WriteLine("В двоичной системе это - " + myNumber2 + " .");