using System;

namespace _2_CsharpOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Console.WriteLine("Valores default");
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
        }
    }
}
