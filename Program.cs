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

            mas[i, j] = Math.Round(new Random().NextDouble()*100,2);
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
double[,] newArray =  FillMasReal(n,m);