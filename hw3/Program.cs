//Задача 68: Напишите программу
 //вычисления функции Аккермана с помощью рекурсии. 
 //Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29



int countAkkerman (int n, int m)
{
  if(n  == 0) return m + 1;
  else if(m == 0) return countAkkerman(n -1, 1);
   return countAkkerman(n-1, countAkkerman(n,m-1));
}

Console.Write("Введите первое число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" функция Аккермана для чисел {number1} и {number2} = {countAkkerman(number1, number2)}");