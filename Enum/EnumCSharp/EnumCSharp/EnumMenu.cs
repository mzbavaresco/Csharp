using System;
using System.Collections.Generic;
using System.Text;

namespace EnumCSharp
{
    public enum opcoesMenu {Escrever,Ler }
    class EnumMenu
    {



        public void Menu(opcoesMenu opcao) 
        {
            Console.WriteLine(opcao);
        }



    }
}
