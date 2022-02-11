using System;

namespace writeLineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j <= i) { 
                    Console.Write("*");

                    }
                    else 
                    {
                        break;
                    }
                }
                

                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <=i  ; j++)
                {
                       
                        Console.Write("*");

                    
                    
                }


                Console.WriteLine();
            }

        }
    }
}
