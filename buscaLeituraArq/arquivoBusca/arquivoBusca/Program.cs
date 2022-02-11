using System;

namespace MatrizCSharp
{
   
    class Program
    {
        

        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            Console.WriteLine("Ola mundo!");

            OperacoesMatriz operacaoMatriz = new OperacoesMatriz();
            matriz=operacaoMatriz.InicializaMatriz(matriz);
            operacaoMatriz.EscreveMatriz(matriz);
            Console.ReadKey();
            Menu menu = new Menu();
            menu.menu();
        }

       
    }
}
