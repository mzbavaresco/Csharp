using System;
using System.Collections;
namespace ListaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("Ola mundo");
            array.Add(123456);
            array.Add(true);
            
            foreach (Object obj in array)
            {
                Console.WriteLine();
                Console.Write("   {0}", obj);
            }
        }
    }
}
