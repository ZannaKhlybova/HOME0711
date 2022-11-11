//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
Double FindPr(Double a,int b)
 {
   Double prois = 1;
   for (int i=1;i<=b;i++)
   
      prois=prois*a;
      return prois;
 } 
Console.Write("Ввeдите,пожалуйста, число: ");
Double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввeдите,пожалуйста, степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} в степени {b} равно {FindPr(a,b)}");
*/
//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
/*
int FindSum(int a)
{
   int remainder = a % 10;
   int sum = remainder;
   int divid = a / 10;
   while (divid > 0)
   {
      remainder = divid % 10;
      sum = sum + remainder;
      divid = divid / 10;
   }
   return sum;
}
Console.Write("Ввeдите,пожалуйста, целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма цифр числа {a} равна {FindSum(a)}");
*/
//Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
void Mass()
{
int[] arr = {1,2,5,7,19,6,1,33};
int n = arr.Length;
for(int index=0;index<n;index++)
{
 Console.Write($"{arr[index]} ");
}
}
Mass();


