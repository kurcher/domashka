//Yurii Murai B-121-24-3-PI Yurii Murai
using System;
using CharMatrixLibrary;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть розмір квадратної матриці: ");
        int n = int.Parse(Console.ReadLine());

        CharMatrix matrix = new CharMatrix(n);
        matrix.PrintMatrix();

        Console.WriteLine("\nГоловна діагональ: " + matrix[0]);
        Console.WriteLine("Побічна діагональ: " + matrix[1]);
        Console.WriteLine("Кількість голосних: " + matrix.VowelCount);
    }
}
//Yurii Murai//