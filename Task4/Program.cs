// Напишите программу, которая принимает на вход число любой размерности и проверяет, является ли оно палиндромом.
Console.Write("Введите число: ");
int n =Convert.ToInt32(Console.ReadLine());
if (n<0) n=n*-1;
int i=0, j=1, m=n, k=n;
    while (m > 10)
        {   m=m/10;
            j=j+1;     }
int[]array = new int[j];
    while (n > 10)
        {   array [i]=n%10;
            n=n/10;
            i++;    }
array[i]=n; j=1;
int palindrome=0;
    for (i = 0; i < array.Length; i++)
        {   palindrome=palindrome+array[array.Length-1-i]*j;
            j=j*10;     }
if (palindrome == k) Console.Write("Это число палиндром.");
else Console.Write("Это число не палиндром.");
