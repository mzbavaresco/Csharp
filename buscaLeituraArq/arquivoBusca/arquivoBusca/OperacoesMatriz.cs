using System;
using System.Collections.Generic;
using System.Text;

namespace MatrizCSharp
{
    class OperacoesMatriz
    {
        public  int[,] InicializaMatriz(int[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = 0;
                }
            }
            return matriz;
        }
        public  void EscreveMatriz(int[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t"+matriz[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
