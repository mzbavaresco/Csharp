using System;
using System.Collections.Generic;
using System.Text;

namespace MatrizCSharp
{
    class Menu
    {


        public void EscreverMenu()
        {
            Console.WriteLine("1-Cadastrar jogador");
            Console.WriteLine("2-Jogar");
            Console.WriteLine("3-Exibir rank geral");
            Console.WriteLine("4-Buscar por jogador cadastrado");
            Console.WriteLine("0- SAIR DO MENU");
        }



        public void menu()
        {
            int i;

            do
            {
                EscreverMenu();
                i = Convert.ToInt32( Console.ReadLine());
                switch (i)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 0: break;
                    
                }

            } while (i!=0);
        }
    }
}
