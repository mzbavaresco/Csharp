using System;

namespace _6_CsharpOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cliente cliente = new Cliente();
            cliente.Nome = "asd";
            Console.WriteLine(cliente.Nome);
        }
    }
}
