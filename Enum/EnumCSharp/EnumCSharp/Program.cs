using System;

namespace EnumCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string scanner;
            Console.WriteLine("");
            scanner = Console.ReadLine();
            EnumMenu em = new EnumMenu();
            em.Menu(opcoesMenu.Escrever);
        
        }
        
    }
}
