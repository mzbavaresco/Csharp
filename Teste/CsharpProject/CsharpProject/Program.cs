using System;

namespace CsharpProject
{
    class Program
    {

        delegate int Funcao(int a, int b);
        static void Main(string[] args)
        {
            Funcao funcao = new Funcao(MaiorValor);


            int resultado = funcao(1, 3);
            Console.WriteLine("Resultado:"+resultado);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ola mundo!");
            Console.WriteLine(MaiorValor(1,2));

            Console.ReadKey();
        }



        public static int MaiorValor(int a, int b) 
        {
            if (a > b) 
            {
                return a;
            }
            
            return b;

        }
    }
}
