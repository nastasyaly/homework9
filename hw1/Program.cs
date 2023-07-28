//Задача 64: Задайте значение m n. 
//Напишите программу, которая выведет 
//все натуральные числа в промежутке от m до n. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int number2 = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber.ToString();
    return firstNumber + " , " + PrintNumbers(firstNumber + 1, secondNumber);
}

Console.WriteLine($"числа от {number1} до {number2} = {PrintNumbers(number1, number2)}");