using System;

namespace csharpOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
             

            ContaCorrente titular2 = new ContaCorrente();
            titular2.agencia = 12039;
            Console.WriteLine(titular2.agencia);
        }
    }
}
