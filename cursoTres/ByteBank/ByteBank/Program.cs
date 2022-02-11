using System;
using System.Collections;
using System.Collections.Generic;
using ByteBank.Funcionarios;
namespace ByteBank
{
    class Program
    {
        public void CalcularBonificacao() 
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
        }
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Funcionario funcionario = new Funcionario(1000,"12345487784");
            
            funcionario.Nome = "Nome Funcionario";
            funcionario.AumentarSalario();
            Console.WriteLine(funcionario.GetBonificacao());
            Diretor diretor = new Diretor("123456789");
            
            diretor.Nome = "Diretor";
            Console.WriteLine(diretor.Nome);
            Console.WriteLine("Funcionario:" + funcionario.GetBonificacao());
            
            diretor.AumentarSalario();
            Console.WriteLine("Diretor :" + diretor.GetBonificacao());
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Console.WriteLine("FUNCIONARIO SALARIO:"+funcionario.Salario);
            Console.WriteLine("DIRETOR:"+diretor.Salario);


            Funcionario funcionarioDiretor = new Diretor("123456");
            Console.WriteLine("Funcionario:"+funcionario.Cpf);
            Console.WriteLine("Diretor: "+funcionarioDiretor.Cpf);
            
            string texto = "Ola mundo";
            Console.WriteLine("{0} olamundo {0}", texto);
            ArrayList array = new ArrayList();
            //List <string> array = new List<string>();
            //ArrayList array = new ArrayList();
             

            //Console.WriteLine(array.ToString());
            
                
        }
    }

    
}
