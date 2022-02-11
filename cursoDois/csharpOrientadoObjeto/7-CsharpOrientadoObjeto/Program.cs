using System;

namespace _7_CsharpOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente cliente = new Cliente();
            cliente.Nome = "Gabriela";
            Console.WriteLine(cliente.Nome);
            Cliente clienteDois = new Cliente();
            clienteDois.Nome = "Gabriela Costa";
            Console.WriteLine(clienteDois.Nome);
        }
    }
}
