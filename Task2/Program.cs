// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray(int size)
      {
            int[]array = new int[size];
            for (int i = 0; i < size; i++)
                {
                    array[i] = new Random().Next(1, 100);
                    if (i!=size-1) Console.Write($"{array[i]}, ");
                    else Console.WriteLine($"{array[i]}");
                }
            return array;
      }
Console.Write("Введите количество элементов массива: ");
int n =Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] mas=CreateArray(n);
for (int i = 1; i < mas.Length; i++)
    {
       if (i % 2 == 1) sum=sum+mas[i];
    }
Console.Write("Cумма элементов, стоящих на нечётных позициях = "+sum);