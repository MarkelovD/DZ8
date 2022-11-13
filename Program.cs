// Console.WriteLine("введите число строк");
// int rows = int.Parse(Console.ReadLine()!);// строки
// Console.WriteLine("введите число столбцов");
// int columns = int.Parse(Console.ReadLine()!);//столбцы
// int[,] array = GetArray(rows, columns, 0, 10); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
// PrintArray(array); //печать массива
// Console.WriteLine("");
// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// //по убыванию элементы каждой строки двумерного массива.
// //SortingArray(array);
// // вывод массива
//void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     { // заполнение строк (0)
//         for (int j = 0; j < Array.GetLength(1); j++)
//         { // заполнение столбцов (1)
//             Console.Write($"{Array[i, j]} "); // вывод заполненого массива
//         }
//         Console.WriteLine(); // переход но новую строку массива
//     }
// }



// // метод заполнения массива случайными числами
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];// присвоение массиву временного значения
//     for (int i = 0; i < m; i++)
//     {// проход по строкам
//         for (int j = 0; j < n; j++)
//         {// проход по столбцам
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result; //возвращение заполненного массива
// }
// void SortingArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)//проход по строкам
//     { // заполнение строк (0)
//         for (int j = 0; j < Array.GetLength(1); j++)// проход по столбцам
//         { // заполнение столбцов (1)
//             for (int k = j + 1; k < Array.GetLength(1); k++)// цикл для сравнения значений относительно предыдущего элемента
//             {
//                 if (Array[i, j] < Array[i, k])
//                 {
//                     int temp = Array[i, j];//пузырьковая сортировка
//                     Array[i, j] = Array[i, k];
//                     Array[i, k] = temp;
//                     continue;
//                 }
//             }
//             Console.Write($"{Array[i, j]} "); // вывод заполненого массива
//         }
//         Console.WriteLine(); // переход но новую строку массива
//     }
// }
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// MaxSumm(array);
// //метод суммы чисел в строках 2 задача
// void MaxSumm(int[,] Array)
// {
//     int StartSumm = 0;// переменная для нахождения суммы элементов массива 0 строки
//     int pozition = 0;//переменная для обозначения нужной строки
//     for (int i = 0; i < array.GetLength(1); i++)//цикл для нахождения суммы 0 строки
//     {
//         StartSumm += array[0, i];
//     }
//     for (int j = 1; j < array.GetLength(0); j++)//цикл перебора сумм строк и
//     {
//         int sum = 0;//делаем обнуление на кадой строке
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             sum += array[j, k];
//         }
//         if (sum > StartSumm)
//         {
//             StartSumm = sum;
//             pozition = j;
//         }
//     }
//     Console.WriteLine($"максимальная сумма элементов строки массива ={StartSumm} индекс строки №{pozition}");
// }
//Задача 58: Задайте две квадратные матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
// Console.WriteLine("введите число строк 1 матрицы");
// int rows1 = int.Parse(Console.ReadLine()!);// строки
// Console.WriteLine("введите число столбцов 1 матрицы");
// int columns1 = int.Parse(Console.ReadLine()!);//столбцы
// int[,] array = GetArray1(rows1, columns1, 0, 10); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
// PrintArray1(array); //печать массива
// Console.WriteLine("");
// // блок параметров и вывода 2 массива
// Console.WriteLine("введите число строк 2 матрицы");
// int rows2 = int.Parse(Console.ReadLine()!);// строки
// Console.WriteLine("введите число столбцов 2 матрицы");
// int columns2 = int.Parse(Console.ReadLine()!);//столбцы
// int[,] array2 = GetArray2(rows2, columns2, 0, 10); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
// PrintArray2(array2); //печать массива
// Console.WriteLine("");
// //проверка выполнения условия перемножения матриц
// if (columns1 != rows2)
// {
//     Console.WriteLine("перемножение матриц невозможно");
//     return;
// }

