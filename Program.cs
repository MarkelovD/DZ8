Console.WriteLine("введите число строк");
int rows = int.Parse(Console.ReadLine()!);// строки
Console.WriteLine("введите число столбцов");
int columns = int.Parse(Console.ReadLine()!);//столбцы
int[,] array = GetArray(rows, columns, 0, 10); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
PrintArray(array); //печать массива
Console.WriteLine("");
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
SortingArray(array);
// вывод массива
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    { // заполнение строк (0)
        for (int j = 0; j < Array.GetLength(1); j++)
        { // заполнение столбцов (1)
            Console.Write($"{Array[i, j]} "); // вывод заполненого массива
        }
        Console.WriteLine(); // переход но новую строку массива
    }
}



// метод заполнения массива случайными числами
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];// присвоение массиву временного значения
    for (int i = 0; i < m; i++)
    {// проход по строкам
        for (int j = 0; j < n; j++)
        {// проход по столбцам
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result; //возвращение заполненного массива
}
void SortingArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)//проход по строкам
    { // заполнение строк (0)
        for (int j = 0; j < Array.GetLength(1); j++)// проход по столбцам
        { // заполнение столбцов (1)
            for (int k = j + 1; k < Array.GetLength(1); k++)// цикл для сравнения значений относительно предыдущего элемента
            {
                if (Array[i, j] < Array[i, k])
                {
                    int temp = Array[i, j];//пузырьковая сортировка
                    Array[i, j] = Array[i, k];
                    Array[i, k] = temp;
                    continue;
                }
            }
            Console.Write($"{Array[i, j]} "); // вывод заполненого массива
        }
        Console.WriteLine(); // переход но новую строку массива
    }
}