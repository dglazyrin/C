void N_between (int N1, int N2)
{
     if (N1<N2)
     {
          N1++;
          Console.Write(N1 + " ");
          N_between(N1,N2);
     }
}
int A = new Random().Next(2,20);            
int B = new Random().Next(20,30);            
Console.WriteLine ($"У нас есть две переменные - {A} и {B}");
Console.Write (A + " ");
N_between(A,B);
