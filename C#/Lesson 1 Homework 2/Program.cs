string D = Console.ReadLine();
string E = Console.ReadLine();
string F = Console.ReadLine();
int A = int.Parse(D);
int B = int.Parse(E);
int C = int.Parse(F);
Console.Write(A+", "+B+", "+C+" -> max=");
if ((A>B)&&(A>C))
{
   Console.WriteLine(A);
}
else if ((B>A)&&(B>C))
{
   Console.WriteLine(B);
}
else
{
   Console.WriteLine(C);
}