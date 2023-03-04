string D = Console.ReadLine();
string E = Console.ReadLine();
int A = int.Parse(D);
int B = int.Parse(E);
Console.Write("A=" + A + " B=" + B + " -> max=");
if (A>B)
{
   Console.WriteLine(A);
}
else
{
   Console.WriteLine(B);
}