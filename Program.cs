//----------------------------------Exercise #47------------------------------
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
//----------------------------------SOLUTION-----------------------------------

double[,] FillMasReal(int n, int m)
{
    int y = 0;
    double[,] mas = new double[n, m];
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {

            mas[i, j] = y;
            y++;


        }

    }

    return mas;
}
System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] newArray = FillMasReal(n, m);

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}
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
//----------------------------------SOLUTION-----------------------------------

/*
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
*/
//----------------------------------HARD SORT------------------------------
/*Задача HARD SORT.
Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
Например, задан массив:
1 4 7 2
5 9 10 3
После сортировки
1 2 3 4
5 7 9 10 */
//----------------------------------SOLUTION-----------------------------------
/*

double[,] Sort(double[,] mas)
{
    double[] mutateInOne = new double[mas.GetLength(0) * mas.GetLength(1)];
    int i = 0;
    foreach (var item in mas)
    {
        mutateInOne[i] = item;
        i++;
    }
    double[] sortedMutateInOne = qSort(mutateInOne, 0, mutateInOne.Length - 1);

    double[,] result = new double[mas.GetLength(0), mas.GetLength(1)];
    System.Console.WriteLine(String.Join("|", sortedMutateInOne)); ;
    System.Console.WriteLine("_____________________________________");

    int n = 0;
    for (int j = 0; j < result.GetLength(0); j++)
    {
        for (int k = 0; k < result.GetLength(1); k++)
        {

            {
                result[j, k] = sortedMutateInOne[n];
                n++;
            }

        }
    }


    return result;
}
double[] qSort(double[] mass, int minIndx, int maxIndx)
{
    if (minIndx >= maxIndx) return mass;

    int addIndx = addINDEX(mass, minIndx, maxIndx);
    qSort(mass, minIndx, addIndx - 1);
    qSort(mass, addIndx + 1, maxIndx);
    return mass;

}
int addINDEX(double[] mass, int minIndx, int maxIndx)
{
    int add = minIndx - 1;
    for (int i = minIndx; i <= maxIndx; i++)
    {
        if (mass[i] < mass[maxIndx])
        {
            add++;
            Swap(ref mass[add], ref mass[i]);

        }

    }
    add++;
    Swap(ref mass[add], ref mass[maxIndx]);

    return add;
}
void Swap(ref double leftItem, ref double rightItem)
{
    double temp = leftItem;

    leftItem = rightItem;

    rightItem = temp;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}
PrintArray(newArray);
System.Console.WriteLine("_____________________________________");
PrintArray(Sort(newArray));
*/

//----------------------------------HARD  2------------------------------
/*задача 2 HARD необязательная.
Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. 
Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место (возможно для этого удобно будет использование множества) 
и выполнить это за m*n / 2 итераций. 
То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.*/
//----------------------------------SOLUTION-----------------------------------
void Swap(ref double leftItem, ref double rightItem) // меняет местами элементы по заданному адресу
{
    double temp = leftItem;

    leftItem = rightItem;

    rightItem = temp;
}

double[,] RndMas(double[,] mas)         // сама функция смешения 
{
    int n = mas.GetLength(0);
    int m = mas.GetLength(1);
    bool[,] ignore = new bool[n, m];
    int k = new Random().Next(0, n);
    int r = new Random().Next(0, m);
    int k1 = new Random().Next(0, n);
    int r1 = new Random().Next(0, m);
    for (int i = 0; i < 100 * n * m / 2; i++)
    {
        int[] ignoreArr = findIgnore(ignore, k, r, k1, r1);
        Swap(ref mas[ignoreArr[0], ignoreArr[1]], ref mas[ignoreArr[2], ignoreArr[3]]);
        ignore[k, r] = true;
    }
    return mas;
}
int[] findIgnore(bool[,] mas, int k, int r, int k1, int r1) // функция для поиска доступных индексов
{
    int[] result = new int[4];
    while (mas[k, r] || mas[k1, r1])
    {
        k = new Random().Next(0, mas.GetLength(0));
        r = new Random().Next(0, mas.GetLength(1));
    }
    result[0] = k; result[1] = r;
    result[2] = k1; result[3] = r1;
    return result;
}
PrintArray(newArray);
System.Console.WriteLine("_____________");
PrintArray(RndMas(newArray));