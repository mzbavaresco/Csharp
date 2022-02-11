using System;


namespace olaMundoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           String HelloWorld= Console.ReadLine();
             
            String teste = "Ola mundo";
            Console.WriteLine(teste);
            if (HelloWorld.Equals(teste))
            {
                for(int i=0;i<100;i++)
                Console.WriteLine("String iguais");
            }
            else
            {
                Console.WriteLine("String diferentes");
            }
        }
    }
}