// // //блок параметров и вывода суммы массивов
// int[,] FinalMass = GetArray3(array, array2); // принимаем 1 и 2 массив на вход для работы с ними
// Console.WriteLine("Результ перемножения матриц");
// PrintArray3(FinalMass); //печать массива
// Console.WriteLine("");

// // // блок методов для работы с 1 массивом
// void PrintArray1(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     { // заполнение строк (0)
//         for (int j = 0; j < Array.GetLength(1); j++)
//         { // заполнение столбцов (1)
//             Console.Write($"{Array[i, j]} "); // вывод заполненого массива
//         }
//         Console.WriteLine(); // переход но новую строку массива
//     }
// }
// // // метод заполнения массива случайными числами
// int[,] GetArray1(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];// присвоение массиву временного значения
//     for (int i = 0; i < m; i++)
//     {// проход по строкам
//         for (int j = 0; j < n; j++)
//         {// проход по столбцам
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result; //возвращение заполненного массива
// }
// // // блок методов для работы с 1 массивом
// void PrintArray2(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     { // заполнение строк (0)
//         for (int j = 0; j < Array.GetLength(1); j++)
//         { // заполнение столбцов (1)
//             Console.Write($"{Array[i, j]} "); // вывод заполненого массива
//         }
//         Console.WriteLine(); // переход но новую строку массива
//     }
// }
// // // метод заполнения массива случайными числами для 2
// int[,] GetArray2(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];// присвоение массиву временного значения
//     for (int i = 0; i < m; i++)
//     {// проход по строкам
//         for (int j = 0; j < n; j++)
//         {// проход по столбцам
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result; //возвращение заполненного массива
// }
// // //метод заполнения массива произведением 1 и 2 массива
// int[,] GetArray3(int[,] array, int[,] array2)
// {
//     int[,]FinalResult= new int[array.GetLength(0),array2.GetLength(1)];
//     for (int i=0;i<array.GetLength(0);i++){
//         for(int j=0;j<array2.GetLength(1);j++){
//             for(int k=0;k<array.GetLength(1);k++){
//                 FinalResult[i,j]+=array[i,k]*array2[k,j];                
//             }
//         }
//     }
//     return FinalResult;
// }
// // //вывод матрицы с результатами
// void PrintArray3(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     { // заполнение строк (0)
//         for (int j = 0; j < Array.GetLength(1); j++)
//         { // заполнение столбцов (1)
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
Console.WriteLine("введите число строк");
int rows = int.Parse(Console.ReadLine()!);
//Кол-во столбцов
Console.WriteLine("введите число столбцов");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число страниц");
int Page = int.Parse(Console.ReadLine()!);
int[,,] array = GetArray3(Page, rows, columns, 10, 99); // вызов метода (rows)-строки (columns)-стобцы,мин знач, макс знач
PrintArray3(array); //печать массива

void PrintArray3(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    { // заполнение страниц (0)
        Console.WriteLine($"Page {i}");
        for (int j = 0; j < Array.GetLength(1); j++)
        { // заполнение строк (1)
            for (int k = 0; k < Array.GetLength(2); k++)
            { // заполнение столбцов (1)
                Console.Write($"{Array[i, j, k]} ({i},{j},{k}) "); // вывод заполненого массива
            }
            Console.WriteLine(); // переход но новую строку массива
        }
        Console.WriteLine("====================");
    }
}
// // метод заполнения массива случайными числами 3х мерного массива
int[,,] GetArray3(int m, int n, int h, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, h];// присвоение массиву временного значения
    for (int i = 0; i < m; i++)
    {// проход по строкам
        for (int j = 0; j < n; j++)
        {// проход по столбцам
            int k = 0;
            while (k < h)
            {
                int numb = new Random().Next(minValue, maxValue + 1);
                if (UniqueNumbers(result, numb)) continue;
                result[i, j, k] = numb;
                k++;
            }
        }
    }
    return result; //возвращение заполненного массива
}
bool UniqueNumbers(int[,,] Array, int num)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                if (Array[i, j, k] == num) return true;
            }
        }
    }
    return false;
}
