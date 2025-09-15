using System;
using Minhabiblioteca;
class Exercicio3
{
  
    static int getContadorOcorrencias(int[,] matriz, int valor)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int contador = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == valor)
                {
                    contador++;
                }
            }
        }
        return contador;
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
        Console.WriteLine("Entre com o valor a ser contado:");
        int valor = int.Parse(Console.ReadLine());
        int ocorrencias = getContadorOcorrencias(matriz, valor);
        Console.WriteLine($"O valor {valor} ocorre {ocorrencias} vezes na matriz.");
    }
}