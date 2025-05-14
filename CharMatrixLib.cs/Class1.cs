//Yurii Murai B-121-24-3-PI Yurii Murai
using System;

namespace CharMatrixLibrary
{
    public class CharMatrix
    {
        private char[,] matrix;
        private int size;
        private int vowelCount;

        public CharMatrix(int n)
        {
            size = n;
            matrix = new char[size, size];
            FillMatrix();
            CalculateVowels();
        }

        
        private void FillMatrix()
        {
            Console.WriteLine("Введіть символи для матриці розміром {0}x{0}:", size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
            }
        }

        
        public string this[int diagonal]
        {
            get
            {
                if (diagonal != 0 && diagonal != 1)
                    throw new ArgumentException("Діагональ має бути 0 або 1");

                string result = "";
                for (int i = 0; i < size; i++)
                {
                    if (diagonal == 0)
                        result += matrix[i, i];
                    else
                        result += matrix[i, size - 1 - i];
                }
                return result;
            }
        }

        public int VowelCount
        {
            get { return vowelCount; }
        }

        private void CalculateVowels()
        {
            vowelCount = 0;
            char[] vowels = {
                'a', 'e', 'i', 'o', 'u', 'y',
                'A', 'E', 'I', 'O', 'U', 'Y',
                'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я',
                'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я'
            };

            foreach (char c in matrix)
            {
                if (Array.Exists(vowels, v => v == c))
                    vowelCount++;
            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine("\nМатриця:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
//Yurii Murai//