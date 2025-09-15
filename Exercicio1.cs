using System;
using Minhabiblioteca;
class Exercicio1
{
    static int getminimo(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int menor = matriz[0, 0];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }
        return menor;
    }

    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Entre com a quantidade de linhas e colunas:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, cols];
        Minhabiblioteca.Biblioteca.gerarMatriz(matriz);
        Minhabiblioteca.Biblioteca.mostrarMatriz(matriz);
        int menor = getminimo(matriz);
        Console.WriteLine($"O menor valor da matriz é: {menor}");
    }
}