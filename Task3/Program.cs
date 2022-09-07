// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateArray(int size)
      {
            double[]array = new double[size];
            for (int i = 0; i < size; i++)
                {
                    array[i] =Math.Round(new Random().Next(1,20) + new Random().NextDouble(),2);
                    if (i!=size-1) Console.Write($"{array[i]}; ");
                    else Console.WriteLine($"{array[i]} - наш массив");
                }
            return array;
      }
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] mas=CreateArray(n);
double max = mas[0], min = mas[0], difference = 0;
for (int i = 1; i < mas.Length; i++)
    {
       if (mas[i] > max) max=mas[i];
       if (mas[i] < min) min=mas[i];
    }
difference = Math.Round(max - min , 2);    
Console.Write("Разница между максимальным и минимальным элементом массива = "+difference);