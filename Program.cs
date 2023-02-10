/*
double[,] Create2dRandomDoubleArray(int m, int n, int minValue, int maxValue){
    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return array;
}
void PrintArray(double[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(Math.Round(arr[i, j], 1) + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите переменную m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[,] newArray = Create2dRandomDoubleArray(m, n, minValue, maxValue);
PrintArray(newArray);
*/
/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
/*


int[,] Create2dRandomArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int minValue = rnd.Next(0);
    int maxValue = rnd.Next(1000);
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(1000);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t" + array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



void CheckingValueArrayElement (int[,] newArray)
{
    Console.WriteLine("Введите номер строки: ");
    int nRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int userColumn = Convert.ToInt32(Console.ReadLine());
    if(nRow <= newArray.GetLength(0) & userColumn <= newArray.GetLength(1))
    {
        Console.WriteLine($"Ваш номер " + newArray[nRow-1 , userColumn -1]);
    }
    else Console.WriteLine("Такого элемента не существует");
}
int [,] newArray = Create2dRandomArray();
Show2dArray(newArray);
CheckingValueArrayElement(newArray);
*/

int[,] Create2dRandomIntArray(int row, int column){
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(0, 10);
    return array;
}

void Print2dArray(int[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] arr){
    for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + "\t");
    Console.WriteLine();
    
}

double[] FindAverageInColumns(int[,] array){
    double[] averageArray = new double[array.GetLength(1)];
    double sum;
    for(int i = 0; i < array.GetLength(1); i++){
        sum = 0;
        for(int j = 0; j < array.GetLength(0); j++){
            sum += array[j, i];
        }
        averageArray[i] = Math.Round( (sum/array.GetLength(0)), 1);
    }
    return averageArray;
}

Console.Write("Input a rows number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a columns number: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dRandomIntArray(row, column);
Print2dArray(newArray);

double[] averageArray = FindAverageInColumns(newArray);
PrintArray(averageArray);


