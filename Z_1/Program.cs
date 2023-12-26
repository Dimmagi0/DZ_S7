// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

void PrintNumbers(int startNum, int endNum)
{
    System.Console.WriteLine(startNum);
    if(startNum >= endNum)
     {  
        return;
    }
    PrintNumbers(startNum+1, endNum);
}
PrintNumbers(numM, numN);