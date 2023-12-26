// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = new int [6];

CreateArray();
int[] CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 50);
        System.Console.Write(array[i] + ", ");
    }  
    return array;
}

Console.WriteLine();

string str = "";

PrintElements();
void PrintElements()
{
    for (int i = array.Length-1; i >= 0; i--)
    {
    str += array[i]; 
    Console.Write(array[i] + ", ");
    }
}