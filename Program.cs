//----------------------------------Exercise #47------------------------------
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
//----------------------------------SOLUTION-----------------------------------

double[,] FillMasReal(int n, int m)
{
    double[,] mas = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine("\t");
        for (int j = 0; j < m; j++)
        {

            mas[i, j] = Math.Round(new Random().NextDouble() * 100);
            System.Console.Write($"\t|{mas[i, j]}");

        }

    }
    System.Console.Write("\n");
    return mas;
}
System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] newArray = FillMasReal(n, m);


//----------------------------------Exercise #50------------------------------
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
//----------------------------------SOLUTION-----------------------------------
/*

object[] SearchElementByIndex(double[,] mas, int[] srch)
{
    object[] result = new object[1];
    if (srch[0] - 1 > mas.GetLength(0) || srch[1] - 1 > mas.GetLength(1)) { result[0] = "Такого числа в массиве нет"; }
    else result[0] = mas[srch[0] - 1, srch[1] - 1];
    return result;

}
System.Console.WriteLine("Введите индекс через пробел");

int[] searchReq = Console.ReadLine().Split().Select(int.Parse).ToArray();

System.Console.WriteLine(SearchElementByIndex(newArray, searchReq)[0]);

object[] SearchElementByValue(double[,] mas, int srch)
{
    object[] result = new object[3];
    result[1] = null;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            result[2] = 0;
            if (Convert.ToInt32(mas[i, j]) == srch) { result[0] = i; result[1] = j; return result; }
            else result[2] = -1;
        }
    }
    if (Convert.ToInt32(result[2]) == -1) result[0] = ("отсутствует в массиве");
    return result;
}
System.Console.Write("Введите искомое число = ");
int srch = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Индекс числа {srch} в массиве {SearchElementByValue(newArray, srch)[0]},{SearchElementByValue(newArray, srch)[1]}");
*/

//----------------------------------Exercise #52------------------------------
/*
Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[] AvrgColumn(double[,] mas)
{
    double[] result = new double[mas.GetLength(1)];
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            result[j] += mas[i, j];
        }
        result[j] = Math.Round(result[j] / mas.GetLength(0), 2);

    }
    return result;
}

System.Console.WriteLine($"Таблица средних арифметических столбцов массива: \n {String.Join("\t|", AvrgColumn(newArray))}");