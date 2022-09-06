// массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateArray(int size)
      {
            int[]array = new int[size];
            for (int i = 0; i < size; i++)
                {
                    array[i] = new Random().Next(100, 1000);
                    if (i!=size-1) Console.Write($"{array[i]}, ");
                    else Console.WriteLine($"{array[i]}");
                }
            return array;
      }
Console.Write("Введите количество элементов массива: ");
int n =Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] mas=CreateArray(n);
foreach (int item in mas)
    {
        if (item % 2 == 0) count++;
    }
Console.Write("Количество четных чисел в массиве = "+count);
    