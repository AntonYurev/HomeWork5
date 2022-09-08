// принимает на вход координаты точек и находит расстояние между ними 
// в N-мерном пространстве. N - задается пользователем.
Console.Write("Введите число N-мерного пространства: ");
int n =Convert.ToInt32(Console.ReadLine());
int[,] array = new int[2,n];
void PrintArray(int[,] len)
{
    for (int i = 0; i < len.GetLength(0); i++)
    {
    Console.Write($"Координаты {i+1}-ой точки: ");    
        for (int j = 0; j< len.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(0, 30);
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();    
    }
}
PrintArray(array);
double sqr=0;
for (int i=0; i<n; i++) sqr=sqr+(array[0,i]-array[1,i])*(array[0,i]-array[1,i]);
sqr = Math.Round(Math.Sqrt(sqr),0);
Console.WriteLine($"Расстояние между точками равно: {sqr}"); 