//Задача 66: Задайте значения M и N. Напишите программу, к
//оторая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.WriteLine(" введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int findSum(int m, int n)
{
  if(m > n) return 0;
  return m + findSum(m+1, n);
}

Console.WriteLine($"сумма натуральных элементов в промежутке от {number1} до {number2} = {findSum(number1,number2)}");