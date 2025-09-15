using System;

namespace Minhabiblioteca
{
    public class Biblioteca
    {
        public static void lerMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Console.WriteLine("Entre com os dados da matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }// fim for j
            }// fim for i
        }

        public static void gerarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Random rand = new Random();
            Console.WriteLine("Gerando matriz...");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                }
            }
        }
        public static void lerMatrizDouble(double[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Console.WriteLine("Entre com os dados da matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}]:");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }// fim for j
            }// fim for i
        }
        public static void mostrarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Console.WriteLine("*** Matriz ***");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matriz[i, j] + " | ");
                }// fim for j
                Console.WriteLine();
            }// fim for i    
        }
    }
}