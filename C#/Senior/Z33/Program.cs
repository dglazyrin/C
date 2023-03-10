int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 12; i++)
     {
          X[i]=new Random().Next(0,10);
     }
     return X;
}
void ShowMass(int[] Y)         //Метод вывода массива
{
     Console.WriteLine("А массив у нас такой - ");
     for (int i = 0; i < 12; i++)
     {
          Console.Write(Y[i] + " ");
     }
}
///////////////
// Каких положительных/отрицательных, если диапазон 0-9?
///////////////

int []MyMass = new int[12];
FillMass (MyMass);
ShowMass (MyMass);